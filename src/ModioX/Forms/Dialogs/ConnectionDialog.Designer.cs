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
            this.ButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonConnect = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ScrollBarConsoleProfiles = new DevExpress.XtraEditors.VScrollBar();
            this.PanelConsoleProfiles = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonNewConnection = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.AllowFocus = false;
            this.ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEdit.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonEdit.Appearance.Options.UseFont = true;
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.Location = new System.Drawing.Point(249, 357);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(60, 25);
            this.ButtonEdit.TabIndex = 1;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.AllowFocus = false;
            this.ButtonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConnect.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonConnect.Appearance.Options.UseFont = true;
            this.ButtonConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonConnect.Enabled = false;
            this.ButtonConnect.Location = new System.Drawing.Point(393, 357);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(80, 25);
            this.ButtonConnect.TabIndex = 3;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AllowFocus = false;
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDelete.Appearance.Options.UseFont = true;
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(315, 357);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(72, 25);
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.ScrollBarConsoleProfiles);
            this.groupControl1.Controls.Add(this.PanelConsoleProfiles);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(461, 339);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Console Profiles";
            // 
            // ScrollBarConsoleProfiles
            // 
            this.ScrollBarConsoleProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarConsoleProfiles.Location = new System.Drawing.Point(441, 22);
            this.ScrollBarConsoleProfiles.Name = "ScrollBarConsoleProfiles";
            this.ScrollBarConsoleProfiles.Size = new System.Drawing.Size(17, 315);
            this.ScrollBarConsoleProfiles.TabIndex = 1;
            this.ScrollBarConsoleProfiles.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarConsoleProfiles_Scroll);
            // 
            // PanelConsoleProfiles
            // 
            this.PanelConsoleProfiles.AutoScroll = true;
            this.PanelConsoleProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelConsoleProfiles.Location = new System.Drawing.Point(2, 23);
            this.PanelConsoleProfiles.Name = "PanelConsoleProfiles";
            this.PanelConsoleProfiles.Size = new System.Drawing.Size(457, 314);
            this.PanelConsoleProfiles.TabIndex = 0;
            this.PanelConsoleProfiles.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PanelConsoleProfiles_ControlAddedOrRemoved);
            this.PanelConsoleProfiles.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PanelConsoleProfiles_ControlAddedOrRemoved);
            // 
            // ButtonNewConnection
            // 
            this.ButtonNewConnection.AllowFocus = false;
            this.ButtonNewConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNewConnection.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonNewConnection.Appearance.Options.UseFont = true;
            this.ButtonNewConnection.Location = new System.Drawing.Point(12, 357);
            this.ButtonNewConnection.Name = "ButtonNewConnection";
            this.ButtonNewConnection.Size = new System.Drawing.Size(122, 25);
            this.ButtonNewConnection.TabIndex = 8;
            this.ButtonNewConnection.Text = "New Connection";
            this.ButtonNewConnection.Click += new System.EventHandler(this.ButtonNewConnection_Click);
            // 
            // ConnectionDialog
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(485, 394);
            this.Controls.Add(this.ButtonNewConnection);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonConnect);
            this.DoubleBuffered = true;
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
            this.SizeChanged += new System.EventHandler(this.ConnectionDialogTest_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton ButtonConnect;
        private DevExpress.XtraEditors.SimpleButton ButtonEdit;
        private DevExpress.XtraEditors.SimpleButton ButtonDelete;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.VScrollBar ScrollBarConsoleProfiles;
        private System.Windows.Forms.FlowLayoutPanel PanelConsoleProfiles;
        private DevExpress.XtraEditors.SimpleButton ButtonNewConnection;
    }
}