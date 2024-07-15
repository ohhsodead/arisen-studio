using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Dialogs
{
    partial class NewCustomDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCustomDialog));
            this.LabelLogin = new DevExpress.XtraEditors.LabelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.LabelCategoryType = new DevExpress.XtraEditors.LabelControl();
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonChangeLoginDetails = new DevExpress.XtraEditors.SimpleButton();
            this.LabelPlatform = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxPlatform = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TextBoxName = new DevExpress.XtraEditors.TextEdit();
            this.CheckBoxUseDefaultConsole = new DevExpress.XtraEditors.CheckEdit();
            this.LabelDefault = new DevExpress.XtraEditors.LabelControl();
            this.CheckBoxDefault = new DevExpress.XtraEditors.CheckEdit();
            this.ComboBoxCategoryType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ComboBoxCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxModType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.GridViewFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridControlFiles = new DevExpress.XtraGrid.GridControl();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonInstallFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDownloadFile = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxVersion = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPlatform.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxUseDefaultConsole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxDefault.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCategoryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxModType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxVersion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLogin
            // 
            this.LabelLogin.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLogin.Appearance.Options.UseFont = true;
            this.LabelLogin.Location = new System.Drawing.Point(12, 116);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(33, 15);
            this.LabelLogin.TabIndex = 1141;
            this.LabelLogin.Text = "Login:";
            // 
            // LabelName
            // 
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.Location = new System.Drawing.Point(258, 12);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(32, 15);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Name";
            // 
            // LabelCategoryType
            // 
            this.LabelCategoryType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCategoryType.Appearance.Options.UseFont = true;
            this.LabelCategoryType.Location = new System.Drawing.Point(121, 12);
            this.LabelCategoryType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelCategoryType.Name = "LabelCategoryType";
            this.LabelCategoryType.Size = new System.Drawing.Size(76, 15);
            this.LabelCategoryType.TabIndex = 14;
            this.LabelCategoryType.Text = "Category Type";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Location = new System.Drawing.Point(324, 415);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOK.Size = new System.Drawing.Size(80, 24);
            this.ButtonOK.TabIndex = 10;
            this.ButtonOK.Text = "Save";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(410, 415);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(80, 24);
            this.ButtonCancel.TabIndex = 11;
            this.ButtonCancel.Text = "Cancel";
            // 
            // ButtonChangeLoginDetails
            // 
            this.ButtonChangeLoginDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonChangeLoginDetails.Location = new System.Drawing.Point(410, 116);
            this.ButtonChangeLoginDetails.Name = "ButtonChangeLoginDetails";
            this.ButtonChangeLoginDetails.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonChangeLoginDetails.Size = new System.Drawing.Size(80, 24);
            this.ButtonChangeLoginDetails.TabIndex = 4;
            this.ButtonChangeLoginDetails.Text = "Change";
            // 
            // LabelPlatform
            // 
            this.LabelPlatform.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelPlatform.Appearance.Options.UseFont = true;
            this.LabelPlatform.Location = new System.Drawing.Point(12, 12);
            this.LabelPlatform.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelPlatform.Name = "LabelPlatform";
            this.LabelPlatform.Size = new System.Drawing.Size(46, 15);
            this.LabelPlatform.TabIndex = 1146;
            this.LabelPlatform.Text = "Platform";
            // 
            // ComboBoxPlatform
            // 
            this.ComboBoxPlatform.EditValue = "PlayStation 3";
            this.ComboBoxPlatform.Location = new System.Drawing.Point(12, 32);
            this.ComboBoxPlatform.Name = "ComboBoxPlatform";
            this.ComboBoxPlatform.Properties.AllowFocused = false;
            this.ComboBoxPlatform.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxPlatform.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPlatform.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPlatform.Properties.DropDownRows = 9;
            this.ComboBoxPlatform.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.ComboBoxPlatform.Properties.Items.AddRange(new object[] {
            "PlayStation 3",
            "PlayStation 4",
            "Xbox 360"});
            this.ComboBoxPlatform.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxPlatform.Size = new System.Drawing.Size(103, 24);
            this.ComboBoxPlatform.TabIndex = 1;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(258, 32);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxName.Size = new System.Drawing.Size(232, 24);
            this.TextBoxName.TabIndex = 4;
            // 
            // CheckBoxUseDefaultConsole
            // 
            this.CheckBoxUseDefaultConsole.Location = new System.Drawing.Point(264, 118);
            this.CheckBoxUseDefaultConsole.Name = "CheckBoxUseDefaultConsole";
            this.CheckBoxUseDefaultConsole.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxUseDefaultConsole.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxUseDefaultConsole.Properties.AutoWidth = true;
            this.CheckBoxUseDefaultConsole.Properties.Caption = "";
            this.CheckBoxUseDefaultConsole.Size = new System.Drawing.Size(20, 20);
            this.CheckBoxUseDefaultConsole.TabIndex = 3;
            this.CheckBoxUseDefaultConsole.Visible = false;
            // 
            // LabelDefault
            // 
            this.LabelDefault.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDefault.Appearance.Options.UseFont = true;
            this.LabelDefault.Location = new System.Drawing.Point(12, 148);
            this.LabelDefault.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelDefault.Name = "LabelDefault";
            this.LabelDefault.Size = new System.Drawing.Size(41, 15);
            this.LabelDefault.TabIndex = 1149;
            this.LabelDefault.Text = "Default:";
            // 
            // CheckBoxDefault
            // 
            this.CheckBoxDefault.Location = new System.Drawing.Point(264, 150);
            this.CheckBoxDefault.Name = "CheckBoxDefault";
            this.CheckBoxDefault.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxDefault.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxDefault.Properties.AutoWidth = true;
            this.CheckBoxDefault.Properties.Caption = "";
            this.CheckBoxDefault.Size = new System.Drawing.Size(20, 20);
            this.CheckBoxDefault.TabIndex = 1147;
            // 
            // ComboBoxCategoryType
            // 
            this.ComboBoxCategoryType.EditValue = "Game";
            this.ComboBoxCategoryType.Location = new System.Drawing.Point(121, 32);
            this.ComboBoxCategoryType.Name = "ComboBoxCategoryType";
            this.ComboBoxCategoryType.Properties.AllowFocused = false;
            this.ComboBoxCategoryType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxCategoryType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxCategoryType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxCategoryType.Properties.DropDownRows = 9;
            this.ComboBoxCategoryType.Properties.Items.AddRange(new object[] {
            "Game",
            "Homebrew",
            "Package",
            "Resource",
            "Application",
            "Plugin"});
            this.ComboBoxCategoryType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxCategoryType.Size = new System.Drawing.Size(131, 24);
            this.ComboBoxCategoryType.TabIndex = 2;
            this.ComboBoxCategoryType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategoryType_SelectedIndexChanged);
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxCategory.EditValue = "";
            this.ComboBoxCategory.Location = new System.Drawing.Point(12, 82);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Properties.AllowFocused = false;
            this.ComboBoxCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxCategory.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxCategory.Properties.DropDownRows = 9;
            this.ComboBoxCategory.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.ComboBoxCategory.Properties.Items.AddRange(new object[] {
            "Mod",
            "Homebrew",
            "Resource",
            "Application",
            "Game"});
            this.ComboBoxCategory.Size = new System.Drawing.Size(240, 24);
            this.ComboBoxCategory.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 62);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 15);
            this.labelControl1.TabIndex = 1151;
            this.labelControl1.Text = "Category Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(258, 62);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 15);
            this.labelControl2.TabIndex = 1154;
            this.labelControl2.Text = "Version";
            // 
            // ComboBoxModType
            // 
            this.ComboBoxModType.EditValue = "";
            this.ComboBoxModType.Location = new System.Drawing.Point(354, 82);
            this.ComboBoxModType.Name = "ComboBoxModType";
            this.ComboBoxModType.Properties.AllowFocused = false;
            this.ComboBoxModType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxModType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxModType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxModType.Properties.DropDownRows = 9;
            this.ComboBoxModType.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.ComboBoxModType.Properties.Items.AddRange(new object[] {
            "EBOOT",
            "SPRX",
            "CFG",
            "OTHER"});
            this.ComboBoxModType.Size = new System.Drawing.Size(136, 24);
            this.ComboBoxModType.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(354, 62);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 15);
            this.labelControl3.TabIndex = 1156;
            this.labelControl3.Text = "Mod Type";
            // 
            // GridViewFiles
            // 
            this.GridViewFiles.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridViewFiles.Appearance.Row.Options.UseFont = true;
            this.GridViewFiles.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewFiles.GridControl = this.GridControlFiles;
            this.GridViewFiles.Name = "GridViewFiles";
            this.GridViewFiles.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.GridViewFiles.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.GridViewFiles.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.GridViewFiles.OptionsCustomization.AllowColumnResizing = false;
            this.GridViewFiles.OptionsCustomization.AllowFilter = false;
            this.GridViewFiles.OptionsFilter.AllowFilterEditor = false;
            this.GridViewFiles.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.GridViewFiles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewFiles.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.GridViewFiles.OptionsView.ShowGroupPanel = false;
            this.GridViewFiles.OptionsView.ShowIndicator = false;
            // 
            // GridControlFiles
            // 
            this.GridControlFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControlFiles.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridControlFiles.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.GridControlFiles.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridControlFiles.Location = new System.Drawing.Point(12, 180);
            this.GridControlFiles.MainView = this.GridViewFiles;
            this.GridControlFiles.Name = "GridControlFiles";
            this.GridControlFiles.Size = new System.Drawing.Size(478, 194);
            this.GridControlFiles.TabIndex = 7;
            this.GridControlFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewFiles});
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonInstallFile);
            this.PanelButtons.Controls.Add(this.ButtonDownloadFile);
            this.PanelButtons.Location = new System.Drawing.Point(12, 380);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(478, 24);
            this.PanelButtons.TabIndex = 1185;
            // 
            // ButtonInstallFile
            // 
            this.ButtonInstallFile.AutoSize = true;
            this.ButtonInstallFile.Enabled = false;
            this.ButtonInstallFile.Location = new System.Drawing.Point(0, 0);
            this.ButtonInstallFile.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonInstallFile.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonInstallFile.Name = "ButtonInstallFile";
            this.ButtonInstallFile.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonInstallFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonInstallFile.Size = new System.Drawing.Size(95, 24);
            this.ButtonInstallFile.TabIndex = 8;
            this.ButtonInstallFile.Text = "Choose File";
            // 
            // ButtonDownloadFile
            // 
            this.ButtonDownloadFile.AutoSize = true;
            this.ButtonDownloadFile.Enabled = false;
            this.ButtonDownloadFile.Location = new System.Drawing.Point(101, 0);
            this.ButtonDownloadFile.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDownloadFile.Name = "ButtonDownloadFile";
            this.ButtonDownloadFile.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonDownloadFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDownloadFile.Size = new System.Drawing.Size(89, 24);
            this.ButtonDownloadFile.TabIndex = 9;
            this.ButtonDownloadFile.Text = "Delete File";
            // 
            // TextBoxVersion
            // 
            this.TextBoxVersion.Location = new System.Drawing.Point(258, 82);
            this.TextBoxVersion.Name = "TextBoxVersion";
            this.TextBoxVersion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxVersion.Properties.Appearance.Options.UseFont = true;
            this.TextBoxVersion.Size = new System.Drawing.Size(90, 24);
            this.TextBoxVersion.TabIndex = 5;
            // 
            // NewCustomDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(502, 451);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.GridControlFiles);
            this.Controls.Add(this.ComboBoxModType);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TextBoxVersion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ComboBoxCategoryType);
            this.Controls.Add(this.LabelDefault);
            this.Controls.Add(this.CheckBoxDefault);
            this.Controls.Add(this.ComboBoxPlatform);
            this.Controls.Add(this.LabelPlatform);
            this.Controls.Add(this.ButtonChangeLoginDetails);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelCategoryType);
            this.Controls.Add(this.CheckBoxUseDefaultConsole);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("NewCustomDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCustomDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Mod Details";
            this.Load += new System.EventHandler(this.NewCustomDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPlatform.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxUseDefaultConsole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxDefault.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCategoryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxModType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxVersion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelName;
        private LabelControl LabelCategoryType;
        private LabelControl LabelLogin;
        private TextEdit TextBoxName;
        private SimpleButton ButtonOK;
        private SimpleButton ButtonCancel;
        private SimpleButton ButtonChangeLoginDetails;
        private LabelControl LabelPlatform;
        private ComboBoxEdit ComboBoxPlatform;
        private CheckEdit CheckBoxUseDefaultConsole;
        private LabelControl LabelDefault;
        private CheckEdit CheckBoxDefault;
        private ComboBoxEdit ComboBoxCategoryType;
        private ComboBoxEdit ComboBoxCategory;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private ComboBoxEdit ComboBoxModType;
        private LabelControl labelControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewFiles;
        private DevExpress.XtraGrid.GridControl GridControlFiles;
        private DevExpress.Utils.Layout.StackPanel PanelButtons;
        private SimpleButton ButtonInstallFile;
        private SimpleButton ButtonDownloadFile;
        private TextEdit TextBoxVersion;
    }
}