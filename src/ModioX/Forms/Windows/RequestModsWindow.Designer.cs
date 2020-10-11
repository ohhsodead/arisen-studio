namespace ModioX.Forms
{
    partial class RequestModsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestModsWindow));
            this.TextBoxAuthor = new DarkUI.Controls.DarkTextBox();
            this.ButtonSubmitModsDetails = new DarkUI.Controls.DarkButton();
            this.LabelAuthor = new DarkUI.Controls.DarkLabel();
            this.LabelGameId = new DarkUI.Controls.DarkLabel();
            this.LabelDescription = new DarkUI.Controls.DarkLabel();
            this.TextBoxDescription = new DarkUI.Controls.DarkTextBox();
            this.ComboBoxCategoryTitle = new DarkUI.Controls.DarkComboBox();
            this.SectionModDetails = new DarkUI.Controls.DarkSectionPanel();
            this.LabelSupportedRegions = new DarkUI.Controls.DarkLabel();
            this.TextBoxGameRegions = new DarkUI.Controls.DarkTextBox();
            this.LabelSupportedSystemType = new DarkUI.Controls.DarkLabel();
            this.TextBoxSystemType = new DarkUI.Controls.DarkTextBox();
            this.TextBoxLinks = new DarkUI.Controls.DarkTextBox();
            this.LabelDownloadOtherLinks = new DarkUI.Controls.DarkLabel();
            this.LabelVersion = new DarkUI.Controls.DarkLabel();
            this.LabelModType = new DarkUI.Controls.DarkLabel();
            this.TextBoxModType = new DarkUI.Controls.DarkTextBox();
            this.LabelModName = new DarkUI.Controls.DarkLabel();
            this.TextBoxVersion = new DarkUI.Controls.DarkTextBox();
            this.TextBoxName = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.SectionModDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxAuthor
            // 
            this.TextBoxAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAuthor.Location = new System.Drawing.Point(226, 139);
            this.TextBoxAuthor.Name = "TextBoxAuthor";
            this.TextBoxAuthor.Size = new System.Drawing.Size(137, 23);
            this.TextBoxAuthor.TabIndex = 3;
            // 
            // ButtonSubmitModsDetails
            // 
            this.ButtonSubmitModsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSubmitModsDetails.Location = new System.Drawing.Point(322, 409);
            this.ButtonSubmitModsDetails.Name = "ButtonSubmitModsDetails";
            this.ButtonSubmitModsDetails.Size = new System.Drawing.Size(141, 24);
            this.ButtonSubmitModsDetails.TabIndex = 9;
            this.ButtonSubmitModsDetails.Text = "Submit Mods Details";
            this.ButtonSubmitModsDetails.Click += new System.EventHandler(this.ButtonSubmitModsDetails_Click);
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelAuthor.Location = new System.Drawing.Point(224, 118);
            this.LabelAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(47, 15);
            this.LabelAuthor.TabIndex = 5;
            this.LabelAuthor.Text = "Author:";
            // 
            // LabelGameId
            // 
            this.LabelGameId.AutoSize = true;
            this.LabelGameId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameId.Location = new System.Drawing.Point(6, 118);
            this.LabelGameId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelGameId.Name = "LabelGameId";
            this.LabelGameId.Size = new System.Drawing.Size(94, 15);
            this.LabelGameId.TabIndex = 12;
            this.LabelGameId.Text = "Category/Game:";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelDescription.Location = new System.Drawing.Point(6, 220);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
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
            this.TextBoxDescription.Location = new System.Drawing.Point(8, 241);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(435, 54);
            this.TextBoxDescription.TabIndex = 7;
            this.TextBoxDescription.Text = "Explain some details about the mod that we users may need to know, including feat" +
    "ures, important notes and any other information...";
            // 
            // ComboBoxCategoryTitle
            // 
            this.ComboBoxCategoryTitle.FormattingEnabled = true;
            this.ComboBoxCategoryTitle.Location = new System.Drawing.Point(9, 140);
            this.ComboBoxCategoryTitle.Name = "ComboBoxCategoryTitle";
            this.ComboBoxCategoryTitle.Size = new System.Drawing.Size(211, 24);
            this.ComboBoxCategoryTitle.TabIndex = 2;
            this.ComboBoxCategoryTitle.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategoryTitle_SelectedIndexChanged);
            // 
            // SectionModDetails
            // 
            this.SectionModDetails.Controls.Add(this.LabelSupportedRegions);
            this.SectionModDetails.Controls.Add(this.TextBoxGameRegions);
            this.SectionModDetails.Controls.Add(this.LabelSupportedSystemType);
            this.SectionModDetails.Controls.Add(this.TextBoxSystemType);
            this.SectionModDetails.Controls.Add(this.TextBoxLinks);
            this.SectionModDetails.Controls.Add(this.LabelDownloadOtherLinks);
            this.SectionModDetails.Controls.Add(this.LabelVersion);
            this.SectionModDetails.Controls.Add(this.LabelModType);
            this.SectionModDetails.Controls.Add(this.TextBoxModType);
            this.SectionModDetails.Controls.Add(this.LabelModName);
            this.SectionModDetails.Controls.Add(this.TextBoxVersion);
            this.SectionModDetails.Controls.Add(this.TextBoxName);
            this.SectionModDetails.Controls.Add(this.LabelAuthor);
            this.SectionModDetails.Controls.Add(this.TextBoxAuthor);
            this.SectionModDetails.Controls.Add(this.darkLabel1);
            this.SectionModDetails.Controls.Add(this.ComboBoxCategoryTitle);
            this.SectionModDetails.Controls.Add(this.LabelGameId);
            this.SectionModDetails.Controls.Add(this.TextBoxDescription);
            this.SectionModDetails.Controls.Add(this.LabelDescription);
            this.SectionModDetails.Location = new System.Drawing.Point(12, 12);
            this.SectionModDetails.Name = "SectionModDetails";
            this.SectionModDetails.SectionHeader = "Mod Details";
            this.SectionModDetails.Size = new System.Drawing.Size(451, 386);
            this.SectionModDetails.TabIndex = 3;
            // 
            // LabelSupportedRegions
            // 
            this.LabelSupportedRegions.AutoSize = true;
            this.LabelSupportedRegions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelSupportedRegions.Location = new System.Drawing.Point(224, 170);
            this.LabelSupportedRegions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelSupportedRegions.Name = "LabelSupportedRegions";
            this.LabelSupportedRegions.Size = new System.Drawing.Size(86, 15);
            this.LabelSupportedRegions.TabIndex = 27;
            this.LabelSupportedRegions.Text = "Game Regions:";
            // 
            // TextBoxGameRegions
            // 
            this.TextBoxGameRegions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxGameRegions.Location = new System.Drawing.Point(227, 190);
            this.TextBoxGameRegions.Name = "TextBoxGameRegions";
            this.TextBoxGameRegions.Size = new System.Drawing.Size(216, 23);
            this.TextBoxGameRegions.TabIndex = 6;
            this.TextBoxGameRegions.Text = "Enter all supported regions...";
            // 
            // LabelSupportedSystemType
            // 
            this.LabelSupportedSystemType.AutoSize = true;
            this.LabelSupportedSystemType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelSupportedSystemType.Location = new System.Drawing.Point(6, 170);
            this.LabelSupportedSystemType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.LabelSupportedSystemType.Name = "LabelSupportedSystemType";
            this.LabelSupportedSystemType.Size = new System.Drawing.Size(75, 15);
            this.LabelSupportedSystemType.TabIndex = 26;
            this.LabelSupportedSystemType.Text = "System Type:";
            // 
            // TextBoxSystemType
            // 
            this.TextBoxSystemType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSystemType.Location = new System.Drawing.Point(8, 190);
            this.TextBoxSystemType.Name = "TextBoxSystemType";
            this.TextBoxSystemType.Size = new System.Drawing.Size(212, 23);
            this.TextBoxSystemType.TabIndex = 5;
            this.TextBoxSystemType.Text = "CEX/DEX/HEN/HAN/ANY";
            // 
            // TextBoxLinks
            // 
            this.TextBoxLinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLinks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxLinks.Location = new System.Drawing.Point(8, 323);
            this.TextBoxLinks.Multiline = true;
            this.TextBoxLinks.Name = "TextBoxLinks";
            this.TextBoxLinks.Size = new System.Drawing.Size(435, 54);
            this.TextBoxLinks.TabIndex = 8;
            this.TextBoxLinks.Text = "Please add a few links where the mods can be found, such as download links, forum" +
    "s, youtube videos, etc.";
            // 
            // LabelDownloadOtherLinks
            // 
            this.LabelDownloadOtherLinks.AutoSize = true;
            this.LabelDownloadOtherLinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelDownloadOtherLinks.Location = new System.Drawing.Point(7, 302);
            this.LabelDownloadOtherLinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.LabelDownloadOtherLinks.Name = "LabelDownloadOtherLinks";
            this.LabelDownloadOtherLinks.Size = new System.Drawing.Size(169, 15);
            this.LabelDownloadOtherLinks.TabIndex = 23;
            this.LabelDownloadOtherLinks.Text = "Download/Forum/Other Links:";
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelVersion.Location = new System.Drawing.Point(366, 118);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(48, 15);
            this.LabelVersion.TabIndex = 21;
            this.LabelVersion.Text = "Version:";
            // 
            // LabelModType
            // 
            this.LabelModType.AutoSize = true;
            this.LabelModType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelModType.Location = new System.Drawing.Point(224, 69);
            this.LabelModType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelModType.Name = "LabelModType";
            this.LabelModType.Size = new System.Drawing.Size(62, 15);
            this.LabelModType.TabIndex = 19;
            this.LabelModType.Text = "Mod Type:";
            // 
            // TextBoxModType
            // 
            this.TextBoxModType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxModType.Location = new System.Drawing.Point(226, 89);
            this.TextBoxModType.Name = "TextBoxModType";
            this.TextBoxModType.Size = new System.Drawing.Size(217, 23);
            this.TextBoxModType.TabIndex = 1;
            this.TextBoxModType.Text = "SPRX/EBOOT/GAMESAVE/etc.";
            // 
            // LabelModName
            // 
            this.LabelModName.AutoSize = true;
            this.LabelModName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelModName.Location = new System.Drawing.Point(6, 69);
            this.LabelModName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelModName.Name = "LabelModName";
            this.LabelModName.Size = new System.Drawing.Size(70, 15);
            this.LabelModName.TabIndex = 17;
            this.LabelModName.Text = "Mod Name:";
            // 
            // TextBoxVersion
            // 
            this.TextBoxVersion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxVersion.Location = new System.Drawing.Point(369, 139);
            this.TextBoxVersion.Name = "TextBoxVersion";
            this.TextBoxVersion.Size = new System.Drawing.Size(74, 23);
            this.TextBoxVersion.TabIndex = 4;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.Location = new System.Drawing.Point(8, 89);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(212, 23);
            this.TextBoxName.TabIndex = 0;
            // 
            // darkLabel1
            // 
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(6, 31);
            this.darkLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(437, 34);
            this.darkLabel1.TabIndex = 15;
            this.darkLabel1.Text = "Please provide as much information you can find about the mods, also any links yo" +
    "u can find showcasing the mods will help to find more details.";
            // 
            // RequestModsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(475, 445);
            this.Controls.Add(this.SectionModDetails);
            this.Controls.Add(this.ButtonSubmitModsDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequestModsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Request Mods Form";
            this.Load += new System.EventHandler(this.RequestMods_Load);
            this.SectionModDetails.ResumeLayout(false);
            this.SectionModDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkTextBox TextBoxAuthor;
        private DarkUI.Controls.DarkButton ButtonSubmitModsDetails;
        private DarkUI.Controls.DarkLabel LabelAuthor;
        private DarkUI.Controls.DarkLabel LabelGameId;
        private DarkUI.Controls.DarkLabel LabelDescription;
        private DarkUI.Controls.DarkTextBox TextBoxDescription;
        private DarkUI.Controls.DarkComboBox ComboBoxCategoryTitle;
        private DarkUI.Controls.DarkSectionPanel SectionModDetails;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox TextBoxLinks;
        private DarkUI.Controls.DarkLabel LabelDownloadOtherLinks;
        private DarkUI.Controls.DarkLabel LabelVersion;
        private DarkUI.Controls.DarkLabel LabelModType;
        private DarkUI.Controls.DarkTextBox TextBoxModType;
        private DarkUI.Controls.DarkLabel LabelModName;
        private DarkUI.Controls.DarkTextBox TextBoxVersion;
        private DarkUI.Controls.DarkTextBox TextBoxName;
        private DarkUI.Controls.DarkLabel LabelSupportedRegions;
        private DarkUI.Controls.DarkTextBox TextBoxGameRegions;
        private DarkUI.Controls.DarkLabel LabelSupportedSystemType;
        private DarkUI.Controls.DarkTextBox TextBoxSystemType;
    }
}