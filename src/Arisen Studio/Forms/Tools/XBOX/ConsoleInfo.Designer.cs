
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Tools.XBOX
{
    partial class ConsoleInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleInfo));
            this.LabelHeaderTempCPU = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderTempGPU = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderIPAddress = new DevExpress.XtraEditors.LabelControl();
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
            this.LabelTempMB = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderTempMB = new DevExpress.XtraEditors.LabelControl();
            this.LabelTempRAM = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderTempRAM = new DevExpress.XtraEditors.LabelControl();
            this.LabelTitleID = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderTitleID = new DevExpress.XtraEditors.LabelControl();
            this.LabelKernel = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderKernel = new DevExpress.XtraEditors.LabelControl();
            this.LabelCPUKey = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderCPUKey = new DevExpress.XtraEditors.LabelControl();
            this.LabelTempGPU = new DevExpress.XtraEditors.LabelControl();
            this.LabelTempCPU = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonRefreshDetails = new DevExpress.XtraEditors.SimpleButton();
            this.LabelIPAddress = new DevExpress.XtraEditors.LabelControl();
            this.GroupLEDColors = new DevExpress.XtraEditors.GroupControl();
            this.RadioGroupLEDsBottomRight = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.RadioGroupLEDsBottomLeft = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonSetLEDs = new DevExpress.XtraEditors.SimpleButton();
            this.RadioGroupLEDsTopRight = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.RadioGroupLEDsTopLeft = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.GroupDiscFan = new DevExpress.XtraEditors.GroupControl();
            this.ButtonSetFanSpeed = new DevExpress.XtraEditors.SimpleButton();
            this.TrackBarFanSpeed = new DevExpress.XtraEditors.TrackBarControl();
            this.ButtonDiscTrayClose = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDiscTrayOpen = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PopupImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGameSave)).BeginInit();
            this.GroupGameSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupLEDColors)).BeginInit();
            this.GroupLEDColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupLEDsBottomRight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupLEDsBottomLeft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupLEDsTopRight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupLEDsTopLeft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupDiscFan)).BeginInit();
            this.GroupDiscFan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFanSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFanSpeed.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeaderTempCPU
            // 
            this.LabelHeaderTempCPU.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTempCPU.Appearance.Options.UseFont = true;
            this.LabelHeaderTempCPU.Location = new System.Drawing.Point(455, 66);
            this.LabelHeaderTempCPU.Name = "LabelHeaderTempCPU";
            this.LabelHeaderTempCPU.Size = new System.Drawing.Size(26, 15);
            this.LabelHeaderTempCPU.TabIndex = 12;
            this.LabelHeaderTempCPU.Text = "CPU:";
            // 
            // LabelHeaderTempGPU
            // 
            this.LabelHeaderTempGPU.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTempGPU.Appearance.Options.UseFont = true;
            this.LabelHeaderTempGPU.Location = new System.Drawing.Point(455, 98);
            this.LabelHeaderTempGPU.Name = "LabelHeaderTempGPU";
            this.LabelHeaderTempGPU.Size = new System.Drawing.Size(26, 15);
            this.LabelHeaderTempGPU.TabIndex = 8;
            this.LabelHeaderTempGPU.Text = "GPU:";
            // 
            // LabelHeaderIPAddress
            // 
            this.LabelHeaderIPAddress.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderIPAddress.Appearance.Options.UseFont = true;
            this.LabelHeaderIPAddress.Location = new System.Drawing.Point(15, 34);
            this.LabelHeaderIPAddress.Name = "LabelHeaderIPAddress";
            this.LabelHeaderIPAddress.Size = new System.Drawing.Size(58, 15);
            this.LabelHeaderIPAddress.TabIndex = 4;
            this.LabelHeaderIPAddress.Text = "IP Address:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(702, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 499);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(702, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 499);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(702, 0);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 499);
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
            this.GroupGameSave.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.GroupGameSave.Controls.Add(this.LabelTempMB);
            this.GroupGameSave.Controls.Add(this.LabelHeaderTempMB);
            this.GroupGameSave.Controls.Add(this.LabelTempRAM);
            this.GroupGameSave.Controls.Add(this.LabelHeaderTempRAM);
            this.GroupGameSave.Controls.Add(this.LabelTitleID);
            this.GroupGameSave.Controls.Add(this.LabelHeaderTitleID);
            this.GroupGameSave.Controls.Add(this.LabelKernel);
            this.GroupGameSave.Controls.Add(this.LabelHeaderKernel);
            this.GroupGameSave.Controls.Add(this.LabelCPUKey);
            this.GroupGameSave.Controls.Add(this.LabelHeaderCPUKey);
            this.GroupGameSave.Controls.Add(this.LabelTempGPU);
            this.GroupGameSave.Controls.Add(this.LabelTempCPU);
            this.GroupGameSave.Controls.Add(this.labelControl7);
            this.GroupGameSave.Controls.Add(this.ButtonRefreshDetails);
            this.GroupGameSave.Controls.Add(this.LabelIPAddress);
            this.GroupGameSave.Controls.Add(this.LabelHeaderTempCPU);
            this.GroupGameSave.Controls.Add(this.LabelHeaderTempGPU);
            this.GroupGameSave.Controls.Add(this.LabelHeaderIPAddress);
            this.GroupGameSave.Location = new System.Drawing.Point(12, 12);
            this.GroupGameSave.Name = "GroupGameSave";
            this.GroupGameSave.Padding = new System.Windows.Forms.Padding(12);
            this.GroupGameSave.Size = new System.Drawing.Size(678, 244);
            this.GroupGameSave.TabIndex = 11;
            this.GroupGameSave.Text = "Details";
            // 
            // LabelTempMB
            // 
            this.LabelTempMB.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTempMB.Appearance.Options.UseFont = true;
            this.LabelTempMB.Location = new System.Drawing.Point(497, 163);
            this.LabelTempMB.Name = "LabelTempMB";
            this.LabelTempMB.Size = new System.Drawing.Size(5, 15);
            this.LabelTempMB.TabIndex = 27;
            this.LabelTempMB.Text = "-";
            // 
            // LabelHeaderTempMB
            // 
            this.LabelHeaderTempMB.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTempMB.Appearance.Options.UseFont = true;
            this.LabelHeaderTempMB.Location = new System.Drawing.Point(455, 163);
            this.LabelHeaderTempMB.Name = "LabelHeaderTempMB";
            this.LabelHeaderTempMB.Size = new System.Drawing.Size(21, 15);
            this.LabelHeaderTempMB.TabIndex = 26;
            this.LabelHeaderTempMB.Text = "MB:";
            // 
            // LabelTempRAM
            // 
            this.LabelTempRAM.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTempRAM.Appearance.Options.UseFont = true;
            this.LabelTempRAM.Location = new System.Drawing.Point(497, 130);
            this.LabelTempRAM.Name = "LabelTempRAM";
            this.LabelTempRAM.Size = new System.Drawing.Size(5, 15);
            this.LabelTempRAM.TabIndex = 25;
            this.LabelTempRAM.Text = "-";
            // 
            // LabelHeaderTempRAM
            // 
            this.LabelHeaderTempRAM.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTempRAM.Appearance.Options.UseFont = true;
            this.LabelHeaderTempRAM.Location = new System.Drawing.Point(455, 130);
            this.LabelHeaderTempRAM.Name = "LabelHeaderTempRAM";
            this.LabelHeaderTempRAM.Size = new System.Drawing.Size(29, 15);
            this.LabelHeaderTempRAM.TabIndex = 24;
            this.LabelHeaderTempRAM.Text = "RAM:";
            // 
            // LabelTitleID
            // 
            this.LabelTitleID.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTitleID.Appearance.Options.UseFont = true;
            this.LabelTitleID.Location = new System.Drawing.Point(139, 130);
            this.LabelTitleID.Name = "LabelTitleID";
            this.LabelTitleID.Size = new System.Drawing.Size(5, 15);
            this.LabelTitleID.TabIndex = 23;
            this.LabelTitleID.Text = "-";
            // 
            // LabelHeaderTitleID
            // 
            this.LabelHeaderTitleID.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTitleID.Appearance.Options.UseFont = true;
            this.LabelHeaderTitleID.Location = new System.Drawing.Point(15, 130);
            this.LabelHeaderTitleID.Name = "LabelHeaderTitleID";
            this.LabelHeaderTitleID.Size = new System.Drawing.Size(39, 15);
            this.LabelHeaderTitleID.TabIndex = 22;
            this.LabelHeaderTitleID.Text = "Title ID:";
            // 
            // LabelKernel
            // 
            this.LabelKernel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelKernel.Appearance.Options.UseFont = true;
            this.LabelKernel.Location = new System.Drawing.Point(139, 98);
            this.LabelKernel.Name = "LabelKernel";
            this.LabelKernel.Size = new System.Drawing.Size(5, 15);
            this.LabelKernel.TabIndex = 21;
            this.LabelKernel.Text = "-";
            // 
            // LabelHeaderKernel
            // 
            this.LabelHeaderKernel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderKernel.Appearance.Options.UseFont = true;
            this.LabelHeaderKernel.Location = new System.Drawing.Point(15, 98);
            this.LabelHeaderKernel.Name = "LabelHeaderKernel";
            this.LabelHeaderKernel.Size = new System.Drawing.Size(36, 15);
            this.LabelHeaderKernel.TabIndex = 20;
            this.LabelHeaderKernel.Text = "Kernel:";
            // 
            // LabelCPUKey
            // 
            this.LabelCPUKey.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelCPUKey.Appearance.Options.UseFont = true;
            this.LabelCPUKey.Location = new System.Drawing.Point(139, 66);
            this.LabelCPUKey.Name = "LabelCPUKey";
            this.LabelCPUKey.Size = new System.Drawing.Size(5, 15);
            this.LabelCPUKey.TabIndex = 19;
            this.LabelCPUKey.Text = "-";
            // 
            // LabelHeaderCPUKey
            // 
            this.LabelHeaderCPUKey.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderCPUKey.Appearance.Options.UseFont = true;
            this.LabelHeaderCPUKey.Location = new System.Drawing.Point(15, 66);
            this.LabelHeaderCPUKey.Name = "LabelHeaderCPUKey";
            this.LabelHeaderCPUKey.Size = new System.Drawing.Size(48, 15);
            this.LabelHeaderCPUKey.TabIndex = 18;
            this.LabelHeaderCPUKey.Text = "CPU Key:";
            // 
            // LabelTempGPU
            // 
            this.LabelTempGPU.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTempGPU.Appearance.Options.UseFont = true;
            this.LabelTempGPU.Location = new System.Drawing.Point(497, 98);
            this.LabelTempGPU.Name = "LabelTempGPU";
            this.LabelTempGPU.Size = new System.Drawing.Size(5, 15);
            this.LabelTempGPU.TabIndex = 17;
            this.LabelTempGPU.Text = "-";
            // 
            // LabelTempCPU
            // 
            this.LabelTempCPU.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTempCPU.Appearance.Options.UseFont = true;
            this.LabelTempCPU.Location = new System.Drawing.Point(497, 66);
            this.LabelTempCPU.Name = "LabelTempCPU";
            this.LabelTempCPU.Size = new System.Drawing.Size(5, 15);
            this.LabelTempCPU.TabIndex = 16;
            this.LabelTempCPU.Text = "-";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(455, 34);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 15);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Temperatures";
            // 
            // ButtonRefreshDetails
            // 
            this.ButtonRefreshDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRefreshDetails.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonRefreshDetails.Appearance.Options.UseFont = true;
            this.ButtonRefreshDetails.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonRefreshDetails.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonRefreshDetails.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonRefreshDetails.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonRefreshDetails.Location = new System.Drawing.Point(15, 203);
            this.ButtonRefreshDetails.Name = "ButtonRefreshDetails";
            this.ButtonRefreshDetails.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRefreshDetails.Size = new System.Drawing.Size(648, 25);
            this.ButtonRefreshDetails.TabIndex = 1;
            this.ButtonRefreshDetails.Text = "Refresh";
            this.ButtonRefreshDetails.Click += new System.EventHandler(this.ButtonRefreshDetails_Click);
            // 
            // LabelIPAddress
            // 
            this.LabelIPAddress.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelIPAddress.Appearance.Options.UseFont = true;
            this.LabelIPAddress.Location = new System.Drawing.Point(139, 34);
            this.LabelIPAddress.Name = "LabelIPAddress";
            this.LabelIPAddress.Size = new System.Drawing.Size(5, 15);
            this.LabelIPAddress.TabIndex = 13;
            this.LabelIPAddress.Text = "-";
            // 
            // GroupLEDColors
            // 
            this.GroupLEDColors.Controls.Add(this.RadioGroupLEDsBottomRight);
            this.GroupLEDColors.Controls.Add(this.labelControl8);
            this.GroupLEDColors.Controls.Add(this.RadioGroupLEDsBottomLeft);
            this.GroupLEDColors.Controls.Add(this.labelControl6);
            this.GroupLEDColors.Controls.Add(this.ButtonSetLEDs);
            this.GroupLEDColors.Controls.Add(this.RadioGroupLEDsTopRight);
            this.GroupLEDColors.Controls.Add(this.labelControl1);
            this.GroupLEDColors.Controls.Add(this.RadioGroupLEDsTopLeft);
            this.GroupLEDColors.Controls.Add(this.labelControl4);
            this.GroupLEDColors.Location = new System.Drawing.Point(12, 264);
            this.GroupLEDColors.Name = "GroupLEDColors";
            this.GroupLEDColors.Padding = new System.Windows.Forms.Padding(12);
            this.GroupLEDColors.Size = new System.Drawing.Size(385, 218);
            this.GroupLEDColors.TabIndex = 13;
            this.GroupLEDColors.Text = "LED Colors";
            // 
            // RadioGroupLEDsBottomRight
            // 
            this.RadioGroupLEDsBottomRight.Location = new System.Drawing.Point(293, 59);
            this.RadioGroupLEDsBottomRight.Name = "RadioGroupLEDsBottomRight";
            this.RadioGroupLEDsBottomRight.Properties.AllowFocused = false;
            this.RadioGroupLEDsBottomRight.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioGroupLEDsBottomRight.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.RadioGroupLEDsBottomRight.Properties.Appearance.Options.UseBackColor = true;
            this.RadioGroupLEDsBottomRight.Properties.Appearance.Options.UseFont = true;
            this.RadioGroupLEDsBottomRight.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioGroupLEDsBottomRight.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Green"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Orange"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Red"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Off")});
            this.RadioGroupLEDsBottomRight.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.RadioGroupLEDsBottomRight.Size = new System.Drawing.Size(74, 96);
            this.RadioGroupLEDsBottomRight.TabIndex = 1183;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(294, 34);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(74, 15);
            this.labelControl8.TabIndex = 1182;
            this.labelControl8.Text = "Bottom Right:";
            // 
            // RadioGroupLEDsBottomLeft
            // 
            this.RadioGroupLEDsBottomLeft.Location = new System.Drawing.Point(201, 59);
            this.RadioGroupLEDsBottomLeft.Name = "RadioGroupLEDsBottomLeft";
            this.RadioGroupLEDsBottomLeft.Properties.AllowFocused = false;
            this.RadioGroupLEDsBottomLeft.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioGroupLEDsBottomLeft.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.RadioGroupLEDsBottomLeft.Properties.Appearance.Options.UseBackColor = true;
            this.RadioGroupLEDsBottomLeft.Properties.Appearance.Options.UseFont = true;
            this.RadioGroupLEDsBottomLeft.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioGroupLEDsBottomLeft.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Green"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Orange"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Red"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Off")});
            this.RadioGroupLEDsBottomLeft.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.RadioGroupLEDsBottomLeft.Size = new System.Drawing.Size(74, 96);
            this.RadioGroupLEDsBottomLeft.TabIndex = 1181;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(202, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 15);
            this.labelControl6.TabIndex = 1180;
            this.labelControl6.Text = "Bottom Left:";
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
            this.ButtonSetLEDs.Location = new System.Drawing.Point(15, 177);
            this.ButtonSetLEDs.Name = "ButtonSetLEDs";
            this.ButtonSetLEDs.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSetLEDs.Size = new System.Drawing.Size(355, 25);
            this.ButtonSetLEDs.TabIndex = 22;
            this.ButtonSetLEDs.Text = "Set LEDs";
            this.ButtonSetLEDs.Click += new System.EventHandler(this.ButtonSetLEDs_Click);
            // 
            // RadioGroupLEDsTopRight
            // 
            this.RadioGroupLEDsTopRight.Location = new System.Drawing.Point(108, 59);
            this.RadioGroupLEDsTopRight.Name = "RadioGroupLEDsTopRight";
            this.RadioGroupLEDsTopRight.Properties.AllowFocused = false;
            this.RadioGroupLEDsTopRight.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioGroupLEDsTopRight.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.RadioGroupLEDsTopRight.Properties.Appearance.Options.UseBackColor = true;
            this.RadioGroupLEDsTopRight.Properties.Appearance.Options.UseFont = true;
            this.RadioGroupLEDsTopRight.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioGroupLEDsTopRight.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Green"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Orange"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Red"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Off")});
            this.RadioGroupLEDsTopRight.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.RadioGroupLEDsTopRight.Size = new System.Drawing.Size(74, 96);
            this.RadioGroupLEDsTopRight.TabIndex = 1175;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(109, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 15);
            this.labelControl1.TabIndex = 1174;
            this.labelControl1.Text = "Top Right:";
            // 
            // RadioGroupLEDsTopLeft
            // 
            this.RadioGroupLEDsTopLeft.Location = new System.Drawing.Point(14, 59);
            this.RadioGroupLEDsTopLeft.Name = "RadioGroupLEDsTopLeft";
            this.RadioGroupLEDsTopLeft.Properties.AllowFocused = false;
            this.RadioGroupLEDsTopLeft.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioGroupLEDsTopLeft.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.RadioGroupLEDsTopLeft.Properties.Appearance.Options.UseBackColor = true;
            this.RadioGroupLEDsTopLeft.Properties.Appearance.Options.UseFont = true;
            this.RadioGroupLEDsTopLeft.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioGroupLEDsTopLeft.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Green"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Orange"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Red"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Off")});
            this.RadioGroupLEDsTopLeft.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.RadioGroupLEDsTopLeft.Size = new System.Drawing.Size(74, 96);
            this.RadioGroupLEDsTopLeft.TabIndex = 1173;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 15);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Top Left:";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 4";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 4";
            // 
            // GroupDiscFan
            // 
            this.GroupDiscFan.Controls.Add(this.ButtonSetFanSpeed);
            this.GroupDiscFan.Controls.Add(this.TrackBarFanSpeed);
            this.GroupDiscFan.Controls.Add(this.ButtonDiscTrayClose);
            this.GroupDiscFan.Controls.Add(this.ButtonDiscTrayOpen);
            this.GroupDiscFan.Controls.Add(this.labelControl3);
            this.GroupDiscFan.Controls.Add(this.labelControl10);
            this.GroupDiscFan.Location = new System.Drawing.Point(405, 264);
            this.GroupDiscFan.Name = "GroupDiscFan";
            this.GroupDiscFan.Padding = new System.Windows.Forms.Padding(12);
            this.GroupDiscFan.Size = new System.Drawing.Size(285, 218);
            this.GroupDiscFan.TabIndex = 19;
            this.GroupDiscFan.Text = "Disc Tray && Fan Speed";
            // 
            // ButtonSetFanSpeed
            // 
            this.ButtonSetFanSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSetFanSpeed.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonSetFanSpeed.Appearance.Options.UseFont = true;
            this.ButtonSetFanSpeed.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonSetFanSpeed.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonSetFanSpeed.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonSetFanSpeed.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonSetFanSpeed.Location = new System.Drawing.Point(123, 97);
            this.ButtonSetFanSpeed.Name = "ButtonSetFanSpeed";
            this.ButtonSetFanSpeed.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSetFanSpeed.Size = new System.Drawing.Size(146, 25);
            this.ButtonSetFanSpeed.TabIndex = 1179;
            this.ButtonSetFanSpeed.Text = "Set Fan Speed";
            this.ButtonSetFanSpeed.Click += new System.EventHandler(this.ButtonSetFanSpeed_Click);
            // 
            // TrackBarFanSpeed
            // 
            this.TrackBarFanSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackBarFanSpeed.EditValue = null;
            this.TrackBarFanSpeed.Location = new System.Drawing.Point(123, 66);
            this.TrackBarFanSpeed.MenuManager = this.BarManager;
            this.TrackBarFanSpeed.Name = "TrackBarFanSpeed";
            this.TrackBarFanSpeed.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.TrackBarFanSpeed.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TrackBarFanSpeed.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBarFanSpeed.Size = new System.Drawing.Size(146, 45);
            this.TrackBarFanSpeed.TabIndex = 1182;
            // 
            // ButtonDiscTrayClose
            // 
            this.ButtonDiscTrayClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonDiscTrayClose.Appearance.Options.UseFont = true;
            this.ButtonDiscTrayClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonDiscTrayClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonDiscTrayClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonDiscTrayClose.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonDiscTrayClose.Location = new System.Drawing.Point(15, 97);
            this.ButtonDiscTrayClose.Name = "ButtonDiscTrayClose";
            this.ButtonDiscTrayClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDiscTrayClose.Size = new System.Drawing.Size(94, 25);
            this.ButtonDiscTrayClose.TabIndex = 1181;
            this.ButtonDiscTrayClose.Text = "Close";
            this.ButtonDiscTrayClose.Click += new System.EventHandler(this.ButtonDiscTrayClose_Click);
            // 
            // ButtonDiscTrayOpen
            // 
            this.ButtonDiscTrayOpen.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonDiscTrayOpen.Appearance.Options.UseFont = true;
            this.ButtonDiscTrayOpen.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonDiscTrayOpen.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonDiscTrayOpen.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonDiscTrayOpen.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonDiscTrayOpen.Location = new System.Drawing.Point(15, 66);
            this.ButtonDiscTrayOpen.Name = "ButtonDiscTrayOpen";
            this.ButtonDiscTrayOpen.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDiscTrayOpen.Size = new System.Drawing.Size(94, 25);
            this.ButtonDiscTrayOpen.TabIndex = 1180;
            this.ButtonDiscTrayOpen.Text = "Open";
            this.ButtonDiscTrayOpen.Click += new System.EventHandler(this.ButtonDiscTrayOpen_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(123, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 15);
            this.labelControl3.TabIndex = 1178;
            this.labelControl3.Text = "Fan Speed";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(15, 34);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(50, 15);
            this.labelControl10.TabIndex = 4;
            this.labelControl10.Text = "Disc Tray";
            // 
            // ConsoleInfo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 525);
            this.Controls.Add(this.GroupDiscFan);
            this.Controls.Add(this.GroupLEDColors);
            this.Controls.Add(this.GroupGameSave);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ConsoleInfo.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsoleInfo";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Console Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsoleInfo_FormClosing);
            this.Load += new System.EventHandler(this.ConsoleInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PopupImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGameSave)).EndInit();
            this.GroupGameSave.ResumeLayout(false);
            this.GroupGameSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupLEDColors)).EndInit();
            this.GroupLEDColors.ResumeLayout(false);
            this.GroupLEDColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupLEDsBottomRight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupLEDsBottomLeft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupLEDsTopRight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupLEDsTopLeft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupDiscFan)).EndInit();
            this.GroupDiscFan.ResumeLayout(false);
            this.GroupDiscFan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFanSpeed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFanSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelHeaderIPAddress;
        private LabelControl LabelHeaderTempGPU;
        private LabelControl LabelHeaderTempCPU;
        private DevExpress.XtraBars.PopupMenu PopupMenuFile;
        private DevExpress.XtraBars.PopupMenu PopupImage;
        private DevExpress.XtraBars.PopupMenu PopupMenuProfile;
        private GroupControl GroupLEDColors;
        private LabelControl labelControl4;
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
        private DevExpress.XtraBars.BarButtonItem MenuItemLoadFile;
        private DevExpress.XtraBars.BarButtonItem MenuItemSaveFile;
        private DevExpress.XtraBars.BarButtonItem MenuItemReplace;
        private DevExpress.XtraBars.BarButtonItem MenuItemExtract;
        private DevExpress.XtraBars.BarButtonItem MenuItemAddProfileDetails;
        private DevExpress.XtraBars.BarButtonItem MenuItemAddProfileFromConsole;
        private DevExpress.XtraBars.BarButtonItem MenuItemAddExistingProfile;
        private DevExpress.XtraBars.BarSubItem MenuItemSaveToDevice;
        private DevExpress.XtraBars.BarButtonItem MenuItemNoDeviceFound;
        private LabelControl LabelIPAddress;
        private SimpleButton ButtonRefreshDetails;
        private LabelControl labelControl7;
        private LabelControl LabelTempGPU;
        private LabelControl LabelTempCPU;
        private LabelControl LabelCPUKey;
        private LabelControl LabelHeaderCPUKey;
        private LabelControl LabelKernel;
        private LabelControl LabelHeaderKernel;
        private RadioGroup RadioGroupLEDsTopLeft;
        private SimpleButton ButtonSetLEDs;
        private RadioGroup RadioGroupLEDsTopRight;
        private LabelControl labelControl1;
        private LabelControl LabelTempRAM;
        private LabelControl LabelHeaderTempRAM;
        private LabelControl LabelTitleID;
        private LabelControl LabelHeaderTitleID;
        private LabelControl LabelTempMB;
        private LabelControl LabelHeaderTempMB;
        private RadioGroup RadioGroupLEDsBottomRight;
        private LabelControl labelControl8;
        private RadioGroup RadioGroupLEDsBottomLeft;
        private LabelControl labelControl6;
        private GroupControl GroupDiscFan;
        private SimpleButton ButtonSetFanSpeed;
        private TrackBarControl TrackBarFanSpeed;
        private SimpleButton ButtonDiscTrayClose;
        private SimpleButton ButtonDiscTrayOpen;
        private LabelControl labelControl3;
        private LabelControl labelControl10;
    }
}