namespace ModioX.Forms.Settings
{
    partial class ExternalApplicationsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExternalApplicationsDialog));
            this.ColumnApplicationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonBrowseLocalFile = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxFileLocation = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxFileName = new DevExpress.XtraEditors.TextEdit();
            this.LabelFileLocation = new DevExpress.XtraEditors.LabelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.GroupExternalApplications = new DevExpress.XtraEditors.GroupControl();
            this.ProgressLoading = new DevExpress.XtraWaitForm.ProgressPanel();
            this.GridApplications = new DevExpress.XtraGrid.GridControl();
            this.GridViewApplications = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonDeleteApplication = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.GroupApplicationDetails = new DevExpress.XtraEditors.GroupControl();
            this.stackPanel2 = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonNewApplication = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonAddApplication = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSaveAll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupExternalApplications)).BeginInit();
            this.GroupExternalApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupApplicationDetails)).BeginInit();
            this.GroupApplicationDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).BeginInit();
            this.stackPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColumnApplicationName
            // 
            this.ColumnApplicationName.HeaderText = "Application Name";
            this.ColumnApplicationName.Name = "ColumnApplicationName";
            this.ColumnApplicationName.ReadOnly = true;
            this.ColumnApplicationName.Width = 190;
            // 
            // ColumnFileLocation
            // 
            this.ColumnFileLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFileLocation.HeaderText = "File Location";
            this.ColumnFileLocation.Name = "ColumnFileLocation";
            this.ColumnFileLocation.ReadOnly = true;
            this.ColumnFileLocation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnGameTitle
            // 
            this.ColumnGameTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnGameTitle.HeaderText = "Game Title";
            this.ColumnGameTitle.Name = "ColumnGameTitle";
            this.ColumnGameTitle.ReadOnly = true;
            // 
            // ButtonBrowseLocalFile
            // 
            this.ButtonBrowseLocalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowseLocalFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonBrowseLocalFile.Appearance.Options.UseFont = true;
            this.ButtonBrowseLocalFile.Location = new System.Drawing.Point(598, 50);
            this.ButtonBrowseLocalFile.Name = "ButtonBrowseLocalFile";
            this.ButtonBrowseLocalFile.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonBrowseLocalFile.Size = new System.Drawing.Size(42, 22);
            this.ButtonBrowseLocalFile.TabIndex = 5;
            this.ButtonBrowseLocalFile.Text = "...";
            this.ButtonBrowseLocalFile.Click += new System.EventHandler(this.ButtonBrowseLocalFile_Click);
            // 
            // TextBoxFileLocation
            // 
            this.TextBoxFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFileLocation.Location = new System.Drawing.Point(198, 50);
            this.TextBoxFileLocation.Name = "TextBoxFileLocation";
            this.TextBoxFileLocation.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFileLocation.Properties.Appearance.Options.UseFont = true;
            this.TextBoxFileLocation.Size = new System.Drawing.Size(396, 22);
            this.TextBoxFileLocation.TabIndex = 4;
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Location = new System.Drawing.Point(8, 50);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFileName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxFileName.Size = new System.Drawing.Size(184, 22);
            this.TextBoxFileName.TabIndex = 3;
            // 
            // LabelFileLocation
            // 
            this.LabelFileLocation.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileLocation.Appearance.Options.UseFont = true;
            this.LabelFileLocation.Location = new System.Drawing.Point(198, 30);
            this.LabelFileLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelFileLocation.Name = "LabelFileLocation";
            this.LabelFileLocation.Size = new System.Drawing.Size(70, 15);
            this.LabelFileLocation.TabIndex = 15;
            this.LabelFileLocation.Text = "File Location:";
            // 
            // LabelName
            // 
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.Location = new System.Drawing.Point(8, 30);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(99, 15);
            this.LabelName.TabIndex = 16;
            this.LabelName.Text = "Application Name:";
            // 
            // GroupExternalApplications
            // 
            this.GroupExternalApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupExternalApplications.Controls.Add(this.ProgressLoading);
            this.GroupExternalApplications.Controls.Add(this.GridApplications);
            this.GroupExternalApplications.Controls.Add(this.stackPanel1);
            this.GroupExternalApplications.Location = new System.Drawing.Point(16, 12);
            this.GroupExternalApplications.Name = "GroupExternalApplications";
            this.GroupExternalApplications.Size = new System.Drawing.Size(647, 257);
            this.GroupExternalApplications.TabIndex = 1180;
            this.GroupExternalApplications.Text = "EXTERNAL APPLICATIONS";
            // 
            // ProgressLoading
            // 
            this.ProgressLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgressLoading.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProgressLoading.Appearance.Options.UseBackColor = true;
            this.ProgressLoading.AppearanceCaption.Options.UseTextOptions = true;
            this.ProgressLoading.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressLoading.AppearanceDescription.Options.UseTextOptions = true;
            this.ProgressLoading.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressLoading.Caption = "NO EXTERNAL APPLICATIONS";
            this.ProgressLoading.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressLoading.Description = "";
            this.ProgressLoading.Location = new System.Drawing.Point(200, 95);
            this.ProgressLoading.Name = "ProgressLoading";
            this.ProgressLoading.Size = new System.Drawing.Size(246, 66);
            this.ProgressLoading.TabIndex = 1172;
            this.ProgressLoading.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // GridApplications
            // 
            this.GridApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridApplications.Location = new System.Drawing.Point(2, 23);
            this.GridApplications.MainView = this.GridViewApplications;
            this.GridApplications.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.GridApplications.Name = "GridApplications";
            this.GridApplications.Size = new System.Drawing.Size(643, 196);
            this.GridApplications.TabIndex = 0;
            this.GridApplications.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewApplications});
            // 
            // GridViewApplications
            // 
            this.GridViewApplications.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewApplications.GridControl = this.GridApplications;
            this.GridViewApplications.Name = "GridViewApplications";
            this.GridViewApplications.OptionsBehavior.Editable = false;
            this.GridViewApplications.OptionsBehavior.ReadOnly = true;
            this.GridViewApplications.OptionsCustomization.AllowFilter = false;
            this.GridViewApplications.OptionsFilter.AllowFilterEditor = false;
            this.GridViewApplications.OptionsMenu.EnableGroupPanelMenu = false;
            this.GridViewApplications.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewApplications.OptionsView.ShowGroupPanel = false;
            this.GridViewApplications.OptionsView.ShowIndicator = false;
            this.GridViewApplications.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewApplications_RowClick);
            this.GridViewApplications.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewApplications_FocusedRowChanged);
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.ButtonDeleteApplication);
            this.stackPanel1.Controls.Add(this.ButtonDeleteAll);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel1.Location = new System.Drawing.Point(2, 219);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(643, 36);
            this.stackPanel1.TabIndex = 10;
            // 
            // ButtonDeleteApplication
            // 
            this.ButtonDeleteApplication.Enabled = false;
            this.ButtonDeleteApplication.Location = new System.Drawing.Point(6, 6);
            this.ButtonDeleteApplication.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.ButtonDeleteApplication.Name = "ButtonDeleteApplication";
            this.ButtonDeleteApplication.Size = new System.Drawing.Size(67, 24);
            this.ButtonDeleteApplication.TabIndex = 1;
            this.ButtonDeleteApplication.Text = "Delete";
            this.ButtonDeleteApplication.Click += new System.EventHandler(this.ButtonDeleteApplication_Click);
            // 
            // ButtonDeleteAll
            // 
            this.ButtonDeleteAll.Location = new System.Drawing.Point(79, 6);
            this.ButtonDeleteAll.Name = "ButtonDeleteAll";
            this.ButtonDeleteAll.Size = new System.Drawing.Size(84, 24);
            this.ButtonDeleteAll.TabIndex = 2;
            this.ButtonDeleteAll.Text = "Delete All";
            this.ButtonDeleteAll.Click += new System.EventHandler(this.ButtonDeleteAll_Click);
            // 
            // GroupApplicationDetails
            // 
            this.GroupApplicationDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupApplicationDetails.Controls.Add(this.stackPanel2);
            this.GroupApplicationDetails.Controls.Add(this.ButtonBrowseLocalFile);
            this.GroupApplicationDetails.Controls.Add(this.LabelName);
            this.GroupApplicationDetails.Controls.Add(this.TextBoxFileLocation);
            this.GroupApplicationDetails.Controls.Add(this.LabelFileLocation);
            this.GroupApplicationDetails.Controls.Add(this.TextBoxFileName);
            this.GroupApplicationDetails.Location = new System.Drawing.Point(16, 275);
            this.GroupApplicationDetails.Name = "GroupApplicationDetails";
            this.GroupApplicationDetails.Size = new System.Drawing.Size(647, 112);
            this.GroupApplicationDetails.TabIndex = 1181;
            this.GroupApplicationDetails.Text = "APPLICATION DETAILS";
            // 
            // stackPanel2
            // 
            this.stackPanel2.Controls.Add(this.ButtonNewApplication);
            this.stackPanel2.Controls.Add(this.ButtonAddApplication);
            this.stackPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel2.Location = new System.Drawing.Point(2, 74);
            this.stackPanel2.Name = "stackPanel2";
            this.stackPanel2.Size = new System.Drawing.Size(643, 36);
            this.stackPanel2.TabIndex = 10;
            // 
            // ButtonNewApplication
            // 
            this.ButtonNewApplication.Location = new System.Drawing.Point(6, 6);
            this.ButtonNewApplication.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.ButtonNewApplication.Name = "ButtonNewApplication";
            this.ButtonNewApplication.Size = new System.Drawing.Size(123, 24);
            this.ButtonNewApplication.TabIndex = 6;
            this.ButtonNewApplication.Text = "New Application";
            this.ButtonNewApplication.Click += new System.EventHandler(this.ButtonNewApplication_Click);
            // 
            // ButtonAddApplication
            // 
            this.ButtonAddApplication.Location = new System.Drawing.Point(135, 6);
            this.ButtonAddApplication.Name = "ButtonAddApplication";
            this.ButtonAddApplication.Size = new System.Drawing.Size(123, 24);
            this.ButtonAddApplication.TabIndex = 7;
            this.ButtonAddApplication.Text = "Add Application";
            this.ButtonAddApplication.Click += new System.EventHandler(this.ButtonAddApplication_Click);
            // 
            // ButtonSaveAll
            // 
            this.ButtonSaveAll.Location = new System.Drawing.Point(582, 405);
            this.ButtonSaveAll.Name = "ButtonSaveAll";
            this.ButtonSaveAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSaveAll.Size = new System.Drawing.Size(81, 24);
            this.ButtonSaveAll.TabIndex = 8;
            this.ButtonSaveAll.Text = "Save All";
            this.ButtonSaveAll.Click += new System.EventHandler(this.ButtonSaveAll_Click);
            // 
            // ExternalApplicationsDialog
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(675, 438);
            this.Controls.Add(this.GroupApplicationDetails);
            this.Controls.Add(this.GroupExternalApplications);
            this.Controls.Add(this.ButtonSaveAll);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ExternalApplicationsDialog.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExternalApplicationsDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "External Applications";
            this.Load += new System.EventHandler(this.EditExternalApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupExternalApplications)).EndInit();
            this.GroupExternalApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupApplicationDetails)).EndInit();
            this.GroupApplicationDetails.ResumeLayout(false);
            this.GroupApplicationDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel2)).EndInit();
            this.stackPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private DevExpress.XtraEditors.LabelControl LabelFileLocation;
        private DevExpress.XtraEditors.LabelControl LabelName;
        private DevExpress.XtraEditors.TextEdit TextBoxFileLocation;
        private DevExpress.XtraEditors.TextEdit TextBoxFileName;
        private DevExpress.XtraEditors.SimpleButton ButtonBrowseLocalFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApplicationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileLocation;
        private DevExpress.XtraEditors.GroupControl GroupExternalApplications;
        private DevExpress.XtraWaitForm.ProgressPanel ProgressLoading;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton ButtonDeleteApplication;
        private DevExpress.XtraEditors.SimpleButton ButtonDeleteAll;
        private DevExpress.XtraEditors.GroupControl GroupApplicationDetails;
        private DevExpress.Utils.Layout.StackPanel stackPanel2;
        private DevExpress.XtraEditors.SimpleButton ButtonNewApplication;
        private DevExpress.XtraEditors.SimpleButton ButtonAddApplication;
        private DevExpress.XtraEditors.SimpleButton ButtonSaveAll;
        private DevExpress.XtraGrid.GridControl GridApplications;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewApplications;
    }
}