
using System.ComponentModel;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ArisenStudio.Forms.Tools.XBOX
{
    partial class DashlaunchEditor
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
            this.GridLaunchFile = new DevExpress.XtraGrid.GridControl();
            this.GridViewLaunchFile = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CheckBoxEnableLiveStrong = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxEnableLiveBlock = new DevExpress.XtraEditors.CheckEdit();
            this.ButtonRestoreDefault = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRestoreBackup = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSaveUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxKey = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxValue = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxSections = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonSetValue = new DevExpress.XtraEditors.SimpleButton();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GridLaunchFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLaunchFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxEnableLiveStrong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxEnableLiveBlock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSections.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridLaunchFile
            // 
            this.GridLaunchFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridLaunchFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridLaunchFile.Location = new System.Drawing.Point(12, 65);
            this.GridLaunchFile.MainView = this.GridViewLaunchFile;
            this.GridLaunchFile.Name = "GridLaunchFile";
            this.GridLaunchFile.Size = new System.Drawing.Size(428, 238);
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
            // CheckBoxEnableLiveStrong
            // 
            this.CheckBoxEnableLiveStrong.Location = new System.Drawing.Point(125, 40);
            this.CheckBoxEnableLiveStrong.Name = "CheckBoxEnableLiveStrong";
            this.CheckBoxEnableLiveStrong.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxEnableLiveStrong.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxEnableLiveStrong.Properties.AutoWidth = true;
            this.CheckBoxEnableLiveStrong.Properties.Caption = "Enable Live Strong";
            this.CheckBoxEnableLiveStrong.Size = new System.Drawing.Size(119, 19);
            this.CheckBoxEnableLiveStrong.TabIndex = 5;
            this.CheckBoxEnableLiveStrong.CheckedChanged += new System.EventHandler(this.CheckBoxEnableLiveStrong_CheckedChanged);
            // 
            // CheckBoxEnableLiveBlock
            // 
            this.CheckBoxEnableLiveBlock.Location = new System.Drawing.Point(11, 40);
            this.CheckBoxEnableLiveBlock.Name = "CheckBoxEnableLiveBlock";
            this.CheckBoxEnableLiveBlock.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxEnableLiveBlock.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxEnableLiveBlock.Properties.AutoWidth = true;
            this.CheckBoxEnableLiveBlock.Properties.Caption = "Enable Live Block";
            this.CheckBoxEnableLiveBlock.Size = new System.Drawing.Size(113, 19);
            this.CheckBoxEnableLiveBlock.TabIndex = 4;
            this.CheckBoxEnableLiveBlock.ToolTip = "if set to true, this will block the console from resolving LIVE related dns\r\nif n" +
    "ot set this value will be TRUE";
            this.CheckBoxEnableLiveBlock.CheckedChanged += new System.EventHandler(this.CheckBoxEnableLiveBlock_CheckedChanged);
            // 
            // ButtonRestoreDefault
            // 
            this.ButtonRestoreDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRestoreDefault.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRestoreDefault.Appearance.Options.UseFont = true;
            this.ButtonRestoreDefault.AutoSize = true;
            this.ButtonRestoreDefault.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonRestoreDefault.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonRestoreDefault.ImageOptions.ImageToTextIndent = 6;
            this.ButtonRestoreDefault.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonRestoreDefault.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.restore_file;
            this.ButtonRestoreDefault.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.ButtonRestoreDefault.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonRestoreDefault.Location = new System.Drawing.Point(0, 0);
            this.ButtonRestoreDefault.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonRestoreDefault.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonRestoreDefault.Name = "ButtonRestoreDefault";
            this.ButtonRestoreDefault.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ButtonRestoreDefault.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRestoreDefault.Size = new System.Drawing.Size(121, 24);
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
            this.ButtonRestoreBackup.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonRestoreBackup.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonRestoreBackup.ImageOptions.ImageToTextIndent = 6;
            this.ButtonRestoreBackup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonRestoreBackup.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.restore_backup;
            this.ButtonRestoreBackup.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonRestoreBackup.Location = new System.Drawing.Point(127, 0);
            this.ButtonRestoreBackup.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonRestoreBackup.Name = "ButtonRestoreBackup";
            this.ButtonRestoreBackup.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ButtonRestoreBackup.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRestoreBackup.Size = new System.Drawing.Size(122, 24);
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
            this.ButtonSaveUpdate.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonSaveUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonSaveUpdate.ImageOptions.ImageToTextIndent = 4;
            this.ButtonSaveUpdate.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonSaveUpdate.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.save_update;
            this.ButtonSaveUpdate.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonSaveUpdate.Location = new System.Drawing.Point(255, 0);
            this.ButtonSaveUpdate.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonSaveUpdate.Name = "ButtonSaveUpdate";
            this.ButtonSaveUpdate.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ButtonSaveUpdate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSaveUpdate.Size = new System.Drawing.Size(131, 24);
            this.ButtonSaveUpdate.TabIndex = 8;
            this.ButtonSaveUpdate.Text = "Save && Update";
            this.ButtonSaveUpdate.Click += new System.EventHandler(this.ButtonSaveUpdate_Click);
            // 
            // TextBoxKey
            // 
            this.TextBoxKey.EditValue = "";
            this.TextBoxKey.Location = new System.Drawing.Point(90, 12);
            this.TextBoxKey.Name = "TextBoxKey";
            this.TextBoxKey.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxKey.Properties.Appearance.Options.UseFont = true;
            this.TextBoxKey.Size = new System.Drawing.Size(84, 22);
            this.TextBoxKey.TabIndex = 1;
            // 
            // TextBoxValue
            // 
            this.TextBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxValue.Location = new System.Drawing.Point(197, 12);
            this.TextBoxValue.Name = "TextBoxValue";
            this.TextBoxValue.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxValue.Properties.Appearance.Options.UseFont = true;
            this.TextBoxValue.Size = new System.Drawing.Size(159, 22);
            this.TextBoxValue.TabIndex = 2;
            // 
            // ComboBoxSections
            // 
            this.ComboBoxSections.EditValue = "Paths";
            this.ComboBoxSections.Location = new System.Drawing.Point(12, 12);
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
            this.ComboBoxSections.Size = new System.Drawing.Size(72, 22);
            this.ComboBoxSections.TabIndex = 0;
            this.ComboBoxSections.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSections_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(182, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(9, 17);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "=";
            // 
            // ButtonSetValue
            // 
            this.ButtonSetValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSetValue.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSetValue.Appearance.Options.UseFont = true;
            this.ButtonSetValue.Location = new System.Drawing.Point(362, 12);
            this.ButtonSetValue.Name = "ButtonSetValue";
            this.ButtonSetValue.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSetValue.Size = new System.Drawing.Size(78, 23);
            this.ButtonSetValue.TabIndex = 3;
            this.ButtonSetValue.Text = "Set Value";
            this.ButtonSetValue.Click += new System.EventHandler(this.ButtonSetValue_Click);
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
            // DashlaunchEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 345);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.CheckBoxEnableLiveStrong);
            this.Controls.Add(this.CheckBoxEnableLiveBlock);
            this.Controls.Add(this.TextBoxKey);
            this.Controls.Add(this.ComboBoxSections);
            this.Controls.Add(this.TextBoxValue);
            this.Controls.Add(this.ButtonSetValue);
            this.Controls.Add(this.GridLaunchFile);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashlaunchEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashlaunch Editor";
            this.Load += new System.EventHandler(this.DashlaunchEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLaunchFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLaunchFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxEnableLiveStrong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxEnableLiveBlock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSections.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GridControl GridLaunchFile;
        private GridView GridViewLaunchFile;
        private TextEdit TextBoxKey;
        private TextEdit TextBoxValue;
        private ComboBoxEdit ComboBoxSections;
        private LabelControl labelControl1;
        private SimpleButton ButtonSetValue;
        private SimpleButton ButtonRestoreBackup;
        private SimpleButton ButtonSaveUpdate;
        private CheckEdit CheckBoxEnableLiveStrong;
        private CheckEdit CheckBoxEnableLiveBlock;
        private SimpleButton ButtonRestoreDefault;
        private StackPanel PanelButtons;
    }
}