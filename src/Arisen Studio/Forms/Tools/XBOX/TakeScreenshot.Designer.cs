
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
            this.ButtonRefreshModules = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
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
            // ButtonRefreshModules
            // 
            this.ButtonRefreshModules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonRefreshModules.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonRefreshModules.Appearance.Options.UseFont = true;
            this.ButtonRefreshModules.AutoSize = true;
            this.ButtonRefreshModules.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonRefreshModules.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonRefreshModules.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.check;
            this.ButtonRefreshModules.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonRefreshModules.Location = new System.Drawing.Point(88, 0);
            this.ButtonRefreshModules.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonRefreshModules.Name = "ButtonRefreshModules";
            this.ButtonRefreshModules.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonRefreshModules.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonRefreshModules.Size = new System.Drawing.Size(131, 24);
            this.ButtonRefreshModules.TabIndex = 9;
            this.ButtonRefreshModules.Text = "Take Screenshot";
            this.ButtonRefreshModules.Click += new System.EventHandler(this.ButtonTakeScreenshot_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCancel.Appearance.Options.UseFont = true;
            this.ButtonCancel.AutoSize = true;
            this.ButtonCancel.Enabled = false;
            this.ButtonCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonCancel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonCancel.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.actions_forbid;
            this.ButtonCancel.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonCancel.Location = new System.Drawing.Point(0, 0);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonCancel.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(82, 24);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonCancel);
            this.PanelButtons.Controls.Add(this.ButtonRefreshModules);
            this.PanelButtons.Location = new System.Drawing.Point(12, 350);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(496, 24);
            this.PanelButtons.TabIndex = 1182;
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
            this.TextBoxFileName.Properties.NullValuePrompt = "Screenshot File Name...";
            this.TextBoxFileName.Size = new System.Drawing.Size(496, 22);
            this.TextBoxFileName.TabIndex = 1183;
            // 
            // ImageScreenshot
            // 
            this.ImageScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageScreenshot.Location = new System.Drawing.Point(12, 65);
            this.ImageScreenshot.Name = "ImageScreenshot";
            this.ImageScreenshot.Size = new System.Drawing.Size(496, 279);
            this.ImageScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageScreenshot.TabIndex = 1184;
            this.ImageScreenshot.TabStop = false;
            // 
            // CheckBoxUploadToImgur
            // 
            this.CheckBoxUploadToImgur.Location = new System.Drawing.Point(11, 40);
            this.CheckBoxUploadToImgur.Name = "CheckBoxUploadToImgur";
            this.CheckBoxUploadToImgur.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxUploadToImgur.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxUploadToImgur.Properties.AutoWidth = true;
            this.CheckBoxUploadToImgur.Properties.Caption = "Upload to Imgur";
            this.CheckBoxUploadToImgur.Size = new System.Drawing.Size(109, 19);
            this.CheckBoxUploadToImgur.TabIndex = 1185;
            this.CheckBoxUploadToImgur.ToolTip = "if set to true, this will block the console from resolving LIVE related dns\r\nif n" +
    "ot set this value will be TRUE";
            // 
            // TakeScreenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private SimpleButton ButtonCancel;
        private SimpleButton ButtonRefreshModules;
        private StackPanel PanelButtons;
        private TextEdit TextBoxFileName;
        private System.Windows.Forms.PictureBox ImageScreenshot;
        private CheckEdit CheckBoxUploadToImgur;
    }
}