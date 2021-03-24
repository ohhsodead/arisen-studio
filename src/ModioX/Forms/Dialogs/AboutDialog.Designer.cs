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
            this.GroupInformation = new DevExpress.XtraEditors.GroupControl();
            this.LabelInformation = new DevExpress.XtraEditors.LabelControl();
            this.GroupSpecialThanks = new DevExpress.XtraEditors.GroupControl();
            this.LabelSpecialThanks = new DevExpress.XtraEditors.LabelControl();
            this.GroupLicense = new DevExpress.XtraEditors.GroupControl();
            this.LabelLicense = new DevExpress.XtraEditors.LabelControl();
            this.GroupCredits = new DevExpress.XtraEditors.GroupControl();
            this.LabelCredits = new DevExpress.XtraEditors.LabelControl();
            this.ButtonClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupInformation)).BeginInit();
            this.GroupInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupSpecialThanks)).BeginInit();
            this.GroupSpecialThanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupLicense)).BeginInit();
            this.GroupLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCredits)).BeginInit();
            this.GroupCredits.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupInformation
            // 
            this.GroupInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupInformation.Controls.Add(this.LabelInformation);
            this.GroupInformation.Location = new System.Drawing.Point(14, 14);
            this.GroupInformation.Margin = new System.Windows.Forms.Padding(5);
            this.GroupInformation.Name = "GroupInformation";
            this.GroupInformation.Padding = new System.Windows.Forms.Padding(3);
            this.GroupInformation.Size = new System.Drawing.Size(500, 105);
            this.GroupInformation.TabIndex = 2;
            this.GroupInformation.Text = "INFORMATION";
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
            this.LabelInformation.Size = new System.Drawing.Size(490, 74);
            this.LabelInformation.TabIndex = 19;
            this.LabelInformation.Text = resources.GetString("LabelInformation.Text");
            // 
            // GroupSpecialThanks
            // 
            this.GroupSpecialThanks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupSpecialThanks.Controls.Add(this.LabelSpecialThanks);
            this.GroupSpecialThanks.Location = new System.Drawing.Point(268, 127);
            this.GroupSpecialThanks.Name = "GroupSpecialThanks";
            this.GroupSpecialThanks.Padding = new System.Windows.Forms.Padding(3);
            this.GroupSpecialThanks.Size = new System.Drawing.Size(246, 131);
            this.GroupSpecialThanks.TabIndex = 4;
            this.GroupSpecialThanks.Text = "SPECIAL THANKS";
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
            this.LabelSpecialThanks.Size = new System.Drawing.Size(236, 100);
            this.LabelSpecialThanks.TabIndex = 18;
            this.LabelSpecialThanks.Text = resources.GetString("LabelSpecialThanks.Text");
            // 
            // GroupLicense
            // 
            this.GroupLicense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupLicense.Controls.Add(this.LabelLicense);
            this.GroupLicense.Location = new System.Drawing.Point(14, 268);
            this.GroupLicense.Margin = new System.Windows.Forms.Padding(5);
            this.GroupLicense.Name = "GroupLicense";
            this.GroupLicense.Padding = new System.Windows.Forms.Padding(3);
            this.GroupLicense.Size = new System.Drawing.Size(500, 171);
            this.GroupLicense.TabIndex = 14;
            this.GroupLicense.Text = "LICENSE";
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
            this.LabelLicense.Size = new System.Drawing.Size(490, 140);
            this.LabelLicense.TabIndex = 18;
            this.LabelLicense.Text = resources.GetString("LabelLicense.Text");
            this.LabelLicense.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.LabelLicense_HyperlinkClick);
            // 
            // GroupCredits
            // 
            this.GroupCredits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupCredits.Controls.Add(this.LabelCredits);
            this.GroupCredits.Location = new System.Drawing.Point(14, 127);
            this.GroupCredits.Margin = new System.Windows.Forms.Padding(5);
            this.GroupCredits.Name = "GroupCredits";
            this.GroupCredits.Padding = new System.Windows.Forms.Padding(3);
            this.GroupCredits.Size = new System.Drawing.Size(246, 131);
            this.GroupCredits.TabIndex = 4;
            this.GroupCredits.Text = "CREDITS";
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
            this.LabelCredits.Size = new System.Drawing.Size(236, 100);
            this.LabelCredits.TabIndex = 17;
            this.LabelCredits.Text = "Developer: ohhsodead\r\nContributor: KayGart\r\nContributor: TeddyHammer\r\nContributor" +
    ": Doregon\r\n\r\nWebsite:\r\n<href=\\\"https://github.com/ohhsodead/ModioX /\\\">https://g" +
    "ithub.com/ohhsodead/ModioX ";
            this.LabelCredits.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.LabelCredits_HyperlinkClick);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonClose.Location = new System.Drawing.Point(228, 466);
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
            this.ClientSize = new System.Drawing.Size(530, 502);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.GroupCredits);
            this.Controls.Add(this.GroupLicense);
            this.Controls.Add(this.GroupSpecialThanks);
            this.Controls.Add(this.GroupInformation);
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
            ((System.ComponentModel.ISupportInitialize)(this.GroupInformation)).EndInit();
            this.GroupInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupSpecialThanks)).EndInit();
            this.GroupSpecialThanks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupLicense)).EndInit();
            this.GroupLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupCredits)).EndInit();
            this.GroupCredits.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupControl GroupInformation;
        private GroupControl GroupSpecialThanks;
        private GroupControl GroupLicense;
        private GroupControl GroupCredits;
        private SimpleButton ButtonClose;
        private LabelControl LabelCredits;
        private LabelControl LabelInformation;
        private LabelControl LabelSpecialThanks;
        private LabelControl LabelLicense;
    }
}