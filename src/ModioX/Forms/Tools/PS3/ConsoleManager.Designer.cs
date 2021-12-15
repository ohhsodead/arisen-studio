
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Tools.PS3
{
    partial class ConsoleManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleManager));
            this.LabelHeaderTempCELL = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderTempRSX = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderFirmwareVersion = new DevExpress.XtraEditors.LabelControl();
            this.PopupImage = new DevExpress.XtraBars.PopupMenu(this.components);
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.MenuStatus = new DevExpress.XtraBars.Bar();
            this.LabelHeaderStatus = new DevExpress.XtraBars.BarStaticItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.MenuButtonFile = new DevExpress.XtraBars.BarButtonItem();
            this.PopupMenuFile = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuItemLoadFile = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemSaveFile = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemReplace = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemExtract = new DevExpress.XtraBars.BarButtonItem();
            this.MenuButtonProfile = new DevExpress.XtraBars.BarButtonItem();
            this.PopupMenuProfile = new DevExpress.XtraBars.PopupMenu(this.components);
            this.MenuItemAddProfileDetails = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemAddProfileFromConsole = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemAddExistingProfile = new DevExpress.XtraBars.BarButtonItem();
            this.MenuItemSaveToDevice = new DevExpress.XtraBars.BarSubItem();
            this.MenuItemNoDeviceFound = new DevExpress.XtraBars.BarButtonItem();
            this.GroupGameSave = new DevExpress.XtraEditors.GroupControl();
            this.LabelCoreVersion = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.LabelFirmwareType = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.LabelTempRSX = new DevExpress.XtraEditors.LabelControl();
            this.LabelTempCELL = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonRefreshDetails = new DevExpress.XtraEditors.SimpleButton();
            this.LabelFirmwareVersion = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ButtonRingBuzzer = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.RadioGroupBuzzerMode = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonSetLEDs = new DevExpress.XtraEditors.SimpleButton();
            this.RadioGroupLEDsRed = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.RadioGroupLEDsGreen = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.GroupConsoleIds = new DevExpress.XtraEditors.GroupControl();
            this.ButtonSetPSID = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSetIDPS = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxPSID = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxIDPS = new DevExpress.XtraEditors.TextEdit();
            this.LabelHeaderPSID = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderIDPS = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PopupImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGameSave)).BeginInit();
            this.GroupGameSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupBuzzerMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupLEDsRed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupLEDsGreen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupConsoleIds)).BeginInit();
            this.GroupConsoleIds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPSID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxIDPS.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeaderTempCELL
            // 
            this.LabelHeaderTempCELL.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTempCELL.Appearance.Options.UseFont = true;
            this.LabelHeaderTempCELL.Location = new System.Drawing.Point(233, 72);
            this.LabelHeaderTempCELL.Name = "LabelHeaderTempCELL";
            this.LabelHeaderTempCELL.Size = new System.Drawing.Size(29, 15);
            this.LabelHeaderTempCELL.TabIndex = 12;
            this.LabelHeaderTempCELL.Text = "CELL:";
            // 
            // LabelHeaderTempRSX
            // 
            this.LabelHeaderTempRSX.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTempRSX.Appearance.Options.UseFont = true;
            this.LabelHeaderTempRSX.Location = new System.Drawing.Point(233, 100);
            this.LabelHeaderTempRSX.Name = "LabelHeaderTempRSX";
            this.LabelHeaderTempRSX.Size = new System.Drawing.Size(23, 15);
            this.LabelHeaderTempRSX.TabIndex = 8;
            this.LabelHeaderTempRSX.Text = "RSX:";
            // 
            // LabelHeaderFirmwareVersion
            // 
            this.LabelHeaderFirmwareVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderFirmwareVersion.Appearance.Options.UseFont = true;
            this.LabelHeaderFirmwareVersion.Location = new System.Drawing.Point(15, 40);
            this.LabelHeaderFirmwareVersion.Name = "LabelHeaderFirmwareVersion";
            this.LabelHeaderFirmwareVersion.Size = new System.Drawing.Size(94, 15);
            this.LabelHeaderFirmwareVersion.TabIndex = 4;
            this.LabelHeaderFirmwareVersion.Text = "Firmware Version:";
            // 
            // PopupImage
            // 
            this.PopupImage.AutoFillEditorWidth = false;
            this.PopupImage.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.PopupImage.Manager = this.BarManager;
            this.PopupImage.Name = "PopupImage";
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MenuStatus});
            this.BarManager.DockControls.Add(this.barDockControlTop);
            this.BarManager.DockControls.Add(this.barDockControlBottom);
            this.BarManager.DockControls.Add(this.barDockControlLeft);
            this.BarManager.DockControls.Add(this.barDockControlRight);
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuButtonFile,
            this.MenuItemLoadFile,
            this.MenuItemSaveFile,
            this.LabelHeaderStatus,
            this.LabelStatus,
            this.MenuItemReplace,
            this.MenuItemExtract,
            this.MenuButtonProfile,
            this.MenuItemAddProfileDetails,
            this.MenuItemAddProfileFromConsole,
            this.MenuItemAddExistingProfile,
            this.MenuItemSaveToDevice,
            this.MenuItemNoDeviceFound});
            this.BarManager.MaxItemId = 20;
            this.BarManager.StatusBar = this.MenuStatus;
            // 
            // MenuStatus
            // 
            this.MenuStatus.BarItemVertIndent = 4;
            this.MenuStatus.BarName = "Status bar";
            this.MenuStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.MenuStatus.DockCol = 0;
            this.MenuStatus.DockRow = 0;
            this.MenuStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.MenuStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelHeaderStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelStatus)});
            this.MenuStatus.OptionsBar.AllowQuickCustomization = false;
            this.MenuStatus.OptionsBar.DrawDragBorder = false;
            this.MenuStatus.OptionsBar.UseWholeRow = true;
            this.MenuStatus.Text = "Status bar";
            // 
            // LabelHeaderStatus
            // 
            this.LabelHeaderStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelHeaderStatus.Caption = "Status:";
            this.LabelHeaderStatus.Id = 6;
            this.LabelHeaderStatus.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderStatus.ItemAppearance.Normal.Options.UseFont = true;
            this.LabelHeaderStatus.LeftIndent = 2;
            this.LabelHeaderStatus.Name = "LabelHeaderStatus";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelStatus.Caption = "Idle";
            this.LabelStatus.Id = 7;
            this.LabelStatus.Name = "LabelStatus";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(705, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 391);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(705, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 391);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(705, 0);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 391);
            // 
            // MenuButtonFile
            // 
            this.MenuButtonFile.ActAsDropDown = true;
            this.MenuButtonFile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuButtonFile.Caption = "CONNECT";
            this.MenuButtonFile.DropDownControl = this.PopupMenuFile;
            this.MenuButtonFile.Id = 2;
            this.MenuButtonFile.Name = "MenuButtonFile";
            // 
            // PopupMenuFile
            // 
            this.PopupMenuFile.AutoFillEditorWidth = false;
            this.PopupMenuFile.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.PopupMenuFile.Manager = this.BarManager;
            this.PopupMenuFile.Name = "PopupMenuFile";
            // 
            // MenuItemLoadFile
            // 
            this.MenuItemLoadFile.Caption = "Load File...";
            this.MenuItemLoadFile.Id = 3;
            this.MenuItemLoadFile.Name = "MenuItemLoadFile";
            // 
            // MenuItemSaveFile
            // 
            this.MenuItemSaveFile.Caption = "Save File...";
            this.MenuItemSaveFile.Id = 5;
            this.MenuItemSaveFile.Name = "MenuItemSaveFile";
            // 
            // MenuItemReplace
            // 
            this.MenuItemReplace.Caption = "Replace...";
            this.MenuItemReplace.Id = 8;
            this.MenuItemReplace.Name = "MenuItemReplace";
            // 
            // MenuItemExtract
            // 
            this.MenuItemExtract.Caption = "Extract...";
            this.MenuItemExtract.Id = 9;
            this.MenuItemExtract.Name = "MenuItemExtract";
            // 
            // MenuButtonProfile
            // 
            this.MenuButtonProfile.ActAsDropDown = true;
            this.MenuButtonProfile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.MenuButtonProfile.Caption = "PROFILE";
            this.MenuButtonProfile.DropDownControl = this.PopupMenuProfile;
            this.MenuButtonProfile.Id = 10;
            this.MenuButtonProfile.Name = "MenuButtonProfile";
            // 
            // PopupMenuProfile
            // 
            this.PopupMenuProfile.AutoFillEditorWidth = false;
            this.PopupMenuProfile.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            this.PopupMenuProfile.Manager = this.BarManager;
            this.PopupMenuProfile.Name = "PopupMenuProfile";
            // 
            // MenuItemAddProfileDetails
            // 
            this.MenuItemAddProfileDetails.Caption = "Add Profile Details...";
            this.MenuItemAddProfileDetails.Id = 11;
            this.MenuItemAddProfileDetails.Name = "MenuItemAddProfileDetails";
            // 
            // MenuItemAddProfileFromConsole
            // 
            this.MenuItemAddProfileFromConsole.Caption = "Add Profile From Console...";
            this.MenuItemAddProfileFromConsole.Id = 12;
            this.MenuItemAddProfileFromConsole.Name = "MenuItemAddProfileFromConsole";
            // 
            // MenuItemAddExistingProfile
            // 
            this.MenuItemAddExistingProfile.Caption = "Add Existing Profile...";
            this.MenuItemAddExistingProfile.Id = 13;
            this.MenuItemAddExistingProfile.Name = "MenuItemAddExistingProfile";
            // 
            // MenuItemSaveToDevice
            // 
            this.MenuItemSaveToDevice.Caption = "Save to Device...";
            this.MenuItemSaveToDevice.Id = 16;
            this.MenuItemSaveToDevice.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuItemNoDeviceFound)});
            this.MenuItemSaveToDevice.Name = "MenuItemSaveToDevice";
            // 
            // MenuItemNoDeviceFound
            // 
            this.MenuItemNoDeviceFound.Caption = "No Devices Found";
            this.MenuItemNoDeviceFound.Enabled = false;
            this.MenuItemNoDeviceFound.Id = 17;
            this.MenuItemNoDeviceFound.Name = "MenuItemNoDeviceFound";
            this.MenuItemNoDeviceFound.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.MenuItemNoDeviceFound.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            // 
            // GroupGameSave
            // 
            this.GroupGameSave.Controls.Add(this.LabelCoreVersion);
            this.GroupGameSave.Controls.Add(this.labelControl14);
            this.GroupGameSave.Controls.Add(this.LabelFirmwareType);
            this.GroupGameSave.Controls.Add(this.labelControl12);
            this.GroupGameSave.Controls.Add(this.LabelTempRSX);
            this.GroupGameSave.Controls.Add(this.LabelTempCELL);
            this.GroupGameSave.Controls.Add(this.labelControl7);
            this.GroupGameSave.Controls.Add(this.ButtonRefreshDetails);
            this.GroupGameSave.Controls.Add(this.LabelFirmwareVersion);
            this.GroupGameSave.Controls.Add(this.LabelHeaderTempCELL);
            this.GroupGameSave.Controls.Add(this.LabelHeaderTempRSX);
            this.GroupGameSave.Controls.Add(this.LabelHeaderFirmwareVersion);
            this.GroupGameSave.Location = new System.Drawing.Point(12, 12);
            this.GroupGameSave.Name = "GroupGameSave";
            this.GroupGameSave.Padding = new System.Windows.Forms.Padding(12);
            this.GroupGameSave.Size = new System.Drawing.Size(343, 245);
            this.GroupGameSave.TabIndex = 11;
            this.GroupGameSave.Text = "Details";
            // 
            // LabelCoreVersion
            // 
            this.LabelCoreVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelCoreVersion.Appearance.Options.UseFont = true;
            this.LabelCoreVersion.Location = new System.Drawing.Point(139, 104);
            this.LabelCoreVersion.Name = "LabelCoreVersion";
            this.LabelCoreVersion.Size = new System.Drawing.Size(5, 15);
            this.LabelCoreVersion.TabIndex = 21;
            this.LabelCoreVersion.Text = "-";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(15, 104);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(70, 15);
            this.labelControl14.TabIndex = 20;
            this.labelControl14.Text = "Core Version:";
            // 
            // LabelFirmwareType
            // 
            this.LabelFirmwareType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelFirmwareType.Appearance.Options.UseFont = true;
            this.LabelFirmwareType.Location = new System.Drawing.Point(139, 72);
            this.LabelFirmwareType.Name = "LabelFirmwareType";
            this.LabelFirmwareType.Size = new System.Drawing.Size(5, 15);
            this.LabelFirmwareType.TabIndex = 19;
            this.LabelFirmwareType.Text = "-";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(15, 72);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(80, 15);
            this.labelControl12.TabIndex = 18;
            this.labelControl12.Text = "Firmware Type:";
            // 
            // LabelTempRSX
            // 
            this.LabelTempRSX.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTempRSX.Appearance.Options.UseFont = true;
            this.LabelTempRSX.Location = new System.Drawing.Point(279, 100);
            this.LabelTempRSX.Name = "LabelTempRSX";
            this.LabelTempRSX.Size = new System.Drawing.Size(5, 15);
            this.LabelTempRSX.TabIndex = 17;
            this.LabelTempRSX.Text = "-";
            // 
            // LabelTempCELL
            // 
            this.LabelTempCELL.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTempCELL.Appearance.Options.UseFont = true;
            this.LabelTempCELL.Location = new System.Drawing.Point(279, 72);
            this.LabelTempCELL.Name = "LabelTempCELL";
            this.LabelTempCELL.Size = new System.Drawing.Size(5, 15);
            this.LabelTempCELL.TabIndex = 16;
            this.LabelTempCELL.Text = "-";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(233, 40);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 15);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Temperatures";
            // 
            // ButtonRefreshDetails
            // 
            this.ButtonRefreshDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRefreshDetails.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonRefreshDetails.Appearance.Options.UseFont = true;
            this.ButtonRefreshDetails.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonRefreshDetails.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonRefreshDetails.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonRefreshDetails.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonRefreshDetails.Location = new System.Drawing.Point(15, 204);
            this.ButtonRefreshDetails.Name = "ButtonRefreshDetails";
            this.ButtonRefreshDetails.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRefreshDetails.Size = new System.Drawing.Size(313, 25);
            this.ButtonRefreshDetails.TabIndex = 1;
            this.ButtonRefreshDetails.Text = "Refresh";
            this.ButtonRefreshDetails.Click += new System.EventHandler(this.ButtonRefreshDetails_Click);
            // 
            // LabelFirmwareVersion
            // 
            this.LabelFirmwareVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelFirmwareVersion.Appearance.Options.UseFont = true;
            this.LabelFirmwareVersion.Location = new System.Drawing.Point(139, 40);
            this.LabelFirmwareVersion.Name = "LabelFirmwareVersion";
            this.LabelFirmwareVersion.Size = new System.Drawing.Size(5, 15);
            this.LabelFirmwareVersion.TabIndex = 13;
            this.LabelFirmwareVersion.Text = "-";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ButtonRingBuzzer);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.RadioGroupBuzzerMode);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.ButtonSetLEDs);
            this.groupControl1.Controls.Add(this.RadioGroupLEDsRed);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.RadioGroupLEDsGreen);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Location = new System.Drawing.Point(363, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(12);
            this.groupControl1.Size = new System.Drawing.Size(330, 245);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "LEDs && Buzzer";
            // 
            // ButtonRingBuzzer
            // 
            this.ButtonRingBuzzer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRingBuzzer.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonRingBuzzer.Appearance.Options.UseFont = true;
            this.ButtonRingBuzzer.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonRingBuzzer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonRingBuzzer.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonRingBuzzer.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonRingBuzzer.Location = new System.Drawing.Point(212, 204);
            this.ButtonRingBuzzer.Name = "ButtonRingBuzzer";
            this.ButtonRingBuzzer.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRingBuzzer.Size = new System.Drawing.Size(103, 25);
            this.ButtonRingBuzzer.TabIndex = 1179;
            this.ButtonRingBuzzer.Text = "Ring Buzzer";
            this.ButtonRingBuzzer.Click += new System.EventHandler(this.ButtonRingBuzzer_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(212, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 15);
            this.labelControl3.TabIndex = 1178;
            this.labelControl3.Text = "Buzzer";
            // 
            // RadioGroupBuzzerMode
            // 
            this.RadioGroupBuzzerMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioGroupBuzzerMode.Location = new System.Drawing.Point(211, 97);
            this.RadioGroupBuzzerMode.Name = "RadioGroupBuzzerMode";
            this.RadioGroupBuzzerMode.Properties.AllowFocused = false;
            this.RadioGroupBuzzerMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioGroupBuzzerMode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.RadioGroupBuzzerMode.Properties.Appearance.Options.UseBackColor = true;
            this.RadioGroupBuzzerMode.Properties.Appearance.Options.UseFont = true;
            this.RadioGroupBuzzerMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioGroupBuzzerMode.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Single"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Double"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Triple")});
            this.RadioGroupBuzzerMode.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.RadioGroupBuzzerMode.Size = new System.Drawing.Size(102, 74);
            this.RadioGroupBuzzerMode.TabIndex = 1177;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(212, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 15);
            this.labelControl2.TabIndex = 1176;
            this.labelControl2.Text = "Mode:";
            // 
            // ButtonSetLEDs
            // 
            this.ButtonSetLEDs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSetLEDs.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonSetLEDs.Appearance.Options.UseFont = true;
            this.ButtonSetLEDs.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonSetLEDs.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonSetLEDs.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonSetLEDs.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonSetLEDs.Location = new System.Drawing.Point(15, 204);
            this.ButtonSetLEDs.Name = "ButtonSetLEDs";
            this.ButtonSetLEDs.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSetLEDs.Size = new System.Drawing.Size(170, 25);
            this.ButtonSetLEDs.TabIndex = 22;
            this.ButtonSetLEDs.Text = "Set LEDs";
            this.ButtonSetLEDs.Click += new System.EventHandler(this.ButtonSetLEDs_Click);
            // 
            // RadioGroupLEDsRed
            // 
            this.RadioGroupLEDsRed.Location = new System.Drawing.Point(111, 97);
            this.RadioGroupLEDsRed.Name = "RadioGroupLEDsRed";
            this.RadioGroupLEDsRed.Properties.AllowFocused = false;
            this.RadioGroupLEDsRed.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioGroupLEDsRed.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.RadioGroupLEDsRed.Properties.Appearance.Options.UseBackColor = true;
            this.RadioGroupLEDsRed.Properties.Appearance.Options.UseFont = true;
            this.RadioGroupLEDsRed.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioGroupLEDsRed.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Off"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "On"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Blink Fast"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Blink Slow")});
            this.RadioGroupLEDsRed.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.RadioGroupLEDsRed.Size = new System.Drawing.Size(74, 96);
            this.RadioGroupLEDsRed.TabIndex = 1175;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(112, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 15);
            this.labelControl1.TabIndex = 1174;
            this.labelControl1.Text = "Red:";
            // 
            // RadioGroupLEDsGreen
            // 
            this.RadioGroupLEDsGreen.Location = new System.Drawing.Point(14, 97);
            this.RadioGroupLEDsGreen.Name = "RadioGroupLEDsGreen";
            this.RadioGroupLEDsGreen.Properties.AllowFocused = false;
            this.RadioGroupLEDsGreen.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioGroupLEDsGreen.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.RadioGroupLEDsGreen.Properties.Appearance.Options.UseBackColor = true;
            this.RadioGroupLEDsGreen.Properties.Appearance.Options.UseFont = true;
            this.RadioGroupLEDsGreen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioGroupLEDsGreen.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Off"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "On"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Blink Fast"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Blink Slow")});
            this.RadioGroupLEDsGreen.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.RadioGroupLEDsGreen.Size = new System.Drawing.Size(91, 96);
            this.RadioGroupLEDsGreen.TabIndex = 1173;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 72);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 15);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Green:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 40);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 15);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "LED Colours";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 4";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 4";
            // 
            // GroupConsoleIds
            // 
            this.GroupConsoleIds.Controls.Add(this.ButtonSetPSID);
            this.GroupConsoleIds.Controls.Add(this.ButtonSetIDPS);
            this.GroupConsoleIds.Controls.Add(this.TextBoxPSID);
            this.GroupConsoleIds.Controls.Add(this.TextBoxIDPS);
            this.GroupConsoleIds.Controls.Add(this.LabelHeaderPSID);
            this.GroupConsoleIds.Controls.Add(this.LabelHeaderIDPS);
            this.GroupConsoleIds.Location = new System.Drawing.Point(12, 266);
            this.GroupConsoleIds.Name = "GroupConsoleIds";
            this.GroupConsoleIds.Padding = new System.Windows.Forms.Padding(12);
            this.GroupConsoleIds.Size = new System.Drawing.Size(681, 111);
            this.GroupConsoleIds.TabIndex = 14;
            this.GroupConsoleIds.Text = "Console IDs";
            // 
            // ButtonSetPSID
            // 
            this.ButtonSetPSID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonSetPSID.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonSetPSID.Appearance.Options.UseFont = true;
            this.ButtonSetPSID.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonSetPSID.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonSetPSID.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonSetPSID.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonSetPSID.Location = new System.Drawing.Point(592, 72);
            this.ButtonSetPSID.Name = "ButtonSetPSID";
            this.ButtonSetPSID.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSetPSID.Size = new System.Drawing.Size(73, 22);
            this.ButtonSetPSID.TabIndex = 10;
            this.ButtonSetPSID.Text = "Set";
            this.ButtonSetPSID.Click += new System.EventHandler(this.ButtonSetPSID_Click);
            // 
            // ButtonSetIDPS
            // 
            this.ButtonSetIDPS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonSetIDPS.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonSetIDPS.Appearance.Options.UseFont = true;
            this.ButtonSetIDPS.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonSetIDPS.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonSetIDPS.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonSetIDPS.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonSetIDPS.Location = new System.Drawing.Point(592, 37);
            this.ButtonSetIDPS.Name = "ButtonSetIDPS";
            this.ButtonSetIDPS.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSetIDPS.Size = new System.Drawing.Size(73, 22);
            this.ButtonSetIDPS.TabIndex = 9;
            this.ButtonSetIDPS.Text = "Set";
            this.ButtonSetIDPS.Click += new System.EventHandler(this.ButtonSetIDPS_Click);
            // 
            // TextBoxPSID
            // 
            this.TextBoxPSID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPSID.Location = new System.Drawing.Point(61, 72);
            this.TextBoxPSID.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.TextBoxPSID.Name = "TextBoxPSID";
            this.TextBoxPSID.Properties.AllowFocused = false;
            this.TextBoxPSID.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextBoxPSID.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPSID.Properties.Appearance.Options.UseFont = true;
            this.TextBoxPSID.Properties.BeepOnError = true;
            this.TextBoxPSID.Properties.NullValuePrompt = "None";
            this.TextBoxPSID.Properties.UseMaskAsDisplayFormat = true;
            this.TextBoxPSID.Size = new System.Drawing.Size(522, 22);
            this.TextBoxPSID.TabIndex = 5;
            // 
            // TextBoxIDPS
            // 
            this.TextBoxIDPS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxIDPS.Location = new System.Drawing.Point(61, 37);
            this.TextBoxIDPS.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.TextBoxIDPS.Name = "TextBoxIDPS";
            this.TextBoxIDPS.Properties.AllowFocused = false;
            this.TextBoxIDPS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextBoxIDPS.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxIDPS.Properties.Appearance.Options.UseFont = true;
            this.TextBoxIDPS.Properties.BeepOnError = true;
            this.TextBoxIDPS.Properties.NullValuePrompt = "None";
            this.TextBoxIDPS.Properties.UseMaskAsDisplayFormat = true;
            this.TextBoxIDPS.Size = new System.Drawing.Size(522, 22);
            this.TextBoxIDPS.TabIndex = 4;
            // 
            // LabelHeaderPSID
            // 
            this.LabelHeaderPSID.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderPSID.Appearance.Options.UseFont = true;
            this.LabelHeaderPSID.Location = new System.Drawing.Point(15, 75);
            this.LabelHeaderPSID.Name = "LabelHeaderPSID";
            this.LabelHeaderPSID.Size = new System.Drawing.Size(27, 15);
            this.LabelHeaderPSID.TabIndex = 6;
            this.LabelHeaderPSID.Text = "PSID:";
            // 
            // LabelHeaderIDPS
            // 
            this.LabelHeaderIDPS.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderIDPS.Appearance.Options.UseFont = true;
            this.LabelHeaderIDPS.Location = new System.Drawing.Point(15, 40);
            this.LabelHeaderIDPS.Name = "LabelHeaderIDPS";
            this.LabelHeaderIDPS.Size = new System.Drawing.Size(27, 15);
            this.LabelHeaderIDPS.TabIndex = 4;
            this.LabelHeaderIDPS.Text = "IDPS:";
            // 
            // ConsoleManager
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 414);
            this.Controls.Add(this.GroupConsoleIds);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GroupGameSave);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ConsoleManager.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsoleManager";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Console Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameSaveResigner_FormClosing);
            this.Load += new System.EventHandler(this.ConsoleManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PopupImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGameSave)).EndInit();
            this.GroupGameSave.ResumeLayout(false);
            this.GroupGameSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupBuzzerMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupLEDsRed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupLEDsGreen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupConsoleIds)).EndInit();
            this.GroupConsoleIds.ResumeLayout(false);
            this.GroupConsoleIds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPSID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxIDPS.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelHeaderFirmwareVersion;
        private LabelControl LabelHeaderTempRSX;
        private LabelControl LabelHeaderTempCELL;
        private DevExpress.XtraBars.PopupMenu PopupMenuFile;
        private DevExpress.XtraBars.PopupMenu PopupImage;
        private DevExpress.XtraBars.PopupMenu PopupMenuProfile;
        private GroupControl groupControl1;
        private LabelControl labelControl4;
        private LabelControl labelControl5;
        private GroupControl GroupGameSave;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.BarButtonItem MenuButtonFile;
        private DevExpress.XtraBars.BarButtonItem MenuButtonProfile;
        private DevExpress.XtraBars.Bar MenuStatus;
        private DevExpress.XtraBars.BarStaticItem LabelHeaderStatus;
        private DevExpress.XtraBars.BarStaticItem LabelStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private GroupControl GroupConsoleIds;
        private TextEdit TextBoxPSID;
        private TextEdit TextBoxIDPS;
        private LabelControl LabelHeaderPSID;
        private LabelControl LabelHeaderIDPS;
        private DevExpress.XtraBars.BarButtonItem MenuItemLoadFile;
        private DevExpress.XtraBars.BarButtonItem MenuItemSaveFile;
        private DevExpress.XtraBars.BarButtonItem MenuItemReplace;
        private DevExpress.XtraBars.BarButtonItem MenuItemExtract;
        private DevExpress.XtraBars.BarButtonItem MenuItemAddProfileDetails;
        private DevExpress.XtraBars.BarButtonItem MenuItemAddProfileFromConsole;
        private DevExpress.XtraBars.BarButtonItem MenuItemAddExistingProfile;
        private DevExpress.XtraBars.BarSubItem MenuItemSaveToDevice;
        private DevExpress.XtraBars.BarButtonItem MenuItemNoDeviceFound;
        private SimpleButton ButtonSetPSID;
        private SimpleButton ButtonSetIDPS;
        private LabelControl LabelFirmwareVersion;
        private SimpleButton ButtonRefreshDetails;
        private LabelControl labelControl7;
        private LabelControl LabelTempRSX;
        private LabelControl LabelTempCELL;
        private LabelControl LabelFirmwareType;
        private LabelControl labelControl12;
        private LabelControl LabelCoreVersion;
        private LabelControl labelControl14;
        private RadioGroup RadioGroupLEDsGreen;
        private SimpleButton ButtonSetLEDs;
        private RadioGroup RadioGroupLEDsRed;
        private LabelControl labelControl1;
        private SimpleButton ButtonRingBuzzer;
        private LabelControl labelControl3;
        private RadioGroup RadioGroupBuzzerMode;
        private LabelControl labelControl2;
    }
}