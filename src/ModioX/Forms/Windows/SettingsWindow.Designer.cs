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
            this.ButtonOK = new DarkUI.Controls.DarkButton();
            this.CheckBoxAutoDetectGameRegions = new DarkUI.Controls.DarkCheckBox();
            this.CheckBoxRememberGameRegions = new DarkUI.Controls.DarkCheckBox();
            this.CheckBoxAutoDetectGameTitles = new DarkUI.Controls.DarkCheckBox();
            this.SectionContentRecognition = new DarkUI.Controls.DarkSectionPanel();
            this.SectionFileManager = new DarkUI.Controls.DarkSectionPanel();
            this.CheckBoxSaveLocalPath = new DarkUI.Controls.DarkCheckBox();
            this.CheckBoxSaveConsolePath = new DarkUI.Controls.DarkCheckBox();
            this.SectionFileSizes = new DarkUI.Controls.DarkSectionPanel();
            this.CheckBoxShowFileSizeInBytes = new DarkUI.Controls.DarkCheckBox();
            this.SectionContentRecognition.SuspendLayout();
            this.SectionFileManager.SuspendLayout();
            this.SectionFileSizes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonOK.Location = new System.Drawing.Point(149, 296);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(85, 25);
            this.ButtonOK.TabIndex = 7;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // CheckBoxAutoDetectGameRegions
            // 
            this.CheckBoxAutoDetectGameRegions.AutoSize = true;
            this.CheckBoxAutoDetectGameRegions.Location = new System.Drawing.Point(10, 31);
            this.CheckBoxAutoDetectGameRegions.Name = "CheckBoxAutoDetectGameRegions";
            this.CheckBoxAutoDetectGameRegions.Size = new System.Drawing.Size(211, 19);
            this.CheckBoxAutoDetectGameRegions.TabIndex = 1;
            this.CheckBoxAutoDetectGameRegions.Text = "Automatically detect game regions";
            // 
            // CheckBoxRememberGameRegions
            // 
            this.CheckBoxRememberGameRegions.AutoSize = true;
            this.CheckBoxRememberGameRegions.Location = new System.Drawing.Point(10, 81);
            this.CheckBoxRememberGameRegions.Name = "CheckBoxRememberGameRegions";
            this.CheckBoxRememberGameRegions.Size = new System.Drawing.Size(159, 19);
            this.CheckBoxRememberGameRegions.TabIndex = 3;
            this.CheckBoxRememberGameRegions.Text = "Remember game regions";
            // 
            // CheckBoxAutoDetectGameTitles
            // 
            this.CheckBoxAutoDetectGameTitles.AutoSize = true;
            this.CheckBoxAutoDetectGameTitles.Location = new System.Drawing.Point(10, 56);
            this.CheckBoxAutoDetectGameTitles.Name = "CheckBoxAutoDetectGameTitles";
            this.CheckBoxAutoDetectGameTitles.Size = new System.Drawing.Size(197, 19);
            this.CheckBoxAutoDetectGameTitles.TabIndex = 2;
            this.CheckBoxAutoDetectGameTitles.Text = "Automatically detect game titles";
            // 
            // SectionContentRecognition
            // 
            this.SectionContentRecognition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionContentRecognition.Controls.Add(this.CheckBoxAutoDetectGameRegions);
            this.SectionContentRecognition.Controls.Add(this.CheckBoxRememberGameRegions);
            this.SectionContentRecognition.Controls.Add(this.CheckBoxAutoDetectGameTitles);
            this.SectionContentRecognition.Location = new System.Drawing.Point(13, 13);
            this.SectionContentRecognition.Margin = new System.Windows.Forms.Padding(4);
            this.SectionContentRecognition.Name = "SectionContentRecognition";
            this.SectionContentRecognition.SectionHeader = "Content Recognition";
            this.SectionContentRecognition.Size = new System.Drawing.Size(356, 108);
            this.SectionContentRecognition.TabIndex = 0;
            this.SectionContentRecognition.TabStop = true;
            // 
            // SectionFileManager
            // 
            this.SectionFileManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionFileManager.Controls.Add(this.CheckBoxSaveLocalPath);
            this.SectionFileManager.Controls.Add(this.CheckBoxSaveConsolePath);
            this.SectionFileManager.Location = new System.Drawing.Point(13, 130);
            this.SectionFileManager.Margin = new System.Windows.Forms.Padding(4);
            this.SectionFileManager.Name = "SectionFileManager";
            this.SectionFileManager.SectionHeader = "File Manager";
            this.SectionFileManager.Size = new System.Drawing.Size(356, 84);
            this.SectionFileManager.TabIndex = 4;
            this.SectionFileManager.TabStop = true;
            // 
            // CheckBoxSaveLocalPath
            // 
            this.CheckBoxSaveLocalPath.AutoSize = true;
            this.CheckBoxSaveLocalPath.Location = new System.Drawing.Point(10, 31);
            this.CheckBoxSaveLocalPath.Name = "CheckBoxSaveLocalPath";
            this.CheckBoxSaveLocalPath.Size = new System.Drawing.Size(196, 19);
            this.CheckBoxSaveLocalPath.TabIndex = 5;
            this.CheckBoxSaveLocalPath.Text = "Save current local directory path";
            // 
            // CheckBoxSaveConsolePath
            // 
            this.CheckBoxSaveConsolePath.AutoSize = true;
            this.CheckBoxSaveConsolePath.Location = new System.Drawing.Point(10, 56);
            this.CheckBoxSaveConsolePath.Name = "CheckBoxSaveConsolePath";
            this.CheckBoxSaveConsolePath.Size = new System.Drawing.Size(212, 19);
            this.CheckBoxSaveConsolePath.TabIndex = 6;
            this.CheckBoxSaveConsolePath.Text = "Save current console directory path";
            // 
            // SectionFileSizes
            // 
            this.SectionFileSizes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionFileSizes.Controls.Add(this.CheckBoxShowFileSizeInBytes);
            this.SectionFileSizes.Location = new System.Drawing.Point(13, 222);
            this.SectionFileSizes.Margin = new System.Windows.Forms.Padding(4);
            this.SectionFileSizes.Name = "SectionFileSizes";
            this.SectionFileSizes.SectionHeader = "File Sizes";
            this.SectionFileSizes.Size = new System.Drawing.Size(356, 59);
            this.SectionFileSizes.TabIndex = 7;
            this.SectionFileSizes.TabStop = true;
            // 
            // CheckBoxShowFileSizeInBytes
            // 
            this.CheckBoxShowFileSizeInBytes.AutoSize = true;
            this.CheckBoxShowFileSizeInBytes.Location = new System.Drawing.Point(10, 31);
            this.CheckBoxShowFileSizeInBytes.Name = "CheckBoxShowFileSizeInBytes";
            this.CheckBoxShowFileSizeInBytes.Size = new System.Drawing.Size(140, 19);
            this.CheckBoxShowFileSizeInBytes.TabIndex = 5;
            this.CheckBoxShowFileSizeInBytes.Text = "Show file size in bytes";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 339);
            this.Controls.Add(this.SectionFileSizes);
            this.Controls.Add(this.SectionFileManager);
            this.Controls.Add(this.SectionContentRecognition);
            this.Controls.Add(this.ButtonOK);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.SectionContentRecognition.ResumeLayout(false);
            this.SectionContentRecognition.PerformLayout();
            this.SectionFileManager.ResumeLayout(false);
            this.SectionFileManager.PerformLayout();
            this.SectionFileSizes.ResumeLayout(false);
            this.SectionFileSizes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkButton ButtonOK;
        private DarkUI.Controls.DarkCheckBox CheckBoxAutoDetectGameRegions;
        private DarkUI.Controls.DarkCheckBox CheckBoxRememberGameRegions;
        private DarkUI.Controls.DarkCheckBox CheckBoxAutoDetectGameTitles;
        private DarkUI.Controls.DarkSectionPanel SectionContentRecognition;
        private DarkUI.Controls.DarkSectionPanel SectionFileManager;
        private DarkUI.Controls.DarkCheckBox CheckBoxSaveLocalPath;
        private DarkUI.Controls.DarkCheckBox CheckBoxSaveConsolePath;
        private DarkUI.Controls.DarkSectionPanel SectionFileSizes;
        private DarkUI.Controls.DarkCheckBox CheckBoxShowFileSizeInBytes;
    }
}