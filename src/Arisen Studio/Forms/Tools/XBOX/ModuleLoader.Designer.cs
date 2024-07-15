
using System.ComponentModel;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ArisenStudio.Forms.Tools.XBOX
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
            this.ButtonRefreshModules = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonUnloadModule = new DevExpress.XtraEditors.SimpleButton();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.TextBoxModuleName = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxDrives = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ButtonInjectPlugin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridBootModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxModuleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDrives.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridBootModules
            // 
            this.GridBootModules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridBootModules.Location = new System.Drawing.Point(12, 41);
            this.GridBootModules.MainView = this.GridViewModules;
            this.GridBootModules.Name = "GridBootModules";
            this.GridBootModules.Size = new System.Drawing.Size(327, 275);
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
            // ButtonRefreshModules
            // 
            this.ButtonRefreshModules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRefreshModules.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRefreshModules.Appearance.Options.UseFont = true;
            this.ButtonRefreshModules.AutoSize = true;
            this.ButtonRefreshModules.Location = new System.Drawing.Point(115, 0);
            this.ButtonRefreshModules.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonRefreshModules.Name = "ButtonRefreshModules";
            this.ButtonRefreshModules.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonRefreshModules.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRefreshModules.Size = new System.Drawing.Size(115, 24);
            this.ButtonRefreshModules.TabIndex = 9;
            this.ButtonRefreshModules.Text = "Refresh Modules";
            this.ButtonRefreshModules.Click += new System.EventHandler(this.ButtonRefreshModules_Click);
            // 
            // ButtonUnloadModule
            // 
            this.ButtonUnloadModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonUnloadModule.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUnloadModule.Appearance.Options.UseFont = true;
            this.ButtonUnloadModule.AutoSize = true;
            this.ButtonUnloadModule.Enabled = false;
            this.ButtonUnloadModule.Location = new System.Drawing.Point(0, 0);
            this.ButtonUnloadModule.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonUnloadModule.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonUnloadModule.Name = "ButtonUnloadModule";
            this.ButtonUnloadModule.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonUnloadModule.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonUnloadModule.Size = new System.Drawing.Size(109, 24);
            this.ButtonUnloadModule.TabIndex = 8;
            this.ButtonUnloadModule.Text = "Unload Module";
            this.ButtonUnloadModule.Click += new System.EventHandler(this.ButtonUnloadModule_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonUnloadModule);
            this.PanelButtons.Controls.Add(this.ButtonRefreshModules);
            this.PanelButtons.Location = new System.Drawing.Point(12, 322);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(327, 24);
            this.PanelButtons.TabIndex = 1182;
            // 
            // TextBoxModuleName
            // 
            this.TextBoxModuleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxModuleName.Location = new System.Drawing.Point(78, 13);
            this.TextBoxModuleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxModuleName.Name = "TextBoxModuleName";
            this.TextBoxModuleName.Properties.AllowFocused = false;
            this.TextBoxModuleName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextBoxModuleName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxModuleName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxModuleName.Properties.NullValuePrompt = "ModuleName.xex";
            this.TextBoxModuleName.Size = new System.Drawing.Size(158, 24);
            this.TextBoxModuleName.TabIndex = 1183;
            // 
            // ComboBoxDrives
            // 
            this.ComboBoxDrives.EditValue = "HDD:\\";
            this.ComboBoxDrives.Location = new System.Drawing.Point(12, 13);
            this.ComboBoxDrives.Name = "ComboBoxDrives";
            this.ComboBoxDrives.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxDrives.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxDrives.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxDrives.Properties.Items.AddRange(new object[] {
            "HDD:\\",
            "USB0:\\",
            "USB1:\\",
            "USB2:\\",
            "USB3:\\",
            "USB4:\\"});
            this.ComboBoxDrives.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxDrives.Size = new System.Drawing.Size(60, 24);
            this.ComboBoxDrives.TabIndex = 1184;
            // 
            // ButtonInjectPlugin
            // 
            this.ButtonInjectPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInjectPlugin.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonInjectPlugin.Appearance.Options.UseFont = true;
            this.ButtonInjectPlugin.Location = new System.Drawing.Point(242, 12);
            this.ButtonInjectPlugin.Name = "ButtonInjectPlugin";
            this.ButtonInjectPlugin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInjectPlugin.Size = new System.Drawing.Size(97, 25);
            this.ButtonInjectPlugin.TabIndex = 1185;
            this.ButtonInjectPlugin.Text = "Inject Plugin";
            this.ButtonInjectPlugin.Click += new System.EventHandler(this.ButtonInjectPlugin_Click);
            // 
            // ModuleLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 358);
            this.Controls.Add(this.ButtonInjectPlugin);
            this.Controls.Add(this.ComboBoxDrives);
            this.Controls.Add(this.TextBoxModuleName);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.GridBootModules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModuleLoader";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modules Loader";
            this.Load += new System.EventHandler(this.ModuleLoader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridBootModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxModuleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDrives.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GridControl GridBootModules;
        private GridView GridViewModules;
        private SimpleButton ButtonUnloadModule;
        private SimpleButton ButtonRefreshModules;
        private StackPanel PanelButtons;
        private TextEdit TextBoxModuleName;
        private ComboBoxEdit ComboBoxDrives;
        private SimpleButton ButtonInjectPlugin;
    }
}