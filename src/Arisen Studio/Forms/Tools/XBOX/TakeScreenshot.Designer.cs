
using System.ComponentModel;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ArisenStudio.Forms.Tools.XBOX
{
    partial class TakeScreenshot
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
            this.ButtonCaptureImage = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteImage = new DevExpress.XtraEditors.SimpleButton();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonNewImage = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonOpenFolder = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxFileName = new DevExpress.XtraEditors.TextEdit();
            this.ImageScreenshot = new System.Windows.Forms.PictureBox();
            this.CheckBoxUploadToImgur = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageScreenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxUploadToImgur.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCaptureImage
            // 
            this.ButtonCaptureImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonCaptureImage.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCaptureImage.Appearance.Options.UseFont = true;
            this.ButtonCaptureImage.AutoSize = true;
            this.ButtonCaptureImage.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonCaptureImage.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonCaptureImage.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonCaptureImage.Location = new System.Drawing.Point(0, 0);
            this.ButtonCaptureImage.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonCaptureImage.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonCaptureImage.Name = "ButtonCaptureImage";
            this.ButtonCaptureImage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonCaptureImage.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCaptureImage.Size = new System.Drawing.Size(105, 24);
            this.ButtonCaptureImage.TabIndex = 3;
            this.ButtonCaptureImage.Text = "Capture Image";
            this.ButtonCaptureImage.Click += new System.EventHandler(this.ButtonTakeScreenshot_Click);
            // 
            // ButtonDeleteImage
            // 
            this.ButtonDeleteImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDeleteImage.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDeleteImage.Appearance.Options.UseFont = true;
            this.ButtonDeleteImage.AutoSize = true;
            this.ButtonDeleteImage.Enabled = false;
            this.ButtonDeleteImage.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonDeleteImage.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonDeleteImage.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonDeleteImage.Location = new System.Drawing.Point(111, 0);
            this.ButtonDeleteImage.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDeleteImage.Name = "ButtonDeleteImage";
            this.ButtonDeleteImage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonDeleteImage.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteImage.Size = new System.Drawing.Size(96, 24);
            this.ButtonDeleteImage.TabIndex = 4;
            this.ButtonDeleteImage.Text = "Delete Image";
            this.ButtonDeleteImage.Click += new System.EventHandler(this.ButtonDeleteScreenshot_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonCaptureImage);
            this.PanelButtons.Controls.Add(this.ButtonDeleteImage);
            this.PanelButtons.Controls.Add(this.ButtonNewImage);
            this.PanelButtons.Controls.Add(this.ButtonOpenFolder);
            this.PanelButtons.Location = new System.Drawing.Point(12, 350);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(496, 24);
            this.PanelButtons.TabIndex = 1182;
            // 
            // ButtonNewImage
            // 
            this.ButtonNewImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonNewImage.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonNewImage.Appearance.Options.UseFont = true;
            this.ButtonNewImage.AutoSize = true;
            this.ButtonNewImage.Enabled = false;
            this.ButtonNewImage.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonNewImage.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonNewImage.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonNewImage.Location = new System.Drawing.Point(213, 0);
            this.ButtonNewImage.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonNewImage.Name = "ButtonNewImage";
            this.ButtonNewImage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonNewImage.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonNewImage.Size = new System.Drawing.Size(87, 24);
            this.ButtonNewImage.TabIndex = 6;
            this.ButtonNewImage.Text = "New Image";
            this.ButtonNewImage.Click += new System.EventHandler(this.ButtonNewScreenshot_Click);
            // 
            // ButtonOpenFolder
            // 
            this.ButtonOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonOpenFolder.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonOpenFolder.Appearance.Options.UseFont = true;
            this.ButtonOpenFolder.AutoSize = true;
            this.ButtonOpenFolder.Enabled = false;
            this.ButtonOpenFolder.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonOpenFolder.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonOpenFolder.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonOpenFolder.Location = new System.Drawing.Point(306, 0);
            this.ButtonOpenFolder.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonOpenFolder.Name = "ButtonOpenFolder";
            this.ButtonOpenFolder.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonOpenFolder.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOpenFolder.Size = new System.Drawing.Size(92, 24);
            this.ButtonOpenFolder.TabIndex = 5;
            this.ButtonOpenFolder.Text = "Open Folder";
            this.ButtonOpenFolder.Click += new System.EventHandler(this.ButtonOpenFilePath_Click);
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFileName.Location = new System.Drawing.Point(12, 12);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.Properties.AllowFocused = false;
            this.TextBoxFileName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFileName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxFileName.Properties.NullValuePrompt = "Screenshot File Name (without extension)";
            this.TextBoxFileName.Size = new System.Drawing.Size(379, 24);
            this.TextBoxFileName.TabIndex = 0;
            // 
            // ImageScreenshot
            // 
            this.ImageScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageScreenshot.Location = new System.Drawing.Point(12, 44);
            this.ImageScreenshot.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ImageScreenshot.Name = "ImageScreenshot";
            this.ImageScreenshot.Size = new System.Drawing.Size(496, 298);
            this.ImageScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageScreenshot.TabIndex = 1184;
            this.ImageScreenshot.TabStop = false;
            // 
            // CheckBoxUploadToImgur
            // 
            this.CheckBoxUploadToImgur.Location = new System.Drawing.Point(397, 14);
            this.CheckBoxUploadToImgur.Name = "CheckBoxUploadToImgur";
            this.CheckBoxUploadToImgur.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxUploadToImgur.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxUploadToImgur.Properties.AutoWidth = true;
            this.CheckBoxUploadToImgur.Properties.Caption = "Upload to Imgur";
            this.CheckBoxUploadToImgur.Size = new System.Drawing.Size(111, 20);
            this.CheckBoxUploadToImgur.TabIndex = 1;
            this.CheckBoxUploadToImgur.ToolTip = "if set to true, this will block the console from resolving LIVE related dns\r\nif n" +
    "ot set this value will be TRUE";
            // 
            // TakeScreenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(520, 386);
            this.Controls.Add(this.CheckBoxUploadToImgur);
            this.Controls.Add(this.ImageScreenshot);
            this.Controls.Add(this.TextBoxFileName);
            this.Controls.Add(this.PanelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TakeScreenshot";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Take Screenshot";
            this.Load += new System.EventHandler(this.TakeScreenshot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageScreenshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxUploadToImgur.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SimpleButton ButtonDeleteImage;
        private SimpleButton ButtonCaptureImage;
        private StackPanel PanelButtons;
        private TextEdit TextBoxFileName;
        private System.Windows.Forms.PictureBox ImageScreenshot;
        private CheckEdit CheckBoxUploadToImgur;
        private SimpleButton ButtonOpenFolder;
        private SimpleButton ButtonNewImage;
    }
}