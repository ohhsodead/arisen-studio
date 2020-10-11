namespace ModioX.Forms
{
    partial class LoginDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDialog));
            this.ButtonUseDefault = new DarkUI.Controls.DarkButton();
            this.ButtonCancel = new DarkUI.Controls.DarkButton();
            this.ButtonOK = new DarkUI.Controls.DarkButton();
            this.LabelName = new DarkUI.Controls.DarkLabel();
            this.TextBoxUsername = new DarkUI.Controls.DarkTextBox();
            this.TextBoxPassword = new DarkUI.Controls.DarkTextBox();
            this.LabelDescription = new DarkUI.Controls.DarkLabel();
            this.SectionNewConsoleProfile = new DarkUI.Controls.DarkSectionPanel();
            this.SectionNewConsoleProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonUseDefault
            // 
            this.ButtonUseDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUseDefault.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.ButtonUseDefault.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUseDefault.Location = new System.Drawing.Point(84, 96);
            this.ButtonUseDefault.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonUseDefault.Name = "ButtonUseDefault";
            this.ButtonUseDefault.Size = new System.Drawing.Size(85, 25);
            this.ButtonUseDefault.TabIndex = 4;
            this.ButtonUseDefault.Text = "Use Default";
            this.ButtonUseDefault.Click += new System.EventHandler(this.ButtonUseDefault_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCancel.Location = new System.Drawing.Point(274, 96);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(85, 25);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Enabled = false;
            this.ButtonOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonOK.Location = new System.Drawing.Point(179, 96);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(85, 25);
            this.ButtonOK.TabIndex = 2;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelName.Location = new System.Drawing.Point(6, 31);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(63, 15);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Username:";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUsername.Location = new System.Drawing.Point(84, 29);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(275, 23);
            this.TextBoxUsername.TabIndex = 0;
            this.TextBoxUsername.TextChanged += new System.EventHandler(this.TextBoxUsername_TextChanged);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPassword.Location = new System.Drawing.Point(84, 58);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(275, 23);
            this.TextBoxPassword.TabIndex = 1;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelDescription.Location = new System.Drawing.Point(6, 60);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(60, 15);
            this.LabelDescription.TabIndex = 14;
            this.LabelDescription.Text = "Password:";
            // 
            // SectionNewConsoleProfile
            // 
            this.SectionNewConsoleProfile.Controls.Add(this.ButtonUseDefault);
            this.SectionNewConsoleProfile.Controls.Add(this.ButtonCancel);
            this.SectionNewConsoleProfile.Controls.Add(this.ButtonOK);
            this.SectionNewConsoleProfile.Controls.Add(this.LabelName);
            this.SectionNewConsoleProfile.Controls.Add(this.TextBoxUsername);
            this.SectionNewConsoleProfile.Controls.Add(this.TextBoxPassword);
            this.SectionNewConsoleProfile.Controls.Add(this.LabelDescription);
            this.SectionNewConsoleProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionNewConsoleProfile.Location = new System.Drawing.Point(13, 12);
            this.SectionNewConsoleProfile.Margin = new System.Windows.Forms.Padding(4);
            this.SectionNewConsoleProfile.Name = "SectionNewConsoleProfile";
            this.SectionNewConsoleProfile.SectionHeader = "Log in as:";
            this.SectionNewConsoleProfile.Size = new System.Drawing.Size(367, 131);
            this.SectionNewConsoleProfile.TabIndex = 1140;
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(388, 156);
            this.Controls.Add(this.SectionNewConsoleProfile);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Credentials";
            this.Load += new System.EventHandler(this.ConsoleCredentials_Load);
            this.SectionNewConsoleProfile.ResumeLayout(false);
            this.SectionNewConsoleProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkLabel LabelName;
        private DarkUI.Controls.DarkLabel LabelDescription;
        private DarkUI.Controls.DarkButton ButtonOK;
        private DarkUI.Controls.DarkButton ButtonUseDefault;
        private DarkUI.Controls.DarkButton ButtonCancel;
        public DarkUI.Controls.DarkTextBox TextBoxUsername;
        public DarkUI.Controls.DarkTextBox TextBoxPassword;
        private DarkUI.Controls.DarkSectionPanel SectionNewConsoleProfile;
    }
}