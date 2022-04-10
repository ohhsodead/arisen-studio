using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs.Importing
{
    partial class InstallFileDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallFileDialog));
            this.LabelLocalFile = new DevExpress.XtraEditors.LabelControl();
            this.LabelFilePath = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxLocalFilePath = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxInstallFilePath = new DevExpress.XtraEditors.TextEdit();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.ImageFileLocation = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLocalFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxInstallFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFileLocation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLocalFile
            // 
            this.LabelLocalFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLocalFile.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelLocalFile.Appearance.Options.UseFont = true;
            this.LabelLocalFile.Appearance.Options.UseForeColor = true;
            this.LabelLocalFile.Location = new System.Drawing.Point(12, 14);
            this.LabelLocalFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelLocalFile.Name = "LabelLocalFile";
            this.LabelLocalFile.Size = new System.Drawing.Size(52, 15);
            this.LabelLocalFile.TabIndex = 15;
            this.LabelLocalFile.Text = "Local File:";
            // 
            // LabelFilePath
            // 
            this.LabelFilePath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFilePath.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFilePath.Appearance.Options.UseFont = true;
            this.LabelFilePath.Appearance.Options.UseForeColor = true;
            this.LabelFilePath.Location = new System.Drawing.Point(12, 43);
            this.LabelFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelFilePath.Name = "LabelFilePath";
            this.LabelFilePath.Size = new System.Drawing.Size(61, 15);
            this.LabelFilePath.TabIndex = 16;
            this.LabelFilePath.Text = "Install Path:";
            // 
            // TextBoxLocalFilePath
            // 
            this.TextBoxLocalFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLocalFilePath.Location = new System.Drawing.Point(90, 12);
            this.TextBoxLocalFilePath.Name = "TextBoxLocalFilePath";
            this.TextBoxLocalFilePath.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxLocalFilePath.Properties.Appearance.Options.UseFont = true;
            this.TextBoxLocalFilePath.Size = new System.Drawing.Size(315, 22);
            this.TextBoxLocalFilePath.TabIndex = 0;
            this.TextBoxLocalFilePath.EditValueChanged += new System.EventHandler(this.TextBoxLocalFilePath_EditValueChanged);
            // 
            // TextBoxInstallFilePath
            // 
            this.TextBoxInstallFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxInstallFilePath.Location = new System.Drawing.Point(90, 41);
            this.TextBoxInstallFilePath.Name = "TextBoxInstallFilePath";
            this.TextBoxInstallFilePath.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxInstallFilePath.Properties.Appearance.Options.UseFont = true;
            this.TextBoxInstallFilePath.Size = new System.Drawing.Size(344, 22);
            this.TextBoxInstallFilePath.TabIndex = 1;
            this.TextBoxInstallFilePath.EditValueChanged += new System.EventHandler(this.TextBoxInstallFilePath_EditValueChanged);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(260, 80);
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
            this.ButtonOK.Location = new System.Drawing.Point(350, 80);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOK.Size = new System.Drawing.Size(84, 25);
            this.ButtonOK.TabIndex = 2;
            this.ButtonOK.Text = "OK";
            // 
            // ImageFileLocation
            // 
            this.ImageFileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageFileLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageFileLocation.EditValue = ((object)(resources.GetObject("ImageFileLocation.EditValue")));
            this.ImageFileLocation.Location = new System.Drawing.Point(414, 12);
            this.ImageFileLocation.Name = "ImageFileLocation";
            this.ImageFileLocation.Properties.AllowFocused = false;
            this.ImageFileLocation.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ImageFileLocation.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ImageFileLocation.Properties.Appearance.Options.UseBackColor = true;
            this.ImageFileLocation.Properties.Appearance.Options.UseForeColor = true;
            this.ImageFileLocation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageFileLocation.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageFileLocation.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageFileLocation.Size = new System.Drawing.Size(22, 22);
            this.ImageFileLocation.TabIndex = 1184;
            this.ImageFileLocation.Click += new System.EventHandler(this.ImageFileLocation_Click);
            // 
            // InstallFileDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(446, 117);
            this.Controls.Add(this.ImageFileLocation);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextBoxInstallFilePath);
            this.Controls.Add(this.TextBoxLocalFilePath);
            this.Controls.Add(this.LabelFilePath);
            this.Controls.Add(this.LabelLocalFile);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("InstallFileDialog.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallFileDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Install File";
            this.Load += new System.EventHandler(this.InstallFileDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLocalFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxInstallFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFileLocation.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelLocalFile;
        private LabelControl LabelFilePath;
        public SimpleButton ButtonCancel;
        public SimpleButton ButtonOK;
        public TextEdit TextBoxLocalFilePath;
        public TextEdit TextBoxInstallFilePath;
        private PictureEdit ImageFileLocation;
    }
}