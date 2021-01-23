namespace ModioX.Forms.Settings
{
    partial class CustomListsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomListsDialog));
            this.GridCustomLists = new DevExpress.XtraGrid.GridControl();
            this.GridViewCustomLists = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonCreateNewList = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRenameList = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteList = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteAllLists = new DevExpress.XtraEditors.SimpleButton();
            this.ProgressCustomLists = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCustomLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridCustomLists
            // 
            this.GridCustomLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCustomLists.Location = new System.Drawing.Point(2, 23);
            this.GridCustomLists.MainView = this.GridViewCustomLists;
            this.GridCustomLists.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.GridCustomLists.Name = "GridCustomLists";
            this.GridCustomLists.Size = new System.Drawing.Size(403, 228);
            this.GridCustomLists.TabIndex = 0;
            this.GridCustomLists.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewCustomLists});
            this.GridCustomLists.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.GridCustomLists_FocusedViewChanged);
            // 
            // GridViewCustomLists
            // 
            this.GridViewCustomLists.GridControl = this.GridCustomLists;
            this.GridViewCustomLists.Name = "GridViewCustomLists";
            this.GridViewCustomLists.OptionsBehavior.ReadOnly = true;
            this.GridViewCustomLists.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.GridViewCustomLists.OptionsView.ShowGroupPanel = false;
            this.GridViewCustomLists.OptionsView.ShowIndicator = false;
            this.GridViewCustomLists.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnRegion
            // 
            this.ColumnRegion.HeaderText = "# of Mods";
            this.ColumnRegion.Name = "ColumnRegion";
            this.ColumnRegion.ReadOnly = true;
            this.ColumnRegion.Width = 80;
            // 
            // ColumnGameRegion
            // 
            this.ColumnGameRegion.HeaderText = "Game Region";
            this.ColumnGameRegion.Name = "ColumnGameRegion";
            this.ColumnGameRegion.Width = 120;
            // 
            // ColumnGameTitle
            // 
            this.ColumnGameTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnGameTitle.HeaderText = "Game Title";
            this.ColumnGameTitle.Name = "ColumnGameTitle";
            this.ColumnGameTitle.ReadOnly = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ProgressCustomLists);
            this.groupControl1.Controls.Add(this.GridCustomLists);
            this.groupControl1.Controls.Add(this.stackPanel1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(407, 289);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "YOUR LISTS";
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.ButtonCreateNewList);
            this.stackPanel1.Controls.Add(this.ButtonRenameList);
            this.stackPanel1.Controls.Add(this.ButtonDeleteList);
            this.stackPanel1.Controls.Add(this.ButtonDeleteAllLists);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel1.Location = new System.Drawing.Point(2, 251);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(403, 36);
            this.stackPanel1.TabIndex = 10;
            // 
            // ButtonCreateNewList
            // 
            this.ButtonCreateNewList.Location = new System.Drawing.Point(6, 6);
            this.ButtonCreateNewList.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.ButtonCreateNewList.Name = "ButtonCreateNewList";
            this.ButtonCreateNewList.Size = new System.Drawing.Size(101, 24);
            this.ButtonCreateNewList.TabIndex = 10;
            this.ButtonCreateNewList.Text = "Create New List";
            this.ButtonCreateNewList.Click += new System.EventHandler(this.ButtonCreateNewList_Click);
            // 
            // ButtonRenameList
            // 
            this.ButtonRenameList.Enabled = false;
            this.ButtonRenameList.Location = new System.Drawing.Point(113, 6);
            this.ButtonRenameList.Name = "ButtonRenameList";
            this.ButtonRenameList.Size = new System.Drawing.Size(89, 24);
            this.ButtonRenameList.TabIndex = 11;
            this.ButtonRenameList.Text = "Rename List";
            this.ButtonRenameList.Click += new System.EventHandler(this.ButtonRenameList_Click);
            // 
            // ButtonDeleteList
            // 
            this.ButtonDeleteList.Enabled = false;
            this.ButtonDeleteList.Location = new System.Drawing.Point(208, 6);
            this.ButtonDeleteList.Name = "ButtonDeleteList";
            this.ButtonDeleteList.Size = new System.Drawing.Size(82, 24);
            this.ButtonDeleteList.TabIndex = 12;
            this.ButtonDeleteList.Text = "Delete List";
            this.ButtonDeleteList.Click += new System.EventHandler(this.ButtonDeleteList_Click);
            // 
            // ButtonDeleteAllLists
            // 
            this.ButtonDeleteAllLists.Enabled = false;
            this.ButtonDeleteAllLists.Location = new System.Drawing.Point(296, 6);
            this.ButtonDeleteAllLists.Name = "ButtonDeleteAllLists";
            this.ButtonDeleteAllLists.Size = new System.Drawing.Size(101, 24);
            this.ButtonDeleteAllLists.TabIndex = 13;
            this.ButtonDeleteAllLists.Text = "Delete All Lists";
            this.ButtonDeleteAllLists.Click += new System.EventHandler(this.ButtonDeleteAllLists_Click);
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
            this.ProgressCustomLists.Caption = "NO CUSTOM LISTS";
            this.ProgressCustomLists.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressCustomLists.Description = "Loading..";
            this.ProgressCustomLists.Location = new System.Drawing.Point(80, 101);
            this.ProgressCustomLists.Name = "ProgressCustomLists";
            this.ProgressCustomLists.Size = new System.Drawing.Size(246, 66);
            this.ProgressCustomLists.TabIndex = 1172;
            this.ProgressCustomLists.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // CustomListsDialog
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(431, 313);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("CustomListsDialog.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomListsDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Lists";
            this.Load += new System.EventHandler(this.CustomListsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCustomLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GridCustomLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRegion;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewCustomLists;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton ButtonCreateNewList;
        private DevExpress.XtraEditors.SimpleButton ButtonRenameList;
        private DevExpress.XtraEditors.SimpleButton ButtonDeleteList;
        private DevExpress.XtraEditors.SimpleButton ButtonDeleteAllLists;
        private DevExpress.XtraWaitForm.ProgressPanel ProgressCustomLists;
    }
}