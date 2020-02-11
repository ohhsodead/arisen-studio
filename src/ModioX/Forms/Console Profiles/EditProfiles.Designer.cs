namespace ModioX.Forms.Console_Profiles
{
    partial class EditProfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfiles));
            this.ButtonRemoveProfile = new DarkUI.Controls.DarkButton();
            this.ListViewConsoles = new DarkUI.Controls.DarkListView();
            this.SectionConsoleProfile = new DarkUI.Controls.DarkSectionPanel();
            this.ButtonAddProfile = new DarkUI.Controls.DarkButton();
            this.LabelName = new DarkUI.Controls.DarkLabel();
            this.TextBoxName = new DarkUI.Controls.DarkTextBox();
            this.TextBoxAddress = new DarkUI.Controls.DarkTextBox();
            this.LabelDescription = new DarkUI.Controls.DarkLabel();
            this.SectionConsoleProfiles = new DarkUI.Controls.DarkSectionPanel();
            this.SectionConsoleProfile.SuspendLayout();
            this.SectionConsoleProfiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonRemoveProfile
            // 
            this.ButtonRemoveProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRemoveProfile.Enabled = false;
            this.ButtonRemoveProfile.Location = new System.Drawing.Point(135, 131);
            this.ButtonRemoveProfile.Name = "ButtonRemoveProfile";
            this.ButtonRemoveProfile.Size = new System.Drawing.Size(117, 25);
            this.ButtonRemoveProfile.TabIndex = 1136;
            this.ButtonRemoveProfile.Text = "Remove Profile";
            this.ButtonRemoveProfile.Click += new System.EventHandler(this.ButtonRemoveProfile_Click);
            // 
            // ListViewConsoles
            // 
            this.ListViewConsoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListViewConsoles.Location = new System.Drawing.Point(1, 25);
            this.ListViewConsoles.Name = "ListViewConsoles";
            this.ListViewConsoles.Size = new System.Drawing.Size(258, 99);
            this.ListViewConsoles.TabIndex = 1138;
            this.ListViewConsoles.Text = "darkListView1";
            this.ListViewConsoles.SelectedIndicesChanged += new System.EventHandler(this.ListViewConsoles_SelectedIndicesChanged);
            // 
            // SectionConsoleProfile
            // 
            this.SectionConsoleProfile.Controls.Add(this.ButtonAddProfile);
            this.SectionConsoleProfile.Controls.Add(this.LabelName);
            this.SectionConsoleProfile.Controls.Add(this.TextBoxName);
            this.SectionConsoleProfile.Controls.Add(this.TextBoxAddress);
            this.SectionConsoleProfile.Controls.Add(this.LabelDescription);
            this.SectionConsoleProfile.Location = new System.Drawing.Point(13, 13);
            this.SectionConsoleProfile.Margin = new System.Windows.Forms.Padding(4);
            this.SectionConsoleProfile.Name = "SectionConsoleProfile";
            this.SectionConsoleProfile.SectionHeader = "Console Profile";
            this.SectionConsoleProfile.Size = new System.Drawing.Size(229, 164);
            this.SectionConsoleProfile.TabIndex = 1140;
            // 
            // ButtonAddProfile
            // 
            this.ButtonAddProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddProfile.Location = new System.Drawing.Point(127, 131);
            this.ButtonAddProfile.Name = "ButtonAddProfile";
            this.ButtonAddProfile.Size = new System.Drawing.Size(94, 25);
            this.ButtonAddProfile.TabIndex = 1137;
            this.ButtonAddProfile.Text = "Add Profile";
            this.ButtonAddProfile.Click += new System.EventHandler(this.ButtonAddProfile_Click);
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
            // TextBoxName
            // 
            this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxName.Location = new System.Drawing.Point(8, 51);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(213, 23);
            this.TextBoxName.TabIndex = 4;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAddress.Location = new System.Drawing.Point(8, 101);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(213, 23);
            this.TextBoxAddress.TabIndex = 13;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelDescription.Location = new System.Drawing.Point(6, 81);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(83, 15);
            this.LabelDescription.TabIndex = 14;
            this.LabelDescription.Text = "Local Address:";
            // 
            // SectionConsoleProfiles
            // 
            this.SectionConsoleProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionConsoleProfiles.Controls.Add(this.ListViewConsoles);
            this.SectionConsoleProfiles.Controls.Add(this.ButtonRemoveProfile);
            this.SectionConsoleProfiles.Location = new System.Drawing.Point(249, 13);
            this.SectionConsoleProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.SectionConsoleProfiles.Name = "SectionConsoleProfiles";
            this.SectionConsoleProfiles.SectionHeader = "Console Profiles";
            this.SectionConsoleProfiles.Size = new System.Drawing.Size(260, 164);
            this.SectionConsoleProfiles.TabIndex = 1141;
            // 
            // EditProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(522, 189);
            this.Controls.Add(this.SectionConsoleProfiles);
            this.Controls.Add(this.SectionConsoleProfile);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProfiles";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Console Profiles";
            this.Load += new System.EventHandler(this.ConsolesWindow_Load);
            this.SectionConsoleProfile.ResumeLayout(false);
            this.SectionConsoleProfile.PerformLayout();
            this.SectionConsoleProfiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkButton ButtonRemoveProfile;
        private DarkUI.Controls.DarkListView ListViewConsoles;
        private DarkUI.Controls.DarkSectionPanel SectionConsoleProfile;
        private DarkUI.Controls.DarkLabel LabelName;
        private DarkUI.Controls.DarkTextBox TextBoxName;
        private DarkUI.Controls.DarkTextBox TextBoxAddress;
        private DarkUI.Controls.DarkLabel LabelDescription;
        private DarkUI.Controls.DarkSectionPanel SectionConsoleProfiles;
        private DarkUI.Controls.DarkButton ButtonAddProfile;
    }
}