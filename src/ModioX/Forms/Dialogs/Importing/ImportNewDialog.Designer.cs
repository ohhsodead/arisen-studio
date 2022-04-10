using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs.Importing
{
    partial class ImportNewDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportNewDialog));
            this.LabelVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelCreator = new DevExpress.XtraEditors.LabelControl();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelModName = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxModName = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxCreators = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxVersion = new DevExpress.XtraEditors.TextEdit();
            this.ButtonImport = new DevExpress.XtraEditors.SimpleButton();
            this.LabelSystemType = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxDescription = new DevExpress.XtraEditors.MemoEdit();
            this.ComboBoxPlatform = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelConsole = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.SectionInstallFiles = new DevExpress.XtraEditors.GroupControl();
            this.GridFiles = new DevExpress.XtraGrid.GridControl();
            this.GridViewFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonAddFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBoxSystemType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelRegion = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxModType = new DevExpress.XtraEditors.TextEdit();
            this.LabelModType = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxRegion = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxModName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCreators.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPlatform.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionInstallFiles)).BeginInit();
            this.SectionInstallFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSystemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxModType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxRegion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelVersion
            // 
            this.LabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersion.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelVersion.Appearance.Options.UseFont = true;
            this.LabelVersion.Appearance.Options.UseForeColor = true;
            this.LabelVersion.Location = new System.Drawing.Point(541, 60);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(42, 15);
            this.LabelVersion.TabIndex = 7;
            this.LabelVersion.Text = "Version:";
            // 
            // LabelCreator
            // 
            this.LabelCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCreator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCreator.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelCreator.Appearance.Options.UseFont = true;
            this.LabelCreator.Appearance.Options.UseForeColor = true;
            this.LabelCreator.Location = new System.Drawing.Point(296, 60);
            this.LabelCreator.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelCreator.Name = "LabelCreator";
            this.LabelCreator.Size = new System.Drawing.Size(42, 15);
            this.LabelCreator.TabIndex = 9;
            this.LabelCreator.Text = "Creator:";
            // 
            // LabelCategory
            // 
            this.LabelCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCategory.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelCategory.Appearance.Options.UseFont = true;
            this.LabelCategory.Appearance.Options.UseForeColor = true;
            this.LabelCategory.Location = new System.Drawing.Point(12, 60);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(51, 15);
            this.LabelCategory.TabIndex = 12;
            this.LabelCategory.Text = "Category:";
            // 
            // LabelModName
            // 
            this.LabelModName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelModName.Appearance.Options.UseFont = true;
            this.LabelModName.Appearance.Options.UseForeColor = true;
            this.LabelModName.Location = new System.Drawing.Point(12, 12);
            this.LabelModName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelModName.Name = "LabelModName";
            this.LabelModName.Size = new System.Drawing.Size(35, 15);
            this.LabelModName.TabIndex = 14;
            this.LabelModName.Text = "Name:";
            // 
            // TextBoxModName
            // 
            this.TextBoxModName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxModName.Location = new System.Drawing.Point(12, 32);
            this.TextBoxModName.Name = "TextBoxModName";
            this.TextBoxModName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxModName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxModName.Size = new System.Drawing.Size(278, 22);
            this.TextBoxModName.TabIndex = 0;
            // 
            // TextBoxCreators
            // 
            this.TextBoxCreators.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCreators.Location = new System.Drawing.Point(296, 80);
            this.TextBoxCreators.Name = "TextBoxCreators";
            this.TextBoxCreators.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCreators.Properties.Appearance.Options.UseFont = true;
            this.TextBoxCreators.Size = new System.Drawing.Size(136, 22);
            this.TextBoxCreators.TabIndex = 3;
            // 
            // TextBoxVersion
            // 
            this.TextBoxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxVersion.Location = new System.Drawing.Point(541, 80);
            this.TextBoxVersion.Name = "TextBoxVersion";
            this.TextBoxVersion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxVersion.Properties.Appearance.Options.UseFont = true;
            this.TextBoxVersion.Size = new System.Drawing.Size(54, 22);
            this.TextBoxVersion.TabIndex = 4;
            // 
            // ButtonImport
            // 
            this.ButtonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonImport.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonImport.Appearance.Options.UseFont = true;
            this.ButtonImport.Location = new System.Drawing.Point(523, 491);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonImport.Size = new System.Drawing.Size(72, 25);
            this.ButtonImport.TabIndex = 7;
            this.ButtonImport.Text = "Import";
            this.ButtonImport.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // LabelSystemType
            // 
            this.LabelSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSystemType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSystemType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelSystemType.Appearance.Options.UseFont = true;
            this.LabelSystemType.Appearance.Options.UseForeColor = true;
            this.LabelSystemType.Location = new System.Drawing.Point(396, 12);
            this.LabelSystemType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSystemType.Name = "LabelSystemType";
            this.LabelSystemType.Size = new System.Drawing.Size(69, 15);
            this.LabelSystemType.TabIndex = 18;
            this.LabelSystemType.Text = "System Type:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 108);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 15);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Description:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescription.EditValue = "";
            this.TextBoxDescription.Location = new System.Drawing.Point(12, 128);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Properties.Appearance.Options.UseFont = true;
            this.TextBoxDescription.Size = new System.Drawing.Size(583, 113);
            this.TextBoxDescription.TabIndex = 5;
            // 
            // ComboBoxPlatform
            // 
            this.ComboBoxPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPlatform.EditValue = "PlayStation 3";
            this.ComboBoxPlatform.Location = new System.Drawing.Point(296, 32);
            this.ComboBoxPlatform.Name = "ComboBoxPlatform";
            this.ComboBoxPlatform.Properties.AllowFocused = false;
            this.ComboBoxPlatform.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPlatform.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPlatform.Properties.AutoComplete = false;
            this.ComboBoxPlatform.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPlatform.Properties.Items.AddRange(new object[] {
            "PlayStation 3",
            "Xbox 360"});
            this.ComboBoxPlatform.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxPlatform.Size = new System.Drawing.Size(94, 22);
            this.ComboBoxPlatform.TabIndex = 21;
            this.ComboBoxPlatform.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPlatform_SelectedIndexChanged);
            // 
            // LabelConsole
            // 
            this.LabelConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelConsole.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConsole.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelConsole.Appearance.Options.UseFont = true;
            this.LabelConsole.Appearance.Options.UseForeColor = true;
            this.LabelConsole.Location = new System.Drawing.Point(296, 12);
            this.LabelConsole.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelConsole.Name = "LabelConsole";
            this.LabelConsole.Size = new System.Drawing.Size(49, 15);
            this.LabelConsole.TabIndex = 22;
            this.LabelConsole.Text = "Platform:";
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxCategory.Location = new System.Drawing.Point(12, 80);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCategory.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxCategory.Size = new System.Drawing.Size(278, 22);
            this.ComboBoxCategory.TabIndex = 2;
            this.ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // SectionInstallFiles
            // 
            this.SectionInstallFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionInstallFiles.Controls.Add(this.GridFiles);
            this.SectionInstallFiles.Controls.Add(this.PanelButtons);
            this.SectionInstallFiles.Location = new System.Drawing.Point(12, 253);
            this.SectionInstallFiles.Name = "SectionInstallFiles";
            this.SectionInstallFiles.Size = new System.Drawing.Size(583, 221);
            this.SectionInstallFiles.TabIndex = 23;
            this.SectionInstallFiles.Text = "INSTALLATION FILES";
            // 
            // GridFiles
            // 
            this.GridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridFiles.Location = new System.Drawing.Point(2, 23);
            this.GridFiles.MainView = this.GridViewFiles;
            this.GridFiles.Name = "GridFiles";
            this.GridFiles.Size = new System.Drawing.Size(579, 155);
            this.GridFiles.TabIndex = 0;
            this.GridFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewFiles});
            // 
            // GridViewFiles
            // 
            this.GridViewFiles.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewFiles.GridControl = this.GridFiles;
            this.GridViewFiles.Name = "GridViewFiles";
            this.GridViewFiles.OptionsCustomization.AllowFilter = false;
            this.GridViewFiles.OptionsFilter.AllowFilterEditor = false;
            this.GridViewFiles.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.GridViewFiles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewFiles.OptionsView.ShowGroupPanel = false;
            this.GridViewFiles.OptionsView.ShowIndicator = false;
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonAddFile);
            this.PanelButtons.Controls.Add(this.ButtonDeleteFile);
            this.PanelButtons.Controls.Add(this.ButtonDeleteAll);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(2, 178);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(579, 41);
            this.PanelButtons.TabIndex = 1180;
            // 
            // ButtonAddFile
            // 
            this.ButtonAddFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonAddFile.Appearance.Options.UseFont = true;
            this.ButtonAddFile.Location = new System.Drawing.Point(8, 8);
            this.ButtonAddFile.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonAddFile.Name = "ButtonAddFile";
            this.ButtonAddFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonAddFile.Size = new System.Drawing.Size(77, 25);
            this.ButtonAddFile.TabIndex = 1;
            this.ButtonAddFile.Text = "Add File";
            this.ButtonAddFile.Click += new System.EventHandler(this.ButtonAddFile_Click);
            // 
            // ButtonDeleteFile
            // 
            this.ButtonDeleteFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonDeleteFile.Appearance.Options.UseFont = true;
            this.ButtonDeleteFile.Enabled = false;
            this.ButtonDeleteFile.Location = new System.Drawing.Point(91, 8);
            this.ButtonDeleteFile.Name = "ButtonDeleteFile";
            this.ButtonDeleteFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteFile.Size = new System.Drawing.Size(85, 25);
            this.ButtonDeleteFile.TabIndex = 3;
            this.ButtonDeleteFile.Text = "Delete File";
            // 
            // ButtonDeleteAll
            // 
            this.ButtonDeleteAll.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonDeleteAll.Appearance.Options.UseFont = true;
            this.ButtonDeleteAll.Enabled = false;
            this.ButtonDeleteAll.Location = new System.Drawing.Point(182, 8);
            this.ButtonDeleteAll.Name = "ButtonDeleteAll";
            this.ButtonDeleteAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteAll.Size = new System.Drawing.Size(83, 25);
            this.ButtonDeleteAll.TabIndex = 4;
            this.ButtonDeleteAll.Text = "Delete All";
            // 
            // ComboBoxSystemType
            // 
            this.ComboBoxSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSystemType.Location = new System.Drawing.Point(396, 32);
            this.ComboBoxSystemType.Name = "ComboBoxSystemType";
            this.ComboBoxSystemType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ComboBoxSystemType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSystemType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxSystemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxSystemType.Properties.Items.AddRange(new object[] {
            "CEX",
            "DEX",
            "HEN",
            "CEX/DEX",
            "CEX/DEX/HEN"});
            this.ComboBoxSystemType.Properties.NullValuePrompt = "Select...";
            this.ComboBoxSystemType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxSystemType.Size = new System.Drawing.Size(99, 22);
            this.ComboBoxSystemType.TabIndex = 1;
            // 
            // LabelRegion
            // 
            this.LabelRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegion.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelRegion.Appearance.Options.UseFont = true;
            this.LabelRegion.Appearance.Options.UseForeColor = true;
            this.LabelRegion.Location = new System.Drawing.Point(438, 60);
            this.LabelRegion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(40, 15);
            this.LabelRegion.TabIndex = 25;
            this.LabelRegion.Text = "Region:";
            // 
            // TextBoxModType
            // 
            this.TextBoxModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxModType.Location = new System.Drawing.Point(501, 32);
            this.TextBoxModType.Name = "TextBoxModType";
            this.TextBoxModType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxModType.Properties.Appearance.Options.UseFont = true;
            this.TextBoxModType.Size = new System.Drawing.Size(94, 22);
            this.TextBoxModType.TabIndex = 26;
            // 
            // LabelModType
            // 
            this.LabelModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelModType.Appearance.Options.UseFont = true;
            this.LabelModType.Appearance.Options.UseForeColor = true;
            this.LabelModType.Location = new System.Drawing.Point(501, 12);
            this.LabelModType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelModType.Name = "LabelModType";
            this.LabelModType.Size = new System.Drawing.Size(56, 15);
            this.LabelModType.TabIndex = 27;
            this.LabelModType.Text = "Mod Type:";
            // 
            // TextBoxRegion
            // 
            this.TextBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxRegion.Location = new System.Drawing.Point(438, 80);
            this.TextBoxRegion.Name = "TextBoxRegion";
            this.TextBoxRegion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRegion.Properties.Appearance.Options.UseFont = true;
            this.TextBoxRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TextBoxRegion.Size = new System.Drawing.Size(97, 22);
            this.TextBoxRegion.TabIndex = 24;
            // 
            // ImportNewDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(607, 528);
            this.Controls.Add(this.TextBoxModType);
            this.Controls.Add(this.LabelModType);
            this.Controls.Add(this.LabelRegion);
            this.Controls.Add(this.SectionInstallFiles);
            this.Controls.Add(this.LabelConsole);
            this.Controls.Add(this.ComboBoxPlatform);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.LabelSystemType);
            this.Controls.Add(this.ButtonImport);
            this.Controls.Add(this.TextBoxVersion);
            this.Controls.Add(this.TextBoxCreators);
            this.Controls.Add(this.TextBoxModName);
            this.Controls.Add(this.LabelCreator);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelModName);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.ComboBoxSystemType);
            this.Controls.Add(this.TextBoxRegion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ImportNewDialog.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportNewDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Mods";
            this.Load += new System.EventHandler(this.ImportModsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxModName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCreators.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPlatform.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectionInstallFiles)).EndInit();
            this.SectionInstallFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSystemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxModType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxRegion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelVersion;
        private LabelControl LabelCreator;
        private LabelControl LabelCategory;
        private LabelControl LabelModName;
        private TextEdit TextBoxModName;
        private TextEdit TextBoxCreators;
        private TextEdit TextBoxVersion;
        private SimpleButton ButtonImport;
        private LabelControl LabelSystemType;
        private LabelControl labelControl1;
        private MemoEdit TextBoxDescription;
        private ComboBoxEdit ComboBoxPlatform;
        private LabelControl LabelConsole;
        private ComboBoxEdit ComboBoxCategory;
        private GroupControl SectionInstallFiles;
        private DevExpress.XtraGrid.GridControl GridFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewFiles;
        private DevExpress.Utils.Layout.StackPanel PanelButtons;
        private SimpleButton ButtonAddFile;
        private SimpleButton ButtonDeleteFile;
        private SimpleButton ButtonDeleteAll;
        private ComboBoxEdit ComboBoxSystemType;
        private LabelControl LabelRegion;
        private TextEdit TextBoxModType;
        private LabelControl LabelModType;
        private ComboBoxEdit TextBoxRegion;
    }
}