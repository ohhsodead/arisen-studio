namespace ModioX.Forms.Dialogs
{
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.RichTextBoxThanks = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxCredits = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxLicence = new System.Windows.Forms.RichTextBox();
            this.ButtonClose = new DarkUI.Controls.DarkButton();
            this.SectionPanelLicense = new DarkUI.Controls.DarkSectionPanel();
            this.PanelLicense = new System.Windows.Forms.Panel();
            this.SectionPanelCredits = new DarkUI.Controls.DarkSectionPanel();
            this.PanelCredits = new System.Windows.Forms.Panel();
            this.SectionPanelThanks = new DarkUI.Controls.DarkSectionPanel();
            this.PanelThanks = new System.Windows.Forms.Panel();
            this.SectionPanelInformation = new DarkUI.Controls.DarkSectionPanel();
            this.PanelInformation = new System.Windows.Forms.Panel();
            this.RichTextBoxInformation = new System.Windows.Forms.RichTextBox();
            this.SectionPanelLicense.SuspendLayout();
            this.PanelLicense.SuspendLayout();
            this.SectionPanelCredits.SuspendLayout();
            this.PanelCredits.SuspendLayout();
            this.SectionPanelThanks.SuspendLayout();
            this.PanelThanks.SuspendLayout();
            this.SectionPanelInformation.SuspendLayout();
            this.PanelInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBoxThanks
            // 
            this.RichTextBoxThanks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.RichTextBoxThanks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxThanks.Cursor = System.Windows.Forms.Cursors.Default;
            this.RichTextBoxThanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxThanks.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.RichTextBoxThanks.ForeColor = System.Drawing.Color.Gainsboro;
            this.RichTextBoxThanks.Location = new System.Drawing.Point(8, 8);
            this.RichTextBoxThanks.Name = "RichTextBoxThanks";
            this.RichTextBoxThanks.ReadOnly = true;
            this.RichTextBoxThanks.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RichTextBoxThanks.Size = new System.Drawing.Size(271, 77);
            this.RichTextBoxThanks.TabIndex = 2;
            this.RichTextBoxThanks.TabStop = false;
            this.RichTextBoxThanks.Text = "Appropriate Creators for all Mods\nRobinPerris for DarkUI for WinForms\nJamesNK for" +
    " Newtonsoft.Json\nApache for Apache log4net\nBISOON for FtpConnection.cs";
            this.RichTextBoxThanks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextBox_MouseDown);
            // 
            // RichTextBoxCredits
            // 
            this.RichTextBoxCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.RichTextBoxCredits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxCredits.Cursor = System.Windows.Forms.Cursors.Default;
            this.RichTextBoxCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxCredits.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RichTextBoxCredits.ForeColor = System.Drawing.Color.Gainsboro;
            this.RichTextBoxCredits.Location = new System.Drawing.Point(8, 8);
            this.RichTextBoxCredits.Name = "RichTextBoxCredits";
            this.RichTextBoxCredits.ReadOnly = true;
            this.RichTextBoxCredits.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RichTextBoxCredits.Size = new System.Drawing.Size(272, 77);
            this.RichTextBoxCredits.TabIndex = 1;
            this.RichTextBoxCredits.TabStop = false;
            this.RichTextBoxCredits.Text = "Developer: ohhsodead\nContributor: KayGart\n\nWebsite:\nhttps://github.com/ohhsodead/" +
    "ModioX";
            this.RichTextBoxCredits.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RichTextBoxCredits_LinkClicked);
            this.RichTextBoxCredits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextBox_MouseDown);
            // 
            // RichTextBoxLicence
            // 
            this.RichTextBoxLicence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.RichTextBoxLicence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxLicence.Cursor = System.Windows.Forms.Cursors.Default;
            this.RichTextBoxLicence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxLicence.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RichTextBoxLicence.ForeColor = System.Drawing.Color.Gainsboro;
            this.RichTextBoxLicence.Location = new System.Drawing.Point(8, 8);
            this.RichTextBoxLicence.Name = "RichTextBoxLicence";
            this.RichTextBoxLicence.ReadOnly = true;
            this.RichTextBoxLicence.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RichTextBoxLicence.Size = new System.Drawing.Size(567, 151);
            this.RichTextBoxLicence.TabIndex = 3;
            this.RichTextBoxLicence.TabStop = false;
            this.RichTextBoxLicence.Text = resources.GetString("RichTextBoxLicence.Text");
            this.RichTextBoxLicence.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RichTextBoxLicence_LinkClicked);
            this.RichTextBoxLicence.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextBox_MouseDown);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonClose.Location = new System.Drawing.Point(268, 476);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(74, 24);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // SectionPanelLicense
            // 
            this.SectionPanelLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SectionPanelLicense.Controls.Add(this.PanelLicense);
            this.SectionPanelLicense.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionPanelLicense.Location = new System.Drawing.Point(12, 265);
            this.SectionPanelLicense.Margin = new System.Windows.Forms.Padding(4);
            this.SectionPanelLicense.Name = "SectionPanelLicense";
            this.SectionPanelLicense.SectionHeader = "LICENSE";
            this.SectionPanelLicense.Size = new System.Drawing.Size(585, 193);
            this.SectionPanelLicense.TabIndex = 13;
            // 
            // PanelLicense
            // 
            this.PanelLicense.Controls.Add(this.RichTextBoxLicence);
            this.PanelLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLicense.Location = new System.Drawing.Point(1, 25);
            this.PanelLicense.Name = "PanelLicense";
            this.PanelLicense.Padding = new System.Windows.Forms.Padding(8);
            this.PanelLicense.Size = new System.Drawing.Size(583, 167);
            this.PanelLicense.TabIndex = 0;
            // 
            // SectionPanelCredits
            // 
            this.SectionPanelCredits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SectionPanelCredits.Controls.Add(this.PanelCredits);
            this.SectionPanelCredits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionPanelCredits.Location = new System.Drawing.Point(12, 138);
            this.SectionPanelCredits.Margin = new System.Windows.Forms.Padding(4);
            this.SectionPanelCredits.Name = "SectionPanelCredits";
            this.SectionPanelCredits.SectionHeader = "CREDITS";
            this.SectionPanelCredits.Size = new System.Drawing.Size(290, 119);
            this.SectionPanelCredits.TabIndex = 0;
            // 
            // PanelCredits
            // 
            this.PanelCredits.Controls.Add(this.RichTextBoxCredits);
            this.PanelCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCredits.Location = new System.Drawing.Point(1, 25);
            this.PanelCredits.Name = "PanelCredits";
            this.PanelCredits.Padding = new System.Windows.Forms.Padding(8);
            this.PanelCredits.Size = new System.Drawing.Size(288, 93);
            this.PanelCredits.TabIndex = 0;
            // 
            // SectionPanelThanks
            // 
            this.SectionPanelThanks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SectionPanelThanks.Controls.Add(this.PanelThanks);
            this.SectionPanelThanks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionPanelThanks.Location = new System.Drawing.Point(308, 138);
            this.SectionPanelThanks.Margin = new System.Windows.Forms.Padding(4);
            this.SectionPanelThanks.Name = "SectionPanelThanks";
            this.SectionPanelThanks.SectionHeader = "SPECIAL THANKS";
            this.SectionPanelThanks.Size = new System.Drawing.Size(289, 119);
            this.SectionPanelThanks.TabIndex = 15;
            // 
            // PanelThanks
            // 
            this.PanelThanks.Controls.Add(this.RichTextBoxThanks);
            this.PanelThanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelThanks.Location = new System.Drawing.Point(1, 25);
            this.PanelThanks.Name = "PanelThanks";
            this.PanelThanks.Padding = new System.Windows.Forms.Padding(8);
            this.PanelThanks.Size = new System.Drawing.Size(287, 93);
            this.PanelThanks.TabIndex = 0;
            // 
            // SectionPanelInformation
            // 
            this.SectionPanelInformation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SectionPanelInformation.Controls.Add(this.PanelInformation);
            this.SectionPanelInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionPanelInformation.Location = new System.Drawing.Point(12, 13);
            this.SectionPanelInformation.Margin = new System.Windows.Forms.Padding(4);
            this.SectionPanelInformation.Name = "SectionPanelInformation";
            this.SectionPanelInformation.SectionHeader = "INFORMATION";
            this.SectionPanelInformation.Size = new System.Drawing.Size(585, 117);
            this.SectionPanelInformation.TabIndex = 0;
            // 
            // PanelInformation
            // 
            this.PanelInformation.Controls.Add(this.RichTextBoxInformation);
            this.PanelInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInformation.Location = new System.Drawing.Point(1, 25);
            this.PanelInformation.Name = "PanelInformation";
            this.PanelInformation.Padding = new System.Windows.Forms.Padding(8);
            this.PanelInformation.Size = new System.Drawing.Size(583, 91);
            this.PanelInformation.TabIndex = 0;
            // 
            // RichTextBoxInformation
            // 
            this.RichTextBoxInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.RichTextBoxInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxInformation.Cursor = System.Windows.Forms.Cursors.Default;
            this.RichTextBoxInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxInformation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RichTextBoxInformation.ForeColor = System.Drawing.Color.Gainsboro;
            this.RichTextBoxInformation.Location = new System.Drawing.Point(8, 8);
            this.RichTextBoxInformation.Name = "RichTextBoxInformation";
            this.RichTextBoxInformation.ReadOnly = true;
            this.RichTextBoxInformation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RichTextBoxInformation.Size = new System.Drawing.Size(567, 75);
            this.RichTextBoxInformation.TabIndex = 1;
            this.RichTextBoxInformation.TabStop = false;
            this.RichTextBoxInformation.Text = resources.GetString("RichTextBoxInformation.Text");
            this.RichTextBoxInformation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RichTextBox_MouseDown);
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(610, 516);
            this.Controls.Add(this.SectionPanelInformation);
            this.Controls.Add(this.SectionPanelThanks);
            this.Controls.Add(this.SectionPanelCredits);
            this.Controls.Add(this.SectionPanelLicense);
            this.Controls.Add(this.ButtonClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            this.SectionPanelLicense.ResumeLayout(false);
            this.PanelLicense.ResumeLayout(false);
            this.SectionPanelCredits.ResumeLayout(false);
            this.PanelCredits.ResumeLayout(false);
            this.SectionPanelThanks.ResumeLayout(false);
            this.PanelThanks.ResumeLayout(false);
            this.SectionPanelInformation.ResumeLayout(false);
            this.PanelInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkButton ButtonClose;
        private System.Windows.Forms.RichTextBox RichTextBoxLicence;
        private System.Windows.Forms.RichTextBox RichTextBoxCredits;
        private System.Windows.Forms.RichTextBox RichTextBoxThanks;
        private DarkUI.Controls.DarkSectionPanel SectionPanelLicense;
        private System.Windows.Forms.Panel PanelLicense;
        private DarkUI.Controls.DarkSectionPanel SectionPanelCredits;
        private System.Windows.Forms.Panel PanelCredits;
        private DarkUI.Controls.DarkSectionPanel SectionPanelThanks;
        private System.Windows.Forms.Panel PanelThanks;
        private DarkUI.Controls.DarkSectionPanel SectionPanelInformation;
        private System.Windows.Forms.Panel PanelInformation;
        private System.Windows.Forms.RichTextBox RichTextBoxInformation;
    }
}