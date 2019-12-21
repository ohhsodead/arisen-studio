namespace ModioX.Windows.Custom_Mods
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
            this.ComboBoxCategoryId = new DarkUI.Controls.DarkComboBox();
            this.ListViewInstallFiles = new DarkUI.Controls.DarkListView();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.ButtonRemoveInstallFile = new DarkUI.Controls.DarkButton();
            this.ButtonAddInstall = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel3 = new DarkUI.Controls.DarkSectionPanel();
            this.ButtonNewMod = new DarkUI.Controls.DarkButton();
            this.ComboBoxCustomMods = new DarkUI.Controls.DarkComboBox();
            this.darkSectionPanel1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.darkSectionPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.Location = new System.Drawing.Point(8, 51);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(287, 23);
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
            this.LabelLocalPath.Location = new System.Drawing.Point(6, 161);
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
            this.TextBoxLocalPath.Location = new System.Drawing.Point(8, 181);
            this.TextBoxLocalPath.Name = "TextBoxLocalPath";
            this.TextBoxLocalPath.Size = new System.Drawing.Size(387, 23);
            this.TextBoxLocalPath.TabIndex = 9;
            // 
            // LabelConsolePath
            // 
            this.LabelConsolePath.AutoSize = true;
            this.LabelConsolePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelConsolePath.Location = new System.Drawing.Point(6, 211);
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
            this.TextBoxConsolePath.Location = new System.Drawing.Point(8, 231);
            this.TextBoxConsolePath.Name = "TextBoxConsolePath";
            this.TextBoxConsolePath.Size = new System.Drawing.Size(435, 23);
            this.TextBoxConsolePath.TabIndex = 11;
            this.TextBoxConsolePath.Text = "e.g. /dev_hdd0/game/{REGION}/USRDIR/EBOOT.BIN or patch_mp.ff";
            // 
            // LabelGameId
            // 
            this.LabelGameId.AutoSize = true;
            this.LabelGameId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameId.Location = new System.Drawing.Point(298, 30);
            this.LabelGameId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelGameId.Name = "LabelGameId";
            this.LabelGameId.Size = new System.Drawing.Size(71, 15);
            this.LabelGameId.TabIndex = 12;
            this.LabelGameId.Text = "Category Id:";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelDescription.Location = new System.Drawing.Point(6, 81);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(70, 15);
            this.LabelDescription.TabIndex = 14;
            this.LabelDescription.Text = "Description:";
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
            this.TextBoxDescription.TextChanged += new System.EventHandler(this.TextBoxDescription_TextChanged);
            // 
            // ButtonLocalPath
            // 
            this.ButtonLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLocalPath.Location = new System.Drawing.Point(401, 181);
            this.ButtonLocalPath.Name = "ButtonLocalPath";
            this.ButtonLocalPath.Size = new System.Drawing.Size(42, 23);
            this.ButtonLocalPath.TabIndex = 10;
            this.ButtonLocalPath.Text = "...";
            this.ButtonLocalPath.Click += new System.EventHandler(this.ButtonLocalPath_Click);
            // 
            // ComboBoxCategoryId
            // 
            this.ComboBoxCategoryId.FormattingEnabled = true;
            this.ComboBoxCategoryId.Location = new System.Drawing.Point(301, 51);
            this.ComboBoxCategoryId.Name = "ComboBoxCategoryId";
            this.ComboBoxCategoryId.Size = new System.Drawing.Size(142, 24);
            this.ComboBoxCategoryId.TabIndex = 5;
            this.ComboBoxCategoryId.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategoryId_SelectedIndexChanged);
            // 
            // ListViewInstallFiles
            // 
            this.ListViewInstallFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewInstallFiles.Location = new System.Drawing.Point(8, 31);
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
            this.darkSectionPanel1.Controls.Add(this.ComboBoxCategoryId);
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
            this.ButtonRemoveInstallFile.Location = new System.Drawing.Point(8, 130);
            this.ButtonRemoveInstallFile.Name = "ButtonRemoveInstallFile";
            this.ButtonRemoveInstallFile.Size = new System.Drawing.Size(94, 24);
            this.ButtonRemoveInstallFile.TabIndex = 13;
            this.ButtonRemoveInstallFile.Text = "Remove File";
            this.ButtonRemoveInstallFile.Click += new System.EventHandler(this.ButtonRemoveInstallFile_Click);
            // 
            // ButtonAddInstall
            // 
            this.ButtonAddInstall.Location = new System.Drawing.Point(8, 260);
            this.ButtonAddInstall.Name = "ButtonAddInstall";
            this.ButtonAddInstall.Size = new System.Drawing.Size(80, 24);
            this.ButtonAddInstall.TabIndex = 12;
            this.ButtonAddInstall.Text = "Add File";
            this.ButtonAddInstall.Click += new System.EventHandler(this.ButtonAddInstall_Click);
            // 
            // darkSectionPanel3
            // 
            this.darkSectionPanel3.Controls.Add(this.ButtonNewMod);
            this.darkSectionPanel3.Controls.Add(this.ComboBoxCustomMods);
            this.darkSectionPanel3.Location = new System.Drawing.Point(12, 12);
            this.darkSectionPanel3.Name = "darkSectionPanel3";
            this.darkSectionPanel3.SectionHeader = "Custom Mods";
            this.darkSectionPanel3.Size = new System.Drawing.Size(344, 64);
            this.darkSectionPanel3.TabIndex = 0;
            this.darkSectionPanel3.Visible = false;
            // 
            // ButtonNewMod
            // 
            this.ButtonNewMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNewMod.Location = new System.Drawing.Point(255, 32);
            this.ButtonNewMod.Name = "ButtonNewMod";
            this.ButtonNewMod.Size = new System.Drawing.Size(81, 24);
            this.ButtonNewMod.TabIndex = 2;
            this.ButtonNewMod.Text = "New Mod";
            this.ButtonNewMod.Click += new System.EventHandler(this.ButtonNewMod_Click);
            // 
            // ComboBoxCustomMods
            // 
            this.ComboBoxCustomMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxCustomMods.FormattingEnabled = true;
            this.ComboBoxCustomMods.Location = new System.Drawing.Point(8, 32);
            this.ComboBoxCustomMods.Name = "ComboBoxCustomMods";
            this.ComboBoxCustomMods.Size = new System.Drawing.Size(240, 24);
            this.ComboBoxCustomMods.TabIndex = 1;
            this.ComboBoxCustomMods.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCustomMods_SelectedIndexChanged);
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
            this.Controls.Add(this.darkSectionPanel3);
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
            this.darkSectionPanel3.ResumeLayout(false);
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
        private DarkUI.Controls.DarkComboBox ComboBoxCategoryId;
        private DarkUI.Controls.DarkListView ListViewInstallFiles;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkButton ButtonRemoveInstallFile;
        private DarkUI.Controls.DarkButton ButtonAddInstall;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel3;
        private DarkUI.Controls.DarkComboBox ComboBoxCustomMods;
        private DarkUI.Controls.DarkButton ButtonNewMod;
    }
}