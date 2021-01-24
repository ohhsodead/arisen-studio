
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
            this.TabDatabase = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.RadioConsoles = new DevExpress.XtraEditors.RadioGroup();
            this.TabContentRecognition = new DevExpress.XtraTab.XtraTabPage();
            this.TabFileManager = new DevExpress.XtraTab.XtraTabPage();
            this.TabFileSizes = new DevExpress.XtraTab.XtraTabPage();
            this.XboxPeekPokeSettings = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.colorEdit1 = new DevExpress.XtraEditors.ColorEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.colorEdit2 = new DevExpress.XtraEditors.ColorEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxRememberGameRegions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameTitles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameRegions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveConsolePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveLocalPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxShowFileSizeInBytes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadioConsoles.Properties)).BeginInit();
            this.TabContentRecognition.SuspendLayout();
            this.TabFileManager.SuspendLayout();
            this.TabFileSizes.SuspendLayout();
            this.XboxPeekPokeSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBoxRememberGameRegions
            // 
            this.CheckBoxRememberGameRegions.Location = new System.Drawing.Point(9, 56);
            this.CheckBoxRememberGameRegions.Name = "CheckBoxRememberGameRegions";
            this.CheckBoxRememberGameRegions.Properties.AllowFocused = false;
            this.CheckBoxRememberGameRegions.Properties.Caption = "Remember game regions";
            this.CheckBoxRememberGameRegions.Size = new System.Drawing.Size(164, 19);
            this.CheckBoxRememberGameRegions.TabIndex = 3;
            // 
            // CheckBoxAutoDetectGameTitles
            // 
            this.CheckBoxAutoDetectGameTitles.Location = new System.Drawing.Point(9, 32);
            this.CheckBoxAutoDetectGameTitles.Name = "CheckBoxAutoDetectGameTitles";
            this.CheckBoxAutoDetectGameTitles.Properties.AllowFocused = false;
            this.CheckBoxAutoDetectGameTitles.Properties.Caption = "Automatically detect game titles";
            this.CheckBoxAutoDetectGameTitles.Size = new System.Drawing.Size(212, 19);
            this.CheckBoxAutoDetectGameTitles.TabIndex = 2;
            // 
            // CheckBoxAutoDetectGameRegions
            // 
            this.CheckBoxAutoDetectGameRegions.Location = new System.Drawing.Point(9, 8);
            this.CheckBoxAutoDetectGameRegions.Name = "CheckBoxAutoDetectGameRegions";
            this.CheckBoxAutoDetectGameRegions.Properties.AllowFocused = false;
            this.CheckBoxAutoDetectGameRegions.Properties.Caption = "Automatically detect game regions";
            this.CheckBoxAutoDetectGameRegions.Size = new System.Drawing.Size(212, 19);
            this.CheckBoxAutoDetectGameRegions.TabIndex = 1;
            // 
            // CheckBoxSaveConsolePath
            // 
            this.CheckBoxSaveConsolePath.Location = new System.Drawing.Point(9, 32);
            this.CheckBoxSaveConsolePath.Name = "CheckBoxSaveConsolePath";
            this.CheckBoxSaveConsolePath.Properties.AllowFocused = false;
            this.CheckBoxSaveConsolePath.Properties.Caption = "Save current console directory path";
            this.CheckBoxSaveConsolePath.Size = new System.Drawing.Size(212, 19);
            this.CheckBoxSaveConsolePath.TabIndex = 2;
            // 
            // CheckBoxSaveLocalPath
            // 
            this.CheckBoxSaveLocalPath.Location = new System.Drawing.Point(9, 8);
            this.CheckBoxSaveLocalPath.Name = "CheckBoxSaveLocalPath";
            this.CheckBoxSaveLocalPath.Properties.AllowFocused = false;
            this.CheckBoxSaveLocalPath.Properties.Caption = "Save current local directory path";
            this.CheckBoxSaveLocalPath.Size = new System.Drawing.Size(212, 19);
            this.CheckBoxSaveLocalPath.TabIndex = 1;
            // 
            // CheckBoxShowFileSizeInBytes
            // 
            this.CheckBoxShowFileSizeInBytes.Location = new System.Drawing.Point(9, 8);
            this.CheckBoxShowFileSizeInBytes.Name = "CheckBoxShowFileSizeInBytes";
            this.CheckBoxShowFileSizeInBytes.Properties.AllowFocused = false;
            this.CheckBoxShowFileSizeInBytes.Properties.Caption = "Show file size in bytes";
            this.CheckBoxShowFileSizeInBytes.Size = new System.Drawing.Size(212, 19);
            this.CheckBoxShowFileSizeInBytes.TabIndex = 1;
            // 
            // ButtonSaveSettings
            // 
            this.ButtonSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonSaveSettings.Location = new System.Drawing.Point(141, 227);
            this.ButtonSaveSettings.Name = "ButtonSaveSettings";
            this.ButtonSaveSettings.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSaveSettings.Size = new System.Drawing.Size(97, 24);
            this.ButtonSaveSettings.TabIndex = 3;
            this.ButtonSaveSettings.Text = "Save Settings";
            this.ButtonSaveSettings.Click += new System.EventHandler(this.ButtonSaveSettings_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.TabDatabase;
            this.TabControl.Size = new System.Drawing.Size(355, 209);
            this.TabControl.TabIndex = 5;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabDatabase,
            this.TabContentRecognition,
            this.TabFileManager,
            this.TabFileSizes,
            this.XboxPeekPokeSettings});
            // 
            // TabDatabase
            // 
            this.TabDatabase.Controls.Add(this.labelControl1);
            this.TabDatabase.Controls.Add(this.RadioConsoles);
            this.TabDatabase.Name = "TabDatabase";
            this.TabDatabase.Size = new System.Drawing.Size(353, 182);
            this.TabDatabase.Text = "Database";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Set default database:";
            // 
            // RadioConsoles
            // 
            this.RadioConsoles.Location = new System.Drawing.Point(5, 25);
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
            this.TabContentRecognition.Controls.Add(this.CheckBoxRememberGameRegions);
            this.TabContentRecognition.Controls.Add(this.CheckBoxAutoDetectGameRegions);
            this.TabContentRecognition.Controls.Add(this.CheckBoxAutoDetectGameTitles);
            this.TabContentRecognition.Name = "TabContentRecognition";
            this.TabContentRecognition.Size = new System.Drawing.Size(353, 182);
            this.TabContentRecognition.Text = "Content Recognition";
            // 
            // TabFileManager
            // 
            this.TabFileManager.Controls.Add(this.CheckBoxSaveConsolePath);
            this.TabFileManager.Controls.Add(this.CheckBoxSaveLocalPath);
            this.TabFileManager.Name = "TabFileManager";
            this.TabFileManager.Size = new System.Drawing.Size(353, 182);
            this.TabFileManager.Text = "File Manager";
            // 
            // TabFileSizes
            // 
            this.TabFileSizes.Controls.Add(this.CheckBoxShowFileSizeInBytes);
            this.TabFileSizes.Name = "TabFileSizes";
            this.TabFileSizes.Size = new System.Drawing.Size(353, 182);
            this.TabFileSizes.Text = "File Sizes";
            // 
            // XboxPeekPokeSettings
            // 
            this.XboxPeekPokeSettings.Controls.Add(this.groupControl1);
            this.XboxPeekPokeSettings.Name = "XboxPeekPokeSettings";
            this.XboxPeekPokeSettings.Size = new System.Drawing.Size(353, 182);
            this.XboxPeekPokeSettings.Text = "Xbox Debugging";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.simpleButton7);
            this.groupControl1.Controls.Add(this.colorEdit1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.colorEdit2);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(204, 113);
            this.groupControl1.TabIndex = 147;
            this.groupControl1.Text = "HexBox Settings";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "ForeColor";
            // 
            // simpleButton7
            // 
            this.simpleButton7.AllowFocus = false;
            this.simpleButton7.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton7.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 7.2F);
            this.simpleButton7.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.simpleButton7.Appearance.Options.UseBackColor = true;
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Appearance.Options.UseForeColor = true;
            this.simpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton7.Location = new System.Drawing.Point(14, 82);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(185, 24);
            this.simpleButton7.TabIndex = 145;
            this.simpleButton7.Text = "Save Settings";
            // 
            // colorEdit1
            // 
            this.colorEdit1.EditValue = System.Drawing.Color.Empty;
            this.colorEdit1.Location = new System.Drawing.Point(114, 30);
            this.colorEdit1.Name = "colorEdit1";
            this.colorEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEdit1.Size = new System.Drawing.Size(86, 20);
            this.colorEdit1.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Background Color";
            // 
            // colorEdit2
            // 
            this.colorEdit2.EditValue = System.Drawing.Color.Empty;
            this.colorEdit2.Location = new System.Drawing.Point(114, 56);
            this.colorEdit2.Name = "colorEdit2";
            this.colorEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEdit2.Size = new System.Drawing.Size(86, 20);
            this.colorEdit2.TabIndex = 1;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 263);
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
            this.TabDatabase.ResumeLayout(false);
            this.TabDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadioConsoles.Properties)).EndInit();
            this.TabContentRecognition.ResumeLayout(false);
            this.TabFileManager.ResumeLayout(false);
            this.TabFileSizes.ResumeLayout(false);
            this.XboxPeekPokeSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEdit2.Properties)).EndInit();
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
        private DevExpress.XtraTab.XtraTabPage TabContentRecognition;
        private DevExpress.XtraTab.XtraTabPage TabFileManager;
        private DevExpress.XtraTab.XtraTabPage TabFileSizes;
        private DevExpress.XtraTab.XtraTabPage TabDatabase;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup RadioConsoles;
        private DevExpress.XtraTab.XtraTabPage XboxPeekPokeSettings;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.ColorEdit colorEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ColorEdit colorEdit2;
    }
}