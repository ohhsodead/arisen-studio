
using System.ComponentModel;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ArisenStudio.Forms.Tools.PS3
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
            this.ButtonTakeScreenshot = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteScreenshot = new DevExpress.XtraEditors.SimpleButton();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonOpenFilePath = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxFileName = new DevExpress.XtraEditors.TextEdit();
            this.ImageScreenshot = new System.Windows.Forms.PictureBox();
            this.CheckBoxUploadToImgur = new DevExpress.XtraEditors.CheckEdit();
            this.ButtonNewScreenshot = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageScreenshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxUploadToImgur.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonTakeScreenshot
            // 
            this.ButtonTakeScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonTakeScreenshot.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonTakeScreenshot.Appearance.Options.UseFont = true;
            this.ButtonTakeScreenshot.AutoSize = true;
            this.ButtonTakeScreenshot.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonTakeScreenshot.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonTakeScreenshot.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonTakeScreenshot.Location = new System.Drawing.Point(0, 0);
            this.ButtonTakeScreenshot.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonTakeScreenshot.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonTakeScreenshot.Name = "ButtonTakeScreenshot";
            this.ButtonTakeScreenshot.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonTakeScreenshot.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonTakeScreenshot.Size = new System.Drawing.Size(112, 24);
            this.ButtonTakeScreenshot.TabIndex = 3;
            this.ButtonTakeScreenshot.Text = "Take Screenshot";
            this.ButtonTakeScreenshot.Click += new System.EventHandler(this.ButtonTakeScreenshot_Click);
            // 
            // ButtonDeleteScreenshot
            // 
            this.ButtonDeleteScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonDeleteScreenshot.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDeleteScreenshot.Appearance.Options.UseFont = true;
            this.ButtonDeleteScreenshot.AutoSize = true;
            this.ButtonDeleteScreenshot.Enabled = false;
            this.ButtonDeleteScreenshot.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonDeleteScreenshot.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonDeleteScreenshot.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonDeleteScreenshot.Location = new System.Drawing.Point(118, 0);
            this.ButtonDeleteScreenshot.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDeleteScreenshot.Name = "ButtonDeleteScreenshot";
            this.ButtonDeleteScreenshot.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonDeleteScreenshot.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteScreenshot.Size = new System.Drawing.Size(121, 24);
            this.ButtonDeleteScreenshot.TabIndex = 4;
            this.ButtonDeleteScreenshot.Text = "Delete Screenshot";
            this.ButtonDeleteScreenshot.Click += new System.EventHandler(this.ButtonDeleteScreenshot_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonTakeScreenshot);
            this.PanelButtons.Controls.Add(this.ButtonDeleteScreenshot);
            this.PanelButtons.Controls.Add(this.ButtonNewScreenshot);
            this.PanelButtons.Controls.Add(this.ButtonOpenFilePath);
            this.PanelButtons.Location = new System.Drawing.Point(12, 350);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(496, 24);
            this.PanelButtons.TabIndex = 1182;
            // 
            // ButtonOpenFilePath
            // 
            this.ButtonOpenFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonOpenFilePath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonOpenFilePath.Appearance.Options.UseFont = true;
            this.ButtonOpenFilePath.AutoSize = true;
            this.ButtonOpenFilePath.Enabled = false;
            this.ButtonOpenFilePath.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonOpenFilePath.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonOpenFilePath.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonOpenFilePath.Location = new System.Drawing.Point(338, 0);
            this.ButtonOpenFilePath.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonOpenFilePath.Name = "ButtonOpenFilePath";
            this.ButtonOpenFilePath.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonOpenFilePath.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOpenFilePath.Size = new System.Drawing.Size(104, 24);
            this.ButtonOpenFilePath.TabIndex = 5;
            this.ButtonOpenFilePath.Text = "Open File Path";
            this.ButtonOpenFilePath.Click += new System.EventHandler(this.ButtonOpenFilePath_Click);
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
            // ButtonNewScreenshot
            // 
            this.ButtonNewScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonNewScreenshot.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonNewScreenshot.Appearance.Options.UseFont = true;
            this.ButtonNewScreenshot.AutoSize = true;
            this.ButtonNewScreenshot.Enabled = false;
            this.ButtonNewScreenshot.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonNewScreenshot.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonNewScreenshot.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonNewScreenshot.Location = new System.Drawing.Point(245, 0);
            this.ButtonNewScreenshot.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonNewScreenshot.Name = "ButtonNewScreenshot";
            this.ButtonNewScreenshot.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonNewScreenshot.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonNewScreenshot.Size = new System.Drawing.Size(87, 24);
            this.ButtonNewScreenshot.TabIndex = 7;
            this.ButtonNewScreenshot.Text = "New Image";
            this.ButtonNewScreenshot.Click += new System.EventHandler(this.ButtonNewScreenshot_Click);
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
        private SimpleButton ButtonDeleteScreenshot;
        private SimpleButton ButtonTakeScreenshot;
        private StackPanel PanelButtons;
        private TextEdit TextBoxFileName;
        private System.Windows.Forms.PictureBox ImageScreenshot;
        private CheckEdit CheckBoxUploadToImgur;
        private SimpleButton ButtonOpenFilePath;
        private SimpleButton ButtonNewScreenshot;
    }
}