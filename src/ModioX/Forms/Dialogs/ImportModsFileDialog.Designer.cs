using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs
{
    partial class ImportModsFileDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportModsFileDialog));
            this.LabelUsername = new DevExpress.XtraEditors.LabelControl();
            this.LabelPassword = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxFileLocation = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxInstallPath = new DevExpress.XtraEditors.TextEdit();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.ImageFileLocation = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxInstallPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFileLocation.Properties)).BeginInit();
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
            this.LabelUsername.Size = new System.Drawing.Size(70, 15);
            this.LabelUsername.TabIndex = 15;
            this.LabelUsername.Text = "File Location:";
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
            this.LabelPassword.Size = new System.Drawing.Size(61, 15);
            this.LabelPassword.TabIndex = 16;
            this.LabelPassword.Text = "Install Path:";
            // 
            // TextBoxFileLocation
            // 
            this.TextBoxFileLocation.Location = new System.Drawing.Point(90, 12);
            this.TextBoxFileLocation.Name = "TextBoxFileLocation";
            this.TextBoxFileLocation.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxFileLocation.Properties.Appearance.Options.UseFont = true;
            this.TextBoxFileLocation.Size = new System.Drawing.Size(282, 22);
            this.TextBoxFileLocation.TabIndex = 0;
            this.TextBoxFileLocation.EditValueChanged += new System.EventHandler(this.TextBoxUsername_EditValueChanged);
            // 
            // TextBoxInstallPath
            // 
            this.TextBoxInstallPath.Location = new System.Drawing.Point(90, 41);
            this.TextBoxInstallPath.Name = "TextBoxInstallPath";
            this.TextBoxInstallPath.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxInstallPath.Properties.Appearance.Options.UseFont = true;
            this.TextBoxInstallPath.Size = new System.Drawing.Size(282, 22);
            this.TextBoxInstallPath.TabIndex = 1;
            this.TextBoxInstallPath.EditValueChanged += new System.EventHandler(this.TextBoxPassword_EditValueChanged);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(198, 80);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(84, 25);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            // 
            // ButtonOK
            // 
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Enabled = false;
            this.ButtonOK.Location = new System.Drawing.Point(288, 80);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOK.Size = new System.Drawing.Size(84, 25);
            this.ButtonOK.TabIndex = 2;
            this.ButtonOK.Text = "OK";
            // 
            // ImageFileLocation
            // 
            this.ImageFileLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageFileLocation.EditValue = ((object)(resources.GetObject("ImageFileLocation.EditValue")));
            this.ImageFileLocation.Location = new System.Drawing.Point(349, 13);
            this.ImageFileLocation.Name = "ImageFileLocation";
            this.ImageFileLocation.Properties.AllowFocused = false;
            this.ImageFileLocation.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ImageFileLocation.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ImageFileLocation.Properties.Appearance.Options.UseBackColor = true;
            this.ImageFileLocation.Properties.Appearance.Options.UseForeColor = true;
            this.ImageFileLocation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageFileLocation.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageFileLocation.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageFileLocation.Size = new System.Drawing.Size(20, 20);
            this.ImageFileLocation.TabIndex = 1184;
            this.ImageFileLocation.Click += new System.EventHandler(this.ImageFileLocation_Click);
            // 
            // ImportFileDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 117);
            this.Controls.Add(this.ImageFileLocation);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextBoxInstallPath);
            this.Controls.Add(this.TextBoxFileLocation);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ImportFileDialog.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportFileDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import File";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxInstallPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFileLocation.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelUsername;
        private LabelControl LabelPassword;
        public SimpleButton ButtonCancel;
        public SimpleButton ButtonOK;
        public TextEdit TextBoxFileLocation;
        public TextEdit TextBoxInstallPath;
        private PictureEdit ImageFileLocation;
    }
}