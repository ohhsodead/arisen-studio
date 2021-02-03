using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs
{
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LabelInformation = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.LabelSpecialThanks = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.LabelLicense = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.LabelCredits = new DevExpress.XtraEditors.LabelControl();
            this.ButtonClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LabelInformation);
            this.groupControl1.Location = new System.Drawing.Point(14, 10);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(3);
            this.groupControl1.Size = new System.Drawing.Size(585, 102);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "INFORMATION";
            // 
            // LabelInformation
            // 
            this.LabelInformation.AllowHtmlString = true;
            this.LabelInformation.Appearance.Options.UseTextOptions = true;
            this.LabelInformation.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelInformation.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelInformation.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelInformation.Location = new System.Drawing.Point(5, 26);
            this.LabelInformation.Name = "LabelInformation";
            this.LabelInformation.Padding = new System.Windows.Forms.Padding(3);
            this.LabelInformation.Size = new System.Drawing.Size(575, 71);
            this.LabelInformation.TabIndex = 19;
            this.LabelInformation.Text = resources.GetString("LabelInformation.Text");
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.LabelSpecialThanks);
            this.groupControl2.Location = new System.Drawing.Point(310, 122);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(3);
            this.groupControl2.Size = new System.Drawing.Size(289, 130);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "SPECIAL THANKS";
            // 
            // LabelSpecialThanks
            // 
            this.LabelSpecialThanks.AllowHtmlString = true;
            this.LabelSpecialThanks.Appearance.Options.UseTextOptions = true;
            this.LabelSpecialThanks.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelSpecialThanks.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelSpecialThanks.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelSpecialThanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelSpecialThanks.Location = new System.Drawing.Point(5, 26);
            this.LabelSpecialThanks.Name = "LabelSpecialThanks";
            this.LabelSpecialThanks.Padding = new System.Windows.Forms.Padding(3);
            this.LabelSpecialThanks.Size = new System.Drawing.Size(279, 99);
            this.LabelSpecialThanks.TabIndex = 18;
            this.LabelSpecialThanks.Text = resources.GetString("LabelSpecialThanks.Text");
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.LabelLicense);
            this.groupControl3.Location = new System.Drawing.Point(14, 262);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Padding = new System.Windows.Forms.Padding(3);
            this.groupControl3.Size = new System.Drawing.Size(585, 171);
            this.groupControl3.TabIndex = 14;
            this.groupControl3.Text = "LICENSE";
            // 
            // LabelLicense
            // 
            this.LabelLicense.AllowHtmlString = true;
            this.LabelLicense.Appearance.Options.UseTextOptions = true;
            this.LabelLicense.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelLicense.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelLicense.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelLicense.Location = new System.Drawing.Point(5, 26);
            this.LabelLicense.Name = "LabelLicense";
            this.LabelLicense.Padding = new System.Windows.Forms.Padding(3);
            this.LabelLicense.Size = new System.Drawing.Size(575, 140);
            this.LabelLicense.TabIndex = 18;
            this.LabelLicense.Text = resources.GetString("LabelLicense.Text");
            this.LabelLicense.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.LabelLicense_HyperlinkClick);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.LabelCredits);
            this.groupControl4.Location = new System.Drawing.Point(14, 122);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Padding = new System.Windows.Forms.Padding(3);
            this.groupControl4.Size = new System.Drawing.Size(286, 130);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "CREDITS";
            // 
            // LabelCredits
            // 
            this.LabelCredits.AllowHtmlString = true;
            this.LabelCredits.Appearance.Options.UseTextOptions = true;
            this.LabelCredits.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelCredits.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelCredits.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCredits.Location = new System.Drawing.Point(5, 26);
            this.LabelCredits.Name = "LabelCredits";
            this.LabelCredits.Padding = new System.Windows.Forms.Padding(3);
            this.LabelCredits.Size = new System.Drawing.Size(276, 99);
            this.LabelCredits.TabIndex = 17;
            this.LabelCredits.Text = "Developer: ohhsodead\r\nContributor: KayGart\r\nContributor: TeddyHammer\r\n\r\n\r\nWebsite" +
    ":\r\n<href=\\\"https://github.com/ohhsodead/ModioX /\\\">https://github.com/ohhsodead/" +
    "ModioX ";
            this.LabelCredits.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.LabelCredits_HyperlinkClick);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonClose.Location = new System.Drawing.Point(270, 476);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonClose.Size = new System.Drawing.Size(74, 24);
            this.ButtonClose.TabIndex = 15;
            this.ButtonClose.Text = "OK";
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AboutDialog
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(615, 512);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("AboutDialog.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupControl groupControl1;
        private GroupControl groupControl2;
        private GroupControl groupControl3;
        private GroupControl groupControl4;
        private SimpleButton ButtonClose;
        private LabelControl LabelCredits;
        private LabelControl LabelInformation;
        private LabelControl LabelSpecialThanks;
        private LabelControl LabelLicense;
    }
}