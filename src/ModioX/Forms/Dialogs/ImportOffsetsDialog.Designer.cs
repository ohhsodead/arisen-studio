using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs
{
    partial class ImportOffsetsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportOffsetsDialog));
            this.LabelGameCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelModName = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxName = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxGame = new DevExpress.XtraEditors.TextEdit();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.LabelSourceLink = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxConsoleType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelConsole = new DevExpress.XtraEditors.LabelControl();
            this.GridControlMemoryOffsets = new DevExpress.XtraGrid.GridControl();
            this.GridViewMemoryOffsets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ButtonAddCode = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRemoveCode = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonEditCode = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGame.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxConsoleType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlMemoryOffsets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMemoryOffsets)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelGameCategory
            // 
            this.LabelGameCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameCategory.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameCategory.Appearance.Options.UseFont = true;
            this.LabelGameCategory.Appearance.Options.UseForeColor = true;
            this.LabelGameCategory.Location = new System.Drawing.Point(12, 60);
            this.LabelGameCategory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelGameCategory.Name = "LabelGameCategory";
            this.LabelGameCategory.Size = new System.Drawing.Size(34, 15);
            this.LabelGameCategory.TabIndex = 12;
            this.LabelGameCategory.Text = "Game:";
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
            // TextBoxName
            // 
            this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxName.Location = new System.Drawing.Point(12, 32);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxName.Size = new System.Drawing.Size(197, 22);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.EditValueChanged += new System.EventHandler(this.TextBoxName_EditValueChanged);
            // 
            // TextBoxGame
            // 
            this.TextBoxGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGame.Location = new System.Drawing.Point(12, 80);
            this.TextBoxGame.Name = "TextBoxGame";
            this.TextBoxGame.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxGame.Properties.Appearance.Options.UseFont = true;
            this.TextBoxGame.Size = new System.Drawing.Size(299, 22);
            this.TextBoxGame.TabIndex = 2;
            this.TextBoxGame.EditValueChanged += new System.EventHandler(this.TextBoxGame_EditValueChanged);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonCancel.Appearance.Options.UseFont = true;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(155, 334);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(75, 25);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "Cancel";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonSave.Appearance.Options.UseFont = true;
            this.ButtonSave.Location = new System.Drawing.Point(236, 334);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSave.Size = new System.Drawing.Size(75, 25);
            this.ButtonSave.TabIndex = 8;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // LabelSourceLink
            // 
            this.LabelSourceLink.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSourceLink.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelSourceLink.Appearance.Options.UseFont = true;
            this.LabelSourceLink.Appearance.Options.UseForeColor = true;
            this.LabelSourceLink.Location = new System.Drawing.Point(12, 108);
            this.LabelSourceLink.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSourceLink.Name = "LabelSourceLink";
            this.LabelSourceLink.Size = new System.Drawing.Size(36, 15);
            this.LabelSourceLink.TabIndex = 16;
            this.LabelSourceLink.Text = "Codes:";
            // 
            // ComboBoxConsoleType
            // 
            this.ComboBoxConsoleType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxConsoleType.EditValue = "PlayStation 3";
            this.ComboBoxConsoleType.Location = new System.Drawing.Point(215, 32);
            this.ComboBoxConsoleType.Name = "ComboBoxConsoleType";
            this.ComboBoxConsoleType.Properties.AllowFocused = false;
            this.ComboBoxConsoleType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxConsoleType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxConsoleType.Properties.AutoComplete = false;
            this.ComboBoxConsoleType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxConsoleType.Properties.Items.AddRange(new object[] {
            "PlayStation 3",
            "Xbox 360"});
            this.ComboBoxConsoleType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxConsoleType.Size = new System.Drawing.Size(96, 22);
            this.ComboBoxConsoleType.TabIndex = 1;
            this.ComboBoxConsoleType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxConsoleType_SelectedIndexChanged);
            // 
            // LabelConsole
            // 
            this.LabelConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelConsole.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConsole.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelConsole.Appearance.Options.UseFont = true;
            this.LabelConsole.Appearance.Options.UseForeColor = true;
            this.LabelConsole.Location = new System.Drawing.Point(215, 12);
            this.LabelConsole.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelConsole.Name = "LabelConsole";
            this.LabelConsole.Size = new System.Drawing.Size(46, 15);
            this.LabelConsole.TabIndex = 22;
            this.LabelConsole.Text = "Console:";
            // 
            // GridControlMemoryOffsets
            // 
            this.GridControlMemoryOffsets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridControlMemoryOffsets.Location = new System.Drawing.Point(12, 128);
            this.GridControlMemoryOffsets.MainView = this.GridViewMemoryOffsets;
            this.GridControlMemoryOffsets.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GridControlMemoryOffsets.Name = "GridControlMemoryOffsets";
            this.GridControlMemoryOffsets.Size = new System.Drawing.Size(299, 156);
            this.GridControlMemoryOffsets.TabIndex = 3;
            this.GridControlMemoryOffsets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewMemoryOffsets});
            // 
            // GridViewMemoryOffsets
            // 
            this.GridViewMemoryOffsets.ActiveFilterEnabled = false;
            this.GridViewMemoryOffsets.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewMemoryOffsets.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewMemoryOffsets.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewMemoryOffsets.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewMemoryOffsets.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewMemoryOffsets.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewMemoryOffsets.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.GridViewMemoryOffsets.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GridViewMemoryOffsets.Appearance.Row.Options.UseBackColor = true;
            this.GridViewMemoryOffsets.Appearance.Row.Options.UseFont = true;
            this.GridViewMemoryOffsets.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridViewMemoryOffsets.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewMemoryOffsets.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.GridViewMemoryOffsets.AppearancePrint.Row.Options.UseBackColor = true;
            this.GridViewMemoryOffsets.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewMemoryOffsets.GridControl = this.GridControlMemoryOffsets;
            this.GridViewMemoryOffsets.GroupRowHeight = 20;
            this.GridViewMemoryOffsets.Name = "GridViewMemoryOffsets";
            this.GridViewMemoryOffsets.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.GridViewMemoryOffsets.OptionsCustomization.AllowFilter = false;
            this.GridViewMemoryOffsets.OptionsFilter.AllowFilterEditor = false;
            this.GridViewMemoryOffsets.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewMemoryOffsets.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewMemoryOffsets.OptionsView.ShowGroupPanel = false;
            this.GridViewMemoryOffsets.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewMemoryOffsets.OptionsView.ShowIndicator = false;
            this.GridViewMemoryOffsets.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewMemoryOffsets.RowHeight = 24;
            this.GridViewMemoryOffsets.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // ButtonAddCode
            // 
            this.ButtonAddCode.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonAddCode.Appearance.Options.UseFont = true;
            this.ButtonAddCode.Location = new System.Drawing.Point(12, 290);
            this.ButtonAddCode.Name = "ButtonAddCode";
            this.ButtonAddCode.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonAddCode.Size = new System.Drawing.Size(89, 25);
            this.ButtonAddCode.TabIndex = 4;
            this.ButtonAddCode.Text = "Add Code";
            this.ButtonAddCode.Click += new System.EventHandler(this.ButtonAddCode_Click);
            // 
            // ButtonRemoveCode
            // 
            this.ButtonRemoveCode.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonRemoveCode.Appearance.Options.UseFont = true;
            this.ButtonRemoveCode.Location = new System.Drawing.Point(202, 290);
            this.ButtonRemoveCode.Name = "ButtonRemoveCode";
            this.ButtonRemoveCode.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRemoveCode.Size = new System.Drawing.Size(109, 25);
            this.ButtonRemoveCode.TabIndex = 6;
            this.ButtonRemoveCode.Text = "Remove Code";
            // 
            // ButtonEditCode
            // 
            this.ButtonEditCode.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ButtonEditCode.Appearance.Options.UseFont = true;
            this.ButtonEditCode.Location = new System.Drawing.Point(107, 290);
            this.ButtonEditCode.Name = "ButtonEditCode";
            this.ButtonEditCode.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonEditCode.Size = new System.Drawing.Size(89, 25);
            this.ButtonEditCode.TabIndex = 5;
            this.ButtonEditCode.Text = "Edit Code";
            // 
            // ImportOffsetsDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(323, 371);
            this.Controls.Add(this.ButtonEditCode);
            this.Controls.Add(this.ButtonRemoveCode);
            this.Controls.Add(this.ButtonAddCode);
            this.Controls.Add(this.GridControlMemoryOffsets);
            this.Controls.Add(this.LabelConsole);
            this.Controls.Add(this.ComboBoxConsoleType);
            this.Controls.Add(this.LabelSourceLink);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextBoxGame);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelGameCategory);
            this.Controls.Add(this.LabelModName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ImportOffsetsDialog.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportOffsetsDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Mods";
            this.Load += new System.EventHandler(this.ImportOffsetsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGame.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxConsoleType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlMemoryOffsets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMemoryOffsets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelGameCategory;
        private LabelControl LabelModName;
        private TextEdit TextBoxName;
        private TextEdit TextBoxGame;
        private SimpleButton ButtonCancel;
        private SimpleButton ButtonSave;
        private LabelControl LabelSourceLink;
        private ComboBoxEdit ComboBoxConsoleType;
        private LabelControl LabelConsole;
        private DevExpress.XtraGrid.GridControl GridControlMemoryOffsets;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewMemoryOffsets;
        private SimpleButton ButtonAddCode;
        private SimpleButton ButtonRemoveCode;
        private SimpleButton ButtonEditCode;
    }
}