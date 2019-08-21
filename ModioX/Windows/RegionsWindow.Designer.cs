namespace ModioX.Windows
{
    partial class RegionsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegionsWindow));
            this.ListViewRegions = new DarkUI.Controls.DarkListView();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.darkSectionPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewRegions
            // 
            this.ListViewRegions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewRegions.Location = new System.Drawing.Point(1, 25);
            this.ListViewRegions.Name = "ListViewRegions";
            this.ListViewRegions.Size = new System.Drawing.Size(154, 143);
            this.ListViewRegions.TabIndex = 1;
            this.ListViewRegions.Text = "darkListView1";
            this.ListViewRegions.SelectedIndicesChanged += new System.EventHandler(this.ListViewRegions_SelectedIndicesChanged);
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkSectionPanel1.Controls.Add(this.ListViewRegions);
            this.darkSectionPanel1.Location = new System.Drawing.Point(12, 12);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Choose Your Region...";
            this.darkSectionPanel1.Size = new System.Drawing.Size(156, 169);
            this.darkSectionPanel1.TabIndex = 2;
            // 
            // RegionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 193);
            this.Controls.Add(this.darkSectionPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegionsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Regions";
            this.darkSectionPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DarkUI.Controls.DarkListView ListViewRegions;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
    }
}