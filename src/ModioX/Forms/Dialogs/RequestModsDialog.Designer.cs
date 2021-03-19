using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs
{
    partial class RequestModsDialog
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
            this.LabelVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelCreators = new DevExpress.XtraEditors.LabelControl();
            this.LabelGameCategory = new DevExpress.XtraEditors.LabelControl();
            this.LabelModName = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxModName = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxGameCategory = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxCreators = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxVersion = new DevExpress.XtraEditors.TextEdit();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.LabelSourceLink = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxSourceLinks = new DevExpress.XtraEditors.MemoEdit();
            this.TextBoxSystemType = new DevExpress.XtraEditors.TextEdit();
            this.LabelSystemType = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxDescription = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxModName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCreators.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSourceLinks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSystemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelVersion
            // 
            this.LabelVersion.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelVersion.Appearance.Options.UseForeColor = true;
            this.LabelVersion.Location = new System.Drawing.Point(218, 104);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(42, 13);
            this.LabelVersion.TabIndex = 7;
            this.LabelVersion.Text = "Version:";
            // 
            // LabelCreators
            // 
            this.LabelCreators.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelCreators.Appearance.Options.UseForeColor = true;
            this.LabelCreators.Location = new System.Drawing.Point(12, 104);
            this.LabelCreators.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelCreators.Name = "LabelCreators";
            this.LabelCreators.Size = new System.Drawing.Size(52, 13);
            this.LabelCreators.TabIndex = 9;
            this.LabelCreators.Text = "Creator(s):";
            // 
            // LabelGameCategory
            // 
            this.LabelGameCategory.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameCategory.Appearance.Options.UseForeColor = true;
            this.LabelGameCategory.Location = new System.Drawing.Point(12, 58);
            this.LabelGameCategory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelGameCategory.Name = "LabelGameCategory";
            this.LabelGameCategory.Size = new System.Drawing.Size(82, 13);
            this.LabelGameCategory.TabIndex = 12;
            this.LabelGameCategory.Text = "Game/Category:";
            // 
            // LabelModName
            // 
            this.LabelModName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelModName.Appearance.Options.UseForeColor = true;
            this.LabelModName.Location = new System.Drawing.Point(12, 12);
            this.LabelModName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelModName.Name = "LabelModName";
            this.LabelModName.Size = new System.Drawing.Size(59, 13);
            this.LabelModName.TabIndex = 14;
            this.LabelModName.Text = "Mod Name:";
            // 
            // TextBoxModName
            // 
            this.TextBoxModName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxModName.Location = new System.Drawing.Point(12, 30);
            this.TextBoxModName.Name = "TextBoxModName";
            this.TextBoxModName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxModName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxModName.Size = new System.Drawing.Size(184, 22);
            this.TextBoxModName.TabIndex = 0;
            // 
            // TextBoxGameCategory
            // 
            this.TextBoxGameCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGameCategory.Location = new System.Drawing.Point(12, 76);
            this.TextBoxGameCategory.Name = "TextBoxGameCategory";
            this.TextBoxGameCategory.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxGameCategory.Properties.Appearance.Options.UseFont = true;
            this.TextBoxGameCategory.Size = new System.Drawing.Size(299, 22);
            this.TextBoxGameCategory.TabIndex = 2;
            // 
            // TextBoxCreators
            // 
            this.TextBoxCreators.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCreators.Location = new System.Drawing.Point(12, 122);
            this.TextBoxCreators.Name = "TextBoxCreators";
            this.TextBoxCreators.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxCreators.Properties.Appearance.Options.UseFont = true;
            this.TextBoxCreators.Size = new System.Drawing.Size(200, 22);
            this.TextBoxCreators.TabIndex = 3;
            // 
            // TextBoxVersion
            // 
            this.TextBoxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxVersion.Location = new System.Drawing.Point(218, 122);
            this.TextBoxVersion.Name = "TextBoxVersion";
            this.TextBoxVersion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxVersion.Properties.Appearance.Options.UseFont = true;
            this.TextBoxVersion.Size = new System.Drawing.Size(93, 22);
            this.TextBoxVersion.TabIndex = 4;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(236, 316);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Location = new System.Drawing.Point(155, 316);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 7;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // LabelSourceLink
            // 
            this.LabelSourceLink.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelSourceLink.Appearance.Options.UseForeColor = true;
            this.LabelSourceLink.Location = new System.Drawing.Point(12, 239);
            this.LabelSourceLink.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSourceLink.Name = "LabelSourceLink";
            this.LabelSourceLink.Size = new System.Drawing.Size(67, 13);
            this.LabelSourceLink.TabIndex = 16;
            this.LabelSourceLink.Text = "Source Links:";
            // 
            // TextBoxSourceLinks
            // 
            this.TextBoxSourceLinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSourceLinks.EditValue = "";
            this.TextBoxSourceLinks.Location = new System.Drawing.Point(12, 257);
            this.TextBoxSourceLinks.Name = "TextBoxSourceLinks";
            this.TextBoxSourceLinks.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSourceLinks.Properties.Appearance.Options.UseFont = true;
            this.TextBoxSourceLinks.Size = new System.Drawing.Size(299, 37);
            this.TextBoxSourceLinks.TabIndex = 6;
            // 
            // TextBoxSystemType
            // 
            this.TextBoxSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSystemType.Location = new System.Drawing.Point(202, 30);
            this.TextBoxSystemType.Name = "TextBoxSystemType";
            this.TextBoxSystemType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSystemType.Properties.Appearance.Options.UseFont = true;
            this.TextBoxSystemType.Size = new System.Drawing.Size(109, 22);
            this.TextBoxSystemType.TabIndex = 1;
            // 
            // LabelSystemType
            // 
            this.LabelSystemType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelSystemType.Appearance.Options.UseForeColor = true;
            this.LabelSystemType.Location = new System.Drawing.Point(202, 12);
            this.LabelSystemType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSystemType.Name = "LabelSystemType";
            this.LabelSystemType.Size = new System.Drawing.Size(65, 13);
            this.LabelSystemType.TabIndex = 18;
            this.LabelSystemType.Text = "System Type:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 150);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Description:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescription.EditValue = "";
            this.TextBoxDescription.Location = new System.Drawing.Point(12, 168);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDescription.Properties.Appearance.Options.UseFont = true;
            this.TextBoxDescription.Size = new System.Drawing.Size(299, 65);
            this.TextBoxDescription.TabIndex = 5;
            // 
            // RequestModsDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(323, 351);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxSystemType);
            this.Controls.Add(this.LabelSystemType);
            this.Controls.Add(this.LabelSourceLink);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextBoxVersion);
            this.Controls.Add(this.TextBoxCreators);
            this.Controls.Add(this.TextBoxGameCategory);
            this.Controls.Add(this.TextBoxModName);
            this.Controls.Add(this.LabelCreators);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelGameCategory);
            this.Controls.Add(this.LabelModName);
            this.Controls.Add(this.TextBoxSourceLinks);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequestModsDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Request Mods";
            this.Load += new System.EventHandler(this.RequestModsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxModName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCreators.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSourceLinks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSystemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelVersion;
        private LabelControl LabelCreators;
        private LabelControl LabelGameCategory;
        private LabelControl LabelModName;
        private TextEdit TextBoxModName;
        private TextEdit TextBoxGameCategory;
        private TextEdit TextBoxCreators;
        private TextEdit TextBoxVersion;
        private SimpleButton ButtonCancel;
        private SimpleButton ButtonOK;
        private LabelControl LabelSourceLink;
        private MemoEdit TextBoxSourceLinks;
        private TextEdit TextBoxSystemType;
        private LabelControl LabelSystemType;
        private LabelControl labelControl1;
        private MemoEdit TextBoxDescription;
    }
}