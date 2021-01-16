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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.RichTextBoxInformation = new System.Windows.Forms.RichTextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.RichTextBoxThanks = new System.Windows.Forms.RichTextBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.RichTextBoxLicence = new System.Windows.Forms.RichTextBox();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.RichTextBoxCredits = new System.Windows.Forms.RichTextBox();
            this.ButtonClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.RichTextBoxInformation);
            this.groupControl1.Location = new System.Drawing.Point(14, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(585, 117);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "INFORMATION";
            // 
            // RichTextBoxInformation
            // 
            this.RichTextBoxInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.RichTextBoxInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxInformation.Cursor = System.Windows.Forms.Cursors.Default;
            this.RichTextBoxInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxInformation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RichTextBoxInformation.ForeColor = System.Drawing.Color.Gainsboro;
            this.RichTextBoxInformation.Location = new System.Drawing.Point(2, 23);
            this.RichTextBoxInformation.Name = "RichTextBoxInformation";
            this.RichTextBoxInformation.ReadOnly = true;
            this.RichTextBoxInformation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RichTextBoxInformation.Size = new System.Drawing.Size(581, 92);
            this.RichTextBoxInformation.TabIndex = 2;
            this.RichTextBoxInformation.TabStop = false;
            this.RichTextBoxInformation.Text = resources.GetString("RichTextBoxInformation.Text");
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.RichTextBoxThanks);
            this.groupControl2.Location = new System.Drawing.Point(310, 135);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(289, 132);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "SPECIAL THANKS";
            // 
            // RichTextBoxThanks
            // 
            this.RichTextBoxThanks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.RichTextBoxThanks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxThanks.Cursor = System.Windows.Forms.Cursors.Default;
            this.RichTextBoxThanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxThanks.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.RichTextBoxThanks.ForeColor = System.Drawing.Color.Gainsboro;
            this.RichTextBoxThanks.Location = new System.Drawing.Point(2, 23);
            this.RichTextBoxThanks.Name = "RichTextBoxThanks";
            this.RichTextBoxThanks.ReadOnly = true;
            this.RichTextBoxThanks.Size = new System.Drawing.Size(285, 107);
            this.RichTextBoxThanks.TabIndex = 3;
            this.RichTextBoxThanks.TabStop = false;
            this.RichTextBoxThanks.Text = "Appropriate Creators for all Mods\nRobinPerris for DarkUI for WinForms\nJamesNK for" +
    " Newtonsoft.Json\nApache for Apache log4net\nBISOON for FtpConnection.cs\nTeddyHamm" +
    "er for XDevkit";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.RichTextBoxLicence);
            this.groupControl3.Location = new System.Drawing.Point(14, 275);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(585, 193);
            this.groupControl3.TabIndex = 14;
            this.groupControl3.Text = "LICENSE";
            // 
            // RichTextBoxLicence
            // 
            this.RichTextBoxLicence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.RichTextBoxLicence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxLicence.Cursor = System.Windows.Forms.Cursors.Default;
            this.RichTextBoxLicence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxLicence.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RichTextBoxLicence.ForeColor = System.Drawing.Color.Gainsboro;
            this.RichTextBoxLicence.Location = new System.Drawing.Point(2, 23);
            this.RichTextBoxLicence.Name = "RichTextBoxLicence";
            this.RichTextBoxLicence.ReadOnly = true;
            this.RichTextBoxLicence.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RichTextBoxLicence.Size = new System.Drawing.Size(581, 168);
            this.RichTextBoxLicence.TabIndex = 4;
            this.RichTextBoxLicence.TabStop = false;
            this.RichTextBoxLicence.Text = resources.GetString("RichTextBoxLicence.Text");
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.RichTextBoxCredits);
            this.groupControl4.Location = new System.Drawing.Point(14, 135);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(290, 132);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "CREDITS";
            // 
            // RichTextBoxCredits
            // 
            this.RichTextBoxCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.RichTextBoxCredits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxCredits.Cursor = System.Windows.Forms.Cursors.Default;
            this.RichTextBoxCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxCredits.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RichTextBoxCredits.ForeColor = System.Drawing.Color.Gainsboro;
            this.RichTextBoxCredits.Location = new System.Drawing.Point(2, 23);
            this.RichTextBoxCredits.Name = "RichTextBoxCredits";
            this.RichTextBoxCredits.ReadOnly = true;
            this.RichTextBoxCredits.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RichTextBoxCredits.Size = new System.Drawing.Size(286, 107);
            this.RichTextBoxCredits.TabIndex = 2;
            this.RichTextBoxCredits.TabStop = false;
            this.RichTextBoxCredits.Text = "Developer: ohhsodead\nContributor: KayGart\n\nWebsite:\nhttps://github.com/ohhsodead/" +
    "ModioX";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(270, 487);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(74, 24);
            this.ButtonClose.TabIndex = 15;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AboutDialog
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(615, 530);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("AboutDialog.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox RichTextBoxInformation;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RichTextBox RichTextBoxThanks;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.RichTextBox RichTextBoxLicence;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.RichTextBox RichTextBoxCredits;
        private DevExpress.XtraEditors.SimpleButton ButtonClose;
    }
}