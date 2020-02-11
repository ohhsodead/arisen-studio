namespace ModioX.Forms.Game_File_Backups
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
            this.ButtonSaveBackup = new DarkUI.Controls.DarkButton();
            this.LabelLocalPath = new DarkUI.Controls.DarkLabel();
            this.TextBoxLocalPath = new DarkUI.Controls.DarkTextBox();
            this.LabelConsolePath = new DarkUI.Controls.DarkLabel();
            this.TextBoxConsolePath = new DarkUI.Controls.DarkTextBox();
            this.LabelGameId = new DarkUI.Controls.DarkLabel();
            this.TextBoxGameId = new DarkUI.Controls.DarkTextBox();
            this.LabelFilename = new DarkUI.Controls.DarkLabel();
            this.TextBoxFileName = new DarkUI.Controls.DarkTextBox();
            this.ButtonLocalPath = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.TextBoxName = new DarkUI.Controls.DarkTextBox();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.darkSectionPanel1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSaveBackup
            // 
            this.ButtonSaveBackup.Location = new System.Drawing.Point(203, 288);
            this.ButtonSaveBackup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonSaveBackup.Name = "ButtonSaveBackup";
            this.ButtonSaveBackup.Size = new System.Drawing.Size(119, 25);
            this.ButtonSaveBackup.TabIndex = 3;
            this.ButtonSaveBackup.Text = "Save Backup File";
            this.ButtonSaveBackup.Click += new System.EventHandler(this.ButtonBackupSave_Click);
            // 
            // LabelLocalPath
            // 
            this.LabelLocalPath.AutoSize = true;
            this.LabelLocalPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelLocalPath.Location = new System.Drawing.Point(6, 80);
            this.LabelLocalPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.LabelLocalPath.Name = "LabelLocalPath";
            this.LabelLocalPath.Size = new System.Drawing.Size(106, 20);
            this.LabelLocalPath.TabIndex = 7;
            this.LabelLocalPath.Text = "Local File Path:";
            // 
            // TextBoxLocalPath
            // 
            this.TextBoxLocalPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLocalPath.Location = new System.Drawing.Point(8, 100);
            this.TextBoxLocalPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxLocalPath.Name = "TextBoxLocalPath";
            this.TextBoxLocalPath.Size = new System.Drawing.Size(245, 27);
            this.TextBoxLocalPath.TabIndex = 6;
            // 
            // LabelConsolePath
            // 
            this.LabelConsolePath.AutoSize = true;
            this.LabelConsolePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelConsolePath.Location = new System.Drawing.Point(6, 29);
            this.LabelConsolePath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.LabelConsolePath.Name = "LabelConsolePath";
            this.LabelConsolePath.Size = new System.Drawing.Size(124, 20);
            this.LabelConsolePath.TabIndex = 9;
            this.LabelConsolePath.Text = "Console File Path:";
            // 
            // TextBoxConsolePath
            // 
            this.TextBoxConsolePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConsolePath.Enabled = false;
            this.TextBoxConsolePath.Location = new System.Drawing.Point(8, 51);
            this.TextBoxConsolePath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxConsolePath.Name = "TextBoxConsolePath";
            this.TextBoxConsolePath.ReadOnly = true;
            this.TextBoxConsolePath.Size = new System.Drawing.Size(295, 27);
            this.TextBoxConsolePath.TabIndex = 8;
            this.TextBoxConsolePath.TextChanged += new System.EventHandler(this.TextBoxConsolePath_TextChanged);
            // 
            // LabelGameId
            // 
            this.LabelGameId.AutoSize = true;
            this.LabelGameId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameId.Location = new System.Drawing.Point(167, 80);
            this.LabelGameId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.LabelGameId.Name = "LabelGameId";
            this.LabelGameId.Size = new System.Drawing.Size(89, 20);
            this.LabelGameId.TabIndex = 12;
            this.LabelGameId.Text = "Category Id:";
            // 
            // TextBoxGameId
            // 
            this.TextBoxGameId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxGameId.Enabled = false;
            this.TextBoxGameId.Location = new System.Drawing.Point(170, 100);
            this.TextBoxGameId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxGameId.Name = "TextBoxGameId";
            this.TextBoxGameId.ReadOnly = true;
            this.TextBoxGameId.Size = new System.Drawing.Size(132, 27);
            this.TextBoxGameId.TabIndex = 11;
            // 
            // LabelFilename
            // 
            this.LabelFilename.AutoSize = true;
            this.LabelFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFilename.Location = new System.Drawing.Point(6, 80);
            this.LabelFilename.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.LabelFilename.Name = "LabelFilename";
            this.LabelFilename.Size = new System.Drawing.Size(79, 20);
            this.LabelFilename.TabIndex = 14;
            this.LabelFilename.Text = "File Name:";
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxFileName.Enabled = false;
            this.TextBoxFileName.Location = new System.Drawing.Point(8, 100);
            this.TextBoxFileName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.ReadOnly = true;
            this.TextBoxFileName.Size = new System.Drawing.Size(156, 27);
            this.TextBoxFileName.TabIndex = 13;
            // 
            // ButtonLocalPath
            // 
            this.ButtonLocalPath.Location = new System.Drawing.Point(259, 100);
            this.ButtonLocalPath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonLocalPath.Name = "ButtonLocalPath";
            this.ButtonLocalPath.Size = new System.Drawing.Size(43, 25);
            this.ButtonLocalPath.TabIndex = 20;
            this.ButtonLocalPath.Text = "...";
            this.ButtonLocalPath.Click += new System.EventHandler(this.ButtonLocalPath_Click);
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.darkLabel1);
            this.darkSectionPanel1.Controls.Add(this.TextBoxName);
            this.darkSectionPanel1.Controls.Add(this.LabelFilename);
            this.darkSectionPanel1.Controls.Add(this.TextBoxFileName);
            this.darkSectionPanel1.Controls.Add(this.LabelGameId);
            this.darkSectionPanel1.Controls.Add(this.TextBoxGameId);
            this.darkSectionPanel1.Location = new System.Drawing.Point(11, 12);
            this.darkSectionPanel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Backup Details";
            this.darkSectionPanel1.Size = new System.Drawing.Size(310, 132);
            this.darkSectionPanel1.TabIndex = 21;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(6, 29);
            this.darkLabel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(52, 20);
            this.darkLabel1.TabIndex = 5;
            this.darkLabel1.Text = "Name:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.Location = new System.Drawing.Point(8, 51);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(295, 27);
            this.TextBoxName.TabIndex = 4;
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.LabelConsolePath);
            this.darkSectionPanel2.Controls.Add(this.TextBoxLocalPath);
            this.darkSectionPanel2.Controls.Add(this.ButtonLocalPath);
            this.darkSectionPanel2.Controls.Add(this.LabelLocalPath);
            this.darkSectionPanel2.Controls.Add(this.TextBoxConsolePath);
            this.darkSectionPanel2.Location = new System.Drawing.Point(11, 149);
            this.darkSectionPanel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "File Details";
            this.darkSectionPanel2.Size = new System.Drawing.Size(310, 132);
            this.darkSectionPanel2.TabIndex = 22;
            // 
            // EditBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 325);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.ButtonSaveBackup);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBackupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Backup File";
            this.Load += new System.EventHandler(this.EditBackupForm_Load);
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.darkSectionPanel2.ResumeLayout(false);
            this.darkSectionPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkButton ButtonSaveBackup;
        private DarkUI.Controls.DarkLabel LabelLocalPath;
        private DarkUI.Controls.DarkTextBox TextBoxLocalPath;
        private DarkUI.Controls.DarkLabel LabelConsolePath;
        private DarkUI.Controls.DarkTextBox TextBoxConsolePath;
        private DarkUI.Controls.DarkLabel LabelGameId;
        private DarkUI.Controls.DarkTextBox TextBoxGameId;
        private DarkUI.Controls.DarkLabel LabelFilename;
        private DarkUI.Controls.DarkTextBox TextBoxFileName;
        private DarkUI.Controls.DarkButton ButtonLocalPath;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox TextBoxName;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
    }
}