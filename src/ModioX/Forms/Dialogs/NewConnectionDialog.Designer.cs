namespace ModioX.Forms.Dialogs
{
    partial class NewConnectionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConnectionDialog));
            this.ButtonChangeCredentials = new DarkUI.Controls.DarkButton();
            this.LabelUserPass = new DarkUI.Controls.DarkLabel();
            this.LabelLogin = new DarkUI.Controls.DarkLabel();
            this.ButtonCancel = new DarkUI.Controls.DarkButton();
            this.TextBoxConsolePort = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.ButtonOK = new DarkUI.Controls.DarkButton();
            this.LabelName = new DarkUI.Controls.DarkLabel();
            this.TextBoxConnectionName = new DarkUI.Controls.DarkTextBox();
            this.TextBoxConsoleAddress = new DarkUI.Controls.DarkTextBox();
            this.LabelDescription = new DarkUI.Controls.DarkLabel();
            this.SuspendLayout();
            // 
            // ButtonChangeCredentials
            // 
            this.ButtonChangeCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonChangeCredentials.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonChangeCredentials.Location = new System.Drawing.Point(283, 72);
            this.ButtonChangeCredentials.Name = "ButtonChangeCredentials";
            this.ButtonChangeCredentials.Size = new System.Drawing.Size(80, 25);
            this.ButtonChangeCredentials.TabIndex = 3;
            this.ButtonChangeCredentials.Text = "Change";
            this.ButtonChangeCredentials.Click += new System.EventHandler(this.ButtonChangeCredentials_Click);
            // 
            // LabelUserPass
            // 
            this.LabelUserPass.AutoEllipsis = true;
            this.LabelUserPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelUserPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelUserPass.Location = new System.Drawing.Point(122, 77);
            this.LabelUserPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelUserPass.Name = "LabelUserPass";
            this.LabelUserPass.Size = new System.Drawing.Size(158, 15);
            this.LabelUserPass.TabIndex = 1142;
            this.LabelUserPass.Text = "Default";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelLogin.Location = new System.Drawing.Point(12, 77);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(40, 15);
            this.LabelLogin.TabIndex = 1141;
            this.LabelLogin.Text = "Login:";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCancel.Location = new System.Drawing.Point(283, 126);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(80, 25);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // TextBoxConsolePort
            // 
            this.TextBoxConsolePort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConsolePort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConsolePort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConsolePort.Location = new System.Drawing.Point(314, 42);
            this.TextBoxConsolePort.Name = "TextBoxConsolePort";
            this.TextBoxConsolePort.Size = new System.Drawing.Size(49, 23);
            this.TextBoxConsolePort.TabIndex = 2;
            this.TextBoxConsolePort.Text = "21";
            // 
            // darkLabel1
            // 
            this.darkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(276, 44);
            this.darkLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(32, 15);
            this.darkLabel1.TabIndex = 1139;
            this.darkLabel1.Text = "Port:";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonOK.Location = new System.Drawing.Point(193, 126);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(80, 25);
            this.ButtonOK.TabIndex = 4;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelName.Location = new System.Drawing.Point(12, 14);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(107, 15);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Connection Name:";
            // 
            // TextBoxConnectionName
            // 
            this.TextBoxConnectionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConnectionName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConnectionName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConnectionName.Location = new System.Drawing.Point(125, 12);
            this.TextBoxConnectionName.Name = "TextBoxConnectionName";
            this.TextBoxConnectionName.Size = new System.Drawing.Size(238, 23);
            this.TextBoxConnectionName.TabIndex = 0;
            // 
            // TextBoxConsoleAddress
            // 
            this.TextBoxConsoleAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConsoleAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConsoleAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConsoleAddress.Location = new System.Drawing.Point(125, 42);
            this.TextBoxConsoleAddress.Name = "TextBoxConsoleAddress";
            this.TextBoxConsoleAddress.Size = new System.Drawing.Size(145, 23);
            this.TextBoxConsoleAddress.TabIndex = 1;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelDescription.Location = new System.Drawing.Point(12, 44);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(98, 15);
            this.LabelDescription.TabIndex = 14;
            this.LabelDescription.Text = "Console Address:";
            // 
            // NewConnectionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(375, 165);
            this.Controls.Add(this.ButtonChangeCredentials);
            this.Controls.Add(this.LabelUserPass);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextBoxConsoleAddress);
            this.Controls.Add(this.TextBoxConsolePort);
            this.Controls.Add(this.TextBoxConnectionName);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.ButtonOK);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewConnectionDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection Details";
            this.Load += new System.EventHandler(this.ConsolesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkLabel LabelName;
        private DarkUI.Controls.DarkTextBox TextBoxConnectionName;
        private DarkUI.Controls.DarkTextBox TextBoxConsoleAddress;
        private DarkUI.Controls.DarkLabel LabelDescription;
        private DarkUI.Controls.DarkButton ButtonOK;
        private DarkUI.Controls.DarkButton ButtonChangeCredentials;
        private DarkUI.Controls.DarkLabel LabelUserPass;
        private DarkUI.Controls.DarkLabel LabelLogin;
        private DarkUI.Controls.DarkButton ButtonCancel;
        private DarkUI.Controls.DarkTextBox TextBoxConsolePort;
        private DarkUI.Controls.DarkLabel darkLabel1;
    }
}