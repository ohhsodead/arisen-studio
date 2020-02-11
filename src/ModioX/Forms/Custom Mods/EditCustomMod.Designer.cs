namespace ModioX.Forms.Custom_Mods
{
    partial class EditCustomMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomMod));
            this.TextBoxName = new DarkUI.Controls.DarkTextBox();
            this.ButtonSaveMod = new DarkUI.Controls.DarkButton();
            this.LabelName = new DarkUI.Controls.DarkLabel();
            this.LabelLocalPath = new DarkUI.Controls.DarkLabel();
            this.TextBoxLocalPath = new DarkUI.Controls.DarkTextBox();
            this.LabelConsolePath = new DarkUI.Controls.DarkLabel();
            this.TextBoxConsolePath = new DarkUI.Controls.DarkTextBox();
            this.LabelGameId = new DarkUI.Controls.DarkLabel();
            this.LabelDescription = new DarkUI.Controls.DarkLabel();
            this.TextBoxDescription = new DarkUI.Controls.DarkTextBox();
            this.ButtonLocalPath = new DarkUI.Controls.DarkButton();
            this.ComboBoxCategoryTitle = new DarkUI.Controls.DarkComboBox();
            this.ListViewInstallFiles = new DarkUI.Controls.DarkListView();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.ButtonRemoveInstallFile = new DarkUI.Controls.DarkButton();
            this.ButtonAddInstall = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.Location = new System.Drawing.Point(8, 51);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(212, 23);
            this.TextBoxName.TabIndex = 4;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // ButtonSaveMod
            // 
            this.ButtonSaveMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveMod.Location = new System.Drawing.Point(335, 479);
            this.ButtonSaveMod.Name = "ButtonSaveMod";
            this.ButtonSaveMod.Size = new System.Drawing.Size(128, 24);
            this.ButtonSaveMod.TabIndex = 14;
            this.ButtonSaveMod.Text = "Save Custom Mod";
            this.ButtonSaveMod.Click += new System.EventHandler(this.ButtonSaveMod_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelName.Location = new System.Drawing.Point(6, 31);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(42, 15);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Name:";
            // 
            // LabelLocalPath
            // 
            this.LabelLocalPath.AutoSize = true;
            this.LabelLocalPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelLocalPath.Location = new System.Drawing.Point(6, 31);
            this.LabelLocalPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelLocalPath.Name = "LabelLocalPath";
            this.LabelLocalPath.Size = new System.Drawing.Size(171, 15);
            this.LabelLocalPath.TabIndex = 7;
            this.LabelLocalPath.Text = "Local File Path (Case Sensitive):";
            // 
            // TextBoxLocalPath
            // 
            this.TextBoxLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLocalPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLocalPath.Location = new System.Drawing.Point(8, 51);
            this.TextBoxLocalPath.Name = "TextBoxLocalPath";
            this.TextBoxLocalPath.Size = new System.Drawing.Size(387, 23);
            this.TextBoxLocalPath.TabIndex = 9;
            // 
            // LabelConsolePath
            // 
            this.LabelConsolePath.AutoSize = true;
            this.LabelConsolePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelConsolePath.Location = new System.Drawing.Point(6, 81);
            this.LabelConsolePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelConsolePath.Name = "LabelConsolePath";
            this.LabelConsolePath.Size = new System.Drawing.Size(186, 15);
            this.LabelConsolePath.TabIndex = 9;
            this.LabelConsolePath.Text = "Console File Path (Case Sensitive):";
            // 
            // TextBoxConsolePath
            // 
            this.TextBoxConsolePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConsolePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConsolePath.Location = new System.Drawing.Point(8, 101);
            this.TextBoxConsolePath.Name = "TextBoxConsolePath";
            this.TextBoxConsolePath.Size = new System.Drawing.Size(435, 23);
            this.TextBoxConsolePath.TabIndex = 11;
            this.TextBoxConsolePath.Text = "e.g. /dev_hdd0/game/{REGION}/USRDIR/EBOOT.BIN or patch_mp.ff";
            // 
            // LabelGameId
            // 
            this.LabelGameId.AutoSize = true;
            this.LabelGameId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameId.Location = new System.Drawing.Point(224, 31);
            this.LabelGameId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelGameId.Name = "LabelGameId";
            this.LabelGameId.Size = new System.Drawing.Size(58, 15);
            this.LabelGameId.TabIndex = 12;
            this.LabelGameId.Text = "Category:";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelDescription.Location = new System.Drawing.Point(6, 81);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(127, 15);
            this.LabelDescription.TabIndex = 14;
            this.LabelDescription.Text = "Description (Optional):";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDescription.Location = new System.Drawing.Point(8, 101);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(435, 52);
            this.TextBoxDescription.TabIndex = 6;
            this.TextBoxDescription.Text = "Also some text here to explain about the mods...";
            this.TextBoxDescription.TextChanged += new System.EventHandler(this.TextBoxDescription_TextChanged);
            // 
            // ButtonLocalPath
            // 
            this.ButtonLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLocalPath.Location = new System.Drawing.Point(401, 51);
            this.ButtonLocalPath.Name = "ButtonLocalPath";
            this.ButtonLocalPath.Size = new System.Drawing.Size(42, 23);
            this.ButtonLocalPath.TabIndex = 10;
            this.ButtonLocalPath.Text = "...";
            this.ButtonLocalPath.Click += new System.EventHandler(this.ButtonLocalPath_Click);
            // 
            // ComboBoxCategoryTitle
            // 
            this.ComboBoxCategoryTitle.FormattingEnabled = true;
            this.ComboBoxCategoryTitle.Location = new System.Drawing.Point(226, 51);
            this.ComboBoxCategoryTitle.Name = "ComboBoxCategoryTitle";
            this.ComboBoxCategoryTitle.Size = new System.Drawing.Size(217, 24);
            this.ComboBoxCategoryTitle.TabIndex = 5;
            this.ComboBoxCategoryTitle.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategoryId_SelectedIndexChanged);
            // 
            // ListViewInstallFiles
            // 
            this.ListViewInstallFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewInstallFiles.Location = new System.Drawing.Point(8, 161);
            this.ListViewInstallFiles.Name = "ListViewInstallFiles";
            this.ListViewInstallFiles.Size = new System.Drawing.Size(435, 92);
            this.ListViewInstallFiles.TabIndex = 8;
            this.ListViewInstallFiles.Text = "darkListView1";
            this.ListViewInstallFiles.SelectedIndicesChanged += new System.EventHandler(this.ListViewInstallFiles_SelectedIndicesChanged);
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.LabelName);
            this.darkSectionPanel1.Controls.Add(this.TextBoxName);
            this.darkSectionPanel1.Controls.Add(this.ComboBoxCategoryTitle);
            this.darkSectionPanel1.Controls.Add(this.LabelGameId);
            this.darkSectionPanel1.Controls.Add(this.TextBoxDescription);
            this.darkSectionPanel1.Controls.Add(this.LabelDescription);
            this.darkSectionPanel1.Location = new System.Drawing.Point(12, 12);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Mod Details";
            this.darkSectionPanel1.Size = new System.Drawing.Size(451, 161);
            this.darkSectionPanel1.TabIndex = 3;
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.ButtonRemoveInstallFile);
            this.darkSectionPanel2.Controls.Add(this.ButtonAddInstall);
            this.darkSectionPanel2.Controls.Add(this.ListViewInstallFiles);
            this.darkSectionPanel2.Controls.Add(this.LabelConsolePath);
            this.darkSectionPanel2.Controls.Add(this.ButtonLocalPath);
            this.darkSectionPanel2.Controls.Add(this.TextBoxLocalPath);
            this.darkSectionPanel2.Controls.Add(this.TextBoxConsolePath);
            this.darkSectionPanel2.Controls.Add(this.LabelLocalPath);
            this.darkSectionPanel2.Location = new System.Drawing.Point(12, 179);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "Mod Install Files";
            this.darkSectionPanel2.Size = new System.Drawing.Size(451, 292);
            this.darkSectionPanel2.TabIndex = 7;
            // 
            // ButtonRemoveInstallFile
            // 
            this.ButtonRemoveInstallFile.Enabled = false;
            this.ButtonRemoveInstallFile.Location = new System.Drawing.Point(8, 260);
            this.ButtonRemoveInstallFile.Name = "ButtonRemoveInstallFile";
            this.ButtonRemoveInstallFile.Size = new System.Drawing.Size(94, 24);
            this.ButtonRemoveInstallFile.TabIndex = 13;
            this.ButtonRemoveInstallFile.Text = "Remove File";
            this.ButtonRemoveInstallFile.Click += new System.EventHandler(this.ButtonRemoveInstallFile_Click);
            // 
            // ButtonAddInstall
            // 
            this.ButtonAddInstall.Location = new System.Drawing.Point(8, 130);
            this.ButtonAddInstall.Name = "ButtonAddInstall";
            this.ButtonAddInstall.Size = new System.Drawing.Size(80, 24);
            this.ButtonAddInstall.TabIndex = 12;
            this.ButtonAddInstall.Text = "Add File";
            this.ButtonAddInstall.Click += new System.EventHandler(this.ButtonAddInstall_Click);
            // 
            // EditCustomMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(475, 515);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.ButtonSaveMod);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCustomMod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Custom Mod";
            this.Load += new System.EventHandler(this.EditCustomMod_Load);
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.darkSectionPanel2.ResumeLayout(false);
            this.darkSectionPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkTextBox TextBoxName;
        private DarkUI.Controls.DarkButton ButtonSaveMod;
        private DarkUI.Controls.DarkLabel LabelName;
        private DarkUI.Controls.DarkLabel LabelLocalPath;
        private DarkUI.Controls.DarkTextBox TextBoxLocalPath;
        private DarkUI.Controls.DarkLabel LabelConsolePath;
        private DarkUI.Controls.DarkTextBox TextBoxConsolePath;
        private DarkUI.Controls.DarkLabel LabelGameId;
        private DarkUI.Controls.DarkLabel LabelDescription;
        private DarkUI.Controls.DarkTextBox TextBoxDescription;
        private DarkUI.Controls.DarkButton ButtonLocalPath;
        private DarkUI.Controls.DarkComboBox ComboBoxCategoryTitle;
        private DarkUI.Controls.DarkListView ListViewInstallFiles;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkButton ButtonRemoveInstallFile;
        private DarkUI.Controls.DarkButton ButtonAddInstall;
    }
}