
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
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.TabContentRecognition = new DevExpress.XtraTab.XtraTabPage();
            this.TabFileManager = new DevExpress.XtraTab.XtraTabPage();
            this.TabFileSizes = new DevExpress.XtraTab.XtraTabPage();
            this.TabConsoles = new DevExpress.XtraTab.XtraTabPage();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxRememberGameRegions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameTitles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameRegions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveConsolePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveLocalPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxShowFileSizeInBytes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabContentRecognition.SuspendLayout();
            this.TabFileManager.SuspendLayout();
            this.TabFileSizes.SuspendLayout();
            this.TabConsoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckBoxRememberGameRegions
            // 
            this.CheckBoxRememberGameRegions.Location = new System.Drawing.Point(9, 56);
            this.CheckBoxRememberGameRegions.Name = "CheckBoxRememberGameRegions";
            this.CheckBoxRememberGameRegions.Properties.AllowFocused = false;
            this.CheckBoxRememberGameRegions.Properties.Caption = "Remember game regions";
            this.CheckBoxRememberGameRegions.Size = new System.Drawing.Size(164, 18);
            this.CheckBoxRememberGameRegions.TabIndex = 3;
            // 
            // CheckBoxAutoDetectGameTitles
            // 
            this.CheckBoxAutoDetectGameTitles.Location = new System.Drawing.Point(9, 32);
            this.CheckBoxAutoDetectGameTitles.Name = "CheckBoxAutoDetectGameTitles";
            this.CheckBoxAutoDetectGameTitles.Properties.AllowFocused = false;
            this.CheckBoxAutoDetectGameTitles.Properties.Caption = "Automatically detect game titles";
            this.CheckBoxAutoDetectGameTitles.Size = new System.Drawing.Size(212, 18);
            this.CheckBoxAutoDetectGameTitles.TabIndex = 2;
            // 
            // CheckBoxAutoDetectGameRegions
            // 
            this.CheckBoxAutoDetectGameRegions.Location = new System.Drawing.Point(9, 8);
            this.CheckBoxAutoDetectGameRegions.Name = "CheckBoxAutoDetectGameRegions";
            this.CheckBoxAutoDetectGameRegions.Properties.AllowFocused = false;
            this.CheckBoxAutoDetectGameRegions.Properties.Caption = "Automatically detect game regions";
            this.CheckBoxAutoDetectGameRegions.Size = new System.Drawing.Size(212, 18);
            this.CheckBoxAutoDetectGameRegions.TabIndex = 1;
            // 
            // CheckBoxSaveConsolePath
            // 
            this.CheckBoxSaveConsolePath.Location = new System.Drawing.Point(9, 32);
            this.CheckBoxSaveConsolePath.Name = "CheckBoxSaveConsolePath";
            this.CheckBoxSaveConsolePath.Properties.AllowFocused = false;
            this.CheckBoxSaveConsolePath.Properties.Caption = "Save current console directory path";
            this.CheckBoxSaveConsolePath.Size = new System.Drawing.Size(212, 18);
            this.CheckBoxSaveConsolePath.TabIndex = 2;
            // 
            // CheckBoxSaveLocalPath
            // 
            this.CheckBoxSaveLocalPath.Location = new System.Drawing.Point(9, 8);
            this.CheckBoxSaveLocalPath.Name = "CheckBoxSaveLocalPath";
            this.CheckBoxSaveLocalPath.Properties.AllowFocused = false;
            this.CheckBoxSaveLocalPath.Properties.Caption = "Save current local directory path";
            this.CheckBoxSaveLocalPath.Size = new System.Drawing.Size(212, 18);
            this.CheckBoxSaveLocalPath.TabIndex = 1;
            // 
            // CheckBoxShowFileSizeInBytes
            // 
            this.CheckBoxShowFileSizeInBytes.Location = new System.Drawing.Point(9, 8);
            this.CheckBoxShowFileSizeInBytes.Name = "CheckBoxShowFileSizeInBytes";
            this.CheckBoxShowFileSizeInBytes.Properties.AllowFocused = false;
            this.CheckBoxShowFileSizeInBytes.Properties.Caption = "Show file size in bytes";
            this.CheckBoxShowFileSizeInBytes.Size = new System.Drawing.Size(212, 18);
            this.CheckBoxShowFileSizeInBytes.TabIndex = 1;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonOK.Location = new System.Drawing.Point(152, 228);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 3;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.TabContentRecognition;
            this.TabControl.Size = new System.Drawing.Size(355, 210);
            this.TabControl.TabIndex = 5;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabConsoles,
            this.TabContentRecognition,
            this.TabFileManager,
            this.TabFileSizes});
            // 
            // TabContentRecognition
            // 
            this.TabContentRecognition.Controls.Add(this.CheckBoxRememberGameRegions);
            this.TabContentRecognition.Controls.Add(this.CheckBoxAutoDetectGameRegions);
            this.TabContentRecognition.Controls.Add(this.CheckBoxAutoDetectGameTitles);
            this.TabContentRecognition.Name = "TabContentRecognition";
            this.TabContentRecognition.Size = new System.Drawing.Size(353, 187);
            this.TabContentRecognition.Text = "Content Recognition";
            // 
            // TabFileManager
            // 
            this.TabFileManager.Controls.Add(this.CheckBoxSaveConsolePath);
            this.TabFileManager.Controls.Add(this.CheckBoxSaveLocalPath);
            this.TabFileManager.Name = "TabFileManager";
            this.TabFileManager.Size = new System.Drawing.Size(353, 187);
            this.TabFileManager.Text = "File Manager";
            // 
            // TabFileSizes
            // 
            this.TabFileSizes.Controls.Add(this.CheckBoxShowFileSizeInBytes);
            this.TabFileSizes.Name = "TabFileSizes";
            this.TabFileSizes.Size = new System.Drawing.Size(353, 187);
            this.TabFileSizes.Text = "File Sizes";
            // 
            // TabConsoles
            // 
            this.TabConsoles.Controls.Add(this.labelControl1);
            this.TabConsoles.Controls.Add(this.radioGroup1);
            this.TabConsoles.Name = "TabConsoles";
            this.TabConsoles.Size = new System.Drawing.Size(353, 187);
            this.TabConsoles.Text = "PS3/XBOX";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(5, 27);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "PS3 Mods"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Xbox Mods")});
            this.radioGroup1.Size = new System.Drawing.Size(117, 58);
            this.radioGroup1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(133, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Load database by default:";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 263);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ButtonOK);
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
            this.TabContentRecognition.ResumeLayout(false);
            this.TabFileManager.ResumeLayout(false);
            this.TabFileSizes.ResumeLayout(false);
            this.TabConsoles.ResumeLayout(false);
            this.TabConsoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.CheckEdit CheckBoxAutoDetectGameTitles;
        private DevExpress.XtraEditors.CheckEdit CheckBoxAutoDetectGameRegions;
        private DevExpress.XtraEditors.CheckEdit CheckBoxSaveConsolePath;
        private DevExpress.XtraEditors.CheckEdit CheckBoxSaveLocalPath;
        private DevExpress.XtraEditors.CheckEdit CheckBoxShowFileSizeInBytes;
        private DevExpress.XtraEditors.SimpleButton ButtonOK;
        private DevExpress.XtraEditors.CheckEdit CheckBoxRememberGameRegions;
        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage TabContentRecognition;
        private DevExpress.XtraTab.XtraTabPage TabFileManager;
        private DevExpress.XtraTab.XtraTabPage TabFileSizes;
        private DevExpress.XtraTab.XtraTabPage TabConsoles;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
    }
}