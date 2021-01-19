namespace ModioX.Forms
{
    partial class BackupFileDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupFileDialog));
            this.LabelLocalFilePath = new DarkUI.Controls.DarkLabel();
            this.LabelInstallFilePath = new DarkUI.Controls.DarkLabel();
            this.LabelGameId = new DarkUI.Controls.DarkLabel();
            this.LabelFilename = new DarkUI.Controls.DarkLabel();
            this.TextBoxFileName = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxGameId = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxConsolePath = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxLocalPath = new DevExpress.XtraEditors.TextEdit();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonBrowseLocalPath = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsolePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLocalPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLocalFilePath
            // 
            this.LabelLocalFilePath.AutoSize = true;
            this.LabelLocalFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelLocalFilePath.Location = new System.Drawing.Point(12, 118);
            this.LabelLocalFilePath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelLocalFilePath.Name = "LabelLocalFilePath";
            this.LabelLocalFilePath.Size = new System.Drawing.Size(86, 15);
            this.LabelLocalFilePath.TabIndex = 7;
            this.LabelLocalFilePath.Text = "Local File Path:";
            // 
            // LabelInstallFilePath
            // 
            this.LabelInstallFilePath.AutoSize = true;
            this.LabelInstallFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelInstallFilePath.Location = new System.Drawing.Point(12, 65);
            this.LabelInstallFilePath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelInstallFilePath.Name = "LabelInstallFilePath";
            this.LabelInstallFilePath.Size = new System.Drawing.Size(89, 15);
            this.LabelInstallFilePath.TabIndex = 9;
            this.LabelInstallFilePath.Text = "Install File Path:";
            // 
            // LabelGameId
            // 
            this.LabelGameId.AutoSize = true;
            this.LabelGameId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameId.Location = new System.Drawing.Point(173, 12);
            this.LabelGameId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelGameId.Name = "LabelGameId";
            this.LabelGameId.Size = new System.Drawing.Size(54, 15);
            this.LabelGameId.TabIndex = 12;
            this.LabelGameId.Text = "Game Id:";
            // 
            // LabelFilename
            // 
            this.LabelFilename.AutoSize = true;
            this.LabelFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFilename.Location = new System.Drawing.Point(12, 12);
            this.LabelFilename.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelFilename.Name = "LabelFilename";
            this.LabelFilename.Size = new System.Drawing.Size(63, 15);
            this.LabelFilename.TabIndex = 14;
            this.LabelFilename.Text = "File Name:";
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFileName.Enabled = false;
            this.TextBoxFileName.Location = new System.Drawing.Point(12, 32);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.Properties.AllowFocused = false;
            this.TextBoxFileName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFileName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxFileName.Size = new System.Drawing.Size(158, 22);
            this.TextBoxFileName.TabIndex = 0;
            // 
            // TextBoxGameId
            // 
            this.TextBoxGameId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGameId.Enabled = false;
            this.TextBoxGameId.Location = new System.Drawing.Point(176, 32);
            this.TextBoxGameId.Name = "TextBoxGameId";
            this.TextBoxGameId.Properties.AllowFocused = false;
            this.TextBoxGameId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxGameId.Properties.Appearance.Options.UseFont = true;
            this.TextBoxGameId.Size = new System.Drawing.Size(135, 22);
            this.TextBoxGameId.TabIndex = 1;
            // 
            // TextBoxConsolePath
            // 
            this.TextBoxConsolePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConsolePath.Enabled = false;
            this.TextBoxConsolePath.Location = new System.Drawing.Point(12, 85);
            this.TextBoxConsolePath.Name = "TextBoxConsolePath";
            this.TextBoxConsolePath.Properties.AllowFocused = false;
            this.TextBoxConsolePath.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConsolePath.Properties.Appearance.Options.UseFont = true;
            this.TextBoxConsolePath.Size = new System.Drawing.Size(299, 22);
            this.TextBoxConsolePath.TabIndex = 2;
            // 
            // TextBoxLocalPath
            // 
            this.TextBoxLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLocalPath.Location = new System.Drawing.Point(12, 138);
            this.TextBoxLocalPath.Name = "TextBoxLocalPath";
            this.TextBoxLocalPath.Properties.AllowFocused = false;
            this.TextBoxLocalPath.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxLocalPath.Properties.Appearance.Options.UseFont = true;
            this.TextBoxLocalPath.Size = new System.Drawing.Size(248, 22);
            this.TextBoxLocalPath.TabIndex = 3;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(236, 177);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(155, 177);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 5;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonBrowseLocalPath
            // 
            this.ButtonBrowseLocalPath.Location = new System.Drawing.Point(266, 138);
            this.ButtonBrowseLocalPath.Name = "ButtonBrowseLocalPath";
            this.ButtonBrowseLocalPath.Size = new System.Drawing.Size(45, 22);
            this.ButtonBrowseLocalPath.TabIndex = 4;
            this.ButtonBrowseLocalPath.Text = "...";
            this.ButtonBrowseLocalPath.Click += new System.EventHandler(this.ButtonBrowseLocalPath_Click);
            // 
            // BackupFileDialog
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(323, 212);
            this.Controls.Add(this.ButtonBrowseLocalPath);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextBoxLocalPath);
            this.Controls.Add(this.TextBoxConsolePath);
            this.Controls.Add(this.TextBoxGameId);
            this.Controls.Add(this.TextBoxFileName);
            this.Controls.Add(this.LabelInstallFilePath);
            this.Controls.Add(this.LabelLocalFilePath);
            this.Controls.Add(this.LabelGameId);
            this.Controls.Add(this.LabelFilename);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("BackupFileDialog.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupFileDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup File Details";
            this.Load += new System.EventHandler(this.EditBackupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsolePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLocalPath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkLabel LabelLocalFilePath;
        private DarkUI.Controls.DarkLabel LabelInstallFilePath;
        private DarkUI.Controls.DarkLabel LabelGameId;
        private DarkUI.Controls.DarkLabel LabelFilename;
        private DevExpress.XtraEditors.TextEdit TextBoxFileName;
        private DevExpress.XtraEditors.TextEdit TextBoxGameId;
        private DevExpress.XtraEditors.TextEdit TextBoxConsolePath;
        private DevExpress.XtraEditors.TextEdit TextBoxLocalPath;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonOK;
        private DevExpress.XtraEditors.SimpleButton ButtonBrowseLocalPath;
    }
}