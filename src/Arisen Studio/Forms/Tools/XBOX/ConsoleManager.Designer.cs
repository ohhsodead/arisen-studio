
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Tools.XBOX
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
            this.GroupDetails = new DevExpress.XtraEditors.GroupControl();
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
            this.LabelHeaderTemperatures = new DevExpress.XtraEditors.LabelControl();
            this.ButtonRefreshDetails = new DevExpress.XtraEditors.SimpleButton();
            this.LabelIPAddress = new DevExpress.XtraEditors.LabelControl();
            this.GroupLEDColors = new DevExpress.XtraEditors.GroupControl();
            this.RadioGroupLEDsBottomRight = new DevExpress.XtraEditors.RadioGroup();
            this.LabelHeaderLedBottomRight = new DevExpress.XtraEditors.LabelControl();
            this.RadioGroupLEDsBottomLeft = new DevExpress.XtraEditors.RadioGroup();
            this.LabelHeaderLedBottomLeft = new DevExpress.XtraEditors.LabelControl();
            this.ButtonSetLEDs = new DevExpress.XtraEditors.SimpleButton();
            this.RadioGroupLEDsTopRight = new DevExpress.XtraEditors.RadioGroup();
            this.LabelHeaderLedTopRight = new DevExpress.XtraEditors.LabelControl();
            this.RadioGroupLEDsTopLeft = new DevExpress.XtraEditors.RadioGroup();
            this.LabelHeaderLedTopLeft = new DevExpress.XtraEditors.LabelControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.GroupDiscFan = new DevExpress.XtraEditors.GroupControl();
            this.ButtonSetFanSpeed = new DevExpress.XtraEditors.SimpleButton();
            this.TrackBarFanSpeed = new DevExpress.XtraEditors.TrackBarControl();
            this.ButtonDiscTrayClose = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDiscTrayOpen = new DevExpress.XtraEditors.SimpleButton();
            this.LabelHeaderFanSpeed = new DevExpress.XtraEditors.LabelControl();
            this.LabelHeaderDiscTray = new DevExpress.XtraEditors.LabelControl();
            this.GroupNeighborhoodEditor = new DevExpress.XtraEditors.GroupControl();
            this.TextBoxXboxName = new DevExpress.XtraEditors.ButtonEdit();
            this.LabelHeaderIconColor = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxXboxIcon = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelHeaderName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PopupImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupDetails)).BeginInit();
            this.GroupDetails.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.GroupNeighborhoodEditor)).BeginInit();
            this.GroupNeighborhoodEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxXboxName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxXboxIcon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeaderTempCPU
            // 
            this.LabelHeaderTempCPU.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTempCPU.Appearance.Options.UseFont = true;
            this.LabelHeaderTempCPU.Location = new System.Drawing.Point(446, 61);
            this.LabelHeaderTempCPU.Name = "LabelHeaderTempCPU";
            this.LabelHeaderTempCPU.Size = new System.Drawing.Size(26, 15);
            this.LabelHeaderTempCPU.TabIndex = 12;
            this.LabelHeaderTempCPU.Text = "CPU:";
            // 
            // LabelHeaderTempGPU
            // 
            this.LabelHeaderTempGPU.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTempGPU.Appearance.Options.UseFont = true;
            this.LabelHeaderTempGPU.Location = new System.Drawing.Point(446, 93);
            this.LabelHeaderTempGPU.Name = "LabelHeaderTempGPU";
            this.LabelHeaderTempGPU.Size = new System.Drawing.Size(26, 15);
            this.LabelHeaderTempGPU.TabIndex = 8;
            this.LabelHeaderTempGPU.Text = "GPU:";
            // 
            // LabelHeaderIPAddress
            // 
            this.LabelHeaderIPAddress.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderIPAddress.Appearance.Options.UseFont = true;
            this.LabelHeaderIPAddress.Location = new System.Drawing.Point(10, 29);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 495);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(702, 29);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 495);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(702, 0);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 495);
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
            // GroupDetails
            // 
            this.GroupDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupDetails.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GroupDetails.AppearanceCaption.Options.UseFont = true;
            this.GroupDetails.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.GroupDetails.Controls.Add(this.LabelTempMB);
            this.GroupDetails.Controls.Add(this.LabelHeaderTempMB);
            this.GroupDetails.Controls.Add(this.LabelTempRAM);
            this.GroupDetails.Controls.Add(this.LabelHeaderTempRAM);
            this.GroupDetails.Controls.Add(this.LabelTitleID);
            this.GroupDetails.Controls.Add(this.LabelHeaderTitleID);
            this.GroupDetails.Controls.Add(this.LabelKernel);
            this.GroupDetails.Controls.Add(this.LabelHeaderKernel);
            this.GroupDetails.Controls.Add(this.LabelCPUKey);
            this.GroupDetails.Controls.Add(this.LabelHeaderCPUKey);
            this.GroupDetails.Controls.Add(this.LabelTempGPU);
            this.GroupDetails.Controls.Add(this.LabelTempCPU);
            this.GroupDetails.Controls.Add(this.LabelHeaderTemperatures);
            this.GroupDetails.Controls.Add(this.ButtonRefreshDetails);
            this.GroupDetails.Controls.Add(this.LabelIPAddress);
            this.GroupDetails.Controls.Add(this.LabelHeaderTempCPU);
            this.GroupDetails.Controls.Add(this.LabelHeaderTempGPU);
            this.GroupDetails.Controls.Add(this.LabelHeaderIPAddress);
            this.GroupDetails.Location = new System.Drawing.Point(12, 12);
            this.GroupDetails.Name = "GroupDetails";
            this.GroupDetails.Padding = new System.Windows.Forms.Padding(5);
            this.GroupDetails.Size = new System.Drawing.Size(678, 243);
            this.GroupDetails.TabIndex = 11;
            this.GroupDetails.Text = "System Details";
            // 
            // LabelTempMB
            // 
            this.LabelTempMB.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTempMB.Appearance.Options.UseFont = true;
            this.LabelTempMB.Location = new System.Drawing.Point(489, 158);
            this.LabelTempMB.Name = "LabelTempMB";
            this.LabelTempMB.Size = new System.Drawing.Size(5, 15);
            this.LabelTempMB.TabIndex = 27;
            this.LabelTempMB.Text = "-";
            // 
            // LabelHeaderTempMB
            // 
            this.LabelHeaderTempMB.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTempMB.Appearance.Options.UseFont = true;
            this.LabelHeaderTempMB.Location = new System.Drawing.Point(446, 158);
            this.LabelHeaderTempMB.Name = "LabelHeaderTempMB";
            this.LabelHeaderTempMB.Size = new System.Drawing.Size(21, 15);
            this.LabelHeaderTempMB.TabIndex = 26;
            this.LabelHeaderTempMB.Text = "MB:";
            // 
            // LabelTempRAM
            // 
            this.LabelTempRAM.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTempRAM.Appearance.Options.UseFont = true;
            this.LabelTempRAM.Location = new System.Drawing.Point(489, 125);
            this.LabelTempRAM.Name = "LabelTempRAM";
            this.LabelTempRAM.Size = new System.Drawing.Size(5, 15);
            this.LabelTempRAM.TabIndex = 25;
            this.LabelTempRAM.Text = "-";
            // 
            // LabelHeaderTempRAM
            // 
            this.LabelHeaderTempRAM.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTempRAM.Appearance.Options.UseFont = true;
            this.LabelHeaderTempRAM.Location = new System.Drawing.Point(446, 125);
            this.LabelHeaderTempRAM.Name = "LabelHeaderTempRAM";
            this.LabelHeaderTempRAM.Size = new System.Drawing.Size(29, 15);
            this.LabelHeaderTempRAM.TabIndex = 24;
            this.LabelHeaderTempRAM.Text = "RAM:";
            // 
            // LabelTitleID
            // 
            this.LabelTitleID.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTitleID.Appearance.Options.UseFont = true;
            this.LabelTitleID.Location = new System.Drawing.Point(137, 125);
            this.LabelTitleID.Name = "LabelTitleID";
            this.LabelTitleID.Size = new System.Drawing.Size(5, 15);
            this.LabelTitleID.TabIndex = 23;
            this.LabelTitleID.Text = "-";
            // 
            // LabelHeaderTitleID
            // 
            this.LabelHeaderTitleID.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderTitleID.Appearance.Options.UseFont = true;
            this.LabelHeaderTitleID.Location = new System.Drawing.Point(10, 125);
            this.LabelHeaderTitleID.Name = "LabelHeaderTitleID";
            this.LabelHeaderTitleID.Size = new System.Drawing.Size(39, 15);
            this.LabelHeaderTitleID.TabIndex = 22;
            this.LabelHeaderTitleID.Text = "Title ID:";
            // 
            // LabelKernel
            // 
            this.LabelKernel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelKernel.Appearance.Options.UseFont = true;
            this.LabelKernel.Location = new System.Drawing.Point(137, 93);
            this.LabelKernel.Name = "LabelKernel";
            this.LabelKernel.Size = new System.Drawing.Size(5, 15);
            this.LabelKernel.TabIndex = 21;
            this.LabelKernel.Text = "-";
            // 
            // LabelHeaderKernel
            // 
            this.LabelHeaderKernel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderKernel.Appearance.Options.UseFont = true;
            this.LabelHeaderKernel.Location = new System.Drawing.Point(10, 93);
            this.LabelHeaderKernel.Name = "LabelHeaderKernel";
            this.LabelHeaderKernel.Size = new System.Drawing.Size(36, 15);
            this.LabelHeaderKernel.TabIndex = 20;
            this.LabelHeaderKernel.Text = "Kernel:";
            // 
            // LabelCPUKey
            // 
            this.LabelCPUKey.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelCPUKey.Appearance.Options.UseFont = true;
            this.LabelCPUKey.Location = new System.Drawing.Point(137, 61);
            this.LabelCPUKey.Name = "LabelCPUKey";
            this.LabelCPUKey.Size = new System.Drawing.Size(5, 15);
            this.LabelCPUKey.TabIndex = 19;
            this.LabelCPUKey.Text = "-";
            // 
            // LabelHeaderCPUKey
            // 
            this.LabelHeaderCPUKey.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderCPUKey.Appearance.Options.UseFont = true;
            this.LabelHeaderCPUKey.Location = new System.Drawing.Point(10, 61);
            this.LabelHeaderCPUKey.Name = "LabelHeaderCPUKey";
            this.LabelHeaderCPUKey.Size = new System.Drawing.Size(48, 15);
            this.LabelHeaderCPUKey.TabIndex = 18;
            this.LabelHeaderCPUKey.Text = "CPU Key:";
            // 
            // LabelTempGPU
            // 
            this.LabelTempGPU.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTempGPU.Appearance.Options.UseFont = true;
            this.LabelTempGPU.Location = new System.Drawing.Point(489, 93);
            this.LabelTempGPU.Name = "LabelTempGPU";
            this.LabelTempGPU.Size = new System.Drawing.Size(5, 15);
            this.LabelTempGPU.TabIndex = 17;
            this.LabelTempGPU.Text = "-";
            // 
            // LabelTempCPU
            // 
            this.LabelTempCPU.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelTempCPU.Appearance.Options.UseFont = true;
            this.LabelTempCPU.Location = new System.Drawing.Point(489, 61);
            this.LabelTempCPU.Name = "LabelTempCPU";
            this.LabelTempCPU.Size = new System.Drawing.Size(5, 15);
            this.LabelTempCPU.TabIndex = 16;
            this.LabelTempCPU.Text = "-";
            // 
            // LabelHeaderTemperatures
            // 
            this.LabelHeaderTemperatures.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderTemperatures.Appearance.Options.UseFont = true;
            this.LabelHeaderTemperatures.Location = new System.Drawing.Point(446, 29);
            this.LabelHeaderTemperatures.Name = "LabelHeaderTemperatures";
            this.LabelHeaderTemperatures.Size = new System.Drawing.Size(79, 15);
            this.LabelHeaderTemperatures.TabIndex = 15;
            this.LabelHeaderTemperatures.Text = "Temperatures";
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
            this.ButtonRefreshDetails.Location = new System.Drawing.Point(10, 208);
            this.ButtonRefreshDetails.Name = "ButtonRefreshDetails";
            this.ButtonRefreshDetails.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRefreshDetails.Size = new System.Drawing.Size(658, 25);
            this.ButtonRefreshDetails.TabIndex = 1;
            this.ButtonRefreshDetails.Text = "Refresh";
            this.ButtonRefreshDetails.Click += new System.EventHandler(this.ButtonRefreshDetails_Click);
            // 
            // LabelIPAddress
            // 
            this.LabelIPAddress.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelIPAddress.Appearance.Options.UseFont = true;
            this.LabelIPAddress.Location = new System.Drawing.Point(137, 29);
            this.LabelIPAddress.Name = "LabelIPAddress";
            this.LabelIPAddress.Size = new System.Drawing.Size(5, 15);
            this.LabelIPAddress.TabIndex = 13;
            this.LabelIPAddress.Text = "-";
            // 
            // GroupLEDColors
            // 
            this.GroupLEDColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupLEDColors.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GroupLEDColors.AppearanceCaption.Options.UseFont = true;
            this.GroupLEDColors.Controls.Add(this.RadioGroupLEDsBottomRight);
            this.GroupLEDColors.Controls.Add(this.LabelHeaderLedBottomRight);
            this.GroupLEDColors.Controls.Add(this.RadioGroupLEDsBottomLeft);
            this.GroupLEDColors.Controls.Add(this.LabelHeaderLedBottomLeft);
            this.GroupLEDColors.Controls.Add(this.ButtonSetLEDs);
            this.GroupLEDColors.Controls.Add(this.RadioGroupLEDsTopRight);
            this.GroupLEDColors.Controls.Add(this.LabelHeaderLedTopRight);
            this.GroupLEDColors.Controls.Add(this.RadioGroupLEDsTopLeft);
            this.GroupLEDColors.Controls.Add(this.LabelHeaderLedTopLeft);
            this.GroupLEDColors.Location = new System.Drawing.Point(12, 261);
            this.GroupLEDColors.Name = "GroupLEDColors";
            this.GroupLEDColors.Padding = new System.Windows.Forms.Padding(5);
            this.GroupLEDColors.Size = new System.Drawing.Size(385, 220);
            this.GroupLEDColors.TabIndex = 13;
            this.GroupLEDColors.Text = "LED Colors";
            // 
            // RadioGroupLEDsBottomRight
            // 
            this.RadioGroupLEDsBottomRight.Location = new System.Drawing.Point(290, 56);
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
            // LabelHeaderLedBottomRight
            // 
            this.LabelHeaderLedBottomRight.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderLedBottomRight.Appearance.Options.UseFont = true;
            this.LabelHeaderLedBottomRight.Location = new System.Drawing.Point(289, 29);
            this.LabelHeaderLedBottomRight.Name = "LabelHeaderLedBottomRight";
            this.LabelHeaderLedBottomRight.Size = new System.Drawing.Size(74, 15);
            this.LabelHeaderLedBottomRight.TabIndex = 1182;
            this.LabelHeaderLedBottomRight.Text = "Bottom Right:";
            // 
            // RadioGroupLEDsBottomLeft
            // 
            this.RadioGroupLEDsBottomLeft.Location = new System.Drawing.Point(198, 56);
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
            // LabelHeaderLedBottomLeft
            // 
            this.LabelHeaderLedBottomLeft.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderLedBottomLeft.Appearance.Options.UseFont = true;
            this.LabelHeaderLedBottomLeft.Location = new System.Drawing.Point(197, 29);
            this.LabelHeaderLedBottomLeft.Name = "LabelHeaderLedBottomLeft";
            this.LabelHeaderLedBottomLeft.Size = new System.Drawing.Size(66, 15);
            this.LabelHeaderLedBottomLeft.TabIndex = 1180;
            this.LabelHeaderLedBottomLeft.Text = "Bottom Left:";
            // 
            // ButtonSetLEDs
            // 
            this.ButtonSetLEDs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSetLEDs.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonSetLEDs.Appearance.Options.UseFont = true;
            this.ButtonSetLEDs.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonSetLEDs.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonSetLEDs.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonSetLEDs.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonSetLEDs.Location = new System.Drawing.Point(10, 185);
            this.ButtonSetLEDs.Name = "ButtonSetLEDs";
            this.ButtonSetLEDs.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSetLEDs.Size = new System.Drawing.Size(365, 25);
            this.ButtonSetLEDs.TabIndex = 22;
            this.ButtonSetLEDs.Text = "Set LEDs";
            this.ButtonSetLEDs.Click += new System.EventHandler(this.ButtonSetLEDs_Click);
            // 
            // RadioGroupLEDsTopRight
            // 
            this.RadioGroupLEDsTopRight.Location = new System.Drawing.Point(105, 56);
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
            // LabelHeaderLedTopRight
            // 
            this.LabelHeaderLedTopRight.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderLedTopRight.Appearance.Options.UseFont = true;
            this.LabelHeaderLedTopRight.Location = new System.Drawing.Point(104, 29);
            this.LabelHeaderLedTopRight.Name = "LabelHeaderLedTopRight";
            this.LabelHeaderLedTopRight.Size = new System.Drawing.Size(54, 15);
            this.LabelHeaderLedTopRight.TabIndex = 1174;
            this.LabelHeaderLedTopRight.Text = "Top Right:";
            // 
            // RadioGroupLEDsTopLeft
            // 
            this.RadioGroupLEDsTopLeft.Location = new System.Drawing.Point(11, 56);
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
            // LabelHeaderLedTopLeft
            // 
            this.LabelHeaderLedTopLeft.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderLedTopLeft.Appearance.Options.UseFont = true;
            this.LabelHeaderLedTopLeft.Location = new System.Drawing.Point(10, 29);
            this.LabelHeaderLedTopLeft.Name = "LabelHeaderLedTopLeft";
            this.LabelHeaderLedTopLeft.Size = new System.Drawing.Size(46, 15);
            this.LabelHeaderLedTopLeft.TabIndex = 6;
            this.LabelHeaderLedTopLeft.Text = "Top Left:";
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
            this.GroupDiscFan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupDiscFan.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GroupDiscFan.AppearanceCaption.Options.UseFont = true;
            this.GroupDiscFan.Controls.Add(this.ButtonSetFanSpeed);
            this.GroupDiscFan.Controls.Add(this.TrackBarFanSpeed);
            this.GroupDiscFan.Controls.Add(this.ButtonDiscTrayClose);
            this.GroupDiscFan.Controls.Add(this.ButtonDiscTrayOpen);
            this.GroupDiscFan.Controls.Add(this.LabelHeaderFanSpeed);
            this.GroupDiscFan.Controls.Add(this.LabelHeaderDiscTray);
            this.GroupDiscFan.Location = new System.Drawing.Point(403, 261);
            this.GroupDiscFan.Name = "GroupDiscFan";
            this.GroupDiscFan.Padding = new System.Windows.Forms.Padding(5);
            this.GroupDiscFan.Size = new System.Drawing.Size(287, 128);
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
            this.ButtonSetFanSpeed.Location = new System.Drawing.Point(131, 88);
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
            this.TrackBarFanSpeed.Location = new System.Drawing.Point(131, 57);
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
            this.ButtonDiscTrayClose.Location = new System.Drawing.Point(10, 89);
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
            this.ButtonDiscTrayOpen.Location = new System.Drawing.Point(10, 58);
            this.ButtonDiscTrayOpen.Name = "ButtonDiscTrayOpen";
            this.ButtonDiscTrayOpen.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDiscTrayOpen.Size = new System.Drawing.Size(94, 25);
            this.ButtonDiscTrayOpen.TabIndex = 1180;
            this.ButtonDiscTrayOpen.Text = "Open";
            this.ButtonDiscTrayOpen.Click += new System.EventHandler(this.ButtonDiscTrayOpen_Click);
            // 
            // LabelHeaderFanSpeed
            // 
            this.LabelHeaderFanSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderFanSpeed.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFanSpeed.Appearance.Options.UseFont = true;
            this.LabelHeaderFanSpeed.Location = new System.Drawing.Point(135, 29);
            this.LabelHeaderFanSpeed.Name = "LabelHeaderFanSpeed";
            this.LabelHeaderFanSpeed.Size = new System.Drawing.Size(57, 15);
            this.LabelHeaderFanSpeed.TabIndex = 1178;
            this.LabelHeaderFanSpeed.Text = "Fan Speed";
            // 
            // LabelHeaderDiscTray
            // 
            this.LabelHeaderDiscTray.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderDiscTray.Appearance.Options.UseFont = true;
            this.LabelHeaderDiscTray.Location = new System.Drawing.Point(10, 29);
            this.LabelHeaderDiscTray.Name = "LabelHeaderDiscTray";
            this.LabelHeaderDiscTray.Size = new System.Drawing.Size(50, 15);
            this.LabelHeaderDiscTray.TabIndex = 4;
            this.LabelHeaderDiscTray.Text = "Disc Tray";
            // 
            // GroupNeighborhoodEditor
            // 
            this.GroupNeighborhoodEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNeighborhoodEditor.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GroupNeighborhoodEditor.AppearanceCaption.Options.UseFont = true;
            this.GroupNeighborhoodEditor.Controls.Add(this.TextBoxXboxName);
            this.GroupNeighborhoodEditor.Controls.Add(this.LabelHeaderIconColor);
            this.GroupNeighborhoodEditor.Controls.Add(this.ComboBoxXboxIcon);
            this.GroupNeighborhoodEditor.Controls.Add(this.LabelHeaderName);
            this.GroupNeighborhoodEditor.Location = new System.Drawing.Point(403, 395);
            this.GroupNeighborhoodEditor.Name = "GroupNeighborhoodEditor";
            this.GroupNeighborhoodEditor.Padding = new System.Windows.Forms.Padding(5);
            this.GroupNeighborhoodEditor.Size = new System.Drawing.Size(287, 86);
            this.GroupNeighborhoodEditor.TabIndex = 1183;
            this.GroupNeighborhoodEditor.Text = "Neighborhood Editor";
            // 
            // TextBoxXboxName
            // 
            this.TextBoxXboxName.Location = new System.Drawing.Point(10, 50);
            this.TextBoxXboxName.MenuManager = this.BarManager;
            this.TextBoxXboxName.Name = "TextBoxXboxName";
            this.TextBoxXboxName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxXboxName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxXboxName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.TextBoxXboxName.Size = new System.Drawing.Size(154, 24);
            this.TextBoxXboxName.TabIndex = 8;
            this.TextBoxXboxName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TextBoxXboxName_ButtonClick);
            // 
            // LabelHeaderIconColor
            // 
            this.LabelHeaderIconColor.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderIconColor.Appearance.Options.UseFont = true;
            this.LabelHeaderIconColor.Location = new System.Drawing.Point(170, 29);
            this.LabelHeaderIconColor.Name = "LabelHeaderIconColor";
            this.LabelHeaderIconColor.Size = new System.Drawing.Size(56, 15);
            this.LabelHeaderIconColor.TabIndex = 7;
            this.LabelHeaderIconColor.Text = "Icon Color";
            // 
            // ComboBoxXboxIcon
            // 
            this.ComboBoxXboxIcon.EditValue = "White";
            this.ComboBoxXboxIcon.Location = new System.Drawing.Point(170, 50);
            this.ComboBoxXboxIcon.MenuManager = this.BarManager;
            this.ComboBoxXboxIcon.Name = "ComboBoxXboxIcon";
            this.ComboBoxXboxIcon.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ComboBoxXboxIcon.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxXboxIcon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxXboxIcon.Properties.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "BlueGray",
            "White"});
            this.ComboBoxXboxIcon.Size = new System.Drawing.Size(107, 24);
            this.ComboBoxXboxIcon.TabIndex = 6;
            this.ComboBoxXboxIcon.SelectedIndexChanged += new System.EventHandler(this.ComboBoxXboxIcon_SelectedIndexChanged);
            // 
            // LabelHeaderName
            // 
            this.LabelHeaderName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderName.Appearance.Options.UseFont = true;
            this.LabelHeaderName.Location = new System.Drawing.Point(10, 29);
            this.LabelHeaderName.Name = "LabelHeaderName";
            this.LabelHeaderName.Size = new System.Drawing.Size(79, 15);
            this.LabelHeaderName.TabIndex = 5;
            this.LabelHeaderName.Text = "Console Name";
            // 
            // ConsoleManager
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(702, 524);
            this.Controls.Add(this.GroupNeighborhoodEditor);
            this.Controls.Add(this.GroupDiscFan);
            this.Controls.Add(this.GroupLEDColors);
            this.Controls.Add(this.GroupDetails);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ConsoleManager.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsoleManager";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Console Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsoleManager_FormClosing);
            this.Load += new System.EventHandler(this.ConsoleManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PopupImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupDetails)).EndInit();
            this.GroupDetails.ResumeLayout(false);
            this.GroupDetails.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.GroupNeighborhoodEditor)).EndInit();
            this.GroupNeighborhoodEditor.ResumeLayout(false);
            this.GroupNeighborhoodEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxXboxName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxXboxIcon.Properties)).EndInit();
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
        private LabelControl LabelHeaderLedTopLeft;
        private GroupControl GroupDetails;
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
        private LabelControl LabelHeaderTemperatures;
        private LabelControl LabelTempGPU;
        private LabelControl LabelTempCPU;
        private LabelControl LabelCPUKey;
        private LabelControl LabelHeaderCPUKey;
        private LabelControl LabelKernel;
        private LabelControl LabelHeaderKernel;
        private RadioGroup RadioGroupLEDsTopLeft;
        private SimpleButton ButtonSetLEDs;
        private RadioGroup RadioGroupLEDsTopRight;
        private LabelControl LabelHeaderLedTopRight;
        private LabelControl LabelTempRAM;
        private LabelControl LabelHeaderTempRAM;
        private LabelControl LabelTitleID;
        private LabelControl LabelHeaderTitleID;
        private LabelControl LabelTempMB;
        private LabelControl LabelHeaderTempMB;
        private RadioGroup RadioGroupLEDsBottomRight;
        private LabelControl LabelHeaderLedBottomRight;
        private RadioGroup RadioGroupLEDsBottomLeft;
        private LabelControl LabelHeaderLedBottomLeft;
        private GroupControl GroupDiscFan;
        private SimpleButton ButtonSetFanSpeed;
        private TrackBarControl TrackBarFanSpeed;
        private SimpleButton ButtonDiscTrayClose;
        private SimpleButton ButtonDiscTrayOpen;
        private LabelControl LabelHeaderFanSpeed;
        private LabelControl LabelHeaderDiscTray;
        private GroupControl GroupNeighborhoodEditor;
        private LabelControl LabelHeaderName;
        private LabelControl LabelHeaderIconColor;
        private ComboBoxEdit ComboBoxXboxIcon;
        private ButtonEdit TextBoxXboxName;
    }
}