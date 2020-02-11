namespace ModioX.Windows
{
    partial class ListViewDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewDialog));
            this.ListViewItems = new DarkUI.Controls.DarkListView();
            this.SectionItems = new DarkUI.Controls.DarkSectionPanel();
            this.SectionItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewItems
            // 
            this.ListViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewItems.ItemHeight = 22;
            this.ListViewItems.Location = new System.Drawing.Point(1, 25);
            this.ListViewItems.Name = "ListViewItems";
            this.ListViewItems.Size = new System.Drawing.Size(159, 169);
            this.ListViewItems.TabIndex = 1;
            this.ListViewItems.Text = "darkListView1";
            this.ListViewItems.SelectedIndicesChanged += new System.EventHandler(this.ListViewRegions_SelectedIndicesChanged);
            // 
            // SectionItems
            // 
            this.SectionItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionItems.Controls.Add(this.ListViewItems);
            this.SectionItems.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SectionItems.Location = new System.Drawing.Point(14, 14);
            this.SectionItems.Name = "SectionItems";
            this.SectionItems.SectionHeader = "Choose Item...";
            this.SectionItems.Size = new System.Drawing.Size(161, 195);
            this.SectionItems.TabIndex = 0;
            // 
            // ListViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 223);
            this.Controls.Add(this.SectionItems);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListViewDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Regions";
            this.Load += new System.EventHandler(this.ListViewDialog_Load);
            this.SectionItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DarkUI.Controls.DarkListView ListViewItems;
        private DarkUI.Controls.DarkSectionPanel SectionItems;
    }
}