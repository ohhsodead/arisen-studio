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
            this.ButtonSaveAll = new DarkUI.Controls.DarkButton();
            this.ColumnApplicationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionAddApplication = new DarkUI.Controls.DarkSectionPanel();
            this.ButtonNewApplication = new DarkUI.Controls.DarkButton();
            this.ButtonLocalFilePath = new DarkUI.Controls.DarkButton();
            this.TextBoxFileLocation = new DarkUI.Controls.DarkTextBox();
            this.TextBoxFileName = new DarkUI.Controls.DarkTextBox();
            this.ButtonAddApplication = new DarkUI.Controls.DarkButton();
            this.LabelFileLocation = new DarkUI.Controls.DarkLabel();
            this.LabelName = new DarkUI.Controls.DarkLabel();
            this.GroupExternalApplications = new DevExpress.XtraEditors.GroupControl();
            this.ProgressCustomLists = new DevExpress.XtraWaitForm.ProgressPanel();
            this.GridControlExternalApplications = new DevExpress.XtraGrid.GridControl();
            this.GridViewExternalApplications = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonDeleteApplication = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteAllLists = new DevExpress.XtraEditors.SimpleButton();
            this.SectionAddApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupExternalApplications)).BeginInit();
            this.GroupExternalApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlExternalApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewExternalApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSaveAll
            // 
            this.ButtonSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveAll.Location = new System.Drawing.Point(582, 403);
            this.ButtonSaveAll.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonSaveAll.Name = "ButtonSaveAll";
            this.ButtonSaveAll.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonSaveAll.Size = new System.Drawing.Size(79, 24);
            this.ButtonSaveAll.TabIndex = 3;
            this.ButtonSaveAll.Text = "Save All";
            this.ButtonSaveAll.Click += new System.EventHandler(this.ButtonSaveAll_Click);
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
            // SectionAddApplication
            // 
            this.SectionAddApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionAddApplication.Controls.Add(this.ButtonNewApplication);
            this.SectionAddApplication.Controls.Add(this.ButtonLocalFilePath);
            this.SectionAddApplication.Controls.Add(this.TextBoxFileLocation);
            this.SectionAddApplication.Controls.Add(this.TextBoxFileName);
            this.SectionAddApplication.Controls.Add(this.ButtonAddApplication);
            this.SectionAddApplication.Controls.Add(this.LabelFileLocation);
            this.SectionAddApplication.Controls.Add(this.LabelName);
            this.SectionAddApplication.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionAddApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionAddApplication.Location = new System.Drawing.Point(12, 276);
            this.SectionAddApplication.Margin = new System.Windows.Forms.Padding(4);
            this.SectionAddApplication.Name = "SectionAddApplication";
            this.SectionAddApplication.SectionHeader = "APPLICATION DETAILS";
            this.SectionAddApplication.Size = new System.Drawing.Size(651, 118);
            this.SectionAddApplication.TabIndex = 1179;
            // 
            // ButtonNewApplication
            // 
            this.ButtonNewApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNewApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonNewApplication.Location = new System.Drawing.Point(376, 84);
            this.ButtonNewApplication.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonNewApplication.Name = "ButtonNewApplication";
            this.ButtonNewApplication.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonNewApplication.Size = new System.Drawing.Size(128, 24);
            this.ButtonNewApplication.TabIndex = 1185;
            this.ButtonNewApplication.Text = "New Application";
            this.ButtonNewApplication.Click += new System.EventHandler(this.ButtonNewApplication_Click);
            // 
            // ButtonLocalFilePath
            // 
            this.ButtonLocalFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLocalFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonLocalFilePath.Location = new System.Drawing.Point(600, 51);
            this.ButtonLocalFilePath.Name = "ButtonLocalFilePath";
            this.ButtonLocalFilePath.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonLocalFilePath.Size = new System.Drawing.Size(42, 23);
            this.ButtonLocalFilePath.TabIndex = 1184;
            this.ButtonLocalFilePath.Text = "...";
            this.ButtonLocalFilePath.Click += new System.EventHandler(this.ButtonLocalFilePath_Click);
            // 
            // TextBoxFileLocation
            // 
            this.TextBoxFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFileLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxFileLocation.Location = new System.Drawing.Point(198, 51);
            this.TextBoxFileLocation.Name = "TextBoxFileLocation";
            this.TextBoxFileLocation.Size = new System.Drawing.Size(396, 23);
            this.TextBoxFileLocation.TabIndex = 1183;
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFileName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxFileName.Location = new System.Drawing.Point(8, 51);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.Size = new System.Drawing.Size(184, 23);
            this.TextBoxFileName.TabIndex = 1182;
            // 
            // ButtonAddApplication
            // 
            this.ButtonAddApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAddApplication.Location = new System.Drawing.Point(514, 84);
            this.ButtonAddApplication.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonAddApplication.Name = "ButtonAddApplication";
            this.ButtonAddApplication.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonAddApplication.Size = new System.Drawing.Size(128, 24);
            this.ButtonAddApplication.TabIndex = 1180;
            this.ButtonAddApplication.Text = "Add Application";
            this.ButtonAddApplication.Click += new System.EventHandler(this.ButtonAddApplication_Click);
            // 
            // LabelFileLocation
            // 
            this.LabelFileLocation.AutoSize = true;
            this.LabelFileLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFileLocation.Location = new System.Drawing.Point(196, 31);
            this.LabelFileLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelFileLocation.Name = "LabelFileLocation";
            this.LabelFileLocation.Size = new System.Drawing.Size(77, 15);
            this.LabelFileLocation.TabIndex = 15;
            this.LabelFileLocation.Text = "File Location:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelName.Location = new System.Drawing.Point(6, 31);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(106, 15);
            this.LabelName.TabIndex = 16;
            this.LabelName.Text = "Application Name:";
            // 
            // GroupExternalApplications
            // 
            this.GroupExternalApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupExternalApplications.Controls.Add(this.ProgressCustomLists);
            this.GroupExternalApplications.Controls.Add(this.GridControlExternalApplications);
            this.GroupExternalApplications.Controls.Add(this.stackPanel1);
            this.GroupExternalApplications.Location = new System.Drawing.Point(16, 12);
            this.GroupExternalApplications.Name = "GroupExternalApplications";
            this.GroupExternalApplications.Size = new System.Drawing.Size(647, 257);
            this.GroupExternalApplications.TabIndex = 1180;
            this.GroupExternalApplications.Text = "EXTERNAL APPLICATIONS";
            // 
            // ProgressCustomLists
            // 
            this.ProgressCustomLists.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgressCustomLists.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProgressCustomLists.Appearance.Options.UseBackColor = true;
            this.ProgressCustomLists.AppearanceCaption.Options.UseTextOptions = true;
            this.ProgressCustomLists.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressCustomLists.AppearanceDescription.Options.UseTextOptions = true;
            this.ProgressCustomLists.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProgressCustomLists.Caption = "NO EXTERNAL APPLICATIONS";
            this.ProgressCustomLists.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressCustomLists.Description = "Loading..";
            this.ProgressCustomLists.Location = new System.Drawing.Point(200, 101);
            this.ProgressCustomLists.Name = "ProgressCustomLists";
            this.ProgressCustomLists.Size = new System.Drawing.Size(246, 66);
            this.ProgressCustomLists.TabIndex = 1172;
            this.ProgressCustomLists.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // GridControlExternalApplications
            // 
            this.GridControlExternalApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlExternalApplications.Location = new System.Drawing.Point(2, 23);
            this.GridControlExternalApplications.MainView = this.GridViewExternalApplications;
            this.GridControlExternalApplications.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.GridControlExternalApplications.Name = "GridControlExternalApplications";
            this.GridControlExternalApplications.Size = new System.Drawing.Size(643, 196);
            this.GridControlExternalApplications.TabIndex = 0;
            this.GridControlExternalApplications.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewExternalApplications});
            // 
            // GridViewExternalApplications
            // 
            this.GridViewExternalApplications.ActiveFilterEnabled = false;
            this.GridViewExternalApplications.GridControl = this.GridControlExternalApplications;
            this.GridViewExternalApplications.Name = "GridViewExternalApplications";
            this.GridViewExternalApplications.OptionsBehavior.ReadOnly = true;
            this.GridViewExternalApplications.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.GridViewExternalApplications.OptionsView.ShowGroupPanel = false;
            this.GridViewExternalApplications.OptionsView.ShowIndicator = false;
            this.GridViewExternalApplications.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.ButtonDeleteApplication);
            this.stackPanel1.Controls.Add(this.ButtonDeleteAllLists);
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
            this.ButtonDeleteApplication.Size = new System.Drawing.Size(82, 24);
            this.ButtonDeleteApplication.TabIndex = 12;
            this.ButtonDeleteApplication.Text = "Delete List";
            // 
            // ButtonDeleteAllLists
            // 
            this.ButtonDeleteAllLists.Enabled = false;
            this.ButtonDeleteAllLists.Location = new System.Drawing.Point(94, 6);
            this.ButtonDeleteAllLists.Name = "ButtonDeleteAllLists";
            this.ButtonDeleteAllLists.Size = new System.Drawing.Size(84, 24);
            this.ButtonDeleteAllLists.TabIndex = 13;
            this.ButtonDeleteAllLists.Text = "Delete All";
            // 
            // ExternalApplicationsDialog
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(675, 441);
            this.Controls.Add(this.GroupExternalApplications);
            this.Controls.Add(this.SectionAddApplication);
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
            this.SectionAddApplication.ResumeLayout(false);
            this.SectionAddApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupExternalApplications)).EndInit();
            this.GroupExternalApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlExternalApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewExternalApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkButton ButtonSaveAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private DarkUI.Controls.DarkSectionPanel SectionAddApplication;
        private DarkUI.Controls.DarkLabel LabelFileLocation;
        private DarkUI.Controls.DarkLabel LabelName;
        private DarkUI.Controls.DarkButton ButtonAddApplication;
        private DarkUI.Controls.DarkTextBox TextBoxFileLocation;
        private DarkUI.Controls.DarkTextBox TextBoxFileName;
        private DarkUI.Controls.DarkButton ButtonLocalFilePath;
        private DarkUI.Controls.DarkButton ButtonNewApplication;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApplicationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileLocation;
        private DevExpress.XtraEditors.GroupControl GroupExternalApplications;
        private DevExpress.XtraWaitForm.ProgressPanel ProgressCustomLists;
        private DevExpress.XtraGrid.GridControl GridControlExternalApplications;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewExternalApplications;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton ButtonDeleteApplication;
        private DevExpress.XtraEditors.SimpleButton ButtonDeleteAllLists;
    }
}