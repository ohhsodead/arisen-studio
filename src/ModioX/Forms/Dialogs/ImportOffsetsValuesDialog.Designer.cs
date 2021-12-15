using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs
{
    partial class ImportOffsetsValuesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportOffsetsValuesDialog));
            this.LabelUsername = new DevExpress.XtraEditors.LabelControl();
            this.LabelPassword = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxOffset = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxValue = new DevExpress.XtraEditors.TextEdit();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxOffset.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUsername
            // 
            this.LabelUsername.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelUsername.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelUsername.Appearance.Options.UseFont = true;
            this.LabelUsername.Appearance.Options.UseForeColor = true;
            this.LabelUsername.Location = new System.Drawing.Point(12, 14);
            this.LabelUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(35, 15);
            this.LabelUsername.TabIndex = 15;
            this.LabelUsername.Text = "Offset:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelPassword.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelPassword.Appearance.Options.UseFont = true;
            this.LabelPassword.Appearance.Options.UseForeColor = true;
            this.LabelPassword.Location = new System.Drawing.Point(12, 43);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(32, 15);
            this.LabelPassword.TabIndex = 16;
            this.LabelPassword.Text = "Value:";
            // 
            // TextBoxOffset
            // 
            this.TextBoxOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxOffset.Location = new System.Drawing.Point(58, 11);
            this.TextBoxOffset.Name = "TextBoxOffset";
            this.TextBoxOffset.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxOffset.Properties.Appearance.Options.UseFont = true;
            this.TextBoxOffset.Size = new System.Drawing.Size(200, 22);
            this.TextBoxOffset.TabIndex = 0;
            this.TextBoxOffset.EditValueChanged += new System.EventHandler(this.TextBoxOffset_EditValueChanged);
            // 
            // TextBoxValue
            // 
            this.TextBoxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxValue.Location = new System.Drawing.Point(58, 40);
            this.TextBoxValue.Name = "TextBoxValue";
            this.TextBoxValue.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxValue.Properties.Appearance.Options.UseFont = true;
            this.TextBoxValue.Size = new System.Drawing.Size(200, 22);
            this.TextBoxValue.TabIndex = 1;
            this.TextBoxValue.EditValueChanged += new System.EventHandler(this.TextBoxValue_EditValueChanged);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(84, 80);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(84, 25);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Enabled = false;
            this.ButtonOK.Location = new System.Drawing.Point(174, 80);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOK.Size = new System.Drawing.Size(84, 25);
            this.ButtonOK.TabIndex = 2;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ImportOffsetsValuesDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(270, 117);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextBoxValue);
            this.Controls.Add(this.TextBoxOffset);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ImportOffsetsValuesDialog.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportOffsetsValuesDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Code";
            this.Load += new System.EventHandler(this.ImportOffsetsValuesDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxOffset.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelUsername;
        private LabelControl LabelPassword;
        public SimpleButton ButtonCancel;
        public SimpleButton ButtonOK;
        public TextEdit TextBoxOffset;
        public TextEdit TextBoxValue;
    }
}