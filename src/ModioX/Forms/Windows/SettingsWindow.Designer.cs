
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.CheckBoxRememberGameRegions = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxAutoDetectGameTitles = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxAutoDetectGameRegions = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.CheckBoxSaveConsolePath = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxSaveLocalPath = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.CheckBoxShowFileSizeInBytes = new DevExpress.XtraEditors.CheckEdit();
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxRememberGameRegions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameTitles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameRegions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveConsolePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveLocalPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxShowFileSizeInBytes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.CheckBoxRememberGameRegions);
            this.groupControl1.Controls.Add(this.CheckBoxAutoDetectGameTitles);
            this.groupControl1.Controls.Add(this.CheckBoxAutoDetectGameRegions);
            this.groupControl1.Location = new System.Drawing.Point(14, 10);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(354, 103);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Content Recognition";
            // 
            // CheckBoxRememberGameRegions
            // 
            this.CheckBoxRememberGameRegions.Location = new System.Drawing.Point(6, 76);
            this.CheckBoxRememberGameRegions.Name = "CheckBoxRememberGameRegions";
            this.CheckBoxRememberGameRegions.Properties.Caption = "Remember game regions";
            this.CheckBoxRememberGameRegions.Size = new System.Drawing.Size(164, 18);
            this.CheckBoxRememberGameRegions.TabIndex = 3;
            // 
            // CheckBoxAutoDetectGameTitles
            // 
            this.CheckBoxAutoDetectGameTitles.Location = new System.Drawing.Point(6, 52);
            this.CheckBoxAutoDetectGameTitles.Name = "CheckBoxAutoDetectGameTitles";
            this.CheckBoxAutoDetectGameTitles.Properties.Caption = "Automatically detect game titles";
            this.CheckBoxAutoDetectGameTitles.Size = new System.Drawing.Size(212, 18);
            this.CheckBoxAutoDetectGameTitles.TabIndex = 2;
            // 
            // CheckBoxAutoDetectGameRegions
            // 
            this.CheckBoxAutoDetectGameRegions.Location = new System.Drawing.Point(6, 28);
            this.CheckBoxAutoDetectGameRegions.Name = "CheckBoxAutoDetectGameRegions";
            this.CheckBoxAutoDetectGameRegions.Properties.Caption = "Automatically detect game regions";
            this.CheckBoxAutoDetectGameRegions.Size = new System.Drawing.Size(212, 18);
            this.CheckBoxAutoDetectGameRegions.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.CheckBoxSaveConsolePath);
            this.groupControl2.Controls.Add(this.CheckBoxSaveLocalPath);
            this.groupControl2.Location = new System.Drawing.Point(14, 124);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(354, 76);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "File Manager";
            // 
            // CheckBoxSaveConsolePath
            // 
            this.CheckBoxSaveConsolePath.Location = new System.Drawing.Point(6, 52);
            this.CheckBoxSaveConsolePath.Name = "CheckBoxSaveConsolePath";
            this.CheckBoxSaveConsolePath.Properties.Caption = "Save current console directory path";
            this.CheckBoxSaveConsolePath.Size = new System.Drawing.Size(212, 18);
            this.CheckBoxSaveConsolePath.TabIndex = 2;
            // 
            // CheckBoxSaveLocalPath
            // 
            this.CheckBoxSaveLocalPath.Location = new System.Drawing.Point(6, 28);
            this.CheckBoxSaveLocalPath.Name = "CheckBoxSaveLocalPath";
            this.CheckBoxSaveLocalPath.Properties.Caption = "Save current local directory path";
            this.CheckBoxSaveLocalPath.Size = new System.Drawing.Size(212, 18);
            this.CheckBoxSaveLocalPath.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.CheckBoxShowFileSizeInBytes);
            this.groupControl3.Location = new System.Drawing.Point(14, 209);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(354, 60);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "File Sizes";
            // 
            // CheckBoxShowFileSizeInBytes
            // 
            this.CheckBoxShowFileSizeInBytes.Location = new System.Drawing.Point(6, 28);
            this.CheckBoxShowFileSizeInBytes.Name = "CheckBoxShowFileSizeInBytes";
            this.CheckBoxShowFileSizeInBytes.Properties.Caption = "Show file size in bytes";
            this.CheckBoxShowFileSizeInBytes.Size = new System.Drawing.Size(212, 18);
            this.CheckBoxShowFileSizeInBytes.TabIndex = 1;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(154, 304);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 3;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 339);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.MaximumSize = new System.Drawing.Size(384, 371);
            this.MinimumSize = new System.Drawing.Size(384, 371);
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxRememberGameRegions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameTitles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoDetectGameRegions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveConsolePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxSaveLocalPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxShowFileSizeInBytes.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit CheckBoxAutoDetectGameTitles;
        private DevExpress.XtraEditors.CheckEdit CheckBoxAutoDetectGameRegions;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit CheckBoxSaveConsolePath;
        private DevExpress.XtraEditors.CheckEdit CheckBoxSaveLocalPath;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.CheckEdit CheckBoxShowFileSizeInBytes;
        private DevExpress.XtraEditors.SimpleButton ButtonOK;
        private DevExpress.XtraEditors.CheckEdit CheckBoxRememberGameRegions;
    }
}