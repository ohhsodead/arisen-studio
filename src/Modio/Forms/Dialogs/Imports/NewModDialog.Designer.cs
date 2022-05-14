using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Modio.Forms.Dialogs.Imports
{
    partial class NewModDialog
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
            this.LabelRequestedBy = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxRegion = new DevExpress.XtraEditors.TextEdit();
            this.LabelRegion = new DevExpress.XtraEditors.LabelControl();
            this.LabelConsole = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxConsole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxDescription = new DevExpress.XtraEditors.MemoEdit();
            this.LabelSourceLink = new DevExpress.XtraEditors.LabelControl();
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxCreators = new DevExpress.XtraEditors.TextEdit();
            this.LabelCreatedBy = new DevExpress.XtraEditors.LabelControl();
            this.LabelCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxSourceLinks = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxModName = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxGameCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxConsole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCreators.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSourceLinks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxModName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRequestedBy
            // 
            this.LabelRequestedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRequestedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelRequestedBy.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelRequestedBy.Appearance.Options.UseFont = true;
            this.LabelRequestedBy.Appearance.Options.UseForeColor = true;
            this.LabelRequestedBy.Location = new System.Drawing.Point(226, 108);
            this.LabelRequestedBy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelRequestedBy.Name = "LabelRequestedBy";
            this.LabelRequestedBy.Size = new System.Drawing.Size(74, 15);
            this.LabelRequestedBy.TabIndex = 44;
            this.LabelRequestedBy.Text = "Submitted by:";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(226, 128);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(172, 22);
            this.textEdit1.TabIndex = 43;
            // 
            // TextBoxRegion
            // 
            this.TextBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxRegion.Location = new System.Drawing.Point(269, 80);
            this.TextBoxRegion.Name = "TextBoxRegion";
            this.TextBoxRegion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxRegion.Properties.Appearance.Options.UseFont = true;
            this.TextBoxRegion.Size = new System.Drawing.Size(129, 22);
            this.TextBoxRegion.TabIndex = 31;
            // 
            // LabelRegion
            // 
            this.LabelRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelRegion.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelRegion.Appearance.Options.UseFont = true;
            this.LabelRegion.Appearance.Options.UseForeColor = true;
            this.LabelRegion.Location = new System.Drawing.Point(269, 60);
            this.LabelRegion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(40, 15);
            this.LabelRegion.TabIndex = 42;
            this.LabelRegion.Text = "Region:";
            // 
            // LabelConsole
            // 
            this.LabelConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelConsole.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelConsole.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelConsole.Appearance.Options.UseFont = true;
            this.LabelConsole.Appearance.Options.UseForeColor = true;
            this.LabelConsole.Location = new System.Drawing.Point(289, 12);
            this.LabelConsole.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelConsole.Name = "LabelConsole";
            this.LabelConsole.Size = new System.Drawing.Size(49, 15);
            this.LabelConsole.TabIndex = 41;
            this.LabelConsole.Text = "Platform:";
            // 
            // ComboBoxConsole
            // 
            this.ComboBoxConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxConsole.Location = new System.Drawing.Point(289, 32);
            this.ComboBoxConsole.Name = "ComboBoxConsole";
            this.ComboBoxConsole.Properties.AllowFocused = false;
            this.ComboBoxConsole.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ComboBoxConsole.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxConsole.Properties.AutoComplete = false;
            this.ComboBoxConsole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxConsole.Properties.Items.AddRange(new object[] {
            "PlayStation 3",
            "Xbox 360"});
            this.ComboBoxConsole.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxConsole.Size = new System.Drawing.Size(109, 22);
            this.ComboBoxConsole.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 156);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 15);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Description:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescription.EditValue = "";
            this.TextBoxDescription.Location = new System.Drawing.Point(12, 176);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxDescription.Properties.Appearance.Options.UseFont = true;
            this.TextBoxDescription.Size = new System.Drawing.Size(386, 65);
            this.TextBoxDescription.TabIndex = 29;
            // 
            // LabelSourceLink
            // 
            this.LabelSourceLink.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelSourceLink.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelSourceLink.Appearance.Options.UseFont = true;
            this.LabelSourceLink.Appearance.Options.UseForeColor = true;
            this.LabelSourceLink.Location = new System.Drawing.Point(12, 247);
            this.LabelSourceLink.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSourceLink.Name = "LabelSourceLink";
            this.LabelSourceLink.Size = new System.Drawing.Size(64, 15);
            this.LabelSourceLink.TabIndex = 39;
            this.LabelSourceLink.Text = "Source Link:";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Location = new System.Drawing.Point(242, 368);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 34;
            this.ButtonOK.Text = "OK";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(323, 368);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 35;
            this.ButtonCancel.Text = "Cancel";
            // 
            // TextBoxCreators
            // 
            this.TextBoxCreators.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCreators.Location = new System.Drawing.Point(12, 128);
            this.TextBoxCreators.Name = "TextBoxCreators";
            this.TextBoxCreators.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxCreators.Properties.Appearance.Options.UseFont = true;
            this.TextBoxCreators.Size = new System.Drawing.Size(208, 22);
            this.TextBoxCreators.TabIndex = 32;
            // 
            // LabelCreatedBy
            // 
            this.LabelCreatedBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelCreatedBy.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelCreatedBy.Appearance.Options.UseFont = true;
            this.LabelCreatedBy.Appearance.Options.UseForeColor = true;
            this.LabelCreatedBy.Location = new System.Drawing.Point(12, 108);
            this.LabelCreatedBy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelCreatedBy.Name = "LabelCreatedBy";
            this.LabelCreatedBy.Size = new System.Drawing.Size(57, 15);
            this.LabelCreatedBy.TabIndex = 36;
            this.LabelCreatedBy.Text = "Created by";
            // 
            // LabelCategory
            // 
            this.LabelCategory.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelCategory.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelCategory.Appearance.Options.UseFont = true;
            this.LabelCategory.Appearance.Options.UseForeColor = true;
            this.LabelCategory.Location = new System.Drawing.Point(12, 12);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(51, 15);
            this.LabelCategory.TabIndex = 37;
            this.LabelCategory.Text = "Category:";
            // 
            // LabelName
            // 
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.Appearance.Options.UseForeColor = true;
            this.LabelName.Location = new System.Drawing.Point(12, 60);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 15);
            this.LabelName.TabIndex = 38;
            this.LabelName.Text = "Name:";
            // 
            // TextBoxSourceLinks
            // 
            this.TextBoxSourceLinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSourceLinks.EditValue = "";
            this.TextBoxSourceLinks.Location = new System.Drawing.Point(12, 267);
            this.TextBoxSourceLinks.Name = "TextBoxSourceLinks";
            this.TextBoxSourceLinks.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxSourceLinks.Properties.Appearance.Options.UseFont = true;
            this.TextBoxSourceLinks.Size = new System.Drawing.Size(386, 22);
            this.TextBoxSourceLinks.TabIndex = 33;
            // 
            // TextBoxModName
            // 
            this.TextBoxModName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxModName.Location = new System.Drawing.Point(12, 80);
            this.TextBoxModName.Name = "TextBoxModName";
            this.TextBoxModName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxModName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxModName.Size = new System.Drawing.Size(251, 22);
            this.TextBoxModName.TabIndex = 27;
            // 
            // TextBoxGameCategory
            // 
            this.TextBoxGameCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGameCategory.Location = new System.Drawing.Point(12, 32);
            this.TextBoxGameCategory.Name = "TextBoxGameCategory";
            this.TextBoxGameCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxGameCategory.Properties.Appearance.Options.UseFont = true;
            this.TextBoxGameCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TextBoxGameCategory.Size = new System.Drawing.Size(271, 22);
            this.TextBoxGameCategory.TabIndex = 30;
            // 
            // NewModDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(410, 403);
            this.Controls.Add(this.LabelRequestedBy);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.TextBoxRegion);
            this.Controls.Add(this.LabelRegion);
            this.Controls.Add(this.LabelConsole);
            this.Controls.Add(this.ComboBoxConsole);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.LabelSourceLink);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextBoxCreators);
            this.Controls.Add(this.LabelCreatedBy);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxSourceLinks);
            this.Controls.Add(this.TextBoxModName);
            this.Controls.Add(this.TextBoxGameCategory);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewModDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Request Mods";
            this.Load += new System.EventHandler(this.ImportedModsManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxConsole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCreators.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSourceLinks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxModName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameCategory.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl LabelRequestedBy;
        private TextEdit textEdit1;
        private TextEdit TextBoxRegion;
        private LabelControl LabelRegion;
        private LabelControl LabelConsole;
        private ComboBoxEdit ComboBoxConsole;
        private LabelControl labelControl1;
        private MemoEdit TextBoxDescription;
        private LabelControl LabelSourceLink;
        private SimpleButton ButtonOK;
        private SimpleButton ButtonCancel;
        private TextEdit TextBoxCreators;
        private LabelControl LabelCreatedBy;
        private LabelControl LabelCategory;
        private LabelControl LabelName;
        private TextEdit TextBoxSourceLinks;
        private TextEdit TextBoxModName;
        private ComboBoxEdit TextBoxGameCategory;
    }
}