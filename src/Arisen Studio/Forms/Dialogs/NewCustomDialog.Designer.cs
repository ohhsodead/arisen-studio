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
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.LabelCategoryType = new DevExpress.XtraEditors.LabelControl();
            this.ButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.LabelPlatform = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxPlatform = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TextBoxName = new DevExpress.XtraEditors.TextEdit();
            this.ComboBoxCategoryType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ComboBoxCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelVersion = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxModType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelModType = new DevExpress.XtraEditors.LabelControl();
            this.GridViewFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridControlFiles = new DevExpress.XtraGrid.GridControl();
            this.TextBoxVersion = new DevExpress.XtraEditors.TextEdit();
            this.LabelDescription = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxDescription = new DevExpress.XtraRichEdit.RichEditControl();
            this.GroupInstallationFiles = new DevExpress.XtraEditors.GroupControl();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonChooseFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonHelp = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPlatform.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCategoryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxModType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupInstallationFiles)).BeginInit();
            this.GroupInstallationFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.Location = new System.Drawing.Point(12, 62);
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
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Location = new System.Drawing.Point(324, 441);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSave.Size = new System.Drawing.Size(80, 24);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(410, 441);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(80, 24);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "Cancel";
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
            this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxName.Location = new System.Drawing.Point(12, 82);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxName.Size = new System.Drawing.Size(240, 24);
            this.TextBoxName.TabIndex = 4;
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
            this.ComboBoxCategory.Location = new System.Drawing.Point(258, 32);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Properties.AllowFocused = false;
            this.ComboBoxCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxCategory.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxCategory.Properties.DropDownRows = 9;
            this.ComboBoxCategory.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.ComboBoxCategory.Size = new System.Drawing.Size(232, 24);
            this.ComboBoxCategory.TabIndex = 3;
            // 
            // LabelCategory
            // 
            this.LabelCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCategory.Appearance.Options.UseFont = true;
            this.LabelCategory.Location = new System.Drawing.Point(258, 12);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(48, 15);
            this.LabelCategory.TabIndex = 1151;
            this.LabelCategory.Text = "Category";
            // 
            // LabelVersion
            // 
            this.LabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelVersion.Appearance.Options.UseFont = true;
            this.LabelVersion.Location = new System.Drawing.Point(400, 62);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(39, 15);
            this.LabelVersion.TabIndex = 1154;
            this.LabelVersion.Text = "Version";
            // 
            // ComboBoxModType
            // 
            this.ComboBoxModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxModType.EditValue = "";
            this.ComboBoxModType.Location = new System.Drawing.Point(258, 82);
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
            // LabelModType
            // 
            this.LabelModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelModType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelModType.Appearance.Options.UseFont = true;
            this.LabelModType.Location = new System.Drawing.Point(258, 62);
            this.LabelModType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelModType.Name = "LabelModType";
            this.LabelModType.Size = new System.Drawing.Size(53, 15);
            this.LabelModType.TabIndex = 1156;
            this.LabelModType.Text = "Mod Type";
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
            this.GridControlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlFiles.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridControlFiles.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.GridControlFiles.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridControlFiles.Location = new System.Drawing.Point(2, 22);
            this.GridControlFiles.MainView = this.GridViewFiles;
            this.GridControlFiles.Name = "GridControlFiles";
            this.GridControlFiles.Size = new System.Drawing.Size(474, 116);
            this.GridControlFiles.TabIndex = 8;
            this.GridControlFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewFiles});
            // 
            // TextBoxVersion
            // 
            this.TextBoxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxVersion.Location = new System.Drawing.Point(400, 82);
            this.TextBoxVersion.Name = "TextBoxVersion";
            this.TextBoxVersion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxVersion.Properties.Appearance.Options.UseFont = true;
            this.TextBoxVersion.Size = new System.Drawing.Size(90, 24);
            this.TextBoxVersion.TabIndex = 5;
            // 
            // LabelDescription
            // 
            this.LabelDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.Appearance.Options.UseFont = true;
            this.LabelDescription.Location = new System.Drawing.Point(12, 112);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(60, 15);
            this.LabelDescription.TabIndex = 1187;
            this.LabelDescription.Text = "Description";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescription.Appearance.Text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDescription.Appearance.Text.Options.UseFont = true;
            this.TextBoxDescription.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.TextBoxDescription.Location = new System.Drawing.Point(12, 132);
            this.TextBoxDescription.LookAndFeel.SkinName = "WXI";
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Options.Behavior.FontSource = DevExpress.XtraRichEdit.RichEditBaseValueSource.Control;
            this.TextBoxDescription.Options.ClipboardFormats.Html = DevExpress.XtraRichEdit.RichEditClipboardMode.Disabled;
            this.TextBoxDescription.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.TextBoxDescription.Options.Export.Mht.HtmlNumberingListExportFormat = DevExpress.XtraRichEdit.Export.Html.HtmlNumberingListExportFormat.PlainTextFormat;
            this.TextBoxDescription.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.TextBoxDescription.Options.Import.Html.AutoDetectEncoding = false;
            this.TextBoxDescription.Size = new System.Drawing.Size(478, 94);
            this.TextBoxDescription.TabIndex = 7;
            this.TextBoxDescription.Views.SimpleView.AdjustColorsToSkins = true;
            this.TextBoxDescription.Views.SimpleView.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxDescription.Views.SimpleView.Padding = new DevExpress.Portable.PortablePadding(2);
            // 
            // GroupInstallationFiles
            // 
            this.GroupInstallationFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupInstallationFiles.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupInstallationFiles.AppearanceCaption.Options.UseFont = true;
            this.GroupInstallationFiles.Controls.Add(this.GridControlFiles);
            this.GroupInstallationFiles.Controls.Add(this.PanelButtons);
            this.GroupInstallationFiles.Location = new System.Drawing.Point(12, 240);
            this.GroupInstallationFiles.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.GroupInstallationFiles.Name = "GroupInstallationFiles";
            this.GroupInstallationFiles.Size = new System.Drawing.Size(478, 172);
            this.GroupInstallationFiles.TabIndex = 1189;
            this.GroupInstallationFiles.Text = "Installation Files";
            // 
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonChooseFile);
            this.PanelButtons.Controls.Add(this.ButtonDeleteFile);
            this.PanelButtons.Controls.Add(this.ButtonDeleteAll);
            this.PanelButtons.Controls.Add(this.ButtonHelp);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(2, 138);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.PanelButtons.Size = new System.Drawing.Size(474, 32);
            this.PanelButtons.TabIndex = 1186;
            // 
            // ButtonChooseFile
            // 
            this.ButtonChooseFile.AutoSize = true;
            this.ButtonChooseFile.Enabled = false;
            this.ButtonChooseFile.Location = new System.Drawing.Point(0, 8);
            this.ButtonChooseFile.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonChooseFile.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonChooseFile.Name = "ButtonChooseFile";
            this.ButtonChooseFile.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonChooseFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonChooseFile.Size = new System.Drawing.Size(95, 24);
            this.ButtonChooseFile.TabIndex = 9;
            this.ButtonChooseFile.Text = "Choose File";
            // 
            // ButtonDeleteFile
            // 
            this.ButtonDeleteFile.AutoSize = true;
            this.ButtonDeleteFile.Enabled = false;
            this.ButtonDeleteFile.Location = new System.Drawing.Point(101, 8);
            this.ButtonDeleteFile.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDeleteFile.Name = "ButtonDeleteFile";
            this.ButtonDeleteFile.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonDeleteFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteFile.Size = new System.Drawing.Size(68, 24);
            this.ButtonDeleteFile.TabIndex = 10;
            this.ButtonDeleteFile.Text = "Delete";
            // 
            // ButtonDeleteAll
            // 
            this.ButtonDeleteAll.AutoSize = true;
            this.ButtonDeleteAll.Enabled = false;
            this.ButtonDeleteAll.Location = new System.Drawing.Point(175, 8);
            this.ButtonDeleteAll.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDeleteAll.Name = "ButtonDeleteAll";
            this.ButtonDeleteAll.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonDeleteAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteAll.Size = new System.Drawing.Size(84, 24);
            this.ButtonDeleteAll.TabIndex = 11;
            this.ButtonDeleteAll.Text = "Delete All";
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.AutoSize = true;
            this.ButtonHelp.Enabled = false;
            this.ButtonHelp.Location = new System.Drawing.Point(265, 8);
            this.ButtonHelp.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.ButtonHelp.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonHelp.Size = new System.Drawing.Size(59, 24);
            this.ButtonHelp.TabIndex = 12;
            this.ButtonHelp.Text = "Help";
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // NewCustomDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(502, 477);
            this.Controls.Add(this.GroupInstallationFiles);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.ComboBoxModType);
            this.Controls.Add(this.LabelModType);
            this.Controls.Add(this.TextBoxVersion);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.ComboBoxCategoryType);
            this.Controls.Add(this.ComboBoxPlatform);
            this.Controls.Add(this.LabelPlatform);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelCategoryType);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mod Details";
            this.Load += new System.EventHandler(this.NewCustomDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPlatform.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCategoryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxModType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupInstallationFiles)).EndInit();
            this.GroupInstallationFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelName;
        private LabelControl LabelCategoryType;
        private TextEdit TextBoxName;
        private SimpleButton ButtonSave;
        private SimpleButton ButtonCancel;
        private LabelControl LabelPlatform;
        private ComboBoxEdit ComboBoxPlatform;
        private ComboBoxEdit ComboBoxCategoryType;
        private ComboBoxEdit ComboBoxCategory;
        private LabelControl LabelCategory;
        private LabelControl LabelVersion;
        private ComboBoxEdit ComboBoxModType;
        private LabelControl LabelModType;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewFiles;
        private DevExpress.XtraGrid.GridControl GridControlFiles;
        private TextEdit TextBoxVersion;
        private LabelControl LabelDescription;
        private DevExpress.XtraRichEdit.RichEditControl TextBoxDescription;
        private GroupControl GroupInstallationFiles;
        private DevExpress.Utils.Layout.StackPanel PanelButtons;
        private SimpleButton ButtonChooseFile;
        private SimpleButton ButtonDeleteFile;
        private SimpleButton ButtonDeleteAll;
        private SimpleButton ButtonHelp;
    }
}