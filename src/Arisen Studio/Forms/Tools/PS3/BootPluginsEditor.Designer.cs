
using System.ComponentModel;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ArisenStudio.Forms.Tools.PS3
{
    partial class BootPluginsEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.GridBootPlugins = new DevExpress.XtraGrid.GridControl();
            this.GridViewBootPlugins = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ButtonRestoreDefault = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRestoreBackup = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSaveUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GridBootPlugins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBootPlugins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridBootPlugins
            // 
            this.GridBootPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridBootPlugins.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridBootPlugins.Location = new System.Drawing.Point(12, 12);
            this.GridBootPlugins.MainView = this.GridViewBootPlugins;
            this.GridBootPlugins.Name = "GridBootPlugins";
            this.GridBootPlugins.Size = new System.Drawing.Size(428, 291);
            this.GridBootPlugins.TabIndex = 6;
            this.GridBootPlugins.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewBootPlugins});
            // 
            // GridViewBootPlugins
            // 
            this.GridViewBootPlugins.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewBootPlugins.GridControl = this.GridBootPlugins;
            this.GridViewBootPlugins.Name = "GridViewBootPlugins";
            this.GridViewBootPlugins.OptionsCustomization.AllowFilter = false;
            this.GridViewBootPlugins.OptionsFilter.AllowFilterEditor = false;
            this.GridViewBootPlugins.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.GridViewBootPlugins.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewBootPlugins.OptionsView.ShowGroupPanel = false;
            this.GridViewBootPlugins.OptionsView.ShowIndicator = false;
            this.GridViewBootPlugins.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewIniFile_RowClick);
            this.GridViewBootPlugins.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewIniFile_FocusedRowChanged);
            // 
            // ButtonRestoreDefault
            // 
            this.ButtonRestoreDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRestoreDefault.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRestoreDefault.Appearance.Options.UseFont = true;
            this.ButtonRestoreDefault.AutoSize = true;
            this.ButtonRestoreDefault.Location = new System.Drawing.Point(0, 0);
            this.ButtonRestoreDefault.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonRestoreDefault.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonRestoreDefault.Name = "ButtonRestoreDefault";
            this.ButtonRestoreDefault.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonRestoreDefault.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRestoreDefault.Size = new System.Drawing.Size(107, 24);
            this.ButtonRestoreDefault.TabIndex = 9;
            this.ButtonRestoreDefault.Text = "Restore Default";
            this.ButtonRestoreDefault.Click += new System.EventHandler(this.ButtonRestoreDefault_Click);
            // 
            // ButtonRestoreBackup
            // 
            this.ButtonRestoreBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRestoreBackup.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRestoreBackup.Appearance.Options.UseFont = true;
            this.ButtonRestoreBackup.AutoSize = true;
            this.ButtonRestoreBackup.Location = new System.Drawing.Point(113, 0);
            this.ButtonRestoreBackup.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonRestoreBackup.Name = "ButtonRestoreBackup";
            this.ButtonRestoreBackup.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonRestoreBackup.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRestoreBackup.Size = new System.Drawing.Size(108, 24);
            this.ButtonRestoreBackup.TabIndex = 7;
            this.ButtonRestoreBackup.Text = "Restore Backup";
            this.ButtonRestoreBackup.Click += new System.EventHandler(this.ButtonRestoreBackup_Click);
            // 
            // ButtonSaveUpdate
            // 
            this.ButtonSaveUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSaveUpdate.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSaveUpdate.Appearance.Options.UseFont = true;
            this.ButtonSaveUpdate.AutoSize = true;
            this.ButtonSaveUpdate.Location = new System.Drawing.Point(227, 0);
            this.ButtonSaveUpdate.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonSaveUpdate.Name = "ButtonSaveUpdate";
            this.ButtonSaveUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonSaveUpdate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSaveUpdate.Size = new System.Drawing.Size(115, 24);
            this.ButtonSaveUpdate.TabIndex = 8;
            this.ButtonSaveUpdate.Text = "Save && Update";
            this.ButtonSaveUpdate.Click += new System.EventHandler(this.ButtonSaveUpdate_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonRestoreDefault);
            this.PanelButtons.Controls.Add(this.ButtonRestoreBackup);
            this.PanelButtons.Controls.Add(this.ButtonSaveUpdate);
            this.PanelButtons.Location = new System.Drawing.Point(12, 309);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(428, 24);
            this.PanelButtons.TabIndex = 1182;
            // 
            // BootPluginsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(452, 345);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.GridBootPlugins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BootPluginsEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Boot Plugins Editor";
            this.Load += new System.EventHandler(this.BootPluginsEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridBootPlugins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBootPlugins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GridControl GridBootPlugins;
        private GridView GridViewBootPlugins;
        private SimpleButton ButtonRestoreBackup;
        private SimpleButton ButtonSaveUpdate;
        private SimpleButton ButtonRestoreDefault;
        private StackPanel PanelButtons;
    }
}