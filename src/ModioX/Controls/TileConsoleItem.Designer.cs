
namespace ModioX.Controls
{
    partial class TileConsoleItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelConsoleName = new DevExpress.XtraEditors.LabelControl();
            this.ImageConsole = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageConsole.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelConsoleName
            // 
            this.LabelConsoleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelConsoleName.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LabelConsoleName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelConsoleName.Appearance.Options.UseBackColor = true;
            this.LabelConsoleName.Appearance.Options.UseFont = true;
            this.LabelConsoleName.Appearance.Options.UseTextOptions = true;
            this.LabelConsoleName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LabelConsoleName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelConsoleName.AutoEllipsis = true;
            this.LabelConsoleName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelConsoleName.Location = new System.Drawing.Point(3, 142);
            this.LabelConsoleName.Name = "LabelConsoleName";
            this.LabelConsoleName.Size = new System.Drawing.Size(138, 16);
            this.LabelConsoleName.TabIndex = 1;
            this.LabelConsoleName.Text = "Console Name";
            // 
            // ImageConsole
            // 
            this.ImageConsole.Location = new System.Drawing.Point(4, 4);
            this.ImageConsole.Name = "ImageConsole";
            this.ImageConsole.Properties.AllowFocused = false;
            this.ImageConsole.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ImageConsole.Properties.Appearance.Options.UseBackColor = true;
            this.ImageConsole.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageConsole.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageConsole.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageConsole.Size = new System.Drawing.Size(135, 135);
            this.ImageConsole.TabIndex = 0;
            // 
            // TileConsoleItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelConsoleName);
            this.Controls.Add(this.ImageConsole);
            this.Name = "TileConsoleItem";
            this.Size = new System.Drawing.Size(144, 162);
            ((System.ComponentModel.ISupportInitialize)(this.ImageConsole.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PictureEdit ImageConsole;
        public DevExpress.XtraEditors.LabelControl LabelConsoleName;
    }
}
