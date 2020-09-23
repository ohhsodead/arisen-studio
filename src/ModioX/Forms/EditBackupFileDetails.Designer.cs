namespace ModioX.Forms
{
    partial class EditBackupFileDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBackupFileDetails));
            this.ButtonSaveBackup = new DarkUI.Controls.DarkButton();
            this.LabelLocalFilePath = new DarkUI.Controls.DarkLabel();
            this.TextBoxLocalPath = new DarkUI.Controls.DarkTextBox();
            this.LabelInstallFilePath = new DarkUI.Controls.DarkLabel();
            this.TextBoxConsolePath = new DarkUI.Controls.DarkTextBox();
            this.LabelGameId = new DarkUI.Controls.DarkLabel();
            this.TextBoxGameId = new DarkUI.Controls.DarkTextBox();
            this.LabelFilename = new DarkUI.Controls.DarkLabel();
            this.TextBoxFileName = new DarkUI.Controls.DarkTextBox();
            this.ButtonLocalPath = new DarkUI.Controls.DarkButton();
            this.SectionBackupDetails = new DarkUI.Controls.DarkSectionPanel();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.TextBoxName = new DarkUI.Controls.DarkTextBox();
            this.SectionBackupDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSaveBackup
            // 
            this.ButtonSaveBackup.Location = new System.Drawing.Point(202, 264);
            this.ButtonSaveBackup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonSaveBackup.Name = "ButtonSaveBackup";
            this.ButtonSaveBackup.Size = new System.Drawing.Size(119, 25);
            this.ButtonSaveBackup.TabIndex = 6;
            this.ButtonSaveBackup.Text = "Save Backup File";
            this.ButtonSaveBackup.Click += new System.EventHandler(this.ButtonBackupSave_Click);
            // 
            // LabelLocalFilePath
            // 
            this.LabelLocalFilePath.AutoSize = true;
            this.LabelLocalFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelLocalFilePath.Location = new System.Drawing.Point(6, 188);
            this.LabelLocalFilePath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelLocalFilePath.Name = "LabelLocalFilePath";
            this.LabelLocalFilePath.Size = new System.Drawing.Size(86, 15);
            this.LabelLocalFilePath.TabIndex = 7;
            this.LabelLocalFilePath.Text = "Local File Path:";
            // 
            // TextBoxLocalPath
            // 
            this.TextBoxLocalPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLocalPath.Location = new System.Drawing.Point(8, 210);
            this.TextBoxLocalPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxLocalPath.Name = "TextBoxLocalPath";
            this.TextBoxLocalPath.Size = new System.Drawing.Size(246, 23);
            this.TextBoxLocalPath.TabIndex = 4;
            // 
            // LabelInstallFilePath
            // 
            this.LabelInstallFilePath.AutoSize = true;
            this.LabelInstallFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelInstallFilePath.Location = new System.Drawing.Point(6, 135);
            this.LabelInstallFilePath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelInstallFilePath.Name = "LabelInstallFilePath";
            this.LabelInstallFilePath.Size = new System.Drawing.Size(89, 15);
            this.LabelInstallFilePath.TabIndex = 9;
            this.LabelInstallFilePath.Text = "Install File Path:";
            // 
            // TextBoxConsolePath
            // 
            this.TextBoxConsolePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConsolePath.Enabled = false;
            this.TextBoxConsolePath.Location = new System.Drawing.Point(8, 157);
            this.TextBoxConsolePath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxConsolePath.Name = "TextBoxConsolePath";
            this.TextBoxConsolePath.ReadOnly = true;
            this.TextBoxConsolePath.Size = new System.Drawing.Size(295, 23);
            this.TextBoxConsolePath.TabIndex = 3;
            this.TextBoxConsolePath.TextChanged += new System.EventHandler(this.TextBoxConsolePath_TextChanged);
            // 
            // LabelGameId
            // 
            this.LabelGameId.AutoSize = true;
            this.LabelGameId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameId.Location = new System.Drawing.Point(167, 84);
            this.LabelGameId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelGameId.Name = "LabelGameId";
            this.LabelGameId.Size = new System.Drawing.Size(54, 15);
            this.LabelGameId.TabIndex = 12;
            this.LabelGameId.Text = "Game Id:";
            // 
            // TextBoxGameId
            // 
            this.TextBoxGameId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxGameId.Enabled = false;
            this.TextBoxGameId.Location = new System.Drawing.Point(170, 104);
            this.TextBoxGameId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxGameId.Name = "TextBoxGameId";
            this.TextBoxGameId.ReadOnly = true;
            this.TextBoxGameId.Size = new System.Drawing.Size(133, 23);
            this.TextBoxGameId.TabIndex = 2;
            // 
            // LabelFilename
            // 
            this.LabelFilename.AutoSize = true;
            this.LabelFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFilename.Location = new System.Drawing.Point(6, 84);
            this.LabelFilename.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelFilename.Name = "LabelFilename";
            this.LabelFilename.Size = new System.Drawing.Size(63, 15);
            this.LabelFilename.TabIndex = 14;
            this.LabelFilename.Text = "File Name:";
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxFileName.Enabled = false;
            this.TextBoxFileName.Location = new System.Drawing.Point(8, 104);
            this.TextBoxFileName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.ReadOnly = true;
            this.TextBoxFileName.Size = new System.Drawing.Size(156, 23);
            this.TextBoxFileName.TabIndex = 1;
            // 
            // ButtonLocalPath
            // 
            this.ButtonLocalPath.Location = new System.Drawing.Point(260, 210);
            this.ButtonLocalPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonLocalPath.Name = "ButtonLocalPath";
            this.ButtonLocalPath.Size = new System.Drawing.Size(43, 25);
            this.ButtonLocalPath.TabIndex = 5;
            this.ButtonLocalPath.Text = "...";
            this.ButtonLocalPath.Click += new System.EventHandler(this.ButtonLocalPath_Click);
            // 
            // SectionBackupDetails
            // 
            this.SectionBackupDetails.Controls.Add(this.LabelInstallFilePath);
            this.SectionBackupDetails.Controls.Add(this.TextBoxLocalPath);
            this.SectionBackupDetails.Controls.Add(this.darkLabel1);
            this.SectionBackupDetails.Controls.Add(this.ButtonLocalPath);
            this.SectionBackupDetails.Controls.Add(this.TextBoxName);
            this.SectionBackupDetails.Controls.Add(this.LabelLocalFilePath);
            this.SectionBackupDetails.Controls.Add(this.LabelFilename);
            this.SectionBackupDetails.Controls.Add(this.TextBoxConsolePath);
            this.SectionBackupDetails.Controls.Add(this.TextBoxFileName);
            this.SectionBackupDetails.Controls.Add(this.LabelGameId);
            this.SectionBackupDetails.Controls.Add(this.TextBoxGameId);
            this.SectionBackupDetails.Location = new System.Drawing.Point(12, 12);
            this.SectionBackupDetails.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SectionBackupDetails.Name = "SectionBackupDetails";
            this.SectionBackupDetails.SectionHeader = "BACKUP FILE DETAILS";
            this.SectionBackupDetails.Size = new System.Drawing.Size(310, 242);
            this.SectionBackupDetails.TabIndex = 0;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(6, 31);
            this.darkLabel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(42, 15);
            this.darkLabel1.TabIndex = 5;
            this.darkLabel1.Text = "Name:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.Location = new System.Drawing.Point(8, 53);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(295, 23);
            this.TextBoxName.TabIndex = 0;
            // 
            // EditBackupFileDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 303);
            this.Controls.Add(this.SectionBackupDetails);
            this.Controls.Add(this.ButtonSaveBackup);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBackupFileDetails";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Backup File";
            this.Load += new System.EventHandler(this.EditBackupForm_Load);
            this.SectionBackupDetails.ResumeLayout(false);
            this.SectionBackupDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkButton ButtonSaveBackup;
        private DarkUI.Controls.DarkLabel LabelLocalFilePath;
        private DarkUI.Controls.DarkTextBox TextBoxLocalPath;
        private DarkUI.Controls.DarkLabel LabelInstallFilePath;
        private DarkUI.Controls.DarkTextBox TextBoxConsolePath;
        private DarkUI.Controls.DarkLabel LabelGameId;
        private DarkUI.Controls.DarkTextBox TextBoxGameId;
        private DarkUI.Controls.DarkLabel LabelFilename;
        private DarkUI.Controls.DarkTextBox TextBoxFileName;
        private DarkUI.Controls.DarkButton ButtonLocalPath;
        private DarkUI.Controls.DarkSectionPanel SectionBackupDetails;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox TextBoxName;
    }
}