namespace ModioX.Windows
{
    partial class EditBackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBackupForm));
            this.TextBoxName = new DarkUI.Controls.DarkTextBox();
            this.ButtonSaveBackup = new DarkUI.Controls.DarkButton();
            this.LabelName = new DarkUI.Controls.DarkLabel();
            this.LabelLocalPath = new DarkUI.Controls.DarkLabel();
            this.TextBoxLocalPath = new DarkUI.Controls.DarkTextBox();
            this.LabelConsolePath = new DarkUI.Controls.DarkLabel();
            this.TextBoxConsolePath = new DarkUI.Controls.DarkTextBox();
            this.LabelGameId = new DarkUI.Controls.DarkLabel();
            this.TextBoxGameId = new DarkUI.Controls.DarkTextBox();
            this.LabelFilename = new DarkUI.Controls.DarkLabel();
            this.TextBoxFileName = new DarkUI.Controls.DarkTextBox();
            this.ButtonLocalPath = new DarkUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.Location = new System.Drawing.Point(12, 31);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(297, 23);
            this.TextBoxName.TabIndex = 4;
            // 
            // ButtonSaveBackup
            // 
            this.ButtonSaveBackup.Location = new System.Drawing.Point(208, 205);
            this.ButtonSaveBackup.Name = "ButtonSaveBackup";
            this.ButtonSaveBackup.Size = new System.Drawing.Size(101, 24);
            this.ButtonSaveBackup.TabIndex = 3;
            this.ButtonSaveBackup.Text = "Save Backup";
            this.ButtonSaveBackup.Click += new System.EventHandler(this.ButtonBackupSave_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelName.Location = new System.Drawing.Point(12, 12);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(42, 15);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Name:";
            // 
            // LabelLocalPath
            // 
            this.LabelLocalPath.AutoSize = true;
            this.LabelLocalPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelLocalPath.Location = new System.Drawing.Point(12, 108);
            this.LabelLocalPath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.LabelLocalPath.Name = "LabelLocalPath";
            this.LabelLocalPath.Size = new System.Drawing.Size(147, 15);
            this.LabelLocalPath.TabIndex = 7;
            this.LabelLocalPath.Text = "Local Path (case sensitive):";
            // 
            // TextBoxLocalPath
            // 
            this.TextBoxLocalPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLocalPath.Location = new System.Drawing.Point(12, 127);
            this.TextBoxLocalPath.Name = "TextBoxLocalPath";
            this.TextBoxLocalPath.Size = new System.Drawing.Size(248, 23);
            this.TextBoxLocalPath.TabIndex = 6;
            // 
            // LabelConsolePath
            // 
            this.LabelConsolePath.AutoSize = true;
            this.LabelConsolePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelConsolePath.Location = new System.Drawing.Point(12, 156);
            this.LabelConsolePath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.LabelConsolePath.Name = "LabelConsolePath";
            this.LabelConsolePath.Size = new System.Drawing.Size(162, 15);
            this.LabelConsolePath.TabIndex = 9;
            this.LabelConsolePath.Text = "Console Path (case sensitive):";
            // 
            // TextBoxConsolePath
            // 
            this.TextBoxConsolePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConsolePath.Location = new System.Drawing.Point(12, 175);
            this.TextBoxConsolePath.Name = "TextBoxConsolePath";
            this.TextBoxConsolePath.Size = new System.Drawing.Size(297, 23);
            this.TextBoxConsolePath.TabIndex = 8;
            // 
            // LabelGameId
            // 
            this.LabelGameId.AutoSize = true;
            this.LabelGameId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameId.Location = new System.Drawing.Point(174, 60);
            this.LabelGameId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.LabelGameId.Name = "LabelGameId";
            this.LabelGameId.Size = new System.Drawing.Size(54, 15);
            this.LabelGameId.TabIndex = 12;
            this.LabelGameId.Text = "Game Id:";
            // 
            // TextBoxGameId
            // 
            this.TextBoxGameId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxGameId.Enabled = false;
            this.TextBoxGameId.Location = new System.Drawing.Point(174, 79);
            this.TextBoxGameId.Name = "TextBoxGameId";
            this.TextBoxGameId.ReadOnly = true;
            this.TextBoxGameId.Size = new System.Drawing.Size(135, 23);
            this.TextBoxGameId.TabIndex = 11;
            // 
            // LabelFilename
            // 
            this.LabelFilename.AutoSize = true;
            this.LabelFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFilename.Location = new System.Drawing.Point(12, 60);
            this.LabelFilename.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.LabelFilename.Name = "LabelFilename";
            this.LabelFilename.Size = new System.Drawing.Size(63, 15);
            this.LabelFilename.TabIndex = 14;
            this.LabelFilename.Text = "File Name:";
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxFileName.Enabled = false;
            this.TextBoxFileName.Location = new System.Drawing.Point(12, 79);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.ReadOnly = true;
            this.TextBoxFileName.Size = new System.Drawing.Size(156, 23);
            this.TextBoxFileName.TabIndex = 13;
            // 
            // ButtonLocalPath
            // 
            this.ButtonLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLocalPath.Location = new System.Drawing.Point(266, 127);
            this.ButtonLocalPath.Name = "ButtonLocalPath";
            this.ButtonLocalPath.Size = new System.Drawing.Size(43, 23);
            this.ButtonLocalPath.TabIndex = 20;
            this.ButtonLocalPath.Text = "...";
            this.ButtonLocalPath.Click += new System.EventHandler(this.ButtonLocalPath_Click);
            // 
            // EditBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(321, 241);
            this.Controls.Add(this.ButtonLocalPath);
            this.Controls.Add(this.LabelFilename);
            this.Controls.Add(this.TextBoxFileName);
            this.Controls.Add(this.LabelGameId);
            this.Controls.Add(this.TextBoxGameId);
            this.Controls.Add(this.LabelConsolePath);
            this.Controls.Add(this.TextBoxConsolePath);
            this.Controls.Add(this.LabelLocalPath);
            this.Controls.Add(this.TextBoxLocalPath);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonSaveBackup);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBackupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Backup";
            this.Load += new System.EventHandler(this.EditBackupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkTextBox TextBoxName;
        private DarkUI.Controls.DarkButton ButtonSaveBackup;
        private DarkUI.Controls.DarkLabel LabelName;
        private DarkUI.Controls.DarkLabel LabelLocalPath;
        private DarkUI.Controls.DarkTextBox TextBoxLocalPath;
        private DarkUI.Controls.DarkLabel LabelConsolePath;
        private DarkUI.Controls.DarkTextBox TextBoxConsolePath;
        private DarkUI.Controls.DarkLabel LabelGameId;
        private DarkUI.Controls.DarkTextBox TextBoxGameId;
        private DarkUI.Controls.DarkLabel LabelFilename;
        private DarkUI.Controls.DarkTextBox TextBoxFileName;
        private DarkUI.Controls.DarkButton ButtonLocalPath;
    }
}