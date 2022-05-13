
using System.ComponentModel;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Modio.Forms.Tools.XBOX
{
    partial class PluginsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginsEditor));
            this.GridLaunchFile = new DevExpress.XtraGrid.GridControl();
            this.GridViewLaunchFile = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GroupIniFileEditor = new DevExpress.XtraEditors.GroupControl();
            this.CheckBoxEnableLiveStrong = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxEnableLiveBlock = new DevExpress.XtraEditors.CheckEdit();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonRestoreDefault = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRestoreBackup = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxKey = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxValue = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxSections = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonSetValue = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridLaunchFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLaunchFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupIniFileEditor)).BeginInit();
            this.GroupIniFileEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxEnableLiveStrong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxEnableLiveBlock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSections.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridLaunchFile
            // 
            this.GridLaunchFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridLaunchFile.Location = new System.Drawing.Point(10, 84);
            this.GridLaunchFile.MainView = this.GridViewLaunchFile;
            this.GridLaunchFile.Name = "GridLaunchFile";
            this.GridLaunchFile.Size = new System.Drawing.Size(408, 193);
            this.GridLaunchFile.TabIndex = 6;
            this.GridLaunchFile.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewLaunchFile});
            // 
            // GridViewLaunchFile
            // 
            this.GridViewLaunchFile.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewLaunchFile.GridControl = this.GridLaunchFile;
            this.GridViewLaunchFile.Name = "GridViewLaunchFile";
            this.GridViewLaunchFile.OptionsBehavior.Editable = false;
            this.GridViewLaunchFile.OptionsBehavior.ReadOnly = true;
            this.GridViewLaunchFile.OptionsCustomization.AllowFilter = false;
            this.GridViewLaunchFile.OptionsFilter.AllowFilterEditor = false;
            this.GridViewLaunchFile.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.GridViewLaunchFile.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewLaunchFile.OptionsView.ShowGroupPanel = false;
            this.GridViewLaunchFile.OptionsView.ShowIndicator = false;
            this.GridViewLaunchFile.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewIniFile_RowClick);
            this.GridViewLaunchFile.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewIniFile_FocusedRowChanged);
            // 
            // GroupIniFileEditor
            // 
            this.GroupIniFileEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupIniFileEditor.Controls.Add(this.CheckBoxEnableLiveStrong);
            this.GroupIniFileEditor.Controls.Add(this.CheckBoxEnableLiveBlock);
            this.GroupIniFileEditor.Controls.Add(this.PanelButtons);
            this.GroupIniFileEditor.Controls.Add(this.TextBoxKey);
            this.GroupIniFileEditor.Controls.Add(this.TextBoxValue);
            this.GroupIniFileEditor.Controls.Add(this.GridLaunchFile);
            this.GroupIniFileEditor.Controls.Add(this.ComboBoxSections);
            this.GroupIniFileEditor.Controls.Add(this.labelControl1);
            this.GroupIniFileEditor.Controls.Add(this.ButtonSetValue);
            this.GroupIniFileEditor.Location = new System.Drawing.Point(12, 12);
            this.GroupIniFileEditor.Name = "GroupIniFileEditor";
            this.GroupIniFileEditor.Size = new System.Drawing.Size(428, 321);
            this.GroupIniFileEditor.TabIndex = 15;
            this.GroupIniFileEditor.Text = "Edit File Values";
            // 
            // CheckBoxEnableLiveStrong
            // 
            this.CheckBoxEnableLiveStrong.Location = new System.Drawing.Point(124, 61);
            this.CheckBoxEnableLiveStrong.Name = "CheckBoxEnableLiveStrong";
            this.CheckBoxEnableLiveStrong.Properties.AutoWidth = true;
            this.CheckBoxEnableLiveStrong.Properties.Caption = "Enable Live Strong";
            this.CheckBoxEnableLiveStrong.Size = new System.Drawing.Size(117, 19);
            this.CheckBoxEnableLiveStrong.TabIndex = 5;
            this.CheckBoxEnableLiveStrong.CheckedChanged += new System.EventHandler(this.CheckBoxEnableLiveStrong_CheckedChanged);
            // 
            // CheckBoxEnableLiveBlock
            // 
            this.CheckBoxEnableLiveBlock.Location = new System.Drawing.Point(10, 61);
            this.CheckBoxEnableLiveBlock.Name = "CheckBoxEnableLiveBlock";
            this.CheckBoxEnableLiveBlock.Properties.AutoWidth = true;
            this.CheckBoxEnableLiveBlock.Properties.Caption = "Enable Live Block";
            this.CheckBoxEnableLiveBlock.Size = new System.Drawing.Size(109, 19);
            this.CheckBoxEnableLiveBlock.TabIndex = 4;
            this.CheckBoxEnableLiveBlock.ToolTip = "if set to true, this will block the console from resolving LIVE related dns\r\nif n" +
    "ot set this value will be TRUE";
            this.CheckBoxEnableLiveBlock.CheckedChanged += new System.EventHandler(this.CheckBoxEnableLiveBlock_CheckedChanged);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonRestoreDefault);
            this.PanelButtons.Controls.Add(this.ButtonRestoreBackup);
            this.PanelButtons.Controls.Add(this.ButtonSave);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(0, 282);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(428, 39);
            this.PanelButtons.TabIndex = 1181;
            // 
            // ButtonRestoreDefault
            // 
            this.ButtonRestoreDefault.Location = new System.Drawing.Point(8, 8);
            this.ButtonRestoreDefault.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonRestoreDefault.Name = "ButtonRestoreDefault";
            this.ButtonRestoreDefault.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRestoreDefault.Size = new System.Drawing.Size(116, 23);
            this.ButtonRestoreDefault.TabIndex = 9;
            this.ButtonRestoreDefault.Text = "Restore Default";
            this.ButtonRestoreDefault.Click += new System.EventHandler(this.ButtonRestoreDefault_Click);
            // 
            // ButtonRestoreBackup
            // 
            this.ButtonRestoreBackup.Location = new System.Drawing.Point(130, 8);
            this.ButtonRestoreBackup.Name = "ButtonRestoreBackup";
            this.ButtonRestoreBackup.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRestoreBackup.Size = new System.Drawing.Size(114, 23);
            this.ButtonRestoreBackup.TabIndex = 7;
            this.ButtonRestoreBackup.Text = "Restore Backup";
            this.ButtonRestoreBackup.Click += new System.EventHandler(this.ButtonRestoreBackup_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(250, 8);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSave.Size = new System.Drawing.Size(77, 23);
            this.ButtonSave.TabIndex = 8;
            this.ButtonSave.Text = "Save File";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxKey
            // 
            this.TextBoxKey.EditValue = "";
            this.TextBoxKey.Location = new System.Drawing.Point(84, 33);
            this.TextBoxKey.Name = "TextBoxKey";
            this.TextBoxKey.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxKey.Properties.Appearance.Options.UseFont = true;
            this.TextBoxKey.Size = new System.Drawing.Size(80, 22);
            this.TextBoxKey.TabIndex = 1;
            // 
            // TextBoxValue
            // 
            this.TextBoxValue.Location = new System.Drawing.Point(189, 33);
            this.TextBoxValue.Name = "TextBoxValue";
            this.TextBoxValue.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxValue.Properties.Appearance.Options.UseFont = true;
            this.TextBoxValue.Size = new System.Drawing.Size(145, 22);
            this.TextBoxValue.TabIndex = 2;
            // 
            // ComboBoxSections
            // 
            this.ComboBoxSections.EditValue = "Paths";
            this.ComboBoxSections.Location = new System.Drawing.Point(10, 33);
            this.ComboBoxSections.Name = "ComboBoxSections";
            this.ComboBoxSections.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxSections.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxSections.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxSections.Properties.Items.AddRange(new object[] {
            "Paths",
            "Plugins",
            "Externals",
            "Settings"});
            this.ComboBoxSections.Size = new System.Drawing.Size(68, 22);
            this.ComboBoxSections.TabIndex = 0;
            this.ComboBoxSections.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSections_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(172, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(9, 17);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "=";
            // 
            // ButtonSetValue
            // 
            this.ButtonSetValue.Location = new System.Drawing.Point(340, 33);
            this.ButtonSetValue.Name = "ButtonSetValue";
            this.ButtonSetValue.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSetValue.Size = new System.Drawing.Size(78, 23);
            this.ButtonSetValue.TabIndex = 3;
            this.ButtonSetValue.Text = "Set Value";
            this.ButtonSetValue.Click += new System.EventHandler(this.ButtonSetValue_Click);
            // 
            // PluginsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 345);
            this.Controls.Add(this.GroupIniFileEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("PluginsEditor.IconOptions.Icon")));
            this.IconOptions.Image = global::Modio.Properties.Resources.icon;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PluginsEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plugins Editor";
            this.Load += new System.EventHandler(this.PluginsEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLaunchFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLaunchFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupIniFileEditor)).EndInit();
            this.GroupIniFileEditor.ResumeLayout(false);
            this.GroupIniFileEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxEnableLiveStrong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxEnableLiveBlock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSections.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GridControl GridLaunchFile;
        private GridView GridViewLaunchFile;
        private GroupControl GroupIniFileEditor;
        private TextEdit TextBoxKey;
        private TextEdit TextBoxValue;
        private ComboBoxEdit ComboBoxSections;
        private LabelControl labelControl1;
        private SimpleButton ButtonSetValue;
        private StackPanel PanelButtons;
        private SimpleButton ButtonRestoreBackup;
        private SimpleButton ButtonSave;
        private CheckEdit CheckBoxEnableLiveStrong;
        private CheckEdit CheckBoxEnableLiveBlock;
        private SimpleButton ButtonRestoreDefault;
    }
}