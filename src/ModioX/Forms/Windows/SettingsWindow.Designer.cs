
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

namespace ModioX.Forms.Windows
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.CheckBoxRememberGameRegions = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxAutoDetectGameTitles = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxAutoDetectGameRegions = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxSaveConsolePath = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxSaveLocalPath = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxShowFileSizeInBytes = new DevExpress.XtraEditors.CheckEdit();
            this.ButtonSaveSettings = new DevExpress.XtraEditors.SimpleButton();
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.TabAppearance = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.CheckBoxRememberThemeOnClose = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TabDatabase = new DevExpress.XtraTab.XtraTabPage();
            this.LabelHeaderDefaultDatabase = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.RadioConsoles = new DevExpress.XtraEditors.RadioGroup();
            this.TabContentRecognition = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TabFileManager = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TabXboxTools = new DevExpress.XtraTab.XtraTabPage();
            this.LabelHeaderLaunchIniFilePath = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxLaunchIniFilePath = new DevExpress.XtraEditors.TextEdit();
            this.LabelHeaderPluginsEditor = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.CheckBoxShowGamesFromExternalDevices = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxRememberGameRegions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameTitles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameRegions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveConsolePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveLocalPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxShowFileSizeInBytes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabAppearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxRememberThemeOnClose.Properties)).BeginInit();
            this.TabDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadioConsoles.Properties)).BeginInit();
            this.TabContentRecognition.SuspendLayout();
            this.TabFileManager.SuspendLayout();
            this.TabXboxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLaunchIniFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxShowGamesFromExternalDevices.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBoxRememberGameRegions
            // 
            this.CheckBoxRememberGameRegions.Location = new System.Drawing.Point(10, 156);
            this.CheckBoxRememberGameRegions.Name = "CheckBoxRememberGameRegions";
            this.CheckBoxRememberGameRegions.Properties.AllowFocused = false;
            this.CheckBoxRememberGameRegions.Properties.AutoWidth = true;
            this.CheckBoxRememberGameRegions.Properties.Caption = "Remember game regions";
            this.CheckBoxRememberGameRegions.Size = new System.Drawing.Size(148, 18);
            this.CheckBoxRememberGameRegions.TabIndex = 3;
            // 
            // CheckBoxAutoDetectGameTitles
            // 
            this.CheckBoxAutoDetectGameTitles.Location = new System.Drawing.Point(10, 106);
            this.CheckBoxAutoDetectGameTitles.Name = "CheckBoxAutoDetectGameTitles";
            this.CheckBoxAutoDetectGameTitles.Properties.AllowFocused = false;
            this.CheckBoxAutoDetectGameTitles.Properties.AutoWidth = true;
            this.CheckBoxAutoDetectGameTitles.Properties.Caption = "Automatically detect game titles";
            this.CheckBoxAutoDetectGameTitles.Size = new System.Drawing.Size(184, 18);
            this.CheckBoxAutoDetectGameTitles.TabIndex = 2;
            // 
            // CheckBoxAutoDetectGameRegions
            // 
            this.CheckBoxAutoDetectGameRegions.Location = new System.Drawing.Point(10, 82);
            this.CheckBoxAutoDetectGameRegions.Name = "CheckBoxAutoDetectGameRegions";
            this.CheckBoxAutoDetectGameRegions.Properties.AllowFocused = false;
            this.CheckBoxAutoDetectGameRegions.Properties.AutoWidth = true;
            this.CheckBoxAutoDetectGameRegions.Properties.Caption = "Automatically detect game regions";
            this.CheckBoxAutoDetectGameRegions.Size = new System.Drawing.Size(198, 18);
            this.CheckBoxAutoDetectGameRegions.TabIndex = 1;
            // 
            // CheckBoxSaveConsolePath
            // 
            this.CheckBoxSaveConsolePath.Location = new System.Drawing.Point(10, 56);
            this.CheckBoxSaveConsolePath.Name = "CheckBoxSaveConsolePath";
            this.CheckBoxSaveConsolePath.Properties.AllowFocused = false;
            this.CheckBoxSaveConsolePath.Properties.AutoWidth = true;
            this.CheckBoxSaveConsolePath.Properties.Caption = "Remember last console directory path";
            this.CheckBoxSaveConsolePath.Size = new System.Drawing.Size(214, 18);
            this.CheckBoxSaveConsolePath.TabIndex = 2;
            // 
            // CheckBoxSaveLocalPath
            // 
            this.CheckBoxSaveLocalPath.Location = new System.Drawing.Point(10, 32);
            this.CheckBoxSaveLocalPath.Name = "CheckBoxSaveLocalPath";
            this.CheckBoxSaveLocalPath.Properties.AllowFocused = false;
            this.CheckBoxSaveLocalPath.Properties.AutoWidth = true;
            this.CheckBoxSaveLocalPath.Properties.Caption = "Remember last local directory path";
            this.CheckBoxSaveLocalPath.Size = new System.Drawing.Size(198, 18);
            this.CheckBoxSaveLocalPath.TabIndex = 1;
            // 
            // CheckBoxShowFileSizeInBytes
            // 
            this.CheckBoxShowFileSizeInBytes.Location = new System.Drawing.Point(10, 82);
            this.CheckBoxShowFileSizeInBytes.Name = "CheckBoxShowFileSizeInBytes";
            this.CheckBoxShowFileSizeInBytes.Properties.AllowFocused = false;
            this.CheckBoxShowFileSizeInBytes.Properties.AutoWidth = true;
            this.CheckBoxShowFileSizeInBytes.Properties.Caption = "Show file size in bytes";
            this.CheckBoxShowFileSizeInBytes.Size = new System.Drawing.Size(134, 18);
            this.CheckBoxShowFileSizeInBytes.TabIndex = 1;
            // 
            // ButtonSaveSettings
            // 
            this.ButtonSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonSaveSettings.Location = new System.Drawing.Point(186, 239);
            this.ButtonSaveSettings.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ButtonSaveSettings.Name = "ButtonSaveSettings";
            this.ButtonSaveSettings.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSaveSettings.Size = new System.Drawing.Size(70, 24);
            this.ButtonSaveSettings.TabIndex = 3;
            this.ButtonSaveSettings.Text = "Save";
            this.ButtonSaveSettings.Click += new System.EventHandler(this.ButtonSaveSettings_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.TabAppearance;
            this.TabControl.Size = new System.Drawing.Size(418, 214);
            this.TabControl.TabIndex = 5;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabAppearance,
            this.TabDatabase,
            this.TabContentRecognition,
            this.TabFileManager,
            this.TabXboxTools});
            // 
            // TabAppearance
            // 
            this.TabAppearance.Controls.Add(this.labelControl6);
            this.TabAppearance.Controls.Add(this.CheckBoxShowFileSizeInBytes);
            this.TabAppearance.Controls.Add(this.CheckBoxRememberThemeOnClose);
            this.TabAppearance.Controls.Add(this.labelControl4);
            this.TabAppearance.Name = "TabAppearance";
            this.TabAppearance.Size = new System.Drawing.Size(416, 191);
            this.TabAppearance.Text = "Appearance";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl6.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(10, 60);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(396, 15);
            this.labelControl6.TabIndex = 1171;
            this.labelControl6.Text = "File Sizes";
            // 
            // CheckBoxRememberThemeOnClose
            // 
            this.CheckBoxRememberThemeOnClose.Location = new System.Drawing.Point(10, 32);
            this.CheckBoxRememberThemeOnClose.Name = "CheckBoxRememberThemeOnClose";
            this.CheckBoxRememberThemeOnClose.Properties.AllowFocused = false;
            this.CheckBoxRememberThemeOnClose.Properties.AutoWidth = true;
            this.CheckBoxRememberThemeOnClose.Properties.Caption = "Remember current theme on close";
            this.CheckBoxRememberThemeOnClose.Size = new System.Drawing.Size(196, 18);
            this.CheckBoxRememberThemeOnClose.TabIndex = 1170;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl4.LineVisible = true;
            this.labelControl4.Location = new System.Drawing.Point(10, 10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(396, 15);
            this.labelControl4.TabIndex = 1168;
            this.labelControl4.Text = "Theme";
            // 
            // TabDatabase
            // 
            this.TabDatabase.Controls.Add(this.LabelHeaderDefaultDatabase);
            this.TabDatabase.Controls.Add(this.labelControl1);
            this.TabDatabase.Controls.Add(this.RadioConsoles);
            this.TabDatabase.Name = "TabDatabase";
            this.TabDatabase.Size = new System.Drawing.Size(416, 191);
            this.TabDatabase.Text = "Database";
            // 
            // LabelHeaderDefaultDatabase
            // 
            this.LabelHeaderDefaultDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderDefaultDatabase.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderDefaultDatabase.Appearance.Options.UseFont = true;
            this.LabelHeaderDefaultDatabase.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelHeaderDefaultDatabase.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelHeaderDefaultDatabase.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelHeaderDefaultDatabase.LineVisible = true;
            this.LabelHeaderDefaultDatabase.Location = new System.Drawing.Point(10, 10);
            this.LabelHeaderDefaultDatabase.Name = "LabelHeaderDefaultDatabase";
            this.LabelHeaderDefaultDatabase.Size = new System.Drawing.Size(396, 15);
            this.LabelHeaderDefaultDatabase.TabIndex = 1169;
            this.LabelHeaderDefaultDatabase.Text = "Startup Database";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(173, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Database type to load on startup:";
            // 
            // RadioConsoles
            // 
            this.RadioConsoles.Location = new System.Drawing.Point(4, 48);
            this.RadioConsoles.Name = "RadioConsoles";
            this.RadioConsoles.Properties.AllowFocused = false;
            this.RadioConsoles.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioConsoles.Properties.Appearance.Options.UseBackColor = true;
            this.RadioConsoles.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioConsoles.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "PS3"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Xbox")});
            this.RadioConsoles.Size = new System.Drawing.Size(113, 56);
            this.RadioConsoles.TabIndex = 3;
            // 
            // TabContentRecognition
            // 
            this.TabContentRecognition.Controls.Add(this.labelControl7);
            this.TabContentRecognition.Controls.Add(this.CheckBoxShowGamesFromExternalDevices);
            this.TabContentRecognition.Controls.Add(this.labelControl5);
            this.TabContentRecognition.Controls.Add(this.labelControl3);
            this.TabContentRecognition.Controls.Add(this.CheckBoxAutoDetectGameRegions);
            this.TabContentRecognition.Controls.Add(this.CheckBoxAutoDetectGameTitles);
            this.TabContentRecognition.Controls.Add(this.CheckBoxRememberGameRegions);
            this.TabContentRecognition.Name = "TabContentRecognition";
            this.TabContentRecognition.Size = new System.Drawing.Size(416, 191);
            this.TabContentRecognition.Text = "Content Recognition";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl5.LineVisible = true;
            this.labelControl5.Location = new System.Drawing.Point(10, 134);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(396, 15);
            this.labelControl5.TabIndex = 1171;
            this.labelControl5.Text = "Game Regions";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(396, 15);
            this.labelControl3.TabIndex = 1170;
            this.labelControl3.Text = "Game Content";
            // 
            // TabFileManager
            // 
            this.TabFileManager.Controls.Add(this.labelControl2);
            this.TabFileManager.Controls.Add(this.CheckBoxSaveConsolePath);
            this.TabFileManager.Controls.Add(this.CheckBoxSaveLocalPath);
            this.TabFileManager.Name = "TabFileManager";
            this.TabFileManager.Size = new System.Drawing.Size(416, 191);
            this.TabFileManager.Text = "File Manager";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(396, 15);
            this.labelControl2.TabIndex = 1170;
            this.labelControl2.Text = "Directories";
            // 
            // TabXboxTools
            // 
            this.TabXboxTools.Controls.Add(this.LabelHeaderLaunchIniFilePath);
            this.TabXboxTools.Controls.Add(this.TextBoxLaunchIniFilePath);
            this.TabXboxTools.Controls.Add(this.LabelHeaderPluginsEditor);
            this.TabXboxTools.Name = "TabXboxTools";
            this.TabXboxTools.Size = new System.Drawing.Size(416, 191);
            this.TabXboxTools.Text = "Xbox Tools";
            // 
            // LabelHeaderLaunchIniFilePath
            // 
            this.LabelHeaderLaunchIniFilePath.Location = new System.Drawing.Point(10, 32);
            this.LabelHeaderLaunchIniFilePath.Name = "LabelHeaderLaunchIniFilePath";
            this.LabelHeaderLaunchIniFilePath.Size = new System.Drawing.Size(103, 13);
            this.LabelHeaderLaunchIniFilePath.TabIndex = 1172;
            this.LabelHeaderLaunchIniFilePath.Text = "Launch.ini File Path:";
            // 
            // TextBoxLaunchIniFilePath
            // 
            this.TextBoxLaunchIniFilePath.Location = new System.Drawing.Point(10, 51);
            this.TextBoxLaunchIniFilePath.Name = "TextBoxLaunchIniFilePath";
            this.TextBoxLaunchIniFilePath.Size = new System.Drawing.Size(396, 20);
            this.TextBoxLaunchIniFilePath.TabIndex = 1171;
            // 
            // LabelHeaderPluginsEditor
            // 
            this.LabelHeaderPluginsEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelHeaderPluginsEditor.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderPluginsEditor.Appearance.Options.UseFont = true;
            this.LabelHeaderPluginsEditor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelHeaderPluginsEditor.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelHeaderPluginsEditor.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelHeaderPluginsEditor.LineVisible = true;
            this.LabelHeaderPluginsEditor.Location = new System.Drawing.Point(10, 10);
            this.LabelHeaderPluginsEditor.Name = "LabelHeaderPluginsEditor";
            this.LabelHeaderPluginsEditor.Size = new System.Drawing.Size(396, 15);
            this.LabelHeaderPluginsEditor.TabIndex = 1170;
            this.LabelHeaderPluginsEditor.Text = "Plugins Editor";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl7.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl7.LineVisible = true;
            this.labelControl7.Location = new System.Drawing.Point(10, 10);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(396, 15);
            this.labelControl7.TabIndex = 1173;
            this.labelControl7.Text = "Games List";
            // 
            // CheckBoxShowGamesFromExternalDevices
            // 
            this.CheckBoxShowGamesFromExternalDevices.Location = new System.Drawing.Point(10, 32);
            this.CheckBoxShowGamesFromExternalDevices.Name = "CheckBoxShowGamesFromExternalDevices";
            this.CheckBoxShowGamesFromExternalDevices.Properties.AllowFocused = false;
            this.CheckBoxShowGamesFromExternalDevices.Properties.AutoWidth = true;
            this.CheckBoxShowGamesFromExternalDevices.Properties.Caption = "Show games from external devices";
            this.CheckBoxShowGamesFromExternalDevices.Size = new System.Drawing.Size(197, 18);
            this.CheckBoxShowGamesFromExternalDevices.TabIndex = 1172;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 275);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ButtonSaveSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("SettingsWindow.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxRememberGameRegions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameTitles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameRegions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveConsolePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveLocalPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxShowFileSizeInBytes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabAppearance.ResumeLayout(false);
            this.TabAppearance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxRememberThemeOnClose.Properties)).EndInit();
            this.TabDatabase.ResumeLayout(false);
            this.TabDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadioConsoles.Properties)).EndInit();
            this.TabContentRecognition.ResumeLayout(false);
            this.TabContentRecognition.PerformLayout();
            this.TabFileManager.ResumeLayout(false);
            this.TabFileManager.PerformLayout();
            this.TabXboxTools.ResumeLayout(false);
            this.TabXboxTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLaunchIniFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxShowGamesFromExternalDevices.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CheckEdit CheckBoxAutoDetectGameTitles;
        private CheckEdit CheckBoxAutoDetectGameRegions;
        private CheckEdit CheckBoxSaveConsolePath;
        private CheckEdit CheckBoxSaveLocalPath;
        private CheckEdit CheckBoxShowFileSizeInBytes;
        private SimpleButton ButtonSaveSettings;
        private CheckEdit CheckBoxRememberGameRegions;
        private XtraTabControl TabControl;
        private XtraTabPage TabFileManager;
        private XtraTabPage TabDatabase;
        private LabelControl labelControl1;
        private RadioGroup RadioConsoles;
        private XtraTabPage TabAppearance;
        private LabelControl labelControl6;
        private CheckEdit CheckBoxRememberThemeOnClose;
        private LabelControl labelControl4;
        private XtraTabPage TabContentRecognition;
        private LabelControl LabelHeaderDefaultDatabase;
        private XtraTabPage TabXboxTools;
        private LabelControl labelControl2;
        private LabelControl LabelHeaderPluginsEditor;
        private LabelControl labelControl5;
        private LabelControl labelControl3;
        private TextEdit TextBoxLaunchIniFilePath;
        private LabelControl LabelHeaderLaunchIniFilePath;
        private LabelControl labelControl7;
        private CheckEdit CheckBoxShowGamesFromExternalDevices;
    }
}