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
            this.TextBoxDescription = new DarkUI.Controls.DarkTextBox();
            this.LabelDescription = new DarkUI.Controls.DarkLabel();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.darkSectionPanel1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSaveBackup
            // 
            this.ButtonSaveBackup.Location = new System.Drawing.Point(215, 369);
            this.ButtonSaveBackup.Name = "ButtonSaveBackup";
            this.ButtonSaveBackup.Size = new System.Drawing.Size(107, 24);
            this.ButtonSaveBackup.TabIndex = 3;
            this.ButtonSaveBackup.Text = "Save Backup";
            this.ButtonSaveBackup.Click += new System.EventHandler(this.ButtonBackupSave_Click);
            // 
            // LabelLocalPath
            // 
            this.LabelLocalPath.AutoSize = true;
            this.LabelLocalPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelLocalPath.Location = new System.Drawing.Point(4, 81);
            this.LabelLocalPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelLocalPath.Name = "LabelLocalPath";
            this.LabelLocalPath.Size = new System.Drawing.Size(86, 15);
            this.LabelLocalPath.TabIndex = 7;
            this.LabelLocalPath.Text = "Local File Path:";
            // 
            // TextBoxLocalPath
            // 
            this.TextBoxLocalPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLocalPath.Location = new System.Drawing.Point(7, 101);
            this.TextBoxLocalPath.Name = "TextBoxLocalPath";
            this.TextBoxLocalPath.Size = new System.Drawing.Size(246, 23);
            this.TextBoxLocalPath.TabIndex = 6;
            // 
            // LabelConsolePath
            // 
            this.LabelConsolePath.AutoSize = true;
            this.LabelConsolePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelConsolePath.Location = new System.Drawing.Point(4, 31);
            this.LabelConsolePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelConsolePath.Name = "LabelConsolePath";
            this.LabelConsolePath.Size = new System.Drawing.Size(101, 15);
            this.LabelConsolePath.TabIndex = 9;
            this.LabelConsolePath.Text = "Console File Path:";
            // 
            // TextBoxConsolePath
            // 
            this.TextBoxConsolePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConsolePath.Location = new System.Drawing.Point(7, 51);
            this.TextBoxConsolePath.Name = "TextBoxConsolePath";
            this.TextBoxConsolePath.Size = new System.Drawing.Size(295, 23);
            this.TextBoxConsolePath.TabIndex = 8;
            this.TextBoxConsolePath.TextChanged += new System.EventHandler(this.TextBoxConsolePath_TextChanged);
            // 
            // LabelGameId
            // 
            this.LabelGameId.AutoSize = true;
            this.LabelGameId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameId.Location = new System.Drawing.Point(167, 81);
            this.LabelGameId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelGameId.Name = "LabelGameId";
            this.LabelGameId.Size = new System.Drawing.Size(71, 15);
            this.LabelGameId.TabIndex = 12;
            this.LabelGameId.Text = "Category Id:";
            // 
            // TextBoxGameId
            // 
            this.TextBoxGameId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxGameId.Enabled = false;
            this.TextBoxGameId.Location = new System.Drawing.Point(170, 101);
            this.TextBoxGameId.Name = "TextBoxGameId";
            this.TextBoxGameId.ReadOnly = true;
            this.TextBoxGameId.Size = new System.Drawing.Size(132, 23);
            this.TextBoxGameId.TabIndex = 11;
            // 
            // LabelFilename
            // 
            this.LabelFilename.AutoSize = true;
            this.LabelFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFilename.Location = new System.Drawing.Point(6, 81);
            this.LabelFilename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelFilename.Name = "LabelFilename";
            this.LabelFilename.Size = new System.Drawing.Size(63, 15);
            this.LabelFilename.TabIndex = 14;
            this.LabelFilename.Text = "File Name:";
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxFileName.Enabled = false;
            this.TextBoxFileName.Location = new System.Drawing.Point(8, 101);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.ReadOnly = true;
            this.TextBoxFileName.Size = new System.Drawing.Size(156, 23);
            this.TextBoxFileName.TabIndex = 13;
            // 
            // ButtonLocalPath
            // 
            this.ButtonLocalPath.Location = new System.Drawing.Point(259, 101);
            this.ButtonLocalPath.Name = "ButtonLocalPath";
            this.ButtonLocalPath.Size = new System.Drawing.Size(43, 23);
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
            this.darkSectionPanel1.Controls.Add(this.TextBoxDescription);
            this.darkSectionPanel1.Controls.Add(this.LabelDescription);
            this.darkSectionPanel1.Location = new System.Drawing.Point(12, 12);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Backup Details";
            this.darkSectionPanel1.Size = new System.Drawing.Size(310, 212);
            this.darkSectionPanel1.TabIndex = 21;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(6, 31);
            this.darkLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(42, 15);
            this.darkLabel1.TabIndex = 5;
            this.darkLabel1.Text = "Name:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.Location = new System.Drawing.Point(8, 51);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(294, 23);
            this.TextBoxName.TabIndex = 4;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDescription.Location = new System.Drawing.Point(8, 152);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(294, 52);
            this.TextBoxDescription.TabIndex = 6;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelDescription.Location = new System.Drawing.Point(6, 132);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(70, 15);
            this.LabelDescription.TabIndex = 14;
            this.LabelDescription.Text = "Description:";
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.LabelConsolePath);
            this.darkSectionPanel2.Controls.Add(this.TextBoxLocalPath);
            this.darkSectionPanel2.Controls.Add(this.ButtonLocalPath);
            this.darkSectionPanel2.Controls.Add(this.LabelLocalPath);
            this.darkSectionPanel2.Controls.Add(this.TextBoxConsolePath);
            this.darkSectionPanel2.Location = new System.Drawing.Point(12, 230);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "File Details";
            this.darkSectionPanel2.Size = new System.Drawing.Size(310, 131);
            this.darkSectionPanel2.TabIndex = 22;
            // 
            // EditBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 408);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.ButtonSaveBackup);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private DarkUI.Controls.DarkTextBox TextBoxDescription;
        private DarkUI.Controls.DarkLabel LabelDescription;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
    }
}