using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;
using DevExpress.XtraWaitForm;
using VScrollBar = DevExpress.XtraEditors.VScrollBar;

namespace ModioX.Forms.Windows
{
    partial class MainWindow
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
            DevExpress.Utils.Animation.Transition transition1 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.FadeTransition fadeTransition1 = new DevExpress.Utils.Animation.FadeTransition();
            DevExpress.Utils.Animation.Transition transition2 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.FadeTransition fadeTransition2 = new DevExpress.Utils.Animation.FadeTransition();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement16 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement17 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement18 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement19 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement20 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement21 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement22 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement23 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement24 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement25 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement26 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement27 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement28 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement29 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement30 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement31 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement32 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement33 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement34 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement35 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement36 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement37 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement38 = new DevExpress.XtraEditors.TileItemElement();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.MainMenu = new DevExpress.XtraBars.BarManager(this.components);
            this.BarStatus = new DevExpress.XtraBars.Bar();
            this.StatusLabelHeaderConnectedConsole = new DevExpress.XtraBars.BarStaticItem();
            this.StatusLabelConnectedConsole = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.MenuItemTools = new DevExpress.XtraBars.BarButtonItem();
            this.MenuTools = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuItemPS3GameBackupFiles = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3GameUpdateFinder = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3PackageManager = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3ConsoleManager = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3WebManControls = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemPS3PowerFunctions = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemPS3Shutdown = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3Restart = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3SoftReboot = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3HardReboot = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3QuickReboot = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3SystemInfo = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemPS3ShowSystemInformation = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3ShowMinimumVersion = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3ShowTemperatures = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3Games = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemPS3MountBD = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3MountISO = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3MountPSN = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3UnmountGame = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3NotifyMessage = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3VirtualController = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemXboxGameLauncher = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemXboxPluginsEditor = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemXboxGameSaveResigner = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemXboxXBDMControls = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemXboxPowerFunctions = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemXboxPowerShutdown = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemXboxPowerSoftReboot = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemXboxPowerHardReboot = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemXboxSystemInfo = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemXboxShowSystemTemperatures = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemXboxNotifyMessage = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemXboxTakeScreenshot = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemHelp = new DevExpress.XtraBars.BarButtonItem();
            this.MenuHelp = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuItemSendFeedback = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemOfficialSource = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemDiscordServer = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemOpenLogFile = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemOpenLogFolder = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemCheckForUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemWhatsNew = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemAbout = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPS3 = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemConnectToPS3 = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemXbox360 = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemConnectToXBOX = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemXboxOpenCloseTray = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemGameSavesInstallFiles = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPackagesInstallFile = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemGameModsInstallFiles = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemPluginsInstallFile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemHomebrewInstallFiles = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemResourcesInstallFiles = new DevExpress.XtraBars.BarButtonItem();
            this.XNotifyText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.XNotifyType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.ButtonSkinChanger = new DevExpress.XtraBars.SkinBarSubItem();
            this.MenuConnect = new DevExpress.XtraBars.PopupMenu(this.components);
            this.LabelGameModsFilterModType = new DevExpress.XtraEditors.LabelControl();
            this.ColumnInstallationFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelGameModsFilterSystemType = new DevExpress.XtraEditors.LabelControl();
            this.PanelGameModsFilters = new System.Windows.Forms.Panel();
            this.ComboBoxGameModsFilterModType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.SeparatorGameMods = new DevExpress.XtraEditors.SeparatorControl();
            this.ComboBoxGameModsFilterCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelGameModsFilterCategory = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxGameModsFilterStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelGameModsFilterStatus = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxGameModsFilterCreator = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelGameModsFilterCreator = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxGameModsFilterVersion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelGameModsFilterVersion = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxGameModsFilterName = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxGameModsFilterRegion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ComboBoxGameModsFilterSystemType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelGameModsFilterRegion = new DevExpress.XtraEditors.LabelControl();
            this.LabelGameModsFilterName = new DevExpress.XtraEditors.LabelControl();
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
            this.ColumnModsInstalledId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledModName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledModType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledNoOfFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledUninstall = new System.Windows.Forms.DataGridViewImageColumn();
            this.GridControlGameMods = new DevExpress.XtraGrid.GridControl();
            this.GridViewGameMods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NavGroupAllGames = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupUsersGames = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupHomebrewApps = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupResources = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupLists = new DevExpress.XtraNavBar.NavBarGroup();
            this.MenuGameMods = new DevExpress.XtraBars.PopupMenu(this.components);
            this.TransitionManager = new DevExpress.Utils.Animation.TransitionManager(this.components);
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.ToolbarFormManager = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.MenuButtonConnect = new DevExpress.XtraBars.BarButtonItem();
            this.MenuButtonTools = new DevExpress.XtraBars.BarButtonItem();
            this.MenuButtonOptions = new DevExpress.XtraBars.BarButtonItem();
            this.MenuButtonHelp = new DevExpress.XtraBars.BarButtonItem();
            this.MenuButtonSubmitMods = new DevExpress.XtraBars.BarButtonItem();
            this.MenuButtonChatRoom = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemRadioGroup2 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.NavigationMenu = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.NavigationGroupDashboard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationItemDashboard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationGroupGeneral = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationItemDownloads = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationItemInstalledMods = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationItemFileManager = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationItemSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationGroupLibrary = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationItemGameMods = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationItemHomebrew = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationItemResources = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationItemPackages = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationItemPlugins = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationItemGameSaves = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NavigationItemRealTimeMods = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PanelLatestNews = new DevExpress.XtraEditors.PanelControl();
            this.ImageReloadNewsItems = new DevExpress.XtraEditors.SvgImageBox();
            this.PanelNewsItems = new DevExpress.XtraEditors.XtraScrollableControl();
            this.LabelHeaderLatestNews = new DevExpress.XtraEditors.LabelControl();
            this.PanelToolItems = new DevExpress.XtraEditors.PanelControl();
            this.TileControlTools = new DevExpress.XtraEditors.TileControl();
            this.TileGroupTools = new DevExpress.XtraEditors.TileGroup();
            this.TileItemToolsGameBackupFiles = new DevExpress.XtraEditors.TileItem();
            this.TileItemToolsGameUpdateFinder = new DevExpress.XtraEditors.TileItem();
            this.TileItemToolsPackageManager = new DevExpress.XtraEditors.TileItem();
            this.TileItemToolsConsoleManager = new DevExpress.XtraEditors.TileItem();
            this.TileItemToolsCustomizeGameRegions = new DevExpress.XtraEditors.TileItem();
            this.TileItemToolsGameLauncher = new DevExpress.XtraEditors.TileItem();
            this.TileItemToolsLaunchFileEditor = new DevExpress.XtraEditors.TileItem();
            this.TileItemToolsGameSaveResigner = new DevExpress.XtraEditors.TileItem();
            this.LabelHeaderTools = new DevExpress.XtraEditors.LabelControl();
            this.PanelChangeLog = new DevExpress.XtraEditors.PanelControl();
            this.LabelChangeLogVersion = new DevExpress.XtraEditors.LabelControl();
            this.PanelChangeLogText = new DevExpress.XtraEditors.XtraScrollableControl();
            this.LabelChangeLog = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderChangeLog = new DevExpress.XtraEditors.LabelControl();
            this.PanelAnnouncements = new DevExpress.XtraEditors.PanelControl();
            this.NoAnnouncementsItem = new ModioX.Controls.NoAnnouncementsItem();
            this.PanelAnnouncementsItems = new DevExpress.XtraEditors.XtraScrollableControl();
            this.LabelHeaderAnnouncements = new DevExpress.XtraEditors.LabelControl();
            this.PanelSetupItems = new DevExpress.XtraEditors.PanelControl();
            this.TileControlSetup = new DevExpress.XtraEditors.TileControl();
            this.TileGroupSetup = new DevExpress.XtraEditors.TileGroup();
            this.TileItemIntroductionDetails = new DevExpress.XtraEditors.TileItem();
            this.TileItemAddNewConsole = new DevExpress.XtraEditors.TileItem();
            this.TileItemScanForXboxConsoles = new DevExpress.XtraEditors.TileItem();
            this.TileItemEditConsoleProfiles = new DevExpress.XtraEditors.TileItem();
            this.TileItemStartupLibrary = new DevExpress.XtraEditors.TileItem();
            this.TileItemSetDownloadsLocation = new DevExpress.XtraEditors.TileItem();
            this.LabelHeaderSetup = new DevExpress.XtraEditors.LabelControl();
            this.PanelInstalledMods = new System.Windows.Forms.Panel();
            this.GridControlInstalledMods = new DevExpress.XtraGrid.GridControl();
            this.GridViewInstalledMods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelInstalledModsFilters = new System.Windows.Forms.Panel();
            this.ImageInstalledModsFilterTotalFilesType = new DevExpress.XtraEditors.PictureEdit();
            this.ImageInstalledModsFilterTotalFilesTypeBack = new DevExpress.XtraEditors.PictureEdit();
            this.LabelInstalledModsFilterTotalFiles = new DevExpress.XtraEditors.LabelControl();
            this.DateTimeInstalledModsFilterInstalledOn = new DevExpress.XtraEditors.DateEdit();
            this.ImageInstalledModsFilterInstalledOnType = new DevExpress.XtraEditors.PictureEdit();
            this.LabelInstalledModsFilterInstalledOn = new DevExpress.XtraEditors.LabelControl();
            this.ImageInstalledModsFilterInstalledOnTypeBack = new DevExpress.XtraEditors.PictureEdit();
            this.NumericBoxInstalledModsFilterTotalFiles = new DevExpress.XtraEditors.SpinEdit();
            this.ComboBoxInstalledModsFilterCreator = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelInstalledModsFilterCreator = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxInstalledModsFilterPlatform = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelInstalledModsFilterPlatform = new DevExpress.XtraEditors.LabelControl();
            this.SeparatorInstalledModsFilter = new DevExpress.XtraEditors.SeparatorControl();
            this.ComboBoxInstalledModsFilterCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelInstalledModsFilterCategory = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxInstalledModsFilterVersion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelInstalledModsFilterVersion = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxInstalledModsFilterName = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxInstalledModsFilterRegion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ComboBoxInstalledModsFilterType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelInstalledModsFilterGameRegion = new DevExpress.XtraEditors.LabelControl();
            this.LabelInstalledModsFilterModName = new DevExpress.XtraEditors.LabelControl();
            this.LabelInstalledModsFilterModType = new DevExpress.XtraEditors.LabelControl();
            this.PanelInstalledModsActions = new System.Windows.Forms.Panel();
            this.TileControlInstalledMods = new DevExpress.XtraEditors.TileControl();
            this.TileGroupInstalledMods = new DevExpress.XtraEditors.TileGroup();
            this.TileItemInstalledModsUninstallAllItems = new DevExpress.XtraEditors.TileItem();
            this.TileItemInstalledModsUninstallItem = new DevExpress.XtraEditors.TileItem();
            this.TileItemInstalledModsViewDetails = new DevExpress.XtraEditors.TileItem();
            this.PanelDownloads = new System.Windows.Forms.Panel();
            this.GridControlDownloads = new DevExpress.XtraGrid.GridControl();
            this.GridViewDownloads = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelFiltersDownloads = new System.Windows.Forms.Panel();
            this.ComboBoxDownloadsFilterRegion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelDownloadsFilterRegion = new DevExpress.XtraEditors.LabelControl();
            this.DateTimeDownloadsFilterDate = new DevExpress.XtraEditors.DateEdit();
            this.ImageDownloadsFilterOnType = new DevExpress.XtraEditors.PictureEdit();
            this.LabelDownloadsFilterDateTime = new DevExpress.XtraEditors.LabelControl();
            this.ImageDownloadsFilterOnTypeBack = new DevExpress.XtraEditors.PictureEdit();
            this.ComboBoxDownloadsFilterVersion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelDownloadsFilterVersion = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxDownloadsFilterModType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelDownloadsFilterModType = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxDownloadsFilterPlatform = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelDownloadsFilterPlatform = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.ComboBoxDownloadsFilterCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelDownloadsFilterCategory = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxDownloadsFilterFileName = new DevExpress.XtraEditors.TextEdit();
            this.LabelDownloadsFilterName = new DevExpress.XtraEditors.LabelControl();
            this.PanelActionsDownloads = new System.Windows.Forms.Panel();
            this.TileControlDownloads = new DevExpress.XtraEditors.TileControl();
            this.TileGroupDownloads = new DevExpress.XtraEditors.TileGroup();
            this.TileItemDownloadsOpenFolder = new DevExpress.XtraEditors.TileItem();
            this.TileItemDownloadsOpenFile = new DevExpress.XtraEditors.TileItem();
            this.TileItemDownloadsDeleteAllItems = new DevExpress.XtraEditors.TileItem();
            this.TileItemDownloadsDeleteItem = new DevExpress.XtraEditors.TileItem();
            this.TileItemDownloadsViewDetails = new DevExpress.XtraEditors.TileItem();
            this.PanelGameModsActions = new System.Windows.Forms.Panel();
            this.TileControlGameMods = new DevExpress.XtraEditors.TileControl();
            this.TileGroupGameMods = new DevExpress.XtraEditors.TileGroup();
            this.TileItemGameModsShowFavorites = new DevExpress.XtraEditors.TileItem();
            this.TileItemGameModsSortBy = new DevExpress.XtraEditors.TileItem();
            this.PanelGameMods = new System.Windows.Forms.Panel();
            this.PageGameMods = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.NavigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageDashboard = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PanelStatistics = new DevExpress.XtraEditors.PanelControl();
            this.PanelStatisticsText = new DevExpress.XtraEditors.XtraScrollableControl();
            this.LabelStatisticsLastUpdated = new DevExpress.XtraEditors.LabelControl();
            this.LabelStatisticsHeaderXbox360 = new DevExpress.XtraEditors.LabelControl();
            this.LabelStatisticsXbox360 = new DevExpress.XtraEditors.LabelControl();
            this.LabelStatisticsHeaderPlayStation3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelStatisticsPlayStation3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderStatistics = new DevExpress.XtraEditors.LabelControl();
            this.PageInstalledMods = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageDownloads = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PageFileManager = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PanelFileManager = new System.Windows.Forms.TableLayoutPanel();
            this.GroupConsoleFileExplorer = new DevExpress.XtraEditors.GroupControl();
            this.PanelFileManagerConsoleButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonFileManagerConsoleDownload = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFileManagerConsoleDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFileManagerConsoleRename = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFileManagerConsoleNewFolder = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFileManagerConsoleRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFileManagerConsoleAddToGames = new DevExpress.XtraEditors.SimpleButton();
            this.PanelFileManagerConsoleStatus = new DevExpress.Utils.Layout.StackPanel();
            this.LabelFileManagerConsoleStatus = new DevExpress.XtraEditors.LabelControl();
            this.GridControlFileManagerConsoleFiles = new DevExpress.XtraGrid.GridControl();
            this.GridViewFileManagerConsoleFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ButtonFileManagerConsoleNavigate = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxFileManagerConsolePath = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxFileManagerConsoleDrives = new DevExpress.XtraEditors.ComboBoxEdit();
            this.GroupLocalFileExplorer = new DevExpress.XtraEditors.GroupControl();
            this.PanelFileManagerLocalButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonFileManagerLocalUpload = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFileManagerLocalDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFileManagerFileLocalRename = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFileManagerLocalNewFolder = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFileManagerLocalRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFileManagerLocalOpenExplorer = new DevExpress.XtraEditors.SimpleButton();
            this.PanelFileManagerLocalStatus = new DevExpress.Utils.Layout.StackPanel();
            this.LabelFileManagerLocalStatus = new DevExpress.XtraEditors.LabelControl();
            this.GridControlFileManagerLocalFiles = new DevExpress.XtraGrid.GridControl();
            this.GridViewFileManagerLocalFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ButtonFileManagerBrowseLocalDirectory = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBoxFileManagerLocalDrives = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TextBoxFileManagerLocalPath = new DevExpress.XtraEditors.TextEdit();
            this.PageSettings = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.TabControlSettings = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageInterface = new DevExpress.XtraTab.XtraTabPage();
            this.LabelSettingsInstallResourcesToUsbDevice = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsInstallResourcesToUsbDevice = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsInstallHomebrewToUsbDevice = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsInstallHomebrewToUsbDevice = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsOtherLanguagesSoon = new DevExpress.XtraEditors.LabelControl();
            this.LabelSettingsOptionsOnlyForPS3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelSettingsAutoLoadDirectoryListings = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsAutoLoadDirectoryListings = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsEnableHardwareAcceleration = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsEnableHardwareAcceleration = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsAdvanced = new DevExpress.XtraEditors.LabelControl();
            this.LabelSettingsInstallPackagesToUsbDevice = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsInstallPackagesToUsbDevice = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsInstallGameSavesToUsbDevice = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsInstallGameSavesToUsbDevice = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsInstallModsToUsbDevice = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsInstallModsToUsbDevice = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsRememberConsolePath = new DevExpress.XtraEditors.LabelControl();
            this.LabelSettingsRememberLocalPath = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsRememberConsolePath = new DevExpress.XtraEditors.ToggleSwitch();
            this.ToggleSwitchSettingsRememberLocalPath = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsRememberGameRegions = new DevExpress.XtraEditors.LabelControl();
            this.LabelSettingsAutoDetectGameTitles = new DevExpress.XtraEditors.LabelControl();
            this.LabelSettingsAutoDetectGameRegions = new DevExpress.XtraEditors.LabelControl();
            this.LabelSettingsShowGamesFromExternalDevices = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsRememberGameRegions = new DevExpress.XtraEditors.ToggleSwitch();
            this.ToggleSwitchSettingsAutoDetectGameTitles = new DevExpress.XtraEditors.ToggleSwitch();
            this.ToggleSwitchSettingsAutoDetectGameRegions = new DevExpress.XtraEditors.ToggleSwitch();
            this.ToggleSwitchSettingsShowGamesFromExternalDevices = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsAutomation = new DevExpress.XtraEditors.LabelControl();
            this.LabelSettingsUseRelativeTimes = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsUseRelativeTimes = new DevExpress.XtraEditors.ToggleSwitch();
            this.ComboBoxSettingsLanguages = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelSettingsUseFormattedFileSizes = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsUseFormattedFileSizes = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsLanguage = new DevExpress.XtraEditors.LabelControl();
            this.LabelSettingsStartupLibrary = new DevExpress.XtraEditors.LabelControl();
            this.RadioGroupSettingsStartupLibrary = new DevExpress.XtraEditors.RadioGroup();
            this.LabelSettingsCustomization = new DevExpress.XtraEditors.LabelControl();
            this.TabPageTools = new DevExpress.XtraTab.XtraTabPage();
            this.SeparatorSettingsTools = new DevExpress.XtraEditors.SeparatorControl();
            this.LabelSettingsToolsXBOX = new DevExpress.XtraEditors.LabelControl();
            this.LabelSettingsPackagesFilePath = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxSettingsPackagesInstallPath = new DevExpress.XtraEditors.TextEdit();
            this.LabelSettingsToolsPS3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelSettingsLaunchIniFilePath = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxSettingsLaunchIniFilePath = new DevExpress.XtraEditors.TextEdit();
            this.TabPageDownloads = new DevExpress.XtraTab.XtraTabPage();
            this.ImageSettingsDownloadsFolder = new DevExpress.XtraEditors.PictureEdit();
            this.LabelSettingsDownloadLocation = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxSettingsDownloadsFolder = new DevExpress.XtraEditors.TextEdit();
            this.LabelSettingsDownloadsFolder = new DevExpress.XtraEditors.LabelControl();
            this.TabPageChatRoom = new DevExpress.XtraTab.XtraTabPage();
            this.LabelSettingsHideUnreadMessagesCount = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsHideUnreadMessagesCount = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsMuteSounds = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsMuteSounds = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsChatRoomOptions = new DevExpress.XtraEditors.LabelControl();
            this.RadioGroupSettingsChatRoom = new DevExpress.XtraEditors.RadioGroup();
            this.LabelSettingsBlockPrivateMessages = new DevExpress.XtraEditors.LabelControl();
            this.ToggleSwitchSettingsBlockPrivateMessages = new DevExpress.XtraEditors.ToggleSwitch();
            this.LabelSettingsChatRoomNotifications = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxSettingsUserName = new DevExpress.XtraEditors.TextEdit();
            this.LabelSettingsChatRoomUserName = new DevExpress.XtraEditors.LabelControl();
            this.PageGameSaves = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PanelGameSaves = new System.Windows.Forms.Panel();
            this.GridControlGameSaves = new DevExpress.XtraGrid.GridControl();
            this.GridViewGameSaves = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelGameSavesFilters = new System.Windows.Forms.Panel();
            this.ComboBoxGameSavesFilterCreator = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelGameSavesFilterCreator = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.ComboBoxGameSavesFilterCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelGameSavesFilterCategory = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxGameSavesFilterVersion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelGameSavesFilterVersion = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxGameSavesFilterName = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxGameSavesFilterRegion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelGameSavesFilterRegion = new DevExpress.XtraEditors.LabelControl();
            this.LabelGameSavesFilterName = new DevExpress.XtraEditors.LabelControl();
            this.PanelGameSavesActions = new System.Windows.Forms.Panel();
            this.TileControlGameSaves = new DevExpress.XtraEditors.TileControl();
            this.TileGroupGameSaves = new DevExpress.XtraEditors.TileGroup();
            this.TileItemGameSavesSortBy = new DevExpress.XtraEditors.TileItem();
            this.PagePlugins = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PanelPlugins = new System.Windows.Forms.Panel();
            this.GridControlPlugins = new DevExpress.XtraGrid.GridControl();
            this.GridViewPlugins = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelPluginsFilters = new System.Windows.Forms.Panel();
            this.ComboBoxPluginsFilterStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelPluginsFilterStatus = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxPluginsFilterCreator = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelPluginsFilterCreator = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.ComboBoxPluginsFilterCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxPluginsFilterVersion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelPluginsFilterVersion = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxPluginsFilterName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TileControlPlugins = new DevExpress.XtraEditors.TileControl();
            this.TileGroupPlugins = new DevExpress.XtraEditors.TileGroup();
            this.TileItemPluginsShowFavorites = new DevExpress.XtraEditors.TileItem();
            this.TileItemPluginsSortBy = new DevExpress.XtraEditors.TileItem();
            this.PagePackages = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PanelPackages = new System.Windows.Forms.Panel();
            this.GridControlPackages = new DevExpress.XtraGrid.GridControl();
            this.GridViewPackages = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelPackagesFilters = new System.Windows.Forms.Panel();
            this.ImagePackagesFilterFileSizeType = new DevExpress.XtraEditors.PictureEdit();
            this.ImagePackagesFilterFileSizeBack = new DevExpress.XtraEditors.PictureEdit();
            this.LabelPackagesFilterFileSize = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxPackagesFilterModifiedDate = new DevExpress.XtraEditors.DateEdit();
            this.ImagePackagesFilterDateType = new DevExpress.XtraEditors.PictureEdit();
            this.LabelPackagesFilterModifiedDate = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.ComboBoxPackagesFilterStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelPackagesFilterStatus = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxPackagesFilterName = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxPackagesFilterRegion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelHeaderPackagesRegion = new DevExpress.XtraEditors.LabelControl();
            this.LabelPackagesFilterName = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxFilterPackagesCategories = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelPackagesFilterCategory = new DevExpress.XtraEditors.LabelControl();
            this.ImagePackagesFilterDateTypeBack = new DevExpress.XtraEditors.PictureEdit();
            this.ComboBoxPackagesFilterFileSize = new DevExpress.XtraEditors.SpinEdit();
            this.PanelPackagesActions = new System.Windows.Forms.Panel();
            this.TileControlPackages = new DevExpress.XtraEditors.TileControl();
            this.TileGroupPackages = new DevExpress.XtraEditors.TileGroup();
            this.TileItemPackagesSortBy = new DevExpress.XtraEditors.TileItem();
            this.PageRealTimeMods = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBoxEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.separatorControl8 = new DevExpress.XtraEditors.SeparatorControl();
            this.comboBoxEdit4 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl49 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl50 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridControlMemoryOffsets = new DevExpress.XtraGrid.GridControl();
            this.GridViewMemoryOffsets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.separatorControl7 = new DevExpress.XtraEditors.SeparatorControl();
            this.ComboBoxRealTimeModsGame = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl43 = new DevExpress.XtraEditors.LabelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ButtonAttachGame = new DevExpress.XtraEditors.SimpleButton();
            this.TileControlRealTimeMods = new DevExpress.XtraEditors.TileControl();
            this.TileGroupRealTimeMods = new DevExpress.XtraEditors.TileGroup();
            this.TileItemRealTimeModsCategories = new DevExpress.XtraEditors.TileItem();
            this.TileItemRealTimeModsSort = new DevExpress.XtraEditors.TileItem();
            this.TileItemRealTimeModsImport = new DevExpress.XtraEditors.TileItem();
            this.PanelRealTimeMods = new System.Windows.Forms.Panel();
            this.GridControlRealTimeMods = new DevExpress.XtraGrid.GridControl();
            this.GridViewRealTimeMods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ComboBoxFilterRealTimeModsGameMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.separatorControl6 = new DevExpress.XtraEditors.SeparatorControl();
            this.ComboBoxFilterRealTimeModsGame = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl66 = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxFilterRealTimeModsName = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxFilterRealTimeModsCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl71 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl72 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl73 = new DevExpress.XtraEditors.LabelControl();
            this.FlyoutPanelRealTimeMods = new DevExpress.Utils.FlyoutPanel();
            this.FlyoutPanelControlRealTimeMods = new DevExpress.Utils.FlyoutPanelControl();
            this.xtraScrollableControl3 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.ImageCloseRealTimeModsInfo = new DevExpress.XtraEditors.SvgImageBox();
            this.LabelHeaderRealTimeModsDetails = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderRealTimeModsGameVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelRealTimeModsDescription = new DevExpress.XtraEditors.LabelControl();
            this.LabelRealTimeModsGameVersion = new DevExpress.XtraEditors.LabelControl();
            this.labelControl44 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl48 = new DevExpress.XtraEditors.LabelControl();
            this.LabelRealTimeModsGameTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelControl52 = new DevExpress.XtraEditors.LabelControl();
            this.LabelRealTimeModsName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl58 = new DevExpress.XtraEditors.LabelControl();
            this.LabelRealTimeModsCategory = new DevExpress.XtraEditors.LabelControl();
            this.labelControl62 = new DevExpress.XtraEditors.LabelControl();
            this.LabelRealTimeModsGameMode = new DevExpress.XtraEditors.LabelControl();
            this.stackPanel4 = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonRealTimeModsSetValue = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRealTimeModsEnable = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRealTimeModsDisable = new DevExpress.XtraEditors.SimpleButton();
            this.PageResources = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PanelResourcesResources = new System.Windows.Forms.Panel();
            this.TileControlResources = new DevExpress.XtraEditors.TileControl();
            this.TileGroupResources = new DevExpress.XtraEditors.TileGroup();
            this.TileItemResourcesShowFavorites = new DevExpress.XtraEditors.TileItem();
            this.TileItemResourcesSortBy = new DevExpress.XtraEditors.TileItem();
            this.panel16 = new System.Windows.Forms.Panel();
            this.GridControlResources = new DevExpress.XtraGrid.GridControl();
            this.GridViewResources = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelResourcesFilters = new System.Windows.Forms.Panel();
            this.ComboBoxResourcesFilterModType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.separatorControl11 = new DevExpress.XtraEditors.SeparatorControl();
            this.ComboBoxResourcesFilterCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelResourcesFilterCategory = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxResourcesFilterStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelResourcesFilterStatus = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxResourcesFilterCreator = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelResourcesFilterCreator = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxResourcesFilterVersion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelResourcesFilterVersion = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxResourcesFilterName = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxResourcesFilterSystemType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelResourcesFilterName = new DevExpress.XtraEditors.LabelControl();
            this.LabelResourcesFilterSystemType = new DevExpress.XtraEditors.LabelControl();
            this.LabelResourcesFilterModType = new DevExpress.XtraEditors.LabelControl();
            this.PageHomebrew = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.PanelHomebrewActions = new System.Windows.Forms.Panel();
            this.TileControlHomebrew = new DevExpress.XtraEditors.TileControl();
            this.TileGroupHomebrew = new DevExpress.XtraEditors.TileGroup();
            this.TileItemHomebrewShowFavorites = new DevExpress.XtraEditors.TileItem();
            this.TileItemHomebrewSortBy = new DevExpress.XtraEditors.TileItem();
            this.PanelHomebrew = new System.Windows.Forms.Panel();
            this.GridControlHomebrew = new DevExpress.XtraGrid.GridControl();
            this.GridViewHomebrew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelHomebrewFilters = new System.Windows.Forms.Panel();
            this.SeparatorHomebrew = new DevExpress.XtraEditors.SeparatorControl();
            this.ComboBoxHomebrewFilterCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelHomebrewFilterCategory = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxHomebrewFilterStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelHomebrewFilterStatus = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxHomebrewFilterCreator = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelHomebrewFilterCreator = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxHomebrewFilterVersion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelHomebrewFilterVersion = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxHomebrewFilterName = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxHomebrewFilterSystemType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelHomebrewFilterName = new DevExpress.XtraEditors.LabelControl();
            this.LabelHomebrewFilterSystemType = new DevExpress.XtraEditors.LabelControl();
            this.MenuGameSaves = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuPlugins = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuPackages = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuHomebrew = new DevExpress.XtraBars.PopupMenu(this.components);
            this.SeparatorTitle = new DevExpress.XtraEditors.SeparatorControl();
            this.SeparatorLeft = new DevExpress.XtraEditors.SeparatorControl();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.ImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.TimerLoadConsole = new System.Windows.Forms.Timer(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.separatorControl9 = new DevExpress.XtraEditors.SeparatorControl();
            this.comboBoxEdit5 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit6 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit7 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit8 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl51 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit9 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit10 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl53 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl55 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl57 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl59 = new DevExpress.XtraEditors.LabelControl();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.xtraScrollableControl4 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.labelControl60 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl61 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl63 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl64 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl65 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl67 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl68 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl69 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl70 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl74 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl75 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl76 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl77 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl78 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl79 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl80 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl81 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl82 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl83 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl84 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl85 = new DevExpress.XtraEditors.LabelControl();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dropDownButton2 = new DevExpress.XtraEditors.DropDownButton();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.MenuResources = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNotifyText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNotifyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuConnect)).BeginInit();
            this.PanelGameModsFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterModType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorGameMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterCreator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameModsFilterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterSystemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlGameMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGameMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolbarFormManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelLatestNews)).BeginInit();
            this.PanelLatestNews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageReloadNewsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelToolItems)).BeginInit();
            this.PanelToolItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelChangeLog)).BeginInit();
            this.PanelChangeLog.SuspendLayout();
            this.PanelChangeLogText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelAnnouncements)).BeginInit();
            this.PanelAnnouncements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSetupItems)).BeginInit();
            this.PanelSetupItems.SuspendLayout();
            this.PanelInstalledMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlInstalledMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInstalledMods)).BeginInit();
            this.PanelInstalledModsFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInstalledModsFilterTotalFilesType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInstalledModsFilterTotalFilesTypeBack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeInstalledModsFilterInstalledOn.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeInstalledModsFilterInstalledOn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInstalledModsFilterInstalledOnType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInstalledModsFilterInstalledOnTypeBack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBoxInstalledModsFilterTotalFiles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstalledModsFilterCreator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstalledModsFilterPlatform.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorInstalledModsFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstalledModsFilterCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstalledModsFilterVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxInstalledModsFilterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstalledModsFilterRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstalledModsFilterType.Properties)).BeginInit();
            this.PanelInstalledModsActions.SuspendLayout();
            this.PanelDownloads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDownloads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDownloads)).BeginInit();
            this.PanelFiltersDownloads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDownloadsFilterRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeDownloadsFilterDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeDownloadsFilterDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDownloadsFilterOnType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDownloadsFilterOnTypeBack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDownloadsFilterVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDownloadsFilterModType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDownloadsFilterPlatform.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDownloadsFilterCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDownloadsFilterFileName.Properties)).BeginInit();
            this.PanelActionsDownloads.SuspendLayout();
            this.PanelGameModsActions.SuspendLayout();
            this.PanelGameMods.SuspendLayout();
            this.PageGameMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationFrame)).BeginInit();
            this.NavigationFrame.SuspendLayout();
            this.PageDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelStatistics)).BeginInit();
            this.PanelStatistics.SuspendLayout();
            this.PanelStatisticsText.SuspendLayout();
            this.PageInstalledMods.SuspendLayout();
            this.PageDownloads.SuspendLayout();
            this.PageFileManager.SuspendLayout();
            this.PanelFileManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupConsoleFileExplorer)).BeginInit();
            this.GroupConsoleFileExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelFileManagerConsoleButtons)).BeginInit();
            this.PanelFileManagerConsoleButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelFileManagerConsoleStatus)).BeginInit();
            this.PanelFileManagerConsoleStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlFileManagerConsoleFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFileManagerConsoleFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileManagerConsolePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxFileManagerConsoleDrives.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupLocalFileExplorer)).BeginInit();
            this.GroupLocalFileExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelFileManagerLocalButtons)).BeginInit();
            this.PanelFileManagerLocalButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelFileManagerLocalStatus)).BeginInit();
            this.PanelFileManagerLocalStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlFileManagerLocalFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFileManagerLocalFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxFileManagerLocalDrives.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileManagerLocalPath.Properties)).BeginInit();
            this.PageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlSettings)).BeginInit();
            this.TabControlSettings.SuspendLayout();
            this.TabPageInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsInstallResourcesToUsbDevice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsAutoLoadDirectoryListings.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsEnableHardwareAcceleration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsInstallPackagesToUsbDevice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsInstallModsToUsbDevice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsRememberConsolePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsRememberLocalPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsRememberGameRegions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsAutoDetectGameTitles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsAutoDetectGameRegions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsShowGamesFromExternalDevices.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsUseRelativeTimes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSettingsLanguages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsUseFormattedFileSizes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupSettingsStartupLibrary.Properties)).BeginInit();
            this.TabPageTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorSettingsTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSettingsPackagesInstallPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSettingsLaunchIniFilePath.Properties)).BeginInit();
            this.TabPageDownloads.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSettingsDownloadsFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSettingsDownloadsFolder.Properties)).BeginInit();
            this.TabPageChatRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsHideUnreadMessagesCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsMuteSounds.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupSettingsChatRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsBlockPrivateMessages.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSettingsUserName.Properties)).BeginInit();
            this.PageGameSaves.SuspendLayout();
            this.PanelGameSaves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlGameSaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameSaves)).BeginInit();
            this.PanelGameSavesFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameSavesFilterCreator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameSavesFilterCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameSavesFilterVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameSavesFilterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameSavesFilterRegion.Properties)).BeginInit();
            this.PanelGameSavesActions.SuspendLayout();
            this.PagePlugins.SuspendLayout();
            this.PanelPlugins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlPlugins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPlugins)).BeginInit();
            this.PanelPluginsFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPluginsFilterStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPluginsFilterCreator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPluginsFilterCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPluginsFilterVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPluginsFilterName.Properties)).BeginInit();
            this.panel6.SuspendLayout();
            this.PagePackages.SuspendLayout();
            this.PanelPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPackages)).BeginInit();
            this.PanelPackagesFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePackagesFilterFileSizeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePackagesFilterFileSizeBack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPackagesFilterModifiedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPackagesFilterModifiedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePackagesFilterDateType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPackagesFilterStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPackagesFilterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPackagesFilterRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxFilterPackagesCategories.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePackagesFilterDateTypeBack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPackagesFilterFileSize.Properties)).BeginInit();
            this.PanelPackagesActions.SuspendLayout();
            this.PageRealTimeMods.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlMemoryOffsets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMemoryOffsets)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRealTimeModsGame.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            this.PanelRealTimeMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlRealTimeMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRealTimeMods)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxFilterRealTimeModsGameMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxFilterRealTimeModsGame.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFilterRealTimeModsName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxFilterRealTimeModsCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyoutPanelRealTimeMods)).BeginInit();
            this.FlyoutPanelRealTimeMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlyoutPanelControlRealTimeMods)).BeginInit();
            this.FlyoutPanelControlRealTimeMods.SuspendLayout();
            this.xtraScrollableControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCloseRealTimeModsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel4)).BeginInit();
            this.stackPanel4.SuspendLayout();
            this.PageResources.SuspendLayout();
            this.PanelResourcesResources.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewResources)).BeginInit();
            this.PanelResourcesFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxResourcesFilterModType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxResourcesFilterCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxResourcesFilterStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxResourcesFilterCreator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxResourcesFilterVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxResourcesFilterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxResourcesFilterSystemType.Properties)).BeginInit();
            this.PageHomebrew.SuspendLayout();
            this.PanelHomebrewActions.SuspendLayout();
            this.PanelHomebrew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlHomebrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHomebrew)).BeginInit();
            this.PanelHomebrewFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHomebrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxHomebrewFilterCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxHomebrewFilterStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxHomebrewFilterCreator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxHomebrewFilterVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxHomebrewFilterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxHomebrewFilterSystemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGameSaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPlugins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuHomebrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            this.xtraScrollableControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuResources)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 31);
            this.barDockControlTop.Manager = this.MainMenu;
            this.barDockControlTop.Size = new System.Drawing.Size(1528, 0);
            // 
            // MainMenu
            // 
            this.MainMenu.AllowCustomization = false;
            this.MainMenu.AllowQuickCustomization = false;
            this.MainMenu.AllowShowToolbarsPopup = false;
            this.MainMenu.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarStatus});
            this.MainMenu.DockControls.Add(this.barDockControlTop);
            this.MainMenu.DockControls.Add(this.barDockControlBottom);
            this.MainMenu.DockControls.Add(this.barDockControlLeft);
            this.MainMenu.DockControls.Add(this.barDockControlRight);
            this.MainMenu.Form = this;
            this.MainMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuItemTools,
            this.MenuItemHelp,
            this.MenuItemPS3GameBackupFiles,
            this.MenuItemPS3GameUpdateFinder,
            this.MenuItemPS3PackageManager,
            this.MenuItemDiscordServer,
            this.MenuItemOfficialSource,
            this.MenuItemOpenLogFile,
            this.MenuItemOpenLogFolder,
            this.MenuItemAbout,
            this.MenuItemWhatsNew,
            this.MenuItemCheckForUpdate,
            this.MenuItemPS3,
            this.MenuItemXbox360,
            this.MenuItemPS3WebManControls,
            this.MenuItemPS3NotifyMessage,
            this.MenuItemPS3VirtualController,
            this.MenuItemPS3PowerFunctions,
            this.MenuItemPS3Shutdown,
            this.MenuItemPS3QuickReboot,
            this.MenuItemPS3SoftReboot,
            this.StatusLabelConnectedConsole,
            this.MenuItemConnectToXBOX,
            this.MenuItemXboxXBDMControls,
            this.MenuItemXboxPowerFunctions,
            this.MenuItemXboxPowerShutdown,
            this.MenuItemXboxSystemInfo,
            this.MenuItemXboxPowerSoftReboot,
            this.MenuItemXboxPowerHardReboot,
            this.MenuItemXboxShowSystemTemperatures,
            this.StatusLabelHeaderConnectedConsole,
            this.MenuItemXboxOpenCloseTray,
            this.MenuItemXboxPluginsEditor,
            this.MenuItemXboxNotifyMessage,
            this.MenuItemPS3HardReboot,
            this.MenuItemXboxTakeScreenshot,
            this.MenuItemPS3SystemInfo,
            this.MenuItemPS3ShowMinimumVersion,
            this.MenuItemPS3ShowSystemInformation,
            this.MenuItemPS3ShowTemperatures,
            this.MenuItemPS3Games,
            this.MenuItemPS3MountBD,
            this.MenuItemPS3UnmountGame,
            this.MenuItemPS3MountISO,
            this.MenuItemPS3MountPSN,
            this.MenuItemPS3Restart,
            this.MenuItemGameSavesInstallFiles,
            this.MenuItemConnectToPS3,
            this.MenuItemXboxGameSaveResigner,
            this.MenuItemPackagesInstallFile,
            this.MenuItemGameModsInstallFiles,
            this.MenuItemPluginsInstallFile,
            this.MenuItemXboxGameLauncher,
            this.MenuItemPS3ConsoleManager,
            this.MenuItemSendFeedback,
            this.barButtonItem1,
            this.MenuItemHomebrewInstallFiles,
            this.MenuItemResourcesInstallFiles});
            this.MainMenu.MaxItemId = 143;
            this.MainMenu.OptionsLayout.AllowAddNewItems = false;
            this.MainMenu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.XNotifyText,
            this.XNotifyType,
            this.repositoryItemRadioGroup1});
            this.MainMenu.StatusBar = this.BarStatus;
            // 
            // BarStatus
            // 
            this.BarStatus.BarItemHorzIndent = 3;
            this.BarStatus.BarItemVertIndent = 5;
            this.BarStatus.BarName = "Status bar";
            this.BarStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.BarStatus.DockCol = 0;
            this.BarStatus.DockRow = 0;
            this.BarStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.BarStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.StatusLabelHeaderConnectedConsole),
            new DevExpress.XtraBars.LinkPersistInfo(this.StatusLabelConnectedConsole)});
            this.BarStatus.OptionsBar.AllowQuickCustomization = false;
            this.BarStatus.OptionsBar.DisableCustomization = true;
            this.BarStatus.OptionsBar.DrawBorder = false;
            this.BarStatus.OptionsBar.DrawDragBorder = false;
            this.BarStatus.OptionsBar.UseWholeRow = true;
            this.BarStatus.Text = "Status bar";
            // 
            // StatusLabelHeaderConnectedConsole
            // 
            this.StatusLabelHeaderConnectedConsole.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.StatusLabelHeaderConnectedConsole.Caption = "Connected Console:";
            this.StatusLabelHeaderConnectedConsole.Id = 85;
            this.StatusLabelHeaderConnectedConsole.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabelHeaderConnectedConsole.ItemAppearance.Normal.Options.UseFont = true;
            this.StatusLabelHeaderConnectedConsole.LeftIndent = 4;
            this.StatusLabelHeaderConnectedConsole.Name = "StatusLabelHeaderConnectedConsole";
            // 
            // StatusLabelConnectedConsole
            // 
            this.StatusLabelConnectedConsole.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.StatusLabelConnectedConsole.Caption = "Idle";
            this.StatusLabelConnectedConsole.Id = 54;
            this.StatusLabelConnectedConsole.Name = "StatusLabelConnectedConsole";
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 744);
            this.barDockControlBottom.Manager = this.MainMenu;
            this.barDockControlBottom.Size = new System.Drawing.Size(1528, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.MainMenu;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 713);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1528, 31);
            this.barDockControlRight.Manager = this.MainMenu;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 713);
            // 
            // MenuItemTools
            // 
            this.MenuItemTools.ActAsDropDown = true;
            this.MenuItemTools.AllowDrawArrow = false;
            this.MenuItemTools.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuItemTools.Caption = "TOOLS";
            this.MenuItemTools.DropDownControl = this.MenuTools;
            this.MenuItemTools.Id = 1;
            this.MenuItemTools.Name = "MenuItemTools";
            // 
            // MenuTools
            // 
            this.MenuTools.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3GameBackupFiles, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3GameUpdateFinder),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3PackageManager, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3ConsoleManager, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3WebManControls, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXboxGameLauncher),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXboxPluginsEditor, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXboxGameSaveResigner, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXboxXBDMControls, true)});
            this.MenuTools.Manager = this.MainMenu;
            this.MenuTools.Name = "MenuTools";
            // 
            // MenuItemPS3GameBackupFiles
            // 
            this.MenuItemPS3GameBackupFiles.Caption = "Game Backup Files...";
            this.MenuItemPS3GameBackupFiles.Id = 7;
            this.MenuItemPS3GameBackupFiles.Name = "MenuItemPS3GameBackupFiles";
            this.MenuItemPS3GameBackupFiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3GameBackupFiles_ItemClick);
            // 
            // MenuItemPS3GameUpdateFinder
            // 
            this.MenuItemPS3GameUpdateFinder.Caption = "Game Update Finder...";
            this.MenuItemPS3GameUpdateFinder.Id = 8;
            this.MenuItemPS3GameUpdateFinder.Name = "MenuItemPS3GameUpdateFinder";
            this.MenuItemPS3GameUpdateFinder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3GameUpdateFinder_ItemClick);
            // 
            // MenuItemPS3PackageManager
            // 
            this.MenuItemPS3PackageManager.Caption = "Package Manager...";
            this.MenuItemPS3PackageManager.Id = 13;
            this.MenuItemPS3PackageManager.Name = "MenuItemPS3PackageManager";
            this.MenuItemPS3PackageManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3PackageManager_ItemClick);
            // 
            // MenuItemPS3ConsoleManager
            // 
            this.MenuItemPS3ConsoleManager.Caption = "Console Manager...";
            this.MenuItemPS3ConsoleManager.Id = 138;
            this.MenuItemPS3ConsoleManager.Name = "MenuItemPS3ConsoleManager";
            this.MenuItemPS3ConsoleManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemPS3ConsoleManager_ItemClick);
            // 
            // MenuItemPS3WebManControls
            // 
            this.MenuItemPS3WebManControls.Caption = "WebMAN Controls...";
            this.MenuItemPS3WebManControls.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuItemPS3WebManControls.Id = 37;
            this.MenuItemPS3WebManControls.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3PowerFunctions),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3SystemInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3Games),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3NotifyMessage),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3VirtualController)});
            this.MenuItemPS3WebManControls.Name = "MenuItemPS3WebManControls";
            // 
            // MenuItemPS3PowerFunctions
            // 
            this.MenuItemPS3PowerFunctions.Caption = "Power Functions";
            this.MenuItemPS3PowerFunctions.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuItemPS3PowerFunctions.Id = 40;
            this.MenuItemPS3PowerFunctions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3Shutdown),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3Restart),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3SoftReboot),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3HardReboot),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3QuickReboot)});
            this.MenuItemPS3PowerFunctions.Name = "MenuItemPS3PowerFunctions";
            // 
            // MenuItemPS3Shutdown
            // 
            this.MenuItemPS3Shutdown.Caption = "Shutdown...";
            this.MenuItemPS3Shutdown.Id = 41;
            this.MenuItemPS3Shutdown.Name = "MenuItemPS3Shutdown";
            this.MenuItemPS3Shutdown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3Shutdown_ItemClick);
            // 
            // MenuItemPS3Restart
            // 
            this.MenuItemPS3Restart.Caption = "Restart...";
            this.MenuItemPS3Restart.Id = 120;
            this.MenuItemPS3Restart.Name = "MenuItemPS3Restart";
            this.MenuItemPS3Restart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3Restart_ItemClick);
            // 
            // MenuItemPS3SoftReboot
            // 
            this.MenuItemPS3SoftReboot.Caption = "Soft Reboot...";
            this.MenuItemPS3SoftReboot.Id = 43;
            this.MenuItemPS3SoftReboot.Name = "MenuItemPS3SoftReboot";
            this.MenuItemPS3SoftReboot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3SoftReboot_ItemClick);
            // 
            // MenuItemPS3HardReboot
            // 
            this.MenuItemPS3HardReboot.Caption = "Hard Reboot...";
            this.MenuItemPS3HardReboot.Id = 105;
            this.MenuItemPS3HardReboot.Name = "MenuItemPS3HardReboot";
            this.MenuItemPS3HardReboot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3HardReboot_ItemClick);
            // 
            // MenuItemPS3QuickReboot
            // 
            this.MenuItemPS3QuickReboot.Caption = "Quick Reboot...";
            this.MenuItemPS3QuickReboot.Id = 42;
            this.MenuItemPS3QuickReboot.Name = "MenuItemPS3QuickReboot";
            this.MenuItemPS3QuickReboot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3Restart_ItemClick);
            // 
            // MenuItemPS3SystemInfo
            // 
            this.MenuItemPS3SystemInfo.Caption = "System Info";
            this.MenuItemPS3SystemInfo.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuItemPS3SystemInfo.Id = 110;
            this.MenuItemPS3SystemInfo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3ShowSystemInformation),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3ShowMinimumVersion),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3ShowTemperatures)});
            this.MenuItemPS3SystemInfo.Name = "MenuItemPS3SystemInfo";
            // 
            // MenuItemPS3ShowSystemInformation
            // 
            this.MenuItemPS3ShowSystemInformation.Caption = "Show System Information...";
            this.MenuItemPS3ShowSystemInformation.Id = 112;
            this.MenuItemPS3ShowSystemInformation.Name = "MenuItemPS3ShowSystemInformation";
            this.MenuItemPS3ShowSystemInformation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3ShowSystemInformation_ItemClick);
            // 
            // MenuItemPS3ShowMinimumVersion
            // 
            this.MenuItemPS3ShowMinimumVersion.Caption = "Show Minimum Version...";
            this.MenuItemPS3ShowMinimumVersion.Id = 111;
            this.MenuItemPS3ShowMinimumVersion.Name = "MenuItemPS3ShowMinimumVersion";
            this.MenuItemPS3ShowMinimumVersion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3ShowMinimumVersion_ItemClick);
            // 
            // MenuItemPS3ShowTemperatures
            // 
            this.MenuItemPS3ShowTemperatures.Caption = "Show Temperatures...";
            this.MenuItemPS3ShowTemperatures.Id = 113;
            this.MenuItemPS3ShowTemperatures.Name = "MenuItemPS3ShowTemperatures";
            this.MenuItemPS3ShowTemperatures.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3ShowTemperatures_ItemClick);
            // 
            // MenuItemPS3Games
            // 
            this.MenuItemPS3Games.Caption = "Games";
            this.MenuItemPS3Games.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuItemPS3Games.Id = 114;
            this.MenuItemPS3Games.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3MountBD),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3MountISO),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3MountPSN),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3UnmountGame)});
            this.MenuItemPS3Games.Name = "MenuItemPS3Games";
            // 
            // MenuItemPS3MountBD
            // 
            this.MenuItemPS3MountBD.Caption = "Mount BD...";
            this.MenuItemPS3MountBD.Id = 115;
            this.MenuItemPS3MountBD.Name = "MenuItemPS3MountBD";
            this.MenuItemPS3MountBD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3MountBD_ItemClick);
            // 
            // MenuItemPS3MountISO
            // 
            this.MenuItemPS3MountISO.Caption = "Mount ISO...";
            this.MenuItemPS3MountISO.Id = 117;
            this.MenuItemPS3MountISO.Name = "MenuItemPS3MountISO";
            this.MenuItemPS3MountISO.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3MountISO_ItemClick);
            // 
            // MenuItemPS3MountPSN
            // 
            this.MenuItemPS3MountPSN.Caption = "Mount PSN...";
            this.MenuItemPS3MountPSN.Id = 118;
            this.MenuItemPS3MountPSN.Name = "MenuItemPS3MountPSN";
            this.MenuItemPS3MountPSN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3MountPSN_ItemClick);
            // 
            // MenuItemPS3UnmountGame
            // 
            this.MenuItemPS3UnmountGame.Caption = "Unmount Game...";
            this.MenuItemPS3UnmountGame.Id = 116;
            this.MenuItemPS3UnmountGame.Name = "MenuItemPS3UnmountGame";
            this.MenuItemPS3UnmountGame.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3Unmount_ItemClick);
            // 
            // MenuItemPS3NotifyMessage
            // 
            this.MenuItemPS3NotifyMessage.Caption = "Notify Message...";
            this.MenuItemPS3NotifyMessage.Id = 38;
            this.MenuItemPS3NotifyMessage.Name = "MenuItemPS3NotifyMessage";
            this.MenuItemPS3NotifyMessage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3NotifyMessage_ItemClick);
            // 
            // MenuItemPS3VirtualController
            // 
            this.MenuItemPS3VirtualController.Caption = "Virtual Controller...";
            this.MenuItemPS3VirtualController.Id = 39;
            this.MenuItemPS3VirtualController.Name = "MenuItemPS3VirtualController";
            this.MenuItemPS3VirtualController.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonPS3VirtualController_ItemClick);
            // 
            // MenuItemXboxGameLauncher
            // 
            this.MenuItemXboxGameLauncher.Caption = "Game Launcher...";
            this.MenuItemXboxGameLauncher.Id = 137;
            this.MenuItemXboxGameLauncher.Name = "MenuItemXboxGameLauncher";
            this.MenuItemXboxGameLauncher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxGameLauncher_ItemClick);
            // 
            // MenuItemXboxPluginsEditor
            // 
            this.MenuItemXboxPluginsEditor.Caption = "Plugins Editor...";
            this.MenuItemXboxPluginsEditor.Id = 102;
            this.MenuItemXboxPluginsEditor.Name = "MenuItemXboxPluginsEditor";
            this.MenuItemXboxPluginsEditor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxLaunchFileEditor_ItemClick);
            // 
            // MenuItemXboxGameSaveResigner
            // 
            this.MenuItemXboxGameSaveResigner.Caption = "Game Save Resigner...";
            this.MenuItemXboxGameSaveResigner.Id = 132;
            this.MenuItemXboxGameSaveResigner.Name = "MenuItemXboxGameSaveResigner";
            this.MenuItemXboxGameSaveResigner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxGameSaveResigner_ItemClick);
            // 
            // MenuItemXboxXBDMControls
            // 
            this.MenuItemXboxXBDMControls.Caption = "XBDM Controls...";
            this.MenuItemXboxXBDMControls.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuItemXboxXBDMControls.Id = 66;
            this.MenuItemXboxXBDMControls.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXboxPowerFunctions),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXboxSystemInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXboxNotifyMessage),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXboxTakeScreenshot)});
            this.MenuItemXboxXBDMControls.Name = "MenuItemXboxXBDMControls";
            // 
            // MenuItemXboxPowerFunctions
            // 
            this.MenuItemXboxPowerFunctions.Caption = "Power Functions";
            this.MenuItemXboxPowerFunctions.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuItemXboxPowerFunctions.Id = 67;
            this.MenuItemXboxPowerFunctions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXboxPowerShutdown),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXboxPowerSoftReboot),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXboxPowerHardReboot)});
            this.MenuItemXboxPowerFunctions.Name = "MenuItemXboxPowerFunctions";
            // 
            // MenuItemXboxPowerShutdown
            // 
            this.MenuItemXboxPowerShutdown.Caption = "Shutdown...";
            this.MenuItemXboxPowerShutdown.Id = 68;
            this.MenuItemXboxPowerShutdown.Name = "MenuItemXboxPowerShutdown";
            this.MenuItemXboxPowerShutdown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxXBDMShutdown_ItemClick);
            // 
            // MenuItemXboxPowerSoftReboot
            // 
            this.MenuItemXboxPowerSoftReboot.Caption = "Soft Reboot...";
            this.MenuItemXboxPowerSoftReboot.Id = 75;
            this.MenuItemXboxPowerSoftReboot.Name = "MenuItemXboxPowerSoftReboot";
            this.MenuItemXboxPowerSoftReboot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxXBDMSoftReboot_ItemClick);
            // 
            // MenuItemXboxPowerHardReboot
            // 
            this.MenuItemXboxPowerHardReboot.Caption = "Hard Reboot...";
            this.MenuItemXboxPowerHardReboot.Id = 76;
            this.MenuItemXboxPowerHardReboot.Name = "MenuItemXboxPowerHardReboot";
            this.MenuItemXboxPowerHardReboot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxXBDMHardReboot_ItemClick);
            // 
            // MenuItemXboxSystemInfo
            // 
            this.MenuItemXboxSystemInfo.Caption = "System Info";
            this.MenuItemXboxSystemInfo.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuItemXboxSystemInfo.Id = 70;
            this.MenuItemXboxSystemInfo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXboxShowSystemTemperatures)});
            this.MenuItemXboxSystemInfo.Name = "MenuItemXboxSystemInfo";
            // 
            // MenuItemXboxShowSystemTemperatures
            // 
            this.MenuItemXboxShowSystemTemperatures.Caption = "Show Temperatures...";
            this.MenuItemXboxShowSystemTemperatures.Id = 85;
            this.MenuItemXboxShowSystemTemperatures.Name = "MenuItemXboxShowSystemTemperatures";
            this.MenuItemXboxShowSystemTemperatures.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxShowSystemInfo_ItemClick);
            // 
            // MenuItemXboxNotifyMessage
            // 
            this.MenuItemXboxNotifyMessage.Caption = "Notify Message...";
            this.MenuItemXboxNotifyMessage.Id = 103;
            this.MenuItemXboxNotifyMessage.Name = "MenuItemXboxNotifyMessage";
            this.MenuItemXboxNotifyMessage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxXNotifyMessage_ItemClick);
            // 
            // MenuItemXboxTakeScreenshot
            // 
            this.MenuItemXboxTakeScreenshot.Caption = "Take Screenshot...";
            this.MenuItemXboxTakeScreenshot.Id = 108;
            this.MenuItemXboxTakeScreenshot.Name = "MenuItemXboxTakeScreenshot";
            this.MenuItemXboxTakeScreenshot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonXboxTakeScreenshot_ItemClick);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.ActAsDropDown = true;
            this.MenuItemHelp.AllowDrawArrow = false;
            this.MenuItemHelp.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuItemHelp.Caption = "HELP";
            this.MenuItemHelp.DropDownControl = this.MenuHelp;
            this.MenuItemHelp.Id = 4;
            this.MenuItemHelp.Name = "MenuItemHelp";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemSendFeedback),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemOfficialSource, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemDiscordServer),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemOpenLogFile, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemOpenLogFolder),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemCheckForUpdate, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemWhatsNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemAbout, true)});
            this.MenuHelp.Manager = this.MainMenu;
            this.MenuHelp.Name = "MenuHelp";
            // 
            // MenuItemSendFeedback
            // 
            this.MenuItemSendFeedback.Caption = "Send Feedback...";
            this.MenuItemSendFeedback.Id = 139;
            this.MenuItemSendFeedback.Name = "MenuItemSendFeedback";
            this.MenuItemSendFeedback.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemSendFeedback_ItemClick);
            // 
            // MenuItemOfficialSource
            // 
            this.MenuItemOfficialSource.Caption = "Official Source...";
            this.MenuItemOfficialSource.Id = 23;
            this.MenuItemOfficialSource.Name = "MenuItemOfficialSource";
            this.MenuItemOfficialSource.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonOfficialSource_ItemClick);
            // 
            // MenuItemDiscordServer
            // 
            this.MenuItemDiscordServer.Caption = "Discord Server...";
            this.MenuItemDiscordServer.Id = 22;
            this.MenuItemDiscordServer.Name = "MenuItemDiscordServer";
            this.MenuItemDiscordServer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonDiscordServer_ItemClick);
            // 
            // MenuItemOpenLogFile
            // 
            this.MenuItemOpenLogFile.Caption = "Open Log File...";
            this.MenuItemOpenLogFile.Id = 24;
            this.MenuItemOpenLogFile.Name = "MenuItemOpenLogFile";
            this.MenuItemOpenLogFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonOpenLogFile_ItemClick);
            // 
            // MenuItemOpenLogFolder
            // 
            this.MenuItemOpenLogFolder.Caption = "Open Log Folder...";
            this.MenuItemOpenLogFolder.Id = 25;
            this.MenuItemOpenLogFolder.Name = "MenuItemOpenLogFolder";
            this.MenuItemOpenLogFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonOpenLogFolder_ItemClick);
            // 
            // MenuItemCheckForUpdate
            // 
            this.MenuItemCheckForUpdate.Caption = "Check For Updates...";
            this.MenuItemCheckForUpdate.Id = 30;
            this.MenuItemCheckForUpdate.Name = "MenuItemCheckForUpdate";
            this.MenuItemCheckForUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonCheckForUpdate_ItemClick);
            // 
            // MenuItemWhatsNew
            // 
            this.MenuItemWhatsNew.Caption = "What\'s New...";
            this.MenuItemWhatsNew.Id = 29;
            this.MenuItemWhatsNew.Name = "MenuItemWhatsNew";
            this.MenuItemWhatsNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonWhatsNew_ItemClick);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Caption = "About...";
            this.MenuItemAbout.Id = 28;
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonAbout_ItemClick);
            // 
            // MenuItemPS3
            // 
            this.MenuItemPS3.Caption = "PS3";
            this.MenuItemPS3.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuItemPS3.Id = 32;
            this.MenuItemPS3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemConnectToPS3)});
            this.MenuItemPS3.Name = "MenuItemPS3";
            // 
            // MenuItemConnectToPS3
            // 
            this.MenuItemConnectToPS3.Caption = "Connect to console...";
            this.MenuItemConnectToPS3.Id = 131;
            this.MenuItemConnectToPS3.Name = "MenuItemConnectToPS3";
            this.MenuItemConnectToPS3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemConnectToPS3_ItemClick);
            // 
            // MenuItemXbox360
            // 
            this.MenuItemXbox360.Caption = "XBOX";
            this.MenuItemXbox360.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuItemXbox360.Id = 33;
            this.MenuItemXbox360.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemConnectToXBOX)});
            this.MenuItemXbox360.Name = "MenuItemXbox360";
            // 
            // MenuItemConnectToXBOX
            // 
            this.MenuItemConnectToXBOX.Caption = "Connect to console...";
            this.MenuItemConnectToXBOX.Id = 56;
            this.MenuItemConnectToXBOX.Name = "MenuItemConnectToXBOX";
            this.MenuItemConnectToXBOX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemConnectToXBOX_ItemClick);
            // 
            // MenuItemXboxOpenCloseTray
            // 
            this.MenuItemXboxOpenCloseTray.Caption = "Open/Close Tray";
            this.MenuItemXboxOpenCloseTray.Id = 91;
            this.MenuItemXboxOpenCloseTray.Name = "MenuItemXboxOpenCloseTray";
            // 
            // MenuItemGameSavesInstallFiles
            // 
            this.MenuItemGameSavesInstallFiles.Caption = "Install Files...";
            this.MenuItemGameSavesInstallFiles.Id = 129;
            this.MenuItemGameSavesInstallFiles.Name = "MenuItemGameSavesInstallFiles";
            this.MenuItemGameSavesInstallFiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemGameSavesInstallFiles_ItemClick);
            // 
            // MenuItemPackagesInstallFile
            // 
            this.MenuItemPackagesInstallFile.Caption = "Install File...";
            this.MenuItemPackagesInstallFile.Id = 133;
            this.MenuItemPackagesInstallFile.Name = "MenuItemPackagesInstallFile";
            // 
            // MenuItemGameModsInstallFiles
            // 
            this.MenuItemGameModsInstallFiles.Caption = "Install Files...";
            this.MenuItemGameModsInstallFiles.Id = 135;
            this.MenuItemGameModsInstallFiles.Name = "MenuItemGameModsInstallFiles";
            this.MenuItemGameModsInstallFiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemGameModsInstallFiles_ItemClick);
            // 
            // MenuItemPluginsInstallFile
            // 
            this.MenuItemPluginsInstallFile.Caption = "Install File...";
            this.MenuItemPluginsInstallFile.Id = 136;
            this.MenuItemPluginsInstallFile.Name = "MenuItemPluginsInstallFile";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "You Have No Lists";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 140;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // MenuItemHomebrewInstallFiles
            // 
            this.MenuItemHomebrewInstallFiles.Caption = "Install Files...";
            this.MenuItemHomebrewInstallFiles.Id = 141;
            this.MenuItemHomebrewInstallFiles.Name = "MenuItemHomebrewInstallFiles";
            this.MenuItemHomebrewInstallFiles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemHomebrewInstallFiles_ItemClick);
            // 
            // MenuItemResourcesInstallFiles
            // 
            this.MenuItemResourcesInstallFiles.Caption = "Install Files...";
            this.MenuItemResourcesInstallFiles.Id = 142;
            this.MenuItemResourcesInstallFiles.Name = "MenuItemResourcesInstallFiles";
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
            // ButtonSkinChanger
            // 
            this.ButtonSkinChanger.Caption = "Skin Changer...";
            this.ButtonSkinChanger.Id = 119;
            this.ButtonSkinChanger.Name = "ButtonSkinChanger";
            // 
            // MenuConnect
            // 
            this.MenuConnect.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuConnect.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPS3),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemXbox360)});
            this.MenuConnect.Manager = this.MainMenu;
            this.MenuConnect.Name = "MenuConnect";
            // 
            // LabelGameModsFilterModType
            // 
            this.LabelGameModsFilterModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameModsFilterModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelGameModsFilterModType.Appearance.Options.UseFont = true;
            this.LabelGameModsFilterModType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameModsFilterModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameModsFilterModType.Location = new System.Drawing.Point(738, 20);
            this.LabelGameModsFilterModType.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelGameModsFilterModType.Name = "LabelGameModsFilterModType";
            this.LabelGameModsFilterModType.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameModsFilterModType.Size = new System.Drawing.Size(61, 15);
            this.LabelGameModsFilterModType.TabIndex = 1122;
            this.LabelGameModsFilterModType.Text = "Mod Type";
            // 
            // ColumnInstallationFiles
            // 
            this.ColumnInstallationFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnInstallationFiles.HeaderText = "Installation Files";
            this.ColumnInstallationFiles.Name = "ColumnInstallationFiles";
            this.ColumnInstallationFiles.ReadOnly = true;
            this.ColumnInstallationFiles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LabelGameModsFilterSystemType
            // 
            this.LabelGameModsFilterSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameModsFilterSystemType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelGameModsFilterSystemType.Appearance.Options.UseFont = true;
            this.LabelGameModsFilterSystemType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameModsFilterSystemType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameModsFilterSystemType.Location = new System.Drawing.Point(651, 20);
            this.LabelGameModsFilterSystemType.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelGameModsFilterSystemType.Name = "LabelGameModsFilterSystemType";
            this.LabelGameModsFilterSystemType.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameModsFilterSystemType.Size = new System.Drawing.Size(77, 15);
            this.LabelGameModsFilterSystemType.TabIndex = 1156;
            this.LabelGameModsFilterSystemType.Text = "System Type";
            // 
            // PanelGameModsFilters
            // 
            this.PanelGameModsFilters.BackColor = System.Drawing.Color.Transparent;
            this.PanelGameModsFilters.Controls.Add(this.ComboBoxGameModsFilterModType);
            this.PanelGameModsFilters.Controls.Add(this.SeparatorGameMods);
            this.PanelGameModsFilters.Controls.Add(this.ComboBoxGameModsFilterCategory);
            this.PanelGameModsFilters.Controls.Add(this.LabelGameModsFilterCategory);
            this.PanelGameModsFilters.Controls.Add(this.ComboBoxGameModsFilterStatus);
            this.PanelGameModsFilters.Controls.Add(this.LabelGameModsFilterStatus);
            this.PanelGameModsFilters.Controls.Add(this.ComboBoxGameModsFilterCreator);
            this.PanelGameModsFilters.Controls.Add(this.LabelGameModsFilterCreator);
            this.PanelGameModsFilters.Controls.Add(this.ComboBoxGameModsFilterVersion);
            this.PanelGameModsFilters.Controls.Add(this.LabelGameModsFilterVersion);
            this.PanelGameModsFilters.Controls.Add(this.TextBoxGameModsFilterName);
            this.PanelGameModsFilters.Controls.Add(this.ComboBoxGameModsFilterRegion);
            this.PanelGameModsFilters.Controls.Add(this.ComboBoxGameModsFilterSystemType);
            this.PanelGameModsFilters.Controls.Add(this.LabelGameModsFilterRegion);
            this.PanelGameModsFilters.Controls.Add(this.LabelGameModsFilterName);
            this.PanelGameModsFilters.Controls.Add(this.LabelGameModsFilterSystemType);
            this.PanelGameModsFilters.Controls.Add(this.LabelGameModsFilterModType);
            this.PanelGameModsFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelGameModsFilters.Location = new System.Drawing.Point(0, 0);
            this.PanelGameModsFilters.Margin = new System.Windows.Forms.Padding(0, 4, 0, 50);
            this.PanelGameModsFilters.Name = "PanelGameModsFilters";
            this.PanelGameModsFilters.Size = new System.Drawing.Size(1251, 70);
            this.PanelGameModsFilters.TabIndex = 12;
            // 
            // ComboBoxGameModsFilterModType
            // 
            this.ComboBoxGameModsFilterModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameModsFilterModType.Location = new System.Drawing.Point(741, 40);
            this.ComboBoxGameModsFilterModType.MenuManager = this.MainMenu;
            this.ComboBoxGameModsFilterModType.Name = "ComboBoxGameModsFilterModType";
            this.ComboBoxGameModsFilterModType.Properties.AllowFocused = false;
            this.ComboBoxGameModsFilterModType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxGameModsFilterModType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameModsFilterModType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameModsFilterModType.Properties.AutoComplete = false;
            this.ComboBoxGameModsFilterModType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameModsFilterModType.Properties.DropDownRows = 12;
            this.ComboBoxGameModsFilterModType.Properties.NullValuePrompt = "Select...";
            this.ComboBoxGameModsFilterModType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameModsFilterModType.Size = new System.Drawing.Size(92, 22);
            this.ComboBoxGameModsFilterModType.TabIndex = 5;
            this.ComboBoxGameModsFilterModType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameModsFilterModType_SelectedIndexChanged);
            // 
            // SeparatorGameMods
            // 
            this.SeparatorGameMods.BackColor = System.Drawing.Color.Transparent;
            this.SeparatorGameMods.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparatorGameMods.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.SeparatorGameMods.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SeparatorGameMods.LineThickness = 3;
            this.SeparatorGameMods.Location = new System.Drawing.Point(0, 67);
            this.SeparatorGameMods.Margin = new System.Windows.Forms.Padding(0);
            this.SeparatorGameMods.Name = "SeparatorGameMods";
            this.SeparatorGameMods.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.SeparatorGameMods.Size = new System.Drawing.Size(1251, 3);
            this.SeparatorGameMods.TabIndex = 1172;
            // 
            // ComboBoxGameModsFilterCategory
            // 
            this.ComboBoxGameModsFilterCategory.Location = new System.Drawing.Point(17, 40);
            this.ComboBoxGameModsFilterCategory.MenuManager = this.MainMenu;
            this.ComboBoxGameModsFilterCategory.Name = "ComboBoxGameModsFilterCategory";
            this.ComboBoxGameModsFilterCategory.Properties.AllowFocused = false;
            this.ComboBoxGameModsFilterCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxGameModsFilterCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameModsFilterCategory.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameModsFilterCategory.Properties.AutoComplete = false;
            this.ComboBoxGameModsFilterCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameModsFilterCategory.Properties.DropDownRows = 15;
            this.ComboBoxGameModsFilterCategory.Properties.NullValuePrompt = "Select...";
            this.ComboBoxGameModsFilterCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameModsFilterCategory.Size = new System.Drawing.Size(220, 22);
            this.ComboBoxGameModsFilterCategory.TabIndex = 2;
            this.ComboBoxGameModsFilterCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameModsFilterCategory_SelectedIndexChanged);
            // 
            // LabelGameModsFilterCategory
            // 
            this.LabelGameModsFilterCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelGameModsFilterCategory.Appearance.Options.UseFont = true;
            this.LabelGameModsFilterCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameModsFilterCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameModsFilterCategory.Location = new System.Drawing.Point(15, 20);
            this.LabelGameModsFilterCategory.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelGameModsFilterCategory.Name = "LabelGameModsFilterCategory";
            this.LabelGameModsFilterCategory.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameModsFilterCategory.Size = new System.Drawing.Size(56, 15);
            this.LabelGameModsFilterCategory.TabIndex = 1171;
            this.LabelGameModsFilterCategory.Text = "Category";
            // 
            // ComboBoxGameModsFilterStatus
            // 
            this.ComboBoxGameModsFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameModsFilterStatus.Location = new System.Drawing.Point(1130, 40);
            this.ComboBoxGameModsFilterStatus.MenuManager = this.MainMenu;
            this.ComboBoxGameModsFilterStatus.Name = "ComboBoxGameModsFilterStatus";
            this.ComboBoxGameModsFilterStatus.Properties.AllowFocused = false;
            this.ComboBoxGameModsFilterStatus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxGameModsFilterStatus.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ComboBoxGameModsFilterStatus.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameModsFilterStatus.Properties.AutoComplete = false;
            this.ComboBoxGameModsFilterStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameModsFilterStatus.Properties.Items.AddRange(new object[] {
            "<All>",
            "Downloaded",
            "Not Installed",
            "Installed"});
            this.ComboBoxGameModsFilterStatus.Properties.NullValuePrompt = "Select...";
            this.ComboBoxGameModsFilterStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameModsFilterStatus.Size = new System.Drawing.Size(102, 22);
            this.ComboBoxGameModsFilterStatus.TabIndex = 9;
            this.ComboBoxGameModsFilterStatus.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameModsFilterStatus_SelectedIndexChanged);
            // 
            // LabelGameModsFilterStatus
            // 
            this.LabelGameModsFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameModsFilterStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelGameModsFilterStatus.Appearance.Options.UseFont = true;
            this.LabelGameModsFilterStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameModsFilterStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameModsFilterStatus.Location = new System.Drawing.Point(1127, 20);
            this.LabelGameModsFilterStatus.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelGameModsFilterStatus.Name = "LabelGameModsFilterStatus";
            this.LabelGameModsFilterStatus.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameModsFilterStatus.Size = new System.Drawing.Size(41, 15);
            this.LabelGameModsFilterStatus.TabIndex = 1169;
            this.LabelGameModsFilterStatus.Text = "Status";
            // 
            // ComboBoxGameModsFilterCreator
            // 
            this.ComboBoxGameModsFilterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameModsFilterCreator.Location = new System.Drawing.Point(997, 40);
            this.ComboBoxGameModsFilterCreator.MenuManager = this.MainMenu;
            this.ComboBoxGameModsFilterCreator.Name = "ComboBoxGameModsFilterCreator";
            this.ComboBoxGameModsFilterCreator.Properties.AllowFocused = false;
            this.ComboBoxGameModsFilterCreator.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxGameModsFilterCreator.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameModsFilterCreator.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameModsFilterCreator.Properties.AutoComplete = false;
            this.ComboBoxGameModsFilterCreator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameModsFilterCreator.Properties.DropDownRows = 12;
            this.ComboBoxGameModsFilterCreator.Properties.NullValuePrompt = "Select...";
            this.ComboBoxGameModsFilterCreator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameModsFilterCreator.Size = new System.Drawing.Size(127, 22);
            this.ComboBoxGameModsFilterCreator.TabIndex = 8;
            this.ComboBoxGameModsFilterCreator.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameModsFilterCreator_SelectedIndexChanged);
            // 
            // LabelGameModsFilterCreator
            // 
            this.LabelGameModsFilterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameModsFilterCreator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelGameModsFilterCreator.Appearance.Options.UseFont = true;
            this.LabelGameModsFilterCreator.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameModsFilterCreator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameModsFilterCreator.Location = new System.Drawing.Point(994, 20);
            this.LabelGameModsFilterCreator.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelGameModsFilterCreator.Name = "LabelGameModsFilterCreator";
            this.LabelGameModsFilterCreator.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameModsFilterCreator.Size = new System.Drawing.Size(48, 15);
            this.LabelGameModsFilterCreator.TabIndex = 1167;
            this.LabelGameModsFilterCreator.Text = "Creator";
            // 
            // ComboBoxGameModsFilterVersion
            // 
            this.ComboBoxGameModsFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameModsFilterVersion.Location = new System.Drawing.Point(927, 40);
            this.ComboBoxGameModsFilterVersion.MenuManager = this.MainMenu;
            this.ComboBoxGameModsFilterVersion.Name = "ComboBoxGameModsFilterVersion";
            this.ComboBoxGameModsFilterVersion.Properties.AllowFocused = false;
            this.ComboBoxGameModsFilterVersion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxGameModsFilterVersion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameModsFilterVersion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameModsFilterVersion.Properties.AutoComplete = false;
            this.ComboBoxGameModsFilterVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameModsFilterVersion.Properties.DropDownRows = 12;
            this.ComboBoxGameModsFilterVersion.Properties.NullValuePrompt = "Select...";
            this.ComboBoxGameModsFilterVersion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameModsFilterVersion.Size = new System.Drawing.Size(64, 22);
            this.ComboBoxGameModsFilterVersion.TabIndex = 7;
            this.ComboBoxGameModsFilterVersion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameModsFilterVersion_SelectedIndexChanged);
            // 
            // LabelGameModsFilterVersion
            // 
            this.LabelGameModsFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameModsFilterVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelGameModsFilterVersion.Appearance.Options.UseFont = true;
            this.LabelGameModsFilterVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameModsFilterVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameModsFilterVersion.Location = new System.Drawing.Point(924, 20);
            this.LabelGameModsFilterVersion.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelGameModsFilterVersion.Name = "LabelGameModsFilterVersion";
            this.LabelGameModsFilterVersion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameModsFilterVersion.Size = new System.Drawing.Size(48, 15);
            this.LabelGameModsFilterVersion.TabIndex = 1165;
            this.LabelGameModsFilterVersion.Text = "Version";
            // 
            // TextBoxGameModsFilterName
            // 
            this.TextBoxGameModsFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGameModsFilterName.Location = new System.Drawing.Point(243, 40);
            this.TextBoxGameModsFilterName.MenuManager = this.MainMenu;
            this.TextBoxGameModsFilterName.Name = "TextBoxGameModsFilterName";
            this.TextBoxGameModsFilterName.Properties.AllowFocused = false;
            this.TextBoxGameModsFilterName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TextBoxGameModsFilterName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxGameModsFilterName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxGameModsFilterName.Properties.NullValuePrompt = "Search...";
            this.TextBoxGameModsFilterName.Size = new System.Drawing.Size(405, 22);
            this.TextBoxGameModsFilterName.TabIndex = 3;
            this.TextBoxGameModsFilterName.EditValueChanged += new System.EventHandler(this.TextBoxFilterGameModsName_TextChanged);
            // 
            // ComboBoxGameModsFilterRegion
            // 
            this.ComboBoxGameModsFilterRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameModsFilterRegion.Location = new System.Drawing.Point(839, 40);
            this.ComboBoxGameModsFilterRegion.MenuManager = this.MainMenu;
            this.ComboBoxGameModsFilterRegion.Name = "ComboBoxGameModsFilterRegion";
            this.ComboBoxGameModsFilterRegion.Properties.AllowFocused = false;
            this.ComboBoxGameModsFilterRegion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxGameModsFilterRegion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameModsFilterRegion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameModsFilterRegion.Properties.AutoComplete = false;
            this.ComboBoxGameModsFilterRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameModsFilterRegion.Properties.DropDownRows = 12;
            this.ComboBoxGameModsFilterRegion.Properties.NullValuePrompt = "Select...";
            this.ComboBoxGameModsFilterRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameModsFilterRegion.Size = new System.Drawing.Size(82, 22);
            this.ComboBoxGameModsFilterRegion.TabIndex = 6;
            this.ComboBoxGameModsFilterRegion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameModsFilterRegion_SelectedIndexChanged);
            // 
            // ComboBoxGameModsFilterSystemType
            // 
            this.ComboBoxGameModsFilterSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameModsFilterSystemType.Location = new System.Drawing.Point(654, 40);
            this.ComboBoxGameModsFilterSystemType.MenuManager = this.MainMenu;
            this.ComboBoxGameModsFilterSystemType.Name = "ComboBoxGameModsFilterSystemType";
            this.ComboBoxGameModsFilterSystemType.Properties.AllowFocused = false;
            this.ComboBoxGameModsFilterSystemType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxGameModsFilterSystemType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameModsFilterSystemType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameModsFilterSystemType.Properties.AutoComplete = false;
            this.ComboBoxGameModsFilterSystemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameModsFilterSystemType.Properties.DropDownRows = 12;
            this.ComboBoxGameModsFilterSystemType.Properties.Items.AddRange(new object[] {
            "<All>"});
            this.ComboBoxGameModsFilterSystemType.Properties.NullValuePrompt = "Select...";
            this.ComboBoxGameModsFilterSystemType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameModsFilterSystemType.Size = new System.Drawing.Size(81, 22);
            this.ComboBoxGameModsFilterSystemType.TabIndex = 4;
            this.ComboBoxGameModsFilterSystemType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameModsFilterSystemType_SelectedIndexChanged);
            // 
            // LabelGameModsFilterRegion
            // 
            this.LabelGameModsFilterRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameModsFilterRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelGameModsFilterRegion.Appearance.Options.UseFont = true;
            this.LabelGameModsFilterRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameModsFilterRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameModsFilterRegion.Location = new System.Drawing.Point(836, 20);
            this.LabelGameModsFilterRegion.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelGameModsFilterRegion.Name = "LabelGameModsFilterRegion";
            this.LabelGameModsFilterRegion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameModsFilterRegion.Size = new System.Drawing.Size(45, 15);
            this.LabelGameModsFilterRegion.TabIndex = 1163;
            this.LabelGameModsFilterRegion.Text = "Region";
            // 
            // LabelGameModsFilterName
            // 
            this.LabelGameModsFilterName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelGameModsFilterName.Appearance.Options.UseFont = true;
            this.LabelGameModsFilterName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameModsFilterName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameModsFilterName.Location = new System.Drawing.Point(240, 20);
            this.LabelGameModsFilterName.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelGameModsFilterName.Name = "LabelGameModsFilterName";
            this.LabelGameModsFilterName.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameModsFilterName.Size = new System.Drawing.Size(39, 15);
            this.LabelGameModsFilterName.TabIndex = 1157;
            this.LabelGameModsFilterName.Text = "Name";
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
            this.ColumnModsFirmware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsFirmware.HeaderText = "System Type";
            this.ColumnModsFirmware.MinimumWidth = 6;
            this.ColumnModsFirmware.Name = "ColumnModsFirmware";
            this.ColumnModsFirmware.ReadOnly = true;
            // 
            // ColumnModsType
            // 
            this.ColumnModsType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsType.HeaderText = "Mod Type";
            this.ColumnModsType.MinimumWidth = 6;
            this.ColumnModsType.Name = "ColumnModsType";
            this.ColumnModsType.ReadOnly = true;
            // 
            // ColumnModsRegion
            // 
            this.ColumnModsRegion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsRegion.HeaderText = "Region";
            this.ColumnModsRegion.MinimumWidth = 6;
            this.ColumnModsRegion.Name = "ColumnModsRegion";
            this.ColumnModsRegion.ReadOnly = true;
            // 
            // ColumnModsVersion
            // 
            this.ColumnModsVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsVersion.HeaderText = "Version";
            this.ColumnModsVersion.MinimumWidth = 6;
            this.ColumnModsVersion.Name = "ColumnModsVersion";
            this.ColumnModsVersion.ReadOnly = true;
            // 
            // ColumnModsAuthor
            // 
            this.ColumnModsAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsAuthor.HeaderText = "Creator";
            this.ColumnModsAuthor.MinimumWidth = 124;
            this.ColumnModsAuthor.Name = "ColumnModsAuthor";
            this.ColumnModsAuthor.ReadOnly = true;
            // 
            // ColumnModsNoFiles
            // 
            this.ColumnModsNoFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsNoFiles.HeaderText = "# of Files";
            this.ColumnModsNoFiles.MinimumWidth = 6;
            this.ColumnModsNoFiles.Name = "ColumnModsNoFiles";
            this.ColumnModsNoFiles.ReadOnly = true;
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
            this.ColumnModsInstalledRegion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledRegion.HeaderText = "Region";
            this.ColumnModsInstalledRegion.MinimumWidth = 6;
            this.ColumnModsInstalledRegion.Name = "ColumnModsInstalledRegion";
            this.ColumnModsInstalledRegion.ReadOnly = true;
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
            this.ColumnModsInstalledModType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledModType.HeaderText = "Mod Type";
            this.ColumnModsInstalledModType.MinimumWidth = 6;
            this.ColumnModsInstalledModType.Name = "ColumnModsInstalledModType";
            this.ColumnModsInstalledModType.ReadOnly = true;
            // 
            // ColumnModsInstalledVersion
            // 
            this.ColumnModsInstalledVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledVersion.HeaderText = "Version";
            this.ColumnModsInstalledVersion.MinimumWidth = 6;
            this.ColumnModsInstalledVersion.Name = "ColumnModsInstalledVersion";
            this.ColumnModsInstalledVersion.ReadOnly = true;
            // 
            // ColumnModsInstalledNoOfFiles
            // 
            this.ColumnModsInstalledNoOfFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledNoOfFiles.HeaderText = "# Files";
            this.ColumnModsInstalledNoOfFiles.MinimumWidth = 6;
            this.ColumnModsInstalledNoOfFiles.Name = "ColumnModsInstalledNoOfFiles";
            this.ColumnModsInstalledNoOfFiles.ReadOnly = true;
            // 
            // ColumnModsInstalledDateTime
            // 
            this.ColumnModsInstalledDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            // GridControlGameMods
            // 
            this.GridControlGameMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlGameMods.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlGameMods.Location = new System.Drawing.Point(10, 70);
            this.GridControlGameMods.MainView = this.GridViewGameMods;
            this.GridControlGameMods.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GridControlGameMods.Name = "GridControlGameMods";
            this.GridControlGameMods.Size = new System.Drawing.Size(1231, 530);
            this.GridControlGameMods.TabIndex = 5;
            this.GridControlGameMods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewGameMods});
            // 
            // GridViewGameMods
            // 
            this.GridViewGameMods.ActiveFilterEnabled = false;
            this.GridViewGameMods.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewGameMods.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewGameMods.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewGameMods.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewGameMods.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewGameMods.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewGameMods.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.GridViewGameMods.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewGameMods.Appearance.Row.Options.UseBackColor = true;
            this.GridViewGameMods.Appearance.Row.Options.UseFont = true;
            this.GridViewGameMods.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewGameMods.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewGameMods.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewGameMods.AppearancePrint.Row.Options.UseBackColor = true;
            this.GridViewGameMods.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewGameMods.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewGameMods.GridControl = this.GridControlGameMods;
            this.GridViewGameMods.GroupRowHeight = 20;
            this.GridViewGameMods.Name = "GridViewGameMods";
            this.GridViewGameMods.OptionsBehavior.Editable = false;
            this.GridViewGameMods.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.GridViewGameMods.OptionsBehavior.ReadOnly = true;
            this.GridViewGameMods.OptionsCustomization.AllowFilter = false;
            this.GridViewGameMods.OptionsFilter.AllowFilterEditor = false;
            this.GridViewGameMods.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewGameMods.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewGameMods.OptionsView.ShowColumnHeaders = false;
            this.GridViewGameMods.OptionsView.ShowGroupPanel = false;
            this.GridViewGameMods.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewGameMods.OptionsView.ShowIndicator = false;
            this.GridViewGameMods.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewGameMods.RowHeight = 24;
            this.GridViewGameMods.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GridViewGameMods.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewGameMods_RowClick);
            this.GridViewGameMods.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GridViewGameMods_CustomDrawCell);
            this.GridViewGameMods.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.GridViewGameMods_PopupMenuShowing);
            // 
            // NavGroupAllGames
            // 
            this.NavGroupAllGames.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NavGroupAllGames.Appearance.Options.UseFont = true;
            this.NavGroupAllGames.Caption = "ALL GAMES";
            this.NavGroupAllGames.Expanded = true;
            this.NavGroupAllGames.Name = "NavGroupAllGames";
            // 
            // NavGroupUsersGames
            // 
            this.NavGroupUsersGames.Caption = "YOUR GAMES";
            this.NavGroupUsersGames.Name = "NavGroupUsersGames";
            // 
            // NavGroupHomebrewApps
            // 
            this.NavGroupHomebrewApps.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NavGroupHomebrewApps.Appearance.Options.UseFont = true;
            this.NavGroupHomebrewApps.Caption = "HOMEBREW APPLICATIONS";
            this.NavGroupHomebrewApps.Expanded = true;
            this.NavGroupHomebrewApps.Name = "NavGroupHomebrewApps";
            // 
            // NavGroupResources
            // 
            this.NavGroupResources.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NavGroupResources.Appearance.Options.UseFont = true;
            this.NavGroupResources.Caption = "RESOURCES";
            this.NavGroupResources.Expanded = true;
            this.NavGroupResources.Name = "NavGroupResources";
            // 
            // NavGroupLists
            // 
            this.NavGroupLists.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NavGroupLists.Appearance.Options.UseFont = true;
            this.NavGroupLists.Caption = "LISTS";
            this.NavGroupLists.Expanded = true;
            this.NavGroupLists.Name = "NavGroupLists";
            // 
            // MenuGameMods
            // 
            this.MenuGameMods.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuGameMods.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemGameModsInstallFiles)});
            this.MenuGameMods.Manager = this.MainMenu;
            this.MenuGameMods.Name = "MenuGameMods";
            this.MenuGameMods.BeforePopup += new System.ComponentModel.CancelEventHandler(this.MenuGameMods_BeforePopup);
            // 
            // TransitionManager
            // 
            transition1.BarWaitingIndicatorProperties.Caption = "";
            transition1.BarWaitingIndicatorProperties.Description = "";
            transition1.Control = this;
            transition1.EasingMode = DevExpress.Data.Utils.EasingMode.EaseOut;
            transition1.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.LineWaitingIndicatorProperties.Caption = "";
            transition1.LineWaitingIndicatorProperties.Description = "";
            transition1.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.RingWaitingIndicatorProperties.Caption = "";
            transition1.RingWaitingIndicatorProperties.Description = "";
            transition1.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.False;
            transition1.TransitionType = fadeTransition1;
            transition1.WaitingIndicatorProperties.Caption = "";
            transition1.WaitingIndicatorProperties.Description = "";
            transition2.BarWaitingIndicatorProperties.Caption = "";
            transition2.BarWaitingIndicatorProperties.Description = "";
            transition2.Control = this.barDockControlTop;
            transition2.EasingMode = DevExpress.Data.Utils.EasingMode.EaseInOut;
            transition2.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition2.LineWaitingIndicatorProperties.Caption = "";
            transition2.LineWaitingIndicatorProperties.Description = "";
            transition2.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition2.RingWaitingIndicatorProperties.Caption = "";
            transition2.RingWaitingIndicatorProperties.Description = "";
            transition2.TransitionType = fadeTransition2;
            transition2.WaitingIndicatorProperties.Caption = "";
            transition2.WaitingIndicatorProperties.Description = "";
            this.TransitionManager.Transitions.Add(transition1);
            this.TransitionManager.Transitions.Add(transition2);
            // 
            // toolbarFormControl1
            // 
            this.toolbarFormControl1.Location = new System.Drawing.Point(0, 0);
            this.toolbarFormControl1.Manager = this.ToolbarFormManager;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.Size = new System.Drawing.Size(1528, 31);
            this.toolbarFormControl1.TabIndex = 1184;
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.TitleItemLinks.Add(this.MenuButtonConnect, true);
            this.toolbarFormControl1.TitleItemLinks.Add(this.MenuButtonTools);
            this.toolbarFormControl1.TitleItemLinks.Add(this.MenuButtonHelp);
            this.toolbarFormControl1.TitleItemLinks.Add(this.MenuButtonSubmitMods, true);
            this.toolbarFormControl1.TitleItemLinks.Add(this.MenuButtonChatRoom);
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // ToolbarFormManager
            // 
            this.ToolbarFormManager.AllowCustomization = false;
            this.ToolbarFormManager.AllowQuickCustomization = false;
            this.ToolbarFormManager.DockControls.Add(this.barDockControl1);
            this.ToolbarFormManager.DockControls.Add(this.barDockControl2);
            this.ToolbarFormManager.DockControls.Add(this.barDockControl3);
            this.ToolbarFormManager.DockControls.Add(this.barDockControl4);
            this.ToolbarFormManager.Form = this;
            this.ToolbarFormManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuButtonConnect,
            this.MenuButtonTools,
            this.MenuButtonOptions,
            this.MenuButtonHelp,
            this.MenuButtonSubmitMods,
            this.MenuButtonChatRoom});
            this.ToolbarFormManager.MaxItemId = 10;
            this.ToolbarFormManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup2});
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 31);
            this.barDockControl1.Manager = this.ToolbarFormManager;
            this.barDockControl1.Size = new System.Drawing.Size(1528, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 769);
            this.barDockControl2.Manager = this.ToolbarFormManager;
            this.barDockControl2.Size = new System.Drawing.Size(1528, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 31);
            this.barDockControl3.Manager = this.ToolbarFormManager;
            this.barDockControl3.Size = new System.Drawing.Size(0, 738);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1528, 31);
            this.barDockControl4.Manager = this.ToolbarFormManager;
            this.barDockControl4.Size = new System.Drawing.Size(0, 738);
            // 
            // MenuButtonConnect
            // 
            this.MenuButtonConnect.ActAsDropDown = true;
            this.MenuButtonConnect.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuButtonConnect.Caption = "CONNECT";
            this.MenuButtonConnect.DropDownControl = this.MenuConnect;
            this.MenuButtonConnect.Id = 0;
            this.MenuButtonConnect.Name = "MenuButtonConnect";
            this.MenuButtonConnect.Size = new System.Drawing.Size(0, 31);
            // 
            // MenuButtonTools
            // 
            this.MenuButtonTools.ActAsDropDown = true;
            this.MenuButtonTools.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuButtonTools.Caption = "TOOLS";
            this.MenuButtonTools.DropDownControl = this.MenuTools;
            this.MenuButtonTools.Id = 1;
            this.MenuButtonTools.Name = "MenuButtonTools";
            this.MenuButtonTools.Size = new System.Drawing.Size(0, 31);
            // 
            // MenuButtonOptions
            // 
            this.MenuButtonOptions.ActAsDropDown = true;
            this.MenuButtonOptions.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuButtonOptions.Caption = "OPTIONS";
            this.MenuButtonOptions.Id = 2;
            this.MenuButtonOptions.Name = "MenuButtonOptions";
            this.MenuButtonOptions.Size = new System.Drawing.Size(0, 31);
            // 
            // MenuButtonHelp
            // 
            this.MenuButtonHelp.ActAsDropDown = true;
            this.MenuButtonHelp.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuButtonHelp.Caption = "HELP";
            this.MenuButtonHelp.DropDownControl = this.MenuHelp;
            this.MenuButtonHelp.Id = 3;
            this.MenuButtonHelp.Name = "MenuButtonHelp";
            this.MenuButtonHelp.Size = new System.Drawing.Size(0, 31);
            // 
            // MenuButtonSubmitMods
            // 
            this.MenuButtonSubmitMods.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.MenuButtonSubmitMods.Caption = "SUBMIT MODS";
            this.MenuButtonSubmitMods.Id = 5;
            this.MenuButtonSubmitMods.Name = "MenuButtonSubmitMods";
            this.MenuButtonSubmitMods.Size = new System.Drawing.Size(0, 31);
            this.MenuButtonSubmitMods.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemButtonSubmitMods_ItemClick);
            // 
            // MenuButtonChatRoom
            // 
            this.MenuButtonChatRoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.MenuButtonChatRoom.Caption = "CHAT ROOM";
            this.MenuButtonChatRoom.Id = 6;
            this.MenuButtonChatRoom.Name = "MenuButtonChatRoom";
            this.MenuButtonChatRoom.Size = new System.Drawing.Size(0, 31);
            this.MenuButtonChatRoom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuItemButtonChatRoom_ItemClick);
            // 
            // repositoryItemRadioGroup2
            // 
            this.repositoryItemRadioGroup2.Name = "repositoryItemRadioGroup2";
            // 
            // NavigationMenu
            // 
            this.NavigationMenu.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationMenu.AllowItemSelection = true;
            this.NavigationMenu.Appearance.Group.Default.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.NavigationMenu.Appearance.Group.Default.Options.UseFont = true;
            this.NavigationMenu.Appearance.Group.Default.Options.UseTextOptions = true;
            this.NavigationMenu.Appearance.Group.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationMenu.Appearance.Group.Default.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NavigationMenu.Appearance.Group.Normal.Options.UseTextOptions = true;
            this.NavigationMenu.Appearance.Group.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationMenu.Appearance.Group.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NavigationMenu.Appearance.Item.Default.Options.UseTextOptions = true;
            this.NavigationMenu.Appearance.Item.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            this.NavigationMenu.Appearance.Item.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationMenu.Appearance.Item.Hovered.Options.UseTextOptions = true;
            this.NavigationMenu.Appearance.Item.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            this.NavigationMenu.Appearance.Item.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationMenu.Appearance.Item.Normal.Options.UseTextOptions = true;
            this.NavigationMenu.Appearance.Item.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            this.NavigationMenu.Appearance.Item.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationMenu.Appearance.Item.Pressed.Options.UseTextOptions = true;
            this.NavigationMenu.Appearance.Item.Pressed.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            this.NavigationMenu.Appearance.Item.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationMenu.ChildLevelIndent = 4;
            this.NavigationMenu.DistanceBetweenRootGroups = 0;
            this.NavigationMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.NavigationGroupDashboard,
            this.NavigationGroupGeneral,
            this.NavigationGroupLibrary});
            this.NavigationMenu.ExpandGroupOnHeaderClick = false;
            this.NavigationMenu.ExpandItemOnHeaderClick = false;
            this.NavigationMenu.Location = new System.Drawing.Point(0, 32);
            this.NavigationMenu.Name = "NavigationMenu";
            this.NavigationMenu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.NavigationMenu.ShowGroupExpandButtons = false;
            this.NavigationMenu.ShowItemExpandButtons = false;
            this.NavigationMenu.Size = new System.Drawing.Size(246, 712);
            this.NavigationMenu.TabIndex = 1186;
            this.NavigationMenu.CustomDrawElement += new DevExpress.XtraBars.Navigation.CustomDrawElementEventHandler(this.NavigationMenu_CustomDrawElement);
            // 
            // NavigationGroupDashboard
            // 
            this.NavigationGroupDashboard.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationGroupDashboard.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationGroupDashboard.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationGroupDashboard.Appearance.Default.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NavigationGroupDashboard.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.NavigationItemDashboard});
            this.NavigationGroupDashboard.Expanded = true;
            this.NavigationGroupDashboard.HeaderVisible = false;
            this.NavigationGroupDashboard.Name = "NavigationGroupDashboard";
            this.NavigationGroupDashboard.Text = "Dashboard";
            // 
            // NavigationItemDashboard
            // 
            this.NavigationItemDashboard.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemDashboard.Appearance.Default.Options.UseFont = true;
            this.NavigationItemDashboard.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationItemDashboard.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemDashboard.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemDashboard.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationItemDashboard.Appearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NavigationItemDashboard.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemDashboard.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemDashboard.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemDashboard.Appearance.Normal.Options.UseFont = true;
            this.NavigationItemDashboard.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationItemDashboard.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemDashboard.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemDashboard.HeaderIndent = 10;
            this.NavigationItemDashboard.Height = 30;
            this.NavigationItemDashboard.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationItemDashboard.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.NavigationItemDashboard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NavigationItemDashboard.ImageOptions.SvgImage")));
            this.NavigationItemDashboard.Name = "NavigationItemDashboard";
            this.NavigationItemDashboard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NavigationItemDashboard.Text = "DASHBOARD";
            this.NavigationItemDashboard.Click += new System.EventHandler(this.NavigationItemDashboard_Click);
            // 
            // NavigationGroupGeneral
            // 
            this.NavigationGroupGeneral.Appearance.Default.BackColor = System.Drawing.Color.Transparent;
            this.NavigationGroupGeneral.Appearance.Default.Options.UseBackColor = true;
            this.NavigationGroupGeneral.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationGroupGeneral.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationGroupGeneral.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationGroupGeneral.Appearance.Default.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NavigationGroupGeneral.Appearance.Hovered.BackColor = System.Drawing.Color.Transparent;
            this.NavigationGroupGeneral.Appearance.Hovered.Options.UseBackColor = true;
            this.NavigationGroupGeneral.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationGroupGeneral.Appearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationGroupGeneral.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationGroupGeneral.Appearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NavigationGroupGeneral.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationGroupGeneral.Appearance.Normal.BackColor = System.Drawing.Color.Transparent;
            this.NavigationGroupGeneral.Appearance.Normal.Options.UseBackColor = true;
            this.NavigationGroupGeneral.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationGroupGeneral.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationGroupGeneral.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NavigationGroupGeneral.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationGroupGeneral.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.NavigationItemDownloads,
            this.NavigationItemInstalledMods,
            this.NavigationItemFileManager,
            this.NavigationItemSettings});
            this.NavigationGroupGeneral.Expanded = true;
            this.NavigationGroupGeneral.HeaderIndent = 0;
            this.NavigationGroupGeneral.Height = 40;
            this.NavigationGroupGeneral.Name = "NavigationGroupGeneral";
            this.NavigationGroupGeneral.Text = "GENERAL";
            // 
            // NavigationItemDownloads
            // 
            this.NavigationItemDownloads.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemDownloads.Appearance.Default.Options.UseFont = true;
            this.NavigationItemDownloads.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationItemDownloads.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemDownloads.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemDownloads.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationItemDownloads.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemDownloads.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemDownloads.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationItemDownloads.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemDownloads.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemDownloads.Appearance.Pressed.Options.UseTextOptions = true;
            this.NavigationItemDownloads.Appearance.Pressed.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            this.NavigationItemDownloads.Appearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemDownloads.HeaderIndent = 10;
            this.NavigationItemDownloads.Height = 30;
            this.NavigationItemDownloads.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationItemDownloads.ImageOptions.Image = global::ModioX.Properties.Resources.downloads;
            this.NavigationItemDownloads.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.NavigationItemDownloads.Name = "NavigationItemDownloads";
            this.NavigationItemDownloads.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NavigationItemDownloads.Text = "DOWNLOADS";
            this.NavigationItemDownloads.Click += new System.EventHandler(this.NavigationItemDownloads_Click);
            // 
            // NavigationItemInstalledMods
            // 
            this.NavigationItemInstalledMods.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemInstalledMods.Appearance.Default.Options.UseFont = true;
            this.NavigationItemInstalledMods.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationItemInstalledMods.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NavigationItemInstalledMods.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemInstalledMods.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemInstalledMods.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationItemInstalledMods.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemInstalledMods.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemInstalledMods.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationItemInstalledMods.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemInstalledMods.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemInstalledMods.Appearance.Pressed.Options.UseTextOptions = true;
            this.NavigationItemInstalledMods.Appearance.Pressed.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            this.NavigationItemInstalledMods.Appearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemInstalledMods.HeaderIndent = 10;
            this.NavigationItemInstalledMods.Height = 30;
            this.NavigationItemInstalledMods.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationItemInstalledMods.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.NavigationItemInstalledMods.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NavigationItemInstalledMods.ImageOptions.SvgImage")));
            this.NavigationItemInstalledMods.Name = "NavigationItemInstalledMods";
            this.NavigationItemInstalledMods.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NavigationItemInstalledMods.Text = "INSTALLED MODS";
            this.NavigationItemInstalledMods.Click += new System.EventHandler(this.NavigationItemInstalledMods_Click);
            // 
            // NavigationItemFileManager
            // 
            this.NavigationItemFileManager.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemFileManager.Appearance.Default.Options.UseFont = true;
            this.NavigationItemFileManager.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationItemFileManager.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemFileManager.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemFileManager.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationItemFileManager.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemFileManager.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemFileManager.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationItemFileManager.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemFileManager.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemFileManager.Appearance.Pressed.Options.UseTextOptions = true;
            this.NavigationItemFileManager.Appearance.Pressed.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            this.NavigationItemFileManager.Appearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemFileManager.HeaderIndent = 10;
            this.NavigationItemFileManager.Height = 30;
            this.NavigationItemFileManager.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationItemFileManager.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.NavigationItemFileManager.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NavigationItemFileManager.ImageOptions.SvgImage")));
            this.NavigationItemFileManager.Name = "NavigationItemFileManager";
            this.NavigationItemFileManager.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NavigationItemFileManager.Text = "FILE MANAGER";
            this.NavigationItemFileManager.Click += new System.EventHandler(this.NavigationItemFileManager_Click);
            // 
            // NavigationItemSettings
            // 
            this.NavigationItemSettings.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemSettings.Appearance.Default.Options.UseFont = true;
            this.NavigationItemSettings.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationItemSettings.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemSettings.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemSettings.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationItemSettings.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemSettings.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemSettings.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationItemSettings.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemSettings.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemSettings.Appearance.Pressed.Options.UseTextOptions = true;
            this.NavigationItemSettings.Appearance.Pressed.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            this.NavigationItemSettings.Appearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemSettings.HeaderIndent = 10;
            this.NavigationItemSettings.Height = 30;
            this.NavigationItemSettings.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationItemSettings.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.NavigationItemSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NavigationItemSettings.ImageOptions.SvgImage")));
            this.NavigationItemSettings.Name = "NavigationItemSettings";
            this.NavigationItemSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NavigationItemSettings.Text = "SETTINGS";
            this.NavigationItemSettings.Click += new System.EventHandler(this.NavigationItemSettings_Click);
            // 
            // NavigationGroupLibrary
            // 
            this.NavigationGroupLibrary.Appearance.Default.BackColor = System.Drawing.Color.Transparent;
            this.NavigationGroupLibrary.Appearance.Default.Options.UseBackColor = true;
            this.NavigationGroupLibrary.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationGroupLibrary.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationGroupLibrary.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationGroupLibrary.Appearance.Default.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NavigationGroupLibrary.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationGroupLibrary.Appearance.Hovered.BackColor = System.Drawing.Color.Transparent;
            this.NavigationGroupLibrary.Appearance.Hovered.Options.UseBackColor = true;
            this.NavigationGroupLibrary.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationGroupLibrary.Appearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationGroupLibrary.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationGroupLibrary.Appearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NavigationGroupLibrary.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationGroupLibrary.Appearance.Normal.BackColor = System.Drawing.Color.Transparent;
            this.NavigationGroupLibrary.Appearance.Normal.Options.UseBackColor = true;
            this.NavigationGroupLibrary.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationGroupLibrary.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationGroupLibrary.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.NavigationGroupLibrary.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationGroupLibrary.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.NavigationItemGameMods,
            this.NavigationItemHomebrew,
            this.NavigationItemResources,
            this.NavigationItemPackages,
            this.NavigationItemPlugins,
            this.NavigationItemGameSaves,
            this.NavigationItemRealTimeMods});
            this.NavigationGroupLibrary.Expanded = true;
            this.NavigationGroupLibrary.HeaderIndent = 0;
            this.NavigationGroupLibrary.Height = 40;
            this.NavigationGroupLibrary.Name = "NavigationGroupLibrary";
            this.NavigationGroupLibrary.Text = "LIBRARY";
            // 
            // NavigationItemGameMods
            // 
            this.NavigationItemGameMods.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemGameMods.Appearance.Default.Options.UseFont = true;
            this.NavigationItemGameMods.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationItemGameMods.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemGameMods.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemGameMods.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationItemGameMods.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemGameMods.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemGameMods.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemGameMods.Appearance.Normal.Options.UseFont = true;
            this.NavigationItemGameMods.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationItemGameMods.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemGameMods.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemGameMods.HeaderIndent = 10;
            this.NavigationItemGameMods.Height = 30;
            this.NavigationItemGameMods.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationItemGameMods.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NavigationItemGameMods.ImageOptions.Image")));
            this.NavigationItemGameMods.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.NavigationItemGameMods.Name = "NavigationItemGameMods";
            this.NavigationItemGameMods.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NavigationItemGameMods.Text = "GAME MODS";
            this.NavigationItemGameMods.Click += new System.EventHandler(this.NavigationItemGameMods_Click);
            // 
            // NavigationItemHomebrew
            // 
            this.NavigationItemHomebrew.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemHomebrew.Appearance.Default.Options.UseFont = true;
            this.NavigationItemHomebrew.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationItemHomebrew.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationItemHomebrew.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemHomebrew.Appearance.Default.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NavigationItemHomebrew.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemHomebrew.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationItemHomebrew.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemHomebrew.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemHomebrew.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemHomebrew.Appearance.Normal.Options.UseFont = true;
            this.NavigationItemHomebrew.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationItemHomebrew.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NavigationItemHomebrew.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemHomebrew.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NavigationItemHomebrew.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemHomebrew.HeaderIndent = 10;
            this.NavigationItemHomebrew.Height = 30;
            this.NavigationItemHomebrew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationItemHomebrew.ImageOptions.Image = global::ModioX.Properties.Resources.homebrew;
            this.NavigationItemHomebrew.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.NavigationItemHomebrew.Name = "NavigationItemHomebrew";
            this.NavigationItemHomebrew.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NavigationItemHomebrew.Text = "HOMEBREW";
            this.NavigationItemHomebrew.Click += new System.EventHandler(this.NavigationItemHomebrew_Click);
            // 
            // NavigationItemResources
            // 
            this.NavigationItemResources.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemResources.Appearance.Default.Options.UseFont = true;
            this.NavigationItemResources.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationItemResources.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationItemResources.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemResources.Appearance.Default.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NavigationItemResources.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemResources.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationItemResources.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemResources.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemResources.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemResources.Appearance.Normal.Options.UseFont = true;
            this.NavigationItemResources.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationItemResources.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NavigationItemResources.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemResources.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NavigationItemResources.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemResources.HeaderIndent = 10;
            this.NavigationItemResources.Height = 30;
            this.NavigationItemResources.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationItemResources.ImageOptions.Image = global::ModioX.Properties.Resources.resources;
            this.NavigationItemResources.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.NavigationItemResources.Name = "NavigationItemResources";
            this.NavigationItemResources.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NavigationItemResources.Text = "RESOURCES";
            this.NavigationItemResources.Click += new System.EventHandler(this.NavigationItemResources_Click);
            // 
            // NavigationItemPackages
            // 
            this.NavigationItemPackages.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemPackages.Appearance.Default.Options.UseFont = true;
            this.NavigationItemPackages.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationItemPackages.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationItemPackages.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemPackages.Appearance.Default.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NavigationItemPackages.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemPackages.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationItemPackages.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemPackages.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemPackages.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationItemPackages.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemPackages.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemPackages.HeaderIndent = 10;
            this.NavigationItemPackages.Height = 30;
            this.NavigationItemPackages.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationItemPackages.ImageOptions.Image = global::ModioX.Properties.Resources.packages;
            this.NavigationItemPackages.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.NavigationItemPackages.Name = "NavigationItemPackages";
            this.NavigationItemPackages.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NavigationItemPackages.Text = "PACKAGES";
            this.NavigationItemPackages.Click += new System.EventHandler(this.NavigationItemPackages_Click);
            // 
            // NavigationItemPlugins
            // 
            this.NavigationItemPlugins.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemPlugins.Appearance.Default.Options.UseFont = true;
            this.NavigationItemPlugins.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationItemPlugins.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationItemPlugins.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemPlugins.Appearance.Default.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NavigationItemPlugins.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemPlugins.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationItemPlugins.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemPlugins.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemPlugins.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemPlugins.Appearance.Normal.Options.UseFont = true;
            this.NavigationItemPlugins.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationItemPlugins.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NavigationItemPlugins.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemPlugins.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemPlugins.HeaderIndent = 10;
            this.NavigationItemPlugins.Height = 30;
            this.NavigationItemPlugins.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationItemPlugins.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NavigationItemPlugins.ImageOptions.Image")));
            this.NavigationItemPlugins.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.NavigationItemPlugins.Name = "NavigationItemPlugins";
            this.NavigationItemPlugins.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NavigationItemPlugins.Text = "PLUGINS";
            this.NavigationItemPlugins.Click += new System.EventHandler(this.NavigationItemPlugins_Click);
            // 
            // NavigationItemGameSaves
            // 
            this.NavigationItemGameSaves.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemGameSaves.Appearance.Default.Options.UseFont = true;
            this.NavigationItemGameSaves.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationItemGameSaves.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationItemGameSaves.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemGameSaves.Appearance.Default.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NavigationItemGameSaves.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemGameSaves.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationItemGameSaves.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemGameSaves.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemGameSaves.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemGameSaves.Appearance.Normal.Options.UseFont = true;
            this.NavigationItemGameSaves.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationItemGameSaves.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NavigationItemGameSaves.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemGameSaves.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NavigationItemGameSaves.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemGameSaves.HeaderIndent = 10;
            this.NavigationItemGameSaves.Height = 30;
            this.NavigationItemGameSaves.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationItemGameSaves.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.NavigationItemGameSaves.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NavigationItemGameSaves.ImageOptions.SvgImage")));
            this.NavigationItemGameSaves.Name = "NavigationItemGameSaves";
            this.NavigationItemGameSaves.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NavigationItemGameSaves.Text = "GAME SAVES";
            this.NavigationItemGameSaves.Click += new System.EventHandler(this.NavigationItemGameSaves_Click);
            // 
            // NavigationItemRealTimeMods
            // 
            this.NavigationItemRealTimeMods.Appearance.Default.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemRealTimeMods.Appearance.Default.Options.UseFont = true;
            this.NavigationItemRealTimeMods.Appearance.Default.Options.UseTextOptions = true;
            this.NavigationItemRealTimeMods.Appearance.Default.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.NavigationItemRealTimeMods.Appearance.Default.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemRealTimeMods.Appearance.Default.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NavigationItemRealTimeMods.Appearance.Default.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemRealTimeMods.Appearance.Hovered.Options.UseTextOptions = true;
            this.NavigationItemRealTimeMods.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemRealTimeMods.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemRealTimeMods.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.NavigationItemRealTimeMods.Appearance.Normal.Options.UseFont = true;
            this.NavigationItemRealTimeMods.Appearance.Normal.Options.UseTextOptions = true;
            this.NavigationItemRealTimeMods.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.NavigationItemRealTimeMods.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.NavigationItemRealTimeMods.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.NavigationItemRealTimeMods.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.NavigationItemRealTimeMods.HeaderIndent = 10;
            this.NavigationItemRealTimeMods.Height = 30;
            this.NavigationItemRealTimeMods.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationItemRealTimeMods.ImageOptions.Image = global::ModioX.Properties.Resources.world;
            this.NavigationItemRealTimeMods.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.NavigationItemRealTimeMods.Name = "NavigationItemRealTimeMods";
            this.NavigationItemRealTimeMods.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NavigationItemRealTimeMods.Text = "REAL TIME MODS";
            this.NavigationItemRealTimeMods.Click += new System.EventHandler(this.NavigationItemRealTimeMods_Click);
            // 
            // PanelLatestNews
            // 
            this.PanelLatestNews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLatestNews.Controls.Add(this.ImageReloadNewsItems);
            this.PanelLatestNews.Controls.Add(this.PanelNewsItems);
            this.PanelLatestNews.Controls.Add(this.LabelHeaderLatestNews);
            this.PanelLatestNews.Location = new System.Drawing.Point(15, 441);
            this.PanelLatestNews.Margin = new System.Windows.Forms.Padding(7);
            this.PanelLatestNews.MinimumSize = new System.Drawing.Size(530, 390);
            this.PanelLatestNews.Name = "PanelLatestNews";
            this.PanelLatestNews.Size = new System.Drawing.Size(547, 390);
            this.PanelLatestNews.TabIndex = 4;
            // 
            // ImageReloadNewsItems
            // 
            this.ImageReloadNewsItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageReloadNewsItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageReloadNewsItems.Location = new System.Drawing.Point(516, 10);
            this.ImageReloadNewsItems.Name = "ImageReloadNewsItems";
            this.ImageReloadNewsItems.Size = new System.Drawing.Size(20, 20);
            this.ImageReloadNewsItems.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageReloadNewsItems.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageReloadNewsItems.SvgImage")));
            this.ImageReloadNewsItems.TabIndex = 2;
            this.ImageReloadNewsItems.Text = "svgImageBox1";
            this.ImageReloadNewsItems.Click += new System.EventHandler(this.ImageReloadNewsItems_Click);
            // 
            // PanelNewsItems
            // 
            this.PanelNewsItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelNewsItems.Location = new System.Drawing.Point(5, 37);
            this.PanelNewsItems.Name = "PanelNewsItems";
            this.PanelNewsItems.Size = new System.Drawing.Size(537, 348);
            this.PanelNewsItems.TabIndex = 1;
            // 
            // LabelHeaderLatestNews
            // 
            this.LabelHeaderLatestNews.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderLatestNews.Appearance.Options.UseFont = true;
            this.LabelHeaderLatestNews.Location = new System.Drawing.Point(12, 10);
            this.LabelHeaderLatestNews.Name = "LabelHeaderLatestNews";
            this.LabelHeaderLatestNews.Size = new System.Drawing.Size(106, 21);
            this.LabelHeaderLatestNews.TabIndex = 0;
            this.LabelHeaderLatestNews.Text = "LATEST NEWS";
            // 
            // PanelToolItems
            // 
            this.PanelToolItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelToolItems.Controls.Add(this.TileControlTools);
            this.PanelToolItems.Controls.Add(this.LabelHeaderTools);
            this.PanelToolItems.Location = new System.Drawing.Point(15, 236);
            this.PanelToolItems.Margin = new System.Windows.Forms.Padding(3, 7, 7, 7);
            this.PanelToolItems.MinimumSize = new System.Drawing.Size(800, 191);
            this.PanelToolItems.Name = "PanelToolItems";
            this.PanelToolItems.Size = new System.Drawing.Size(817, 191);
            this.PanelToolItems.TabIndex = 2;
            // 
            // TileControlTools
            // 
            this.TileControlTools.AllowItemHover = true;
            this.TileControlTools.AllowSelectedItemBorder = false;
            this.TileControlTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TileControlTools.Groups.Add(this.TileGroupTools);
            this.TileControlTools.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TileControlTools.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            this.TileControlTools.Location = new System.Drawing.Point(7, 41);
            this.TileControlTools.MaxId = 12;
            this.TileControlTools.Name = "TileControlTools";
            this.TileControlTools.Padding = new System.Windows.Forms.Padding(14, 10, 10, 10);
            this.TileControlTools.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.TileControlTools.Size = new System.Drawing.Size(791, 139);
            this.TileControlTools.TabIndex = 2;
            this.TileControlTools.Text = "tileControl1";
            // 
            // TileGroupTools
            // 
            this.TileGroupTools.Items.Add(this.TileItemToolsGameBackupFiles);
            this.TileGroupTools.Items.Add(this.TileItemToolsGameUpdateFinder);
            this.TileGroupTools.Items.Add(this.TileItemToolsPackageManager);
            this.TileGroupTools.Items.Add(this.TileItemToolsConsoleManager);
            this.TileGroupTools.Items.Add(this.TileItemToolsCustomizeGameRegions);
            this.TileGroupTools.Items.Add(this.TileItemToolsGameLauncher);
            this.TileGroupTools.Items.Add(this.TileItemToolsLaunchFileEditor);
            this.TileGroupTools.Items.Add(this.TileItemToolsGameSaveResigner);
            this.TileGroupTools.Name = "TileGroupTools";
            // 
            // TileItemToolsGameBackupFiles
            // 
            this.TileItemToolsGameBackupFiles.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemToolsGameBackupFiles.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsGameBackupFiles.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsGameBackupFiles.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TileItemToolsGameBackupFiles.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemToolsGameBackupFiles.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.TileItemToolsGameBackupFiles.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemToolsGameBackupFiles.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemToolsGameBackupFiles.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemToolsGameBackupFiles.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemToolsGameBackupFiles.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemToolsGameBackupFiles.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement8.ImageOptions.Image = global::ModioX.Properties.Resources.backup_restore;
            tileItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement8.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement8.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement8.Text = "Backup/Restore Game Files";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemToolsGameBackupFiles.Elements.Add(tileItemElement8);
            this.TileItemToolsGameBackupFiles.Id = 0;
            this.TileItemToolsGameBackupFiles.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemToolsGameBackupFiles.Name = "TileItemToolsGameBackupFiles";
            this.TileItemToolsGameBackupFiles.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemToolsGameBackupFiles_ItemClick);
            // 
            // TileItemToolsGameUpdateFinder
            // 
            this.TileItemToolsGameUpdateFinder.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemToolsGameUpdateFinder.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsGameUpdateFinder.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsGameUpdateFinder.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TileItemToolsGameUpdateFinder.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemToolsGameUpdateFinder.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.TileItemToolsGameUpdateFinder.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemToolsGameUpdateFinder.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemToolsGameUpdateFinder.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemToolsGameUpdateFinder.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemToolsGameUpdateFinder.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemToolsGameUpdateFinder.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement9.ImageOptions.Image = global::ModioX.Properties.Resources.find_file;
            tileItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement9.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement9.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement9.Text = "Game Update Finder";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemToolsGameUpdateFinder.Elements.Add(tileItemElement9);
            this.TileItemToolsGameUpdateFinder.Id = 0;
            this.TileItemToolsGameUpdateFinder.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemToolsGameUpdateFinder.Name = "TileItemToolsGameUpdateFinder";
            this.TileItemToolsGameUpdateFinder.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemToolsGameUpdateFinder_ItemClick);
            // 
            // TileItemToolsPackageManager
            // 
            this.TileItemToolsPackageManager.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemToolsPackageManager.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsPackageManager.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsPackageManager.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TileItemToolsPackageManager.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemToolsPackageManager.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.TileItemToolsPackageManager.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemToolsPackageManager.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemToolsPackageManager.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemToolsPackageManager.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemToolsPackageManager.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemToolsPackageManager.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement10.ImageOptions.Image = global::ModioX.Properties.Resources.folder_settings;
            tileItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement10.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement10.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement10.Text = "Package File Manager";
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemToolsPackageManager.Elements.Add(tileItemElement10);
            this.TileItemToolsPackageManager.Id = 7;
            this.TileItemToolsPackageManager.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemToolsPackageManager.Name = "TileItemToolsPackageManager";
            this.TileItemToolsPackageManager.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemToolsPackageManager_ItemClick);
            // 
            // TileItemToolsConsoleManager
            // 
            this.TileItemToolsConsoleManager.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemToolsConsoleManager.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsConsoleManager.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsConsoleManager.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TileItemToolsConsoleManager.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemToolsConsoleManager.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.TileItemToolsConsoleManager.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemToolsConsoleManager.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemToolsConsoleManager.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemToolsConsoleManager.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemToolsConsoleManager.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemToolsConsoleManager.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement11.AnchorIndent = -50;
            tileItemElement11.Appearance.Normal.Options.UseTextOptions = true;
            tileItemElement11.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tileItemElement11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement11.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement11.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement11.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement11.Text = "Console Manager";
            tileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemToolsConsoleManager.Elements.Add(tileItemElement11);
            this.TileItemToolsConsoleManager.Id = 3;
            this.TileItemToolsConsoleManager.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemToolsConsoleManager.Name = "TileItemToolsConsoleManager";
            this.TileItemToolsConsoleManager.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemToolsConsoleManager_ItemClick);
            // 
            // TileItemToolsCustomizeGameRegions
            // 
            this.TileItemToolsCustomizeGameRegions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemToolsCustomizeGameRegions.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsCustomizeGameRegions.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsCustomizeGameRegions.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TileItemToolsCustomizeGameRegions.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemToolsCustomizeGameRegions.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.TileItemToolsCustomizeGameRegions.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemToolsCustomizeGameRegions.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemToolsCustomizeGameRegions.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemToolsCustomizeGameRegions.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemToolsCustomizeGameRegions.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemToolsCustomizeGameRegions.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement12.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement12.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement12.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement12.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
            tileItemElement12.Text = "Default Game Regions";
            tileItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemToolsCustomizeGameRegions.Elements.Add(tileItemElement12);
            this.TileItemToolsCustomizeGameRegions.Id = 11;
            this.TileItemToolsCustomizeGameRegions.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemToolsCustomizeGameRegions.Name = "TileItemToolsCustomizeGameRegions";
            this.TileItemToolsCustomizeGameRegions.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemToolsCustomizeGameRegions_ItemClick);
            // 
            // TileItemToolsGameLauncher
            // 
            this.TileItemToolsGameLauncher.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsGameLauncher.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsGameLauncher.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TileItemToolsGameLauncher.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemToolsGameLauncher.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.TileItemToolsGameLauncher.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemToolsGameLauncher.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemToolsGameLauncher.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemToolsGameLauncher.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemToolsGameLauncher.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemToolsGameLauncher.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement13.ImageOptions.Image = global::ModioX.Properties.Resources.game_controller;
            tileItemElement13.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement13.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement13.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement13.Text = "Games Launcher";
            tileItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemToolsGameLauncher.Elements.Add(tileItemElement13);
            this.TileItemToolsGameLauncher.Id = 9;
            this.TileItemToolsGameLauncher.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemToolsGameLauncher.Name = "TileItemToolsGameLauncher";
            this.TileItemToolsGameLauncher.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemToolsGameLauncher_ItemClick);
            // 
            // TileItemToolsLaunchFileEditor
            // 
            this.TileItemToolsLaunchFileEditor.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemToolsLaunchFileEditor.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsLaunchFileEditor.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsLaunchFileEditor.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TileItemToolsLaunchFileEditor.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemToolsLaunchFileEditor.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.TileItemToolsLaunchFileEditor.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemToolsLaunchFileEditor.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemToolsLaunchFileEditor.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemToolsLaunchFileEditor.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemToolsLaunchFileEditor.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemToolsLaunchFileEditor.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement14.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement14.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement14.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement14.ImageOptions.ImageToTextIndent = 5;
            tileItemElement14.Text = "Launch File Editor";
            tileItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemToolsLaunchFileEditor.Elements.Add(tileItemElement14);
            this.TileItemToolsLaunchFileEditor.Id = 4;
            this.TileItemToolsLaunchFileEditor.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemToolsLaunchFileEditor.Name = "TileItemToolsLaunchFileEditor";
            this.TileItemToolsLaunchFileEditor.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemToolsLaunchFileEditor_ItemClick);
            // 
            // TileItemToolsGameSaveResigner
            // 
            this.TileItemToolsGameSaveResigner.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemToolsGameSaveResigner.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsGameSaveResigner.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkOrchid;
            this.TileItemToolsGameSaveResigner.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TileItemToolsGameSaveResigner.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemToolsGameSaveResigner.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.TileItemToolsGameSaveResigner.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemToolsGameSaveResigner.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemToolsGameSaveResigner.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemToolsGameSaveResigner.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemToolsGameSaveResigner.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemToolsGameSaveResigner.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement15.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement15.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement15.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement15.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement15.ImageOptions.ImageToTextIndent = 5;
            tileItemElement15.Text = "Game Save Resigner";
            tileItemElement15.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemToolsGameSaveResigner.Elements.Add(tileItemElement15);
            this.TileItemToolsGameSaveResigner.Id = 8;
            this.TileItemToolsGameSaveResigner.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemToolsGameSaveResigner.Name = "TileItemToolsGameSaveResigner";
            this.TileItemToolsGameSaveResigner.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemToolsGameSaveResigner_ItemClick);
            // 
            // LabelHeaderTools
            // 
            this.LabelHeaderTools.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderTools.Appearance.Options.UseFont = true;
            this.LabelHeaderTools.Location = new System.Drawing.Point(12, 10);
            this.LabelHeaderTools.Name = "LabelHeaderTools";
            this.LabelHeaderTools.Size = new System.Drawing.Size(50, 21);
            this.LabelHeaderTools.TabIndex = 0;
            this.LabelHeaderTools.Text = "TOOLS";
            // 
            // PanelChangeLog
            // 
            this.PanelChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChangeLog.Controls.Add(this.LabelChangeLogVersion);
            this.PanelChangeLog.Controls.Add(this.PanelChangeLogText);
            this.PanelChangeLog.Controls.Add(this.LabelHeaderChangeLog);
            this.PanelChangeLog.Location = new System.Drawing.Point(847, 361);
            this.PanelChangeLog.Margin = new System.Windows.Forms.Padding(7, 7, 3, 7);
            this.PanelChangeLog.MinimumSize = new System.Drawing.Size(410, 358);
            this.PanelChangeLog.Name = "PanelChangeLog";
            this.PanelChangeLog.Size = new System.Drawing.Size(414, 358);
            this.PanelChangeLog.TabIndex = 3;
            // 
            // LabelChangeLogVersion
            // 
            this.LabelChangeLogVersion.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelChangeLogVersion.Appearance.Options.UseFont = true;
            this.LabelChangeLogVersion.Location = new System.Drawing.Point(12, 37);
            this.LabelChangeLogVersion.Name = "LabelChangeLogVersion";
            this.LabelChangeLogVersion.Size = new System.Drawing.Size(45, 17);
            this.LabelChangeLogVersion.TabIndex = 2;
            this.LabelChangeLogVersion.Text = "Version";
            // 
            // PanelChangeLogText
            // 
            this.PanelChangeLogText.AllowTouchScroll = true;
            this.PanelChangeLogText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChangeLogText.Controls.Add(this.LabelChangeLog);
            this.PanelChangeLogText.FireScrollEventOnMouseWheel = true;
            this.PanelChangeLogText.Location = new System.Drawing.Point(12, 60);
            this.PanelChangeLogText.MinimumSize = new System.Drawing.Size(393, 0);
            this.PanelChangeLogText.Name = "PanelChangeLogText";
            this.PanelChangeLogText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.PanelChangeLogText.Size = new System.Drawing.Size(397, 293);
            this.PanelChangeLogText.TabIndex = 1;
            // 
            // LabelChangeLog
            // 
            this.LabelChangeLog.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelChangeLog.Appearance.Options.UseFont = true;
            this.LabelChangeLog.Location = new System.Drawing.Point(0, 0);
            this.LabelChangeLog.Name = "LabelChangeLog";
            this.LabelChangeLog.Size = new System.Drawing.Size(70, 17);
            this.LabelChangeLog.TabIndex = 3;
            this.LabelChangeLog.Text = "Change Log";
            // 
            // LabelHeaderChangeLog
            // 
            this.LabelHeaderChangeLog.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderChangeLog.Appearance.Options.UseFont = true;
            this.LabelHeaderChangeLog.Location = new System.Drawing.Point(12, 10);
            this.LabelHeaderChangeLog.Name = "LabelHeaderChangeLog";
            this.LabelHeaderChangeLog.Size = new System.Drawing.Size(101, 21);
            this.LabelHeaderChangeLog.TabIndex = 0;
            this.LabelHeaderChangeLog.Text = "CHANGE LOG";
            // 
            // PanelAnnouncements
            // 
            this.PanelAnnouncements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAnnouncements.Controls.Add(this.NoAnnouncementsItem);
            this.PanelAnnouncements.Controls.Add(this.PanelAnnouncementsItems);
            this.PanelAnnouncements.Controls.Add(this.LabelHeaderAnnouncements);
            this.PanelAnnouncements.Location = new System.Drawing.Point(847, 17);
            this.PanelAnnouncements.Margin = new System.Windows.Forms.Padding(7, 3, 3, 7);
            this.PanelAnnouncements.MinimumSize = new System.Drawing.Size(410, 330);
            this.PanelAnnouncements.Name = "PanelAnnouncements";
            this.PanelAnnouncements.Size = new System.Drawing.Size(414, 330);
            this.PanelAnnouncements.TabIndex = 2;
            // 
            // NoAnnouncementsItem
            // 
            this.NoAnnouncementsItem.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.NoAnnouncementsItem.Appearance.Options.UseBackColor = true;
            this.NoAnnouncementsItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NoAnnouncementsItem.Location = new System.Drawing.Point(82, 59);
            this.NoAnnouncementsItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.NoAnnouncementsItem.Name = "NoAnnouncementsItem";
            this.NoAnnouncementsItem.Size = new System.Drawing.Size(250, 182);
            this.NoAnnouncementsItem.TabIndex = 2;
            // 
            // PanelAnnouncementsItems
            // 
            this.PanelAnnouncementsItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAnnouncementsItems.Location = new System.Drawing.Point(5, 37);
            this.PanelAnnouncementsItems.MinimumSize = new System.Drawing.Size(400, 0);
            this.PanelAnnouncementsItems.Name = "PanelAnnouncementsItems";
            this.PanelAnnouncementsItems.Size = new System.Drawing.Size(404, 288);
            this.PanelAnnouncementsItems.TabIndex = 1;
            this.PanelAnnouncementsItems.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PanelAnnouncementsItems_ControlAdded);
            this.PanelAnnouncementsItems.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PanelAnnouncementsItems_ControlRemoved);
            // 
            // LabelHeaderAnnouncements
            // 
            this.LabelHeaderAnnouncements.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderAnnouncements.Appearance.Options.UseFont = true;
            this.LabelHeaderAnnouncements.Location = new System.Drawing.Point(12, 10);
            this.LabelHeaderAnnouncements.Name = "LabelHeaderAnnouncements";
            this.LabelHeaderAnnouncements.Size = new System.Drawing.Size(148, 21);
            this.LabelHeaderAnnouncements.TabIndex = 0;
            this.LabelHeaderAnnouncements.Text = "ANNOUNCEMENTS";
            // 
            // PanelSetupItems
            // 
            this.PanelSetupItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSetupItems.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelSetupItems.Appearance.Options.UseBackColor = true;
            this.PanelSetupItems.Controls.Add(this.TileControlSetup);
            this.PanelSetupItems.Controls.Add(this.LabelHeaderSetup);
            this.PanelSetupItems.Location = new System.Drawing.Point(15, 17);
            this.PanelSetupItems.Margin = new System.Windows.Forms.Padding(3, 7, 7, 7);
            this.PanelSetupItems.MinimumSize = new System.Drawing.Size(800, 205);
            this.PanelSetupItems.Name = "PanelSetupItems";
            this.PanelSetupItems.Size = new System.Drawing.Size(817, 205);
            this.PanelSetupItems.TabIndex = 0;
            // 
            // TileControlSetup
            // 
            this.TileControlSetup.AllowItemHover = true;
            this.TileControlSetup.AllowSelectedItemBorder = false;
            this.TileControlSetup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TileControlSetup.Groups.Add(this.TileGroupSetup);
            this.TileControlSetup.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TileControlSetup.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            this.TileControlSetup.Location = new System.Drawing.Point(7, 41);
            this.TileControlSetup.MaxId = 9;
            this.TileControlSetup.Name = "TileControlSetup";
            this.TileControlSetup.Padding = new System.Windows.Forms.Padding(14, 10, 10, 10);
            this.TileControlSetup.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.TileControlSetup.Size = new System.Drawing.Size(791, 139);
            this.TileControlSetup.TabIndex = 1;
            this.TileControlSetup.Text = "tileControl1";
            // 
            // TileGroupSetup
            // 
            this.TileGroupSetup.Items.Add(this.TileItemIntroductionDetails);
            this.TileGroupSetup.Items.Add(this.TileItemAddNewConsole);
            this.TileGroupSetup.Items.Add(this.TileItemScanForXboxConsoles);
            this.TileGroupSetup.Items.Add(this.TileItemEditConsoleProfiles);
            this.TileGroupSetup.Items.Add(this.TileItemStartupLibrary);
            this.TileGroupSetup.Items.Add(this.TileItemSetDownloadsLocation);
            this.TileGroupSetup.Name = "TileGroupSetup";
            // 
            // TileItemIntroductionDetails
            // 
            this.TileItemIntroductionDetails.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemIntroductionDetails.AppearanceItem.Normal.BackColor = System.Drawing.Color.Coral;
            this.TileItemIntroductionDetails.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Coral;
            this.TileItemIntroductionDetails.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TileItemIntroductionDetails.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemIntroductionDetails.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.TileItemIntroductionDetails.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemIntroductionDetails.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemIntroductionDetails.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemIntroductionDetails.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemIntroductionDetails.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemIntroductionDetails.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement1.Text = "Introduction Details";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemIntroductionDetails.Elements.Add(tileItemElement1);
            this.TileItemIntroductionDetails.Id = 0;
            this.TileItemIntroductionDetails.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemIntroductionDetails.Name = "TileItemIntroductionDetails";
            this.TileItemIntroductionDetails.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemIntroductionDetails_ItemClick);
            // 
            // TileItemAddNewConsole
            // 
            this.TileItemAddNewConsole.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemAddNewConsole.AppearanceItem.Normal.BackColor = System.Drawing.SystemColors.Highlight;
            this.TileItemAddNewConsole.AppearanceItem.Normal.BorderColor = System.Drawing.SystemColors.Highlight;
            this.TileItemAddNewConsole.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TileItemAddNewConsole.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemAddNewConsole.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.TileItemAddNewConsole.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemAddNewConsole.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemAddNewConsole.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemAddNewConsole.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemAddNewConsole.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemAddNewConsole.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement2.ImageOptions.Image = global::ModioX.Properties.Resources.add_profile;
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "Add New Console Profile";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemAddNewConsole.Elements.Add(tileItemElement2);
            this.TileItemAddNewConsole.Id = 0;
            this.TileItemAddNewConsole.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemAddNewConsole.Name = "TileItemAddNewConsole";
            this.TileItemAddNewConsole.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemAddNewConsole_ItemClick);
            // 
            // TileItemScanForXboxConsoles
            // 
            this.TileItemScanForXboxConsoles.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemScanForXboxConsoles.AppearanceItem.Normal.BackColor = System.Drawing.SystemColors.Highlight;
            this.TileItemScanForXboxConsoles.AppearanceItem.Normal.BorderColor = System.Drawing.SystemColors.Highlight;
            this.TileItemScanForXboxConsoles.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TileItemScanForXboxConsoles.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemScanForXboxConsoles.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.TileItemScanForXboxConsoles.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemScanForXboxConsoles.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemScanForXboxConsoles.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemScanForXboxConsoles.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemScanForXboxConsoles.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemScanForXboxConsoles.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement3.ImageOptions.Image = global::ModioX.Properties.Resources.find_profile;
            tileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "Scan For Xbox Consoles";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemScanForXboxConsoles.Elements.Add(tileItemElement3);
            this.TileItemScanForXboxConsoles.Id = 8;
            this.TileItemScanForXboxConsoles.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemScanForXboxConsoles.Name = "TileItemScanForXboxConsoles";
            this.TileItemScanForXboxConsoles.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemScanForXboxConsoles_ItemClick);
            // 
            // TileItemEditConsoleProfiles
            // 
            this.TileItemEditConsoleProfiles.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemEditConsoleProfiles.AppearanceItem.Normal.BackColor = System.Drawing.SystemColors.Highlight;
            this.TileItemEditConsoleProfiles.AppearanceItem.Normal.BorderColor = System.Drawing.SystemColors.Highlight;
            this.TileItemEditConsoleProfiles.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TileItemEditConsoleProfiles.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemEditConsoleProfiles.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.TileItemEditConsoleProfiles.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemEditConsoleProfiles.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemEditConsoleProfiles.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemEditConsoleProfiles.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemEditConsoleProfiles.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemEditConsoleProfiles.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement4.ImageOptions.Image = global::ModioX.Properties.Resources.profile;
            tileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement4.Text = "Edit Console Profiles";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemEditConsoleProfiles.Elements.Add(tileItemElement4);
            this.TileItemEditConsoleProfiles.Id = 7;
            this.TileItemEditConsoleProfiles.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemEditConsoleProfiles.Name = "TileItemEditConsoleProfiles";
            this.TileItemEditConsoleProfiles.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemEditConsoleProfiles_ItemClick);
            // 
            // TileItemStartupLibrary
            // 
            this.TileItemStartupLibrary.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemStartupLibrary.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TileItemStartupLibrary.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemStartupLibrary.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemStartupLibrary.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemStartupLibrary.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemStartupLibrary.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemStartupLibrary.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement5.AnchorIndent = -50;
            tileItemElement5.Appearance.Normal.Options.UseTextOptions = true;
            tileItemElement5.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tileItemElement5.ImageOptions.Image = global::ModioX.Properties.Resources.library;
            tileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement5.ImageOptions.ImageSize = new System.Drawing.Size(32, 32);
            tileItemElement5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement5.Text = "Startup Library";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement6.AnchorIndent = -1;
            tileItemElement6.Text = "PlayStation 3";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            tileItemElement6.TextLocation = new System.Drawing.Point(0, -5);
            this.TileItemStartupLibrary.Elements.Add(tileItemElement5);
            this.TileItemStartupLibrary.Elements.Add(tileItemElement6);
            this.TileItemStartupLibrary.Id = 3;
            this.TileItemStartupLibrary.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemStartupLibrary.Name = "TileItemStartupLibrary";
            this.TileItemStartupLibrary.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.TileItemStartupLibrary.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemStartupLibrary_ItemClick);
            // 
            // TileItemSetDownloadsLocation
            // 
            this.TileItemSetDownloadsLocation.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemSetDownloadsLocation.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.TileItemSetDownloadsLocation.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemSetDownloadsLocation.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemSetDownloadsLocation.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemSetDownloadsLocation.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemSetDownloadsLocation.AppearanceItem.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TileItemSetDownloadsLocation.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement7.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement7.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement7.ImageOptions.ImageToTextIndent = 5;
            tileItemElement7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            tileItemElement7.Text = "Set Downloads Location";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemSetDownloadsLocation.Elements.Add(tileItemElement7);
            this.TileItemSetDownloadsLocation.Id = 4;
            this.TileItemSetDownloadsLocation.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.TileItemSetDownloadsLocation.Name = "TileItemSetDownloadsLocation";
            this.TileItemSetDownloadsLocation.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemSetDownloadsLocation_ItemClick);
            // 
            // LabelHeaderSetup
            // 
            this.LabelHeaderSetup.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderSetup.Appearance.Options.UseFont = true;
            this.LabelHeaderSetup.Location = new System.Drawing.Point(12, 10);
            this.LabelHeaderSetup.Name = "LabelHeaderSetup";
            this.LabelHeaderSetup.Size = new System.Drawing.Size(168, 21);
            this.LabelHeaderSetup.TabIndex = 0;
            this.LabelHeaderSetup.Text = "LET\'S GET YOU SET UP";
            // 
            // PanelInstalledMods
            // 
            this.PanelInstalledMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInstalledMods.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelInstalledMods.BackColor = System.Drawing.Color.Transparent;
            this.PanelInstalledMods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelInstalledMods.Controls.Add(this.GridControlInstalledMods);
            this.PanelInstalledMods.Controls.Add(this.PanelInstalledModsFilters);
            this.PanelInstalledMods.Location = new System.Drawing.Point(14, 84);
            this.PanelInstalledMods.Margin = new System.Windows.Forms.Padding(14);
            this.PanelInstalledMods.Name = "PanelInstalledMods";
            this.PanelInstalledMods.Size = new System.Drawing.Size(1253, 614);
            this.PanelInstalledMods.TabIndex = 1181;
            // 
            // GridControlInstalledMods
            // 
            this.GridControlInstalledMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlInstalledMods.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridControlInstalledMods.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.GridControlInstalledMods.EmbeddedNavigator.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.GridControlInstalledMods.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlInstalledMods.Location = new System.Drawing.Point(10, 70);
            this.GridControlInstalledMods.MainView = this.GridViewInstalledMods;
            this.GridControlInstalledMods.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GridControlInstalledMods.MenuManager = this.MainMenu;
            this.GridControlInstalledMods.Name = "GridControlInstalledMods";
            this.GridControlInstalledMods.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.GridControlInstalledMods.Size = new System.Drawing.Size(1231, 530);
            this.GridControlInstalledMods.TabIndex = 5;
            this.GridControlInstalledMods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewInstalledMods});
            // 
            // GridViewInstalledMods
            // 
            this.GridViewInstalledMods.ActiveFilterEnabled = false;
            this.GridViewInstalledMods.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewInstalledMods.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewInstalledMods.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewInstalledMods.Appearance.FocusedCell.Options.UseBackColor = true;
            this.GridViewInstalledMods.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewInstalledMods.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewInstalledMods.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewInstalledMods.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewInstalledMods.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewInstalledMods.Appearance.Preview.Options.UseBackColor = true;
            this.GridViewInstalledMods.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.GridViewInstalledMods.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewInstalledMods.Appearance.Row.Options.UseBackColor = true;
            this.GridViewInstalledMods.Appearance.Row.Options.UseFont = true;
            this.GridViewInstalledMods.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewInstalledMods.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewInstalledMods.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewInstalledMods.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewInstalledMods.GridControl = this.GridControlInstalledMods;
            this.GridViewInstalledMods.GroupRowHeight = 20;
            this.GridViewInstalledMods.Name = "GridViewInstalledMods";
            this.GridViewInstalledMods.OptionsBehavior.Editable = false;
            this.GridViewInstalledMods.OptionsBehavior.ReadOnly = true;
            this.GridViewInstalledMods.OptionsCustomization.AllowFilter = false;
            this.GridViewInstalledMods.OptionsFilter.AllowFilterEditor = false;
            this.GridViewInstalledMods.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewInstalledMods.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewInstalledMods.OptionsView.ShowColumnHeaders = false;
            this.GridViewInstalledMods.OptionsView.ShowGroupPanel = false;
            this.GridViewInstalledMods.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewInstalledMods.OptionsView.ShowIndicator = false;
            this.GridViewInstalledMods.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewInstalledMods.RowHeight = 24;
            this.GridViewInstalledMods.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GridViewInstalledMods.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewInstalledMods_RowClick);
            this.GridViewInstalledMods.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GridViewInstalledMods_CustomDrawCell);
            this.GridViewInstalledMods.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewInstalledMods_FocusedRowChanged);
            // 
            // PanelInstalledModsFilters
            // 
            this.PanelInstalledModsFilters.BackColor = System.Drawing.Color.Transparent;
            this.PanelInstalledModsFilters.Controls.Add(this.ImageInstalledModsFilterTotalFilesType);
            this.PanelInstalledModsFilters.Controls.Add(this.ImageInstalledModsFilterTotalFilesTypeBack);
            this.PanelInstalledModsFilters.Controls.Add(this.LabelInstalledModsFilterTotalFiles);
            this.PanelInstalledModsFilters.Controls.Add(this.DateTimeInstalledModsFilterInstalledOn);
            this.PanelInstalledModsFilters.Controls.Add(this.ImageInstalledModsFilterInstalledOnType);
            this.PanelInstalledModsFilters.Controls.Add(this.LabelInstalledModsFilterInstalledOn);
            this.PanelInstalledModsFilters.Controls.Add(this.ImageInstalledModsFilterInstalledOnTypeBack);
            this.PanelInstalledModsFilters.Controls.Add(this.NumericBoxInstalledModsFilterTotalFiles);
            this.PanelInstalledModsFilters.Controls.Add(this.ComboBoxInstalledModsFilterCreator);
            this.PanelInstalledModsFilters.Controls.Add(this.LabelInstalledModsFilterCreator);
            this.PanelInstalledModsFilters.Controls.Add(this.ComboBoxInstalledModsFilterPlatform);
            this.PanelInstalledModsFilters.Controls.Add(this.LabelInstalledModsFilterPlatform);
            this.PanelInstalledModsFilters.Controls.Add(this.SeparatorInstalledModsFilter);
            this.PanelInstalledModsFilters.Controls.Add(this.ComboBoxInstalledModsFilterCategory);
            this.PanelInstalledModsFilters.Controls.Add(this.LabelInstalledModsFilterCategory);
            this.PanelInstalledModsFilters.Controls.Add(this.ComboBoxInstalledModsFilterVersion);
            this.PanelInstalledModsFilters.Controls.Add(this.LabelInstalledModsFilterVersion);
            this.PanelInstalledModsFilters.Controls.Add(this.TextBoxInstalledModsFilterName);
            this.PanelInstalledModsFilters.Controls.Add(this.ComboBoxInstalledModsFilterRegion);
            this.PanelInstalledModsFilters.Controls.Add(this.ComboBoxInstalledModsFilterType);
            this.PanelInstalledModsFilters.Controls.Add(this.LabelInstalledModsFilterGameRegion);
            this.PanelInstalledModsFilters.Controls.Add(this.LabelInstalledModsFilterModName);
            this.PanelInstalledModsFilters.Controls.Add(this.LabelInstalledModsFilterModType);
            this.PanelInstalledModsFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInstalledModsFilters.Location = new System.Drawing.Point(0, 0);
            this.PanelInstalledModsFilters.Margin = new System.Windows.Forms.Padding(0, 4, 0, 50);
            this.PanelInstalledModsFilters.Name = "PanelInstalledModsFilters";
            this.PanelInstalledModsFilters.Size = new System.Drawing.Size(1251, 70);
            this.PanelInstalledModsFilters.TabIndex = 12;
            // 
            // ImageInstalledModsFilterTotalFilesType
            // 
            this.ImageInstalledModsFilterTotalFilesType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageInstalledModsFilterTotalFilesType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageInstalledModsFilterTotalFilesType.EditValue = ((object)(resources.GetObject("ImageInstalledModsFilterTotalFilesType.EditValue")));
            this.ImageInstalledModsFilterTotalFilesType.Location = new System.Drawing.Point(1059, 44);
            this.ImageInstalledModsFilterTotalFilesType.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ImageInstalledModsFilterTotalFilesType.MenuManager = this.MainMenu;
            this.ImageInstalledModsFilterTotalFilesType.Name = "ImageInstalledModsFilterTotalFilesType";
            this.ImageInstalledModsFilterTotalFilesType.Properties.AllowFocused = false;
            this.ImageInstalledModsFilterTotalFilesType.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImageInstalledModsFilterTotalFilesType.Properties.Appearance.Options.UseForeColor = true;
            this.ImageInstalledModsFilterTotalFilesType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageInstalledModsFilterTotalFilesType.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageInstalledModsFilterTotalFilesType.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageInstalledModsFilterTotalFilesType.Size = new System.Drawing.Size(14, 14);
            this.ImageInstalledModsFilterTotalFilesType.TabIndex = 1207;
            this.ImageInstalledModsFilterTotalFilesType.Click += new System.EventHandler(this.ImageInstalledModsFilterTotalFilesType_Click);
            // 
            // ImageInstalledModsFilterTotalFilesTypeBack
            // 
            this.ImageInstalledModsFilterTotalFilesTypeBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageInstalledModsFilterTotalFilesTypeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageInstalledModsFilterTotalFilesTypeBack.Location = new System.Drawing.Point(1055, 40);
            this.ImageInstalledModsFilterTotalFilesTypeBack.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ImageInstalledModsFilterTotalFilesTypeBack.MenuManager = this.MainMenu;
            this.ImageInstalledModsFilterTotalFilesTypeBack.Name = "ImageInstalledModsFilterTotalFilesTypeBack";
            this.ImageInstalledModsFilterTotalFilesTypeBack.Properties.AllowFocused = false;
            this.ImageInstalledModsFilterTotalFilesTypeBack.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImageInstalledModsFilterTotalFilesTypeBack.Properties.Appearance.Options.UseForeColor = true;
            this.ImageInstalledModsFilterTotalFilesTypeBack.Properties.NullText = " ";
            this.ImageInstalledModsFilterTotalFilesTypeBack.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageInstalledModsFilterTotalFilesTypeBack.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageInstalledModsFilterTotalFilesTypeBack.Size = new System.Drawing.Size(22, 22);
            this.ImageInstalledModsFilterTotalFilesTypeBack.TabIndex = 1208;
            // 
            // LabelInstalledModsFilterTotalFiles
            // 
            this.LabelInstalledModsFilterTotalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInstalledModsFilterTotalFiles.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelInstalledModsFilterTotalFiles.Appearance.Options.UseFont = true;
            this.LabelInstalledModsFilterTotalFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelInstalledModsFilterTotalFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstalledModsFilterTotalFiles.Location = new System.Drawing.Point(1052, 20);
            this.LabelInstalledModsFilterTotalFiles.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelInstalledModsFilterTotalFiles.Name = "LabelInstalledModsFilterTotalFiles";
            this.LabelInstalledModsFilterTotalFiles.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelInstalledModsFilterTotalFiles.Size = new System.Drawing.Size(61, 15);
            this.LabelInstalledModsFilterTotalFiles.TabIndex = 1204;
            this.LabelInstalledModsFilterTotalFiles.Text = "Total Files";
            // 
            // DateTimeInstalledModsFilterInstalledOn
            // 
            this.DateTimeInstalledModsFilterInstalledOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeInstalledModsFilterInstalledOn.EditValue = null;
            this.DateTimeInstalledModsFilterInstalledOn.Location = new System.Drawing.Point(1152, 40);
            this.DateTimeInstalledModsFilterInstalledOn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.DateTimeInstalledModsFilterInstalledOn.MenuManager = this.MainMenu;
            this.DateTimeInstalledModsFilterInstalledOn.Name = "DateTimeInstalledModsFilterInstalledOn";
            this.DateTimeInstalledModsFilterInstalledOn.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.DateTimeInstalledModsFilterInstalledOn.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DateTimeInstalledModsFilterInstalledOn.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimeInstalledModsFilterInstalledOn.Properties.Appearance.Options.UseBackColor = true;
            this.DateTimeInstalledModsFilterInstalledOn.Properties.Appearance.Options.UseFont = true;
            this.DateTimeInstalledModsFilterInstalledOn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTimeInstalledModsFilterInstalledOn.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.DateTimeInstalledModsFilterInstalledOn.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTimeInstalledModsFilterInstalledOn.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "MM/dd/yyyy";
            this.DateTimeInstalledModsFilterInstalledOn.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DateTimeInstalledModsFilterInstalledOn.Properties.CalendarTimeProperties.EditFormat.FormatString = "MM/dd/yyyy";
            this.DateTimeInstalledModsFilterInstalledOn.Properties.CalendarTimeProperties.TouchUIMaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.DateTimeInstalledModsFilterInstalledOn.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
            this.DateTimeInstalledModsFilterInstalledOn.Properties.DisplayFormat.FormatString = "MM/dd/yyyy";
            this.DateTimeInstalledModsFilterInstalledOn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTimeInstalledModsFilterInstalledOn.Properties.EditFormat.FormatString = "MM/dd/yyyy";
            this.DateTimeInstalledModsFilterInstalledOn.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTimeInstalledModsFilterInstalledOn.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.DateTimeInstalledModsFilterInstalledOn.Properties.MaskSettings.Set("mask", "MM/dd/yyyy");
            this.DateTimeInstalledModsFilterInstalledOn.Properties.MaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.DateTimeInstalledModsFilterInstalledOn.Properties.NullValuePrompt = "Select...";
            this.DateTimeInstalledModsFilterInstalledOn.Properties.UseMaskAsDisplayFormat = true;
            this.DateTimeInstalledModsFilterInstalledOn.Properties.EditValueChanged += new System.EventHandler(this.DateTimeBoxFilterInstalledModsInstalledOn_Properties_EditValueChanged);
            this.DateTimeInstalledModsFilterInstalledOn.Size = new System.Drawing.Size(80, 22);
            this.DateTimeInstalledModsFilterInstalledOn.TabIndex = 1202;
            // 
            // ImageInstalledModsFilterInstalledOnType
            // 
            this.ImageInstalledModsFilterInstalledOnType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageInstalledModsFilterInstalledOnType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageInstalledModsFilterInstalledOnType.EditValue = ((object)(resources.GetObject("ImageInstalledModsFilterInstalledOnType.EditValue")));
            this.ImageInstalledModsFilterInstalledOnType.Location = new System.Drawing.Point(1135, 44);
            this.ImageInstalledModsFilterInstalledOnType.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ImageInstalledModsFilterInstalledOnType.MenuManager = this.MainMenu;
            this.ImageInstalledModsFilterInstalledOnType.Name = "ImageInstalledModsFilterInstalledOnType";
            this.ImageInstalledModsFilterInstalledOnType.Properties.AllowFocused = false;
            this.ImageInstalledModsFilterInstalledOnType.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImageInstalledModsFilterInstalledOnType.Properties.Appearance.Options.UseForeColor = true;
            this.ImageInstalledModsFilterInstalledOnType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageInstalledModsFilterInstalledOnType.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageInstalledModsFilterInstalledOnType.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageInstalledModsFilterInstalledOnType.Size = new System.Drawing.Size(14, 14);
            this.ImageInstalledModsFilterInstalledOnType.TabIndex = 1203;
            this.ImageInstalledModsFilterInstalledOnType.Click += new System.EventHandler(this.ImageInstalledModsFilterInstalledOnType_Click);
            // 
            // LabelInstalledModsFilterInstalledOn
            // 
            this.LabelInstalledModsFilterInstalledOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInstalledModsFilterInstalledOn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelInstalledModsFilterInstalledOn.Appearance.Options.UseFont = true;
            this.LabelInstalledModsFilterInstalledOn.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelInstalledModsFilterInstalledOn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstalledModsFilterInstalledOn.Location = new System.Drawing.Point(1128, 20);
            this.LabelInstalledModsFilterInstalledOn.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelInstalledModsFilterInstalledOn.Name = "LabelInstalledModsFilterInstalledOn";
            this.LabelInstalledModsFilterInstalledOn.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelInstalledModsFilterInstalledOn.Size = new System.Drawing.Size(72, 15);
            this.LabelInstalledModsFilterInstalledOn.TabIndex = 1201;
            this.LabelInstalledModsFilterInstalledOn.Text = "Installed On";
            // 
            // ImageInstalledModsFilterInstalledOnTypeBack
            // 
            this.ImageInstalledModsFilterInstalledOnTypeBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageInstalledModsFilterInstalledOnTypeBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageInstalledModsFilterInstalledOnTypeBack.Location = new System.Drawing.Point(1131, 40);
            this.ImageInstalledModsFilterInstalledOnTypeBack.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ImageInstalledModsFilterInstalledOnTypeBack.MenuManager = this.MainMenu;
            this.ImageInstalledModsFilterInstalledOnTypeBack.Name = "ImageInstalledModsFilterInstalledOnTypeBack";
            this.ImageInstalledModsFilterInstalledOnTypeBack.Properties.AllowFocused = false;
            this.ImageInstalledModsFilterInstalledOnTypeBack.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImageInstalledModsFilterInstalledOnTypeBack.Properties.Appearance.Options.UseForeColor = true;
            this.ImageInstalledModsFilterInstalledOnTypeBack.Properties.NullText = " ";
            this.ImageInstalledModsFilterInstalledOnTypeBack.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageInstalledModsFilterInstalledOnTypeBack.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageInstalledModsFilterInstalledOnTypeBack.Size = new System.Drawing.Size(22, 22);
            this.ImageInstalledModsFilterInstalledOnTypeBack.TabIndex = 1205;
            // 
            // NumericBoxInstalledModsFilterTotalFiles
            // 
            this.NumericBoxInstalledModsFilterTotalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericBoxInstalledModsFilterTotalFiles.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumericBoxInstalledModsFilterTotalFiles.Location = new System.Drawing.Point(1076, 40);
            this.NumericBoxInstalledModsFilterTotalFiles.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.NumericBoxInstalledModsFilterTotalFiles.MenuManager = this.MainMenu;
            this.NumericBoxInstalledModsFilterTotalFiles.Name = "NumericBoxInstalledModsFilterTotalFiles";
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.Appearance.Options.UseBackColor = true;
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.Appearance.Options.UseFont = true;
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.BeepOnError = false;
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.IsFloatValue = false;
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.MaskSettings.Set("mask", "###");
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.NullValuePrompt = "Select...";
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.UseMaskAsDisplayFormat = true;
            this.NumericBoxInstalledModsFilterTotalFiles.Properties.EditValueChanged += new System.EventHandler(this.NumericBoxFilterInstalledModsFiles_Properties_EditValueChanged);
            this.NumericBoxInstalledModsFilterTotalFiles.Size = new System.Drawing.Size(49, 22);
            this.NumericBoxInstalledModsFilterTotalFiles.TabIndex = 1206;
            // 
            // ComboBoxInstalledModsFilterCreator
            // 
            this.ComboBoxInstalledModsFilterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxInstalledModsFilterCreator.Location = new System.Drawing.Point(922, 40);
            this.ComboBoxInstalledModsFilterCreator.MenuManager = this.MainMenu;
            this.ComboBoxInstalledModsFilterCreator.Name = "ComboBoxInstalledModsFilterCreator";
            this.ComboBoxInstalledModsFilterCreator.Properties.AllowFocused = false;
            this.ComboBoxInstalledModsFilterCreator.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxInstalledModsFilterCreator.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxInstalledModsFilterCreator.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxInstalledModsFilterCreator.Properties.AutoComplete = false;
            this.ComboBoxInstalledModsFilterCreator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxInstalledModsFilterCreator.Properties.DropDownRows = 12;
            this.ComboBoxInstalledModsFilterCreator.Properties.NullValuePrompt = "Select...";
            this.ComboBoxInstalledModsFilterCreator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxInstalledModsFilterCreator.Size = new System.Drawing.Size(127, 22);
            this.ComboBoxInstalledModsFilterCreator.TabIndex = 1175;
            this.ComboBoxInstalledModsFilterCreator.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInstalledModsFilterCreator_SelectedIndexChanged);
            // 
            // LabelInstalledModsFilterCreator
            // 
            this.LabelInstalledModsFilterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInstalledModsFilterCreator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelInstalledModsFilterCreator.Appearance.Options.UseFont = true;
            this.LabelInstalledModsFilterCreator.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelInstalledModsFilterCreator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstalledModsFilterCreator.Location = new System.Drawing.Point(919, 20);
            this.LabelInstalledModsFilterCreator.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelInstalledModsFilterCreator.Name = "LabelInstalledModsFilterCreator";
            this.LabelInstalledModsFilterCreator.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelInstalledModsFilterCreator.Size = new System.Drawing.Size(48, 15);
            this.LabelInstalledModsFilterCreator.TabIndex = 1176;
            this.LabelInstalledModsFilterCreator.Text = "Creator";
            // 
            // ComboBoxInstalledModsFilterPlatform
            // 
            this.ComboBoxInstalledModsFilterPlatform.Location = new System.Drawing.Point(17, 40);
            this.ComboBoxInstalledModsFilterPlatform.MenuManager = this.MainMenu;
            this.ComboBoxInstalledModsFilterPlatform.Name = "ComboBoxInstalledModsFilterPlatform";
            this.ComboBoxInstalledModsFilterPlatform.Properties.AllowFocused = false;
            this.ComboBoxInstalledModsFilterPlatform.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxInstalledModsFilterPlatform.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxInstalledModsFilterPlatform.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxInstalledModsFilterPlatform.Properties.AutoComplete = false;
            this.ComboBoxInstalledModsFilterPlatform.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxInstalledModsFilterPlatform.Properties.DropDownRows = 12;
            this.ComboBoxInstalledModsFilterPlatform.Properties.Items.AddRange(new object[] {
            "<All>",
            "PlayStation 3",
            "Xbox 360"});
            this.ComboBoxInstalledModsFilterPlatform.Properties.NullValuePrompt = "Select...";
            this.ComboBoxInstalledModsFilterPlatform.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxInstalledModsFilterPlatform.Size = new System.Drawing.Size(92, 22);
            this.ComboBoxInstalledModsFilterPlatform.TabIndex = 1173;
            this.ComboBoxInstalledModsFilterPlatform.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInstalledModsFilterPlatform_SelectedIndexChanged);
            // 
            // LabelInstalledModsFilterPlatform
            // 
            this.LabelInstalledModsFilterPlatform.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelInstalledModsFilterPlatform.Appearance.Options.UseFont = true;
            this.LabelInstalledModsFilterPlatform.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelInstalledModsFilterPlatform.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstalledModsFilterPlatform.Location = new System.Drawing.Point(14, 20);
            this.LabelInstalledModsFilterPlatform.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelInstalledModsFilterPlatform.Name = "LabelInstalledModsFilterPlatform";
            this.LabelInstalledModsFilterPlatform.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelInstalledModsFilterPlatform.Size = new System.Drawing.Size(55, 15);
            this.LabelInstalledModsFilterPlatform.TabIndex = 1174;
            this.LabelInstalledModsFilterPlatform.Text = "Platform";
            // 
            // SeparatorInstalledModsFilter
            // 
            this.SeparatorInstalledModsFilter.BackColor = System.Drawing.Color.Transparent;
            this.SeparatorInstalledModsFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparatorInstalledModsFilter.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.SeparatorInstalledModsFilter.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SeparatorInstalledModsFilter.LineThickness = 3;
            this.SeparatorInstalledModsFilter.Location = new System.Drawing.Point(0, 67);
            this.SeparatorInstalledModsFilter.Margin = new System.Windows.Forms.Padding(0);
            this.SeparatorInstalledModsFilter.Name = "SeparatorInstalledModsFilter";
            this.SeparatorInstalledModsFilter.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.SeparatorInstalledModsFilter.Size = new System.Drawing.Size(1251, 3);
            this.SeparatorInstalledModsFilter.TabIndex = 1172;
            // 
            // ComboBoxInstalledModsFilterCategory
            // 
            this.ComboBoxInstalledModsFilterCategory.Location = new System.Drawing.Point(115, 40);
            this.ComboBoxInstalledModsFilterCategory.MenuManager = this.MainMenu;
            this.ComboBoxInstalledModsFilterCategory.Name = "ComboBoxInstalledModsFilterCategory";
            this.ComboBoxInstalledModsFilterCategory.Properties.AllowFocused = false;
            this.ComboBoxInstalledModsFilterCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxInstalledModsFilterCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxInstalledModsFilterCategory.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxInstalledModsFilterCategory.Properties.AutoComplete = false;
            this.ComboBoxInstalledModsFilterCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxInstalledModsFilterCategory.Properties.DropDownRows = 15;
            this.ComboBoxInstalledModsFilterCategory.Properties.NullValuePrompt = "Select...";
            this.ComboBoxInstalledModsFilterCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxInstalledModsFilterCategory.Size = new System.Drawing.Size(220, 22);
            this.ComboBoxInstalledModsFilterCategory.TabIndex = 1170;
            this.ComboBoxInstalledModsFilterCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInstalledModsFilterCategory_SelectedIndexChanged);
            // 
            // LabelInstalledModsFilterCategory
            // 
            this.LabelInstalledModsFilterCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelInstalledModsFilterCategory.Appearance.Options.UseFont = true;
            this.LabelInstalledModsFilterCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelInstalledModsFilterCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstalledModsFilterCategory.Location = new System.Drawing.Point(112, 20);
            this.LabelInstalledModsFilterCategory.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelInstalledModsFilterCategory.Name = "LabelInstalledModsFilterCategory";
            this.LabelInstalledModsFilterCategory.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelInstalledModsFilterCategory.Size = new System.Drawing.Size(56, 15);
            this.LabelInstalledModsFilterCategory.TabIndex = 1171;
            this.LabelInstalledModsFilterCategory.Text = "Category";
            // 
            // ComboBoxInstalledModsFilterVersion
            // 
            this.ComboBoxInstalledModsFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxInstalledModsFilterVersion.Location = new System.Drawing.Point(852, 40);
            this.ComboBoxInstalledModsFilterVersion.MenuManager = this.MainMenu;
            this.ComboBoxInstalledModsFilterVersion.Name = "ComboBoxInstalledModsFilterVersion";
            this.ComboBoxInstalledModsFilterVersion.Properties.AllowFocused = false;
            this.ComboBoxInstalledModsFilterVersion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxInstalledModsFilterVersion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxInstalledModsFilterVersion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxInstalledModsFilterVersion.Properties.AutoComplete = false;
            this.ComboBoxInstalledModsFilterVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxInstalledModsFilterVersion.Properties.DropDownRows = 12;
            this.ComboBoxInstalledModsFilterVersion.Properties.NullValuePrompt = "Select...";
            this.ComboBoxInstalledModsFilterVersion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxInstalledModsFilterVersion.Size = new System.Drawing.Size(64, 22);
            this.ComboBoxInstalledModsFilterVersion.TabIndex = 1164;
            this.ComboBoxInstalledModsFilterVersion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInstalledModsFilterVersion_SelectedIndexChanged);
            // 
            // LabelInstalledModsFilterVersion
            // 
            this.LabelInstalledModsFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInstalledModsFilterVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelInstalledModsFilterVersion.Appearance.Options.UseFont = true;
            this.LabelInstalledModsFilterVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelInstalledModsFilterVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstalledModsFilterVersion.Location = new System.Drawing.Point(849, 20);
            this.LabelInstalledModsFilterVersion.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelInstalledModsFilterVersion.Name = "LabelInstalledModsFilterVersion";
            this.LabelInstalledModsFilterVersion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelInstalledModsFilterVersion.Size = new System.Drawing.Size(48, 15);
            this.LabelInstalledModsFilterVersion.TabIndex = 1165;
            this.LabelInstalledModsFilterVersion.Text = "Version";
            // 
            // TextBoxInstalledModsFilterName
            // 
            this.TextBoxInstalledModsFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxInstalledModsFilterName.Location = new System.Drawing.Point(341, 40);
            this.TextBoxInstalledModsFilterName.MenuManager = this.MainMenu;
            this.TextBoxInstalledModsFilterName.Name = "TextBoxInstalledModsFilterName";
            this.TextBoxInstalledModsFilterName.Properties.AllowFocused = false;
            this.TextBoxInstalledModsFilterName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TextBoxInstalledModsFilterName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxInstalledModsFilterName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxInstalledModsFilterName.Properties.NullValuePrompt = "Search...";
            this.TextBoxInstalledModsFilterName.Size = new System.Drawing.Size(319, 22);
            this.TextBoxInstalledModsFilterName.TabIndex = 1;
            this.TextBoxInstalledModsFilterName.EditValueChanged += new System.EventHandler(this.TextBoxFilterInstalledModsName_EditValueChanged);
            // 
            // ComboBoxInstalledModsFilterRegion
            // 
            this.ComboBoxInstalledModsFilterRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxInstalledModsFilterRegion.Location = new System.Drawing.Point(764, 40);
            this.ComboBoxInstalledModsFilterRegion.MenuManager = this.MainMenu;
            this.ComboBoxInstalledModsFilterRegion.Name = "ComboBoxInstalledModsFilterRegion";
            this.ComboBoxInstalledModsFilterRegion.Properties.AllowFocused = false;
            this.ComboBoxInstalledModsFilterRegion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxInstalledModsFilterRegion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxInstalledModsFilterRegion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxInstalledModsFilterRegion.Properties.AutoComplete = false;
            this.ComboBoxInstalledModsFilterRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxInstalledModsFilterRegion.Properties.DropDownRows = 12;
            this.ComboBoxInstalledModsFilterRegion.Properties.NullValuePrompt = "Select...";
            this.ComboBoxInstalledModsFilterRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxInstalledModsFilterRegion.Size = new System.Drawing.Size(82, 22);
            this.ComboBoxInstalledModsFilterRegion.TabIndex = 4;
            this.ComboBoxInstalledModsFilterRegion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInstalledModsFilterRegion_SelectedIndexChanged);
            // 
            // ComboBoxInstalledModsFilterType
            // 
            this.ComboBoxInstalledModsFilterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxInstalledModsFilterType.Location = new System.Drawing.Point(666, 40);
            this.ComboBoxInstalledModsFilterType.MenuManager = this.MainMenu;
            this.ComboBoxInstalledModsFilterType.Name = "ComboBoxInstalledModsFilterType";
            this.ComboBoxInstalledModsFilterType.Properties.AllowFocused = false;
            this.ComboBoxInstalledModsFilterType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxInstalledModsFilterType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxInstalledModsFilterType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxInstalledModsFilterType.Properties.AutoComplete = false;
            this.ComboBoxInstalledModsFilterType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxInstalledModsFilterType.Properties.DropDownRows = 12;
            this.ComboBoxInstalledModsFilterType.Properties.NullValuePrompt = "Select...";
            this.ComboBoxInstalledModsFilterType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxInstalledModsFilterType.Size = new System.Drawing.Size(92, 22);
            this.ComboBoxInstalledModsFilterType.TabIndex = 3;
            this.ComboBoxInstalledModsFilterType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInstalledModsFilterType_SelectedIndexChanged);
            // 
            // LabelInstalledModsFilterGameRegion
            // 
            this.LabelInstalledModsFilterGameRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInstalledModsFilterGameRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelInstalledModsFilterGameRegion.Appearance.Options.UseFont = true;
            this.LabelInstalledModsFilterGameRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelInstalledModsFilterGameRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstalledModsFilterGameRegion.Location = new System.Drawing.Point(761, 20);
            this.LabelInstalledModsFilterGameRegion.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelInstalledModsFilterGameRegion.Name = "LabelInstalledModsFilterGameRegion";
            this.LabelInstalledModsFilterGameRegion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelInstalledModsFilterGameRegion.Size = new System.Drawing.Size(45, 15);
            this.LabelInstalledModsFilterGameRegion.TabIndex = 1163;
            this.LabelInstalledModsFilterGameRegion.Text = "Region";
            // 
            // LabelInstalledModsFilterModName
            // 
            this.LabelInstalledModsFilterModName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelInstalledModsFilterModName.Appearance.Options.UseFont = true;
            this.LabelInstalledModsFilterModName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelInstalledModsFilterModName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstalledModsFilterModName.Location = new System.Drawing.Point(338, 20);
            this.LabelInstalledModsFilterModName.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelInstalledModsFilterModName.Name = "LabelInstalledModsFilterModName";
            this.LabelInstalledModsFilterModName.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelInstalledModsFilterModName.Size = new System.Drawing.Size(39, 15);
            this.LabelInstalledModsFilterModName.TabIndex = 1157;
            this.LabelInstalledModsFilterModName.Text = "Name";
            // 
            // LabelInstalledModsFilterModType
            // 
            this.LabelInstalledModsFilterModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInstalledModsFilterModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelInstalledModsFilterModType.Appearance.Options.UseFont = true;
            this.LabelInstalledModsFilterModType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelInstalledModsFilterModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelInstalledModsFilterModType.Location = new System.Drawing.Point(663, 20);
            this.LabelInstalledModsFilterModType.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelInstalledModsFilterModType.Name = "LabelInstalledModsFilterModType";
            this.LabelInstalledModsFilterModType.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelInstalledModsFilterModType.Size = new System.Drawing.Size(61, 15);
            this.LabelInstalledModsFilterModType.TabIndex = 1122;
            this.LabelInstalledModsFilterModType.Text = "Mod Type";
            // 
            // PanelInstalledModsActions
            // 
            this.PanelInstalledModsActions.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelInstalledModsActions.Controls.Add(this.TileControlInstalledMods);
            this.PanelInstalledModsActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInstalledModsActions.Location = new System.Drawing.Point(0, 0);
            this.PanelInstalledModsActions.Margin = new System.Windows.Forms.Padding(0);
            this.PanelInstalledModsActions.Name = "PanelInstalledModsActions";
            this.PanelInstalledModsActions.Size = new System.Drawing.Size(1281, 70);
            this.PanelInstalledModsActions.TabIndex = 1180;
            // 
            // TileControlInstalledMods
            // 
            this.TileControlInstalledMods.AllowDisabledStateIndication = false;
            this.TileControlInstalledMods.AllowDrag = false;
            this.TileControlInstalledMods.AllowDragTilesBetweenGroups = false;
            this.TileControlInstalledMods.AllowGlyphSkinning = true;
            this.TileControlInstalledMods.AllowItemHover = true;
            this.TileControlInstalledMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TileControlInstalledMods.Groups.Add(this.TileGroupInstalledMods);
            this.TileControlInstalledMods.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TileControlInstalledMods.IndentBetweenItems = 2;
            this.TileControlInstalledMods.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade;
            this.TileControlInstalledMods.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileControlInstalledMods.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.TileControlInstalledMods.ItemPadding = new System.Windows.Forms.Padding(0);
            this.TileControlInstalledMods.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.TileControlInstalledMods.Location = new System.Drawing.Point(6, 5);
            this.TileControlInstalledMods.MaxId = 4;
            this.TileControlInstalledMods.Name = "TileControlInstalledMods";
            this.TileControlInstalledMods.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TileControlInstalledMods.Padding = new System.Windows.Forms.Padding(0);
            this.TileControlInstalledMods.Size = new System.Drawing.Size(332, 67);
            this.TileControlInstalledMods.TabIndex = 0;
            this.TileControlInstalledMods.Text = "tileControl1";
            // 
            // TileGroupInstalledMods
            // 
            this.TileGroupInstalledMods.Items.Add(this.TileItemInstalledModsUninstallAllItems);
            this.TileGroupInstalledMods.Items.Add(this.TileItemInstalledModsUninstallItem);
            this.TileGroupInstalledMods.Items.Add(this.TileItemInstalledModsViewDetails);
            this.TileGroupInstalledMods.Name = "TileGroupInstalledMods";
            this.TileGroupInstalledMods.Text = "Installed Mods Actions";
            // 
            // TileItemInstalledModsUninstallAllItems
            // 
            this.TileItemInstalledModsUninstallAllItems.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemInstalledModsUninstallAllItems.AppearanceItem.Disabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(183)))));
            this.TileItemInstalledModsUninstallAllItems.AppearanceItem.Disabled.Options.UseBackColor = true;
            this.TileItemInstalledModsUninstallAllItems.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemInstalledModsUninstallAllItems.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemInstalledModsUninstallAllItems.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemInstalledModsUninstallAllItems.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemInstalledModsUninstallAllItems.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemInstalledModsUninstallAllItems.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemInstalledModsUninstallAllItems.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement16.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement16.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement16.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement16.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement16.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement16.ImageOptions.ImageToTextIndent = 2;
            tileItemElement16.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement16.Text = "Uninstall All Items";
            tileItemElement16.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemInstalledModsUninstallAllItems.Elements.Add(tileItemElement16);
            this.TileItemInstalledModsUninstallAllItems.Id = 0;
            this.TileItemInstalledModsUninstallAllItems.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemInstalledModsUninstallAllItems.Name = "TileItemInstalledModsUninstallAllItems";
            this.TileItemInstalledModsUninstallAllItems.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemInstalledModsUninstallAllItems.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemInstalledModsUninstallAll_ItemClick);
            // 
            // TileItemInstalledModsUninstallItem
            // 
            this.TileItemInstalledModsUninstallItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemInstalledModsUninstallItem.AppearanceItem.Disabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(183)))));
            this.TileItemInstalledModsUninstallItem.AppearanceItem.Disabled.Options.UseBackColor = true;
            this.TileItemInstalledModsUninstallItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemInstalledModsUninstallItem.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemInstalledModsUninstallItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemInstalledModsUninstallItem.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemInstalledModsUninstallItem.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemInstalledModsUninstallItem.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemInstalledModsUninstallItem.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement17.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement17.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement17.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement17.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement17.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement17.ImageOptions.ImageToTextIndent = 2;
            tileItemElement17.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement17.Text = "Uninstall Item";
            tileItemElement17.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemInstalledModsUninstallItem.Elements.Add(tileItemElement17);
            this.TileItemInstalledModsUninstallItem.Enabled = false;
            this.TileItemInstalledModsUninstallItem.Id = 2;
            this.TileItemInstalledModsUninstallItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemInstalledModsUninstallItem.Name = "TileItemInstalledModsUninstallItem";
            this.TileItemInstalledModsUninstallItem.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemInstalledModsUninstallItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemInstalledModsUninstallSelected_ItemClick);
            // 
            // TileItemInstalledModsViewDetails
            // 
            this.TileItemInstalledModsViewDetails.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemInstalledModsViewDetails.AppearanceItem.Disabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(183)))));
            this.TileItemInstalledModsViewDetails.AppearanceItem.Disabled.Options.UseBackColor = true;
            this.TileItemInstalledModsViewDetails.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemInstalledModsViewDetails.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemInstalledModsViewDetails.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemInstalledModsViewDetails.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemInstalledModsViewDetails.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemInstalledModsViewDetails.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemInstalledModsViewDetails.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement18.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement18.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement18.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement18.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement18.ImageOptions.ImageToTextIndent = 2;
            tileItemElement18.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage3")));
            tileItemElement18.Text = "View Details";
            tileItemElement18.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemInstalledModsViewDetails.Elements.Add(tileItemElement18);
            this.TileItemInstalledModsViewDetails.Enabled = false;
            this.TileItemInstalledModsViewDetails.Id = 3;
            this.TileItemInstalledModsViewDetails.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemInstalledModsViewDetails.Name = "TileItemInstalledModsViewDetails";
            this.TileItemInstalledModsViewDetails.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemInstalledModsViewDetails.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemInstalledModsViewDetails_ItemClick);
            // 
            // PanelDownloads
            // 
            this.PanelDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDownloads.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelDownloads.BackColor = System.Drawing.Color.Transparent;
            this.PanelDownloads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDownloads.Controls.Add(this.GridControlDownloads);
            this.PanelDownloads.Controls.Add(this.PanelFiltersDownloads);
            this.PanelDownloads.Location = new System.Drawing.Point(14, 84);
            this.PanelDownloads.Margin = new System.Windows.Forms.Padding(14);
            this.PanelDownloads.Name = "PanelDownloads";
            this.PanelDownloads.Size = new System.Drawing.Size(1253, 614);
            this.PanelDownloads.TabIndex = 15;
            // 
            // GridControlDownloads
            // 
            this.GridControlDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlDownloads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlDownloads.Location = new System.Drawing.Point(10, 70);
            this.GridControlDownloads.MainView = this.GridViewDownloads;
            this.GridControlDownloads.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GridControlDownloads.MenuManager = this.MainMenu;
            this.GridControlDownloads.Name = "GridControlDownloads";
            this.GridControlDownloads.Size = new System.Drawing.Size(1231, 530);
            this.GridControlDownloads.TabIndex = 5;
            this.GridControlDownloads.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewDownloads});
            // 
            // GridViewDownloads
            // 
            this.GridViewDownloads.ActiveFilterEnabled = false;
            this.GridViewDownloads.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewDownloads.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewDownloads.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewDownloads.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewDownloads.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewDownloads.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewDownloads.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.GridViewDownloads.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewDownloads.Appearance.Row.Options.UseBackColor = true;
            this.GridViewDownloads.Appearance.Row.Options.UseFont = true;
            this.GridViewDownloads.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewDownloads.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewDownloads.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewDownloads.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewDownloads.GridControl = this.GridControlDownloads;
            this.GridViewDownloads.GroupRowHeight = 20;
            this.GridViewDownloads.Name = "GridViewDownloads";
            this.GridViewDownloads.OptionsBehavior.Editable = false;
            this.GridViewDownloads.OptionsBehavior.ReadOnly = true;
            this.GridViewDownloads.OptionsCustomization.AllowFilter = false;
            this.GridViewDownloads.OptionsFilter.AllowFilterEditor = false;
            this.GridViewDownloads.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewDownloads.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewDownloads.OptionsView.ShowColumnHeaders = false;
            this.GridViewDownloads.OptionsView.ShowGroupPanel = false;
            this.GridViewDownloads.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewDownloads.OptionsView.ShowIndicator = false;
            this.GridViewDownloads.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewDownloads.RowHeight = 24;
            this.GridViewDownloads.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GridViewDownloads.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewDownloads_RowClick);
            this.GridViewDownloads.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GridViewDownloads_CustomDrawCell);
            this.GridViewDownloads.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewDownloads_FocusedRowChanged);
            // 
            // PanelFiltersDownloads
            // 
            this.PanelFiltersDownloads.BackColor = System.Drawing.Color.Transparent;
            this.PanelFiltersDownloads.Controls.Add(this.ComboBoxDownloadsFilterRegion);
            this.PanelFiltersDownloads.Controls.Add(this.LabelDownloadsFilterRegion);
            this.PanelFiltersDownloads.Controls.Add(this.DateTimeDownloadsFilterDate);
            this.PanelFiltersDownloads.Controls.Add(this.ImageDownloadsFilterOnType);
            this.PanelFiltersDownloads.Controls.Add(this.LabelDownloadsFilterDateTime);
            this.PanelFiltersDownloads.Controls.Add(this.ImageDownloadsFilterOnTypeBack);
            this.PanelFiltersDownloads.Controls.Add(this.ComboBoxDownloadsFilterVersion);
            this.PanelFiltersDownloads.Controls.Add(this.LabelDownloadsFilterVersion);
            this.PanelFiltersDownloads.Controls.Add(this.ComboBoxDownloadsFilterModType);
            this.PanelFiltersDownloads.Controls.Add(this.LabelDownloadsFilterModType);
            this.PanelFiltersDownloads.Controls.Add(this.ComboBoxDownloadsFilterPlatform);
            this.PanelFiltersDownloads.Controls.Add(this.LabelDownloadsFilterPlatform);
            this.PanelFiltersDownloads.Controls.Add(this.separatorControl3);
            this.PanelFiltersDownloads.Controls.Add(this.ComboBoxDownloadsFilterCategory);
            this.PanelFiltersDownloads.Controls.Add(this.LabelDownloadsFilterCategory);
            this.PanelFiltersDownloads.Controls.Add(this.TextBoxDownloadsFilterFileName);
            this.PanelFiltersDownloads.Controls.Add(this.LabelDownloadsFilterName);
            this.PanelFiltersDownloads.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFiltersDownloads.Location = new System.Drawing.Point(0, 0);
            this.PanelFiltersDownloads.Margin = new System.Windows.Forms.Padding(0, 4, 0, 50);
            this.PanelFiltersDownloads.Name = "PanelFiltersDownloads";
            this.PanelFiltersDownloads.Size = new System.Drawing.Size(1251, 70);
            this.PanelFiltersDownloads.TabIndex = 12;
            // 
            // ComboBoxDownloadsFilterRegion
            // 
            this.ComboBoxDownloadsFilterRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxDownloadsFilterRegion.Location = new System.Drawing.Point(971, 40);
            this.ComboBoxDownloadsFilterRegion.MenuManager = this.MainMenu;
            this.ComboBoxDownloadsFilterRegion.Name = "ComboBoxDownloadsFilterRegion";
            this.ComboBoxDownloadsFilterRegion.Properties.AllowFocused = false;
            this.ComboBoxDownloadsFilterRegion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxDownloadsFilterRegion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxDownloadsFilterRegion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxDownloadsFilterRegion.Properties.AutoComplete = false;
            this.ComboBoxDownloadsFilterRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxDownloadsFilterRegion.Properties.DropDownRows = 12;
            this.ComboBoxDownloadsFilterRegion.Properties.NullValuePrompt = "Select...";
            this.ComboBoxDownloadsFilterRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxDownloadsFilterRegion.Size = new System.Drawing.Size(82, 22);
            this.ComboBoxDownloadsFilterRegion.TabIndex = 1206;
            this.ComboBoxDownloadsFilterRegion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDownloadsFilterRegion_SelectedIndexChanged);
            // 
            // LabelDownloadsFilterRegion
            // 
            this.LabelDownloadsFilterRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDownloadsFilterRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelDownloadsFilterRegion.Appearance.Options.UseFont = true;
            this.LabelDownloadsFilterRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelDownloadsFilterRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDownloadsFilterRegion.Location = new System.Drawing.Point(968, 20);
            this.LabelDownloadsFilterRegion.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelDownloadsFilterRegion.Name = "LabelDownloadsFilterRegion";
            this.LabelDownloadsFilterRegion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelDownloadsFilterRegion.Size = new System.Drawing.Size(45, 15);
            this.LabelDownloadsFilterRegion.TabIndex = 1207;
            this.LabelDownloadsFilterRegion.Text = "Region";
            // 
            // DateTimeDownloadsFilterDate
            // 
            this.DateTimeDownloadsFilterDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeDownloadsFilterDate.EditValue = null;
            this.DateTimeDownloadsFilterDate.Location = new System.Drawing.Point(1150, 40);
            this.DateTimeDownloadsFilterDate.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.DateTimeDownloadsFilterDate.MenuManager = this.MainMenu;
            this.DateTimeDownloadsFilterDate.Name = "DateTimeDownloadsFilterDate";
            this.DateTimeDownloadsFilterDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.DateTimeDownloadsFilterDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DateTimeDownloadsFilterDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimeDownloadsFilterDate.Properties.Appearance.Options.UseBackColor = true;
            this.DateTimeDownloadsFilterDate.Properties.Appearance.Options.UseFont = true;
            this.DateTimeDownloadsFilterDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTimeDownloadsFilterDate.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.DateTimeDownloadsFilterDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateTimeDownloadsFilterDate.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "MM/dd/yyyy";
            this.DateTimeDownloadsFilterDate.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DateTimeDownloadsFilterDate.Properties.CalendarTimeProperties.EditFormat.FormatString = "MM/dd/yyyy";
            this.DateTimeDownloadsFilterDate.Properties.CalendarTimeProperties.TouchUIMaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.DateTimeDownloadsFilterDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
            this.DateTimeDownloadsFilterDate.Properties.DisplayFormat.FormatString = "MM/dd/yyyy";
            this.DateTimeDownloadsFilterDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTimeDownloadsFilterDate.Properties.EditFormat.FormatString = "MM/dd/yyyy";
            this.DateTimeDownloadsFilterDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTimeDownloadsFilterDate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.DateTimeDownloadsFilterDate.Properties.MaskSettings.Set("mask", "MM/dd/yyyy");
            this.DateTimeDownloadsFilterDate.Properties.NullValuePrompt = "Select...";
            this.DateTimeDownloadsFilterDate.Properties.UseMaskAsDisplayFormat = true;
            this.DateTimeDownloadsFilterDate.Size = new System.Drawing.Size(82, 22);
            this.DateTimeDownloadsFilterDate.TabIndex = 1202;
            this.DateTimeDownloadsFilterDate.EditValueChanged += new System.EventHandler(this.DateTimeFilterDownloadsDate_EditValueChanged);
            // 
            // ImageDownloadsFilterOnType
            // 
            this.ImageDownloadsFilterOnType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageDownloadsFilterOnType.EditValue = ((object)(resources.GetObject("ImageDownloadsFilterOnType.EditValue")));
            this.ImageDownloadsFilterOnType.Location = new System.Drawing.Point(1133, 44);
            this.ImageDownloadsFilterOnType.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ImageDownloadsFilterOnType.MenuManager = this.MainMenu;
            this.ImageDownloadsFilterOnType.Name = "ImageDownloadsFilterOnType";
            this.ImageDownloadsFilterOnType.Properties.AllowFocused = false;
            this.ImageDownloadsFilterOnType.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImageDownloadsFilterOnType.Properties.Appearance.Options.UseForeColor = true;
            this.ImageDownloadsFilterOnType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageDownloadsFilterOnType.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageDownloadsFilterOnType.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageDownloadsFilterOnType.Size = new System.Drawing.Size(14, 14);
            this.ImageDownloadsFilterOnType.TabIndex = 1203;
            this.ImageDownloadsFilterOnType.Click += new System.EventHandler(this.ImageDownloadsFilterDownloadOnType_Click);
            // 
            // LabelDownloadsFilterDateTime
            // 
            this.LabelDownloadsFilterDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDownloadsFilterDateTime.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelDownloadsFilterDateTime.Appearance.Options.UseFont = true;
            this.LabelDownloadsFilterDateTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelDownloadsFilterDateTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDownloadsFilterDateTime.Location = new System.Drawing.Point(1126, 20);
            this.LabelDownloadsFilterDateTime.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelDownloadsFilterDateTime.Name = "LabelDownloadsFilterDateTime";
            this.LabelDownloadsFilterDateTime.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelDownloadsFilterDateTime.Size = new System.Drawing.Size(88, 15);
            this.LabelDownloadsFilterDateTime.TabIndex = 1201;
            this.LabelDownloadsFilterDateTime.Text = "Dowloaded On";
            // 
            // ImageDownloadsFilterOnTypeBack
            // 
            this.ImageDownloadsFilterOnTypeBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageDownloadsFilterOnTypeBack.Location = new System.Drawing.Point(1129, 40);
            this.ImageDownloadsFilterOnTypeBack.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ImageDownloadsFilterOnTypeBack.MenuManager = this.MainMenu;
            this.ImageDownloadsFilterOnTypeBack.Name = "ImageDownloadsFilterOnTypeBack";
            this.ImageDownloadsFilterOnTypeBack.Properties.AllowFocused = false;
            this.ImageDownloadsFilterOnTypeBack.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImageDownloadsFilterOnTypeBack.Properties.Appearance.Options.UseForeColor = true;
            this.ImageDownloadsFilterOnTypeBack.Properties.NullText = " ";
            this.ImageDownloadsFilterOnTypeBack.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageDownloadsFilterOnTypeBack.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageDownloadsFilterOnTypeBack.Size = new System.Drawing.Size(22, 22);
            this.ImageDownloadsFilterOnTypeBack.TabIndex = 1205;
            // 
            // ComboBoxDownloadsFilterVersion
            // 
            this.ComboBoxDownloadsFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxDownloadsFilterVersion.Location = new System.Drawing.Point(1059, 40);
            this.ComboBoxDownloadsFilterVersion.MenuManager = this.MainMenu;
            this.ComboBoxDownloadsFilterVersion.Name = "ComboBoxDownloadsFilterVersion";
            this.ComboBoxDownloadsFilterVersion.Properties.AllowFocused = false;
            this.ComboBoxDownloadsFilterVersion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxDownloadsFilterVersion.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxDownloadsFilterVersion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxDownloadsFilterVersion.Properties.Appearance.Options.UseBackColor = true;
            this.ComboBoxDownloadsFilterVersion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxDownloadsFilterVersion.Properties.AutoComplete = false;
            this.ComboBoxDownloadsFilterVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxDownloadsFilterVersion.Properties.DropDownRows = 15;
            this.ComboBoxDownloadsFilterVersion.Properties.Items.AddRange(new object[] {
            "<All>"});
            this.ComboBoxDownloadsFilterVersion.Properties.NullValuePrompt = "Select...";
            this.ComboBoxDownloadsFilterVersion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxDownloadsFilterVersion.Size = new System.Drawing.Size(64, 22);
            this.ComboBoxDownloadsFilterVersion.TabIndex = 1175;
            this.ComboBoxDownloadsFilterVersion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDownloadsFilterVersion_SelectedIndexChanged);
            // 
            // LabelDownloadsFilterVersion
            // 
            this.LabelDownloadsFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDownloadsFilterVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelDownloadsFilterVersion.Appearance.Options.UseFont = true;
            this.LabelDownloadsFilterVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelDownloadsFilterVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDownloadsFilterVersion.Location = new System.Drawing.Point(1056, 20);
            this.LabelDownloadsFilterVersion.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelDownloadsFilterVersion.Name = "LabelDownloadsFilterVersion";
            this.LabelDownloadsFilterVersion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelDownloadsFilterVersion.Size = new System.Drawing.Size(48, 15);
            this.LabelDownloadsFilterVersion.TabIndex = 1176;
            this.LabelDownloadsFilterVersion.Text = "Version";
            // 
            // ComboBoxDownloadsFilterModType
            // 
            this.ComboBoxDownloadsFilterModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxDownloadsFilterModType.Location = new System.Drawing.Point(872, 40);
            this.ComboBoxDownloadsFilterModType.MenuManager = this.MainMenu;
            this.ComboBoxDownloadsFilterModType.Name = "ComboBoxDownloadsFilterModType";
            this.ComboBoxDownloadsFilterModType.Properties.AllowFocused = false;
            this.ComboBoxDownloadsFilterModType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxDownloadsFilterModType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxDownloadsFilterModType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxDownloadsFilterModType.Properties.Appearance.Options.UseBackColor = true;
            this.ComboBoxDownloadsFilterModType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxDownloadsFilterModType.Properties.AutoComplete = false;
            this.ComboBoxDownloadsFilterModType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxDownloadsFilterModType.Properties.DropDownRows = 15;
            this.ComboBoxDownloadsFilterModType.Properties.Items.AddRange(new object[] {
            "<All>"});
            this.ComboBoxDownloadsFilterModType.Properties.NullValuePrompt = "Select...";
            this.ComboBoxDownloadsFilterModType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxDownloadsFilterModType.Size = new System.Drawing.Size(93, 22);
            this.ComboBoxDownloadsFilterModType.TabIndex = 1173;
            this.ComboBoxDownloadsFilterModType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDownloadsFilterModType_SelectedIndexChanged);
            // 
            // LabelDownloadsFilterModType
            // 
            this.LabelDownloadsFilterModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDownloadsFilterModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelDownloadsFilterModType.Appearance.Options.UseFont = true;
            this.LabelDownloadsFilterModType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelDownloadsFilterModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDownloadsFilterModType.Location = new System.Drawing.Point(869, 20);
            this.LabelDownloadsFilterModType.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelDownloadsFilterModType.Name = "LabelDownloadsFilterModType";
            this.LabelDownloadsFilterModType.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelDownloadsFilterModType.Size = new System.Drawing.Size(61, 15);
            this.LabelDownloadsFilterModType.TabIndex = 1174;
            this.LabelDownloadsFilterModType.Text = "Mod Type";
            // 
            // ComboBoxDownloadsFilterPlatform
            // 
            this.ComboBoxDownloadsFilterPlatform.Location = new System.Drawing.Point(17, 40);
            this.ComboBoxDownloadsFilterPlatform.MenuManager = this.MainMenu;
            this.ComboBoxDownloadsFilterPlatform.Name = "ComboBoxDownloadsFilterPlatform";
            this.ComboBoxDownloadsFilterPlatform.Properties.AllowFocused = false;
            this.ComboBoxDownloadsFilterPlatform.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxDownloadsFilterPlatform.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxDownloadsFilterPlatform.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxDownloadsFilterPlatform.Properties.AutoComplete = false;
            this.ComboBoxDownloadsFilterPlatform.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxDownloadsFilterPlatform.Properties.DropDownRows = 12;
            this.ComboBoxDownloadsFilterPlatform.Properties.Items.AddRange(new object[] {
            "<All>",
            "PlayStation 3",
            "Xbox 360"});
            this.ComboBoxDownloadsFilterPlatform.Properties.NullValuePrompt = "Select...";
            this.ComboBoxDownloadsFilterPlatform.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxDownloadsFilterPlatform.Size = new System.Drawing.Size(92, 22);
            this.ComboBoxDownloadsFilterPlatform.TabIndex = 3;
            this.ComboBoxDownloadsFilterPlatform.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDownloadsFilterPlatform_SelectedIndexChanged);
            // 
            // LabelDownloadsFilterPlatform
            // 
            this.LabelDownloadsFilterPlatform.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelDownloadsFilterPlatform.Appearance.Options.UseFont = true;
            this.LabelDownloadsFilterPlatform.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelDownloadsFilterPlatform.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDownloadsFilterPlatform.Location = new System.Drawing.Point(14, 20);
            this.LabelDownloadsFilterPlatform.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelDownloadsFilterPlatform.Name = "LabelDownloadsFilterPlatform";
            this.LabelDownloadsFilterPlatform.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelDownloadsFilterPlatform.Size = new System.Drawing.Size(55, 15);
            this.LabelDownloadsFilterPlatform.TabIndex = 1122;
            this.LabelDownloadsFilterPlatform.Text = "Platform";
            // 
            // separatorControl3
            // 
            this.separatorControl3.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl3.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl3.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separatorControl3.LineThickness = 3;
            this.separatorControl3.Location = new System.Drawing.Point(0, 67);
            this.separatorControl3.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.separatorControl3.Size = new System.Drawing.Size(1251, 3);
            this.separatorControl3.TabIndex = 1172;
            // 
            // ComboBoxDownloadsFilterCategory
            // 
            this.ComboBoxDownloadsFilterCategory.Location = new System.Drawing.Point(115, 40);
            this.ComboBoxDownloadsFilterCategory.MenuManager = this.MainMenu;
            this.ComboBoxDownloadsFilterCategory.Name = "ComboBoxDownloadsFilterCategory";
            this.ComboBoxDownloadsFilterCategory.Properties.AllowFocused = false;
            this.ComboBoxDownloadsFilterCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxDownloadsFilterCategory.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxDownloadsFilterCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxDownloadsFilterCategory.Properties.Appearance.Options.UseBackColor = true;
            this.ComboBoxDownloadsFilterCategory.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxDownloadsFilterCategory.Properties.AutoComplete = false;
            this.ComboBoxDownloadsFilterCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxDownloadsFilterCategory.Properties.DropDownRows = 15;
            this.ComboBoxDownloadsFilterCategory.Properties.Items.AddRange(new object[] {
            "<All Categories>"});
            this.ComboBoxDownloadsFilterCategory.Properties.NullValuePrompt = "Select...";
            this.ComboBoxDownloadsFilterCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxDownloadsFilterCategory.Size = new System.Drawing.Size(220, 22);
            this.ComboBoxDownloadsFilterCategory.TabIndex = 1170;
            this.ComboBoxDownloadsFilterCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDownloadsFilterCategory_SelectedIndexChanged);
            // 
            // LabelDownloadsFilterCategory
            // 
            this.LabelDownloadsFilterCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelDownloadsFilterCategory.Appearance.Options.UseFont = true;
            this.LabelDownloadsFilterCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelDownloadsFilterCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDownloadsFilterCategory.Location = new System.Drawing.Point(112, 20);
            this.LabelDownloadsFilterCategory.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelDownloadsFilterCategory.Name = "LabelDownloadsFilterCategory";
            this.LabelDownloadsFilterCategory.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelDownloadsFilterCategory.Size = new System.Drawing.Size(56, 15);
            this.LabelDownloadsFilterCategory.TabIndex = 1171;
            this.LabelDownloadsFilterCategory.Text = "Category";
            // 
            // TextBoxDownloadsFilterFileName
            // 
            this.TextBoxDownloadsFilterFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDownloadsFilterFileName.Location = new System.Drawing.Point(341, 40);
            this.TextBoxDownloadsFilterFileName.MenuManager = this.MainMenu;
            this.TextBoxDownloadsFilterFileName.Name = "TextBoxDownloadsFilterFileName";
            this.TextBoxDownloadsFilterFileName.Properties.AllowFocused = false;
            this.TextBoxDownloadsFilterFileName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TextBoxDownloadsFilterFileName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TextBoxDownloadsFilterFileName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDownloadsFilterFileName.Properties.Appearance.Options.UseBackColor = true;
            this.TextBoxDownloadsFilterFileName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxDownloadsFilterFileName.Properties.NullValuePrompt = "Search...";
            this.TextBoxDownloadsFilterFileName.Size = new System.Drawing.Size(525, 22);
            this.TextBoxDownloadsFilterFileName.TabIndex = 1;
            this.TextBoxDownloadsFilterFileName.EditValueChanged += new System.EventHandler(this.TextBoxDownloadsFilterFileName_EditValueChanged);
            // 
            // LabelDownloadsFilterName
            // 
            this.LabelDownloadsFilterName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelDownloadsFilterName.Appearance.Options.UseFont = true;
            this.LabelDownloadsFilterName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelDownloadsFilterName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDownloadsFilterName.Location = new System.Drawing.Point(338, 20);
            this.LabelDownloadsFilterName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelDownloadsFilterName.Name = "LabelDownloadsFilterName";
            this.LabelDownloadsFilterName.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelDownloadsFilterName.Size = new System.Drawing.Size(39, 15);
            this.LabelDownloadsFilterName.TabIndex = 1157;
            this.LabelDownloadsFilterName.Text = "Name";
            // 
            // PanelActionsDownloads
            // 
            this.PanelActionsDownloads.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelActionsDownloads.Controls.Add(this.TileControlDownloads);
            this.PanelActionsDownloads.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelActionsDownloads.Location = new System.Drawing.Point(0, 0);
            this.PanelActionsDownloads.Margin = new System.Windows.Forms.Padding(0);
            this.PanelActionsDownloads.Name = "PanelActionsDownloads";
            this.PanelActionsDownloads.Size = new System.Drawing.Size(1281, 70);
            this.PanelActionsDownloads.TabIndex = 14;
            // 
            // TileControlDownloads
            // 
            this.TileControlDownloads.AllowDrag = false;
            this.TileControlDownloads.AllowDragTilesBetweenGroups = false;
            this.TileControlDownloads.AllowGlyphSkinning = true;
            this.TileControlDownloads.AllowItemHover = true;
            this.TileControlDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TileControlDownloads.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileControlDownloads.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileControlDownloads.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileControlDownloads.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileControlDownloads.Groups.Add(this.TileGroupDownloads);
            this.TileControlDownloads.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TileControlDownloads.IndentBetweenGroups = 0;
            this.TileControlDownloads.IndentBetweenItems = 2;
            this.TileControlDownloads.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            this.TileControlDownloads.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade;
            this.TileControlDownloads.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileControlDownloads.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.TileControlDownloads.ItemPadding = new System.Windows.Forms.Padding(0);
            this.TileControlDownloads.Location = new System.Drawing.Point(6, 5);
            this.TileControlDownloads.MaxId = 9;
            this.TileControlDownloads.Name = "TileControlDownloads";
            this.TileControlDownloads.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TileControlDownloads.Padding = new System.Windows.Forms.Padding(0);
            this.TileControlDownloads.Size = new System.Drawing.Size(332, 67);
            this.TileControlDownloads.TabIndex = 0;
            this.TileControlDownloads.Text = "tileControl1";
            // 
            // TileGroupDownloads
            // 
            this.TileGroupDownloads.Items.Add(this.TileItemDownloadsOpenFolder);
            this.TileGroupDownloads.Items.Add(this.TileItemDownloadsOpenFile);
            this.TileGroupDownloads.Items.Add(this.TileItemDownloadsDeleteAllItems);
            this.TileGroupDownloads.Items.Add(this.TileItemDownloadsDeleteItem);
            this.TileGroupDownloads.Items.Add(this.TileItemDownloadsViewDetails);
            this.TileGroupDownloads.Name = "TileGroupDownloads";
            this.TileGroupDownloads.Text = "Downloads Actions";
            // 
            // TileItemDownloadsOpenFolder
            // 
            this.TileItemDownloadsOpenFolder.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemDownloadsOpenFolder.AppearanceItem.Disabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(183)))));
            this.TileItemDownloadsOpenFolder.AppearanceItem.Disabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TileItemDownloadsOpenFolder.AppearanceItem.Disabled.Options.UseBackColor = true;
            this.TileItemDownloadsOpenFolder.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemDownloadsOpenFolder.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemDownloadsOpenFolder.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemDownloadsOpenFolder.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemDownloadsOpenFolder.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemDownloadsOpenFolder.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemDownloadsOpenFolder.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemDownloadsOpenFolder.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement19.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement19.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement19.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement19.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement19.ImageOptions.ImageToTextIndent = 2;
            tileItemElement19.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage4")));
            tileItemElement19.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement19.Text = "Open Folder";
            tileItemElement19.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemDownloadsOpenFolder.Elements.Add(tileItemElement19);
            this.TileItemDownloadsOpenFolder.Id = 0;
            this.TileItemDownloadsOpenFolder.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemDownloadsOpenFolder.Name = "TileItemDownloadsOpenFolder";
            this.TileItemDownloadsOpenFolder.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemDownloadsOpenFolder.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemDownloadsOpenFolder_ItemClick);
            // 
            // TileItemDownloadsOpenFile
            // 
            this.TileItemDownloadsOpenFile.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemDownloadsOpenFile.AppearanceItem.Disabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(183)))));
            this.TileItemDownloadsOpenFile.AppearanceItem.Disabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TileItemDownloadsOpenFile.AppearanceItem.Disabled.Options.UseBackColor = true;
            this.TileItemDownloadsOpenFile.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemDownloadsOpenFile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemDownloadsOpenFile.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemDownloadsOpenFile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemDownloadsOpenFile.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemDownloadsOpenFile.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemDownloadsOpenFile.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemDownloadsOpenFile.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement20.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement20.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement20.ImageOptions.ImageSize = new System.Drawing.Size(24, 24);
            tileItemElement20.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement20.ImageOptions.ImageToTextIndent = 2;
            tileItemElement20.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage5")));
            tileItemElement20.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement20.Text = "Open File";
            tileItemElement20.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemDownloadsOpenFile.Elements.Add(tileItemElement20);
            this.TileItemDownloadsOpenFile.Enabled = false;
            this.TileItemDownloadsOpenFile.Id = 0;
            this.TileItemDownloadsOpenFile.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemDownloadsOpenFile.Name = "TileItemDownloadsOpenFile";
            this.TileItemDownloadsOpenFile.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemDownloadsOpenFile.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemDownloadsOpenFile_ItemClick);
            // 
            // TileItemDownloadsDeleteAllItems
            // 
            this.TileItemDownloadsDeleteAllItems.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemDownloadsDeleteAllItems.AppearanceItem.Disabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(183)))));
            this.TileItemDownloadsDeleteAllItems.AppearanceItem.Disabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TileItemDownloadsDeleteAllItems.AppearanceItem.Disabled.Options.UseBackColor = true;
            this.TileItemDownloadsDeleteAllItems.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemDownloadsDeleteAllItems.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemDownloadsDeleteAllItems.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemDownloadsDeleteAllItems.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemDownloadsDeleteAllItems.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemDownloadsDeleteAllItems.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemDownloadsDeleteAllItems.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemDownloadsDeleteAllItems.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement21.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement21.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement21.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement21.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement21.ImageOptions.ImageToTextIndent = 2;
            tileItemElement21.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage6")));
            tileItemElement21.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement21.Text = "Delete All Items";
            tileItemElement21.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemDownloadsDeleteAllItems.Elements.Add(tileItemElement21);
            this.TileItemDownloadsDeleteAllItems.Enabled = false;
            this.TileItemDownloadsDeleteAllItems.Id = 1;
            this.TileItemDownloadsDeleteAllItems.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemDownloadsDeleteAllItems.Name = "TileItemDownloadsDeleteAllItems";
            this.TileItemDownloadsDeleteAllItems.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemDownloadsDeleteAllItems.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemDownloadsDeleteAllItems_ItemClick);
            // 
            // TileItemDownloadsDeleteItem
            // 
            this.TileItemDownloadsDeleteItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemDownloadsDeleteItem.AppearanceItem.Disabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(183)))));
            this.TileItemDownloadsDeleteItem.AppearanceItem.Disabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TileItemDownloadsDeleteItem.AppearanceItem.Disabled.Options.UseBackColor = true;
            this.TileItemDownloadsDeleteItem.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemDownloadsDeleteItem.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemDownloadsDeleteItem.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemDownloadsDeleteItem.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemDownloadsDeleteItem.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemDownloadsDeleteItem.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemDownloadsDeleteItem.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemDownloadsDeleteItem.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement22.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement22.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement22.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement22.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement22.ImageOptions.ImageToTextIndent = 2;
            tileItemElement22.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage7")));
            tileItemElement22.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement22.Text = "Delete Item";
            tileItemElement22.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemDownloadsDeleteItem.Elements.Add(tileItemElement22);
            this.TileItemDownloadsDeleteItem.Enabled = false;
            this.TileItemDownloadsDeleteItem.Id = 2;
            this.TileItemDownloadsDeleteItem.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemDownloadsDeleteItem.Name = "TileItemDownloadsDeleteItem";
            this.TileItemDownloadsDeleteItem.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemDownloadsDeleteItem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemDownloadsDeleteItem_ItemClick);
            // 
            // TileItemDownloadsViewDetails
            // 
            this.TileItemDownloadsViewDetails.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemDownloadsViewDetails.AppearanceItem.Disabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(183)))));
            this.TileItemDownloadsViewDetails.AppearanceItem.Disabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TileItemDownloadsViewDetails.AppearanceItem.Disabled.Options.UseBackColor = true;
            this.TileItemDownloadsViewDetails.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemDownloadsViewDetails.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemDownloadsViewDetails.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemDownloadsViewDetails.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemDownloadsViewDetails.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemDownloadsViewDetails.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemDownloadsViewDetails.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemDownloadsViewDetails.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement23.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement23.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement23.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement23.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement23.ImageOptions.ImageToTextIndent = 2;
            tileItemElement23.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage8")));
            tileItemElement23.Text = "View Details";
            tileItemElement23.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemDownloadsViewDetails.Elements.Add(tileItemElement23);
            this.TileItemDownloadsViewDetails.Enabled = false;
            this.TileItemDownloadsViewDetails.Id = 8;
            this.TileItemDownloadsViewDetails.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemDownloadsViewDetails.Name = "TileItemDownloadsViewDetails";
            this.TileItemDownloadsViewDetails.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemDownloadsViewDetails.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemDownloadsViewDetails_ItemClick);
            // 
            // PanelGameModsActions
            // 
            this.PanelGameModsActions.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelGameModsActions.Controls.Add(this.TileControlGameMods);
            this.PanelGameModsActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelGameModsActions.Location = new System.Drawing.Point(0, 0);
            this.PanelGameModsActions.Margin = new System.Windows.Forms.Padding(0);
            this.PanelGameModsActions.Name = "PanelGameModsActions";
            this.PanelGameModsActions.Size = new System.Drawing.Size(1281, 70);
            this.PanelGameModsActions.TabIndex = 13;
            // 
            // TileControlGameMods
            // 
            this.TileControlGameMods.AllowDisabledStateIndication = false;
            this.TileControlGameMods.AllowDrag = false;
            this.TileControlGameMods.AllowDragTilesBetweenGroups = false;
            this.TileControlGameMods.AllowGlyphSkinning = true;
            this.TileControlGameMods.AllowItemHover = true;
            this.TileControlGameMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TileControlGameMods.Groups.Add(this.TileGroupGameMods);
            this.TileControlGameMods.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TileControlGameMods.IndentBetweenItems = 2;
            this.TileControlGameMods.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade;
            this.TileControlGameMods.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileControlGameMods.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.TileControlGameMods.ItemPadding = new System.Windows.Forms.Padding(0);
            this.TileControlGameMods.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.TileControlGameMods.Location = new System.Drawing.Point(6, 5);
            this.TileControlGameMods.MaxId = 7;
            this.TileControlGameMods.Name = "TileControlGameMods";
            this.TileControlGameMods.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TileControlGameMods.Padding = new System.Windows.Forms.Padding(0);
            this.TileControlGameMods.Size = new System.Drawing.Size(332, 67);
            this.TileControlGameMods.TabIndex = 0;
            this.TileControlGameMods.Text = "TileControlModsActions";
            // 
            // TileGroupGameMods
            // 
            this.TileGroupGameMods.Items.Add(this.TileItemGameModsShowFavorites);
            this.TileGroupGameMods.Items.Add(this.TileItemGameModsSortBy);
            this.TileGroupGameMods.Name = "TileGroupGameMods";
            this.TileGroupGameMods.Text = "Game Mods Actions";
            // 
            // TileItemGameModsShowFavorites
            // 
            this.TileItemGameModsShowFavorites.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemGameModsShowFavorites.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileItemGameModsShowFavorites.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemGameModsShowFavorites.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemGameModsShowFavorites.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemGameModsShowFavorites.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemGameModsShowFavorites.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemGameModsShowFavorites.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemGameModsShowFavorites.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemGameModsShowFavorites.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemGameModsShowFavorites.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement24.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement24.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement24.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement24.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement24.ImageOptions.ImageToTextIndent = 2;
            tileItemElement24.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage9")));
            tileItemElement24.Text = "Show Favorites";
            tileItemElement24.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemGameModsShowFavorites.Elements.Add(tileItemElement24);
            this.TileItemGameModsShowFavorites.Id = 6;
            this.TileItemGameModsShowFavorites.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemGameModsShowFavorites.Name = "TileItemGameModsShowFavorites";
            this.TileItemGameModsShowFavorites.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemGameModsShowFavorites.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemGameModsShowFavorites_ItemClick);
            // 
            // TileItemGameModsSortBy
            // 
            this.TileItemGameModsSortBy.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemGameModsSortBy.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileItemGameModsSortBy.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemGameModsSortBy.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemGameModsSortBy.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemGameModsSortBy.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemGameModsSortBy.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemGameModsSortBy.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemGameModsSortBy.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemGameModsSortBy.AppearanceItem.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.TileItemGameModsSortBy.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement25.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            tileItemElement25.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement25.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement25.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement25.ImageOptions.ImageToTextIndent = 2;
            tileItemElement25.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement25.Text = "Sort By";
            tileItemElement25.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemGameModsSortBy.Elements.Add(tileItemElement25);
            this.TileItemGameModsSortBy.Id = 1;
            this.TileItemGameModsSortBy.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemGameModsSortBy.Name = "TileItemGameModsSortBy";
            this.TileItemGameModsSortBy.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemGameModsSortBy.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemGameModsSortBy_ItemClick);
            // 
            // PanelGameMods
            // 
            this.PanelGameMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelGameMods.BackColor = System.Drawing.Color.Transparent;
            this.PanelGameMods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelGameMods.Controls.Add(this.GridControlGameMods);
            this.PanelGameMods.Controls.Add(this.PanelGameModsFilters);
            this.PanelGameMods.Location = new System.Drawing.Point(14, 84);
            this.PanelGameMods.Margin = new System.Windows.Forms.Padding(14);
            this.PanelGameMods.Name = "PanelGameMods";
            this.PanelGameMods.Size = new System.Drawing.Size(1253, 614);
            this.PanelGameMods.TabIndex = 7;
            // 
            // PageGameMods
            // 
            this.PageGameMods.Appearance.Options.UseFont = true;
            this.PageGameMods.Controls.Add(this.PanelGameMods);
            this.PageGameMods.Controls.Add(this.PanelGameModsActions);
            this.PageGameMods.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PageGameMods.Name = "PageGameMods";
            this.PageGameMods.Size = new System.Drawing.Size(1281, 712);
            // 
            // NavigationFrame
            // 
            this.NavigationFrame.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.NavigationFrame.Controls.Add(this.PageDashboard);
            this.NavigationFrame.Controls.Add(this.PageInstalledMods);
            this.NavigationFrame.Controls.Add(this.PageDownloads);
            this.NavigationFrame.Controls.Add(this.PageFileManager);
            this.NavigationFrame.Controls.Add(this.PageSettings);
            this.NavigationFrame.Controls.Add(this.PageGameMods);
            this.NavigationFrame.Controls.Add(this.PageGameSaves);
            this.NavigationFrame.Controls.Add(this.PagePlugins);
            this.NavigationFrame.Controls.Add(this.PagePackages);
            this.NavigationFrame.Controls.Add(this.PageRealTimeMods);
            this.NavigationFrame.Controls.Add(this.PageResources);
            this.NavigationFrame.Controls.Add(this.PageHomebrew);
            this.NavigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationFrame.Location = new System.Drawing.Point(247, 32);
            this.NavigationFrame.LookAndFeel.SkinName = "Office 2019 Black";
            this.NavigationFrame.Name = "NavigationFrame";
            this.NavigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageDashboard,
            this.PageDownloads,
            this.PageInstalledMods,
            this.PageFileManager,
            this.PageSettings,
            this.PageGameMods,
            this.PageHomebrew,
            this.PageResources,
            this.PagePackages,
            this.PagePlugins,
            this.PageGameSaves,
            this.PageRealTimeMods});
            this.NavigationFrame.SelectedPage = this.PageDashboard;
            this.NavigationFrame.Size = new System.Drawing.Size(1281, 712);
            this.NavigationFrame.TabIndex = 1;
            this.NavigationFrame.Text = "Navigation Frame";
            this.NavigationFrame.TransitionAnimationProperties.FrameCount = 100;
            this.NavigationFrame.TransitionAnimationProperties.FrameInterval = 100;
            this.NavigationFrame.TransitionType = DevExpress.Utils.Animation.Transitions.Fade;
            // 
            // PageDashboard
            // 
            this.PageDashboard.Appearance.Options.UseFont = true;
            this.PageDashboard.Controls.Add(this.PanelStatistics);
            this.PageDashboard.Controls.Add(this.PanelSetupItems);
            this.PageDashboard.Controls.Add(this.PanelAnnouncements);
            this.PageDashboard.Controls.Add(this.PanelChangeLog);
            this.PageDashboard.Controls.Add(this.PanelLatestNews);
            this.PageDashboard.Controls.Add(this.PanelToolItems);
            this.PageDashboard.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PageDashboard.Name = "PageDashboard";
            this.PageDashboard.Padding = new System.Windows.Forms.Padding(16);
            this.PageDashboard.Size = new System.Drawing.Size(1281, 712);
            // 
            // PanelStatistics
            // 
            this.PanelStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelStatistics.Controls.Add(this.PanelStatisticsText);
            this.PanelStatistics.Controls.Add(this.LabelHeaderStatistics);
            this.PanelStatistics.Location = new System.Drawing.Point(576, 441);
            this.PanelStatistics.Margin = new System.Windows.Forms.Padding(7);
            this.PanelStatistics.MinimumSize = new System.Drawing.Size(256, 208);
            this.PanelStatistics.Name = "PanelStatistics";
            this.PanelStatistics.Size = new System.Drawing.Size(256, 208);
            this.PanelStatistics.TabIndex = 6;
            // 
            // PanelStatisticsText
            // 
            this.PanelStatisticsText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelStatisticsText.Controls.Add(this.LabelStatisticsLastUpdated);
            this.PanelStatisticsText.Controls.Add(this.LabelStatisticsHeaderXbox360);
            this.PanelStatisticsText.Controls.Add(this.LabelStatisticsXbox360);
            this.PanelStatisticsText.Controls.Add(this.LabelStatisticsHeaderPlayStation3);
            this.PanelStatisticsText.Controls.Add(this.LabelStatisticsPlayStation3);
            this.PanelStatisticsText.Location = new System.Drawing.Point(12, 37);
            this.PanelStatisticsText.Name = "PanelStatisticsText";
            this.PanelStatisticsText.Size = new System.Drawing.Size(239, 162);
            this.PanelStatisticsText.TabIndex = 1;
            // 
            // LabelStatisticsLastUpdated
            // 
            this.LabelStatisticsLastUpdated.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelStatisticsLastUpdated.Appearance.Options.UseFont = true;
            this.LabelStatisticsLastUpdated.Location = new System.Drawing.Point(0, 141);
            this.LabelStatisticsLastUpdated.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.LabelStatisticsLastUpdated.Name = "LabelStatisticsLastUpdated";
            this.LabelStatisticsLastUpdated.Size = new System.Drawing.Size(151, 17);
            this.LabelStatisticsLastUpdated.TabIndex = 7;
            this.LabelStatisticsLastUpdated.Text = "Last Updated: 00/00/0000";
            // 
            // LabelStatisticsHeaderXbox360
            // 
            this.LabelStatisticsHeaderXbox360.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelStatisticsHeaderXbox360.Appearance.Options.UseFont = true;
            this.LabelStatisticsHeaderXbox360.Location = new System.Drawing.Point(0, 78);
            this.LabelStatisticsHeaderXbox360.Name = "LabelStatisticsHeaderXbox360";
            this.LabelStatisticsHeaderXbox360.Size = new System.Drawing.Size(56, 17);
            this.LabelStatisticsHeaderXbox360.TabIndex = 5;
            this.LabelStatisticsHeaderXbox360.Text = "Xbox 360";
            // 
            // LabelStatisticsXbox360
            // 
            this.LabelStatisticsXbox360.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelStatisticsXbox360.Appearance.Options.UseFont = true;
            this.LabelStatisticsXbox360.Location = new System.Drawing.Point(0, 99);
            this.LabelStatisticsXbox360.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.LabelStatisticsXbox360.Name = "LabelStatisticsXbox360";
            this.LabelStatisticsXbox360.Size = new System.Drawing.Size(115, 34);
            this.LabelStatisticsXbox360.TabIndex = 6;
            this.LabelStatisticsXbox360.Text = "0 Plugins Total\r\n0 Game Saves Total";
            // 
            // LabelStatisticsHeaderPlayStation3
            // 
            this.LabelStatisticsHeaderPlayStation3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatisticsHeaderPlayStation3.Appearance.Options.UseFont = true;
            this.LabelStatisticsHeaderPlayStation3.Location = new System.Drawing.Point(0, 0);
            this.LabelStatisticsHeaderPlayStation3.Name = "LabelStatisticsHeaderPlayStation3";
            this.LabelStatisticsHeaderPlayStation3.Size = new System.Drawing.Size(79, 17);
            this.LabelStatisticsHeaderPlayStation3.TabIndex = 3;
            this.LabelStatisticsHeaderPlayStation3.Text = "PlayStation 3";
            // 
            // LabelStatisticsPlayStation3
            // 
            this.LabelStatisticsPlayStation3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelStatisticsPlayStation3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelStatisticsPlayStation3.Appearance.Options.UseFont = true;
            this.LabelStatisticsPlayStation3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelStatisticsPlayStation3.Location = new System.Drawing.Point(0, 21);
            this.LabelStatisticsPlayStation3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.LabelStatisticsPlayStation3.Name = "LabelStatisticsPlayStation3";
            this.LabelStatisticsPlayStation3.Size = new System.Drawing.Size(222, 51);
            this.LabelStatisticsPlayStation3.TabIndex = 4;
            this.LabelStatisticsPlayStation3.Text = "0 Mods Total\r\n0 Packages Total\r\n0 Game Saves Total";
            // 
            // LabelHeaderStatistics
            // 
            this.LabelHeaderStatistics.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderStatistics.Appearance.Options.UseFont = true;
            this.LabelHeaderStatistics.Location = new System.Drawing.Point(12, 10);
            this.LabelHeaderStatistics.Name = "LabelHeaderStatistics";
            this.LabelHeaderStatistics.Size = new System.Drawing.Size(85, 21);
            this.LabelHeaderStatistics.TabIndex = 0;
            this.LabelHeaderStatistics.Text = "STATISTICS";
            // 
            // PageInstalledMods
            // 
            this.PageInstalledMods.Appearance.Options.UseFont = true;
            this.PageInstalledMods.Controls.Add(this.PanelInstalledMods);
            this.PageInstalledMods.Controls.Add(this.PanelInstalledModsActions);
            this.PageInstalledMods.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PageInstalledMods.Name = "PageInstalledMods";
            this.PageInstalledMods.Size = new System.Drawing.Size(1281, 712);
            // 
            // PageDownloads
            // 
            this.PageDownloads.Appearance.Options.UseFont = true;
            this.PageDownloads.Controls.Add(this.PanelDownloads);
            this.PageDownloads.Controls.Add(this.PanelActionsDownloads);
            this.PageDownloads.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PageDownloads.Name = "PageDownloads";
            this.PageDownloads.Size = new System.Drawing.Size(1281, 712);
            // 
            // PageFileManager
            // 
            this.PageFileManager.Appearance.Options.UseFont = true;
            this.PageFileManager.Controls.Add(this.PanelFileManager);
            this.PageFileManager.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.PageFileManager.Name = "PageFileManager";
            this.PageFileManager.Size = new System.Drawing.Size(1281, 712);
            // 
            // PanelFileManager
            // 
            this.PanelFileManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelFileManager.ColumnCount = 2;
            this.PanelFileManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelFileManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelFileManager.Controls.Add(this.GroupConsoleFileExplorer, 1, 0);
            this.PanelFileManager.Controls.Add(this.GroupLocalFileExplorer, 0, 0);
            this.PanelFileManager.Location = new System.Drawing.Point(14, 14);
            this.PanelFileManager.Margin = new System.Windows.Forms.Padding(14);
            this.PanelFileManager.Name = "PanelFileManager";
            this.PanelFileManager.RowCount = 1;
            this.PanelFileManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelFileManager.Size = new System.Drawing.Size(1253, 684);
            this.PanelFileManager.TabIndex = 1215;
            // 
            // GroupConsoleFileExplorer
            // 
            this.GroupConsoleFileExplorer.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.GroupConsoleFileExplorer.AppearanceCaption.Options.UseFont = true;
            this.GroupConsoleFileExplorer.Controls.Add(this.PanelFileManagerConsoleButtons);
            this.GroupConsoleFileExplorer.Controls.Add(this.PanelFileManagerConsoleStatus);
            this.GroupConsoleFileExplorer.Controls.Add(this.GridControlFileManagerConsoleFiles);
            this.GroupConsoleFileExplorer.Controls.Add(this.ButtonFileManagerConsoleNavigate);
            this.GroupConsoleFileExplorer.Controls.Add(this.TextBoxFileManagerConsolePath);
            this.GroupConsoleFileExplorer.Controls.Add(this.ComboBoxFileManagerConsoleDrives);
            this.GroupConsoleFileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupConsoleFileExplorer.Location = new System.Drawing.Point(631, 0);
            this.GroupConsoleFileExplorer.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.GroupConsoleFileExplorer.Name = "GroupConsoleFileExplorer";
            this.GroupConsoleFileExplorer.Size = new System.Drawing.Size(622, 684);
            this.GroupConsoleFileExplorer.TabIndex = 14;
            this.GroupConsoleFileExplorer.Text = "CONSOLE FILE EXPLORER";
            // 
            // PanelFileManagerConsoleButtons
            // 
            this.PanelFileManagerConsoleButtons.Controls.Add(this.ButtonFileManagerConsoleDownload);
            this.PanelFileManagerConsoleButtons.Controls.Add(this.ButtonFileManagerConsoleDelete);
            this.PanelFileManagerConsoleButtons.Controls.Add(this.ButtonFileManagerConsoleRename);
            this.PanelFileManagerConsoleButtons.Controls.Add(this.ButtonFileManagerConsoleNewFolder);
            this.PanelFileManagerConsoleButtons.Controls.Add(this.ButtonFileManagerConsoleRefresh);
            this.PanelFileManagerConsoleButtons.Controls.Add(this.ButtonFileManagerConsoleAddToGames);
            this.PanelFileManagerConsoleButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFileManagerConsoleButtons.Location = new System.Drawing.Point(2, 612);
            this.PanelFileManagerConsoleButtons.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.PanelFileManagerConsoleButtons.Name = "PanelFileManagerConsoleButtons";
            this.PanelFileManagerConsoleButtons.Size = new System.Drawing.Size(618, 42);
            this.PanelFileManagerConsoleButtons.TabIndex = 3;
            // 
            // ButtonFileManagerConsoleDownload
            // 
            this.ButtonFileManagerConsoleDownload.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFileManagerConsoleDownload.Appearance.Options.UseFont = true;
            this.ButtonFileManagerConsoleDownload.Enabled = false;
            this.ButtonFileManagerConsoleDownload.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFileManagerConsoleDownload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFileManagerConsoleDownload.ImageOptions.ImageToTextIndent = 4;
            this.ButtonFileManagerConsoleDownload.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFileManagerConsoleDownload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFileManagerConsoleDownload.ImageOptions.SvgImage")));
            this.ButtonFileManagerConsoleDownload.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFileManagerConsoleDownload.Location = new System.Drawing.Point(9, 8);
            this.ButtonFileManagerConsoleDownload.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.ButtonFileManagerConsoleDownload.Name = "ButtonFileManagerConsoleDownload";
            this.ButtonFileManagerConsoleDownload.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerConsoleDownload.Size = new System.Drawing.Size(98, 25);
            this.ButtonFileManagerConsoleDownload.TabIndex = 8;
            this.ButtonFileManagerConsoleDownload.Text = "Download";
            this.ButtonFileManagerConsoleDownload.Click += new System.EventHandler(this.ButtonConsoleDownload_Click);
            // 
            // ButtonFileManagerConsoleDelete
            // 
            this.ButtonFileManagerConsoleDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFileManagerConsoleDelete.Appearance.Options.UseFont = true;
            this.ButtonFileManagerConsoleDelete.Enabled = false;
            this.ButtonFileManagerConsoleDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFileManagerConsoleDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFileManagerConsoleDelete.ImageOptions.ImageToTextIndent = 4;
            this.ButtonFileManagerConsoleDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFileManagerConsoleDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFileManagerConsoleDelete.ImageOptions.SvgImage")));
            this.ButtonFileManagerConsoleDelete.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFileManagerConsoleDelete.Location = new System.Drawing.Point(113, 8);
            this.ButtonFileManagerConsoleDelete.Name = "ButtonFileManagerConsoleDelete";
            this.ButtonFileManagerConsoleDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerConsoleDelete.Size = new System.Drawing.Size(78, 25);
            this.ButtonFileManagerConsoleDelete.TabIndex = 9;
            this.ButtonFileManagerConsoleDelete.Text = "Delete";
            this.ButtonFileManagerConsoleDelete.Click += new System.EventHandler(this.ButtonConsoleDelete_Click);
            // 
            // ButtonFileManagerConsoleRename
            // 
            this.ButtonFileManagerConsoleRename.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFileManagerConsoleRename.Appearance.Options.UseFont = true;
            this.ButtonFileManagerConsoleRename.Enabled = false;
            this.ButtonFileManagerConsoleRename.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFileManagerConsoleRename.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFileManagerConsoleRename.ImageOptions.ImageToTextIndent = 4;
            this.ButtonFileManagerConsoleRename.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFileManagerConsoleRename.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFileManagerConsoleRename.ImageOptions.SvgImage")));
            this.ButtonFileManagerConsoleRename.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFileManagerConsoleRename.Location = new System.Drawing.Point(197, 8);
            this.ButtonFileManagerConsoleRename.Name = "ButtonFileManagerConsoleRename";
            this.ButtonFileManagerConsoleRename.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerConsoleRename.Size = new System.Drawing.Size(87, 25);
            this.ButtonFileManagerConsoleRename.TabIndex = 10;
            this.ButtonFileManagerConsoleRename.Text = "Rename";
            this.ButtonFileManagerConsoleRename.Click += new System.EventHandler(this.ButtonConsoleRename_Click);
            // 
            // ButtonFileManagerConsoleNewFolder
            // 
            this.ButtonFileManagerConsoleNewFolder.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFileManagerConsoleNewFolder.Appearance.Options.UseFont = true;
            this.ButtonFileManagerConsoleNewFolder.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFileManagerConsoleNewFolder.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFileManagerConsoleNewFolder.ImageOptions.ImageToTextIndent = 4;
            this.ButtonFileManagerConsoleNewFolder.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFileManagerConsoleNewFolder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFileManagerConsoleNewFolder.ImageOptions.SvgImage")));
            this.ButtonFileManagerConsoleNewFolder.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFileManagerConsoleNewFolder.Location = new System.Drawing.Point(290, 8);
            this.ButtonFileManagerConsoleNewFolder.Name = "ButtonFileManagerConsoleNewFolder";
            this.ButtonFileManagerConsoleNewFolder.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerConsoleNewFolder.Size = new System.Drawing.Size(104, 25);
            this.ButtonFileManagerConsoleNewFolder.TabIndex = 11;
            this.ButtonFileManagerConsoleNewFolder.Text = "New Folder";
            this.ButtonFileManagerConsoleNewFolder.Click += new System.EventHandler(this.ButtonConsoleNewFolder_Click);
            // 
            // ButtonFileManagerConsoleRefresh
            // 
            this.ButtonFileManagerConsoleRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFileManagerConsoleRefresh.Appearance.Options.UseFont = true;
            this.ButtonFileManagerConsoleRefresh.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFileManagerConsoleRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFileManagerConsoleRefresh.ImageOptions.ImageToTextIndent = 4;
            this.ButtonFileManagerConsoleRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFileManagerConsoleRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFileManagerConsoleRefresh.ImageOptions.SvgImage")));
            this.ButtonFileManagerConsoleRefresh.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFileManagerConsoleRefresh.Location = new System.Drawing.Point(400, 8);
            this.ButtonFileManagerConsoleRefresh.Name = "ButtonFileManagerConsoleRefresh";
            this.ButtonFileManagerConsoleRefresh.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerConsoleRefresh.Size = new System.Drawing.Size(88, 25);
            this.ButtonFileManagerConsoleRefresh.TabIndex = 12;
            this.ButtonFileManagerConsoleRefresh.Text = "Refresh";
            this.ButtonFileManagerConsoleRefresh.Click += new System.EventHandler(this.ButtonConsoleRefresh_Click);
            // 
            // ButtonFileManagerConsoleAddToGames
            // 
            this.ButtonFileManagerConsoleAddToGames.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFileManagerConsoleAddToGames.Appearance.Options.UseFont = true;
            this.ButtonFileManagerConsoleAddToGames.Enabled = false;
            this.ButtonFileManagerConsoleAddToGames.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFileManagerConsoleAddToGames.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFileManagerConsoleAddToGames.ImageOptions.ImageToTextIndent = 4;
            this.ButtonFileManagerConsoleAddToGames.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFileManagerConsoleAddToGames.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFileManagerConsoleAddToGames.ImageOptions.SvgImage")));
            this.ButtonFileManagerConsoleAddToGames.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFileManagerConsoleAddToGames.Location = new System.Drawing.Point(494, 8);
            this.ButtonFileManagerConsoleAddToGames.Name = "ButtonFileManagerConsoleAddToGames";
            this.ButtonFileManagerConsoleAddToGames.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerConsoleAddToGames.Size = new System.Drawing.Size(120, 25);
            this.ButtonFileManagerConsoleAddToGames.TabIndex = 13;
            this.ButtonFileManagerConsoleAddToGames.Text = "Add to Games";
            this.ButtonFileManagerConsoleAddToGames.Click += new System.EventHandler(this.ButtonConsoleAddToGames_Click);
            // 
            // PanelFileManagerConsoleStatus
            // 
            this.PanelFileManagerConsoleStatus.Controls.Add(this.LabelFileManagerConsoleStatus);
            this.PanelFileManagerConsoleStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFileManagerConsoleStatus.Location = new System.Drawing.Point(2, 654);
            this.PanelFileManagerConsoleStatus.Name = "PanelFileManagerConsoleStatus";
            this.PanelFileManagerConsoleStatus.Size = new System.Drawing.Size(618, 28);
            this.PanelFileManagerConsoleStatus.TabIndex = 1175;
            // 
            // LabelFileManagerConsoleStatus
            // 
            this.LabelFileManagerConsoleStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelFileManagerConsoleStatus.Appearance.Options.UseFont = true;
            this.LabelFileManagerConsoleStatus.Location = new System.Drawing.Point(10, 5);
            this.LabelFileManagerConsoleStatus.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.LabelFileManagerConsoleStatus.Name = "LabelFileManagerConsoleStatus";
            this.LabelFileManagerConsoleStatus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.LabelFileManagerConsoleStatus.Size = new System.Drawing.Size(50, 17);
            this.LabelFileManagerConsoleStatus.TabIndex = 11;
            this.LabelFileManagerConsoleStatus.Text = "Waiting...";
            // 
            // GridControlFileManagerConsoleFiles
            // 
            this.GridControlFileManagerConsoleFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlFileManagerConsoleFiles.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridControlFileManagerConsoleFiles.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.GridControlFileManagerConsoleFiles.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridControlFileManagerConsoleFiles.Location = new System.Drawing.Point(11, 60);
            this.GridControlFileManagerConsoleFiles.MainView = this.GridViewFileManagerConsoleFiles;
            this.GridControlFileManagerConsoleFiles.Margin = new System.Windows.Forms.Padding(6, 3, 6, 0);
            this.GridControlFileManagerConsoleFiles.Name = "GridControlFileManagerConsoleFiles";
            this.GridControlFileManagerConsoleFiles.Size = new System.Drawing.Size(601, 550);
            this.GridControlFileManagerConsoleFiles.TabIndex = 7;
            this.GridControlFileManagerConsoleFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewFileManagerConsoleFiles});
            // 
            // GridViewFileManagerConsoleFiles
            // 
            this.GridViewFileManagerConsoleFiles.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.GridViewFileManagerConsoleFiles.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridViewFileManagerConsoleFiles.Appearance.Row.FontSizeDelta = 1;
            this.GridViewFileManagerConsoleFiles.Appearance.Row.Options.UseFont = true;
            this.GridViewFileManagerConsoleFiles.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewFileManagerConsoleFiles.GridControl = this.GridControlFileManagerConsoleFiles;
            this.GridViewFileManagerConsoleFiles.Name = "GridViewFileManagerConsoleFiles";
            this.GridViewFileManagerConsoleFiles.OptionsBehavior.Editable = false;
            this.GridViewFileManagerConsoleFiles.OptionsBehavior.ReadOnly = true;
            this.GridViewFileManagerConsoleFiles.OptionsCustomization.AllowFilter = false;
            this.GridViewFileManagerConsoleFiles.OptionsFilter.AllowFilterEditor = false;
            this.GridViewFileManagerConsoleFiles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewFileManagerConsoleFiles.OptionsView.ShowGroupPanel = false;
            this.GridViewFileManagerConsoleFiles.OptionsView.ShowIndicator = false;
            this.GridViewFileManagerConsoleFiles.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewConsoleFiles_RowClick);
            this.GridViewFileManagerConsoleFiles.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewConsoleFiles_FocusedRowChanged);
            this.GridViewFileManagerConsoleFiles.DoubleClick += new System.EventHandler(this.GridViewConsoleFiles_DoubleClick);
            // 
            // ButtonFileManagerConsoleNavigate
            // 
            this.ButtonFileManagerConsoleNavigate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFileManagerConsoleNavigate.Location = new System.Drawing.Point(572, 32);
            this.ButtonFileManagerConsoleNavigate.Name = "ButtonFileManagerConsoleNavigate";
            this.ButtonFileManagerConsoleNavigate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerConsoleNavigate.Size = new System.Drawing.Size(40, 22);
            this.ButtonFileManagerConsoleNavigate.TabIndex = 1173;
            this.ButtonFileManagerConsoleNavigate.Text = ">>";
            this.ButtonFileManagerConsoleNavigate.Click += new System.EventHandler(this.ButtonConsoleNavigate_Click);
            // 
            // TextBoxFileManagerConsolePath
            // 
            this.TextBoxFileManagerConsolePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFileManagerConsolePath.Location = new System.Drawing.Point(113, 32);
            this.TextBoxFileManagerConsolePath.Name = "TextBoxFileManagerConsolePath";
            this.TextBoxFileManagerConsolePath.Properties.AllowFocused = false;
            this.TextBoxFileManagerConsolePath.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxFileManagerConsolePath.Properties.Appearance.Options.UseFont = true;
            this.TextBoxFileManagerConsolePath.Size = new System.Drawing.Size(453, 22);
            this.TextBoxFileManagerConsolePath.TabIndex = 1171;
            // 
            // ComboBoxFileManagerConsoleDrives
            // 
            this.ComboBoxFileManagerConsoleDrives.Location = new System.Drawing.Point(11, 32);
            this.ComboBoxFileManagerConsoleDrives.Name = "ComboBoxFileManagerConsoleDrives";
            this.ComboBoxFileManagerConsoleDrives.Properties.AllowFocused = false;
            this.ComboBoxFileManagerConsoleDrives.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxFileManagerConsoleDrives.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxFileManagerConsoleDrives.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxFileManagerConsoleDrives.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxFileManagerConsoleDrives.Size = new System.Drawing.Size(96, 22);
            this.ComboBoxFileManagerConsoleDrives.TabIndex = 0;
            this.ComboBoxFileManagerConsoleDrives.SelectedIndexChanged += new System.EventHandler(this.ComboBoxConsoleDrives_SelectedIndexChanged);
            // 
            // GroupLocalFileExplorer
            // 
            this.GroupLocalFileExplorer.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.GroupLocalFileExplorer.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.GroupLocalFileExplorer.AppearanceCaption.Options.UseFont = true;
            this.GroupLocalFileExplorer.Controls.Add(this.PanelFileManagerLocalButtons);
            this.GroupLocalFileExplorer.Controls.Add(this.PanelFileManagerLocalStatus);
            this.GroupLocalFileExplorer.Controls.Add(this.GridControlFileManagerLocalFiles);
            this.GroupLocalFileExplorer.Controls.Add(this.ButtonFileManagerBrowseLocalDirectory);
            this.GroupLocalFileExplorer.Controls.Add(this.ComboBoxFileManagerLocalDrives);
            this.GroupLocalFileExplorer.Controls.Add(this.TextBoxFileManagerLocalPath);
            this.GroupLocalFileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupLocalFileExplorer.Location = new System.Drawing.Point(0, 0);
            this.GroupLocalFileExplorer.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.GroupLocalFileExplorer.Name = "GroupLocalFileExplorer";
            this.GroupLocalFileExplorer.Size = new System.Drawing.Size(621, 684);
            this.GroupLocalFileExplorer.TabIndex = 13;
            this.GroupLocalFileExplorer.Text = "LOCAL FILE EXPLORER";
            // 
            // PanelFileManagerLocalButtons
            // 
            this.PanelFileManagerLocalButtons.Controls.Add(this.ButtonFileManagerLocalUpload);
            this.PanelFileManagerLocalButtons.Controls.Add(this.ButtonFileManagerLocalDelete);
            this.PanelFileManagerLocalButtons.Controls.Add(this.ButtonFileManagerFileLocalRename);
            this.PanelFileManagerLocalButtons.Controls.Add(this.ButtonFileManagerLocalNewFolder);
            this.PanelFileManagerLocalButtons.Controls.Add(this.ButtonFileManagerLocalRefresh);
            this.PanelFileManagerLocalButtons.Controls.Add(this.ButtonFileManagerLocalOpenExplorer);
            this.PanelFileManagerLocalButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFileManagerLocalButtons.Location = new System.Drawing.Point(2, 612);
            this.PanelFileManagerLocalButtons.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.PanelFileManagerLocalButtons.Name = "PanelFileManagerLocalButtons";
            this.PanelFileManagerLocalButtons.Size = new System.Drawing.Size(617, 42);
            this.PanelFileManagerLocalButtons.TabIndex = 1;
            // 
            // ButtonFileManagerLocalUpload
            // 
            this.ButtonFileManagerLocalUpload.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFileManagerLocalUpload.Appearance.Options.UseFont = true;
            this.ButtonFileManagerLocalUpload.Enabled = false;
            this.ButtonFileManagerLocalUpload.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFileManagerLocalUpload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFileManagerLocalUpload.ImageOptions.ImageToTextIndent = 4;
            this.ButtonFileManagerLocalUpload.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFileManagerLocalUpload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFileManagerLocalUpload.ImageOptions.SvgImage")));
            this.ButtonFileManagerLocalUpload.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFileManagerLocalUpload.Location = new System.Drawing.Point(9, 8);
            this.ButtonFileManagerLocalUpload.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.ButtonFileManagerLocalUpload.Name = "ButtonFileManagerLocalUpload";
            this.ButtonFileManagerLocalUpload.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerLocalUpload.Size = new System.Drawing.Size(82, 25);
            this.ButtonFileManagerLocalUpload.TabIndex = 1;
            this.ButtonFileManagerLocalUpload.Text = "Upload";
            this.ButtonFileManagerLocalUpload.Click += new System.EventHandler(this.ButtonLocalUpload_Click);
            // 
            // ButtonFileManagerLocalDelete
            // 
            this.ButtonFileManagerLocalDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFileManagerLocalDelete.Appearance.Options.UseFont = true;
            this.ButtonFileManagerLocalDelete.Enabled = false;
            this.ButtonFileManagerLocalDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFileManagerLocalDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFileManagerLocalDelete.ImageOptions.ImageToTextIndent = 4;
            this.ButtonFileManagerLocalDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFileManagerLocalDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFileManagerLocalDelete.ImageOptions.SvgImage")));
            this.ButtonFileManagerLocalDelete.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFileManagerLocalDelete.Location = new System.Drawing.Point(97, 8);
            this.ButtonFileManagerLocalDelete.Name = "ButtonFileManagerLocalDelete";
            this.ButtonFileManagerLocalDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerLocalDelete.Size = new System.Drawing.Size(80, 25);
            this.ButtonFileManagerLocalDelete.TabIndex = 2;
            this.ButtonFileManagerLocalDelete.Text = "Delete";
            this.ButtonFileManagerLocalDelete.Click += new System.EventHandler(this.ButtonLocalDelete_Click);
            // 
            // ButtonFileManagerFileLocalRename
            // 
            this.ButtonFileManagerFileLocalRename.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFileManagerFileLocalRename.Appearance.Options.UseFont = true;
            this.ButtonFileManagerFileLocalRename.Enabled = false;
            this.ButtonFileManagerFileLocalRename.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFileManagerFileLocalRename.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFileManagerFileLocalRename.ImageOptions.ImageToTextIndent = 4;
            this.ButtonFileManagerFileLocalRename.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFileManagerFileLocalRename.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFileManagerFileLocalRename.ImageOptions.SvgImage")));
            this.ButtonFileManagerFileLocalRename.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFileManagerFileLocalRename.Location = new System.Drawing.Point(183, 8);
            this.ButtonFileManagerFileLocalRename.Name = "ButtonFileManagerFileLocalRename";
            this.ButtonFileManagerFileLocalRename.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerFileLocalRename.Size = new System.Drawing.Size(87, 25);
            this.ButtonFileManagerFileLocalRename.TabIndex = 3;
            this.ButtonFileManagerFileLocalRename.Text = "Rename";
            this.ButtonFileManagerFileLocalRename.Click += new System.EventHandler(this.ButtonLocalRename_Click);
            // 
            // ButtonFileManagerLocalNewFolder
            // 
            this.ButtonFileManagerLocalNewFolder.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFileManagerLocalNewFolder.Appearance.Options.UseFont = true;
            this.ButtonFileManagerLocalNewFolder.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFileManagerLocalNewFolder.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFileManagerLocalNewFolder.ImageOptions.ImageToTextIndent = 4;
            this.ButtonFileManagerLocalNewFolder.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFileManagerLocalNewFolder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFileManagerLocalNewFolder.ImageOptions.SvgImage")));
            this.ButtonFileManagerLocalNewFolder.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFileManagerLocalNewFolder.Location = new System.Drawing.Point(276, 8);
            this.ButtonFileManagerLocalNewFolder.Name = "ButtonFileManagerLocalNewFolder";
            this.ButtonFileManagerLocalNewFolder.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerLocalNewFolder.Size = new System.Drawing.Size(104, 25);
            this.ButtonFileManagerLocalNewFolder.TabIndex = 4;
            this.ButtonFileManagerLocalNewFolder.Text = "New Folder";
            this.ButtonFileManagerLocalNewFolder.Click += new System.EventHandler(this.ButtonLocalNewFolder_Click);
            // 
            // ButtonFileManagerLocalRefresh
            // 
            this.ButtonFileManagerLocalRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFileManagerLocalRefresh.Appearance.Options.UseFont = true;
            this.ButtonFileManagerLocalRefresh.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFileManagerLocalRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFileManagerLocalRefresh.ImageOptions.ImageToTextIndent = 4;
            this.ButtonFileManagerLocalRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFileManagerLocalRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFileManagerLocalRefresh.ImageOptions.SvgImage")));
            this.ButtonFileManagerLocalRefresh.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFileManagerLocalRefresh.Location = new System.Drawing.Point(386, 8);
            this.ButtonFileManagerLocalRefresh.Name = "ButtonFileManagerLocalRefresh";
            this.ButtonFileManagerLocalRefresh.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerLocalRefresh.Size = new System.Drawing.Size(88, 25);
            this.ButtonFileManagerLocalRefresh.TabIndex = 5;
            this.ButtonFileManagerLocalRefresh.Text = "Refresh";
            this.ButtonFileManagerLocalRefresh.Click += new System.EventHandler(this.ButtonLocalRefresh_Click);
            // 
            // ButtonFileManagerLocalOpenExplorer
            // 
            this.ButtonFileManagerLocalOpenExplorer.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFileManagerLocalOpenExplorer.Appearance.Options.UseFont = true;
            this.ButtonFileManagerLocalOpenExplorer.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFileManagerLocalOpenExplorer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFileManagerLocalOpenExplorer.ImageOptions.ImageToTextIndent = 4;
            this.ButtonFileManagerLocalOpenExplorer.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFileManagerLocalOpenExplorer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonFileManagerLocalOpenExplorer.ImageOptions.SvgImage")));
            this.ButtonFileManagerLocalOpenExplorer.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFileManagerLocalOpenExplorer.Location = new System.Drawing.Point(480, 8);
            this.ButtonFileManagerLocalOpenExplorer.Name = "ButtonFileManagerLocalOpenExplorer";
            this.ButtonFileManagerLocalOpenExplorer.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerLocalOpenExplorer.Size = new System.Drawing.Size(126, 25);
            this.ButtonFileManagerLocalOpenExplorer.TabIndex = 6;
            this.ButtonFileManagerLocalOpenExplorer.Text = "Open Explorer";
            this.ButtonFileManagerLocalOpenExplorer.Click += new System.EventHandler(this.ButtonLocalOpenExplorer_Click);
            // 
            // PanelFileManagerLocalStatus
            // 
            this.PanelFileManagerLocalStatus.Controls.Add(this.LabelFileManagerLocalStatus);
            this.PanelFileManagerLocalStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFileManagerLocalStatus.Location = new System.Drawing.Point(2, 654);
            this.PanelFileManagerLocalStatus.Name = "PanelFileManagerLocalStatus";
            this.PanelFileManagerLocalStatus.Size = new System.Drawing.Size(617, 28);
            this.PanelFileManagerLocalStatus.TabIndex = 1174;
            // 
            // LabelFileManagerLocalStatus
            // 
            this.LabelFileManagerLocalStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelFileManagerLocalStatus.Appearance.Options.UseFont = true;
            this.LabelFileManagerLocalStatus.Location = new System.Drawing.Point(10, 5);
            this.LabelFileManagerLocalStatus.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.LabelFileManagerLocalStatus.Name = "LabelFileManagerLocalStatus";
            this.LabelFileManagerLocalStatus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.LabelFileManagerLocalStatus.Size = new System.Drawing.Size(50, 17);
            this.LabelFileManagerLocalStatus.TabIndex = 11;
            this.LabelFileManagerLocalStatus.Text = "Waiting...";
            // 
            // GridControlFileManagerLocalFiles
            // 
            this.GridControlFileManagerLocalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlFileManagerLocalFiles.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridControlFileManagerLocalFiles.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.GridControlFileManagerLocalFiles.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridControlFileManagerLocalFiles.Location = new System.Drawing.Point(11, 60);
            this.GridControlFileManagerLocalFiles.MainView = this.GridViewFileManagerLocalFiles;
            this.GridControlFileManagerLocalFiles.Margin = new System.Windows.Forms.Padding(6, 3, 6, 0);
            this.GridControlFileManagerLocalFiles.Name = "GridControlFileManagerLocalFiles";
            this.GridControlFileManagerLocalFiles.Size = new System.Drawing.Size(600, 550);
            this.GridControlFileManagerLocalFiles.TabIndex = 0;
            this.GridControlFileManagerLocalFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewFileManagerLocalFiles});
            // 
            // GridViewFileManagerLocalFiles
            // 
            this.GridViewFileManagerLocalFiles.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.GridViewFileManagerLocalFiles.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridViewFileManagerLocalFiles.Appearance.Row.FontSizeDelta = 1;
            this.GridViewFileManagerLocalFiles.Appearance.Row.Options.UseFont = true;
            this.GridViewFileManagerLocalFiles.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewFileManagerLocalFiles.GridControl = this.GridControlFileManagerLocalFiles;
            this.GridViewFileManagerLocalFiles.Name = "GridViewFileManagerLocalFiles";
            this.GridViewFileManagerLocalFiles.OptionsBehavior.Editable = false;
            this.GridViewFileManagerLocalFiles.OptionsBehavior.ReadOnly = true;
            this.GridViewFileManagerLocalFiles.OptionsCustomization.AllowFilter = false;
            this.GridViewFileManagerLocalFiles.OptionsFilter.AllowFilterEditor = false;
            this.GridViewFileManagerLocalFiles.OptionsMenu.EnableGroupPanelMenu = false;
            this.GridViewFileManagerLocalFiles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewFileManagerLocalFiles.OptionsView.ShowGroupPanel = false;
            this.GridViewFileManagerLocalFiles.OptionsView.ShowIndicator = false;
            this.GridViewFileManagerLocalFiles.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewLocalFiles_RowClick);
            this.GridViewFileManagerLocalFiles.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewLocalFiles_FocusedRowChanged);
            this.GridViewFileManagerLocalFiles.DoubleClick += new System.EventHandler(this.GridViewLocalFiles_DoubleClick);
            // 
            // ButtonFileManagerBrowseLocalDirectory
            // 
            this.ButtonFileManagerBrowseLocalDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFileManagerBrowseLocalDirectory.Location = new System.Drawing.Point(571, 32);
            this.ButtonFileManagerBrowseLocalDirectory.Name = "ButtonFileManagerBrowseLocalDirectory";
            this.ButtonFileManagerBrowseLocalDirectory.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFileManagerBrowseLocalDirectory.Size = new System.Drawing.Size(40, 22);
            this.ButtonFileManagerBrowseLocalDirectory.TabIndex = 1172;
            this.ButtonFileManagerBrowseLocalDirectory.Text = "...";
            this.ButtonFileManagerBrowseLocalDirectory.Click += new System.EventHandler(this.ButtonBrowseLocalDirectory_Click);
            // 
            // ComboBoxFileManagerLocalDrives
            // 
            this.ComboBoxFileManagerLocalDrives.Location = new System.Drawing.Point(11, 32);
            this.ComboBoxFileManagerLocalDrives.Name = "ComboBoxFileManagerLocalDrives";
            this.ComboBoxFileManagerLocalDrives.Properties.AllowFocused = false;
            this.ComboBoxFileManagerLocalDrives.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxFileManagerLocalDrives.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxFileManagerLocalDrives.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxFileManagerLocalDrives.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxFileManagerLocalDrives.Size = new System.Drawing.Size(42, 22);
            this.ComboBoxFileManagerLocalDrives.TabIndex = 1165;
            this.ComboBoxFileManagerLocalDrives.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLocalDrives_SelectedIndexChanged);
            // 
            // TextBoxFileManagerLocalPath
            // 
            this.TextBoxFileManagerLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFileManagerLocalPath.Location = new System.Drawing.Point(59, 32);
            this.TextBoxFileManagerLocalPath.Name = "TextBoxFileManagerLocalPath";
            this.TextBoxFileManagerLocalPath.Properties.AllowFocused = false;
            this.TextBoxFileManagerLocalPath.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFileManagerLocalPath.Properties.Appearance.Options.UseFont = true;
            this.TextBoxFileManagerLocalPath.Size = new System.Drawing.Size(506, 22);
            this.TextBoxFileManagerLocalPath.TabIndex = 1170;
            // 
            // PageSettings
            // 
            this.PageSettings.Appearance.Options.UseFont = true;
            this.PageSettings.Controls.Add(this.TabControlSettings);
            this.PageSettings.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PageSettings.Name = "PageSettings";
            this.PageSettings.Size = new System.Drawing.Size(1281, 712);
            // 
            // TabControlSettings
            // 
            this.TabControlSettings.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TabControlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlSettings.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.TabControlSettings.AppearancePage.Header.Options.UseFont = true;
            this.TabControlSettings.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.TabControlSettings.AppearancePage.HeaderActive.Options.UseFont = true;
            this.TabControlSettings.AppearancePage.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabControlSettings.AppearancePage.PageClient.Options.UseBackColor = true;
            this.TabControlSettings.Location = new System.Drawing.Point(14, 14);
            this.TabControlSettings.Margin = new System.Windows.Forms.Padding(14);
            this.TabControlSettings.Name = "TabControlSettings";
            this.TabControlSettings.SelectedTabPage = this.TabPageInterface;
            this.TabControlSettings.Size = new System.Drawing.Size(1253, 684);
            this.TabControlSettings.TabIndex = 6;
            this.TabControlSettings.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageInterface,
            this.TabPageTools,
            this.TabPageDownloads,
            this.TabPageChatRoom});
            // 
            // TabPageInterface
            // 
            this.TabPageInterface.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPageInterface.Appearance.PageClient.Options.UseBackColor = true;
            this.TabPageInterface.AutoScroll = true;
            this.TabPageInterface.Controls.Add(this.LabelSettingsInstallResourcesToUsbDevice);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsInstallResourcesToUsbDevice);
            this.TabPageInterface.Controls.Add(this.LabelSettingsInstallHomebrewToUsbDevice);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsInstallHomebrewToUsbDevice);
            this.TabPageInterface.Controls.Add(this.LabelSettingsOtherLanguagesSoon);
            this.TabPageInterface.Controls.Add(this.LabelSettingsOptionsOnlyForPS3);
            this.TabPageInterface.Controls.Add(this.LabelSettingsAutoLoadDirectoryListings);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsAutoLoadDirectoryListings);
            this.TabPageInterface.Controls.Add(this.LabelSettingsEnableHardwareAcceleration);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsEnableHardwareAcceleration);
            this.TabPageInterface.Controls.Add(this.LabelSettingsAdvanced);
            this.TabPageInterface.Controls.Add(this.LabelSettingsInstallPackagesToUsbDevice);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsInstallPackagesToUsbDevice);
            this.TabPageInterface.Controls.Add(this.LabelSettingsInstallGameSavesToUsbDevice);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsInstallGameSavesToUsbDevice);
            this.TabPageInterface.Controls.Add(this.LabelSettingsInstallModsToUsbDevice);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsInstallModsToUsbDevice);
            this.TabPageInterface.Controls.Add(this.LabelSettingsRememberConsolePath);
            this.TabPageInterface.Controls.Add(this.LabelSettingsRememberLocalPath);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsRememberConsolePath);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsRememberLocalPath);
            this.TabPageInterface.Controls.Add(this.LabelSettingsRememberGameRegions);
            this.TabPageInterface.Controls.Add(this.LabelSettingsAutoDetectGameTitles);
            this.TabPageInterface.Controls.Add(this.LabelSettingsAutoDetectGameRegions);
            this.TabPageInterface.Controls.Add(this.LabelSettingsShowGamesFromExternalDevices);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsRememberGameRegions);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsAutoDetectGameTitles);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsAutoDetectGameRegions);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsShowGamesFromExternalDevices);
            this.TabPageInterface.Controls.Add(this.LabelSettingsAutomation);
            this.TabPageInterface.Controls.Add(this.LabelSettingsUseRelativeTimes);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsUseRelativeTimes);
            this.TabPageInterface.Controls.Add(this.ComboBoxSettingsLanguages);
            this.TabPageInterface.Controls.Add(this.LabelSettingsUseFormattedFileSizes);
            this.TabPageInterface.Controls.Add(this.ToggleSwitchSettingsUseFormattedFileSizes);
            this.TabPageInterface.Controls.Add(this.LabelSettingsLanguage);
            this.TabPageInterface.Controls.Add(this.LabelSettingsStartupLibrary);
            this.TabPageInterface.Controls.Add(this.RadioGroupSettingsStartupLibrary);
            this.TabPageInterface.Controls.Add(this.LabelSettingsCustomization);
            this.TabPageInterface.Name = "TabPageInterface";
            this.TabPageInterface.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.TabPageInterface.Size = new System.Drawing.Size(1251, 655);
            this.TabPageInterface.Text = "  INTERFACE  ";
            // 
            // LabelSettingsInstallResourcesToUsbDevice
            // 
            this.LabelSettingsInstallResourcesToUsbDevice.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsInstallResourcesToUsbDevice.Appearance.Options.UseFont = true;
            this.LabelSettingsInstallResourcesToUsbDevice.Location = new System.Drawing.Point(71, 481);
            this.LabelSettingsInstallResourcesToUsbDevice.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsInstallResourcesToUsbDevice.Name = "LabelSettingsInstallResourcesToUsbDevice";
            this.LabelSettingsInstallResourcesToUsbDevice.Size = new System.Drawing.Size(195, 15);
            this.LabelSettingsInstallResourcesToUsbDevice.TabIndex = 1218;
            this.LabelSettingsInstallResourcesToUsbDevice.Text = "Install Resources to local USB device*";
            // 
            // ToggleSwitchSettingsInstallResourcesToUsbDevice
            // 
            this.ToggleSwitchSettingsInstallResourcesToUsbDevice.Location = new System.Drawing.Point(14, 479);
            this.ToggleSwitchSettingsInstallResourcesToUsbDevice.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsInstallResourcesToUsbDevice.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsInstallResourcesToUsbDevice.Name = "ToggleSwitchSettingsInstallResourcesToUsbDevice";
            this.ToggleSwitchSettingsInstallResourcesToUsbDevice.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsInstallResourcesToUsbDevice.Properties.OffText = "Off";
            this.ToggleSwitchSettingsInstallResourcesToUsbDevice.Properties.OnText = "On";
            this.ToggleSwitchSettingsInstallResourcesToUsbDevice.Properties.ShowText = false;
            this.ToggleSwitchSettingsInstallResourcesToUsbDevice.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsInstallResourcesToUsbDevice.TabIndex = 1217;
            this.ToggleSwitchSettingsInstallResourcesToUsbDevice.Toggled += new System.EventHandler(this.ToggleSwitchSettingsInstallResourcesToUsbDevice_Toggled);
            // 
            // LabelSettingsInstallHomebrewToUsbDevice
            // 
            this.LabelSettingsInstallHomebrewToUsbDevice.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsInstallHomebrewToUsbDevice.Appearance.Options.UseFont = true;
            this.LabelSettingsInstallHomebrewToUsbDevice.Location = new System.Drawing.Point(72, 451);
            this.LabelSettingsInstallHomebrewToUsbDevice.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsInstallHomebrewToUsbDevice.Name = "LabelSettingsInstallHomebrewToUsbDevice";
            this.LabelSettingsInstallHomebrewToUsbDevice.Size = new System.Drawing.Size(201, 15);
            this.LabelSettingsInstallHomebrewToUsbDevice.TabIndex = 1216;
            this.LabelSettingsInstallHomebrewToUsbDevice.Text = "Install Homebrew to local USB device*";
            // 
            // ToggleSwitchSettingsInstallHomebrewToUsbDevice
            // 
            this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.Location = new System.Drawing.Point(15, 449);
            this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.Name = "ToggleSwitchSettingsInstallHomebrewToUsbDevice";
            this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.Properties.OffText = "Off";
            this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.Properties.OnText = "On";
            this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.Properties.ShowText = false;
            this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.TabIndex = 1215;
            this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.Toggled += new System.EventHandler(this.ToggleSwitchSettingsInstallHomebrewToUsbDevice_Toggled);
            // 
            // LabelSettingsOtherLanguagesSoon
            // 
            this.LabelSettingsOtherLanguagesSoon.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsOtherLanguagesSoon.Appearance.Options.UseFont = true;
            this.LabelSettingsOtherLanguagesSoon.Location = new System.Drawing.Point(15, 68);
            this.LabelSettingsOtherLanguagesSoon.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsOtherLanguagesSoon.Name = "LabelSettingsOtherLanguagesSoon";
            this.LabelSettingsOtherLanguagesSoon.Size = new System.Drawing.Size(182, 15);
            this.LabelSettingsOtherLanguagesSoon.TabIndex = 1214;
            this.LabelSettingsOtherLanguagesSoon.Text = "Other languages are coming soon!";
            // 
            // LabelSettingsOptionsOnlyForPS3
            // 
            this.LabelSettingsOptionsOnlyForPS3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsOptionsOnlyForPS3.Appearance.Options.UseFont = true;
            this.LabelSettingsOptionsOnlyForPS3.Location = new System.Drawing.Point(16, 779);
            this.LabelSettingsOptionsOnlyForPS3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsOptionsOnlyForPS3.Name = "LabelSettingsOptionsOnlyForPS3";
            this.LabelSettingsOptionsOnlyForPS3.Size = new System.Drawing.Size(261, 15);
            this.LabelSettingsOptionsOnlyForPS3.TabIndex = 1213;
            this.LabelSettingsOptionsOnlyForPS3.Text = "*These options are only available for PlayStation 3";
            // 
            // LabelSettingsAutoLoadDirectoryListings
            // 
            this.LabelSettingsAutoLoadDirectoryListings.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsAutoLoadDirectoryListings.Appearance.Options.UseFont = true;
            this.LabelSettingsAutoLoadDirectoryListings.Location = new System.Drawing.Point(72, 691);
            this.LabelSettingsAutoLoadDirectoryListings.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsAutoLoadDirectoryListings.Name = "LabelSettingsAutoLoadDirectoryListings";
            this.LabelSettingsAutoLoadDirectoryListings.Size = new System.Drawing.Size(190, 15);
            this.LabelSettingsAutoLoadDirectoryListings.TabIndex = 1212;
            this.LabelSettingsAutoLoadDirectoryListings.Text = "Automatically load directory listings";
            // 
            // ToggleSwitchSettingsAutoLoadDirectoryListings
            // 
            this.ToggleSwitchSettingsAutoLoadDirectoryListings.Location = new System.Drawing.Point(15, 689);
            this.ToggleSwitchSettingsAutoLoadDirectoryListings.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsAutoLoadDirectoryListings.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsAutoLoadDirectoryListings.Name = "ToggleSwitchSettingsAutoLoadDirectoryListings";
            this.ToggleSwitchSettingsAutoLoadDirectoryListings.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsAutoLoadDirectoryListings.Properties.OffText = "Off";
            this.ToggleSwitchSettingsAutoLoadDirectoryListings.Properties.OnText = "On";
            this.ToggleSwitchSettingsAutoLoadDirectoryListings.Properties.ShowText = false;
            this.ToggleSwitchSettingsAutoLoadDirectoryListings.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsAutoLoadDirectoryListings.TabIndex = 1211;
            this.ToggleSwitchSettingsAutoLoadDirectoryListings.Toggled += new System.EventHandler(this.ToggleSwitchSettingsAutoLoadFileManagerListings_Toggled);
            // 
            // LabelSettingsEnableHardwareAcceleration
            // 
            this.LabelSettingsEnableHardwareAcceleration.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsEnableHardwareAcceleration.Appearance.Options.UseFont = true;
            this.LabelSettingsEnableHardwareAcceleration.Location = new System.Drawing.Point(71, 344);
            this.LabelSettingsEnableHardwareAcceleration.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsEnableHardwareAcceleration.Name = "LabelSettingsEnableHardwareAcceleration";
            this.LabelSettingsEnableHardwareAcceleration.Size = new System.Drawing.Size(158, 15);
            this.LabelSettingsEnableHardwareAcceleration.TabIndex = 1210;
            this.LabelSettingsEnableHardwareAcceleration.Text = "Enable Hardware Acceleration";
            // 
            // ToggleSwitchSettingsEnableHardwareAcceleration
            // 
            this.ToggleSwitchSettingsEnableHardwareAcceleration.Location = new System.Drawing.Point(14, 342);
            this.ToggleSwitchSettingsEnableHardwareAcceleration.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsEnableHardwareAcceleration.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsEnableHardwareAcceleration.Name = "ToggleSwitchSettingsEnableHardwareAcceleration";
            this.ToggleSwitchSettingsEnableHardwareAcceleration.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsEnableHardwareAcceleration.Properties.OffText = "Off";
            this.ToggleSwitchSettingsEnableHardwareAcceleration.Properties.OnText = "On";
            this.ToggleSwitchSettingsEnableHardwareAcceleration.Properties.ShowText = false;
            this.ToggleSwitchSettingsEnableHardwareAcceleration.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsEnableHardwareAcceleration.TabIndex = 1209;
            this.ToggleSwitchSettingsEnableHardwareAcceleration.Toggled += new System.EventHandler(this.ToggleSwitchSettingsEnableDirectXHardwareAcceleration_Toggled);
            // 
            // LabelSettingsAdvanced
            // 
            this.LabelSettingsAdvanced.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSettingsAdvanced.Appearance.Options.UseFont = true;
            this.LabelSettingsAdvanced.Location = new System.Drawing.Point(14, 308);
            this.LabelSettingsAdvanced.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.LabelSettingsAdvanced.Name = "LabelSettingsAdvanced";
            this.LabelSettingsAdvanced.Size = new System.Drawing.Size(55, 15);
            this.LabelSettingsAdvanced.TabIndex = 1208;
            this.LabelSettingsAdvanced.Text = "Advanced";
            // 
            // LabelSettingsInstallPackagesToUsbDevice
            // 
            this.LabelSettingsInstallPackagesToUsbDevice.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsInstallPackagesToUsbDevice.Appearance.Options.UseFont = true;
            this.LabelSettingsInstallPackagesToUsbDevice.Location = new System.Drawing.Point(72, 511);
            this.LabelSettingsInstallPackagesToUsbDevice.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsInstallPackagesToUsbDevice.Name = "LabelSettingsInstallPackagesToUsbDevice";
            this.LabelSettingsInstallPackagesToUsbDevice.Size = new System.Drawing.Size(191, 15);
            this.LabelSettingsInstallPackagesToUsbDevice.TabIndex = 1207;
            this.LabelSettingsInstallPackagesToUsbDevice.Text = "Install Packages to local USB device*\r\n";
            // 
            // ToggleSwitchSettingsInstallPackagesToUsbDevice
            // 
            this.ToggleSwitchSettingsInstallPackagesToUsbDevice.Location = new System.Drawing.Point(15, 509);
            this.ToggleSwitchSettingsInstallPackagesToUsbDevice.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsInstallPackagesToUsbDevice.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsInstallPackagesToUsbDevice.Name = "ToggleSwitchSettingsInstallPackagesToUsbDevice";
            this.ToggleSwitchSettingsInstallPackagesToUsbDevice.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsInstallPackagesToUsbDevice.Properties.OffText = "Off";
            this.ToggleSwitchSettingsInstallPackagesToUsbDevice.Properties.OnText = "On";
            this.ToggleSwitchSettingsInstallPackagesToUsbDevice.Properties.ShowText = false;
            this.ToggleSwitchSettingsInstallPackagesToUsbDevice.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsInstallPackagesToUsbDevice.TabIndex = 1206;
            // 
            // LabelSettingsInstallGameSavesToUsbDevice
            // 
            this.LabelSettingsInstallGameSavesToUsbDevice.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsInstallGameSavesToUsbDevice.Appearance.Options.UseFont = true;
            this.LabelSettingsInstallGameSavesToUsbDevice.Location = new System.Drawing.Point(72, 541);
            this.LabelSettingsInstallGameSavesToUsbDevice.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsInstallGameSavesToUsbDevice.Name = "LabelSettingsInstallGameSavesToUsbDevice";
            this.LabelSettingsInstallGameSavesToUsbDevice.Size = new System.Drawing.Size(200, 15);
            this.LabelSettingsInstallGameSavesToUsbDevice.TabIndex = 1205;
            this.LabelSettingsInstallGameSavesToUsbDevice.Text = "Install Game Saves to local USB device";
            // 
            // ToggleSwitchSettingsInstallGameSavesToUsbDevice
            // 
            this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.Location = new System.Drawing.Point(15, 539);
            this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.Name = "ToggleSwitchSettingsInstallGameSavesToUsbDevice";
            this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.Properties.OffText = "Off";
            this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.Properties.OnText = "On";
            this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.Properties.ShowText = false;
            this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.TabIndex = 1204;
            this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.Toggled += new System.EventHandler(this.ToggleSwitchSettingsInstallGameSavesToUsbDevice_Toggled);
            // 
            // LabelSettingsInstallModsToUsbDevice
            // 
            this.LabelSettingsInstallModsToUsbDevice.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsInstallModsToUsbDevice.Appearance.Options.UseFont = true;
            this.LabelSettingsInstallModsToUsbDevice.Location = new System.Drawing.Point(71, 421);
            this.LabelSettingsInstallModsToUsbDevice.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsInstallModsToUsbDevice.Name = "LabelSettingsInstallModsToUsbDevice";
            this.LabelSettingsInstallModsToUsbDevice.Size = new System.Drawing.Size(211, 15);
            this.LabelSettingsInstallModsToUsbDevice.TabIndex = 1203;
            this.LabelSettingsInstallModsToUsbDevice.Text = "Install Mods/Plugins to local USB device";
            // 
            // ToggleSwitchSettingsInstallModsToUsbDevice
            // 
            this.ToggleSwitchSettingsInstallModsToUsbDevice.Location = new System.Drawing.Point(14, 419);
            this.ToggleSwitchSettingsInstallModsToUsbDevice.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsInstallModsToUsbDevice.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsInstallModsToUsbDevice.Name = "ToggleSwitchSettingsInstallModsToUsbDevice";
            this.ToggleSwitchSettingsInstallModsToUsbDevice.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsInstallModsToUsbDevice.Properties.OffText = "Off";
            this.ToggleSwitchSettingsInstallModsToUsbDevice.Properties.OnText = "On";
            this.ToggleSwitchSettingsInstallModsToUsbDevice.Properties.ShowText = false;
            this.ToggleSwitchSettingsInstallModsToUsbDevice.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsInstallModsToUsbDevice.TabIndex = 1202;
            this.ToggleSwitchSettingsInstallModsToUsbDevice.Toggled += new System.EventHandler(this.ToggleSwitchSettingsInstallModsToUsbDevice_Toggled);
            // 
            // LabelSettingsRememberConsolePath
            // 
            this.LabelSettingsRememberConsolePath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsRememberConsolePath.Appearance.Options.UseFont = true;
            this.LabelSettingsRememberConsolePath.Location = new System.Drawing.Point(72, 751);
            this.LabelSettingsRememberConsolePath.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsRememberConsolePath.Name = "LabelSettingsRememberConsolePath";
            this.LabelSettingsRememberConsolePath.Size = new System.Drawing.Size(200, 15);
            this.LabelSettingsRememberConsolePath.TabIndex = 1201;
            this.LabelSettingsRememberConsolePath.Text = "Remember last console directory path";
            // 
            // LabelSettingsRememberLocalPath
            // 
            this.LabelSettingsRememberLocalPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsRememberLocalPath.Appearance.Options.UseFont = true;
            this.LabelSettingsRememberLocalPath.Location = new System.Drawing.Point(72, 721);
            this.LabelSettingsRememberLocalPath.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsRememberLocalPath.Name = "LabelSettingsRememberLocalPath";
            this.LabelSettingsRememberLocalPath.Size = new System.Drawing.Size(184, 15);
            this.LabelSettingsRememberLocalPath.TabIndex = 1200;
            this.LabelSettingsRememberLocalPath.Text = "Remember last local directory path";
            // 
            // ToggleSwitchSettingsRememberConsolePath
            // 
            this.ToggleSwitchSettingsRememberConsolePath.Location = new System.Drawing.Point(16, 749);
            this.ToggleSwitchSettingsRememberConsolePath.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsRememberConsolePath.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsRememberConsolePath.Name = "ToggleSwitchSettingsRememberConsolePath";
            this.ToggleSwitchSettingsRememberConsolePath.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsRememberConsolePath.Properties.OffText = "Off";
            this.ToggleSwitchSettingsRememberConsolePath.Properties.OnText = "On";
            this.ToggleSwitchSettingsRememberConsolePath.Properties.ShowText = false;
            this.ToggleSwitchSettingsRememberConsolePath.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsRememberConsolePath.TabIndex = 1199;
            this.ToggleSwitchSettingsRememberConsolePath.Toggled += new System.EventHandler(this.ToggleSwitchSettingsRememberConsolePath_Toggled);
            // 
            // ToggleSwitchSettingsRememberLocalPath
            // 
            this.ToggleSwitchSettingsRememberLocalPath.Location = new System.Drawing.Point(15, 719);
            this.ToggleSwitchSettingsRememberLocalPath.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsRememberLocalPath.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsRememberLocalPath.Name = "ToggleSwitchSettingsRememberLocalPath";
            this.ToggleSwitchSettingsRememberLocalPath.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsRememberLocalPath.Properties.OffText = "Off";
            this.ToggleSwitchSettingsRememberLocalPath.Properties.OnText = "On";
            this.ToggleSwitchSettingsRememberLocalPath.Properties.ShowText = false;
            this.ToggleSwitchSettingsRememberLocalPath.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsRememberLocalPath.TabIndex = 1198;
            this.ToggleSwitchSettingsRememberLocalPath.Toggled += new System.EventHandler(this.ToggleSwitchSettingsRememberLocalPath_Toggled);
            // 
            // LabelSettingsRememberGameRegions
            // 
            this.LabelSettingsRememberGameRegions.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsRememberGameRegions.Appearance.Options.UseFont = true;
            this.LabelSettingsRememberGameRegions.Location = new System.Drawing.Point(72, 661);
            this.LabelSettingsRememberGameRegions.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsRememberGameRegions.Name = "LabelSettingsRememberGameRegions";
            this.LabelSettingsRememberGameRegions.Size = new System.Drawing.Size(138, 15);
            this.LabelSettingsRememberGameRegions.TabIndex = 1195;
            this.LabelSettingsRememberGameRegions.Text = "Remember game regions*";
            // 
            // LabelSettingsAutoDetectGameTitles
            // 
            this.LabelSettingsAutoDetectGameTitles.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsAutoDetectGameTitles.Appearance.Options.UseFont = true;
            this.LabelSettingsAutoDetectGameTitles.Location = new System.Drawing.Point(72, 631);
            this.LabelSettingsAutoDetectGameTitles.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsAutoDetectGameTitles.Name = "LabelSettingsAutoDetectGameTitles";
            this.LabelSettingsAutoDetectGameTitles.Size = new System.Drawing.Size(171, 15);
            this.LabelSettingsAutoDetectGameTitles.TabIndex = 1194;
            this.LabelSettingsAutoDetectGameTitles.Text = "Automatically detect game titles";
            // 
            // LabelSettingsAutoDetectGameRegions
            // 
            this.LabelSettingsAutoDetectGameRegions.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsAutoDetectGameRegions.Appearance.Options.UseFont = true;
            this.LabelSettingsAutoDetectGameRegions.Location = new System.Drawing.Point(72, 601);
            this.LabelSettingsAutoDetectGameRegions.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsAutoDetectGameRegions.Name = "LabelSettingsAutoDetectGameRegions";
            this.LabelSettingsAutoDetectGameRegions.Size = new System.Drawing.Size(190, 15);
            this.LabelSettingsAutoDetectGameRegions.TabIndex = 1193;
            this.LabelSettingsAutoDetectGameRegions.Text = "Automatically detect game regions*\r\n";
            // 
            // LabelSettingsShowGamesFromExternalDevices
            // 
            this.LabelSettingsShowGamesFromExternalDevices.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsShowGamesFromExternalDevices.Appearance.Options.UseFont = true;
            this.LabelSettingsShowGamesFromExternalDevices.Location = new System.Drawing.Point(72, 571);
            this.LabelSettingsShowGamesFromExternalDevices.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsShowGamesFromExternalDevices.Name = "LabelSettingsShowGamesFromExternalDevices";
            this.LabelSettingsShowGamesFromExternalDevices.Size = new System.Drawing.Size(206, 15);
            this.LabelSettingsShowGamesFromExternalDevices.TabIndex = 1192;
            this.LabelSettingsShowGamesFromExternalDevices.Text = "Show games list from external devices*\r\n";
            // 
            // ToggleSwitchSettingsRememberGameRegions
            // 
            this.ToggleSwitchSettingsRememberGameRegions.Location = new System.Drawing.Point(15, 659);
            this.ToggleSwitchSettingsRememberGameRegions.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsRememberGameRegions.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsRememberGameRegions.Name = "ToggleSwitchSettingsRememberGameRegions";
            this.ToggleSwitchSettingsRememberGameRegions.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsRememberGameRegions.Properties.OffText = "Off";
            this.ToggleSwitchSettingsRememberGameRegions.Properties.OnText = "On";
            this.ToggleSwitchSettingsRememberGameRegions.Properties.ShowText = false;
            this.ToggleSwitchSettingsRememberGameRegions.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsRememberGameRegions.TabIndex = 1191;
            this.ToggleSwitchSettingsRememberGameRegions.Toggled += new System.EventHandler(this.ToggleSwitchSettingsRememberGameRegions_Toggled);
            // 
            // ToggleSwitchSettingsAutoDetectGameTitles
            // 
            this.ToggleSwitchSettingsAutoDetectGameTitles.Location = new System.Drawing.Point(15, 629);
            this.ToggleSwitchSettingsAutoDetectGameTitles.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsAutoDetectGameTitles.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsAutoDetectGameTitles.Name = "ToggleSwitchSettingsAutoDetectGameTitles";
            this.ToggleSwitchSettingsAutoDetectGameTitles.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsAutoDetectGameTitles.Properties.OffText = "Off";
            this.ToggleSwitchSettingsAutoDetectGameTitles.Properties.OnText = "On";
            this.ToggleSwitchSettingsAutoDetectGameTitles.Properties.ShowText = false;
            this.ToggleSwitchSettingsAutoDetectGameTitles.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsAutoDetectGameTitles.TabIndex = 1190;
            this.ToggleSwitchSettingsAutoDetectGameTitles.Toggled += new System.EventHandler(this.ToggleSwitchSettingsAutoDetectGameTitles_Toggled);
            // 
            // ToggleSwitchSettingsAutoDetectGameRegions
            // 
            this.ToggleSwitchSettingsAutoDetectGameRegions.Location = new System.Drawing.Point(15, 599);
            this.ToggleSwitchSettingsAutoDetectGameRegions.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsAutoDetectGameRegions.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsAutoDetectGameRegions.Name = "ToggleSwitchSettingsAutoDetectGameRegions";
            this.ToggleSwitchSettingsAutoDetectGameRegions.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsAutoDetectGameRegions.Properties.OffText = "Off";
            this.ToggleSwitchSettingsAutoDetectGameRegions.Properties.OnText = "On";
            this.ToggleSwitchSettingsAutoDetectGameRegions.Properties.ShowText = false;
            this.ToggleSwitchSettingsAutoDetectGameRegions.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsAutoDetectGameRegions.TabIndex = 1189;
            this.ToggleSwitchSettingsAutoDetectGameRegions.Toggled += new System.EventHandler(this.ToggleSwitchSettingsAutoDetectGameRegions_Toggled);
            // 
            // ToggleSwitchSettingsShowGamesFromExternalDevices
            // 
            this.ToggleSwitchSettingsShowGamesFromExternalDevices.Location = new System.Drawing.Point(15, 569);
            this.ToggleSwitchSettingsShowGamesFromExternalDevices.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsShowGamesFromExternalDevices.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsShowGamesFromExternalDevices.Name = "ToggleSwitchSettingsShowGamesFromExternalDevices";
            this.ToggleSwitchSettingsShowGamesFromExternalDevices.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsShowGamesFromExternalDevices.Properties.OffText = "Off";
            this.ToggleSwitchSettingsShowGamesFromExternalDevices.Properties.OnText = "On";
            this.ToggleSwitchSettingsShowGamesFromExternalDevices.Properties.ShowText = false;
            this.ToggleSwitchSettingsShowGamesFromExternalDevices.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsShowGamesFromExternalDevices.TabIndex = 1188;
            this.ToggleSwitchSettingsShowGamesFromExternalDevices.Toggled += new System.EventHandler(this.ToggleSwitchSettingsShowGamesFromExternalDevices_Toggled);
            // 
            // LabelSettingsAutomation
            // 
            this.LabelSettingsAutomation.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSettingsAutomation.Appearance.Options.UseFont = true;
            this.LabelSettingsAutomation.Location = new System.Drawing.Point(15, 385);
            this.LabelSettingsAutomation.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.LabelSettingsAutomation.Name = "LabelSettingsAutomation";
            this.LabelSettingsAutomation.Size = new System.Drawing.Size(66, 15);
            this.LabelSettingsAutomation.TabIndex = 1187;
            this.LabelSettingsAutomation.Text = "Automation";
            // 
            // LabelSettingsUseRelativeTimes
            // 
            this.LabelSettingsUseRelativeTimes.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsUseRelativeTimes.Appearance.Options.UseFont = true;
            this.LabelSettingsUseRelativeTimes.Location = new System.Drawing.Point(71, 267);
            this.LabelSettingsUseRelativeTimes.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsUseRelativeTimes.Name = "LabelSettingsUseRelativeTimes";
            this.LabelSettingsUseRelativeTimes.Size = new System.Drawing.Size(208, 15);
            this.LabelSettingsUseRelativeTimes.TabIndex = 1180;
            this.LabelSettingsUseRelativeTimes.Text = "Use relative times (e.g. \"3 months ago\")";
            // 
            // ToggleSwitchSettingsUseRelativeTimes
            // 
            this.ToggleSwitchSettingsUseRelativeTimes.Location = new System.Drawing.Point(14, 265);
            this.ToggleSwitchSettingsUseRelativeTimes.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsUseRelativeTimes.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsUseRelativeTimes.Name = "ToggleSwitchSettingsUseRelativeTimes";
            this.ToggleSwitchSettingsUseRelativeTimes.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsUseRelativeTimes.Properties.OffText = "Off";
            this.ToggleSwitchSettingsUseRelativeTimes.Properties.OnText = "On";
            this.ToggleSwitchSettingsUseRelativeTimes.Properties.ShowText = false;
            this.ToggleSwitchSettingsUseRelativeTimes.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsUseRelativeTimes.TabIndex = 1179;
            this.ToggleSwitchSettingsUseRelativeTimes.Toggled += new System.EventHandler(this.ToggleSwitchSettingsUseRelativeTimes_Toggled);
            // 
            // ComboBoxSettingsLanguages
            // 
            this.ComboBoxSettingsLanguages.EditValue = "English";
            this.ComboBoxSettingsLanguages.Location = new System.Drawing.Point(15, 40);
            this.ComboBoxSettingsLanguages.MenuManager = this.MainMenu;
            this.ComboBoxSettingsLanguages.Name = "ComboBoxSettingsLanguages";
            this.ComboBoxSettingsLanguages.Properties.AllowFocused = false;
            this.ComboBoxSettingsLanguages.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxSettingsLanguages.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxSettingsLanguages.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxSettingsLanguages.Properties.AutoComplete = false;
            this.ComboBoxSettingsLanguages.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxSettingsLanguages.Properties.DropDownRows = 12;
            this.ComboBoxSettingsLanguages.Properties.Items.AddRange(new object[] {
            "English"});
            this.ComboBoxSettingsLanguages.Properties.NullValuePrompt = "Select...";
            this.ComboBoxSettingsLanguages.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxSettingsLanguages.Size = new System.Drawing.Size(214, 22);
            this.ComboBoxSettingsLanguages.TabIndex = 1178;
            this.ComboBoxSettingsLanguages.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSettingsLanguages_SelectedIndexChanged);
            // 
            // LabelSettingsUseFormattedFileSizes
            // 
            this.LabelSettingsUseFormattedFileSizes.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsUseFormattedFileSizes.Appearance.Options.UseFont = true;
            this.LabelSettingsUseFormattedFileSizes.Location = new System.Drawing.Point(71, 237);
            this.LabelSettingsUseFormattedFileSizes.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsUseFormattedFileSizes.Name = "LabelSettingsUseFormattedFileSizes";
            this.LabelSettingsUseFormattedFileSizes.Size = new System.Drawing.Size(191, 15);
            this.LabelSettingsUseFormattedFileSizes.TabIndex = 1177;
            this.LabelSettingsUseFormattedFileSizes.Text = "Use formatted file sizes (e.g. \"3 MB\")";
            // 
            // ToggleSwitchSettingsUseFormattedFileSizes
            // 
            this.ToggleSwitchSettingsUseFormattedFileSizes.Location = new System.Drawing.Point(14, 235);
            this.ToggleSwitchSettingsUseFormattedFileSizes.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsUseFormattedFileSizes.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsUseFormattedFileSizes.Name = "ToggleSwitchSettingsUseFormattedFileSizes";
            this.ToggleSwitchSettingsUseFormattedFileSizes.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsUseFormattedFileSizes.Properties.OffText = "Off";
            this.ToggleSwitchSettingsUseFormattedFileSizes.Properties.OnText = "On";
            this.ToggleSwitchSettingsUseFormattedFileSizes.Properties.ShowText = false;
            this.ToggleSwitchSettingsUseFormattedFileSizes.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsUseFormattedFileSizes.TabIndex = 1176;
            this.ToggleSwitchSettingsUseFormattedFileSizes.Toggled += new System.EventHandler(this.ToggleSwitchSettingsUseFormattedFileSizes_Toggled);
            // 
            // LabelSettingsLanguage
            // 
            this.LabelSettingsLanguage.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSettingsLanguage.Appearance.Options.UseFont = true;
            this.LabelSettingsLanguage.Location = new System.Drawing.Point(15, 15);
            this.LabelSettingsLanguage.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.LabelSettingsLanguage.Name = "LabelSettingsLanguage";
            this.LabelSettingsLanguage.Size = new System.Drawing.Size(53, 15);
            this.LabelSettingsLanguage.TabIndex = 1175;
            this.LabelSettingsLanguage.Text = "Language";
            // 
            // LabelSettingsStartupLibrary
            // 
            this.LabelSettingsStartupLibrary.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSettingsStartupLibrary.Appearance.Options.UseFont = true;
            this.LabelSettingsStartupLibrary.Location = new System.Drawing.Point(15, 102);
            this.LabelSettingsStartupLibrary.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.LabelSettingsStartupLibrary.Name = "LabelSettingsStartupLibrary";
            this.LabelSettingsStartupLibrary.Size = new System.Drawing.Size(83, 15);
            this.LabelSettingsStartupLibrary.TabIndex = 1174;
            this.LabelSettingsStartupLibrary.Text = "Startup Library";
            // 
            // RadioGroupSettingsStartupLibrary
            // 
            this.RadioGroupSettingsStartupLibrary.Location = new System.Drawing.Point(14, 132);
            this.RadioGroupSettingsStartupLibrary.Name = "RadioGroupSettingsStartupLibrary";
            this.RadioGroupSettingsStartupLibrary.Properties.AllowFocused = false;
            this.RadioGroupSettingsStartupLibrary.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioGroupSettingsStartupLibrary.Properties.Appearance.Options.UseBackColor = true;
            this.RadioGroupSettingsStartupLibrary.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioGroupSettingsStartupLibrary.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "PlayStation 3"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Xbox 360")});
            this.RadioGroupSettingsStartupLibrary.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.RadioGroupSettingsStartupLibrary.Properties.SelectedIndexChanged += new System.EventHandler(this.RadioSettingsStartupLibrary_Properties_SelectedIndexChanged);
            this.RadioGroupSettingsStartupLibrary.Size = new System.Drawing.Size(113, 48);
            this.RadioGroupSettingsStartupLibrary.TabIndex = 1172;
            // 
            // LabelSettingsCustomization
            // 
            this.LabelSettingsCustomization.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSettingsCustomization.Appearance.Options.UseFont = true;
            this.LabelSettingsCustomization.Location = new System.Drawing.Point(15, 201);
            this.LabelSettingsCustomization.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.LabelSettingsCustomization.Name = "LabelSettingsCustomization";
            this.LabelSettingsCustomization.Size = new System.Drawing.Size(79, 15);
            this.LabelSettingsCustomization.TabIndex = 1171;
            this.LabelSettingsCustomization.Text = "Customization";
            // 
            // TabPageTools
            // 
            this.TabPageTools.AutoScroll = true;
            this.TabPageTools.Controls.Add(this.SeparatorSettingsTools);
            this.TabPageTools.Controls.Add(this.LabelSettingsToolsXBOX);
            this.TabPageTools.Controls.Add(this.LabelSettingsPackagesFilePath);
            this.TabPageTools.Controls.Add(this.TextBoxSettingsPackagesInstallPath);
            this.TabPageTools.Controls.Add(this.LabelSettingsToolsPS3);
            this.TabPageTools.Controls.Add(this.LabelSettingsLaunchIniFilePath);
            this.TabPageTools.Controls.Add(this.TextBoxSettingsLaunchIniFilePath);
            this.TabPageTools.Name = "TabPageTools";
            this.TabPageTools.Size = new System.Drawing.Size(1251, 655);
            this.TabPageTools.Text = "  TOOLS  ";
            // 
            // SeparatorSettingsTools
            // 
            this.SeparatorSettingsTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeparatorSettingsTools.LineColor = System.Drawing.Color.Gainsboro;
            this.SeparatorSettingsTools.Location = new System.Drawing.Point(15, 111);
            this.SeparatorSettingsTools.Name = "SeparatorSettingsTools";
            this.SeparatorSettingsTools.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.SeparatorSettingsTools.Size = new System.Drawing.Size(1220, 23);
            this.SeparatorSettingsTools.TabIndex = 1177;
            // 
            // LabelSettingsToolsXBOX
            // 
            this.LabelSettingsToolsXBOX.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSettingsToolsXBOX.Appearance.Options.UseFont = true;
            this.LabelSettingsToolsXBOX.Location = new System.Drawing.Point(15, 155);
            this.LabelSettingsToolsXBOX.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.LabelSettingsToolsXBOX.Name = "LabelSettingsToolsXBOX";
            this.LabelSettingsToolsXBOX.Size = new System.Drawing.Size(53, 15);
            this.LabelSettingsToolsXBOX.TabIndex = 1176;
            this.LabelSettingsToolsXBOX.Text = "Xbox 360";
            // 
            // LabelSettingsPackagesFilePath
            // 
            this.LabelSettingsPackagesFilePath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsPackagesFilePath.Appearance.Options.UseFont = true;
            this.LabelSettingsPackagesFilePath.Location = new System.Drawing.Point(15, 49);
            this.LabelSettingsPackagesFilePath.Name = "LabelSettingsPackagesFilePath";
            this.LabelSettingsPackagesFilePath.Size = new System.Drawing.Size(131, 15);
            this.LabelSettingsPackagesFilePath.TabIndex = 1175;
            this.LabelSettingsPackagesFilePath.Text = "Packages File Install Path";
            // 
            // TextBoxSettingsPackagesInstallPath
            // 
            this.TextBoxSettingsPackagesInstallPath.Location = new System.Drawing.Point(15, 70);
            this.TextBoxSettingsPackagesInstallPath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.TextBoxSettingsPackagesInstallPath.Name = "TextBoxSettingsPackagesInstallPath";
            this.TextBoxSettingsPackagesInstallPath.Size = new System.Drawing.Size(449, 20);
            this.TextBoxSettingsPackagesInstallPath.TabIndex = 1174;
            this.TextBoxSettingsPackagesInstallPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSettingsPackagesFilePath_KeyDown);
            // 
            // LabelSettingsToolsPS3
            // 
            this.LabelSettingsToolsPS3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSettingsToolsPS3.Appearance.Options.UseFont = true;
            this.LabelSettingsToolsPS3.Location = new System.Drawing.Point(15, 15);
            this.LabelSettingsToolsPS3.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.LabelSettingsToolsPS3.Name = "LabelSettingsToolsPS3";
            this.LabelSettingsToolsPS3.Size = new System.Drawing.Size(72, 15);
            this.LabelSettingsToolsPS3.TabIndex = 1173;
            this.LabelSettingsToolsPS3.Text = "PlayStation 3";
            // 
            // LabelSettingsLaunchIniFilePath
            // 
            this.LabelSettingsLaunchIniFilePath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsLaunchIniFilePath.Appearance.Options.UseFont = true;
            this.LabelSettingsLaunchIniFilePath.Location = new System.Drawing.Point(15, 189);
            this.LabelSettingsLaunchIniFilePath.Name = "LabelSettingsLaunchIniFilePath";
            this.LabelSettingsLaunchIniFilePath.Size = new System.Drawing.Size(100, 15);
            this.LabelSettingsLaunchIniFilePath.TabIndex = 1172;
            this.LabelSettingsLaunchIniFilePath.Text = "launch.ini File Path";
            // 
            // TextBoxSettingsLaunchIniFilePath
            // 
            this.TextBoxSettingsLaunchIniFilePath.Location = new System.Drawing.Point(15, 210);
            this.TextBoxSettingsLaunchIniFilePath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.TextBoxSettingsLaunchIniFilePath.Name = "TextBoxSettingsLaunchIniFilePath";
            this.TextBoxSettingsLaunchIniFilePath.Size = new System.Drawing.Size(449, 20);
            this.TextBoxSettingsLaunchIniFilePath.TabIndex = 1171;
            this.TextBoxSettingsLaunchIniFilePath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSettingsLaunchIniFilePath_KeyDown);
            // 
            // TabPageDownloads
            // 
            this.TabPageDownloads.Controls.Add(this.ImageSettingsDownloadsFolder);
            this.TabPageDownloads.Controls.Add(this.LabelSettingsDownloadLocation);
            this.TabPageDownloads.Controls.Add(this.TextBoxSettingsDownloadsFolder);
            this.TabPageDownloads.Controls.Add(this.LabelSettingsDownloadsFolder);
            this.TabPageDownloads.Name = "TabPageDownloads";
            this.TabPageDownloads.Size = new System.Drawing.Size(1251, 655);
            this.TabPageDownloads.Text = "  DOWNLOADS  ";
            // 
            // ImageSettingsDownloadsFolder
            // 
            this.ImageSettingsDownloadsFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageSettingsDownloadsFolder.EditValue = ((object)(resources.GetObject("ImageSettingsDownloadsFolder.EditValue")));
            this.ImageSettingsDownloadsFolder.Location = new System.Drawing.Point(457, 40);
            this.ImageSettingsDownloadsFolder.MenuManager = this.MainMenu;
            this.ImageSettingsDownloadsFolder.Name = "ImageSettingsDownloadsFolder";
            this.ImageSettingsDownloadsFolder.Properties.AllowFocused = false;
            this.ImageSettingsDownloadsFolder.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ImageSettingsDownloadsFolder.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImageSettingsDownloadsFolder.Properties.Appearance.Options.UseBackColor = true;
            this.ImageSettingsDownloadsFolder.Properties.Appearance.Options.UseForeColor = true;
            this.ImageSettingsDownloadsFolder.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageSettingsDownloadsFolder.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageSettingsDownloadsFolder.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageSettingsDownloadsFolder.Size = new System.Drawing.Size(20, 20);
            this.ImageSettingsDownloadsFolder.TabIndex = 1183;
            this.ImageSettingsDownloadsFolder.Click += new System.EventHandler(this.ImageSettingsDownloadsFolder_Click);
            // 
            // LabelSettingsDownloadLocation
            // 
            this.LabelSettingsDownloadLocation.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsDownloadLocation.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelSettingsDownloadLocation.Appearance.Options.UseFont = true;
            this.LabelSettingsDownloadLocation.Appearance.Options.UseForeColor = true;
            this.LabelSettingsDownloadLocation.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.LabelSettingsDownloadLocation.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Underline;
            this.LabelSettingsDownloadLocation.AppearanceHovered.Options.UseFont = true;
            this.LabelSettingsDownloadLocation.AppearancePressed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.LabelSettingsDownloadLocation.AppearancePressed.FontStyleDelta = System.Drawing.FontStyle.Underline;
            this.LabelSettingsDownloadLocation.AppearancePressed.Options.UseFont = true;
            this.LabelSettingsDownloadLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSettingsDownloadLocation.Location = new System.Drawing.Point(15, 68);
            this.LabelSettingsDownloadLocation.Name = "LabelSettingsDownloadLocation";
            this.LabelSettingsDownloadLocation.Size = new System.Drawing.Size(103, 15);
            this.LabelSettingsDownloadLocation.TabIndex = 1182;
            this.LabelSettingsDownloadLocation.Text = "Download Location";
            this.LabelSettingsDownloadLocation.Click += new System.EventHandler(this.LabelSettingsDownloadLocation_Click);
            // 
            // TextBoxSettingsDownloadsFolder
            // 
            this.TextBoxSettingsDownloadsFolder.EditValue = "";
            this.TextBoxSettingsDownloadsFolder.Location = new System.Drawing.Point(15, 39);
            this.TextBoxSettingsDownloadsFolder.Name = "TextBoxSettingsDownloadsFolder";
            this.TextBoxSettingsDownloadsFolder.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSettingsDownloadsFolder.Properties.Appearance.Options.UseFont = true;
            this.TextBoxSettingsDownloadsFolder.Properties.MaxLength = 16;
            this.TextBoxSettingsDownloadsFolder.Size = new System.Drawing.Size(465, 22);
            this.TextBoxSettingsDownloadsFolder.TabIndex = 1181;
            // 
            // LabelSettingsDownloadsFolder
            // 
            this.LabelSettingsDownloadsFolder.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSettingsDownloadsFolder.Appearance.Options.UseFont = true;
            this.LabelSettingsDownloadsFolder.Location = new System.Drawing.Point(15, 15);
            this.LabelSettingsDownloadsFolder.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.LabelSettingsDownloadsFolder.Name = "LabelSettingsDownloadsFolder";
            this.LabelSettingsDownloadsFolder.Size = new System.Drawing.Size(99, 15);
            this.LabelSettingsDownloadsFolder.TabIndex = 1179;
            this.LabelSettingsDownloadsFolder.Text = "Downloads Folder";
            // 
            // TabPageChatRoom
            // 
            this.TabPageChatRoom.AutoScroll = true;
            this.TabPageChatRoom.Controls.Add(this.LabelSettingsHideUnreadMessagesCount);
            this.TabPageChatRoom.Controls.Add(this.ToggleSwitchSettingsHideUnreadMessagesCount);
            this.TabPageChatRoom.Controls.Add(this.LabelSettingsMuteSounds);
            this.TabPageChatRoom.Controls.Add(this.ToggleSwitchSettingsMuteSounds);
            this.TabPageChatRoom.Controls.Add(this.LabelSettingsChatRoomOptions);
            this.TabPageChatRoom.Controls.Add(this.RadioGroupSettingsChatRoom);
            this.TabPageChatRoom.Controls.Add(this.LabelSettingsBlockPrivateMessages);
            this.TabPageChatRoom.Controls.Add(this.ToggleSwitchSettingsBlockPrivateMessages);
            this.TabPageChatRoom.Controls.Add(this.LabelSettingsChatRoomNotifications);
            this.TabPageChatRoom.Controls.Add(this.TextBoxSettingsUserName);
            this.TabPageChatRoom.Controls.Add(this.LabelSettingsChatRoomUserName);
            this.TabPageChatRoom.Name = "TabPageChatRoom";
            this.TabPageChatRoom.Size = new System.Drawing.Size(1251, 655);
            this.TabPageChatRoom.Text = "  CHAT ROOM  ";
            // 
            // LabelSettingsHideUnreadMessagesCount
            // 
            this.LabelSettingsHideUnreadMessagesCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsHideUnreadMessagesCount.Appearance.Options.UseFont = true;
            this.LabelSettingsHideUnreadMessagesCount.Location = new System.Drawing.Point(71, 302);
            this.LabelSettingsHideUnreadMessagesCount.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsHideUnreadMessagesCount.Name = "LabelSettingsHideUnreadMessagesCount";
            this.LabelSettingsHideUnreadMessagesCount.Size = new System.Drawing.Size(153, 15);
            this.LabelSettingsHideUnreadMessagesCount.TabIndex = 1193;
            this.LabelSettingsHideUnreadMessagesCount.Text = "Hide unread messages count";
            // 
            // ToggleSwitchSettingsHideUnreadMessagesCount
            // 
            this.ToggleSwitchSettingsHideUnreadMessagesCount.Location = new System.Drawing.Point(14, 300);
            this.ToggleSwitchSettingsHideUnreadMessagesCount.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsHideUnreadMessagesCount.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsHideUnreadMessagesCount.Name = "ToggleSwitchSettingsHideUnreadMessagesCount";
            this.ToggleSwitchSettingsHideUnreadMessagesCount.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsHideUnreadMessagesCount.Properties.OffText = "Off";
            this.ToggleSwitchSettingsHideUnreadMessagesCount.Properties.OnText = "On";
            this.ToggleSwitchSettingsHideUnreadMessagesCount.Properties.ShowText = false;
            this.ToggleSwitchSettingsHideUnreadMessagesCount.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsHideUnreadMessagesCount.TabIndex = 1192;
            this.ToggleSwitchSettingsHideUnreadMessagesCount.Toggled += new System.EventHandler(this.ToggleSwitchSettingsHideUnreadMessagesCount_Toggled);
            // 
            // LabelSettingsMuteSounds
            // 
            this.LabelSettingsMuteSounds.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsMuteSounds.Appearance.Options.UseFont = true;
            this.LabelSettingsMuteSounds.Location = new System.Drawing.Point(71, 272);
            this.LabelSettingsMuteSounds.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsMuteSounds.Name = "LabelSettingsMuteSounds";
            this.LabelSettingsMuteSounds.Size = new System.Drawing.Size(69, 15);
            this.LabelSettingsMuteSounds.TabIndex = 1191;
            this.LabelSettingsMuteSounds.Text = "Mute sounds";
            // 
            // ToggleSwitchSettingsMuteSounds
            // 
            this.ToggleSwitchSettingsMuteSounds.Location = new System.Drawing.Point(14, 270);
            this.ToggleSwitchSettingsMuteSounds.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsMuteSounds.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsMuteSounds.Name = "ToggleSwitchSettingsMuteSounds";
            this.ToggleSwitchSettingsMuteSounds.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsMuteSounds.Properties.OffText = "Off";
            this.ToggleSwitchSettingsMuteSounds.Properties.OnText = "On";
            this.ToggleSwitchSettingsMuteSounds.Properties.ShowText = false;
            this.ToggleSwitchSettingsMuteSounds.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsMuteSounds.TabIndex = 1190;
            this.ToggleSwitchSettingsMuteSounds.Toggled += new System.EventHandler(this.ToggleSwitchSettingsMuteSounds_Toggled);
            // 
            // LabelSettingsChatRoomOptions
            // 
            this.LabelSettingsChatRoomOptions.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSettingsChatRoomOptions.Appearance.Options.UseFont = true;
            this.LabelSettingsChatRoomOptions.Location = new System.Drawing.Point(14, 206);
            this.LabelSettingsChatRoomOptions.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.LabelSettingsChatRoomOptions.Name = "LabelSettingsChatRoomOptions";
            this.LabelSettingsChatRoomOptions.Size = new System.Drawing.Size(43, 15);
            this.LabelSettingsChatRoomOptions.TabIndex = 1189;
            this.LabelSettingsChatRoomOptions.Text = "Options";
            // 
            // RadioGroupSettingsChatRoom
            // 
            this.RadioGroupSettingsChatRoom.Location = new System.Drawing.Point(14, 115);
            this.RadioGroupSettingsChatRoom.Name = "RadioGroupSettingsChatRoom";
            this.RadioGroupSettingsChatRoom.Properties.AllowFocused = false;
            this.RadioGroupSettingsChatRoom.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioGroupSettingsChatRoom.Properties.Appearance.Options.UseBackColor = true;
            this.RadioGroupSettingsChatRoom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioGroupSettingsChatRoom.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "All messages"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "I am mentioned"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Never")});
            this.RadioGroupSettingsChatRoom.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.RadioGroupSettingsChatRoom.Size = new System.Drawing.Size(113, 72);
            this.RadioGroupSettingsChatRoom.TabIndex = 1188;
            this.RadioGroupSettingsChatRoom.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSettingsChatRoom_SelectedIndexChanged);
            // 
            // LabelSettingsBlockPrivateMessages
            // 
            this.LabelSettingsBlockPrivateMessages.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSettingsBlockPrivateMessages.Appearance.Options.UseFont = true;
            this.LabelSettingsBlockPrivateMessages.Location = new System.Drawing.Point(71, 242);
            this.LabelSettingsBlockPrivateMessages.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSettingsBlockPrivateMessages.Name = "LabelSettingsBlockPrivateMessages";
            this.LabelSettingsBlockPrivateMessages.Size = new System.Drawing.Size(137, 15);
            this.LabelSettingsBlockPrivateMessages.TabIndex = 1184;
            this.LabelSettingsBlockPrivateMessages.Text = "Block all private messages";
            // 
            // ToggleSwitchSettingsBlockPrivateMessages
            // 
            this.ToggleSwitchSettingsBlockPrivateMessages.Location = new System.Drawing.Point(14, 240);
            this.ToggleSwitchSettingsBlockPrivateMessages.Margin = new System.Windows.Forms.Padding(14, 3, 3, 8);
            this.ToggleSwitchSettingsBlockPrivateMessages.MenuManager = this.MainMenu;
            this.ToggleSwitchSettingsBlockPrivateMessages.Name = "ToggleSwitchSettingsBlockPrivateMessages";
            this.ToggleSwitchSettingsBlockPrivateMessages.Properties.AutoWidth = true;
            this.ToggleSwitchSettingsBlockPrivateMessages.Properties.OffText = "Off";
            this.ToggleSwitchSettingsBlockPrivateMessages.Properties.OnText = "On";
            this.ToggleSwitchSettingsBlockPrivateMessages.Properties.ShowText = false;
            this.ToggleSwitchSettingsBlockPrivateMessages.Size = new System.Drawing.Size(54, 19);
            this.ToggleSwitchSettingsBlockPrivateMessages.TabIndex = 1182;
            this.ToggleSwitchSettingsBlockPrivateMessages.Toggled += new System.EventHandler(this.ToggleSwitchSettingsBlockPrivateMessages_Toggled);
            // 
            // LabelSettingsChatRoomNotifications
            // 
            this.LabelSettingsChatRoomNotifications.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSettingsChatRoomNotifications.Appearance.Options.UseFont = true;
            this.LabelSettingsChatRoomNotifications.Location = new System.Drawing.Point(15, 85);
            this.LabelSettingsChatRoomNotifications.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.LabelSettingsChatRoomNotifications.Name = "LabelSettingsChatRoomNotifications";
            this.LabelSettingsChatRoomNotifications.Size = new System.Drawing.Size(71, 15);
            this.LabelSettingsChatRoomNotifications.TabIndex = 1180;
            this.LabelSettingsChatRoomNotifications.Text = "Notifications";
            // 
            // TextBoxSettingsUserName
            // 
            this.TextBoxSettingsUserName.EditValue = "an_extra_long_us";
            this.TextBoxSettingsUserName.Location = new System.Drawing.Point(15, 39);
            this.TextBoxSettingsUserName.Name = "TextBoxSettingsUserName";
            this.TextBoxSettingsUserName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSettingsUserName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxSettingsUserName.Properties.MaxLength = 16;
            this.TextBoxSettingsUserName.Size = new System.Drawing.Size(134, 22);
            this.TextBoxSettingsUserName.TabIndex = 1174;
            this.TextBoxSettingsUserName.EditValueChanged += new System.EventHandler(this.TextBoxSettingsUserName_EditValueChanged);
            // 
            // LabelSettingsChatRoomUserName
            // 
            this.LabelSettingsChatRoomUserName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSettingsChatRoomUserName.Appearance.Options.UseFont = true;
            this.LabelSettingsChatRoomUserName.Location = new System.Drawing.Point(15, 15);
            this.LabelSettingsChatRoomUserName.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.LabelSettingsChatRoomUserName.Name = "LabelSettingsChatRoomUserName";
            this.LabelSettingsChatRoomUserName.Size = new System.Drawing.Size(57, 15);
            this.LabelSettingsChatRoomUserName.TabIndex = 1173;
            this.LabelSettingsChatRoomUserName.Text = "Username";
            // 
            // PageGameSaves
            // 
            this.PageGameSaves.Appearance.Options.UseFont = true;
            this.PageGameSaves.Controls.Add(this.PanelGameSaves);
            this.PageGameSaves.Controls.Add(this.PanelGameSavesActions);
            this.PageGameSaves.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PageGameSaves.Name = "PageGameSaves";
            this.PageGameSaves.Size = new System.Drawing.Size(1281, 712);
            // 
            // PanelGameSaves
            // 
            this.PanelGameSaves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelGameSaves.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelGameSaves.BackColor = System.Drawing.Color.Transparent;
            this.PanelGameSaves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelGameSaves.Controls.Add(this.GridControlGameSaves);
            this.PanelGameSaves.Controls.Add(this.PanelGameSavesFilters);
            this.PanelGameSaves.Location = new System.Drawing.Point(14, 84);
            this.PanelGameSaves.Margin = new System.Windows.Forms.Padding(14);
            this.PanelGameSaves.Name = "PanelGameSaves";
            this.PanelGameSaves.Size = new System.Drawing.Size(1253, 614);
            this.PanelGameSaves.TabIndex = 1183;
            // 
            // GridControlGameSaves
            // 
            this.GridControlGameSaves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlGameSaves.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridControlGameSaves.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.GridControlGameSaves.EmbeddedNavigator.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.GridControlGameSaves.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlGameSaves.Location = new System.Drawing.Point(10, 70);
            this.GridControlGameSaves.MainView = this.GridViewGameSaves;
            this.GridControlGameSaves.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GridControlGameSaves.MenuManager = this.MainMenu;
            this.GridControlGameSaves.Name = "GridControlGameSaves";
            this.GridControlGameSaves.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.GridControlGameSaves.Size = new System.Drawing.Size(1231, 530);
            this.GridControlGameSaves.TabIndex = 5;
            this.GridControlGameSaves.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewGameSaves});
            // 
            // GridViewGameSaves
            // 
            this.GridViewGameSaves.ActiveFilterEnabled = false;
            this.GridViewGameSaves.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewGameSaves.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewGameSaves.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewGameSaves.Appearance.FocusedCell.Options.UseBackColor = true;
            this.GridViewGameSaves.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewGameSaves.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewGameSaves.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewGameSaves.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewGameSaves.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewGameSaves.Appearance.Preview.Options.UseBackColor = true;
            this.GridViewGameSaves.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.GridViewGameSaves.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewGameSaves.Appearance.Row.Options.UseBackColor = true;
            this.GridViewGameSaves.Appearance.Row.Options.UseFont = true;
            this.GridViewGameSaves.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewGameSaves.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewGameSaves.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewGameSaves.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewGameSaves.GridControl = this.GridControlGameSaves;
            this.GridViewGameSaves.GroupRowHeight = 20;
            this.GridViewGameSaves.Name = "GridViewGameSaves";
            this.GridViewGameSaves.OptionsBehavior.Editable = false;
            this.GridViewGameSaves.OptionsBehavior.ReadOnly = true;
            this.GridViewGameSaves.OptionsCustomization.AllowFilter = false;
            this.GridViewGameSaves.OptionsFilter.AllowFilterEditor = false;
            this.GridViewGameSaves.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewGameSaves.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewGameSaves.OptionsView.ShowColumnHeaders = false;
            this.GridViewGameSaves.OptionsView.ShowGroupPanel = false;
            this.GridViewGameSaves.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewGameSaves.OptionsView.ShowIndicator = false;
            this.GridViewGameSaves.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewGameSaves.RowHeight = 24;
            this.GridViewGameSaves.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GridViewGameSaves.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewGameSaves_RowClick);
            this.GridViewGameSaves.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GridViewGameSaves_CustomDrawCell);
            // 
            // PanelGameSavesFilters
            // 
            this.PanelGameSavesFilters.BackColor = System.Drawing.Color.Transparent;
            this.PanelGameSavesFilters.Controls.Add(this.ComboBoxGameSavesFilterCreator);
            this.PanelGameSavesFilters.Controls.Add(this.LabelGameSavesFilterCreator);
            this.PanelGameSavesFilters.Controls.Add(this.separatorControl1);
            this.PanelGameSavesFilters.Controls.Add(this.ComboBoxGameSavesFilterCategory);
            this.PanelGameSavesFilters.Controls.Add(this.LabelGameSavesFilterCategory);
            this.PanelGameSavesFilters.Controls.Add(this.ComboBoxGameSavesFilterVersion);
            this.PanelGameSavesFilters.Controls.Add(this.LabelGameSavesFilterVersion);
            this.PanelGameSavesFilters.Controls.Add(this.TextBoxGameSavesFilterName);
            this.PanelGameSavesFilters.Controls.Add(this.ComboBoxGameSavesFilterRegion);
            this.PanelGameSavesFilters.Controls.Add(this.LabelGameSavesFilterRegion);
            this.PanelGameSavesFilters.Controls.Add(this.LabelGameSavesFilterName);
            this.PanelGameSavesFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelGameSavesFilters.Location = new System.Drawing.Point(0, 0);
            this.PanelGameSavesFilters.Margin = new System.Windows.Forms.Padding(0, 4, 0, 50);
            this.PanelGameSavesFilters.Name = "PanelGameSavesFilters";
            this.PanelGameSavesFilters.Size = new System.Drawing.Size(1251, 70);
            this.PanelGameSavesFilters.TabIndex = 12;
            // 
            // ComboBoxGameSavesFilterCreator
            // 
            this.ComboBoxGameSavesFilterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameSavesFilterCreator.Location = new System.Drawing.Point(1091, 40);
            this.ComboBoxGameSavesFilterCreator.MenuManager = this.MainMenu;
            this.ComboBoxGameSavesFilterCreator.Name = "ComboBoxGameSavesFilterCreator";
            this.ComboBoxGameSavesFilterCreator.Properties.AllowFocused = false;
            this.ComboBoxGameSavesFilterCreator.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxGameSavesFilterCreator.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameSavesFilterCreator.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameSavesFilterCreator.Properties.AutoComplete = false;
            this.ComboBoxGameSavesFilterCreator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameSavesFilterCreator.Properties.DropDownRows = 12;
            this.ComboBoxGameSavesFilterCreator.Properties.NullValuePrompt = "Select...";
            this.ComboBoxGameSavesFilterCreator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameSavesFilterCreator.Size = new System.Drawing.Size(141, 22);
            this.ComboBoxGameSavesFilterCreator.TabIndex = 1175;
            this.ComboBoxGameSavesFilterCreator.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameSavesFilterCreator_SelectedIndexChanged);
            // 
            // LabelGameSavesFilterCreator
            // 
            this.LabelGameSavesFilterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameSavesFilterCreator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelGameSavesFilterCreator.Appearance.Options.UseFont = true;
            this.LabelGameSavesFilterCreator.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameSavesFilterCreator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameSavesFilterCreator.Location = new System.Drawing.Point(1088, 20);
            this.LabelGameSavesFilterCreator.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelGameSavesFilterCreator.Name = "LabelGameSavesFilterCreator";
            this.LabelGameSavesFilterCreator.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameSavesFilterCreator.Size = new System.Drawing.Size(48, 15);
            this.LabelGameSavesFilterCreator.TabIndex = 1176;
            this.LabelGameSavesFilterCreator.Text = "Creator";
            // 
            // separatorControl1
            // 
            this.separatorControl1.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl1.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separatorControl1.LineThickness = 3;
            this.separatorControl1.Location = new System.Drawing.Point(0, 67);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.separatorControl1.Size = new System.Drawing.Size(1251, 3);
            this.separatorControl1.TabIndex = 1172;
            // 
            // ComboBoxGameSavesFilterCategory
            // 
            this.ComboBoxGameSavesFilterCategory.Location = new System.Drawing.Point(17, 40);
            this.ComboBoxGameSavesFilterCategory.MenuManager = this.MainMenu;
            this.ComboBoxGameSavesFilterCategory.Name = "ComboBoxGameSavesFilterCategory";
            this.ComboBoxGameSavesFilterCategory.Properties.AllowFocused = false;
            this.ComboBoxGameSavesFilterCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxGameSavesFilterCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameSavesFilterCategory.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameSavesFilterCategory.Properties.AutoComplete = false;
            this.ComboBoxGameSavesFilterCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameSavesFilterCategory.Properties.DropDownRows = 15;
            this.ComboBoxGameSavesFilterCategory.Properties.NullValuePrompt = "Select...";
            this.ComboBoxGameSavesFilterCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameSavesFilterCategory.Size = new System.Drawing.Size(220, 22);
            this.ComboBoxGameSavesFilterCategory.TabIndex = 1170;
            this.ComboBoxGameSavesFilterCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameSavesFilterCategory_SelectedIndexChanged);
            // 
            // LabelGameSavesFilterCategory
            // 
            this.LabelGameSavesFilterCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelGameSavesFilterCategory.Appearance.Options.UseFont = true;
            this.LabelGameSavesFilterCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameSavesFilterCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameSavesFilterCategory.Location = new System.Drawing.Point(15, 20);
            this.LabelGameSavesFilterCategory.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelGameSavesFilterCategory.Name = "LabelGameSavesFilterCategory";
            this.LabelGameSavesFilterCategory.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameSavesFilterCategory.Size = new System.Drawing.Size(56, 15);
            this.LabelGameSavesFilterCategory.TabIndex = 1171;
            this.LabelGameSavesFilterCategory.Text = "Category";
            // 
            // ComboBoxGameSavesFilterVersion
            // 
            this.ComboBoxGameSavesFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameSavesFilterVersion.Location = new System.Drawing.Point(1021, 40);
            this.ComboBoxGameSavesFilterVersion.MenuManager = this.MainMenu;
            this.ComboBoxGameSavesFilterVersion.Name = "ComboBoxGameSavesFilterVersion";
            this.ComboBoxGameSavesFilterVersion.Properties.AllowFocused = false;
            this.ComboBoxGameSavesFilterVersion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxGameSavesFilterVersion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameSavesFilterVersion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameSavesFilterVersion.Properties.AutoComplete = false;
            this.ComboBoxGameSavesFilterVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameSavesFilterVersion.Properties.DropDownRows = 12;
            this.ComboBoxGameSavesFilterVersion.Properties.NullValuePrompt = "Select...";
            this.ComboBoxGameSavesFilterVersion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameSavesFilterVersion.Size = new System.Drawing.Size(64, 22);
            this.ComboBoxGameSavesFilterVersion.TabIndex = 1164;
            this.ComboBoxGameSavesFilterVersion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameSavesFilterVersion_SelectedIndexChanged);
            // 
            // LabelGameSavesFilterVersion
            // 
            this.LabelGameSavesFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameSavesFilterVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelGameSavesFilterVersion.Appearance.Options.UseFont = true;
            this.LabelGameSavesFilterVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameSavesFilterVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameSavesFilterVersion.Location = new System.Drawing.Point(1018, 20);
            this.LabelGameSavesFilterVersion.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelGameSavesFilterVersion.Name = "LabelGameSavesFilterVersion";
            this.LabelGameSavesFilterVersion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameSavesFilterVersion.Size = new System.Drawing.Size(48, 15);
            this.LabelGameSavesFilterVersion.TabIndex = 1165;
            this.LabelGameSavesFilterVersion.Text = "Version";
            // 
            // TextBoxGameSavesFilterName
            // 
            this.TextBoxGameSavesFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGameSavesFilterName.Location = new System.Drawing.Point(243, 40);
            this.TextBoxGameSavesFilterName.MenuManager = this.MainMenu;
            this.TextBoxGameSavesFilterName.Name = "TextBoxGameSavesFilterName";
            this.TextBoxGameSavesFilterName.Properties.AllowFocused = false;
            this.TextBoxGameSavesFilterName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TextBoxGameSavesFilterName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxGameSavesFilterName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxGameSavesFilterName.Properties.NullValuePrompt = "Search...";
            this.TextBoxGameSavesFilterName.Size = new System.Drawing.Size(682, 22);
            this.TextBoxGameSavesFilterName.TabIndex = 1;
            this.TextBoxGameSavesFilterName.TextChanged += new System.EventHandler(this.TextBoxGameSavesFilterName_TextChanged);
            // 
            // ComboBoxGameSavesFilterRegion
            // 
            this.ComboBoxGameSavesFilterRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxGameSavesFilterRegion.Location = new System.Drawing.Point(931, 40);
            this.ComboBoxGameSavesFilterRegion.MenuManager = this.MainMenu;
            this.ComboBoxGameSavesFilterRegion.Name = "ComboBoxGameSavesFilterRegion";
            this.ComboBoxGameSavesFilterRegion.Properties.AllowFocused = false;
            this.ComboBoxGameSavesFilterRegion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxGameSavesFilterRegion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameSavesFilterRegion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameSavesFilterRegion.Properties.AutoComplete = false;
            this.ComboBoxGameSavesFilterRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameSavesFilterRegion.Properties.DropDownRows = 12;
            this.ComboBoxGameSavesFilterRegion.Properties.NullValuePrompt = "Select...";
            this.ComboBoxGameSavesFilterRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameSavesFilterRegion.Size = new System.Drawing.Size(84, 22);
            this.ComboBoxGameSavesFilterRegion.TabIndex = 4;
            this.ComboBoxGameSavesFilterRegion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameSavesFilterRegion_SelectedIndexChanged);
            // 
            // LabelGameSavesFilterRegion
            // 
            this.LabelGameSavesFilterRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelGameSavesFilterRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelGameSavesFilterRegion.Appearance.Options.UseFont = true;
            this.LabelGameSavesFilterRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameSavesFilterRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameSavesFilterRegion.Location = new System.Drawing.Point(928, 20);
            this.LabelGameSavesFilterRegion.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelGameSavesFilterRegion.Name = "LabelGameSavesFilterRegion";
            this.LabelGameSavesFilterRegion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameSavesFilterRegion.Size = new System.Drawing.Size(45, 15);
            this.LabelGameSavesFilterRegion.TabIndex = 1163;
            this.LabelGameSavesFilterRegion.Text = "Region";
            // 
            // LabelGameSavesFilterName
            // 
            this.LabelGameSavesFilterName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelGameSavesFilterName.Appearance.Options.UseFont = true;
            this.LabelGameSavesFilterName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameSavesFilterName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameSavesFilterName.Location = new System.Drawing.Point(240, 20);
            this.LabelGameSavesFilterName.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelGameSavesFilterName.Name = "LabelGameSavesFilterName";
            this.LabelGameSavesFilterName.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameSavesFilterName.Size = new System.Drawing.Size(39, 15);
            this.LabelGameSavesFilterName.TabIndex = 1157;
            this.LabelGameSavesFilterName.Text = "Name";
            // 
            // PanelGameSavesActions
            // 
            this.PanelGameSavesActions.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelGameSavesActions.Controls.Add(this.TileControlGameSaves);
            this.PanelGameSavesActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelGameSavesActions.Location = new System.Drawing.Point(0, 0);
            this.PanelGameSavesActions.Margin = new System.Windows.Forms.Padding(0);
            this.PanelGameSavesActions.Name = "PanelGameSavesActions";
            this.PanelGameSavesActions.Size = new System.Drawing.Size(1281, 70);
            this.PanelGameSavesActions.TabIndex = 1182;
            // 
            // TileControlGameSaves
            // 
            this.TileControlGameSaves.AllowDisabledStateIndication = false;
            this.TileControlGameSaves.AllowDrag = false;
            this.TileControlGameSaves.AllowDragTilesBetweenGroups = false;
            this.TileControlGameSaves.AllowGlyphSkinning = true;
            this.TileControlGameSaves.AllowItemHover = true;
            this.TileControlGameSaves.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TileControlGameSaves.Groups.Add(this.TileGroupGameSaves);
            this.TileControlGameSaves.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TileControlGameSaves.IndentBetweenItems = 2;
            this.TileControlGameSaves.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade;
            this.TileControlGameSaves.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileControlGameSaves.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.TileControlGameSaves.ItemPadding = new System.Windows.Forms.Padding(0);
            this.TileControlGameSaves.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.TileControlGameSaves.Location = new System.Drawing.Point(6, 5);
            this.TileControlGameSaves.MaxId = 6;
            this.TileControlGameSaves.Name = "TileControlGameSaves";
            this.TileControlGameSaves.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TileControlGameSaves.Padding = new System.Windows.Forms.Padding(0);
            this.TileControlGameSaves.Size = new System.Drawing.Size(332, 67);
            this.TileControlGameSaves.TabIndex = 1;
            this.TileControlGameSaves.Text = "TileControlModsActions";
            // 
            // TileGroupGameSaves
            // 
            this.TileGroupGameSaves.Items.Add(this.TileItemGameSavesSortBy);
            this.TileGroupGameSaves.Name = "TileGroupGameSaves";
            this.TileGroupGameSaves.Text = "Game Saves Actions";
            // 
            // TileItemGameSavesSortBy
            // 
            this.TileItemGameSavesSortBy.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemGameSavesSortBy.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileItemGameSavesSortBy.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemGameSavesSortBy.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemGameSavesSortBy.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemGameSavesSortBy.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemGameSavesSortBy.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemGameSavesSortBy.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemGameSavesSortBy.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemGameSavesSortBy.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement26.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            tileItemElement26.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement26.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement26.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement26.ImageOptions.ImageToTextIndent = 2;
            tileItemElement26.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement26.Text = "Sort By";
            tileItemElement26.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemGameSavesSortBy.Elements.Add(tileItemElement26);
            this.TileItemGameSavesSortBy.Id = 1;
            this.TileItemGameSavesSortBy.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemGameSavesSortBy.Name = "TileItemGameSavesSortBy";
            this.TileItemGameSavesSortBy.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemGameSavesSortBy.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemGameSavesSortBy_ItemClick);
            // 
            // PagePlugins
            // 
            this.PagePlugins.Appearance.Options.UseFont = true;
            this.PagePlugins.Controls.Add(this.PanelPlugins);
            this.PagePlugins.Controls.Add(this.panel6);
            this.PagePlugins.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PagePlugins.Name = "PagePlugins";
            this.PagePlugins.Size = new System.Drawing.Size(1281, 712);
            // 
            // PanelPlugins
            // 
            this.PanelPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPlugins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelPlugins.BackColor = System.Drawing.Color.Transparent;
            this.PanelPlugins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPlugins.Controls.Add(this.GridControlPlugins);
            this.PanelPlugins.Controls.Add(this.PanelPluginsFilters);
            this.PanelPlugins.Location = new System.Drawing.Point(14, 84);
            this.PanelPlugins.Margin = new System.Windows.Forms.Padding(14);
            this.PanelPlugins.Name = "PanelPlugins";
            this.PanelPlugins.Size = new System.Drawing.Size(1253, 614);
            this.PanelPlugins.TabIndex = 1185;
            // 
            // GridControlPlugins
            // 
            this.GridControlPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlPlugins.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridControlPlugins.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.GridControlPlugins.EmbeddedNavigator.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.GridControlPlugins.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlPlugins.Location = new System.Drawing.Point(10, 70);
            this.GridControlPlugins.MainView = this.GridViewPlugins;
            this.GridControlPlugins.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GridControlPlugins.MenuManager = this.MainMenu;
            this.GridControlPlugins.Name = "GridControlPlugins";
            this.GridControlPlugins.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.GridControlPlugins.Size = new System.Drawing.Size(1231, 530);
            this.GridControlPlugins.TabIndex = 5;
            this.GridControlPlugins.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewPlugins});
            // 
            // GridViewPlugins
            // 
            this.GridViewPlugins.ActiveFilterEnabled = false;
            this.GridViewPlugins.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewPlugins.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewPlugins.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewPlugins.Appearance.FocusedCell.Options.UseBackColor = true;
            this.GridViewPlugins.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewPlugins.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewPlugins.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewPlugins.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewPlugins.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewPlugins.Appearance.Preview.Options.UseBackColor = true;
            this.GridViewPlugins.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.GridViewPlugins.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewPlugins.Appearance.Row.Options.UseBackColor = true;
            this.GridViewPlugins.Appearance.Row.Options.UseFont = true;
            this.GridViewPlugins.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewPlugins.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewPlugins.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewPlugins.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewPlugins.GridControl = this.GridControlPlugins;
            this.GridViewPlugins.GroupRowHeight = 20;
            this.GridViewPlugins.Name = "GridViewPlugins";
            this.GridViewPlugins.OptionsBehavior.Editable = false;
            this.GridViewPlugins.OptionsBehavior.ReadOnly = true;
            this.GridViewPlugins.OptionsCustomization.AllowFilter = false;
            this.GridViewPlugins.OptionsFilter.AllowFilterEditor = false;
            this.GridViewPlugins.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewPlugins.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewPlugins.OptionsView.ShowColumnHeaders = false;
            this.GridViewPlugins.OptionsView.ShowGroupPanel = false;
            this.GridViewPlugins.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewPlugins.OptionsView.ShowIndicator = false;
            this.GridViewPlugins.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewPlugins.RowHeight = 24;
            this.GridViewPlugins.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GridViewPlugins.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewPlugins_RowClick);
            this.GridViewPlugins.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GridViewPlugins_CustomDrawCell);
            // 
            // PanelPluginsFilters
            // 
            this.PanelPluginsFilters.BackColor = System.Drawing.Color.Transparent;
            this.PanelPluginsFilters.Controls.Add(this.ComboBoxPluginsFilterStatus);
            this.PanelPluginsFilters.Controls.Add(this.LabelPluginsFilterStatus);
            this.PanelPluginsFilters.Controls.Add(this.ComboBoxPluginsFilterCreator);
            this.PanelPluginsFilters.Controls.Add(this.LabelPluginsFilterCreator);
            this.PanelPluginsFilters.Controls.Add(this.separatorControl2);
            this.PanelPluginsFilters.Controls.Add(this.ComboBoxPluginsFilterCategory);
            this.PanelPluginsFilters.Controls.Add(this.labelControl13);
            this.PanelPluginsFilters.Controls.Add(this.ComboBoxPluginsFilterVersion);
            this.PanelPluginsFilters.Controls.Add(this.LabelPluginsFilterVersion);
            this.PanelPluginsFilters.Controls.Add(this.TextBoxPluginsFilterName);
            this.PanelPluginsFilters.Controls.Add(this.labelControl21);
            this.PanelPluginsFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPluginsFilters.Location = new System.Drawing.Point(0, 0);
            this.PanelPluginsFilters.Margin = new System.Windows.Forms.Padding(0, 4, 0, 50);
            this.PanelPluginsFilters.Name = "PanelPluginsFilters";
            this.PanelPluginsFilters.Size = new System.Drawing.Size(1251, 70);
            this.PanelPluginsFilters.TabIndex = 12;
            // 
            // ComboBoxPluginsFilterStatus
            // 
            this.ComboBoxPluginsFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPluginsFilterStatus.Location = new System.Drawing.Point(1130, 40);
            this.ComboBoxPluginsFilterStatus.MenuManager = this.MainMenu;
            this.ComboBoxPluginsFilterStatus.Name = "ComboBoxPluginsFilterStatus";
            this.ComboBoxPluginsFilterStatus.Properties.AllowFocused = false;
            this.ComboBoxPluginsFilterStatus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxPluginsFilterStatus.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxPluginsFilterStatus.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPluginsFilterStatus.Properties.AutoComplete = false;
            this.ComboBoxPluginsFilterStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPluginsFilterStatus.Properties.DropDownRows = 12;
            this.ComboBoxPluginsFilterStatus.Properties.Items.AddRange(new object[] {
            "<All>",
            "Not Installed",
            "Installing",
            "Installed"});
            this.ComboBoxPluginsFilterStatus.Properties.NullValuePrompt = "Select...";
            this.ComboBoxPluginsFilterStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxPluginsFilterStatus.Size = new System.Drawing.Size(102, 22);
            this.ComboBoxPluginsFilterStatus.TabIndex = 1182;
            this.ComboBoxPluginsFilterStatus.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPluginsFilterStatus_SelectedIndexChanged);
            // 
            // LabelPluginsFilterStatus
            // 
            this.LabelPluginsFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPluginsFilterStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelPluginsFilterStatus.Appearance.Options.UseFont = true;
            this.LabelPluginsFilterStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelPluginsFilterStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPluginsFilterStatus.Location = new System.Drawing.Point(1127, 20);
            this.LabelPluginsFilterStatus.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelPluginsFilterStatus.Name = "LabelPluginsFilterStatus";
            this.LabelPluginsFilterStatus.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelPluginsFilterStatus.Size = new System.Drawing.Size(41, 15);
            this.LabelPluginsFilterStatus.TabIndex = 1183;
            this.LabelPluginsFilterStatus.Text = "Status";
            // 
            // ComboBoxPluginsFilterCreator
            // 
            this.ComboBoxPluginsFilterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPluginsFilterCreator.Location = new System.Drawing.Point(997, 40);
            this.ComboBoxPluginsFilterCreator.MenuManager = this.MainMenu;
            this.ComboBoxPluginsFilterCreator.Name = "ComboBoxPluginsFilterCreator";
            this.ComboBoxPluginsFilterCreator.Properties.AllowFocused = false;
            this.ComboBoxPluginsFilterCreator.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxPluginsFilterCreator.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxPluginsFilterCreator.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPluginsFilterCreator.Properties.AutoComplete = false;
            this.ComboBoxPluginsFilterCreator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPluginsFilterCreator.Properties.DropDownRows = 12;
            this.ComboBoxPluginsFilterCreator.Properties.NullValuePrompt = "Select...";
            this.ComboBoxPluginsFilterCreator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxPluginsFilterCreator.Size = new System.Drawing.Size(127, 22);
            this.ComboBoxPluginsFilterCreator.TabIndex = 1175;
            this.ComboBoxPluginsFilterCreator.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPluginsFilterCreator_SelectedIndexChanged);
            // 
            // LabelPluginsFilterCreator
            // 
            this.LabelPluginsFilterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPluginsFilterCreator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelPluginsFilterCreator.Appearance.Options.UseFont = true;
            this.LabelPluginsFilterCreator.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelPluginsFilterCreator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPluginsFilterCreator.Location = new System.Drawing.Point(994, 20);
            this.LabelPluginsFilterCreator.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelPluginsFilterCreator.Name = "LabelPluginsFilterCreator";
            this.LabelPluginsFilterCreator.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelPluginsFilterCreator.Size = new System.Drawing.Size(48, 15);
            this.LabelPluginsFilterCreator.TabIndex = 1176;
            this.LabelPluginsFilterCreator.Text = "Creator";
            // 
            // separatorControl2
            // 
            this.separatorControl2.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl2.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl2.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separatorControl2.LineThickness = 3;
            this.separatorControl2.Location = new System.Drawing.Point(0, 67);
            this.separatorControl2.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.separatorControl2.Size = new System.Drawing.Size(1251, 3);
            this.separatorControl2.TabIndex = 1172;
            // 
            // ComboBoxPluginsFilterCategory
            // 
            this.ComboBoxPluginsFilterCategory.Location = new System.Drawing.Point(17, 40);
            this.ComboBoxPluginsFilterCategory.MenuManager = this.MainMenu;
            this.ComboBoxPluginsFilterCategory.Name = "ComboBoxPluginsFilterCategory";
            this.ComboBoxPluginsFilterCategory.Properties.AllowFocused = false;
            this.ComboBoxPluginsFilterCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxPluginsFilterCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxPluginsFilterCategory.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPluginsFilterCategory.Properties.AutoComplete = false;
            this.ComboBoxPluginsFilterCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPluginsFilterCategory.Properties.DropDownRows = 15;
            this.ComboBoxPluginsFilterCategory.Properties.NullValuePrompt = "Select...";
            this.ComboBoxPluginsFilterCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxPluginsFilterCategory.Size = new System.Drawing.Size(220, 22);
            this.ComboBoxPluginsFilterCategory.TabIndex = 1170;
            this.ComboBoxPluginsFilterCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPluginsFilterCategory_SelectedIndexChanged);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl13.Location = new System.Drawing.Point(15, 20);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl13.Size = new System.Drawing.Size(56, 15);
            this.labelControl13.TabIndex = 1171;
            this.labelControl13.Text = "Category";
            // 
            // ComboBoxPluginsFilterVersion
            // 
            this.ComboBoxPluginsFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPluginsFilterVersion.Location = new System.Drawing.Point(927, 40);
            this.ComboBoxPluginsFilterVersion.MenuManager = this.MainMenu;
            this.ComboBoxPluginsFilterVersion.Name = "ComboBoxPluginsFilterVersion";
            this.ComboBoxPluginsFilterVersion.Properties.AllowFocused = false;
            this.ComboBoxPluginsFilterVersion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxPluginsFilterVersion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxPluginsFilterVersion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPluginsFilterVersion.Properties.AutoComplete = false;
            this.ComboBoxPluginsFilterVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPluginsFilterVersion.Properties.DropDownRows = 12;
            this.ComboBoxPluginsFilterVersion.Properties.NullValuePrompt = "Select...";
            this.ComboBoxPluginsFilterVersion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxPluginsFilterVersion.Size = new System.Drawing.Size(64, 22);
            this.ComboBoxPluginsFilterVersion.TabIndex = 1164;
            this.ComboBoxPluginsFilterVersion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPluginsFilterVersion_SelectedIndexChanged);
            // 
            // LabelPluginsFilterVersion
            // 
            this.LabelPluginsFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPluginsFilterVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelPluginsFilterVersion.Appearance.Options.UseFont = true;
            this.LabelPluginsFilterVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelPluginsFilterVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPluginsFilterVersion.Location = new System.Drawing.Point(924, 20);
            this.LabelPluginsFilterVersion.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.LabelPluginsFilterVersion.Name = "LabelPluginsFilterVersion";
            this.LabelPluginsFilterVersion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelPluginsFilterVersion.Size = new System.Drawing.Size(48, 15);
            this.LabelPluginsFilterVersion.TabIndex = 1165;
            this.LabelPluginsFilterVersion.Text = "Version";
            // 
            // TextBoxPluginsFilterName
            // 
            this.TextBoxPluginsFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPluginsFilterName.Location = new System.Drawing.Point(243, 40);
            this.TextBoxPluginsFilterName.MenuManager = this.MainMenu;
            this.TextBoxPluginsFilterName.Name = "TextBoxPluginsFilterName";
            this.TextBoxPluginsFilterName.Properties.AllowFocused = false;
            this.TextBoxPluginsFilterName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TextBoxPluginsFilterName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPluginsFilterName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxPluginsFilterName.Properties.NullValuePrompt = "Search...";
            this.TextBoxPluginsFilterName.Size = new System.Drawing.Size(678, 22);
            this.TextBoxPluginsFilterName.TabIndex = 1;
            this.TextBoxPluginsFilterName.TextChanged += new System.EventHandler(this.TextBoxPluginsFilterName_TextChanged);
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl21.Location = new System.Drawing.Point(240, 20);
            this.labelControl21.Margin = new System.Windows.Forms.Padding(5, 4, 0, 2);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl21.Size = new System.Drawing.Size(39, 15);
            this.labelControl21.TabIndex = 1157;
            this.labelControl21.Text = "Name";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Controls.Add(this.TileControlPlugins);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1281, 70);
            this.panel6.TabIndex = 1184;
            // 
            // TileControlPlugins
            // 
            this.TileControlPlugins.AllowDisabledStateIndication = false;
            this.TileControlPlugins.AllowDrag = false;
            this.TileControlPlugins.AllowDragTilesBetweenGroups = false;
            this.TileControlPlugins.AllowGlyphSkinning = true;
            this.TileControlPlugins.AllowItemHover = true;
            this.TileControlPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TileControlPlugins.Groups.Add(this.TileGroupPlugins);
            this.TileControlPlugins.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TileControlPlugins.IndentBetweenItems = 2;
            this.TileControlPlugins.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade;
            this.TileControlPlugins.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileControlPlugins.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.TileControlPlugins.ItemPadding = new System.Windows.Forms.Padding(0);
            this.TileControlPlugins.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.TileControlPlugins.Location = new System.Drawing.Point(6, 5);
            this.TileControlPlugins.MaxId = 6;
            this.TileControlPlugins.Name = "TileControlPlugins";
            this.TileControlPlugins.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TileControlPlugins.Padding = new System.Windows.Forms.Padding(0);
            this.TileControlPlugins.Size = new System.Drawing.Size(332, 67);
            this.TileControlPlugins.TabIndex = 1;
            this.TileControlPlugins.Text = "TileControlModsActions";
            // 
            // TileGroupPlugins
            // 
            this.TileGroupPlugins.Items.Add(this.TileItemPluginsShowFavorites);
            this.TileGroupPlugins.Items.Add(this.TileItemPluginsSortBy);
            this.TileGroupPlugins.Name = "TileGroupPlugins";
            this.TileGroupPlugins.Text = "Plugins Actions";
            // 
            // TileItemPluginsShowFavorites
            // 
            this.TileItemPluginsShowFavorites.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemPluginsShowFavorites.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileItemPluginsShowFavorites.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemPluginsShowFavorites.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemPluginsShowFavorites.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemPluginsShowFavorites.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemPluginsShowFavorites.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemPluginsShowFavorites.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemPluginsShowFavorites.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemPluginsShowFavorites.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement27.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement27.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement27.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement27.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement27.ImageOptions.ImageToTextIndent = 2;
            tileItemElement27.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage10")));
            tileItemElement27.Text = "Show Favorites";
            tileItemElement27.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemPluginsShowFavorites.Elements.Add(tileItemElement27);
            this.TileItemPluginsShowFavorites.Id = 2;
            this.TileItemPluginsShowFavorites.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemPluginsShowFavorites.Name = "TileItemPluginsShowFavorites";
            this.TileItemPluginsShowFavorites.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemPluginsShowFavorites.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemPluginsShowFavorites_ItemClick);
            // 
            // TileItemPluginsSortBy
            // 
            this.TileItemPluginsSortBy.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemPluginsSortBy.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileItemPluginsSortBy.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemPluginsSortBy.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemPluginsSortBy.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemPluginsSortBy.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemPluginsSortBy.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemPluginsSortBy.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemPluginsSortBy.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemPluginsSortBy.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement28.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            tileItemElement28.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement28.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement28.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement28.ImageOptions.ImageToTextIndent = 2;
            tileItemElement28.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement28.Text = "Sort By";
            tileItemElement28.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemPluginsSortBy.Elements.Add(tileItemElement28);
            this.TileItemPluginsSortBy.Id = 1;
            this.TileItemPluginsSortBy.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemPluginsSortBy.Name = "TileItemPluginsSortBy";
            this.TileItemPluginsSortBy.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemPluginsSortBy.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemPluginsSortBy_ItemClick);
            // 
            // PagePackages
            // 
            this.PagePackages.Appearance.Options.UseFont = true;
            this.PagePackages.Controls.Add(this.PanelPackages);
            this.PagePackages.Controls.Add(this.PanelPackagesActions);
            this.PagePackages.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PagePackages.Name = "PagePackages";
            this.PagePackages.Size = new System.Drawing.Size(1281, 712);
            // 
            // PanelPackages
            // 
            this.PanelPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPackages.BackColor = System.Drawing.Color.Transparent;
            this.PanelPackages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPackages.Controls.Add(this.GridControlPackages);
            this.PanelPackages.Controls.Add(this.PanelPackagesFilters);
            this.PanelPackages.Location = new System.Drawing.Point(14, 84);
            this.PanelPackages.Margin = new System.Windows.Forms.Padding(14);
            this.PanelPackages.Name = "PanelPackages";
            this.PanelPackages.Size = new System.Drawing.Size(1253, 614);
            this.PanelPackages.TabIndex = 1183;
            // 
            // GridControlPackages
            // 
            this.GridControlPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlPackages.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlPackages.Location = new System.Drawing.Point(10, 70);
            this.GridControlPackages.MainView = this.GridViewPackages;
            this.GridControlPackages.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GridControlPackages.Name = "GridControlPackages";
            this.GridControlPackages.Size = new System.Drawing.Size(1231, 530);
            this.GridControlPackages.TabIndex = 5;
            this.GridControlPackages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewPackages});
            // 
            // GridViewPackages
            // 
            this.GridViewPackages.ActiveFilterEnabled = false;
            this.GridViewPackages.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewPackages.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewPackages.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewPackages.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewPackages.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewPackages.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewPackages.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.GridViewPackages.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewPackages.Appearance.Row.Options.UseBackColor = true;
            this.GridViewPackages.Appearance.Row.Options.UseFont = true;
            this.GridViewPackages.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewPackages.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewPackages.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewPackages.AppearancePrint.Row.Options.UseBackColor = true;
            this.GridViewPackages.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewPackages.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewPackages.GridControl = this.GridControlPackages;
            this.GridViewPackages.GroupRowHeight = 20;
            this.GridViewPackages.Name = "GridViewPackages";
            this.GridViewPackages.OptionsBehavior.Editable = false;
            this.GridViewPackages.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.GridViewPackages.OptionsBehavior.ReadOnly = true;
            this.GridViewPackages.OptionsCustomization.AllowFilter = false;
            this.GridViewPackages.OptionsFilter.AllowFilterEditor = false;
            this.GridViewPackages.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewPackages.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewPackages.OptionsView.ShowColumnHeaders = false;
            this.GridViewPackages.OptionsView.ShowGroupPanel = false;
            this.GridViewPackages.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewPackages.OptionsView.ShowIndicator = false;
            this.GridViewPackages.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewPackages.RowHeight = 24;
            this.GridViewPackages.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GridViewPackages.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewPackages_RowClick);
            this.GridViewPackages.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GridViewPackages_CustomDrawCell);
            // 
            // PanelPackagesFilters
            // 
            this.PanelPackagesFilters.BackColor = System.Drawing.Color.Transparent;
            this.PanelPackagesFilters.Controls.Add(this.ImagePackagesFilterFileSizeType);
            this.PanelPackagesFilters.Controls.Add(this.ImagePackagesFilterFileSizeBack);
            this.PanelPackagesFilters.Controls.Add(this.LabelPackagesFilterFileSize);
            this.PanelPackagesFilters.Controls.Add(this.ComboBoxPackagesFilterModifiedDate);
            this.PanelPackagesFilters.Controls.Add(this.ImagePackagesFilterDateType);
            this.PanelPackagesFilters.Controls.Add(this.LabelPackagesFilterModifiedDate);
            this.PanelPackagesFilters.Controls.Add(this.separatorControl4);
            this.PanelPackagesFilters.Controls.Add(this.ComboBoxPackagesFilterStatus);
            this.PanelPackagesFilters.Controls.Add(this.LabelPackagesFilterStatus);
            this.PanelPackagesFilters.Controls.Add(this.TextBoxPackagesFilterName);
            this.PanelPackagesFilters.Controls.Add(this.ComboBoxPackagesFilterRegion);
            this.PanelPackagesFilters.Controls.Add(this.LabelHeaderPackagesRegion);
            this.PanelPackagesFilters.Controls.Add(this.LabelPackagesFilterName);
            this.PanelPackagesFilters.Controls.Add(this.ComboBoxFilterPackagesCategories);
            this.PanelPackagesFilters.Controls.Add(this.LabelPackagesFilterCategory);
            this.PanelPackagesFilters.Controls.Add(this.ImagePackagesFilterDateTypeBack);
            this.PanelPackagesFilters.Controls.Add(this.ComboBoxPackagesFilterFileSize);
            this.PanelPackagesFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPackagesFilters.Location = new System.Drawing.Point(0, 0);
            this.PanelPackagesFilters.Margin = new System.Windows.Forms.Padding(0, 4, 0, 50);
            this.PanelPackagesFilters.Name = "PanelPackagesFilters";
            this.PanelPackagesFilters.Size = new System.Drawing.Size(1251, 70);
            this.PanelPackagesFilters.TabIndex = 12;
            // 
            // ImagePackagesFilterFileSizeType
            // 
            this.ImagePackagesFilterFileSizeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePackagesFilterFileSizeType.EditValue = ((object)(resources.GetObject("ImagePackagesFilterFileSizeType.EditValue")));
            this.ImagePackagesFilterFileSizeType.Location = new System.Drawing.Point(1046, 44);
            this.ImagePackagesFilterFileSizeType.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ImagePackagesFilterFileSizeType.MenuManager = this.MainMenu;
            this.ImagePackagesFilterFileSizeType.Name = "ImagePackagesFilterFileSizeType";
            this.ImagePackagesFilterFileSizeType.Properties.AllowFocused = false;
            this.ImagePackagesFilterFileSizeType.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImagePackagesFilterFileSizeType.Properties.Appearance.Options.UseForeColor = true;
            this.ImagePackagesFilterFileSizeType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImagePackagesFilterFileSizeType.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImagePackagesFilterFileSizeType.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImagePackagesFilterFileSizeType.Size = new System.Drawing.Size(14, 14);
            this.ImagePackagesFilterFileSizeType.TabIndex = 1199;
            this.ImagePackagesFilterFileSizeType.Click += new System.EventHandler(this.ImagePackagesFilterFileSizeType_Click);
            // 
            // ImagePackagesFilterFileSizeBack
            // 
            this.ImagePackagesFilterFileSizeBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePackagesFilterFileSizeBack.Location = new System.Drawing.Point(1042, 40);
            this.ImagePackagesFilterFileSizeBack.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ImagePackagesFilterFileSizeBack.MenuManager = this.MainMenu;
            this.ImagePackagesFilterFileSizeBack.Name = "ImagePackagesFilterFileSizeBack";
            this.ImagePackagesFilterFileSizeBack.Properties.AllowFocused = false;
            this.ImagePackagesFilterFileSizeBack.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImagePackagesFilterFileSizeBack.Properties.Appearance.Options.UseForeColor = true;
            this.ImagePackagesFilterFileSizeBack.Properties.NullText = " ";
            this.ImagePackagesFilterFileSizeBack.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImagePackagesFilterFileSizeBack.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImagePackagesFilterFileSizeBack.Size = new System.Drawing.Size(22, 22);
            this.ImagePackagesFilterFileSizeBack.TabIndex = 1200;
            // 
            // LabelPackagesFilterFileSize
            // 
            this.LabelPackagesFilterFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPackagesFilterFileSize.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelPackagesFilterFileSize.Appearance.Options.UseFont = true;
            this.LabelPackagesFilterFileSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelPackagesFilterFileSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPackagesFilterFileSize.Location = new System.Drawing.Point(1039, 20);
            this.LabelPackagesFilterFileSize.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelPackagesFilterFileSize.Name = "LabelPackagesFilterFileSize";
            this.LabelPackagesFilterFileSize.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelPackagesFilterFileSize.Size = new System.Drawing.Size(51, 15);
            this.LabelPackagesFilterFileSize.TabIndex = 1196;
            this.LabelPackagesFilterFileSize.Text = "File Size";
            // 
            // ComboBoxPackagesFilterModifiedDate
            // 
            this.ComboBoxPackagesFilterModifiedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPackagesFilterModifiedDate.EditValue = null;
            this.ComboBoxPackagesFilterModifiedDate.Location = new System.Drawing.Point(956, 40);
            this.ComboBoxPackagesFilterModifiedDate.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ComboBoxPackagesFilterModifiedDate.MenuManager = this.MainMenu;
            this.ComboBoxPackagesFilterModifiedDate.Name = "ComboBoxPackagesFilterModifiedDate";
            this.ComboBoxPackagesFilterModifiedDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxPackagesFilterModifiedDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxPackagesFilterModifiedDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxPackagesFilterModifiedDate.Properties.Appearance.Options.UseBackColor = true;
            this.ComboBoxPackagesFilterModifiedDate.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPackagesFilterModifiedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPackagesFilterModifiedDate.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.ComboBoxPackagesFilterModifiedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPackagesFilterModifiedDate.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "MM/dd/yyyy";
            this.ComboBoxPackagesFilterModifiedDate.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ComboBoxPackagesFilterModifiedDate.Properties.CalendarTimeProperties.EditFormat.FormatString = "MM/dd/yyyy";
            this.ComboBoxPackagesFilterModifiedDate.Properties.CalendarTimeProperties.TouchUIMaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.ComboBoxPackagesFilterModifiedDate.Properties.CalendarTimeProperties.UseMaskAsDisplayFormat = true;
            this.ComboBoxPackagesFilterModifiedDate.Properties.DisplayFormat.FormatString = "MM/dd/yyyy";
            this.ComboBoxPackagesFilterModifiedDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ComboBoxPackagesFilterModifiedDate.Properties.EditFormat.FormatString = "MM/dd/yyyy";
            this.ComboBoxPackagesFilterModifiedDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ComboBoxPackagesFilterModifiedDate.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.ComboBoxPackagesFilterModifiedDate.Properties.MaskSettings.Set("mask", "MM/dd/yyyy");
            this.ComboBoxPackagesFilterModifiedDate.Properties.NullValuePrompt = "Select...";
            this.ComboBoxPackagesFilterModifiedDate.Properties.UseMaskAsDisplayFormat = true;
            this.ComboBoxPackagesFilterModifiedDate.Size = new System.Drawing.Size(80, 22);
            this.ComboBoxPackagesFilterModifiedDate.TabIndex = 1191;
            this.ComboBoxPackagesFilterModifiedDate.EditValueChanged += new System.EventHandler(this.ComboBoxPackagesFilterModifiedDate_EditValueChanged);
            this.ComboBoxPackagesFilterModifiedDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxPackagesFilterModifiedDate_KeyDown);
            // 
            // ImagePackagesFilterDateType
            // 
            this.ImagePackagesFilterDateType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePackagesFilterDateType.EditValue = ((object)(resources.GetObject("ImagePackagesFilterDateType.EditValue")));
            this.ImagePackagesFilterDateType.Location = new System.Drawing.Point(939, 44);
            this.ImagePackagesFilterDateType.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ImagePackagesFilterDateType.MenuManager = this.MainMenu;
            this.ImagePackagesFilterDateType.Name = "ImagePackagesFilterDateType";
            this.ImagePackagesFilterDateType.Properties.AllowFocused = false;
            this.ImagePackagesFilterDateType.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImagePackagesFilterDateType.Properties.Appearance.Options.UseForeColor = true;
            this.ImagePackagesFilterDateType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImagePackagesFilterDateType.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImagePackagesFilterDateType.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImagePackagesFilterDateType.Size = new System.Drawing.Size(14, 14);
            this.ImagePackagesFilterDateType.TabIndex = 1194;
            this.ImagePackagesFilterDateType.Click += new System.EventHandler(this.ImagePackagesFilterDateType_Click);
            // 
            // LabelPackagesFilterModifiedDate
            // 
            this.LabelPackagesFilterModifiedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPackagesFilterModifiedDate.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelPackagesFilterModifiedDate.Appearance.Options.UseFont = true;
            this.LabelPackagesFilterModifiedDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelPackagesFilterModifiedDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPackagesFilterModifiedDate.Location = new System.Drawing.Point(931, 20);
            this.LabelPackagesFilterModifiedDate.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelPackagesFilterModifiedDate.Name = "LabelPackagesFilterModifiedDate";
            this.LabelPackagesFilterModifiedDate.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelPackagesFilterModifiedDate.Size = new System.Drawing.Size(86, 15);
            this.LabelPackagesFilterModifiedDate.TabIndex = 1190;
            this.LabelPackagesFilterModifiedDate.Text = "Modified Date";
            // 
            // separatorControl4
            // 
            this.separatorControl4.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl4.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl4.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separatorControl4.LineThickness = 3;
            this.separatorControl4.Location = new System.Drawing.Point(0, 67);
            this.separatorControl4.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.separatorControl4.Size = new System.Drawing.Size(1251, 3);
            this.separatorControl4.TabIndex = 1172;
            // 
            // ComboBoxPackagesFilterStatus
            // 
            this.ComboBoxPackagesFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPackagesFilterStatus.Location = new System.Drawing.Point(1130, 40);
            this.ComboBoxPackagesFilterStatus.MenuManager = this.MainMenu;
            this.ComboBoxPackagesFilterStatus.Name = "ComboBoxPackagesFilterStatus";
            this.ComboBoxPackagesFilterStatus.Properties.AllowFocused = false;
            this.ComboBoxPackagesFilterStatus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxPackagesFilterStatus.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ComboBoxPackagesFilterStatus.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPackagesFilterStatus.Properties.AutoComplete = false;
            this.ComboBoxPackagesFilterStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPackagesFilterStatus.Properties.Items.AddRange(new object[] {
            "<All>",
            "Downloaded",
            "Not Installed",
            "Installed"});
            this.ComboBoxPackagesFilterStatus.Properties.NullValuePrompt = "Select...";
            this.ComboBoxPackagesFilterStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxPackagesFilterStatus.Size = new System.Drawing.Size(102, 22);
            this.ComboBoxPackagesFilterStatus.TabIndex = 1168;
            this.ComboBoxPackagesFilterStatus.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPackagesFilterStatus_SelectedIndexChanged);
            // 
            // LabelPackagesFilterStatus
            // 
            this.LabelPackagesFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPackagesFilterStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelPackagesFilterStatus.Appearance.Options.UseFont = true;
            this.LabelPackagesFilterStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelPackagesFilterStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPackagesFilterStatus.Location = new System.Drawing.Point(1127, 20);
            this.LabelPackagesFilterStatus.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelPackagesFilterStatus.Name = "LabelPackagesFilterStatus";
            this.LabelPackagesFilterStatus.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelPackagesFilterStatus.Size = new System.Drawing.Size(41, 15);
            this.LabelPackagesFilterStatus.TabIndex = 1169;
            this.LabelPackagesFilterStatus.Text = "Status";
            // 
            // TextBoxPackagesFilterName
            // 
            this.TextBoxPackagesFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPackagesFilterName.Location = new System.Drawing.Point(92, 40);
            this.TextBoxPackagesFilterName.MenuManager = this.MainMenu;
            this.TextBoxPackagesFilterName.Name = "TextBoxPackagesFilterName";
            this.TextBoxPackagesFilterName.Properties.AllowFocused = false;
            this.TextBoxPackagesFilterName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TextBoxPackagesFilterName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxPackagesFilterName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxPackagesFilterName.Properties.NullValuePrompt = "Search...";
            this.TextBoxPackagesFilterName.Size = new System.Drawing.Size(750, 22);
            this.TextBoxPackagesFilterName.TabIndex = 1;
            this.TextBoxPackagesFilterName.EditValueChanged += new System.EventHandler(this.TextBoxPackagesFilterTitle_EditValueChanged);
            // 
            // ComboBoxPackagesFilterRegion
            // 
            this.ComboBoxPackagesFilterRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPackagesFilterRegion.Location = new System.Drawing.Point(847, 40);
            this.ComboBoxPackagesFilterRegion.MenuManager = this.MainMenu;
            this.ComboBoxPackagesFilterRegion.Name = "ComboBoxPackagesFilterRegion";
            this.ComboBoxPackagesFilterRegion.Properties.AllowFocused = false;
            this.ComboBoxPackagesFilterRegion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxPackagesFilterRegion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxPackagesFilterRegion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPackagesFilterRegion.Properties.AutoComplete = false;
            this.ComboBoxPackagesFilterRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPackagesFilterRegion.Properties.DropDownRows = 12;
            this.ComboBoxPackagesFilterRegion.Properties.Items.AddRange(new object[] {
            "<ALL>",
            "EU",
            "US",
            "JP",
            "ASIA"});
            this.ComboBoxPackagesFilterRegion.Properties.NullValuePrompt = "Select...";
            this.ComboBoxPackagesFilterRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxPackagesFilterRegion.Size = new System.Drawing.Size(82, 22);
            this.ComboBoxPackagesFilterRegion.TabIndex = 4;
            this.ComboBoxPackagesFilterRegion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPackagesFilterRegion_SelectedIndexChanged);
            // 
            // LabelHeaderPackagesRegion
            // 
            this.LabelHeaderPackagesRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderPackagesRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderPackagesRegion.Appearance.Options.UseFont = true;
            this.LabelHeaderPackagesRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHeaderPackagesRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderPackagesRegion.Location = new System.Drawing.Point(844, 20);
            this.LabelHeaderPackagesRegion.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelHeaderPackagesRegion.Name = "LabelHeaderPackagesRegion";
            this.LabelHeaderPackagesRegion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelHeaderPackagesRegion.Size = new System.Drawing.Size(45, 15);
            this.LabelHeaderPackagesRegion.TabIndex = 1163;
            this.LabelHeaderPackagesRegion.Text = "Region";
            // 
            // LabelPackagesFilterName
            // 
            this.LabelPackagesFilterName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelPackagesFilterName.Appearance.Options.UseFont = true;
            this.LabelPackagesFilterName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelPackagesFilterName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPackagesFilterName.Location = new System.Drawing.Point(89, 20);
            this.LabelPackagesFilterName.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelPackagesFilterName.Name = "LabelPackagesFilterName";
            this.LabelPackagesFilterName.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelPackagesFilterName.Size = new System.Drawing.Size(39, 15);
            this.LabelPackagesFilterName.TabIndex = 1157;
            this.LabelPackagesFilterName.Text = "Name";
            // 
            // ComboBoxFilterPackagesCategories
            // 
            this.ComboBoxFilterPackagesCategories.Location = new System.Drawing.Point(17, 40);
            this.ComboBoxFilterPackagesCategories.MenuManager = this.MainMenu;
            this.ComboBoxFilterPackagesCategories.Name = "ComboBoxFilterPackagesCategories";
            this.ComboBoxFilterPackagesCategories.Properties.AllowFocused = false;
            this.ComboBoxFilterPackagesCategories.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxFilterPackagesCategories.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxFilterPackagesCategories.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxFilterPackagesCategories.Properties.AutoComplete = false;
            this.ComboBoxFilterPackagesCategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxFilterPackagesCategories.Properties.DropDownRows = 15;
            this.ComboBoxFilterPackagesCategories.Properties.Items.AddRange(new object[] {
            "<ALL>",
            "Games",
            "Demos",
            "DLCs",
            "Avatars",
            "Themes"});
            this.ComboBoxFilterPackagesCategories.Properties.NullValuePrompt = "Select...";
            this.ComboBoxFilterPackagesCategories.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxFilterPackagesCategories.Size = new System.Drawing.Size(69, 22);
            this.ComboBoxFilterPackagesCategories.TabIndex = 1187;
            this.ComboBoxFilterPackagesCategories.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPackagesFilterCategories_SelectedIndexChanged);
            // 
            // LabelPackagesFilterCategory
            // 
            this.LabelPackagesFilterCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelPackagesFilterCategory.Appearance.Options.UseFont = true;
            this.LabelPackagesFilterCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelPackagesFilterCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPackagesFilterCategory.Location = new System.Drawing.Point(15, 20);
            this.LabelPackagesFilterCategory.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelPackagesFilterCategory.Name = "LabelPackagesFilterCategory";
            this.LabelPackagesFilterCategory.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelPackagesFilterCategory.Size = new System.Drawing.Size(56, 15);
            this.LabelPackagesFilterCategory.TabIndex = 1188;
            this.LabelPackagesFilterCategory.Text = "Category";
            // 
            // ImagePackagesFilterDateTypeBack
            // 
            this.ImagePackagesFilterDateTypeBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePackagesFilterDateTypeBack.Location = new System.Drawing.Point(935, 40);
            this.ImagePackagesFilterDateTypeBack.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ImagePackagesFilterDateTypeBack.MenuManager = this.MainMenu;
            this.ImagePackagesFilterDateTypeBack.Name = "ImagePackagesFilterDateTypeBack";
            this.ImagePackagesFilterDateTypeBack.Properties.AllowFocused = false;
            this.ImagePackagesFilterDateTypeBack.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImagePackagesFilterDateTypeBack.Properties.Appearance.Options.UseForeColor = true;
            this.ImagePackagesFilterDateTypeBack.Properties.NullText = " ";
            this.ImagePackagesFilterDateTypeBack.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImagePackagesFilterDateTypeBack.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImagePackagesFilterDateTypeBack.Size = new System.Drawing.Size(22, 22);
            this.ImagePackagesFilterDateTypeBack.TabIndex = 1197;
            // 
            // ComboBoxPackagesFilterFileSize
            // 
            this.ComboBoxPackagesFilterFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPackagesFilterFileSize.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ComboBoxPackagesFilterFileSize.Location = new System.Drawing.Point(1063, 40);
            this.ComboBoxPackagesFilterFileSize.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ComboBoxPackagesFilterFileSize.MenuManager = this.MainMenu;
            this.ComboBoxPackagesFilterFileSize.Name = "ComboBoxPackagesFilterFileSize";
            this.ComboBoxPackagesFilterFileSize.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxPackagesFilterFileSize.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBoxPackagesFilterFileSize.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxPackagesFilterFileSize.Properties.Appearance.Options.UseBackColor = true;
            this.ComboBoxPackagesFilterFileSize.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPackagesFilterFileSize.Properties.BeepOnError = false;
            this.ComboBoxPackagesFilterFileSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPackagesFilterFileSize.Properties.DisplayFormat.FormatString = "#### B";
            this.ComboBoxPackagesFilterFileSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ComboBoxPackagesFilterFileSize.Properties.EditFormat.FormatString = "#### B";
            this.ComboBoxPackagesFilterFileSize.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ComboBoxPackagesFilterFileSize.Properties.IsFloatValue = false;
            this.ComboBoxPackagesFilterFileSize.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.ComboBoxPackagesFilterFileSize.Properties.MaskSettings.Set("mask", "#### B");
            this.ComboBoxPackagesFilterFileSize.Properties.NullText = "0";
            this.ComboBoxPackagesFilterFileSize.Properties.NullValuePrompt = "Select...";
            this.ComboBoxPackagesFilterFileSize.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.False;
            this.ComboBoxPackagesFilterFileSize.Properties.UseMaskAsDisplayFormat = true;
            this.ComboBoxPackagesFilterFileSize.Size = new System.Drawing.Size(61, 22);
            this.ComboBoxPackagesFilterFileSize.TabIndex = 1198;
            // 
            // PanelPackagesActions
            // 
            this.PanelPackagesActions.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelPackagesActions.Controls.Add(this.TileControlPackages);
            this.PanelPackagesActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPackagesActions.Location = new System.Drawing.Point(0, 0);
            this.PanelPackagesActions.Margin = new System.Windows.Forms.Padding(0);
            this.PanelPackagesActions.Name = "PanelPackagesActions";
            this.PanelPackagesActions.Size = new System.Drawing.Size(1281, 70);
            this.PanelPackagesActions.TabIndex = 1182;
            // 
            // TileControlPackages
            // 
            this.TileControlPackages.AllowDisabledStateIndication = false;
            this.TileControlPackages.AllowDrag = false;
            this.TileControlPackages.AllowDragTilesBetweenGroups = false;
            this.TileControlPackages.AllowGlyphSkinning = true;
            this.TileControlPackages.AllowItemHover = true;
            this.TileControlPackages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TileControlPackages.Groups.Add(this.TileGroupPackages);
            this.TileControlPackages.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TileControlPackages.IndentBetweenItems = 2;
            this.TileControlPackages.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade;
            this.TileControlPackages.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileControlPackages.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.TileControlPackages.ItemPadding = new System.Windows.Forms.Padding(0);
            this.TileControlPackages.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.TileControlPackages.Location = new System.Drawing.Point(6, 5);
            this.TileControlPackages.MaxId = 6;
            this.TileControlPackages.Name = "TileControlPackages";
            this.TileControlPackages.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TileControlPackages.Padding = new System.Windows.Forms.Padding(0);
            this.TileControlPackages.Size = new System.Drawing.Size(332, 67);
            this.TileControlPackages.TabIndex = 1;
            this.TileControlPackages.Text = "TileControlModsActions";
            // 
            // TileGroupPackages
            // 
            this.TileGroupPackages.Items.Add(this.TileItemPackagesSortBy);
            this.TileGroupPackages.Name = "TileGroupPackages";
            this.TileGroupPackages.Text = "Packages Actions";
            // 
            // TileItemPackagesSortBy
            // 
            this.TileItemPackagesSortBy.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemPackagesSortBy.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileItemPackagesSortBy.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemPackagesSortBy.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemPackagesSortBy.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemPackagesSortBy.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemPackagesSortBy.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemPackagesSortBy.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemPackagesSortBy.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemPackagesSortBy.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement29.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            tileItemElement29.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement29.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement29.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement29.ImageOptions.ImageToTextIndent = 2;
            tileItemElement29.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement29.Text = "Sort By";
            tileItemElement29.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemPackagesSortBy.Elements.Add(tileItemElement29);
            this.TileItemPackagesSortBy.Id = 1;
            this.TileItemPackagesSortBy.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemPackagesSortBy.Name = "TileItemPackagesSortBy";
            this.TileItemPackagesSortBy.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemPackagesSortBy.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemPackagesSortBy_ItemClick);
            // 
            // PageRealTimeMods
            // 
            this.PageRealTimeMods.Appearance.Options.UseFont = true;
            this.PageRealTimeMods.Controls.Add(this.panel7);
            this.PageRealTimeMods.Controls.Add(this.panel1);
            this.PageRealTimeMods.Controls.Add(this.panel5);
            this.PageRealTimeMods.Controls.Add(this.PanelRealTimeMods);
            this.PageRealTimeMods.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PageRealTimeMods.Name = "PageRealTimeMods";
            this.PageRealTimeMods.Size = new System.Drawing.Size(1281, 712);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.gridControl1);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(797, 471);
            this.panel7.Margin = new System.Windows.Forms.Padding(14);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(470, 227);
            this.panel7.TabIndex = 1218;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridControl1.Location = new System.Drawing.Point(10, 70);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(276, 143);
            this.gridControl1.TabIndex = 1220;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.gridView1.AppearancePrint.Row.Options.UseBackColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupRowHeight = 20;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.RowHeight = 24;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.comboBoxEdit3);
            this.panel8.Controls.Add(this.separatorControl8);
            this.panel8.Controls.Add(this.comboBoxEdit4);
            this.panel8.Controls.Add(this.labelControl36);
            this.panel8.Controls.Add(this.textEdit2);
            this.panel8.Controls.Add(this.labelControl49);
            this.panel8.Controls.Add(this.labelControl50);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0, 4, 0, 50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(468, 70);
            this.panel8.TabIndex = 1219;
            // 
            // comboBoxEdit3
            // 
            this.comboBoxEdit3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit3.Location = new System.Drawing.Point(357, 40);
            this.comboBoxEdit3.MenuManager = this.MainMenu;
            this.comboBoxEdit3.Name = "comboBoxEdit3";
            this.comboBoxEdit3.Properties.AllowFocused = false;
            this.comboBoxEdit3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxEdit3.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxEdit3.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit3.Properties.AutoComplete = false;
            this.comboBoxEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit3.Properties.DropDownRows = 12;
            this.comboBoxEdit3.Properties.Items.AddRange(new object[] {
            "<ANY>",
            "Singleplayer",
            "Multiplayer",
            "Zombies",
            "Special Ops",
            "Extinction"});
            this.comboBoxEdit3.Properties.NullValuePrompt = "Select...";
            this.comboBoxEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit3.Size = new System.Drawing.Size(92, 22);
            this.comboBoxEdit3.TabIndex = 1173;
            // 
            // separatorControl8
            // 
            this.separatorControl8.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl8.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl8.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separatorControl8.LineThickness = 3;
            this.separatorControl8.Location = new System.Drawing.Point(0, 67);
            this.separatorControl8.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl8.Name = "separatorControl8";
            this.separatorControl8.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.separatorControl8.Size = new System.Drawing.Size(468, 3);
            this.separatorControl8.TabIndex = 1172;
            // 
            // comboBoxEdit4
            // 
            this.comboBoxEdit4.Location = new System.Drawing.Point(17, 40);
            this.comboBoxEdit4.MenuManager = this.MainMenu;
            this.comboBoxEdit4.Name = "comboBoxEdit4";
            this.comboBoxEdit4.Properties.AllowFocused = false;
            this.comboBoxEdit4.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxEdit4.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxEdit4.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit4.Properties.AutoComplete = false;
            this.comboBoxEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit4.Properties.DropDownRows = 15;
            this.comboBoxEdit4.Properties.NullValuePrompt = "Select...";
            this.comboBoxEdit4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit4.Size = new System.Drawing.Size(87, 22);
            this.comboBoxEdit4.TabIndex = 1170;
            // 
            // labelControl36
            // 
            this.labelControl36.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl36.Appearance.Options.UseFont = true;
            this.labelControl36.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl36.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl36.Location = new System.Drawing.Point(15, 20);
            this.labelControl36.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl36.Size = new System.Drawing.Size(39, 15);
            this.labelControl36.TabIndex = 1171;
            this.labelControl36.Text = "Game";
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit2.Location = new System.Drawing.Point(110, 40);
            this.textEdit2.MenuManager = this.MainMenu;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.AllowFocused = false;
            this.textEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.NullValuePrompt = "Search...";
            this.textEdit2.Size = new System.Drawing.Size(120, 22);
            this.textEdit2.TabIndex = 1;
            // 
            // labelControl49
            // 
            this.labelControl49.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl49.Appearance.Options.UseFont = true;
            this.labelControl49.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl49.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl49.Location = new System.Drawing.Point(107, 20);
            this.labelControl49.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl49.Name = "labelControl49";
            this.labelControl49.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl49.Size = new System.Drawing.Size(39, 15);
            this.labelControl49.TabIndex = 1157;
            this.labelControl49.Text = "Name";
            // 
            // labelControl50
            // 
            this.labelControl50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl50.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl50.Appearance.Options.UseFont = true;
            this.labelControl50.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl50.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl50.Location = new System.Drawing.Point(354, 20);
            this.labelControl50.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl50.Name = "labelControl50";
            this.labelControl50.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl50.Size = new System.Drawing.Size(74, 15);
            this.labelControl50.TabIndex = 1122;
            this.labelControl50.Text = "Game Mode";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.GridControlMemoryOffsets);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(797, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 382);
            this.panel1.TabIndex = 1216;
            // 
            // GridControlMemoryOffsets
            // 
            this.GridControlMemoryOffsets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlMemoryOffsets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlMemoryOffsets.Location = new System.Drawing.Point(10, 70);
            this.GridControlMemoryOffsets.MainView = this.GridViewMemoryOffsets;
            this.GridControlMemoryOffsets.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GridControlMemoryOffsets.Name = "GridControlMemoryOffsets";
            this.GridControlMemoryOffsets.Size = new System.Drawing.Size(276, 298);
            this.GridControlMemoryOffsets.TabIndex = 1220;
            this.GridControlMemoryOffsets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewMemoryOffsets});
            // 
            // GridViewMemoryOffsets
            // 
            this.GridViewMemoryOffsets.ActiveFilterEnabled = false;
            this.GridViewMemoryOffsets.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewMemoryOffsets.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewMemoryOffsets.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewMemoryOffsets.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewMemoryOffsets.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewMemoryOffsets.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewMemoryOffsets.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.GridViewMemoryOffsets.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewMemoryOffsets.Appearance.Row.Options.UseBackColor = true;
            this.GridViewMemoryOffsets.Appearance.Row.Options.UseFont = true;
            this.GridViewMemoryOffsets.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewMemoryOffsets.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewMemoryOffsets.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewMemoryOffsets.AppearancePrint.Row.Options.UseBackColor = true;
            this.GridViewMemoryOffsets.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewMemoryOffsets.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewMemoryOffsets.GridControl = this.GridControlMemoryOffsets;
            this.GridViewMemoryOffsets.GroupRowHeight = 20;
            this.GridViewMemoryOffsets.Name = "GridViewMemoryOffsets";
            this.GridViewMemoryOffsets.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.GridViewMemoryOffsets.OptionsCustomization.AllowFilter = false;
            this.GridViewMemoryOffsets.OptionsFilter.AllowFilterEditor = false;
            this.GridViewMemoryOffsets.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewMemoryOffsets.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewMemoryOffsets.OptionsView.ShowColumnHeaders = false;
            this.GridViewMemoryOffsets.OptionsView.ShowGroupPanel = false;
            this.GridViewMemoryOffsets.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewMemoryOffsets.OptionsView.ShowIndicator = false;
            this.GridViewMemoryOffsets.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewMemoryOffsets.RowHeight = 24;
            this.GridViewMemoryOffsets.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.comboBoxEdit1);
            this.panel3.Controls.Add(this.separatorControl7);
            this.panel3.Controls.Add(this.ComboBoxRealTimeModsGame);
            this.panel3.Controls.Add(this.labelControl24);
            this.panel3.Controls.Add(this.labelControl43);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 4, 0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 70);
            this.panel3.TabIndex = 1219;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit1.Location = new System.Drawing.Point(357, 40);
            this.comboBoxEdit1.MenuManager = this.MainMenu;
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.AllowFocused = false;
            this.comboBoxEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.AutoComplete = false;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.DropDownRows = 12;
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "<ANY>",
            "Singleplayer",
            "Multiplayer",
            "Zombies",
            "Special Ops",
            "Extinction"});
            this.comboBoxEdit1.Properties.NullValuePrompt = "Select...";
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(92, 22);
            this.comboBoxEdit1.TabIndex = 1173;
            // 
            // separatorControl7
            // 
            this.separatorControl7.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl7.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl7.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separatorControl7.LineThickness = 3;
            this.separatorControl7.Location = new System.Drawing.Point(0, 67);
            this.separatorControl7.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl7.Name = "separatorControl7";
            this.separatorControl7.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.separatorControl7.Size = new System.Drawing.Size(468, 3);
            this.separatorControl7.TabIndex = 1172;
            // 
            // ComboBoxRealTimeModsGame
            // 
            this.ComboBoxRealTimeModsGame.Location = new System.Drawing.Point(17, 40);
            this.ComboBoxRealTimeModsGame.MenuManager = this.MainMenu;
            this.ComboBoxRealTimeModsGame.Name = "ComboBoxRealTimeModsGame";
            this.ComboBoxRealTimeModsGame.Properties.AllowFocused = false;
            this.ComboBoxRealTimeModsGame.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxRealTimeModsGame.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxRealTimeModsGame.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxRealTimeModsGame.Properties.AutoComplete = false;
            this.ComboBoxRealTimeModsGame.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxRealTimeModsGame.Properties.DropDownRows = 15;
            this.ComboBoxRealTimeModsGame.Properties.NullValuePrompt = "Select...";
            this.ComboBoxRealTimeModsGame.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxRealTimeModsGame.Size = new System.Drawing.Size(334, 22);
            this.ComboBoxRealTimeModsGame.TabIndex = 1170;
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl24.Appearance.Options.UseFont = true;
            this.labelControl24.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl24.Location = new System.Drawing.Point(15, 20);
            this.labelControl24.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl24.Size = new System.Drawing.Size(39, 15);
            this.labelControl24.TabIndex = 1171;
            this.labelControl24.Text = "Game";
            // 
            // labelControl43
            // 
            this.labelControl43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl43.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl43.Appearance.Options.UseFont = true;
            this.labelControl43.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl43.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl43.Location = new System.Drawing.Point(354, 20);
            this.labelControl43.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl43.Name = "labelControl43";
            this.labelControl43.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl43.Size = new System.Drawing.Size(74, 15);
            this.labelControl43.TabIndex = 1122;
            this.labelControl43.Text = "Game Mode";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Controls.Add(this.ButtonAttachGame);
            this.panel5.Controls.Add(this.TileControlRealTimeMods);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1281, 70);
            this.panel5.TabIndex = 1217;
            // 
            // ButtonAttachGame
            // 
            this.ButtonAttachGame.Location = new System.Drawing.Point(845, 29);
            this.ButtonAttachGame.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonAttachGame.Name = "ButtonAttachGame";
            this.ButtonAttachGame.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonAttachGame.Size = new System.Drawing.Size(98, 24);
            this.ButtonAttachGame.TabIndex = 1174;
            this.ButtonAttachGame.Text = "Attach";
            this.ButtonAttachGame.Click += new System.EventHandler(this.ButtonAttachGame_Click);
            // 
            // TileControlRealTimeMods
            // 
            this.TileControlRealTimeMods.AllowDisabledStateIndication = false;
            this.TileControlRealTimeMods.AllowDrag = false;
            this.TileControlRealTimeMods.AllowDragTilesBetweenGroups = false;
            this.TileControlRealTimeMods.AllowGlyphSkinning = true;
            this.TileControlRealTimeMods.AllowItemHover = true;
            this.TileControlRealTimeMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TileControlRealTimeMods.Groups.Add(this.TileGroupRealTimeMods);
            this.TileControlRealTimeMods.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TileControlRealTimeMods.IndentBetweenItems = 2;
            this.TileControlRealTimeMods.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade;
            this.TileControlRealTimeMods.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileControlRealTimeMods.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.TileControlRealTimeMods.ItemPadding = new System.Windows.Forms.Padding(0);
            this.TileControlRealTimeMods.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.TileControlRealTimeMods.Location = new System.Drawing.Point(6, 5);
            this.TileControlRealTimeMods.MaxId = 7;
            this.TileControlRealTimeMods.Name = "TileControlRealTimeMods";
            this.TileControlRealTimeMods.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TileControlRealTimeMods.Padding = new System.Windows.Forms.Padding(0);
            this.TileControlRealTimeMods.Size = new System.Drawing.Size(332, 67);
            this.TileControlRealTimeMods.TabIndex = 1;
            this.TileControlRealTimeMods.Text = "TileControlModsActions";
            // 
            // TileGroupRealTimeMods
            // 
            this.TileGroupRealTimeMods.Items.Add(this.TileItemRealTimeModsCategories);
            this.TileGroupRealTimeMods.Items.Add(this.TileItemRealTimeModsSort);
            this.TileGroupRealTimeMods.Items.Add(this.TileItemRealTimeModsImport);
            this.TileGroupRealTimeMods.Name = "TileGroupRealTimeMods";
            this.TileGroupRealTimeMods.Text = "Real Time Mods Actions";
            // 
            // TileItemRealTimeModsCategories
            // 
            this.TileItemRealTimeModsCategories.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemRealTimeModsCategories.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileItemRealTimeModsCategories.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemRealTimeModsCategories.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemRealTimeModsCategories.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemRealTimeModsCategories.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemRealTimeModsCategories.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemRealTimeModsCategories.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemRealTimeModsCategories.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemRealTimeModsCategories.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement30.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image9")));
            tileItemElement30.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement30.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement30.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement30.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement30.ImageOptions.ImageToTextIndent = 2;
            tileItemElement30.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement30.Text = "Categories";
            tileItemElement30.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemRealTimeModsCategories.Elements.Add(tileItemElement30);
            this.TileItemRealTimeModsCategories.Id = 0;
            this.TileItemRealTimeModsCategories.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemRealTimeModsCategories.Name = "TileItemRealTimeModsCategories";
            this.TileItemRealTimeModsCategories.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            // 
            // TileItemRealTimeModsSort
            // 
            this.TileItemRealTimeModsSort.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemRealTimeModsSort.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileItemRealTimeModsSort.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemRealTimeModsSort.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemRealTimeModsSort.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemRealTimeModsSort.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemRealTimeModsSort.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemRealTimeModsSort.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemRealTimeModsSort.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemRealTimeModsSort.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement31.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image10")));
            tileItemElement31.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement31.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement31.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement31.ImageOptions.ImageToTextIndent = 2;
            tileItemElement31.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement31.Text = "Sort By";
            tileItemElement31.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemRealTimeModsSort.Elements.Add(tileItemElement31);
            this.TileItemRealTimeModsSort.Id = 1;
            this.TileItemRealTimeModsSort.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemRealTimeModsSort.Name = "TileItemRealTimeModsSort";
            this.TileItemRealTimeModsSort.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            // 
            // TileItemRealTimeModsImport
            // 
            this.TileItemRealTimeModsImport.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemRealTimeModsImport.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileItemRealTimeModsImport.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemRealTimeModsImport.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemRealTimeModsImport.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemRealTimeModsImport.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemRealTimeModsImport.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemRealTimeModsImport.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemRealTimeModsImport.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemRealTimeModsImport.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement32.ImageOptions.Image = global::ModioX.Properties.Resources.add_file;
            tileItemElement32.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement32.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement32.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement32.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement32.ImageOptions.ImageToTextIndent = 2;
            tileItemElement32.Text = "Import";
            tileItemElement32.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemRealTimeModsImport.Elements.Add(tileItemElement32);
            this.TileItemRealTimeModsImport.Id = 2;
            this.TileItemRealTimeModsImport.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemRealTimeModsImport.Name = "TileItemRealTimeModsImport";
            this.TileItemRealTimeModsImport.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            // 
            // PanelRealTimeMods
            // 
            this.PanelRealTimeMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRealTimeMods.BackColor = System.Drawing.Color.Transparent;
            this.PanelRealTimeMods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRealTimeMods.Controls.Add(this.GridControlRealTimeMods);
            this.PanelRealTimeMods.Controls.Add(this.panel4);
            this.PanelRealTimeMods.Controls.Add(this.FlyoutPanelRealTimeMods);
            this.PanelRealTimeMods.Location = new System.Drawing.Point(14, 84);
            this.PanelRealTimeMods.Margin = new System.Windows.Forms.Padding(14);
            this.PanelRealTimeMods.Name = "PanelRealTimeMods";
            this.PanelRealTimeMods.Size = new System.Drawing.Size(777, 614);
            this.PanelRealTimeMods.TabIndex = 1215;
            // 
            // GridControlRealTimeMods
            // 
            this.GridControlRealTimeMods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlRealTimeMods.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlRealTimeMods.Location = new System.Drawing.Point(10, 70);
            this.GridControlRealTimeMods.MainView = this.GridViewRealTimeMods;
            this.GridControlRealTimeMods.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GridControlRealTimeMods.Name = "GridControlRealTimeMods";
            this.GridControlRealTimeMods.Size = new System.Drawing.Size(755, 530);
            this.GridControlRealTimeMods.TabIndex = 5;
            this.GridControlRealTimeMods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewRealTimeMods});
            // 
            // GridViewRealTimeMods
            // 
            this.GridViewRealTimeMods.ActiveFilterEnabled = false;
            this.GridViewRealTimeMods.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewRealTimeMods.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewRealTimeMods.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewRealTimeMods.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewRealTimeMods.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewRealTimeMods.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewRealTimeMods.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.GridViewRealTimeMods.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewRealTimeMods.Appearance.Row.Options.UseBackColor = true;
            this.GridViewRealTimeMods.Appearance.Row.Options.UseFont = true;
            this.GridViewRealTimeMods.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewRealTimeMods.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewRealTimeMods.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewRealTimeMods.AppearancePrint.Row.Options.UseBackColor = true;
            this.GridViewRealTimeMods.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewRealTimeMods.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewRealTimeMods.GridControl = this.GridControlRealTimeMods;
            this.GridViewRealTimeMods.GroupRowHeight = 20;
            this.GridViewRealTimeMods.Name = "GridViewRealTimeMods";
            this.GridViewRealTimeMods.OptionsBehavior.Editable = false;
            this.GridViewRealTimeMods.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.GridViewRealTimeMods.OptionsBehavior.ReadOnly = true;
            this.GridViewRealTimeMods.OptionsCustomization.AllowFilter = false;
            this.GridViewRealTimeMods.OptionsFilter.AllowFilterEditor = false;
            this.GridViewRealTimeMods.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewRealTimeMods.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewRealTimeMods.OptionsView.ShowColumnHeaders = false;
            this.GridViewRealTimeMods.OptionsView.ShowGroupPanel = false;
            this.GridViewRealTimeMods.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewRealTimeMods.OptionsView.ShowIndicator = false;
            this.GridViewRealTimeMods.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewRealTimeMods.RowHeight = 24;
            this.GridViewRealTimeMods.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GridViewRealTimeMods.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewRealTimeMods_RowClick);
            this.GridViewRealTimeMods.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GridViewRealTimeMods_CustomDrawCell);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.ComboBoxFilterRealTimeModsGameMode);
            this.panel4.Controls.Add(this.separatorControl6);
            this.panel4.Controls.Add(this.ComboBoxFilterRealTimeModsGame);
            this.panel4.Controls.Add(this.labelControl66);
            this.panel4.Controls.Add(this.TextBoxFilterRealTimeModsName);
            this.panel4.Controls.Add(this.ComboBoxFilterRealTimeModsCategory);
            this.panel4.Controls.Add(this.labelControl71);
            this.panel4.Controls.Add(this.labelControl72);
            this.panel4.Controls.Add(this.labelControl73);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 4, 0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(775, 70);
            this.panel4.TabIndex = 12;
            // 
            // ComboBoxFilterRealTimeModsGameMode
            // 
            this.ComboBoxFilterRealTimeModsGameMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxFilterRealTimeModsGameMode.Location = new System.Drawing.Point(664, 40);
            this.ComboBoxFilterRealTimeModsGameMode.MenuManager = this.MainMenu;
            this.ComboBoxFilterRealTimeModsGameMode.Name = "ComboBoxFilterRealTimeModsGameMode";
            this.ComboBoxFilterRealTimeModsGameMode.Properties.AllowFocused = false;
            this.ComboBoxFilterRealTimeModsGameMode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxFilterRealTimeModsGameMode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxFilterRealTimeModsGameMode.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxFilterRealTimeModsGameMode.Properties.AutoComplete = false;
            this.ComboBoxFilterRealTimeModsGameMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxFilterRealTimeModsGameMode.Properties.DropDownRows = 12;
            this.ComboBoxFilterRealTimeModsGameMode.Properties.Items.AddRange(new object[] {
            "<ANY>",
            "Singleplayer",
            "Multiplayer",
            "Zombies",
            "Special Ops",
            "Extinction"});
            this.ComboBoxFilterRealTimeModsGameMode.Properties.NullValuePrompt = "Select...";
            this.ComboBoxFilterRealTimeModsGameMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxFilterRealTimeModsGameMode.Size = new System.Drawing.Size(92, 22);
            this.ComboBoxFilterRealTimeModsGameMode.TabIndex = 1173;
            // 
            // separatorControl6
            // 
            this.separatorControl6.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl6.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl6.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separatorControl6.LineThickness = 3;
            this.separatorControl6.Location = new System.Drawing.Point(0, 67);
            this.separatorControl6.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl6.Name = "separatorControl6";
            this.separatorControl6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.separatorControl6.Size = new System.Drawing.Size(775, 3);
            this.separatorControl6.TabIndex = 1172;
            // 
            // ComboBoxFilterRealTimeModsGame
            // 
            this.ComboBoxFilterRealTimeModsGame.Location = new System.Drawing.Point(17, 40);
            this.ComboBoxFilterRealTimeModsGame.MenuManager = this.MainMenu;
            this.ComboBoxFilterRealTimeModsGame.Name = "ComboBoxFilterRealTimeModsGame";
            this.ComboBoxFilterRealTimeModsGame.Properties.AllowFocused = false;
            this.ComboBoxFilterRealTimeModsGame.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxFilterRealTimeModsGame.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxFilterRealTimeModsGame.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxFilterRealTimeModsGame.Properties.AutoComplete = false;
            this.ComboBoxFilterRealTimeModsGame.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxFilterRealTimeModsGame.Properties.DropDownRows = 15;
            this.ComboBoxFilterRealTimeModsGame.Properties.NullValuePrompt = "Select...";
            this.ComboBoxFilterRealTimeModsGame.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxFilterRealTimeModsGame.Size = new System.Drawing.Size(220, 22);
            this.ComboBoxFilterRealTimeModsGame.TabIndex = 1170;
            // 
            // labelControl66
            // 
            this.labelControl66.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl66.Appearance.Options.UseFont = true;
            this.labelControl66.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl66.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl66.Location = new System.Drawing.Point(15, 20);
            this.labelControl66.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl66.Name = "labelControl66";
            this.labelControl66.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl66.Size = new System.Drawing.Size(39, 15);
            this.labelControl66.TabIndex = 1171;
            this.labelControl66.Text = "Game";
            // 
            // TextBoxFilterRealTimeModsName
            // 
            this.TextBoxFilterRealTimeModsName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFilterRealTimeModsName.Location = new System.Drawing.Point(243, 40);
            this.TextBoxFilterRealTimeModsName.MenuManager = this.MainMenu;
            this.TextBoxFilterRealTimeModsName.Name = "TextBoxFilterRealTimeModsName";
            this.TextBoxFilterRealTimeModsName.Properties.AllowFocused = false;
            this.TextBoxFilterRealTimeModsName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TextBoxFilterRealTimeModsName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxFilterRealTimeModsName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxFilterRealTimeModsName.Properties.NullValuePrompt = "Search...";
            this.TextBoxFilterRealTimeModsName.Size = new System.Drawing.Size(289, 22);
            this.TextBoxFilterRealTimeModsName.TabIndex = 1;
            // 
            // ComboBoxFilterRealTimeModsCategory
            // 
            this.ComboBoxFilterRealTimeModsCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxFilterRealTimeModsCategory.Location = new System.Drawing.Point(538, 40);
            this.ComboBoxFilterRealTimeModsCategory.MenuManager = this.MainMenu;
            this.ComboBoxFilterRealTimeModsCategory.Name = "ComboBoxFilterRealTimeModsCategory";
            this.ComboBoxFilterRealTimeModsCategory.Properties.AllowFocused = false;
            this.ComboBoxFilterRealTimeModsCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxFilterRealTimeModsCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxFilterRealTimeModsCategory.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxFilterRealTimeModsCategory.Properties.AutoComplete = false;
            this.ComboBoxFilterRealTimeModsCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxFilterRealTimeModsCategory.Properties.DropDownRows = 12;
            this.ComboBoxFilterRealTimeModsCategory.Properties.Items.AddRange(new object[] {
            "<All>"});
            this.ComboBoxFilterRealTimeModsCategory.Properties.NullValuePrompt = "Select...";
            this.ComboBoxFilterRealTimeModsCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxFilterRealTimeModsCategory.Size = new System.Drawing.Size(120, 22);
            this.ComboBoxFilterRealTimeModsCategory.TabIndex = 2;
            // 
            // labelControl71
            // 
            this.labelControl71.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl71.Appearance.Options.UseFont = true;
            this.labelControl71.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl71.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl71.Location = new System.Drawing.Point(240, 20);
            this.labelControl71.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl71.Name = "labelControl71";
            this.labelControl71.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl71.Size = new System.Drawing.Size(39, 15);
            this.labelControl71.TabIndex = 1157;
            this.labelControl71.Text = "Name";
            // 
            // labelControl72
            // 
            this.labelControl72.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl72.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl72.Appearance.Options.UseFont = true;
            this.labelControl72.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl72.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl72.Location = new System.Drawing.Point(535, 20);
            this.labelControl72.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl72.Name = "labelControl72";
            this.labelControl72.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl72.Size = new System.Drawing.Size(56, 15);
            this.labelControl72.TabIndex = 1156;
            this.labelControl72.Text = "Category";
            // 
            // labelControl73
            // 
            this.labelControl73.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl73.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl73.Appearance.Options.UseFont = true;
            this.labelControl73.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl73.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl73.Location = new System.Drawing.Point(661, 20);
            this.labelControl73.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl73.Name = "labelControl73";
            this.labelControl73.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl73.Size = new System.Drawing.Size(74, 15);
            this.labelControl73.TabIndex = 1122;
            this.labelControl73.Text = "Game Mode";
            // 
            // FlyoutPanelRealTimeMods
            // 
            this.FlyoutPanelRealTimeMods.Controls.Add(this.FlyoutPanelControlRealTimeMods);
            this.FlyoutPanelRealTimeMods.Location = new System.Drawing.Point(370, -1);
            this.FlyoutPanelRealTimeMods.Name = "FlyoutPanelRealTimeMods";
            this.FlyoutPanelRealTimeMods.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.FlyoutPanelRealTimeMods.Options.CloseOnOuterClick = true;
            this.FlyoutPanelRealTimeMods.Options.Location = new System.Drawing.Point(0, -1);
            this.FlyoutPanelRealTimeMods.Options.VertIndent = 10;
            this.FlyoutPanelRealTimeMods.OptionsBeakPanel.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Slide;
            this.FlyoutPanelRealTimeMods.OptionsButtonPanel.AllowGlyphSkinning = true;
            this.FlyoutPanelRealTimeMods.OwnerControl = this.PanelRealTimeMods;
            this.FlyoutPanelRealTimeMods.ParentForm = this;
            this.FlyoutPanelRealTimeMods.Size = new System.Drawing.Size(405, 615);
            this.FlyoutPanelRealTimeMods.TabIndex = 1;
            // 
            // FlyoutPanelControlRealTimeMods
            // 
            this.FlyoutPanelControlRealTimeMods.Controls.Add(this.xtraScrollableControl3);
            this.FlyoutPanelControlRealTimeMods.Controls.Add(this.stackPanel4);
            this.FlyoutPanelControlRealTimeMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlyoutPanelControlRealTimeMods.FlyoutPanel = this.FlyoutPanelRealTimeMods;
            this.FlyoutPanelControlRealTimeMods.Location = new System.Drawing.Point(0, 0);
            this.FlyoutPanelControlRealTimeMods.Name = "FlyoutPanelControlRealTimeMods";
            this.FlyoutPanelControlRealTimeMods.Size = new System.Drawing.Size(405, 615);
            this.FlyoutPanelControlRealTimeMods.TabIndex = 0;
            // 
            // xtraScrollableControl3
            // 
            this.xtraScrollableControl3.Controls.Add(this.ImageCloseRealTimeModsInfo);
            this.xtraScrollableControl3.Controls.Add(this.LabelHeaderRealTimeModsDetails);
            this.xtraScrollableControl3.Controls.Add(this.LabelHeaderRealTimeModsGameVersion);
            this.xtraScrollableControl3.Controls.Add(this.LabelRealTimeModsDescription);
            this.xtraScrollableControl3.Controls.Add(this.LabelRealTimeModsGameVersion);
            this.xtraScrollableControl3.Controls.Add(this.labelControl44);
            this.xtraScrollableControl3.Controls.Add(this.labelControl48);
            this.xtraScrollableControl3.Controls.Add(this.LabelRealTimeModsGameTitle);
            this.xtraScrollableControl3.Controls.Add(this.labelControl52);
            this.xtraScrollableControl3.Controls.Add(this.LabelRealTimeModsName);
            this.xtraScrollableControl3.Controls.Add(this.labelControl58);
            this.xtraScrollableControl3.Controls.Add(this.LabelRealTimeModsCategory);
            this.xtraScrollableControl3.Controls.Add(this.labelControl62);
            this.xtraScrollableControl3.Controls.Add(this.LabelRealTimeModsGameMode);
            this.xtraScrollableControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl3.Location = new System.Drawing.Point(2, 2);
            this.xtraScrollableControl3.Name = "xtraScrollableControl3";
            this.xtraScrollableControl3.Size = new System.Drawing.Size(401, 570);
            this.xtraScrollableControl3.TabIndex = 0;
            // 
            // ImageCloseRealTimeModsInfo
            // 
            this.ImageCloseRealTimeModsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageCloseRealTimeModsInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageCloseRealTimeModsInfo.Location = new System.Drawing.Point(372, 10);
            this.ImageCloseRealTimeModsInfo.Name = "ImageCloseRealTimeModsInfo";
            this.ImageCloseRealTimeModsInfo.Size = new System.Drawing.Size(20, 20);
            this.ImageCloseRealTimeModsInfo.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageCloseRealTimeModsInfo.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageCloseRealTimeModsInfo.SvgImage")));
            this.ImageCloseRealTimeModsInfo.TabIndex = 1170;
            this.ImageCloseRealTimeModsInfo.Text = "svgImageBox1";
            this.ImageCloseRealTimeModsInfo.Click += new System.EventHandler(this.ImageCloseRealTimeModsInfo_Click);
            // 
            // LabelHeaderRealTimeModsDetails
            // 
            this.LabelHeaderRealTimeModsDetails.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderRealTimeModsDetails.Appearance.Options.UseFont = true;
            this.LabelHeaderRealTimeModsDetails.Location = new System.Drawing.Point(8, 10);
            this.LabelHeaderRealTimeModsDetails.Margin = new System.Windows.Forms.Padding(6, 3, 3, 5);
            this.LabelHeaderRealTimeModsDetails.Name = "LabelHeaderRealTimeModsDetails";
            this.LabelHeaderRealTimeModsDetails.Size = new System.Drawing.Size(88, 17);
            this.LabelHeaderRealTimeModsDetails.TabIndex = 1168;
            this.LabelHeaderRealTimeModsDetails.Text = "MOD DETAILS";
            // 
            // LabelHeaderRealTimeModsGameVersion
            // 
            this.LabelHeaderRealTimeModsGameVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderRealTimeModsGameVersion.Appearance.Options.UseFont = true;
            this.LabelHeaderRealTimeModsGameVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderRealTimeModsGameVersion.Location = new System.Drawing.Point(8, 86);
            this.LabelHeaderRealTimeModsGameVersion.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.LabelHeaderRealTimeModsGameVersion.Name = "LabelHeaderRealTimeModsGameVersion";
            this.LabelHeaderRealTimeModsGameVersion.Size = new System.Drawing.Size(78, 15);
            this.LabelHeaderRealTimeModsGameVersion.TabIndex = 26;
            this.LabelHeaderRealTimeModsGameVersion.Text = "Game Version";
            // 
            // LabelRealTimeModsDescription
            // 
            this.LabelRealTimeModsDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelRealTimeModsDescription.Appearance.Options.UseFont = true;
            this.LabelRealTimeModsDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelRealTimeModsDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelRealTimeModsDescription.Location = new System.Drawing.Point(7, 297);
            this.LabelRealTimeModsDescription.Margin = new System.Windows.Forms.Padding(6, 5, 2, 3);
            this.LabelRealTimeModsDescription.MaximumSize = new System.Drawing.Size(360, 0);
            this.LabelRealTimeModsDescription.MinimumSize = new System.Drawing.Size(360, 0);
            this.LabelRealTimeModsDescription.Name = "LabelRealTimeModsDescription";
            this.LabelRealTimeModsDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.LabelRealTimeModsDescription.Size = new System.Drawing.Size(360, 31);
            this.LabelRealTimeModsDescription.TabIndex = 12;
            this.LabelRealTimeModsDescription.Text = "...";
            // 
            // LabelRealTimeModsGameVersion
            // 
            this.LabelRealTimeModsGameVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelRealTimeModsGameVersion.Appearance.Options.UseFont = true;
            this.LabelRealTimeModsGameVersion.AutoEllipsis = true;
            this.LabelRealTimeModsGameVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelRealTimeModsGameVersion.Location = new System.Drawing.Point(8, 107);
            this.LabelRealTimeModsGameVersion.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.LabelRealTimeModsGameVersion.MaximumSize = new System.Drawing.Size(300, 15);
            this.LabelRealTimeModsGameVersion.Name = "LabelRealTimeModsGameVersion";
            this.LabelRealTimeModsGameVersion.Size = new System.Drawing.Size(9, 15);
            this.LabelRealTimeModsGameVersion.TabIndex = 2;
            this.LabelRealTimeModsGameVersion.Text = "...";
            // 
            // labelControl44
            // 
            this.labelControl44.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl44.Appearance.Options.UseFont = true;
            this.labelControl44.Location = new System.Drawing.Point(8, 276);
            this.labelControl44.Margin = new System.Windows.Forms.Padding(6, 5, 3, 0);
            this.labelControl44.Name = "labelControl44";
            this.labelControl44.Size = new System.Drawing.Size(80, 15);
            this.labelControl44.TabIndex = 1169;
            this.labelControl44.Text = "DESCRIPTION ";
            // 
            // labelControl48
            // 
            this.labelControl48.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl48.Appearance.Options.UseFont = true;
            this.labelControl48.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl48.Location = new System.Drawing.Point(8, 39);
            this.labelControl48.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl48.Name = "labelControl48";
            this.labelControl48.Size = new System.Drawing.Size(61, 15);
            this.labelControl48.TabIndex = 24;
            this.labelControl48.Text = "Game Title";
            // 
            // LabelRealTimeModsGameTitle
            // 
            this.LabelRealTimeModsGameTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelRealTimeModsGameTitle.Appearance.Options.UseFont = true;
            this.LabelRealTimeModsGameTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelRealTimeModsGameTitle.Location = new System.Drawing.Point(8, 60);
            this.LabelRealTimeModsGameTitle.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.LabelRealTimeModsGameTitle.Name = "LabelRealTimeModsGameTitle";
            this.LabelRealTimeModsGameTitle.Size = new System.Drawing.Size(9, 15);
            this.LabelRealTimeModsGameTitle.TabIndex = 23;
            this.LabelRealTimeModsGameTitle.Text = "...";
            // 
            // labelControl52
            // 
            this.labelControl52.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl52.Appearance.Options.UseFont = true;
            this.labelControl52.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl52.Location = new System.Drawing.Point(8, 133);
            this.labelControl52.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl52.Name = "labelControl52";
            this.labelControl52.Size = new System.Drawing.Size(61, 15);
            this.labelControl52.TabIndex = 20;
            this.labelControl52.Text = "Mod Name";
            // 
            // LabelRealTimeModsName
            // 
            this.LabelRealTimeModsName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelRealTimeModsName.Appearance.Options.UseFont = true;
            this.LabelRealTimeModsName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelRealTimeModsName.Location = new System.Drawing.Point(8, 154);
            this.LabelRealTimeModsName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.LabelRealTimeModsName.Name = "LabelRealTimeModsName";
            this.LabelRealTimeModsName.Size = new System.Drawing.Size(9, 15);
            this.LabelRealTimeModsName.TabIndex = 21;
            this.LabelRealTimeModsName.Text = "...";
            // 
            // labelControl58
            // 
            this.labelControl58.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl58.Appearance.Options.UseFont = true;
            this.labelControl58.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl58.Location = new System.Drawing.Point(8, 180);
            this.labelControl58.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl58.Name = "labelControl58";
            this.labelControl58.Size = new System.Drawing.Size(50, 15);
            this.labelControl58.TabIndex = 16;
            this.labelControl58.Text = "Category";
            // 
            // LabelRealTimeModsCategory
            // 
            this.LabelRealTimeModsCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelRealTimeModsCategory.Appearance.Options.UseFont = true;
            this.LabelRealTimeModsCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelRealTimeModsCategory.Location = new System.Drawing.Point(8, 201);
            this.LabelRealTimeModsCategory.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.LabelRealTimeModsCategory.Name = "LabelRealTimeModsCategory";
            this.LabelRealTimeModsCategory.Size = new System.Drawing.Size(9, 15);
            this.LabelRealTimeModsCategory.TabIndex = 17;
            this.LabelRealTimeModsCategory.Text = "...";
            // 
            // labelControl62
            // 
            this.labelControl62.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl62.Appearance.Options.UseFont = true;
            this.labelControl62.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl62.Location = new System.Drawing.Point(8, 227);
            this.labelControl62.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl62.Name = "labelControl62";
            this.labelControl62.Size = new System.Drawing.Size(68, 15);
            this.labelControl62.TabIndex = 3;
            this.labelControl62.Text = "Game Mode";
            // 
            // LabelRealTimeModsGameMode
            // 
            this.LabelRealTimeModsGameMode.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelRealTimeModsGameMode.Appearance.Options.UseFont = true;
            this.LabelRealTimeModsGameMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelRealTimeModsGameMode.Location = new System.Drawing.Point(8, 248);
            this.LabelRealTimeModsGameMode.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.LabelRealTimeModsGameMode.Name = "LabelRealTimeModsGameMode";
            this.LabelRealTimeModsGameMode.Size = new System.Drawing.Size(9, 15);
            this.LabelRealTimeModsGameMode.TabIndex = 4;
            this.LabelRealTimeModsGameMode.Text = "...";
            // 
            // stackPanel4
            // 
            this.stackPanel4.Controls.Add(this.ButtonRealTimeModsSetValue);
            this.stackPanel4.Controls.Add(this.ButtonRealTimeModsEnable);
            this.stackPanel4.Controls.Add(this.ButtonRealTimeModsDisable);
            this.stackPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel4.Location = new System.Drawing.Point(2, 572);
            this.stackPanel4.Name = "stackPanel4";
            this.stackPanel4.Size = new System.Drawing.Size(401, 41);
            this.stackPanel4.TabIndex = 1174;
            // 
            // ButtonRealTimeModsSetValue
            // 
            this.ButtonRealTimeModsSetValue.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRealTimeModsSetValue.Appearance.Options.UseFont = true;
            this.ButtonRealTimeModsSetValue.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonRealTimeModsSetValue.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonRealTimeModsSetValue.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonRealTimeModsSetValue.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonRealTimeModsSetValue.ImageOptions.SvgImage")));
            this.ButtonRealTimeModsSetValue.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.ButtonRealTimeModsSetValue.Location = new System.Drawing.Point(8, 8);
            this.ButtonRealTimeModsSetValue.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonRealTimeModsSetValue.Name = "ButtonRealTimeModsSetValue";
            this.ButtonRealTimeModsSetValue.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRealTimeModsSetValue.Size = new System.Drawing.Size(86, 25);
            this.ButtonRealTimeModsSetValue.TabIndex = 1176;
            this.ButtonRealTimeModsSetValue.Text = "Set Value";
            // 
            // ButtonRealTimeModsEnable
            // 
            this.ButtonRealTimeModsEnable.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRealTimeModsEnable.Appearance.Options.UseFont = true;
            this.ButtonRealTimeModsEnable.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonRealTimeModsEnable.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonRealTimeModsEnable.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonRealTimeModsEnable.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonRealTimeModsEnable.ImageOptions.SvgImage")));
            this.ButtonRealTimeModsEnable.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonRealTimeModsEnable.Location = new System.Drawing.Point(105, 8);
            this.ButtonRealTimeModsEnable.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonRealTimeModsEnable.Name = "ButtonRealTimeModsEnable";
            this.ButtonRealTimeModsEnable.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRealTimeModsEnable.Size = new System.Drawing.Size(78, 25);
            this.ButtonRealTimeModsEnable.TabIndex = 1177;
            this.ButtonRealTimeModsEnable.Text = "Enable";
            this.ButtonRealTimeModsEnable.Visible = false;
            // 
            // ButtonRealTimeModsDisable
            // 
            this.ButtonRealTimeModsDisable.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRealTimeModsDisable.Appearance.Options.UseFont = true;
            this.ButtonRealTimeModsDisable.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonRealTimeModsDisable.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonRealTimeModsDisable.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonRealTimeModsDisable.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonRealTimeModsDisable.ImageOptions.SvgImage")));
            this.ButtonRealTimeModsDisable.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.ButtonRealTimeModsDisable.Location = new System.Drawing.Point(189, 8);
            this.ButtonRealTimeModsDisable.Name = "ButtonRealTimeModsDisable";
            this.ButtonRealTimeModsDisable.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRealTimeModsDisable.Size = new System.Drawing.Size(80, 25);
            this.ButtonRealTimeModsDisable.TabIndex = 1178;
            this.ButtonRealTimeModsDisable.Text = "Disable";
            this.ButtonRealTimeModsDisable.Visible = false;
            // 
            // PageResources
            // 
            this.PageResources.Appearance.Options.UseFont = true;
            this.PageResources.Controls.Add(this.PanelResourcesResources);
            this.PageResources.Controls.Add(this.panel16);
            this.PageResources.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PageResources.Name = "PageResources";
            this.PageResources.Size = new System.Drawing.Size(1281, 712);
            // 
            // PanelResourcesResources
            // 
            this.PanelResourcesResources.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelResourcesResources.Controls.Add(this.TileControlResources);
            this.PanelResourcesResources.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelResourcesResources.Location = new System.Drawing.Point(0, 0);
            this.PanelResourcesResources.Margin = new System.Windows.Forms.Padding(0);
            this.PanelResourcesResources.Name = "PanelResourcesResources";
            this.PanelResourcesResources.Size = new System.Drawing.Size(1281, 70);
            this.PanelResourcesResources.TabIndex = 1217;
            // 
            // TileControlResources
            // 
            this.TileControlResources.AllowDisabledStateIndication = false;
            this.TileControlResources.AllowDrag = false;
            this.TileControlResources.AllowDragTilesBetweenGroups = false;
            this.TileControlResources.AllowGlyphSkinning = true;
            this.TileControlResources.AllowItemHover = true;
            this.TileControlResources.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TileControlResources.Groups.Add(this.TileGroupResources);
            this.TileControlResources.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TileControlResources.IndentBetweenItems = 2;
            this.TileControlResources.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade;
            this.TileControlResources.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileControlResources.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.TileControlResources.ItemPadding = new System.Windows.Forms.Padding(0);
            this.TileControlResources.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.TileControlResources.Location = new System.Drawing.Point(6, 5);
            this.TileControlResources.MaxId = 6;
            this.TileControlResources.Name = "TileControlResources";
            this.TileControlResources.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TileControlResources.Padding = new System.Windows.Forms.Padding(0);
            this.TileControlResources.Size = new System.Drawing.Size(332, 67);
            this.TileControlResources.TabIndex = 0;
            this.TileControlResources.Text = "TileControlModsActions";
            // 
            // TileGroupResources
            // 
            this.TileGroupResources.Items.Add(this.TileItemResourcesShowFavorites);
            this.TileGroupResources.Items.Add(this.TileItemResourcesSortBy);
            this.TileGroupResources.Name = "TileGroupResources";
            this.TileGroupResources.Text = "Resources Actions";
            // 
            // TileItemResourcesShowFavorites
            // 
            this.TileItemResourcesShowFavorites.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemResourcesShowFavorites.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileItemResourcesShowFavorites.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemResourcesShowFavorites.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemResourcesShowFavorites.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemResourcesShowFavorites.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemResourcesShowFavorites.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemResourcesShowFavorites.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemResourcesShowFavorites.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemResourcesShowFavorites.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement33.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement33.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement33.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement33.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement33.ImageOptions.ImageToTextIndent = 2;
            tileItemElement33.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage11")));
            tileItemElement33.Text = "Show Favorites";
            tileItemElement33.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemResourcesShowFavorites.Elements.Add(tileItemElement33);
            this.TileItemResourcesShowFavorites.Id = 2;
            this.TileItemResourcesShowFavorites.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemResourcesShowFavorites.Name = "TileItemResourcesShowFavorites";
            this.TileItemResourcesShowFavorites.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemResourcesShowFavorites.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemResourcesShowFavorites_ItemClick);
            // 
            // TileItemResourcesSortBy
            // 
            this.TileItemResourcesSortBy.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemResourcesSortBy.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileItemResourcesSortBy.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemResourcesSortBy.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemResourcesSortBy.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemResourcesSortBy.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemResourcesSortBy.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemResourcesSortBy.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemResourcesSortBy.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemResourcesSortBy.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement34.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image11")));
            tileItemElement34.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement34.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement34.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement34.ImageOptions.ImageToTextIndent = 2;
            tileItemElement34.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement34.Text = "Sort By";
            tileItemElement34.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemResourcesSortBy.Elements.Add(tileItemElement34);
            this.TileItemResourcesSortBy.Id = 1;
            this.TileItemResourcesSortBy.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemResourcesSortBy.Name = "TileItemResourcesSortBy";
            this.TileItemResourcesSortBy.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemResourcesSortBy.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemResourcesSortBy_ItemClick);
            // 
            // panel16
            // 
            this.panel16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel16.BackColor = System.Drawing.Color.Transparent;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.GridControlResources);
            this.panel16.Controls.Add(this.PanelResourcesFilters);
            this.panel16.Location = new System.Drawing.Point(14, 84);
            this.panel16.Margin = new System.Windows.Forms.Padding(14);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1253, 614);
            this.panel16.TabIndex = 1216;
            // 
            // GridControlResources
            // 
            this.GridControlResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlResources.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlResources.Location = new System.Drawing.Point(10, 70);
            this.GridControlResources.MainView = this.GridViewResources;
            this.GridControlResources.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GridControlResources.Name = "GridControlResources";
            this.GridControlResources.Size = new System.Drawing.Size(1231, 530);
            this.GridControlResources.TabIndex = 5;
            this.GridControlResources.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewResources});
            // 
            // GridViewResources
            // 
            this.GridViewResources.ActiveFilterEnabled = false;
            this.GridViewResources.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewResources.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewResources.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewResources.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewResources.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewResources.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewResources.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.GridViewResources.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewResources.Appearance.Row.Options.UseBackColor = true;
            this.GridViewResources.Appearance.Row.Options.UseFont = true;
            this.GridViewResources.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewResources.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewResources.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewResources.AppearancePrint.Row.Options.UseBackColor = true;
            this.GridViewResources.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewResources.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewResources.GridControl = this.GridControlResources;
            this.GridViewResources.GroupRowHeight = 20;
            this.GridViewResources.Name = "GridViewResources";
            this.GridViewResources.OptionsBehavior.Editable = false;
            this.GridViewResources.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.GridViewResources.OptionsBehavior.ReadOnly = true;
            this.GridViewResources.OptionsCustomization.AllowFilter = false;
            this.GridViewResources.OptionsFilter.AllowFilterEditor = false;
            this.GridViewResources.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewResources.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewResources.OptionsView.ShowColumnHeaders = false;
            this.GridViewResources.OptionsView.ShowGroupPanel = false;
            this.GridViewResources.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewResources.OptionsView.ShowIndicator = false;
            this.GridViewResources.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewResources.RowHeight = 24;
            this.GridViewResources.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GridViewResources.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewResources_RowClick);
            this.GridViewResources.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GridViewResources_CustomDrawCell);
            // 
            // PanelResourcesFilters
            // 
            this.PanelResourcesFilters.BackColor = System.Drawing.Color.Transparent;
            this.PanelResourcesFilters.Controls.Add(this.ComboBoxResourcesFilterModType);
            this.PanelResourcesFilters.Controls.Add(this.separatorControl11);
            this.PanelResourcesFilters.Controls.Add(this.ComboBoxResourcesFilterCategory);
            this.PanelResourcesFilters.Controls.Add(this.LabelResourcesFilterCategory);
            this.PanelResourcesFilters.Controls.Add(this.ComboBoxResourcesFilterStatus);
            this.PanelResourcesFilters.Controls.Add(this.LabelResourcesFilterStatus);
            this.PanelResourcesFilters.Controls.Add(this.ComboBoxResourcesFilterCreator);
            this.PanelResourcesFilters.Controls.Add(this.LabelResourcesFilterCreator);
            this.PanelResourcesFilters.Controls.Add(this.ComboBoxResourcesFilterVersion);
            this.PanelResourcesFilters.Controls.Add(this.LabelResourcesFilterVersion);
            this.PanelResourcesFilters.Controls.Add(this.TextBoxResourcesFilterName);
            this.PanelResourcesFilters.Controls.Add(this.ComboBoxResourcesFilterSystemType);
            this.PanelResourcesFilters.Controls.Add(this.LabelResourcesFilterName);
            this.PanelResourcesFilters.Controls.Add(this.LabelResourcesFilterSystemType);
            this.PanelResourcesFilters.Controls.Add(this.LabelResourcesFilterModType);
            this.PanelResourcesFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelResourcesFilters.Location = new System.Drawing.Point(0, 0);
            this.PanelResourcesFilters.Margin = new System.Windows.Forms.Padding(0, 4, 0, 50);
            this.PanelResourcesFilters.Name = "PanelResourcesFilters";
            this.PanelResourcesFilters.Size = new System.Drawing.Size(1251, 70);
            this.PanelResourcesFilters.TabIndex = 12;
            // 
            // ComboBoxResourcesFilterModType
            // 
            this.ComboBoxResourcesFilterModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxResourcesFilterModType.Location = new System.Drawing.Point(829, 40);
            this.ComboBoxResourcesFilterModType.MenuManager = this.MainMenu;
            this.ComboBoxResourcesFilterModType.Name = "ComboBoxResourcesFilterModType";
            this.ComboBoxResourcesFilterModType.Properties.AllowFocused = false;
            this.ComboBoxResourcesFilterModType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxResourcesFilterModType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxResourcesFilterModType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxResourcesFilterModType.Properties.AutoComplete = false;
            this.ComboBoxResourcesFilterModType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxResourcesFilterModType.Properties.DropDownRows = 12;
            this.ComboBoxResourcesFilterModType.Properties.NullValuePrompt = "Select...";
            this.ComboBoxResourcesFilterModType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxResourcesFilterModType.Size = new System.Drawing.Size(92, 22);
            this.ComboBoxResourcesFilterModType.TabIndex = 1173;
            this.ComboBoxResourcesFilterModType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResourcesFilterModType_SelectedIndexChanged);
            // 
            // separatorControl11
            // 
            this.separatorControl11.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl11.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl11.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separatorControl11.LineThickness = 3;
            this.separatorControl11.Location = new System.Drawing.Point(0, 67);
            this.separatorControl11.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl11.Name = "separatorControl11";
            this.separatorControl11.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.separatorControl11.Size = new System.Drawing.Size(1251, 3);
            this.separatorControl11.TabIndex = 1172;
            // 
            // ComboBoxResourcesFilterCategory
            // 
            this.ComboBoxResourcesFilterCategory.Location = new System.Drawing.Point(17, 40);
            this.ComboBoxResourcesFilterCategory.MenuManager = this.MainMenu;
            this.ComboBoxResourcesFilterCategory.Name = "ComboBoxResourcesFilterCategory";
            this.ComboBoxResourcesFilterCategory.Properties.AllowFocused = false;
            this.ComboBoxResourcesFilterCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxResourcesFilterCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxResourcesFilterCategory.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxResourcesFilterCategory.Properties.AutoComplete = false;
            this.ComboBoxResourcesFilterCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxResourcesFilterCategory.Properties.DropDownRows = 15;
            this.ComboBoxResourcesFilterCategory.Properties.NullValuePrompt = "Select...";
            this.ComboBoxResourcesFilterCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxResourcesFilterCategory.Size = new System.Drawing.Size(220, 22);
            this.ComboBoxResourcesFilterCategory.TabIndex = 1170;
            this.ComboBoxResourcesFilterCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResourcesFilterCategory_SelectedIndexChanged);
            // 
            // LabelResourcesFilterCategory
            // 
            this.LabelResourcesFilterCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelResourcesFilterCategory.Appearance.Options.UseFont = true;
            this.LabelResourcesFilterCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelResourcesFilterCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelResourcesFilterCategory.Location = new System.Drawing.Point(15, 20);
            this.LabelResourcesFilterCategory.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelResourcesFilterCategory.Name = "LabelResourcesFilterCategory";
            this.LabelResourcesFilterCategory.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelResourcesFilterCategory.Size = new System.Drawing.Size(56, 15);
            this.LabelResourcesFilterCategory.TabIndex = 1171;
            this.LabelResourcesFilterCategory.Text = "Category";
            // 
            // ComboBoxResourcesFilterStatus
            // 
            this.ComboBoxResourcesFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxResourcesFilterStatus.Location = new System.Drawing.Point(1130, 40);
            this.ComboBoxResourcesFilterStatus.MenuManager = this.MainMenu;
            this.ComboBoxResourcesFilterStatus.Name = "ComboBoxResourcesFilterStatus";
            this.ComboBoxResourcesFilterStatus.Properties.AllowFocused = false;
            this.ComboBoxResourcesFilterStatus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxResourcesFilterStatus.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ComboBoxResourcesFilterStatus.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxResourcesFilterStatus.Properties.AutoComplete = false;
            this.ComboBoxResourcesFilterStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxResourcesFilterStatus.Properties.Items.AddRange(new object[] {
            "<All>",
            "Downloaded",
            "Not Installed",
            "Installed"});
            this.ComboBoxResourcesFilterStatus.Properties.NullValuePrompt = "Select...";
            this.ComboBoxResourcesFilterStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxResourcesFilterStatus.Size = new System.Drawing.Size(102, 22);
            this.ComboBoxResourcesFilterStatus.TabIndex = 1168;
            this.ComboBoxResourcesFilterStatus.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResourcesFilterStatus_SelectedIndexChanged);
            // 
            // LabelResourcesFilterStatus
            // 
            this.LabelResourcesFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelResourcesFilterStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelResourcesFilterStatus.Appearance.Options.UseFont = true;
            this.LabelResourcesFilterStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelResourcesFilterStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelResourcesFilterStatus.Location = new System.Drawing.Point(1127, 20);
            this.LabelResourcesFilterStatus.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelResourcesFilterStatus.Name = "LabelResourcesFilterStatus";
            this.LabelResourcesFilterStatus.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelResourcesFilterStatus.Size = new System.Drawing.Size(41, 15);
            this.LabelResourcesFilterStatus.TabIndex = 1169;
            this.LabelResourcesFilterStatus.Text = "Status";
            // 
            // ComboBoxResourcesFilterCreator
            // 
            this.ComboBoxResourcesFilterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxResourcesFilterCreator.Location = new System.Drawing.Point(997, 40);
            this.ComboBoxResourcesFilterCreator.MenuManager = this.MainMenu;
            this.ComboBoxResourcesFilterCreator.Name = "ComboBoxResourcesFilterCreator";
            this.ComboBoxResourcesFilterCreator.Properties.AllowFocused = false;
            this.ComboBoxResourcesFilterCreator.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxResourcesFilterCreator.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxResourcesFilterCreator.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxResourcesFilterCreator.Properties.AutoComplete = false;
            this.ComboBoxResourcesFilterCreator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxResourcesFilterCreator.Properties.DropDownRows = 12;
            this.ComboBoxResourcesFilterCreator.Properties.NullValuePrompt = "Select...";
            this.ComboBoxResourcesFilterCreator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxResourcesFilterCreator.Size = new System.Drawing.Size(127, 22);
            this.ComboBoxResourcesFilterCreator.TabIndex = 1166;
            this.ComboBoxResourcesFilterCreator.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResourcesFilterCreator_SelectedIndexChanged);
            // 
            // LabelResourcesFilterCreator
            // 
            this.LabelResourcesFilterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelResourcesFilterCreator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelResourcesFilterCreator.Appearance.Options.UseFont = true;
            this.LabelResourcesFilterCreator.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelResourcesFilterCreator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelResourcesFilterCreator.Location = new System.Drawing.Point(994, 20);
            this.LabelResourcesFilterCreator.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelResourcesFilterCreator.Name = "LabelResourcesFilterCreator";
            this.LabelResourcesFilterCreator.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelResourcesFilterCreator.Size = new System.Drawing.Size(48, 15);
            this.LabelResourcesFilterCreator.TabIndex = 1167;
            this.LabelResourcesFilterCreator.Text = "Creator";
            // 
            // ComboBoxResourcesFilterVersion
            // 
            this.ComboBoxResourcesFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxResourcesFilterVersion.Location = new System.Drawing.Point(927, 40);
            this.ComboBoxResourcesFilterVersion.MenuManager = this.MainMenu;
            this.ComboBoxResourcesFilterVersion.Name = "ComboBoxResourcesFilterVersion";
            this.ComboBoxResourcesFilterVersion.Properties.AllowFocused = false;
            this.ComboBoxResourcesFilterVersion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxResourcesFilterVersion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxResourcesFilterVersion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxResourcesFilterVersion.Properties.AutoComplete = false;
            this.ComboBoxResourcesFilterVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxResourcesFilterVersion.Properties.DropDownRows = 12;
            this.ComboBoxResourcesFilterVersion.Properties.NullValuePrompt = "Select...";
            this.ComboBoxResourcesFilterVersion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxResourcesFilterVersion.Size = new System.Drawing.Size(64, 22);
            this.ComboBoxResourcesFilterVersion.TabIndex = 1164;
            this.ComboBoxResourcesFilterVersion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResourcesFilterVersion_SelectedIndexChanged);
            // 
            // LabelResourcesFilterVersion
            // 
            this.LabelResourcesFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelResourcesFilterVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelResourcesFilterVersion.Appearance.Options.UseFont = true;
            this.LabelResourcesFilterVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelResourcesFilterVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelResourcesFilterVersion.Location = new System.Drawing.Point(924, 20);
            this.LabelResourcesFilterVersion.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelResourcesFilterVersion.Name = "LabelResourcesFilterVersion";
            this.LabelResourcesFilterVersion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelResourcesFilterVersion.Size = new System.Drawing.Size(48, 15);
            this.LabelResourcesFilterVersion.TabIndex = 1165;
            this.LabelResourcesFilterVersion.Text = "Version";
            // 
            // TextBoxResourcesFilterName
            // 
            this.TextBoxResourcesFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxResourcesFilterName.Location = new System.Drawing.Point(243, 40);
            this.TextBoxResourcesFilterName.MenuManager = this.MainMenu;
            this.TextBoxResourcesFilterName.Name = "TextBoxResourcesFilterName";
            this.TextBoxResourcesFilterName.Properties.AllowFocused = false;
            this.TextBoxResourcesFilterName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TextBoxResourcesFilterName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxResourcesFilterName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxResourcesFilterName.Properties.NullValuePrompt = "Search...";
            this.TextBoxResourcesFilterName.Size = new System.Drawing.Size(493, 22);
            this.TextBoxResourcesFilterName.TabIndex = 1;
            this.TextBoxResourcesFilterName.TextChanged += new System.EventHandler(this.TextBoxResourcesFilterName_TextChanged);
            // 
            // ComboBoxResourcesFilterSystemType
            // 
            this.ComboBoxResourcesFilterSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxResourcesFilterSystemType.Location = new System.Drawing.Point(742, 40);
            this.ComboBoxResourcesFilterSystemType.MenuManager = this.MainMenu;
            this.ComboBoxResourcesFilterSystemType.Name = "ComboBoxResourcesFilterSystemType";
            this.ComboBoxResourcesFilterSystemType.Properties.AllowFocused = false;
            this.ComboBoxResourcesFilterSystemType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxResourcesFilterSystemType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxResourcesFilterSystemType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxResourcesFilterSystemType.Properties.AutoComplete = false;
            this.ComboBoxResourcesFilterSystemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxResourcesFilterSystemType.Properties.DropDownRows = 12;
            this.ComboBoxResourcesFilterSystemType.Properties.Items.AddRange(new object[] {
            "<Any>"});
            this.ComboBoxResourcesFilterSystemType.Properties.NullValuePrompt = "Select...";
            this.ComboBoxResourcesFilterSystemType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxResourcesFilterSystemType.Size = new System.Drawing.Size(81, 22);
            this.ComboBoxResourcesFilterSystemType.TabIndex = 2;
            this.ComboBoxResourcesFilterSystemType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxResourcesFilterSystemType_SelectedIndexChanged);
            // 
            // LabelResourcesFilterName
            // 
            this.LabelResourcesFilterName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelResourcesFilterName.Appearance.Options.UseFont = true;
            this.LabelResourcesFilterName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelResourcesFilterName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelResourcesFilterName.Location = new System.Drawing.Point(240, 20);
            this.LabelResourcesFilterName.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelResourcesFilterName.Name = "LabelResourcesFilterName";
            this.LabelResourcesFilterName.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelResourcesFilterName.Size = new System.Drawing.Size(39, 15);
            this.LabelResourcesFilterName.TabIndex = 1157;
            this.LabelResourcesFilterName.Text = "Name";
            // 
            // LabelResourcesFilterSystemType
            // 
            this.LabelResourcesFilterSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelResourcesFilterSystemType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelResourcesFilterSystemType.Appearance.Options.UseFont = true;
            this.LabelResourcesFilterSystemType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelResourcesFilterSystemType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelResourcesFilterSystemType.Location = new System.Drawing.Point(739, 20);
            this.LabelResourcesFilterSystemType.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelResourcesFilterSystemType.Name = "LabelResourcesFilterSystemType";
            this.LabelResourcesFilterSystemType.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelResourcesFilterSystemType.Size = new System.Drawing.Size(77, 15);
            this.LabelResourcesFilterSystemType.TabIndex = 1156;
            this.LabelResourcesFilterSystemType.Text = "System Type";
            // 
            // LabelResourcesFilterModType
            // 
            this.LabelResourcesFilterModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelResourcesFilterModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelResourcesFilterModType.Appearance.Options.UseFont = true;
            this.LabelResourcesFilterModType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelResourcesFilterModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelResourcesFilterModType.Location = new System.Drawing.Point(826, 20);
            this.LabelResourcesFilterModType.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelResourcesFilterModType.Name = "LabelResourcesFilterModType";
            this.LabelResourcesFilterModType.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelResourcesFilterModType.Size = new System.Drawing.Size(61, 15);
            this.LabelResourcesFilterModType.TabIndex = 1122;
            this.LabelResourcesFilterModType.Text = "Mod Type";
            // 
            // PageHomebrew
            // 
            this.PageHomebrew.Appearance.Options.UseFont = true;
            this.PageHomebrew.Controls.Add(this.PanelHomebrewActions);
            this.PageHomebrew.Controls.Add(this.PanelHomebrew);
            this.PageHomebrew.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PageHomebrew.Name = "PageHomebrew";
            this.PageHomebrew.Size = new System.Drawing.Size(1281, 712);
            // 
            // PanelHomebrewActions
            // 
            this.PanelHomebrewActions.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHomebrewActions.Controls.Add(this.TileControlHomebrew);
            this.PanelHomebrewActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHomebrewActions.Location = new System.Drawing.Point(0, 0);
            this.PanelHomebrewActions.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHomebrewActions.Name = "PanelHomebrewActions";
            this.PanelHomebrewActions.Size = new System.Drawing.Size(1281, 70);
            this.PanelHomebrewActions.TabIndex = 1216;
            // 
            // TileControlHomebrew
            // 
            this.TileControlHomebrew.AllowDisabledStateIndication = false;
            this.TileControlHomebrew.AllowDrag = false;
            this.TileControlHomebrew.AllowDragTilesBetweenGroups = false;
            this.TileControlHomebrew.AllowGlyphSkinning = true;
            this.TileControlHomebrew.AllowItemHover = true;
            this.TileControlHomebrew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TileControlHomebrew.Groups.Add(this.TileGroupHomebrew);
            this.TileControlHomebrew.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TileControlHomebrew.IndentBetweenItems = 2;
            this.TileControlHomebrew.ItemContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.Fade;
            this.TileControlHomebrew.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileControlHomebrew.ItemImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            this.TileControlHomebrew.ItemPadding = new System.Windows.Forms.Padding(0);
            this.TileControlHomebrew.ItemTextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.TileControlHomebrew.Location = new System.Drawing.Point(6, 5);
            this.TileControlHomebrew.MaxId = 7;
            this.TileControlHomebrew.Name = "TileControlHomebrew";
            this.TileControlHomebrew.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TileControlHomebrew.Padding = new System.Windows.Forms.Padding(0);
            this.TileControlHomebrew.Size = new System.Drawing.Size(332, 67);
            this.TileControlHomebrew.TabIndex = 0;
            this.TileControlHomebrew.Text = "TileControlModsActions";
            // 
            // TileGroupHomebrew
            // 
            this.TileGroupHomebrew.Items.Add(this.TileItemHomebrewShowFavorites);
            this.TileGroupHomebrew.Items.Add(this.TileItemHomebrewSortBy);
            this.TileGroupHomebrew.Name = "TileGroupHomebrew";
            this.TileGroupHomebrew.Text = "Homebrew Actions";
            // 
            // TileItemHomebrewShowFavorites
            // 
            this.TileItemHomebrewShowFavorites.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemHomebrewShowFavorites.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemHomebrewShowFavorites.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemHomebrewShowFavorites.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemHomebrewShowFavorites.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemHomebrewShowFavorites.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemHomebrewShowFavorites.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemHomebrewShowFavorites.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement35.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement35.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement35.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement35.ImageOptions.ImageToTextIndent = 2;
            tileItemElement35.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage12")));
            tileItemElement35.Text = "Show Favorites";
            tileItemElement35.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemHomebrewShowFavorites.Elements.Add(tileItemElement35);
            this.TileItemHomebrewShowFavorites.Id = 6;
            this.TileItemHomebrewShowFavorites.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemHomebrewShowFavorites.Name = "TileItemHomebrewShowFavorites";
            this.TileItemHomebrewShowFavorites.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemHomebrewShowFavorites.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemHomebrewShowFavorites_ItemClick);
            // 
            // TileItemHomebrewSortBy
            // 
            this.TileItemHomebrewSortBy.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.TileItemHomebrewSortBy.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TileItemHomebrewSortBy.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.TileItemHomebrewSortBy.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.TileItemHomebrewSortBy.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.TileItemHomebrewSortBy.AppearanceItem.Normal.Options.UseBackColor = true;
            this.TileItemHomebrewSortBy.AppearanceItem.Normal.Options.UseFont = true;
            this.TileItemHomebrewSortBy.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.TileItemHomebrewSortBy.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TileItemHomebrewSortBy.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement36.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image12")));
            tileItemElement36.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement36.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement36.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement36.ImageOptions.ImageToTextIndent = 2;
            tileItemElement36.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            tileItemElement36.Text = "Sort By";
            tileItemElement36.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.TileItemHomebrewSortBy.Elements.Add(tileItemElement36);
            this.TileItemHomebrewSortBy.Id = 1;
            this.TileItemHomebrewSortBy.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.TileItemHomebrewSortBy.Name = "TileItemHomebrewSortBy";
            this.TileItemHomebrewSortBy.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            this.TileItemHomebrewSortBy.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TileItemHomebrewSortBy_ItemClick);
            // 
            // PanelHomebrew
            // 
            this.PanelHomebrew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelHomebrew.BackColor = System.Drawing.Color.Transparent;
            this.PanelHomebrew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelHomebrew.Controls.Add(this.GridControlHomebrew);
            this.PanelHomebrew.Controls.Add(this.PanelHomebrewFilters);
            this.PanelHomebrew.Location = new System.Drawing.Point(14, 84);
            this.PanelHomebrew.Margin = new System.Windows.Forms.Padding(14);
            this.PanelHomebrew.Name = "PanelHomebrew";
            this.PanelHomebrew.Size = new System.Drawing.Size(1253, 614);
            this.PanelHomebrew.TabIndex = 1215;
            // 
            // GridControlHomebrew
            // 
            this.GridControlHomebrew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlHomebrew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlHomebrew.Location = new System.Drawing.Point(10, 70);
            this.GridControlHomebrew.MainView = this.GridViewHomebrew;
            this.GridControlHomebrew.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GridControlHomebrew.Name = "GridControlHomebrew";
            this.GridControlHomebrew.Size = new System.Drawing.Size(1231, 530);
            this.GridControlHomebrew.TabIndex = 5;
            this.GridControlHomebrew.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewHomebrew});
            // 
            // GridViewHomebrew
            // 
            this.GridViewHomebrew.ActiveFilterEnabled = false;
            this.GridViewHomebrew.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewHomebrew.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewHomebrew.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewHomebrew.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewHomebrew.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewHomebrew.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewHomebrew.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.GridViewHomebrew.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewHomebrew.Appearance.Row.Options.UseBackColor = true;
            this.GridViewHomebrew.Appearance.Row.Options.UseFont = true;
            this.GridViewHomebrew.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewHomebrew.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewHomebrew.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewHomebrew.AppearancePrint.Row.Options.UseBackColor = true;
            this.GridViewHomebrew.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewHomebrew.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewHomebrew.GridControl = this.GridControlHomebrew;
            this.GridViewHomebrew.GroupRowHeight = 20;
            this.GridViewHomebrew.Name = "GridViewHomebrew";
            this.GridViewHomebrew.OptionsBehavior.Editable = false;
            this.GridViewHomebrew.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.GridViewHomebrew.OptionsBehavior.ReadOnly = true;
            this.GridViewHomebrew.OptionsCustomization.AllowFilter = false;
            this.GridViewHomebrew.OptionsFilter.AllowFilterEditor = false;
            this.GridViewHomebrew.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewHomebrew.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewHomebrew.OptionsView.ShowColumnHeaders = false;
            this.GridViewHomebrew.OptionsView.ShowGroupPanel = false;
            this.GridViewHomebrew.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewHomebrew.OptionsView.ShowIndicator = false;
            this.GridViewHomebrew.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewHomebrew.RowHeight = 24;
            this.GridViewHomebrew.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GridViewHomebrew.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewHomebrew_RowClick);
            this.GridViewHomebrew.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.GridViewHomebrew_CustomDrawCell);
            // 
            // PanelHomebrewFilters
            // 
            this.PanelHomebrewFilters.BackColor = System.Drawing.Color.Transparent;
            this.PanelHomebrewFilters.Controls.Add(this.SeparatorHomebrew);
            this.PanelHomebrewFilters.Controls.Add(this.ComboBoxHomebrewFilterCategory);
            this.PanelHomebrewFilters.Controls.Add(this.LabelHomebrewFilterCategory);
            this.PanelHomebrewFilters.Controls.Add(this.ComboBoxHomebrewFilterStatus);
            this.PanelHomebrewFilters.Controls.Add(this.LabelHomebrewFilterStatus);
            this.PanelHomebrewFilters.Controls.Add(this.ComboBoxHomebrewFilterCreator);
            this.PanelHomebrewFilters.Controls.Add(this.LabelHomebrewFilterCreator);
            this.PanelHomebrewFilters.Controls.Add(this.ComboBoxHomebrewFilterVersion);
            this.PanelHomebrewFilters.Controls.Add(this.LabelHomebrewFilterVersion);
            this.PanelHomebrewFilters.Controls.Add(this.TextBoxHomebrewFilterName);
            this.PanelHomebrewFilters.Controls.Add(this.ComboBoxHomebrewFilterSystemType);
            this.PanelHomebrewFilters.Controls.Add(this.LabelHomebrewFilterName);
            this.PanelHomebrewFilters.Controls.Add(this.LabelHomebrewFilterSystemType);
            this.PanelHomebrewFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHomebrewFilters.Location = new System.Drawing.Point(0, 0);
            this.PanelHomebrewFilters.Margin = new System.Windows.Forms.Padding(0, 4, 0, 50);
            this.PanelHomebrewFilters.Name = "PanelHomebrewFilters";
            this.PanelHomebrewFilters.Size = new System.Drawing.Size(1251, 70);
            this.PanelHomebrewFilters.TabIndex = 12;
            // 
            // SeparatorHomebrew
            // 
            this.SeparatorHomebrew.BackColor = System.Drawing.Color.Transparent;
            this.SeparatorHomebrew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SeparatorHomebrew.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.SeparatorHomebrew.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SeparatorHomebrew.LineThickness = 3;
            this.SeparatorHomebrew.Location = new System.Drawing.Point(0, 67);
            this.SeparatorHomebrew.Margin = new System.Windows.Forms.Padding(0);
            this.SeparatorHomebrew.Name = "SeparatorHomebrew";
            this.SeparatorHomebrew.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.SeparatorHomebrew.Size = new System.Drawing.Size(1251, 3);
            this.SeparatorHomebrew.TabIndex = 1172;
            // 
            // ComboBoxHomebrewFilterCategory
            // 
            this.ComboBoxHomebrewFilterCategory.Location = new System.Drawing.Point(17, 40);
            this.ComboBoxHomebrewFilterCategory.MenuManager = this.MainMenu;
            this.ComboBoxHomebrewFilterCategory.Name = "ComboBoxHomebrewFilterCategory";
            this.ComboBoxHomebrewFilterCategory.Properties.AllowFocused = false;
            this.ComboBoxHomebrewFilterCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxHomebrewFilterCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxHomebrewFilterCategory.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxHomebrewFilterCategory.Properties.AutoComplete = false;
            this.ComboBoxHomebrewFilterCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxHomebrewFilterCategory.Properties.DropDownRows = 15;
            this.ComboBoxHomebrewFilterCategory.Properties.NullValuePrompt = "Select...";
            this.ComboBoxHomebrewFilterCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxHomebrewFilterCategory.Size = new System.Drawing.Size(220, 22);
            this.ComboBoxHomebrewFilterCategory.TabIndex = 1170;
            this.ComboBoxHomebrewFilterCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHomebrewFilterCategory_SelectedIndexChanged);
            // 
            // LabelHomebrewFilterCategory
            // 
            this.LabelHomebrewFilterCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelHomebrewFilterCategory.Appearance.Options.UseFont = true;
            this.LabelHomebrewFilterCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHomebrewFilterCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHomebrewFilterCategory.Location = new System.Drawing.Point(15, 20);
            this.LabelHomebrewFilterCategory.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelHomebrewFilterCategory.Name = "LabelHomebrewFilterCategory";
            this.LabelHomebrewFilterCategory.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelHomebrewFilterCategory.Size = new System.Drawing.Size(56, 15);
            this.LabelHomebrewFilterCategory.TabIndex = 1171;
            this.LabelHomebrewFilterCategory.Text = "Category";
            // 
            // ComboBoxHomebrewFilterStatus
            // 
            this.ComboBoxHomebrewFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxHomebrewFilterStatus.Location = new System.Drawing.Point(1130, 40);
            this.ComboBoxHomebrewFilterStatus.MenuManager = this.MainMenu;
            this.ComboBoxHomebrewFilterStatus.Name = "ComboBoxHomebrewFilterStatus";
            this.ComboBoxHomebrewFilterStatus.Properties.AllowFocused = false;
            this.ComboBoxHomebrewFilterStatus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxHomebrewFilterStatus.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ComboBoxHomebrewFilterStatus.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxHomebrewFilterStatus.Properties.AutoComplete = false;
            this.ComboBoxHomebrewFilterStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxHomebrewFilterStatus.Properties.Items.AddRange(new object[] {
            "<All>",
            "Downloaded",
            "Not Installed",
            "Installed"});
            this.ComboBoxHomebrewFilterStatus.Properties.NullValuePrompt = "Select...";
            this.ComboBoxHomebrewFilterStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxHomebrewFilterStatus.Size = new System.Drawing.Size(102, 22);
            this.ComboBoxHomebrewFilterStatus.TabIndex = 1168;
            this.ComboBoxHomebrewFilterStatus.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHomebrewFilterStatus_SelectedIndexChanged);
            // 
            // LabelHomebrewFilterStatus
            // 
            this.LabelHomebrewFilterStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHomebrewFilterStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelHomebrewFilterStatus.Appearance.Options.UseFont = true;
            this.LabelHomebrewFilterStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHomebrewFilterStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHomebrewFilterStatus.Location = new System.Drawing.Point(1127, 20);
            this.LabelHomebrewFilterStatus.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelHomebrewFilterStatus.Name = "LabelHomebrewFilterStatus";
            this.LabelHomebrewFilterStatus.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelHomebrewFilterStatus.Size = new System.Drawing.Size(41, 15);
            this.LabelHomebrewFilterStatus.TabIndex = 1169;
            this.LabelHomebrewFilterStatus.Text = "Status";
            // 
            // ComboBoxHomebrewFilterCreator
            // 
            this.ComboBoxHomebrewFilterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxHomebrewFilterCreator.Location = new System.Drawing.Point(997, 40);
            this.ComboBoxHomebrewFilterCreator.MenuManager = this.MainMenu;
            this.ComboBoxHomebrewFilterCreator.Name = "ComboBoxHomebrewFilterCreator";
            this.ComboBoxHomebrewFilterCreator.Properties.AllowFocused = false;
            this.ComboBoxHomebrewFilterCreator.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxHomebrewFilterCreator.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxHomebrewFilterCreator.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxHomebrewFilterCreator.Properties.AutoComplete = false;
            this.ComboBoxHomebrewFilterCreator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxHomebrewFilterCreator.Properties.DropDownRows = 12;
            this.ComboBoxHomebrewFilterCreator.Properties.NullValuePrompt = "Select...";
            this.ComboBoxHomebrewFilterCreator.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxHomebrewFilterCreator.Size = new System.Drawing.Size(127, 22);
            this.ComboBoxHomebrewFilterCreator.TabIndex = 1166;
            this.ComboBoxHomebrewFilterCreator.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHomebrewFilterCreator_SelectedIndexChanged);
            // 
            // LabelHomebrewFilterCreator
            // 
            this.LabelHomebrewFilterCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHomebrewFilterCreator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelHomebrewFilterCreator.Appearance.Options.UseFont = true;
            this.LabelHomebrewFilterCreator.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHomebrewFilterCreator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHomebrewFilterCreator.Location = new System.Drawing.Point(994, 20);
            this.LabelHomebrewFilterCreator.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelHomebrewFilterCreator.Name = "LabelHomebrewFilterCreator";
            this.LabelHomebrewFilterCreator.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelHomebrewFilterCreator.Size = new System.Drawing.Size(48, 15);
            this.LabelHomebrewFilterCreator.TabIndex = 1167;
            this.LabelHomebrewFilterCreator.Text = "Creator";
            // 
            // ComboBoxHomebrewFilterVersion
            // 
            this.ComboBoxHomebrewFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxHomebrewFilterVersion.Location = new System.Drawing.Point(927, 40);
            this.ComboBoxHomebrewFilterVersion.MenuManager = this.MainMenu;
            this.ComboBoxHomebrewFilterVersion.Name = "ComboBoxHomebrewFilterVersion";
            this.ComboBoxHomebrewFilterVersion.Properties.AllowFocused = false;
            this.ComboBoxHomebrewFilterVersion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxHomebrewFilterVersion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxHomebrewFilterVersion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxHomebrewFilterVersion.Properties.AutoComplete = false;
            this.ComboBoxHomebrewFilterVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxHomebrewFilterVersion.Properties.DropDownRows = 12;
            this.ComboBoxHomebrewFilterVersion.Properties.NullValuePrompt = "Select...";
            this.ComboBoxHomebrewFilterVersion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxHomebrewFilterVersion.Size = new System.Drawing.Size(64, 22);
            this.ComboBoxHomebrewFilterVersion.TabIndex = 1164;
            this.ComboBoxHomebrewFilterVersion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHomebrewFilterVersion_SelectedIndexChanged);
            // 
            // LabelHomebrewFilterVersion
            // 
            this.LabelHomebrewFilterVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHomebrewFilterVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelHomebrewFilterVersion.Appearance.Options.UseFont = true;
            this.LabelHomebrewFilterVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHomebrewFilterVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHomebrewFilterVersion.Location = new System.Drawing.Point(924, 20);
            this.LabelHomebrewFilterVersion.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelHomebrewFilterVersion.Name = "LabelHomebrewFilterVersion";
            this.LabelHomebrewFilterVersion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelHomebrewFilterVersion.Size = new System.Drawing.Size(48, 15);
            this.LabelHomebrewFilterVersion.TabIndex = 1165;
            this.LabelHomebrewFilterVersion.Text = "Version";
            // 
            // TextBoxHomebrewFilterName
            // 
            this.TextBoxHomebrewFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxHomebrewFilterName.Location = new System.Drawing.Point(243, 40);
            this.TextBoxHomebrewFilterName.MenuManager = this.MainMenu;
            this.TextBoxHomebrewFilterName.Name = "TextBoxHomebrewFilterName";
            this.TextBoxHomebrewFilterName.Properties.AllowFocused = false;
            this.TextBoxHomebrewFilterName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.TextBoxHomebrewFilterName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxHomebrewFilterName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxHomebrewFilterName.Properties.NullValuePrompt = "Search...";
            this.TextBoxHomebrewFilterName.Size = new System.Drawing.Size(591, 22);
            this.TextBoxHomebrewFilterName.TabIndex = 1;
            this.TextBoxHomebrewFilterName.TextChanged += new System.EventHandler(this.TextBoxFilterHomebrewName_TextChanged);
            // 
            // ComboBoxHomebrewFilterSystemType
            // 
            this.ComboBoxHomebrewFilterSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxHomebrewFilterSystemType.Location = new System.Drawing.Point(840, 40);
            this.ComboBoxHomebrewFilterSystemType.MenuManager = this.MainMenu;
            this.ComboBoxHomebrewFilterSystemType.Name = "ComboBoxHomebrewFilterSystemType";
            this.ComboBoxHomebrewFilterSystemType.Properties.AllowFocused = false;
            this.ComboBoxHomebrewFilterSystemType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxHomebrewFilterSystemType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxHomebrewFilterSystemType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxHomebrewFilterSystemType.Properties.AutoComplete = false;
            this.ComboBoxHomebrewFilterSystemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxHomebrewFilterSystemType.Properties.DropDownRows = 12;
            this.ComboBoxHomebrewFilterSystemType.Properties.Items.AddRange(new object[] {
            "<All>"});
            this.ComboBoxHomebrewFilterSystemType.Properties.NullValuePrompt = "Select...";
            this.ComboBoxHomebrewFilterSystemType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxHomebrewFilterSystemType.Size = new System.Drawing.Size(81, 22);
            this.ComboBoxHomebrewFilterSystemType.TabIndex = 2;
            this.ComboBoxHomebrewFilterSystemType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHomebrewFilterSystemType_SelectedIndexChanged);
            // 
            // LabelHomebrewFilterName
            // 
            this.LabelHomebrewFilterName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHomebrewFilterName.Appearance.Options.UseFont = true;
            this.LabelHomebrewFilterName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHomebrewFilterName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHomebrewFilterName.Location = new System.Drawing.Point(240, 20);
            this.LabelHomebrewFilterName.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelHomebrewFilterName.Name = "LabelHomebrewFilterName";
            this.LabelHomebrewFilterName.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelHomebrewFilterName.Size = new System.Drawing.Size(39, 15);
            this.LabelHomebrewFilterName.TabIndex = 1157;
            this.LabelHomebrewFilterName.Text = "Name";
            // 
            // LabelHomebrewFilterSystemType
            // 
            this.LabelHomebrewFilterSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHomebrewFilterSystemType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelHomebrewFilterSystemType.Appearance.Options.UseFont = true;
            this.LabelHomebrewFilterSystemType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHomebrewFilterSystemType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHomebrewFilterSystemType.Location = new System.Drawing.Point(837, 20);
            this.LabelHomebrewFilterSystemType.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.LabelHomebrewFilterSystemType.Name = "LabelHomebrewFilterSystemType";
            this.LabelHomebrewFilterSystemType.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelHomebrewFilterSystemType.Size = new System.Drawing.Size(77, 15);
            this.LabelHomebrewFilterSystemType.TabIndex = 1156;
            this.LabelHomebrewFilterSystemType.Text = "System Type";
            // 
            // MenuGameSaves
            // 
            this.MenuGameSaves.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuGameSaves.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemGameSavesInstallFiles)});
            this.MenuGameSaves.Manager = this.MainMenu;
            this.MenuGameSaves.Name = "MenuGameSaves";
            // 
            // MenuPlugins
            // 
            this.MenuPlugins.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPluginsInstallFile)});
            this.MenuPlugins.Manager = this.MainMenu;
            this.MenuPlugins.Name = "MenuPlugins";
            // 
            // MenuPackages
            // 
            this.MenuPackages.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuPackages.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemPackagesInstallFile)});
            this.MenuPackages.Manager = this.MainMenu;
            this.MenuPackages.Name = "MenuPackages";
            // 
            // MenuHomebrew
            // 
            this.MenuHomebrew.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuHomebrew.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemHomebrewInstallFiles)});
            this.MenuHomebrew.Manager = this.MainMenu;
            this.MenuHomebrew.Name = "MenuHomebrew";
            // 
            // SeparatorTitle
            // 
            this.SeparatorTitle.BackColor = System.Drawing.Color.DimGray;
            this.SeparatorTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeparatorTitle.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.SeparatorTitle.LineColor = System.Drawing.Color.DimGray;
            this.SeparatorTitle.LineThickness = 1;
            this.SeparatorTitle.Location = new System.Drawing.Point(0, 31);
            this.SeparatorTitle.Name = "SeparatorTitle";
            this.SeparatorTitle.Padding = new System.Windows.Forms.Padding(0);
            this.SeparatorTitle.Size = new System.Drawing.Size(1528, 1);
            this.SeparatorTitle.TabIndex = 1195;
            // 
            // SeparatorLeft
            // 
            this.SeparatorLeft.BackColor = System.Drawing.Color.DimGray;
            this.SeparatorLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.SeparatorLeft.LineAlignment = DevExpress.XtraEditors.Alignment.Near;
            this.SeparatorLeft.LineColor = System.Drawing.Color.DimGray;
            this.SeparatorLeft.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.SeparatorLeft.LineThickness = 1;
            this.SeparatorLeft.Location = new System.Drawing.Point(246, 32);
            this.SeparatorLeft.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.SeparatorLeft.Name = "SeparatorLeft";
            this.SeparatorLeft.Padding = new System.Windows.Forms.Padding(0);
            this.SeparatorLeft.Size = new System.Drawing.Size(1, 712);
            this.SeparatorLeft.TabIndex = 1206;
            // 
            // tileItem1
            // 
            this.tileItem1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileItem1.AppearanceItem.Disabled.BackColor = System.Drawing.Color.Transparent;
            this.tileItem1.AppearanceItem.Disabled.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tileItem1.AppearanceItem.Disabled.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Disabled.Options.UseForeColor = true;
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tileItem1.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tileItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.tileItem1.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tileItem1.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement37.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement37.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement37.ImageOptions.ImageSize = new System.Drawing.Size(22, 22);
            tileItemElement37.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement37.ImageOptions.ImageToTextIndent = 2;
            tileItemElement37.Text = "Delete";
            tileItemElement37.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem1.Elements.Add(tileItemElement37);
            this.tileItem1.Enabled = false;
            this.tileItem1.Id = 2;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.Padding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            // 
            // ImageCollection
            // 
            this.ImageCollection.ImageSize = new System.Drawing.Size(20, 20);
            this.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ImageCollection.ImageStream")));
            this.ImageCollection.Images.SetKeyName(0, "file");
            this.ImageCollection.Images.SetKeyName(1, "folder");
            this.ImageCollection.Images.SetKeyName(2, "folder up");
            // 
            // tileItem2
            // 
            this.tileItem2.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileItem2.AppearanceItem.Disabled.BackColor = System.Drawing.Color.DarkViolet;
            this.tileItem2.AppearanceItem.Disabled.BorderColor = System.Drawing.Color.DarkViolet;
            this.tileItem2.AppearanceItem.Disabled.Options.UseBackColor = true;
            this.tileItem2.AppearanceItem.Disabled.Options.UseBorderColor = true;
            this.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrchid;
            this.tileItem2.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkOrchid;
            this.tileItem2.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tileItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseTextOptions = true;
            this.tileItem2.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tileItem2.BorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never;
            tileItemElement38.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image13")));
            tileItemElement38.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement38.ImageOptions.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileItemElement38.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement38.ImageOptions.ImageToTextIndent = 5;
            tileItemElement38.Text = "Game Save Resigner";
            tileItemElement38.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem2.Elements.Add(tileItemElement38);
            this.tileItem2.Id = 8;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            // 
            // TimerLoadConsole
            // 
            this.TimerLoadConsole.Tick += new System.EventHandler(this.TimerLoadConsole_Tick);
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.gridControl2);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.flyoutPanel1);
            this.panel10.Location = new System.Drawing.Point(14, 84);
            this.panel10.Margin = new System.Windows.Forms.Padding(14);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1253, 614);
            this.panel10.TabIndex = 7;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridControl2.Location = new System.Drawing.Point(10, 70);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1231, 530);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.ActiveFilterEnabled = false;
            this.gridView2.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.gridView2.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.gridView2.AppearancePrint.Row.Options.UseBackColor = true;
            this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupRowHeight = 20;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsFilter.AllowFilterEditor = false;
            this.gridView2.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowColumnHeaders = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.gridView2.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.RowHeight = 24;
            this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.comboBoxEdit2);
            this.panel11.Controls.Add(this.separatorControl9);
            this.panel11.Controls.Add(this.comboBoxEdit5);
            this.panel11.Controls.Add(this.labelControl6);
            this.panel11.Controls.Add(this.comboBoxEdit6);
            this.panel11.Controls.Add(this.labelControl7);
            this.panel11.Controls.Add(this.comboBoxEdit7);
            this.panel11.Controls.Add(this.labelControl35);
            this.panel11.Controls.Add(this.comboBoxEdit8);
            this.panel11.Controls.Add(this.labelControl51);
            this.panel11.Controls.Add(this.textEdit1);
            this.panel11.Controls.Add(this.comboBoxEdit9);
            this.panel11.Controls.Add(this.comboBoxEdit10);
            this.panel11.Controls.Add(this.labelControl53);
            this.panel11.Controls.Add(this.labelControl55);
            this.panel11.Controls.Add(this.labelControl57);
            this.panel11.Controls.Add(this.labelControl59);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(0, 4, 0, 50);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1251, 70);
            this.panel11.TabIndex = 12;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit2.Location = new System.Drawing.Point(741, 40);
            this.comboBoxEdit2.MenuManager = this.MainMenu;
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.AllowFocused = false;
            this.comboBoxEdit2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxEdit2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxEdit2.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit2.Properties.AutoComplete = false;
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.DropDownRows = 12;
            this.comboBoxEdit2.Properties.NullValuePrompt = "Select...";
            this.comboBoxEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit2.Size = new System.Drawing.Size(92, 22);
            this.comboBoxEdit2.TabIndex = 1173;
            // 
            // separatorControl9
            // 
            this.separatorControl9.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl9.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl9.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separatorControl9.LineThickness = 3;
            this.separatorControl9.Location = new System.Drawing.Point(0, 67);
            this.separatorControl9.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl9.Name = "separatorControl9";
            this.separatorControl9.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.separatorControl9.Size = new System.Drawing.Size(1251, 3);
            this.separatorControl9.TabIndex = 1172;
            // 
            // comboBoxEdit5
            // 
            this.comboBoxEdit5.Location = new System.Drawing.Point(17, 40);
            this.comboBoxEdit5.MenuManager = this.MainMenu;
            this.comboBoxEdit5.Name = "comboBoxEdit5";
            this.comboBoxEdit5.Properties.AllowFocused = false;
            this.comboBoxEdit5.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxEdit5.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxEdit5.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit5.Properties.AutoComplete = false;
            this.comboBoxEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit5.Properties.DropDownRows = 15;
            this.comboBoxEdit5.Properties.NullValuePrompt = "Select...";
            this.comboBoxEdit5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit5.Size = new System.Drawing.Size(220, 22);
            this.comboBoxEdit5.TabIndex = 1170;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl6.Location = new System.Drawing.Point(14, 20);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl6.Size = new System.Drawing.Size(56, 15);
            this.labelControl6.TabIndex = 1171;
            this.labelControl6.Text = "Category";
            // 
            // comboBoxEdit6
            // 
            this.comboBoxEdit6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit6.Location = new System.Drawing.Point(1130, 40);
            this.comboBoxEdit6.MenuManager = this.MainMenu;
            this.comboBoxEdit6.Name = "comboBoxEdit6";
            this.comboBoxEdit6.Properties.AllowFocused = false;
            this.comboBoxEdit6.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxEdit6.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.comboBoxEdit6.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit6.Properties.AutoComplete = false;
            this.comboBoxEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit6.Properties.Items.AddRange(new object[] {
            "Downloaded",
            "Not Installed",
            "Installed"});
            this.comboBoxEdit6.Properties.NullValuePrompt = "Select...";
            this.comboBoxEdit6.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit6.Size = new System.Drawing.Size(102, 22);
            this.comboBoxEdit6.TabIndex = 1168;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl7.Location = new System.Drawing.Point(1127, 20);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl7.Size = new System.Drawing.Size(41, 15);
            this.labelControl7.TabIndex = 1169;
            this.labelControl7.Text = "Status";
            // 
            // comboBoxEdit7
            // 
            this.comboBoxEdit7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit7.Location = new System.Drawing.Point(997, 40);
            this.comboBoxEdit7.MenuManager = this.MainMenu;
            this.comboBoxEdit7.Name = "comboBoxEdit7";
            this.comboBoxEdit7.Properties.AllowFocused = false;
            this.comboBoxEdit7.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxEdit7.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxEdit7.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit7.Properties.AutoComplete = false;
            this.comboBoxEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit7.Properties.DropDownRows = 12;
            this.comboBoxEdit7.Properties.NullValuePrompt = "Select...";
            this.comboBoxEdit7.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit7.Size = new System.Drawing.Size(127, 22);
            this.comboBoxEdit7.TabIndex = 1166;
            // 
            // labelControl35
            // 
            this.labelControl35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl35.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl35.Appearance.Options.UseFont = true;
            this.labelControl35.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl35.Location = new System.Drawing.Point(994, 20);
            this.labelControl35.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl35.Size = new System.Drawing.Size(48, 15);
            this.labelControl35.TabIndex = 1167;
            this.labelControl35.Text = "Creator";
            // 
            // comboBoxEdit8
            // 
            this.comboBoxEdit8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit8.Location = new System.Drawing.Point(927, 40);
            this.comboBoxEdit8.MenuManager = this.MainMenu;
            this.comboBoxEdit8.Name = "comboBoxEdit8";
            this.comboBoxEdit8.Properties.AllowFocused = false;
            this.comboBoxEdit8.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxEdit8.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxEdit8.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit8.Properties.AutoComplete = false;
            this.comboBoxEdit8.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit8.Properties.DropDownRows = 12;
            this.comboBoxEdit8.Properties.NullValuePrompt = "Select...";
            this.comboBoxEdit8.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit8.Size = new System.Drawing.Size(64, 22);
            this.comboBoxEdit8.TabIndex = 1164;
            // 
            // labelControl51
            // 
            this.labelControl51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl51.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl51.Appearance.Options.UseFont = true;
            this.labelControl51.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl51.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl51.Location = new System.Drawing.Point(924, 20);
            this.labelControl51.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl51.Name = "labelControl51";
            this.labelControl51.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl51.Size = new System.Drawing.Size(48, 15);
            this.labelControl51.TabIndex = 1165;
            this.labelControl51.Text = "Version";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(243, 40);
            this.textEdit1.MenuManager = this.MainMenu;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AllowFocused = false;
            this.textEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.NullValuePrompt = "Search...";
            this.textEdit1.Size = new System.Drawing.Size(405, 22);
            this.textEdit1.TabIndex = 1;
            // 
            // comboBoxEdit9
            // 
            this.comboBoxEdit9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit9.Location = new System.Drawing.Point(839, 40);
            this.comboBoxEdit9.MenuManager = this.MainMenu;
            this.comboBoxEdit9.Name = "comboBoxEdit9";
            this.comboBoxEdit9.Properties.AllowFocused = false;
            this.comboBoxEdit9.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxEdit9.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxEdit9.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit9.Properties.AutoComplete = false;
            this.comboBoxEdit9.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit9.Properties.DropDownRows = 12;
            this.comboBoxEdit9.Properties.NullValuePrompt = "Select...";
            this.comboBoxEdit9.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit9.Size = new System.Drawing.Size(82, 22);
            this.comboBoxEdit9.TabIndex = 4;
            // 
            // comboBoxEdit10
            // 
            this.comboBoxEdit10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit10.Location = new System.Drawing.Point(654, 40);
            this.comboBoxEdit10.MenuManager = this.MainMenu;
            this.comboBoxEdit10.Name = "comboBoxEdit10";
            this.comboBoxEdit10.Properties.AllowFocused = false;
            this.comboBoxEdit10.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxEdit10.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxEdit10.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit10.Properties.AutoComplete = false;
            this.comboBoxEdit10.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit10.Properties.DropDownRows = 12;
            this.comboBoxEdit10.Properties.Items.AddRange(new object[] {
            "<All>"});
            this.comboBoxEdit10.Properties.NullValuePrompt = "Select...";
            this.comboBoxEdit10.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit10.Size = new System.Drawing.Size(81, 22);
            this.comboBoxEdit10.TabIndex = 2;
            // 
            // labelControl53
            // 
            this.labelControl53.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl53.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl53.Appearance.Options.UseFont = true;
            this.labelControl53.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl53.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl53.Location = new System.Drawing.Point(836, 20);
            this.labelControl53.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl53.Name = "labelControl53";
            this.labelControl53.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl53.Size = new System.Drawing.Size(45, 15);
            this.labelControl53.TabIndex = 1163;
            this.labelControl53.Text = "Region";
            // 
            // labelControl55
            // 
            this.labelControl55.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl55.Appearance.Options.UseFont = true;
            this.labelControl55.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl55.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl55.Location = new System.Drawing.Point(240, 20);
            this.labelControl55.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl55.Name = "labelControl55";
            this.labelControl55.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl55.Size = new System.Drawing.Size(39, 15);
            this.labelControl55.TabIndex = 1157;
            this.labelControl55.Text = "Name";
            // 
            // labelControl57
            // 
            this.labelControl57.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl57.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl57.Appearance.Options.UseFont = true;
            this.labelControl57.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl57.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl57.Location = new System.Drawing.Point(651, 20);
            this.labelControl57.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl57.Name = "labelControl57";
            this.labelControl57.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl57.Size = new System.Drawing.Size(77, 15);
            this.labelControl57.TabIndex = 1156;
            this.labelControl57.Text = "System Type";
            // 
            // labelControl59
            // 
            this.labelControl59.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl59.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl59.Appearance.Options.UseFont = true;
            this.labelControl59.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl59.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl59.Location = new System.Drawing.Point(738, 20);
            this.labelControl59.Margin = new System.Windows.Forms.Padding(3, 4, 0, 2);
            this.labelControl59.Name = "labelControl59";
            this.labelControl59.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl59.Size = new System.Drawing.Size(61, 15);
            this.labelControl59.TabIndex = 1122;
            this.labelControl59.Text = "Mod Type";
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(844, 0);
            this.flyoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.Options.Location = new System.Drawing.Point(0, -20);
            this.flyoutPanel1.OptionsBeakPanel.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Slide;
            this.flyoutPanel1.OptionsButtonPanel.AllowGlyphSkinning = true;
            this.flyoutPanel1.OwnerControl = this.panel10;
            this.flyoutPanel1.ParentForm = this;
            this.flyoutPanel1.Size = new System.Drawing.Size(405, 615);
            this.flyoutPanel1.TabIndex = 1;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.flyoutPanelControl1.Controls.Add(this.xtraScrollableControl4);
            this.flyoutPanelControl1.Controls.Add(this.stackPanel2);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(405, 615);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // xtraScrollableControl4
            // 
            this.xtraScrollableControl4.Controls.Add(this.svgImageBox1);
            this.xtraScrollableControl4.Controls.Add(this.labelControl60);
            this.xtraScrollableControl4.Controls.Add(this.labelControl61);
            this.xtraScrollableControl4.Controls.Add(this.labelControl63);
            this.xtraScrollableControl4.Controls.Add(this.labelControl64);
            this.xtraScrollableControl4.Controls.Add(this.labelControl65);
            this.xtraScrollableControl4.Controls.Add(this.labelControl67);
            this.xtraScrollableControl4.Controls.Add(this.labelControl68);
            this.xtraScrollableControl4.Controls.Add(this.labelControl69);
            this.xtraScrollableControl4.Controls.Add(this.labelControl70);
            this.xtraScrollableControl4.Controls.Add(this.labelControl74);
            this.xtraScrollableControl4.Controls.Add(this.labelControl75);
            this.xtraScrollableControl4.Controls.Add(this.labelControl76);
            this.xtraScrollableControl4.Controls.Add(this.labelControl77);
            this.xtraScrollableControl4.Controls.Add(this.labelControl78);
            this.xtraScrollableControl4.Controls.Add(this.labelControl79);
            this.xtraScrollableControl4.Controls.Add(this.labelControl80);
            this.xtraScrollableControl4.Controls.Add(this.labelControl81);
            this.xtraScrollableControl4.Controls.Add(this.labelControl82);
            this.xtraScrollableControl4.Controls.Add(this.labelControl83);
            this.xtraScrollableControl4.Controls.Add(this.labelControl84);
            this.xtraScrollableControl4.Controls.Add(this.labelControl85);
            this.xtraScrollableControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl4.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl4.Name = "xtraScrollableControl4";
            this.xtraScrollableControl4.Size = new System.Drawing.Size(405, 573);
            this.xtraScrollableControl4.TabIndex = 0;
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.svgImageBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.svgImageBox1.Location = new System.Drawing.Point(372, 10);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(22, 22);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 1170;
            this.svgImageBox1.Text = "Close";
            // 
            // labelControl60
            // 
            this.labelControl60.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl60.Appearance.Options.UseFont = true;
            this.labelControl60.Location = new System.Drawing.Point(8, 10);
            this.labelControl60.Margin = new System.Windows.Forms.Padding(6, 3, 3, 5);
            this.labelControl60.Name = "labelControl60";
            this.labelControl60.Size = new System.Drawing.Size(88, 17);
            this.labelControl60.TabIndex = 1168;
            this.labelControl60.Text = "MOD DETAILS";
            // 
            // labelControl61
            // 
            this.labelControl61.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl61.Appearance.Options.UseFont = true;
            this.labelControl61.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl61.Location = new System.Drawing.Point(8, 86);
            this.labelControl61.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl61.Name = "labelControl61";
            this.labelControl61.Size = new System.Drawing.Size(33, 15);
            this.labelControl61.TabIndex = 26;
            this.labelControl61.Text = "Name";
            // 
            // labelControl63
            // 
            this.labelControl63.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl63.Appearance.Options.UseFont = true;
            this.labelControl63.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl63.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl63.Location = new System.Drawing.Point(7, 485);
            this.labelControl63.Margin = new System.Windows.Forms.Padding(6, 5, 2, 3);
            this.labelControl63.MaximumSize = new System.Drawing.Size(360, 0);
            this.labelControl63.MinimumSize = new System.Drawing.Size(360, 0);
            this.labelControl63.Name = "labelControl63";
            this.labelControl63.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.labelControl63.Size = new System.Drawing.Size(360, 31);
            this.labelControl63.TabIndex = 12;
            this.labelControl63.Text = "...";
            // 
            // labelControl64
            // 
            this.labelControl64.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl64.Appearance.Options.UseFont = true;
            this.labelControl64.AutoEllipsis = true;
            this.labelControl64.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl64.Location = new System.Drawing.Point(8, 107);
            this.labelControl64.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.labelControl64.MaximumSize = new System.Drawing.Size(300, 15);
            this.labelControl64.Name = "labelControl64";
            this.labelControl64.Size = new System.Drawing.Size(9, 15);
            this.labelControl64.TabIndex = 2;
            this.labelControl64.Text = "...";
            // 
            // labelControl65
            // 
            this.labelControl65.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl65.Appearance.Options.UseFont = true;
            this.labelControl65.Location = new System.Drawing.Point(8, 464);
            this.labelControl65.Margin = new System.Windows.Forms.Padding(6, 5, 3, 0);
            this.labelControl65.Name = "labelControl65";
            this.labelControl65.Size = new System.Drawing.Size(80, 15);
            this.labelControl65.TabIndex = 1169;
            this.labelControl65.Text = "DESCRIPTION ";
            // 
            // labelControl67
            // 
            this.labelControl67.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl67.Appearance.Options.UseFont = true;
            this.labelControl67.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl67.Location = new System.Drawing.Point(8, 39);
            this.labelControl67.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl67.Name = "labelControl67";
            this.labelControl67.Size = new System.Drawing.Size(50, 15);
            this.labelControl67.TabIndex = 24;
            this.labelControl67.Text = "Category";
            // 
            // labelControl68
            // 
            this.labelControl68.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl68.Appearance.Options.UseFont = true;
            this.labelControl68.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl68.Location = new System.Drawing.Point(8, 436);
            this.labelControl68.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.labelControl68.Name = "labelControl68";
            this.labelControl68.Size = new System.Drawing.Size(9, 15);
            this.labelControl68.TabIndex = 14;
            this.labelControl68.Text = "...";
            // 
            // labelControl69
            // 
            this.labelControl69.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl69.Appearance.Options.UseFont = true;
            this.labelControl69.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl69.Location = new System.Drawing.Point(8, 60);
            this.labelControl69.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.labelControl69.Name = "labelControl69";
            this.labelControl69.Size = new System.Drawing.Size(9, 15);
            this.labelControl69.TabIndex = 23;
            this.labelControl69.Text = "...";
            // 
            // labelControl70
            // 
            this.labelControl70.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl70.Appearance.Options.UseFont = true;
            this.labelControl70.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl70.Location = new System.Drawing.Point(8, 415);
            this.labelControl70.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl70.Name = "labelControl70";
            this.labelControl70.Size = new System.Drawing.Size(76, 15);
            this.labelControl70.TabIndex = 13;
            this.labelControl70.Text = "Submitted By";
            // 
            // labelControl74
            // 
            this.labelControl74.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl74.Appearance.Options.UseFont = true;
            this.labelControl74.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl74.Location = new System.Drawing.Point(8, 133);
            this.labelControl74.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl74.Name = "labelControl74";
            this.labelControl74.Size = new System.Drawing.Size(71, 15);
            this.labelControl74.TabIndex = 20;
            this.labelControl74.Text = "System Type";
            // 
            // labelControl75
            // 
            this.labelControl75.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl75.Appearance.Options.UseFont = true;
            this.labelControl75.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl75.Location = new System.Drawing.Point(8, 389);
            this.labelControl75.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.labelControl75.Name = "labelControl75";
            this.labelControl75.Size = new System.Drawing.Size(9, 15);
            this.labelControl75.TabIndex = 15;
            this.labelControl75.Text = "...";
            // 
            // labelControl76
            // 
            this.labelControl76.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl76.Appearance.Options.UseFont = true;
            this.labelControl76.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl76.Location = new System.Drawing.Point(8, 154);
            this.labelControl76.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.labelControl76.Name = "labelControl76";
            this.labelControl76.Size = new System.Drawing.Size(9, 15);
            this.labelControl76.TabIndex = 21;
            this.labelControl76.Text = "...";
            // 
            // labelControl77
            // 
            this.labelControl77.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl77.Appearance.Options.UseFont = true;
            this.labelControl77.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl77.Location = new System.Drawing.Point(8, 368);
            this.labelControl77.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl77.Name = "labelControl77";
            this.labelControl77.Size = new System.Drawing.Size(61, 15);
            this.labelControl77.TabIndex = 6;
            this.labelControl77.Text = "Created By";
            // 
            // labelControl78
            // 
            this.labelControl78.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl78.Appearance.Options.UseFont = true;
            this.labelControl78.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl78.Location = new System.Drawing.Point(8, 180);
            this.labelControl78.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl78.Name = "labelControl78";
            this.labelControl78.Size = new System.Drawing.Size(55, 15);
            this.labelControl78.TabIndex = 16;
            this.labelControl78.Text = "Mod Type";
            // 
            // labelControl79
            // 
            this.labelControl79.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl79.Appearance.Options.UseFont = true;
            this.labelControl79.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl79.Location = new System.Drawing.Point(8, 342);
            this.labelControl79.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.labelControl79.Name = "labelControl79";
            this.labelControl79.Size = new System.Drawing.Size(9, 15);
            this.labelControl79.TabIndex = 10;
            this.labelControl79.Text = "...";
            // 
            // labelControl80
            // 
            this.labelControl80.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl80.Appearance.Options.UseFont = true;
            this.labelControl80.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl80.Location = new System.Drawing.Point(8, 201);
            this.labelControl80.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.labelControl80.Name = "labelControl80";
            this.labelControl80.Size = new System.Drawing.Size(9, 15);
            this.labelControl80.TabIndex = 17;
            this.labelControl80.Text = "...";
            // 
            // labelControl81
            // 
            this.labelControl81.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl81.Appearance.Options.UseFont = true;
            this.labelControl81.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl81.Location = new System.Drawing.Point(8, 321);
            this.labelControl81.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl81.Name = "labelControl81";
            this.labelControl81.Size = new System.Drawing.Size(63, 15);
            this.labelControl81.TabIndex = 9;
            this.labelControl81.Text = "Game Type";
            // 
            // labelControl82
            // 
            this.labelControl82.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl82.Appearance.Options.UseFont = true;
            this.labelControl82.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl82.Location = new System.Drawing.Point(8, 227);
            this.labelControl82.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl82.Name = "labelControl82";
            this.labelControl82.Size = new System.Drawing.Size(42, 15);
            this.labelControl82.TabIndex = 3;
            this.labelControl82.Text = "Version";
            // 
            // labelControl83
            // 
            this.labelControl83.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl83.Appearance.Options.UseFont = true;
            this.labelControl83.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl83.Location = new System.Drawing.Point(8, 295);
            this.labelControl83.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.labelControl83.Name = "labelControl83";
            this.labelControl83.Size = new System.Drawing.Size(9, 15);
            this.labelControl83.TabIndex = 1165;
            this.labelControl83.Text = "...";
            // 
            // labelControl84
            // 
            this.labelControl84.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl84.Appearance.Options.UseFont = true;
            this.labelControl84.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl84.Location = new System.Drawing.Point(8, 248);
            this.labelControl84.Margin = new System.Windows.Forms.Padding(0, 3, 3, 8);
            this.labelControl84.Name = "labelControl84";
            this.labelControl84.Size = new System.Drawing.Size(9, 15);
            this.labelControl84.TabIndex = 4;
            this.labelControl84.Text = "...";
            // 
            // labelControl85
            // 
            this.labelControl85.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl85.Appearance.Options.UseFont = true;
            this.labelControl85.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl85.Location = new System.Drawing.Point(8, 274);
            this.labelControl85.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.labelControl85.Name = "labelControl85";
            this.labelControl85.Size = new System.Drawing.Size(75, 15);
            this.labelControl85.TabIndex = 1164;
            this.labelControl85.Text = "Game Region";
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.dropDownButton1);
            this.stackPanel2.Controls.Add(this.simpleButton1);
            this.stackPanel2.Controls.Add(this.dropDownButton2);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel2.Location = new System.Drawing.Point(0, 573);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(405, 42);
            this.stackPanel2.TabIndex = 1174;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dropDownButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dropDownButton1.Appearance.Options.UseFont = true;
            this.dropDownButton1.Appearance.Options.UseTextOptions = true;
            this.dropDownButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.dropDownButton1.DropDownControl = this.MenuGameMods;
            this.dropDownButton1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.dropDownButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.dropDownButton1.ImageOptions.ImageToTextIndent = 4;
            this.dropDownButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.dropDownButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("dropDownButton1.ImageOptions.SvgImage")));
            this.dropDownButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.dropDownButton1.Location = new System.Drawing.Point(8, 8);
            this.dropDownButton1.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.dropDownButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.dropDownButton1.Size = new System.Drawing.Size(126, 26);
            this.dropDownButton1.TabIndex = 1173;
            this.dropDownButton1.Text = "Not Installed";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.ImageToTextIndent = 6;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.simpleButton1.Location = new System.Drawing.Point(140, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton1.Size = new System.Drawing.Size(100, 26);
            this.simpleButton1.TabIndex = 1176;
            this.simpleButton1.Text = "Download";
            // 
            // dropDownButton2
            // 
            this.dropDownButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dropDownButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dropDownButton2.Appearance.Options.UseFont = true;
            this.dropDownButton2.Appearance.Options.UseTextOptions = true;
            this.dropDownButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dropDownButton2.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.dropDownButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.dropDownButton2.ImageOptions.ImageToTextIndent = 6;
            this.dropDownButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.dropDownButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("dropDownButton2.ImageOptions.SvgImage")));
            this.dropDownButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.dropDownButton2.Location = new System.Drawing.Point(246, 8);
            this.dropDownButton2.Name = "dropDownButton2";
            this.dropDownButton2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.dropDownButton2.Size = new System.Drawing.Size(118, 26);
            this.dropDownButton2.TabIndex = 1174;
            this.dropDownButton2.Text = "Add to List";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Appearance.Options.UseFont = true;
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.panel10);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(200, 100);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 100);
            this.panel12.TabIndex = 0;
            // 
            // tileControl1
            // 
            this.tileControl1.AllowDisabledStateIndication = false;
            this.tileControl1.AllowDrag = false;
            this.tileControl1.AllowDragTilesBetweenGroups = false;
            this.tileControl1.AllowGlyphSkinning = true;
            this.tileControl1.AllowItemHover = true;
            this.tileControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(240, 150);
            this.tileControl1.TabIndex = 0;
            // 
            // MenuResources
            // 
            this.MenuResources.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.MenuResources.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemResourcesInstallFiles)});
            this.MenuResources.Manager = this.MainMenu;
            this.MenuResources.Name = "MenuResources";
            // 
            // MainWindow
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 769);
            this.Controls.Add(this.NavigationFrame);
            this.Controls.Add(this.SeparatorLeft);
            this.Controls.Add(this.NavigationMenu);
            this.Controls.Add(this.SeparatorTitle);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.toolbarFormControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.False;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainWindow.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1530, 770);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModioX - Beta v2.0.0";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.StyleChanged += new System.EventHandler(this.MainWindow_StyleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNotifyText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNotifyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuConnect)).EndInit();
            this.PanelGameModsFilters.ResumeLayout(false);
            this.PanelGameModsFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterModType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorGameMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterCreator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameModsFilterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameModsFilterSystemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlGameMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGameMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolbarFormManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelLatestNews)).EndInit();
            this.PanelLatestNews.ResumeLayout(false);
            this.PanelLatestNews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageReloadNewsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelToolItems)).EndInit();
            this.PanelToolItems.ResumeLayout(false);
            this.PanelToolItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelChangeLog)).EndInit();
            this.PanelChangeLog.ResumeLayout(false);
            this.PanelChangeLog.PerformLayout();
            this.PanelChangeLogText.ResumeLayout(false);
            this.PanelChangeLogText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelAnnouncements)).EndInit();
            this.PanelAnnouncements.ResumeLayout(false);
            this.PanelAnnouncements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSetupItems)).EndInit();
            this.PanelSetupItems.ResumeLayout(false);
            this.PanelSetupItems.PerformLayout();
            this.PanelInstalledMods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlInstalledMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInstalledMods)).EndInit();
            this.PanelInstalledModsFilters.ResumeLayout(false);
            this.PanelInstalledModsFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInstalledModsFilterTotalFilesType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInstalledModsFilterTotalFilesTypeBack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeInstalledModsFilterInstalledOn.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeInstalledModsFilterInstalledOn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInstalledModsFilterInstalledOnType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInstalledModsFilterInstalledOnTypeBack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBoxInstalledModsFilterTotalFiles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstalledModsFilterCreator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstalledModsFilterPlatform.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorInstalledModsFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstalledModsFilterCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstalledModsFilterVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxInstalledModsFilterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstalledModsFilterRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxInstalledModsFilterType.Properties)).EndInit();
            this.PanelInstalledModsActions.ResumeLayout(false);
            this.PanelDownloads.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlDownloads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDownloads)).EndInit();
            this.PanelFiltersDownloads.ResumeLayout(false);
            this.PanelFiltersDownloads.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDownloadsFilterRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeDownloadsFilterDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeDownloadsFilterDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDownloadsFilterOnType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageDownloadsFilterOnTypeBack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDownloadsFilterVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDownloadsFilterModType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDownloadsFilterPlatform.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDownloadsFilterCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDownloadsFilterFileName.Properties)).EndInit();
            this.PanelActionsDownloads.ResumeLayout(false);
            this.PanelGameModsActions.ResumeLayout(false);
            this.PanelGameMods.ResumeLayout(false);
            this.PageGameMods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavigationFrame)).EndInit();
            this.NavigationFrame.ResumeLayout(false);
            this.PageDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelStatistics)).EndInit();
            this.PanelStatistics.ResumeLayout(false);
            this.PanelStatistics.PerformLayout();
            this.PanelStatisticsText.ResumeLayout(false);
            this.PanelStatisticsText.PerformLayout();
            this.PageInstalledMods.ResumeLayout(false);
            this.PageDownloads.ResumeLayout(false);
            this.PageFileManager.ResumeLayout(false);
            this.PanelFileManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupConsoleFileExplorer)).EndInit();
            this.GroupConsoleFileExplorer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelFileManagerConsoleButtons)).EndInit();
            this.PanelFileManagerConsoleButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelFileManagerConsoleStatus)).EndInit();
            this.PanelFileManagerConsoleStatus.ResumeLayout(false);
            this.PanelFileManagerConsoleStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlFileManagerConsoleFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFileManagerConsoleFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileManagerConsolePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxFileManagerConsoleDrives.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupLocalFileExplorer)).EndInit();
            this.GroupLocalFileExplorer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelFileManagerLocalButtons)).EndInit();
            this.PanelFileManagerLocalButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelFileManagerLocalStatus)).EndInit();
            this.PanelFileManagerLocalStatus.ResumeLayout(false);
            this.PanelFileManagerLocalStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlFileManagerLocalFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFileManagerLocalFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxFileManagerLocalDrives.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileManagerLocalPath.Properties)).EndInit();
            this.PageSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlSettings)).EndInit();
            this.TabControlSettings.ResumeLayout(false);
            this.TabPageInterface.ResumeLayout(false);
            this.TabPageInterface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsInstallResourcesToUsbDevice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsInstallHomebrewToUsbDevice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsAutoLoadDirectoryListings.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsEnableHardwareAcceleration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsInstallPackagesToUsbDevice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsInstallGameSavesToUsbDevice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsInstallModsToUsbDevice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsRememberConsolePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsRememberLocalPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsRememberGameRegions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsAutoDetectGameTitles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsAutoDetectGameRegions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsShowGamesFromExternalDevices.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsUseRelativeTimes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSettingsLanguages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsUseFormattedFileSizes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupSettingsStartupLibrary.Properties)).EndInit();
            this.TabPageTools.ResumeLayout(false);
            this.TabPageTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorSettingsTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSettingsPackagesInstallPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSettingsLaunchIniFilePath.Properties)).EndInit();
            this.TabPageDownloads.ResumeLayout(false);
            this.TabPageDownloads.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSettingsDownloadsFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSettingsDownloadsFolder.Properties)).EndInit();
            this.TabPageChatRoom.ResumeLayout(false);
            this.TabPageChatRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsHideUnreadMessagesCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsMuteSounds.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupSettingsChatRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitchSettingsBlockPrivateMessages.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSettingsUserName.Properties)).EndInit();
            this.PageGameSaves.ResumeLayout(false);
            this.PanelGameSaves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlGameSaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameSaves)).EndInit();
            this.PanelGameSavesFilters.ResumeLayout(false);
            this.PanelGameSavesFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameSavesFilterCreator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameSavesFilterCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameSavesFilterVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameSavesFilterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameSavesFilterRegion.Properties)).EndInit();
            this.PanelGameSavesActions.ResumeLayout(false);
            this.PagePlugins.ResumeLayout(false);
            this.PanelPlugins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlPlugins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPlugins)).EndInit();
            this.PanelPluginsFilters.ResumeLayout(false);
            this.PanelPluginsFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPluginsFilterStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPluginsFilterCreator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPluginsFilterCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPluginsFilterVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPluginsFilterName.Properties)).EndInit();
            this.panel6.ResumeLayout(false);
            this.PagePackages.ResumeLayout(false);
            this.PanelPackages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPackages)).EndInit();
            this.PanelPackagesFilters.ResumeLayout(false);
            this.PanelPackagesFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePackagesFilterFileSizeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePackagesFilterFileSizeBack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPackagesFilterModifiedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPackagesFilterModifiedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePackagesFilterDateType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPackagesFilterStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPackagesFilterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPackagesFilterRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxFilterPackagesCategories.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePackagesFilterDateTypeBack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPackagesFilterFileSize.Properties)).EndInit();
            this.PanelPackagesActions.ResumeLayout(false);
            this.PageRealTimeMods.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlMemoryOffsets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMemoryOffsets)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRealTimeModsGame.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.PanelRealTimeMods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlRealTimeMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRealTimeMods)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxFilterRealTimeModsGameMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxFilterRealTimeModsGame.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFilterRealTimeModsName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxFilterRealTimeModsCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyoutPanelRealTimeMods)).EndInit();
            this.FlyoutPanelRealTimeMods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FlyoutPanelControlRealTimeMods)).EndInit();
            this.FlyoutPanelControlRealTimeMods.ResumeLayout(false);
            this.xtraScrollableControl3.ResumeLayout(false);
            this.xtraScrollableControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCloseRealTimeModsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel4)).EndInit();
            this.stackPanel4.ResumeLayout(false);
            this.PageResources.ResumeLayout(false);
            this.PanelResourcesResources.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewResources)).EndInit();
            this.PanelResourcesFilters.ResumeLayout(false);
            this.PanelResourcesFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxResourcesFilterModType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxResourcesFilterCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxResourcesFilterStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxResourcesFilterCreator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxResourcesFilterVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxResourcesFilterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxResourcesFilterSystemType.Properties)).EndInit();
            this.PageHomebrew.ResumeLayout(false);
            this.PanelHomebrewActions.ResumeLayout(false);
            this.PanelHomebrew.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlHomebrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHomebrew)).EndInit();
            this.PanelHomebrewFilters.ResumeLayout(false);
            this.PanelHomebrewFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorHomebrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxHomebrewFilterCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxHomebrewFilterStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxHomebrewFilterCreator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxHomebrewFilterVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxHomebrewFilterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxHomebrewFilterSystemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGameSaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPlugins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuHomebrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeparatorLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCollection)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            this.xtraScrollableControl4.ResumeLayout(false);
            this.xtraScrollableControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuResources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelGameModsFilterModType;
        private LabelControl LabelGameModsFilterSystemType;
        private Panel PanelGameModsFilters;
        private LabelControl LabelGameModsFilterName;
        private LabelControl LabelGameModsFilterRegion;
        private DataGridViewTextBoxColumn ColumnInstallationFiles;
        private DataGridViewTextBoxColumn ColumnModsId;
        private DataGridViewTextBoxColumn ColumnModsName;
        private DataGridViewTextBoxColumn ColumnModsFirmware;
        private DataGridViewTextBoxColumn ColumnModsType;
        private DataGridViewTextBoxColumn ColumnModsRegion;
        private DataGridViewTextBoxColumn ColumnModsVersion;
        private DataGridViewTextBoxColumn ColumnModsAuthor;
        private DataGridViewTextBoxColumn ColumnModsNoFiles;
        private DataGridViewImageColumn ColumnModsInstall;
        private DataGridViewImageColumn ColumnModsDownload;
        private DataGridViewImageColumn ColumnModsFavourite;
        private DataGridViewTextBoxColumn ColumnModsInstalledId;
        private DataGridViewTextBoxColumn ColumnModsInstalledGameTitle;
        private DataGridViewTextBoxColumn ColumnModsInstalledRegion;
        private DataGridViewTextBoxColumn ColumnModsInstalledModName;
        private DataGridViewTextBoxColumn ColumnModsInstalledModType;
        private DataGridViewTextBoxColumn ColumnModsInstalledVersion;
        private DataGridViewTextBoxColumn ColumnModsInstalledNoOfFiles;
        private DataGridViewTextBoxColumn ColumnModsInstalledDateTime;
        private DataGridViewImageColumn ColumnModsInstalledUninstall;
        private BarManager MainMenu;
        private PopupMenu MenuHelp;
        private BarButtonItem MenuItemTools;
        private PopupMenu MenuTools;
        private BarButtonItem MenuItemHelp;
        private PopupMenu MenuConnect;
        private Bar BarStatus;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private ComboBoxEdit ComboBoxGameModsFilterSystemType;
        private BarButtonItem MenuItemPS3GameBackupFiles;
        private BarButtonItem MenuItemPS3GameUpdateFinder;
        private BarButtonItem MenuItemPS3PackageManager;
        private BarButtonItem MenuItemDiscordServer;
        private BarButtonItem MenuItemOfficialSource;
        private BarButtonItem MenuItemOpenLogFile;
        private BarButtonItem MenuItemOpenLogFolder;
        private BarButtonItem MenuItemCheckForUpdate;
        private BarButtonItem MenuItemWhatsNew;
        private BarButtonItem MenuItemAbout;
        private BarSubItem MenuItemPS3;
        private BarSubItem MenuItemXbox360;
        private BarSubItem MenuItemPS3WebManControls;
        private BarSubItem MenuItemPS3PowerFunctions;
        private BarButtonItem MenuItemPS3Shutdown;
        private BarButtonItem MenuItemPS3QuickReboot;
        private BarButtonItem MenuItemPS3SoftReboot;
        private BarButtonItem MenuItemPS3NotifyMessage;
        private BarButtonItem MenuItemPS3VirtualController;
        private ComboBoxEdit ComboBoxGameModsFilterRegion;
        private BarStaticItem StatusLabelConnectedConsole;
        private NavBarGroup NavGroupAllGames;
        private NavBarGroup NavGroupHomebrewApps;
        private NavBarGroup NavGroupResources;
        private NavBarGroup NavGroupLists;
        private TextEdit TextBoxGameModsFilterName;
        private GridControl GridControlGameMods;
        private GridView GridViewGameMods;
        private BarButtonItem MenuItemConnectToXBOX;
        private PopupMenu MenuGameMods;
        private BarSubItem MenuItemXboxXBDMControls;
        private BarSubItem MenuItemXboxPowerFunctions;
        private BarButtonItem MenuItemXboxPowerShutdown;
        private BarButtonItem MenuItemXboxPowerSoftReboot;
        private BarButtonItem MenuItemXboxPowerHardReboot;
        private BarSubItem MenuItemXboxSystemInfo;
        private BarButtonItem MenuItemXboxShowSystemTemperatures;
        private BarStaticItem StatusLabelHeaderConnectedConsole;
        private BarButtonItem MenuItemXboxOpenCloseTray;
        private RepositoryItemComboBox XNotifyType;
        private RepositoryItemTextEdit XNotifyText;
        private BarButtonItem MenuItemXboxPluginsEditor;
        private BarButtonItem MenuItemXboxNotifyMessage;
        private BarButtonItem MenuItemPS3HardReboot;
        private BarButtonItem MenuItemXboxTakeScreenshot;
        private BarSubItem MenuItemPS3SystemInfo;
        private BarButtonItem MenuItemPS3ShowMinimumVersion;
        private BarButtonItem MenuItemPS3ShowSystemInformation;
        private BarButtonItem MenuItemPS3ShowTemperatures;
        private BarSubItem MenuItemPS3Games;
        private BarButtonItem MenuItemPS3MountBD;
        private BarButtonItem MenuItemPS3UnmountGame;
        private BarButtonItem MenuItemPS3MountISO;
        private BarButtonItem MenuItemPS3MountPSN;
        private DevExpress.Utils.Animation.TransitionManager TransitionManager;
        private SkinBarSubItem ButtonSkinChanger;
        private BarButtonItem MenuItemPS3Restart;
        private RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager ToolbarFormManager;
        private BarDockControl barDockControl1;
        private BarDockControl barDockControl2;
        private BarDockControl barDockControl3;
        private BarDockControl barDockControl4;
        private DevExpress.XtraBars.Navigation.AccordionControl NavigationMenu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationGroupDashboard;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationItemDashboard;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationGroupGeneral;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationItemPackages;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationItemGameMods;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationItemInstalledMods;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationItemFileManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationItemSettings;
        private BarButtonItem MenuItemGameSavesInstallFiles;
        private BarButtonItem MenuButtonConnect;
        private BarButtonItem MenuButtonTools;
        private BarButtonItem MenuButtonOptions;
        private BarButtonItem MenuButtonHelp;
        private BarButtonItem MenuButtonSubmitMods;
        private BarButtonItem MenuButtonChatRoom;
        private PanelControl PanelChangeLog;
        private LabelControl LabelChangeLogVersion;
        private XtraScrollableControl PanelChangeLogText;
        private LabelControl LabelHeaderChangeLog;
        private PanelControl PanelAnnouncements;
        private Controls.NoAnnouncementsItem NoAnnouncementsItem;
        private XtraScrollableControl PanelAnnouncementsItems;
        private LabelControl LabelHeaderAnnouncements;
        private PanelControl PanelSetupItems;
        private TileControl TileControlSetup;
        private LabelControl LabelHeaderSetup;
        private PanelControl PanelLatestNews;
        private XtraScrollableControl PanelNewsItems;
        private LabelControl LabelHeaderLatestNews;
        private PanelControl PanelToolItems;
        private LabelControl LabelHeaderTools;
        private TileGroup TileGroupSetup;
        private TileItem TileItemAddNewConsole;
        private TileItem TileItemStartupLibrary;
        private TileItem TileItemSetDownloadsLocation;
        private SvgImageBox ImageReloadNewsItems;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationItemDownloads;
        private NavBarGroup NavGroupUsersGames;
        private LabelControl LabelChangeLog;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationGroupLibrary;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationItemPlugins;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationItemGameSaves;
        private ComboBoxEdit ComboBoxGameModsFilterCreator;
        private LabelControl LabelGameModsFilterCreator;
        private ComboBoxEdit ComboBoxGameModsFilterVersion;
        private LabelControl LabelGameModsFilterVersion;
        private ComboBoxEdit ComboBoxGameModsFilterStatus;
        private LabelControl LabelGameModsFilterStatus;
        private ComboBoxEdit ComboBoxGameModsFilterCategory;
        private LabelControl LabelGameModsFilterCategory;
        private SeparatorControl SeparatorGameMods;
        private Panel PanelGameMods;
        private Panel PanelGameModsActions;
        private TileControl TileControlGameMods;
        private TileGroup TileGroupGameMods;
        private Panel PanelDownloads;
        private GridControl GridControlDownloads;
        private GridView GridViewDownloads;
        private Panel PanelFiltersDownloads;
        private SeparatorControl separatorControl3;
        private ComboBoxEdit ComboBoxDownloadsFilterCategory;
        private LabelControl LabelDownloadsFilterCategory;
        private TextEdit TextBoxDownloadsFilterFileName;
        private ComboBoxEdit ComboBoxDownloadsFilterPlatform;
        private LabelControl LabelDownloadsFilterName;
        private LabelControl LabelDownloadsFilterPlatform;
        private Panel PanelActionsDownloads;
        private TileControl TileControlDownloads;
        private TileGroup TileGroupDownloads;
        private TileItem TileItemDownloadsOpenFolder;
        private Panel PanelInstalledMods;
        private GridControl GridControlInstalledMods;
        private GridView GridViewInstalledMods;
        private Panel PanelInstalledModsFilters;
        private SeparatorControl SeparatorInstalledModsFilter;
        private ComboBoxEdit ComboBoxInstalledModsFilterCategory;
        private LabelControl LabelInstalledModsFilterCategory;
        private ComboBoxEdit ComboBoxInstalledModsFilterVersion;
        private LabelControl LabelInstalledModsFilterVersion;
        private TextEdit TextBoxInstalledModsFilterName;
        private ComboBoxEdit ComboBoxInstalledModsFilterType;
        private LabelControl LabelInstalledModsFilterModName;
        private LabelControl LabelInstalledModsFilterModType;
        private Panel PanelInstalledModsActions;
        private TileControl TileControlInstalledMods;
        private TileGroup TileGroupInstalledMods;
        private TileItem TileItemInstalledModsUninstallAllItems;
        private TileItem TileItemInstalledModsUninstallItem;
        private TileItem TileItemDownloadsDeleteItem;
        private ComboBoxEdit ComboBoxDownloadsFilterModType;
        private LabelControl LabelDownloadsFilterModType;
        private ComboBoxEdit ComboBoxDownloadsFilterVersion;
        private LabelControl LabelDownloadsFilterVersion;
        private ComboBoxEdit ComboBoxInstalledModsFilterPlatform;
        private LabelControl LabelInstalledModsFilterPlatform;
        private DevExpress.XtraBars.Navigation.NavigationFrame NavigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage PageDashboard;
        private DevExpress.XtraBars.Navigation.NavigationPage PageInstalledMods;
        private DevExpress.XtraBars.Navigation.NavigationPage PageDownloads;
        private DevExpress.XtraBars.Navigation.NavigationPage PageFileManager;
        private DevExpress.XtraBars.Navigation.NavigationPage PageSettings;
        private DevExpress.XtraBars.Navigation.NavigationPage PageGameMods;
        private DevExpress.XtraBars.Navigation.NavigationPage PageGameSaves;
        private DevExpress.XtraBars.Navigation.NavigationPage PagePlugins;
        private SeparatorControl SeparatorTitle;
        private SeparatorControl SeparatorLeft;
        private TileItem TileItemDownloadsDeleteAllItems;
        private TileItem tileItem1;
        private ComboBoxEdit ComboBoxGameModsFilterModType;
        private ComboBoxEdit ComboBoxInstalledModsFilterRegion;
        private LabelControl LabelInstalledModsFilterGameRegion;
        private DevExpress.XtraTab.XtraTabControl TabControlSettings;
        private DevExpress.XtraTab.XtraTabPage TabPageInterface;
        private LabelControl LabelSettingsLanguage;
        private LabelControl LabelSettingsStartupLibrary;
        private RadioGroup RadioGroupSettingsStartupLibrary;
        private LabelControl LabelSettingsCustomization;
        private DevExpress.XtraTab.XtraTabPage TabPageChatRoom;
        private LabelControl LabelSettingsChatRoomNotifications;
        private TextEdit TextBoxSettingsUserName;
        private LabelControl LabelSettingsChatRoomUserName;
        private DevExpress.XtraTab.XtraTabPage TabPageTools;
        private LabelControl LabelSettingsLaunchIniFilePath;
        private TextEdit TextBoxSettingsLaunchIniFilePath;
        private ToggleSwitch ToggleSwitchSettingsUseFormattedFileSizes;
        private LabelControl LabelSettingsRememberGameRegions;
        private LabelControl LabelSettingsAutoDetectGameTitles;
        private LabelControl LabelSettingsAutoDetectGameRegions;
        private LabelControl LabelSettingsShowGamesFromExternalDevices;
        private ToggleSwitch ToggleSwitchSettingsRememberGameRegions;
        private ToggleSwitch ToggleSwitchSettingsAutoDetectGameTitles;
        private ToggleSwitch ToggleSwitchSettingsAutoDetectGameRegions;
        private ToggleSwitch ToggleSwitchSettingsShowGamesFromExternalDevices;
        private LabelControl LabelSettingsAutomation;
        private LabelControl LabelSettingsUseRelativeTimes;
        private ToggleSwitch ToggleSwitchSettingsUseRelativeTimes;
        private ComboBoxEdit ComboBoxSettingsLanguages;
        private LabelControl LabelSettingsUseFormattedFileSizes;
        private LabelControl LabelSettingsRememberConsolePath;
        private LabelControl LabelSettingsRememberLocalPath;
        private ToggleSwitch ToggleSwitchSettingsRememberConsolePath;
        private ToggleSwitch ToggleSwitchSettingsRememberLocalPath;
        private RepositoryItemRadioGroup repositoryItemRadioGroup2;
        private DevExpress.XtraTab.XtraTabPage TabPageDownloads;
        private LabelControl LabelSettingsBlockPrivateMessages;
        private ToggleSwitch ToggleSwitchSettingsBlockPrivateMessages;
        private BarButtonItem MenuItemConnectToPS3;
        private TileItem TileItemDownloadsOpenFile;
        private ComboBoxEdit ComboBoxInstalledModsFilterCreator;
        private LabelControl LabelInstalledModsFilterCreator;
        private BarButtonItem MenuItemXboxGameSaveResigner;
        private DevExpress.Utils.ImageCollection ImageCollection;
        private Panel PanelGameSaves;
        private GridControl GridControlGameSaves;
        private GridView GridViewGameSaves;
        private Panel PanelGameSavesFilters;
        private ComboBoxEdit ComboBoxGameSavesFilterCreator;
        private LabelControl LabelGameSavesFilterCreator;
        private SeparatorControl separatorControl1;
        private ComboBoxEdit ComboBoxGameSavesFilterCategory;
        private LabelControl LabelGameSavesFilterCategory;
        private ComboBoxEdit ComboBoxGameSavesFilterVersion;
        private LabelControl LabelGameSavesFilterVersion;
        private TextEdit TextBoxGameSavesFilterName;
        private ComboBoxEdit ComboBoxGameSavesFilterRegion;
        private LabelControl LabelGameSavesFilterRegion;
        private LabelControl LabelGameSavesFilterName;
        private Panel PanelGameSavesActions;
        private DevExpress.XtraBars.Navigation.NavigationPage PagePackages;
        private Panel PanelPackagesActions;
        private Panel PanelPackages;
        private GridControl GridControlPackages;
        private GridView GridViewPackages;
        private Panel PanelPackagesFilters;
        private SeparatorControl separatorControl4;
        private ComboBoxEdit ComboBoxPackagesFilterStatus;
        private LabelControl LabelPackagesFilterStatus;
        private TextEdit TextBoxPackagesFilterName;
        private ComboBoxEdit ComboBoxPackagesFilterRegion;
        private LabelControl LabelHeaderPackagesRegion;
        private LabelControl LabelPackagesFilterName;
        private ComboBoxEdit ComboBoxFilterPackagesCategories;
        private LabelControl LabelPackagesFilterCategory;
        private LabelControl LabelSettingsDownloadsFolder;
        private LabelControl LabelSettingsDownloadLocation;
        private TextEdit TextBoxSettingsDownloadsFolder;
        private PictureEdit ImageSettingsDownloadsFolder;
        private TileItem TileItemIntroductionDetails;
        private Panel PanelPlugins;
        private GridControl GridControlPlugins;
        private GridView GridViewPlugins;
        private Panel PanelPluginsFilters;
        private ComboBoxEdit ComboBoxPluginsFilterStatus;
        private LabelControl LabelPluginsFilterStatus;
        private ComboBoxEdit ComboBoxPluginsFilterCreator;
        private LabelControl LabelPluginsFilterCreator;
        private SeparatorControl separatorControl2;
        private ComboBoxEdit ComboBoxPluginsFilterCategory;
        private LabelControl labelControl13;
        private ComboBoxEdit ComboBoxPluginsFilterVersion;
        private LabelControl LabelPluginsFilterVersion;
        private TextEdit TextBoxPluginsFilterName;
        private LabelControl labelControl21;
        private Panel panel6;
        private RadioGroup RadioGroupSettingsChatRoom;
        private LabelControl LabelSettingsHideUnreadMessagesCount;
        private ToggleSwitch ToggleSwitchSettingsHideUnreadMessagesCount;
        private LabelControl LabelSettingsMuteSounds;
        private ToggleSwitch ToggleSwitchSettingsMuteSounds;
        private LabelControl LabelSettingsChatRoomOptions;
        private PopupMenu MenuPackages;
        private BarButtonItem MenuItemPackagesInstallFile;
        private DateEdit ComboBoxPackagesFilterModifiedDate;
        private LabelControl LabelPackagesFilterModifiedDate;
        private PictureEdit ImagePackagesFilterDateType;
        private SeparatorControl SeparatorSettingsTools;
        private LabelControl LabelSettingsToolsXBOX;
        private LabelControl LabelSettingsPackagesFilePath;
        private TextEdit TextBoxSettingsPackagesInstallPath;
        private LabelControl LabelSettingsToolsPS3;
        private LabelControl LabelPackagesFilterFileSize;
        private PictureEdit ImagePackagesFilterDateTypeBack;
        private LabelControl LabelSettingsInstallModsToUsbDevice;
        private ToggleSwitch ToggleSwitchSettingsInstallModsToUsbDevice;
        private PopupMenu MenuGameSaves;
        private PictureEdit ImagePackagesFilterFileSizeType;
        private PictureEdit ImagePackagesFilterFileSizeBack;
        private SpinEdit ComboBoxPackagesFilterFileSize;
        private TileItem TileItemEditConsoleProfiles;
        private LabelControl LabelSettingsInstallGameSavesToUsbDevice;
        private ToggleSwitch ToggleSwitchSettingsInstallGameSavesToUsbDevice;
        private LabelControl LabelSettingsInstallPackagesToUsbDevice;
        private ToggleSwitch ToggleSwitchSettingsInstallPackagesToUsbDevice;
        private BarButtonItem MenuItemGameModsInstallFiles;
        private PictureEdit ImageInstalledModsFilterTotalFilesType;
        private PictureEdit ImageInstalledModsFilterTotalFilesTypeBack;
        private LabelControl LabelInstalledModsFilterTotalFiles;
        private DateEdit DateTimeInstalledModsFilterInstalledOn;
        private PictureEdit ImageInstalledModsFilterInstalledOnType;
        private LabelControl LabelInstalledModsFilterInstalledOn;
        private PictureEdit ImageInstalledModsFilterInstalledOnTypeBack;
        private SpinEdit NumericBoxInstalledModsFilterTotalFiles;
        private DateEdit DateTimeDownloadsFilterDate;
        private PictureEdit ImageDownloadsFilterOnType;
        private LabelControl LabelDownloadsFilterDateTime;
        private PictureEdit ImageDownloadsFilterOnTypeBack;
        private BarButtonItem MenuItemPluginsInstallFile;
        private PopupMenu MenuPlugins;
        private LabelControl LabelSettingsEnableHardwareAcceleration;
        private ToggleSwitch ToggleSwitchSettingsEnableHardwareAcceleration;
        private LabelControl LabelSettingsAdvanced;
        private TileItem TileItemScanForXboxConsoles;
        private BarButtonItem MenuItemXboxGameLauncher;
        private BarButtonItem MenuItemPS3ConsoleManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationItemRealTimeMods;
        private DevExpress.XtraBars.Navigation.NavigationPage PageRealTimeMods;
        private Panel PanelRealTimeMods;
        private DevExpress.Utils.FlyoutPanel FlyoutPanelRealTimeMods;
        private DevExpress.Utils.FlyoutPanelControl FlyoutPanelControlRealTimeMods;
        private XtraScrollableControl xtraScrollableControl3;
        private SvgImageBox ImageCloseRealTimeModsInfo;
        private LabelControl LabelHeaderRealTimeModsDetails;
        private LabelControl LabelHeaderRealTimeModsGameVersion;
        private LabelControl LabelRealTimeModsDescription;
        private LabelControl LabelRealTimeModsGameVersion;
        private LabelControl labelControl44;
        private LabelControl labelControl48;
        private LabelControl LabelRealTimeModsGameTitle;
        private LabelControl labelControl52;
        private LabelControl LabelRealTimeModsName;
        private LabelControl labelControl58;
        private LabelControl LabelRealTimeModsCategory;
        private LabelControl labelControl62;
        private LabelControl LabelRealTimeModsGameMode;
        private StackPanel stackPanel4;
        private GridControl GridControlRealTimeMods;
        private GridView GridViewRealTimeMods;
        private Panel panel4;
        private ComboBoxEdit ComboBoxFilterRealTimeModsGameMode;
        private SeparatorControl separatorControl6;
        private ComboBoxEdit ComboBoxFilterRealTimeModsGame;
        private LabelControl labelControl66;
        private TextEdit TextBoxFilterRealTimeModsName;
        private ComboBoxEdit ComboBoxFilterRealTimeModsCategory;
        private LabelControl labelControl71;
        private LabelControl labelControl72;
        private LabelControl labelControl73;
        private SimpleButton ButtonRealTimeModsSetValue;
        private SimpleButton ButtonRealTimeModsEnable;
        private SimpleButton ButtonRealTimeModsDisable;
        private Panel panel5;
        private TileItem TileItemGameModsSortBy;
        private TileControl TileControlGameSaves;
        private TileGroup TileGroupGameSaves;
        private TileItem TileItemGameSavesSortBy;
        private TileControl TileControlPlugins;
        private TileGroup TileGroupPlugins;
        private TileItem TileItemPluginsSortBy;
        private TileItem TileItemPluginsShowFavorites;
        private TileControl TileControlPackages;
        private TileGroup TileGroupPackages;
        private TileItem TileItemPackagesSortBy;
        private TileControl TileControlRealTimeMods;
        private TileGroup TileGroupRealTimeMods;
        private TileItem TileItemRealTimeModsCategories;
        private TileItem TileItemRealTimeModsSort;
        private TileItem TileItemRealTimeModsImport;
        private Panel panel1;
        private Panel panel3;
        private SimpleButton ButtonAttachGame;
        private ComboBoxEdit comboBoxEdit1;
        private SeparatorControl separatorControl7;
        private ComboBoxEdit ComboBoxRealTimeModsGame;
        private LabelControl labelControl24;
        private LabelControl labelControl43;
        private GridControl GridControlMemoryOffsets;
        private GridView GridViewMemoryOffsets;
        private Panel panel7;
        private GridControl gridControl1;
        private GridView gridView1;
        private Panel panel8;
        private ComboBoxEdit comboBoxEdit3;
        private SeparatorControl separatorControl8;
        private ComboBoxEdit comboBoxEdit4;
        private LabelControl labelControl36;
        private TextEdit textEdit2;
        private LabelControl labelControl49;
        private LabelControl labelControl50;
        private TileControl TileControlTools;
        private TileGroup TileGroupTools;
        private TileItem TileItemToolsGameUpdateFinder;
        private TileItem TileItemToolsGameBackupFiles;
        private TileItem TileItemToolsPackageManager;
        private TileItem TileItemToolsConsoleManager;
        private TileItem TileItemToolsLaunchFileEditor;
        private TileItem TileItemToolsGameSaveResigner;
        private TileItem tileItem2;
        private TileItem TileItemToolsGameLauncher;
        private TableLayoutPanel PanelFileManager;
        private GroupControl GroupConsoleFileExplorer;
        private StackPanel PanelFileManagerConsoleButtons;
        private SimpleButton ButtonFileManagerConsoleDownload;
        private SimpleButton ButtonFileManagerConsoleDelete;
        private SimpleButton ButtonFileManagerConsoleRename;
        private SimpleButton ButtonFileManagerConsoleNewFolder;
        private SimpleButton ButtonFileManagerConsoleRefresh;
        private SimpleButton ButtonFileManagerConsoleAddToGames;
        private StackPanel PanelFileManagerConsoleStatus;
        private LabelControl LabelFileManagerConsoleStatus;
        private GridControl GridControlFileManagerConsoleFiles;
        private GridView GridViewFileManagerConsoleFiles;
        private SimpleButton ButtonFileManagerConsoleNavigate;
        private TextEdit TextBoxFileManagerConsolePath;
        private ComboBoxEdit ComboBoxFileManagerConsoleDrives;
        private GroupControl GroupLocalFileExplorer;
        private StackPanel PanelFileManagerLocalButtons;
        private SimpleButton ButtonFileManagerLocalUpload;
        private SimpleButton ButtonFileManagerLocalDelete;
        private SimpleButton ButtonFileManagerFileLocalRename;
        private SimpleButton ButtonFileManagerLocalNewFolder;
        private SimpleButton ButtonFileManagerLocalRefresh;
        private SimpleButton ButtonFileManagerLocalOpenExplorer;
        private StackPanel PanelFileManagerLocalStatus;
        private LabelControl LabelFileManagerLocalStatus;
        private GridControl GridControlFileManagerLocalFiles;
        private GridView GridViewFileManagerLocalFiles;
        private SimpleButton ButtonFileManagerBrowseLocalDirectory;
        private ComboBoxEdit ComboBoxFileManagerLocalDrives;
        private TextEdit TextBoxFileManagerLocalPath;
        private Timer TimerLoadConsole;
        private BarButtonItem MenuItemSendFeedback;
        private LabelControl LabelSettingsAutoLoadDirectoryListings;
        private ToggleSwitch ToggleSwitchSettingsAutoLoadDirectoryListings;
        private LabelControl LabelSettingsOptionsOnlyForPS3;
        private LabelControl LabelSettingsOtherLanguagesSoon;
        private BarButtonItem barButtonItem1;
        private PanelControl PanelStatistics;
        private XtraScrollableControl PanelStatisticsText;
        private LabelControl LabelStatisticsPlayStation3;
        private LabelControl LabelHeaderStatistics;
        private LabelControl LabelStatisticsHeaderXbox360;
        private LabelControl LabelStatisticsXbox360;
        private LabelControl LabelStatisticsHeaderPlayStation3;
        private LabelControl LabelStatisticsLastUpdated;
        private ComboBoxEdit ComboBoxDownloadsFilterRegion;
        private LabelControl LabelDownloadsFilterRegion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationItemHomebrew;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NavigationItemResources;
        private DevExpress.XtraBars.Navigation.NavigationPage PageResources;
        private DevExpress.XtraBars.Navigation.NavigationPage PageHomebrew;
        private Panel PanelResourcesResources;
        private TileControl TileControlResources;
        private TileGroup TileGroupResources;
        private TileItem TileItemResourcesSortBy;
        private TileItem TileItemResourcesShowFavorites;
        private Panel panel16;
        private GridControl GridControlResources;
        private GridView GridViewResources;
        private Panel PanelResourcesFilters;
        private ComboBoxEdit ComboBoxResourcesFilterModType;
        private SeparatorControl separatorControl11;
        private ComboBoxEdit ComboBoxResourcesFilterCategory;
        private LabelControl LabelResourcesFilterCategory;
        private ComboBoxEdit ComboBoxResourcesFilterStatus;
        private LabelControl LabelResourcesFilterStatus;
        private ComboBoxEdit ComboBoxResourcesFilterCreator;
        private LabelControl LabelResourcesFilterCreator;
        private ComboBoxEdit ComboBoxResourcesFilterVersion;
        private LabelControl LabelResourcesFilterVersion;
        private TextEdit TextBoxResourcesFilterName;
        private ComboBoxEdit ComboBoxResourcesFilterSystemType;
        private LabelControl LabelResourcesFilterName;
        private LabelControl LabelResourcesFilterSystemType;
        private LabelControl LabelResourcesFilterModType;
        private Panel PanelHomebrewActions;
        private TileControl TileControlHomebrew;
        private TileGroup TileGroupHomebrew;
        private TileItem TileItemHomebrewSortBy;
        private Panel PanelHomebrew;
        private GridControl GridControlHomebrew;
        private GridView GridViewHomebrew;
        private Panel PanelHomebrewFilters;
        private SeparatorControl SeparatorHomebrew;
        private ComboBoxEdit ComboBoxHomebrewFilterCategory;
        private LabelControl LabelHomebrewFilterCategory;
        private ComboBoxEdit ComboBoxHomebrewFilterStatus;
        private LabelControl LabelHomebrewFilterStatus;
        private ComboBoxEdit ComboBoxHomebrewFilterCreator;
        private LabelControl LabelHomebrewFilterCreator;
        private ComboBoxEdit ComboBoxHomebrewFilterVersion;
        private LabelControl LabelHomebrewFilterVersion;
        private TextEdit TextBoxHomebrewFilterName;
        private ComboBoxEdit ComboBoxHomebrewFilterSystemType;
        private LabelControl LabelHomebrewFilterName;
        private LabelControl LabelHomebrewFilterSystemType;
        private Panel panel10;
        private GridControl gridControl2;
        private GridView gridView2;
        private Panel panel11;
        private ComboBoxEdit comboBoxEdit2;
        private SeparatorControl separatorControl9;
        private ComboBoxEdit comboBoxEdit5;
        private LabelControl labelControl6;
        private ComboBoxEdit comboBoxEdit6;
        private LabelControl labelControl7;
        private ComboBoxEdit comboBoxEdit7;
        private LabelControl labelControl35;
        private ComboBoxEdit comboBoxEdit8;
        private LabelControl labelControl51;
        private TextEdit textEdit1;
        private ComboBoxEdit comboBoxEdit9;
        private ComboBoxEdit comboBoxEdit10;
        private LabelControl labelControl53;
        private LabelControl labelControl55;
        private LabelControl labelControl57;
        private LabelControl labelControl59;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private XtraScrollableControl xtraScrollableControl4;
        private SvgImageBox svgImageBox1;
        private LabelControl labelControl60;
        private LabelControl labelControl61;
        private LabelControl labelControl63;
        private LabelControl labelControl64;
        private LabelControl labelControl65;
        private LabelControl labelControl67;
        private LabelControl labelControl68;
        private LabelControl labelControl69;
        private LabelControl labelControl70;
        private LabelControl labelControl74;
        private LabelControl labelControl75;
        private LabelControl labelControl76;
        private LabelControl labelControl77;
        private LabelControl labelControl78;
        private LabelControl labelControl79;
        private LabelControl labelControl80;
        private LabelControl labelControl81;
        private LabelControl labelControl82;
        private LabelControl labelControl83;
        private LabelControl labelControl84;
        private LabelControl labelControl85;
        private StackPanel stackPanel2;
        private DropDownButton dropDownButton1;
        private SimpleButton simpleButton1;
        private DropDownButton dropDownButton2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private Panel panel12;
        private TileControl tileControl1;
        private LabelControl LabelSettingsInstallResourcesToUsbDevice;
        private ToggleSwitch ToggleSwitchSettingsInstallResourcesToUsbDevice;
        private LabelControl LabelSettingsInstallHomebrewToUsbDevice;
        private ToggleSwitch ToggleSwitchSettingsInstallHomebrewToUsbDevice;
        private PopupMenu MenuHomebrew;
        private PopupMenu MenuResources;
        private BarButtonItem MenuItemHomebrewInstallFiles;
        private BarButtonItem MenuItemResourcesInstallFiles;
        private TileItem TileItemGameModsShowFavorites;
        private TileItem TileItemInstalledModsViewDetails;
        private TileItem TileItemDownloadsViewDetails;
        private TileItem TileItemHomebrewShowFavorites;
        private TileItem TileItemToolsCustomizeGameRegions;
    }
}