namespace ModioX.Forms.Dialogs
{
    partial class ConnectionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionDialog));
            this.ListViewConsoleProfiles = new DarkUI.Controls.DarkListView();
            this.SectionItems = new DarkUI.Controls.DarkSectionPanel();
            this.ButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonConnect = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.SectionItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewConsoleProfiles
            // 
            this.ListViewConsoleProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewConsoleProfiles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ListViewConsoleProfiles.Location = new System.Drawing.Point(1, 25);
            this.ListViewConsoleProfiles.Name = "ListViewConsoleProfiles";
            this.ListViewConsoleProfiles.Size = new System.Drawing.Size(222, 184);
            this.ListViewConsoleProfiles.TabIndex = 0;
            this.ListViewConsoleProfiles.Text = "darkListView1";
            this.ListViewConsoleProfiles.SelectedIndicesChanged += new System.EventHandler(this.ListViewConsoleProfiles_SelectedIndicesChanged);
            // 
            // SectionItems
            // 
            this.SectionItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionItems.Controls.Add(this.ListViewConsoleProfiles);
            this.SectionItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionItems.Location = new System.Drawing.Point(12, 12);
            this.SectionItems.Name = "SectionItems";
            this.SectionItems.SectionHeader = "Choose Profile";
            this.SectionItems.Size = new System.Drawing.Size(224, 210);
            this.SectionItems.TabIndex = 2;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.AllowFocus = false;
            this.ButtonEdit.Location = new System.Drawing.Point(12, 228);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(60, 25);
            this.ButtonEdit.TabIndex = 6;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit1_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.AllowFocus = false;
            this.ButtonConnect.Location = new System.Drawing.Point(156, 228);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(80, 25);
            this.ButtonConnect.TabIndex = 4;
            this.ButtonConnect.Text = "Connect";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AllowFocus = false;
            this.ButtonDelete.Location = new System.Drawing.Point(78, 228);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(72, 25);
            this.ButtonDelete.TabIndex = 5;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ConnectionDialog
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(248, 265);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.SectionItems);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ConnectionDialog.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connections";
            this.Load += new System.EventHandler(this.ConnectConsole_Load);
            this.SectionItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkListView ListViewConsoleProfiles;
        private DarkUI.Controls.DarkSectionPanel SectionItems;
        private DevExpress.XtraEditors.SimpleButton ButtonConnect;
        private DevExpress.XtraEditors.SimpleButton ButtonEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonDelete;
    }
}