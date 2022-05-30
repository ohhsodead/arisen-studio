
using System.ComponentModel;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace NeoModsX.Forms.Tools.XBOX
{
    partial class ModuleLoader
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
            this.GridBootModules = new DevExpress.XtraGrid.GridControl();
            this.GridViewModules = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ButtonLoadModule = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonUnloadModule = new DevExpress.XtraEditors.SimpleButton();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GridBootModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridBootModules
            // 
            this.GridBootModules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridBootModules.Location = new System.Drawing.Point(12, 12);
            this.GridBootModules.MainView = this.GridViewModules;
            this.GridBootModules.Name = "GridBootModules";
            this.GridBootModules.Size = new System.Drawing.Size(428, 291);
            this.GridBootModules.TabIndex = 6;
            this.GridBootModules.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewModules});
            // 
            // GridViewModules
            // 
            this.GridViewModules.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewModules.GridControl = this.GridBootModules;
            this.GridViewModules.Name = "GridViewModules";
            this.GridViewModules.OptionsCustomization.AllowFilter = false;
            this.GridViewModules.OptionsFilter.AllowFilterEditor = false;
            this.GridViewModules.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.GridViewModules.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewModules.OptionsView.ShowGroupPanel = false;
            this.GridViewModules.OptionsView.ShowIndicator = false;
            this.GridViewModules.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewModules_RowClick);
            this.GridViewModules.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewModules_FocusedRowChanged);
            // 
            // ButtonLoadModule
            // 
            this.ButtonLoadModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonLoadModule.AutoSize = true;
            this.ButtonLoadModule.Location = new System.Drawing.Point(0, 0);
            this.ButtonLoadModule.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonLoadModule.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonLoadModule.Name = "ButtonLoadModule";
            this.ButtonLoadModule.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonLoadModule.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonLoadModule.Size = new System.Drawing.Size(99, 24);
            this.ButtonLoadModule.TabIndex = 9;
            this.ButtonLoadModule.Text = "Load Module";
            this.ButtonLoadModule.Click += new System.EventHandler(this.ButtonLoadModule_Click);
            // 
            // ButtonUnloadModule
            // 
            this.ButtonUnloadModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonUnloadModule.AutoSize = true;
            this.ButtonUnloadModule.Location = new System.Drawing.Point(105, 0);
            this.ButtonUnloadModule.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonUnloadModule.Name = "ButtonUnloadModule";
            this.ButtonUnloadModule.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonUnloadModule.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonUnloadModule.Size = new System.Drawing.Size(112, 24);
            this.ButtonUnloadModule.TabIndex = 8;
            this.ButtonUnloadModule.Text = "Unload Module";
            this.ButtonUnloadModule.Click += new System.EventHandler(this.ButtonUnloadModule_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonLoadModule);
            this.PanelButtons.Controls.Add(this.ButtonUnloadModule);
            this.PanelButtons.Location = new System.Drawing.Point(12, 309);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(428, 24);
            this.PanelButtons.TabIndex = 1182;
            // 
            // ModuleLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 345);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.GridBootModules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Image = global::NeoModsX.Properties.Resources.neomodsx;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModuleLoader";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Module Loader";
            this.Load += new System.EventHandler(this.ModuleLoader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridBootModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GridControl GridBootModules;
        private GridView GridViewModules;
        private SimpleButton ButtonUnloadModule;
        private SimpleButton ButtonLoadModule;
        private StackPanel PanelButtons;
    }
}