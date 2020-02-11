namespace ModioX.Forms.Connection
{
    partial class ConsoleConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleConnection));
            this.ButtonConnect = new DarkUI.Controls.DarkButton();
            this.ListViewConsoleProfiles = new DarkUI.Controls.DarkListView();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.darkSectionPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConnect.Enabled = false;
            this.ButtonConnect.Location = new System.Drawing.Point(12, 221);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(224, 24);
            this.ButtonConnect.TabIndex = 1;
            this.ButtonConnect.Text = "Connect Console";
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ListViewConsoleProfiles
            // 
            this.ListViewConsoleProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewConsoleProfiles.Location = new System.Drawing.Point(1, 25);
            this.ListViewConsoleProfiles.Name = "ListViewConsoleProfiles";
            this.ListViewConsoleProfiles.Size = new System.Drawing.Size(222, 176);
            this.ListViewConsoleProfiles.TabIndex = 0;
            this.ListViewConsoleProfiles.Text = "darkListView1";
            this.ListViewConsoleProfiles.SelectedIndicesChanged += new System.EventHandler(this.ListViewConsoleProfiles_SelectedIndicesChanged);
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkSectionPanel2.Controls.Add(this.ListViewConsoleProfiles);
            this.darkSectionPanel2.Location = new System.Drawing.Point(12, 12);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "Choose Profile...";
            this.darkSectionPanel2.Size = new System.Drawing.Size(224, 202);
            this.darkSectionPanel2.TabIndex = 0;
            // 
            // ConsoleConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(248, 257);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.ButtonConnect);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsoleConnection";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Console Connection";
            this.Load += new System.EventHandler(this.ConnectConsole_Load);
            this.darkSectionPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkButton ButtonConnect;
        private DarkUI.Controls.DarkListView ListViewConsoleProfiles;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
    }
}