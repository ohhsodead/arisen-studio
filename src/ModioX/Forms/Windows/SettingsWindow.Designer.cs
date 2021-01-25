
namespace ModioX.Forms.Windows
{
    partial class SettingsWindow
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
            this.LabelXboxDebuggingForeColor = new DevExpress.XtraEditors.LabelControl();
            this.ColorXboxDebuggingFont = new DevExpress.XtraEditors.ColorEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ColorXboxDebuggingBackground = new DevExpress.XtraEditors.ColorEdit();
            this.CheckBoxSaveThemeOnClose = new DevExpress.XtraEditors.CheckEdit();
            this.LabelXboxDebugging = new DevExpress.XtraEditors.LabelControl();
            this.LabelXboxDebuggingBackgroundColor = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TabDatabase = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.RadioConsoles = new DevExpress.XtraEditors.RadioGroup();
            this.TabContentRecognition = new DevExpress.XtraTab.XtraTabPage();
            this.TabFileManager = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxRememberGameRegions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameTitles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameRegions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveConsolePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveLocalPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxShowFileSizeInBytes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabAppearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorXboxDebuggingFont.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorXboxDebuggingBackground.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveThemeOnClose.Properties)).BeginInit();
            this.TabDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadioConsoles.Properties)).BeginInit();
            this.TabContentRecognition.SuspendLayout();
            this.TabFileManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckBoxRememberGameRegions
            // 
            this.CheckBoxRememberGameRegions.Location = new System.Drawing.Point(10, 58);
            this.CheckBoxRememberGameRegions.Name = "CheckBoxRememberGameRegions";
            this.CheckBoxRememberGameRegions.Properties.AllowFocused = false;
            this.CheckBoxRememberGameRegions.Properties.AutoWidth = true;
            this.CheckBoxRememberGameRegions.Properties.Caption = "Remember game regions";
            this.CheckBoxRememberGameRegions.Size = new System.Drawing.Size(148, 18);
            this.CheckBoxRememberGameRegions.TabIndex = 3;
            // 
            // CheckBoxAutoDetectGameTitles
            // 
            this.CheckBoxAutoDetectGameTitles.Location = new System.Drawing.Point(10, 34);
            this.CheckBoxAutoDetectGameTitles.Name = "CheckBoxAutoDetectGameTitles";
            this.CheckBoxAutoDetectGameTitles.Properties.AllowFocused = false;
            this.CheckBoxAutoDetectGameTitles.Properties.AutoWidth = true;
            this.CheckBoxAutoDetectGameTitles.Properties.Caption = "Automatically detect game titles";
            this.CheckBoxAutoDetectGameTitles.Size = new System.Drawing.Size(184, 18);
            this.CheckBoxAutoDetectGameTitles.TabIndex = 2;
            // 
            // CheckBoxAutoDetectGameRegions
            // 
            this.CheckBoxAutoDetectGameRegions.Location = new System.Drawing.Point(10, 10);
            this.CheckBoxAutoDetectGameRegions.Name = "CheckBoxAutoDetectGameRegions";
            this.CheckBoxAutoDetectGameRegions.Properties.AllowFocused = false;
            this.CheckBoxAutoDetectGameRegions.Properties.AutoWidth = true;
            this.CheckBoxAutoDetectGameRegions.Properties.Caption = "Automatically detect game regions";
            this.CheckBoxAutoDetectGameRegions.Size = new System.Drawing.Size(198, 18);
            this.CheckBoxAutoDetectGameRegions.TabIndex = 1;
            // 
            // CheckBoxSaveConsolePath
            // 
            this.CheckBoxSaveConsolePath.Location = new System.Drawing.Point(10, 34);
            this.CheckBoxSaveConsolePath.Name = "CheckBoxSaveConsolePath";
            this.CheckBoxSaveConsolePath.Properties.AllowFocused = false;
            this.CheckBoxSaveConsolePath.Properties.AutoWidth = true;
            this.CheckBoxSaveConsolePath.Properties.Caption = "Save last console directory path";
            this.CheckBoxSaveConsolePath.Size = new System.Drawing.Size(183, 18);
            this.CheckBoxSaveConsolePath.TabIndex = 2;
            // 
            // CheckBoxSaveLocalPath
            // 
            this.CheckBoxSaveLocalPath.Location = new System.Drawing.Point(10, 10);
            this.CheckBoxSaveLocalPath.Name = "CheckBoxSaveLocalPath";
            this.CheckBoxSaveLocalPath.Properties.AllowFocused = false;
            this.CheckBoxSaveLocalPath.Properties.AutoWidth = true;
            this.CheckBoxSaveLocalPath.Properties.Caption = "Save last local directory path";
            this.CheckBoxSaveLocalPath.Size = new System.Drawing.Size(167, 18);
            this.CheckBoxSaveLocalPath.TabIndex = 1;
            // 
            // CheckBoxShowFileSizeInBytes
            // 
            this.CheckBoxShowFileSizeInBytes.Location = new System.Drawing.Point(10, 79);
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
            this.ButtonSaveSettings.Location = new System.Drawing.Point(174, 239);
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
            this.TabControl.Size = new System.Drawing.Size(394, 214);
            this.TabControl.TabIndex = 5;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabAppearance,
            this.TabDatabase,
            this.TabContentRecognition,
            this.TabFileManager});
            // 
            // TabAppearance
            // 
            this.TabAppearance.Controls.Add(this.LabelXboxDebuggingForeColor);
            this.TabAppearance.Controls.Add(this.ColorXboxDebuggingFont);
            this.TabAppearance.Controls.Add(this.labelControl6);
            this.TabAppearance.Controls.Add(this.CheckBoxShowFileSizeInBytes);
            this.TabAppearance.Controls.Add(this.ColorXboxDebuggingBackground);
            this.TabAppearance.Controls.Add(this.CheckBoxSaveThemeOnClose);
            this.TabAppearance.Controls.Add(this.LabelXboxDebugging);
            this.TabAppearance.Controls.Add(this.LabelXboxDebuggingBackgroundColor);
            this.TabAppearance.Controls.Add(this.labelControl4);
            this.TabAppearance.Name = "TabAppearance";
            this.TabAppearance.Size = new System.Drawing.Size(392, 191);
            this.TabAppearance.Text = "Appearance";
            // 
            // LabelXboxDebuggingForeColor
            // 
            this.LabelXboxDebuggingForeColor.Location = new System.Drawing.Point(10, 129);
            this.LabelXboxDebuggingForeColor.Name = "LabelXboxDebuggingForeColor";
            this.LabelXboxDebuggingForeColor.Size = new System.Drawing.Size(58, 13);
            this.LabelXboxDebuggingForeColor.TabIndex = 2;
            this.LabelXboxDebuggingForeColor.Text = "Font Color:";
            // 
            // ColorXboxDebuggingFont
            // 
            this.ColorXboxDebuggingFont.EditValue = System.Drawing.Color.Empty;
            this.ColorXboxDebuggingFont.Location = new System.Drawing.Point(132, 126);
            this.ColorXboxDebuggingFont.Name = "ColorXboxDebuggingFont";
            this.ColorXboxDebuggingFont.Properties.AllowFocused = false;
            this.ColorXboxDebuggingFont.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ColorXboxDebuggingFont.Size = new System.Drawing.Size(114, 20);
            this.ColorXboxDebuggingFont.TabIndex = 0;
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
            this.labelControl6.Location = new System.Drawing.Point(10, 58);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(368, 15);
            this.labelControl6.TabIndex = 1171;
            this.labelControl6.Text = "File Sizes";
            // 
            // ColorXboxDebuggingBackground
            // 
            this.ColorXboxDebuggingBackground.EditValue = System.Drawing.Color.Empty;
            this.ColorXboxDebuggingBackground.Location = new System.Drawing.Point(132, 156);
            this.ColorXboxDebuggingBackground.Name = "ColorXboxDebuggingBackground";
            this.ColorXboxDebuggingBackground.Properties.AllowFocused = false;
            this.ColorXboxDebuggingBackground.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ColorXboxDebuggingBackground.Size = new System.Drawing.Size(114, 20);
            this.ColorXboxDebuggingBackground.TabIndex = 1;
            // 
            // CheckBoxSaveThemeOnClose
            // 
            this.CheckBoxSaveThemeOnClose.Location = new System.Drawing.Point(10, 31);
            this.CheckBoxSaveThemeOnClose.Name = "CheckBoxSaveThemeOnClose";
            this.CheckBoxSaveThemeOnClose.Properties.AllowFocused = false;
            this.CheckBoxSaveThemeOnClose.Properties.AutoWidth = true;
            this.CheckBoxSaveThemeOnClose.Properties.Caption = "Save current theme on close";
            this.CheckBoxSaveThemeOnClose.Size = new System.Drawing.Size(165, 18);
            this.CheckBoxSaveThemeOnClose.TabIndex = 1170;
            // 
            // LabelXboxDebugging
            // 
            this.LabelXboxDebugging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelXboxDebugging.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelXboxDebugging.Appearance.Options.UseFont = true;
            this.LabelXboxDebugging.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelXboxDebugging.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelXboxDebugging.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelXboxDebugging.LineVisible = true;
            this.LabelXboxDebugging.Location = new System.Drawing.Point(10, 105);
            this.LabelXboxDebugging.Name = "LabelXboxDebugging";
            this.LabelXboxDebugging.Size = new System.Drawing.Size(368, 15);
            this.LabelXboxDebugging.TabIndex = 1169;
            this.LabelXboxDebugging.Text = "Xbox Debugging (HexBox)";
            // 
            // LabelXboxDebuggingBackgroundColor
            // 
            this.LabelXboxDebuggingBackgroundColor.Location = new System.Drawing.Point(10, 159);
            this.LabelXboxDebuggingBackgroundColor.Name = "LabelXboxDebuggingBackgroundColor";
            this.LabelXboxDebuggingBackgroundColor.Size = new System.Drawing.Size(96, 13);
            this.LabelXboxDebuggingBackgroundColor.TabIndex = 3;
            this.LabelXboxDebuggingBackgroundColor.Text = "Background Color:";
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
            this.labelControl4.Size = new System.Drawing.Size(368, 15);
            this.labelControl4.TabIndex = 1168;
            this.labelControl4.Text = "Theme";
            // 
            // TabDatabase
            // 
            this.TabDatabase.Controls.Add(this.labelControl1);
            this.TabDatabase.Controls.Add(this.RadioConsoles);
            this.TabDatabase.Name = "TabDatabase";
            this.TabDatabase.Size = new System.Drawing.Size(392, 191);
            this.TabDatabase.Text = "Database";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(175, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Load default database on startup:";
            // 
            // RadioConsoles
            // 
            this.RadioConsoles.Location = new System.Drawing.Point(5, 26);
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
            this.TabContentRecognition.Controls.Add(this.CheckBoxAutoDetectGameRegions);
            this.TabContentRecognition.Controls.Add(this.CheckBoxAutoDetectGameTitles);
            this.TabContentRecognition.Controls.Add(this.CheckBoxRememberGameRegions);
            this.TabContentRecognition.Name = "TabContentRecognition";
            this.TabContentRecognition.Size = new System.Drawing.Size(392, 191);
            this.TabContentRecognition.Text = "Content Recognition";
            // 
            // TabFileManager
            // 
            this.TabFileManager.Controls.Add(this.CheckBoxSaveConsolePath);
            this.TabFileManager.Controls.Add(this.CheckBoxSaveLocalPath);
            this.TabFileManager.Name = "TabFileManager";
            this.TabFileManager.Size = new System.Drawing.Size(392, 191);
            this.TabFileManager.Text = "File Manager";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 275);
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
            ((System.ComponentModel.ISupportInitialize)(this.ColorXboxDebuggingFont.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorXboxDebuggingBackground.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveThemeOnClose.Properties)).EndInit();
            this.TabDatabase.ResumeLayout(false);
            this.TabDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadioConsoles.Properties)).EndInit();
            this.TabContentRecognition.ResumeLayout(false);
            this.TabContentRecognition.PerformLayout();
            this.TabFileManager.ResumeLayout(false);
            this.TabFileManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.CheckEdit CheckBoxAutoDetectGameTitles;
        private DevExpress.XtraEditors.CheckEdit CheckBoxAutoDetectGameRegions;
        private DevExpress.XtraEditors.CheckEdit CheckBoxSaveConsolePath;
        private DevExpress.XtraEditors.CheckEdit CheckBoxSaveLocalPath;
        private DevExpress.XtraEditors.CheckEdit CheckBoxShowFileSizeInBytes;
        private DevExpress.XtraEditors.SimpleButton ButtonSaveSettings;
        private DevExpress.XtraEditors.CheckEdit CheckBoxRememberGameRegions;
        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage TabFileManager;
        private DevExpress.XtraTab.XtraTabPage TabDatabase;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup RadioConsoles;
        private DevExpress.XtraEditors.LabelControl LabelXboxDebuggingForeColor;
        private DevExpress.XtraEditors.ColorEdit ColorXboxDebuggingFont;
        private DevExpress.XtraEditors.LabelControl LabelXboxDebuggingBackgroundColor;
        private DevExpress.XtraEditors.ColorEdit ColorXboxDebuggingBackground;
        private DevExpress.XtraTab.XtraTabPage TabAppearance;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit CheckBoxSaveThemeOnClose;
        private DevExpress.XtraEditors.LabelControl LabelXboxDebugging;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraTab.XtraTabPage TabContentRecognition;
    }
}