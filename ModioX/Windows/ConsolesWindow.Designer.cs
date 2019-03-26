namespace ModioX.Windows
{
    partial class ConsolesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsolesWindow));
            this.ListboxConsoles = new System.Windows.Forms.ListBox();
            this.TextBoxConsoleName = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.TextBoxProfileIP = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.ButtonAddProfile = new System.Windows.Forms.Button();
            this.ButtonRemoveProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListboxConsoles
            // 
            this.ListboxConsoles.FormattingEnabled = true;
            this.ListboxConsoles.ItemHeight = 15;
            this.ListboxConsoles.Location = new System.Drawing.Point(12, 68);
            this.ListboxConsoles.Name = "ListboxConsoles";
            this.ListboxConsoles.Size = new System.Drawing.Size(358, 139);
            this.ListboxConsoles.TabIndex = 4;
            this.ListboxConsoles.SelectedIndexChanged += new System.EventHandler(this.ListBoxProfiles_SelectedIndexChanged);
            // 
            // TextBoxConsoleName
            // 
            this.TextBoxConsoleName.Location = new System.Drawing.Point(12, 12);
            this.TextBoxConsoleName.Name = "TextBoxConsoleName";
            this.TextBoxConsoleName.Size = new System.Drawing.Size(270, 21);
            this.TextBoxConsoleName.TabIndex = 0;
            this.TextBoxConsoleName.WaterMark = "Console Name...";
            this.TextBoxConsoleName.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.TextBoxConsoleName.WaterMarkFont = new System.Drawing.Font("Consolas", 9F);
            this.TextBoxConsoleName.WaterMarkForeColor = System.Drawing.Color.DimGray;
            this.TextBoxConsoleName.TextChanged += new System.EventHandler(this.TextBoxProfileName_TextChanged);
            // 
            // TextBoxProfileIP
            // 
            this.TextBoxProfileIP.Location = new System.Drawing.Point(12, 40);
            this.TextBoxProfileIP.Name = "TextBoxProfileIP";
            this.TextBoxProfileIP.Size = new System.Drawing.Size(270, 21);
            this.TextBoxProfileIP.TabIndex = 1;
            this.TextBoxProfileIP.WaterMark = "IP Address...";
            this.TextBoxProfileIP.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.TextBoxProfileIP.WaterMarkFont = new System.Drawing.Font("Consolas", 9F);
            this.TextBoxProfileIP.WaterMarkForeColor = System.Drawing.Color.DimGray;
            this.TextBoxProfileIP.TextChanged += new System.EventHandler(this.TextBoxProfileIP_TextChanged);
            // 
            // ButtonAddProfile
            // 
            this.ButtonAddProfile.Enabled = false;
            this.ButtonAddProfile.Font = new System.Drawing.Font("Arial", 9F);
            this.ButtonAddProfile.Location = new System.Drawing.Point(288, 12);
            this.ButtonAddProfile.Name = "ButtonAddProfile";
            this.ButtonAddProfile.Size = new System.Drawing.Size(82, 22);
            this.ButtonAddProfile.TabIndex = 5;
            this.ButtonAddProfile.Text = "Add";
            this.ButtonAddProfile.UseVisualStyleBackColor = true;
            this.ButtonAddProfile.Click += new System.EventHandler(this.ButtonAddProfile_Click);
            // 
            // ButtonRemoveProfile
            // 
            this.ButtonRemoveProfile.Enabled = false;
            this.ButtonRemoveProfile.Font = new System.Drawing.Font("Arial", 9F);
            this.ButtonRemoveProfile.Location = new System.Drawing.Point(288, 39);
            this.ButtonRemoveProfile.Name = "ButtonRemoveProfile";
            this.ButtonRemoveProfile.Size = new System.Drawing.Size(82, 22);
            this.ButtonRemoveProfile.TabIndex = 6;
            this.ButtonRemoveProfile.Text = "Remove";
            this.ButtonRemoveProfile.UseVisualStyleBackColor = true;
            this.ButtonRemoveProfile.Click += new System.EventHandler(this.ButtonRemoveProfile_Click);
            // 
            // ConsolesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 219);
            this.Controls.Add(this.ButtonRemoveProfile);
            this.Controls.Add(this.ButtonAddProfile);
            this.Controls.Add(this.TextBoxProfileIP);
            this.Controls.Add(this.TextBoxConsoleName);
            this.Controls.Add(this.ListboxConsoles);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsolesWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consoles";
            this.Load += new System.EventHandler(this.ProfilesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListboxConsoles;
        private ChreneLib.Controls.TextBoxes.CTextBox TextBoxConsoleName;
        private ChreneLib.Controls.TextBoxes.CTextBox TextBoxProfileIP;
        private System.Windows.Forms.Button ButtonAddProfile;
        private System.Windows.Forms.Button ButtonRemoveProfile;
    }
}