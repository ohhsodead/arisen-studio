
using System.ComponentModel;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ArisenStudio.Forms.Tools.XBOX
{
    partial class XboxHDKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XboxHDKey));
            this.ButtonSaveFile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonImportFromFile = new DevExpress.XtraEditors.SimpleButton();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.TextBoxConsoleSerial = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxMotherboardSerial = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxXboxHDKey = new DevExpress.XtraEditors.TextEdit();
            this.LabelHeaderIPAddress = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LabelXboxHDKey = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsoleSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMotherboardSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxXboxHDKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSaveFile
            // 
            this.ButtonSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSaveFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSaveFile.Appearance.Options.UseFont = true;
            this.ButtonSaveFile.AutoSize = true;
            this.ButtonSaveFile.Enabled = false;
            this.ButtonSaveFile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonSaveFile.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonSaveFile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonSaveFile.ImageOptions.SvgImage")));
            this.ButtonSaveFile.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonSaveFile.Location = new System.Drawing.Point(153, 0);
            this.ButtonSaveFile.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonSaveFile.Name = "ButtonSaveFile";
            this.ButtonSaveFile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonSaveFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSaveFile.Size = new System.Drawing.Size(91, 24);
            this.ButtonSaveFile.TabIndex = 1;
            this.ButtonSaveFile.Text = "Save File";
            this.ButtonSaveFile.Click += new System.EventHandler(this.ButtonSaveFile_Click);
            // 
            // ButtonImportFromFile
            // 
            this.ButtonImportFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonImportFromFile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonImportFromFile.Appearance.Options.UseFont = true;
            this.ButtonImportFromFile.AutoSize = true;
            this.ButtonImportFromFile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonImportFromFile.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ButtonImportFromFile.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.import1;
            this.ButtonImportFromFile.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonImportFromFile.Location = new System.Drawing.Point(0, 0);
            this.ButtonImportFromFile.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonImportFromFile.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonImportFromFile.Name = "ButtonImportFromFile";
            this.ButtonImportFromFile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ButtonImportFromFile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonImportFromFile.Size = new System.Drawing.Size(147, 24);
            this.ButtonImportFromFile.TabIndex = 0;
            this.ButtonImportFromFile.Text = "Import from KV file";
            this.ButtonImportFromFile.Click += new System.EventHandler(this.ButtonImportFromFile_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonImportFromFile);
            this.PanelButtons.Controls.Add(this.ButtonSaveFile);
            this.PanelButtons.Location = new System.Drawing.Point(12, 175);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(496, 24);
            this.PanelButtons.TabIndex = 3;
            // 
            // TextBoxConsoleSerial
            // 
            this.TextBoxConsoleSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConsoleSerial.Location = new System.Drawing.Point(12, 33);
            this.TextBoxConsoleSerial.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.TextBoxConsoleSerial.Name = "TextBoxConsoleSerial";
            this.TextBoxConsoleSerial.Properties.AllowFocused = false;
            this.TextBoxConsoleSerial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConsoleSerial.Properties.Appearance.Options.UseFont = true;
            this.TextBoxConsoleSerial.Properties.MaxLength = 12;
            this.TextBoxConsoleSerial.Size = new System.Drawing.Size(496, 24);
            this.TextBoxConsoleSerial.TabIndex = 3;
            this.TextBoxConsoleSerial.TextChanged += new System.EventHandler(this.TextBoxConsoleSerial_TextChanged);
            // 
            // TextBoxMotherboardSerial
            // 
            this.TextBoxMotherboardSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMotherboardSerial.Location = new System.Drawing.Point(12, 86);
            this.TextBoxMotherboardSerial.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.TextBoxMotherboardSerial.Name = "TextBoxMotherboardSerial";
            this.TextBoxMotherboardSerial.Properties.AllowFocused = false;
            this.TextBoxMotherboardSerial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxMotherboardSerial.Properties.Appearance.Options.UseFont = true;
            this.TextBoxMotherboardSerial.Properties.MaxLength = 16;
            this.TextBoxMotherboardSerial.Size = new System.Drawing.Size(496, 24);
            this.TextBoxMotherboardSerial.TabIndex = 4;
            this.TextBoxMotherboardSerial.TextChanged += new System.EventHandler(this.TextBoxMotherboardSerial_TextChanged);
            // 
            // TextBoxXboxHDKey
            // 
            this.TextBoxXboxHDKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxXboxHDKey.Location = new System.Drawing.Point(12, 141);
            this.TextBoxXboxHDKey.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.TextBoxXboxHDKey.Name = "TextBoxXboxHDKey";
            this.TextBoxXboxHDKey.Properties.AllowFocused = false;
            this.TextBoxXboxHDKey.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxXboxHDKey.Properties.Appearance.Options.UseFont = true;
            this.TextBoxXboxHDKey.Size = new System.Drawing.Size(496, 24);
            this.TextBoxXboxHDKey.TabIndex = 5;
            // 
            // LabelHeaderIPAddress
            // 
            this.LabelHeaderIPAddress.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderIPAddress.Appearance.Options.UseFont = true;
            this.LabelHeaderIPAddress.Location = new System.Drawing.Point(12, 12);
            this.LabelHeaderIPAddress.Name = "LabelHeaderIPAddress";
            this.LabelHeaderIPAddress.Size = new System.Drawing.Size(216, 15);
            this.LabelHeaderIPAddress.TabIndex = 1188;
            this.LabelHeaderIPAddress.Text = "Console Serial Number (12 digit number)";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(326, 15);
            this.labelControl1.TabIndex = 1189;
            this.labelControl1.Text = "Motherboard Serial Number (16 character hexadecimal string)";
            // 
            // LabelXboxHDKey
            // 
            this.LabelXboxHDKey.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelXboxHDKey.Appearance.Options.UseFont = true;
            this.LabelXboxHDKey.Location = new System.Drawing.Point(12, 118);
            this.LabelXboxHDKey.Name = "LabelXboxHDKey";
            this.LabelXboxHDKey.Size = new System.Drawing.Size(63, 15);
            this.LabelXboxHDKey.TabIndex = 1190;
            this.LabelXboxHDKey.Text = "XboxHDKey";
            // 
            // XboxHDKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(520, 211);
            this.Controls.Add(this.LabelXboxHDKey);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.LabelHeaderIPAddress);
            this.Controls.Add(this.TextBoxXboxHDKey);
            this.Controls.Add(this.TextBoxMotherboardSerial);
            this.Controls.Add(this.TextBoxConsoleSerial);
            this.Controls.Add(this.PanelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XboxHDKey";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XboxHDKey";
            this.Load += new System.EventHandler(this.XboxHDKey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsoleSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMotherboardSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxXboxHDKey.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SimpleButton ButtonImportFromFile;
        private SimpleButton ButtonSaveFile;
        private StackPanel PanelButtons;
        private TextEdit TextBoxConsoleSerial;
        private TextEdit TextBoxMotherboardSerial;
        private TextEdit TextBoxXboxHDKey;
        private LabelControl LabelHeaderIPAddress;
        private LabelControl labelControl1;
        private LabelControl LabelXboxHDKey;
    }
}