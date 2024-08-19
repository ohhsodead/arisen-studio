using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Dialogs
{
    partial class NewProfileDialog
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
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.LabelAddress = new DevExpress.XtraEditors.LabelControl();
            this.ButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonChangeLoginDetails = new DevExpress.XtraEditors.SimpleButton();
            this.LabelPlatformType = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxPlatform = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TextBoxAddress = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxProfileName = new DevExpress.XtraEditors.TextEdit();
            this.CheckBoxDefaultLogin = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxDefaultProfile = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxGoldHEN = new DevExpress.XtraEditors.CheckEdit();
            this.LabelLoginDetails = new DevExpress.XtraEditors.LabelControl();
            this.CheckBoxPassiveMode = new DevExpress.XtraEditors.CheckEdit();
            this.LabelOptions = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPlatform.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxProfileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxDefaultLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxDefaultProfile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxGoldHEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxPassiveMode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.Location = new System.Drawing.Point(12, 16);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(72, 15);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Profile Name:";
            // 
            // LabelAddress
            // 
            this.LabelAddress.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelAddress.Appearance.Options.UseFont = true;
            this.LabelAddress.Location = new System.Drawing.Point(12, 88);
            this.LabelAddress.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(58, 15);
            this.LabelAddress.TabIndex = 14;
            this.LabelAddress.Text = "IP Address:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Location = new System.Drawing.Point(330, 301);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSave.Size = new System.Drawing.Size(80, 24);
            this.ButtonSave.TabIndex = 9;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(240, 301);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(80, 24);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Cancel";
            // 
            // ButtonChangeLoginDetails
            // 
            this.ButtonChangeLoginDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonChangeLoginDetails.Location = new System.Drawing.Point(330, 120);
            this.ButtonChangeLoginDetails.Name = "ButtonChangeLoginDetails";
            this.ButtonChangeLoginDetails.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonChangeLoginDetails.Size = new System.Drawing.Size(80, 24);
            this.ButtonChangeLoginDetails.TabIndex = 4;
            this.ButtonChangeLoginDetails.Text = "Change";
            this.ButtonChangeLoginDetails.Click += new System.EventHandler(this.ButtonChangeCredentials_Click);
            // 
            // LabelPlatformType
            // 
            this.LabelPlatformType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelPlatformType.Appearance.Options.UseFont = true;
            this.LabelPlatformType.Location = new System.Drawing.Point(12, 52);
            this.LabelPlatformType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelPlatformType.Name = "LabelPlatformType";
            this.LabelPlatformType.Size = new System.Drawing.Size(77, 15);
            this.LabelPlatformType.TabIndex = 1146;
            this.LabelPlatformType.Text = "Platform Type:";
            // 
            // ComboBoxPlatform
            // 
            this.ComboBoxPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPlatform.EditValue = "";
            this.ComboBoxPlatform.Location = new System.Drawing.Point(126, 48);
            this.ComboBoxPlatform.Name = "ComboBoxPlatform";
            this.ComboBoxPlatform.Properties.AllowFocused = false;
            this.ComboBoxPlatform.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxPlatform.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPlatform.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPlatform.Properties.DropDownRows = 9;
            this.ComboBoxPlatform.Properties.Items.AddRange(new object[] {
            "PlayStation 3 (Fat)",
            "PlayStation 3 (Slim)",
            "PlayStation 3 (Super Slim)",
            "PlayStation 4 (All Models)",
            "Xbox 360 (Fat/White)",
            "Xbox 360 Elite (Fat/Black)",
            "Xbox 360 S (Slim)",
            "Xbox 360 E (Slim E)"});
            this.ComboBoxPlatform.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxPlatform.Size = new System.Drawing.Size(284, 24);
            this.ComboBoxPlatform.TabIndex = 1;
            this.ComboBoxPlatform.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPlatformType_SelectedIndexChanged);
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAddress.Location = new System.Drawing.Point(126, 84);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAddress.Properties.Appearance.Options.UseFont = true;
            this.TextBoxAddress.Size = new System.Drawing.Size(284, 24);
            this.TextBoxAddress.TabIndex = 2;
            // 
            // TextBoxProfileName
            // 
            this.TextBoxProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxProfileName.Location = new System.Drawing.Point(126, 12);
            this.TextBoxProfileName.Name = "TextBoxProfileName";
            this.TextBoxProfileName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxProfileName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxProfileName.Size = new System.Drawing.Size(284, 24);
            this.TextBoxProfileName.TabIndex = 0;
            // 
            // CheckBoxDefaultLogin
            // 
            this.CheckBoxDefaultLogin.Location = new System.Drawing.Point(126, 122);
            this.CheckBoxDefaultLogin.Name = "CheckBoxDefaultLogin";
            this.CheckBoxDefaultLogin.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxDefaultLogin.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxDefaultLogin.Properties.AutoWidth = true;
            this.CheckBoxDefaultLogin.Properties.Caption = "Default Credentials";
            this.CheckBoxDefaultLogin.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.CheckBoxDefaultLogin_Properties_EditValueChanging);
            this.CheckBoxDefaultLogin.Size = new System.Drawing.Size(124, 20);
            this.CheckBoxDefaultLogin.TabIndex = 3;
            this.CheckBoxDefaultLogin.Visible = false;
            this.CheckBoxDefaultLogin.CheckStateChanged += new System.EventHandler(this.CheckBoxDefaultLogin_CheckStateChanged);
            // 
            // CheckBoxDefaultProfile
            // 
            this.CheckBoxDefaultProfile.Location = new System.Drawing.Point(126, 158);
            this.CheckBoxDefaultProfile.Name = "CheckBoxDefaultProfile";
            this.CheckBoxDefaultProfile.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxDefaultProfile.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxDefaultProfile.Properties.AutoWidth = true;
            this.CheckBoxDefaultProfile.Properties.Caption = "Default Profile";
            this.CheckBoxDefaultProfile.Size = new System.Drawing.Size(99, 20);
            this.CheckBoxDefaultProfile.TabIndex = 7;
            this.CheckBoxDefaultProfile.CheckStateChanged += new System.EventHandler(this.CheckBoxDefaultProfile_CheckStateChanged);
            this.CheckBoxDefaultProfile.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.CheckBoxDefaultProfile_EditValueChanging);
            // 
            // CheckBoxGoldHEN
            // 
            this.CheckBoxGoldHEN.Location = new System.Drawing.Point(126, 230);
            this.CheckBoxGoldHEN.Name = "CheckBoxGoldHEN";
            this.CheckBoxGoldHEN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxGoldHEN.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxGoldHEN.Properties.AutoWidth = true;
            this.CheckBoxGoldHEN.Properties.Caption = "GoldHEN";
            this.CheckBoxGoldHEN.Size = new System.Drawing.Size(73, 20);
            this.CheckBoxGoldHEN.TabIndex = 6;
            this.CheckBoxGoldHEN.CheckStateChanged += new System.EventHandler(this.CheckBoxGoldHEN_CheckStateChanged);
            // 
            // LabelLoginDetails
            // 
            this.LabelLoginDetails.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLoginDetails.Appearance.Options.UseFont = true;
            this.LabelLoginDetails.Location = new System.Drawing.Point(12, 124);
            this.LabelLoginDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelLoginDetails.Name = "LabelLoginDetails";
            this.LabelLoginDetails.Size = new System.Drawing.Size(71, 15);
            this.LabelLoginDetails.TabIndex = 1147;
            this.LabelLoginDetails.Text = "Login Details:";
            // 
            // CheckBoxPassiveMode
            // 
            this.CheckBoxPassiveMode.Location = new System.Drawing.Point(126, 194);
            this.CheckBoxPassiveMode.Name = "CheckBoxPassiveMode";
            this.CheckBoxPassiveMode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxPassiveMode.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxPassiveMode.Properties.AutoWidth = true;
            this.CheckBoxPassiveMode.Properties.Caption = "Passive Mode";
            this.CheckBoxPassiveMode.Size = new System.Drawing.Size(96, 20);
            this.CheckBoxPassiveMode.TabIndex = 5;
            this.CheckBoxPassiveMode.CheckStateChanged += new System.EventHandler(this.CheckBoxPassiveMode_CheckStateChanged);
            // 
            // LabelOptions
            // 
            this.LabelOptions.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelOptions.Appearance.Options.UseFont = true;
            this.LabelOptions.Location = new System.Drawing.Point(12, 160);
            this.LabelOptions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelOptions.Name = "LabelOptions";
            this.LabelOptions.Size = new System.Drawing.Size(45, 15);
            this.LabelOptions.TabIndex = 1153;
            this.LabelOptions.Text = "Options:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 196);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 15);
            this.labelControl2.TabIndex = 1154;
            this.labelControl2.Text = "Login Details:";
            this.labelControl2.Visible = false;
            // 
            // NewProfileDialog
            // 
            this.AcceptButton = this.ButtonSave;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(422, 337);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.LabelOptions);
            this.Controls.Add(this.CheckBoxPassiveMode);
            this.Controls.Add(this.LabelLoginDetails);
            this.Controls.Add(this.CheckBoxGoldHEN);
            this.Controls.Add(this.CheckBoxDefaultProfile);
            this.Controls.Add(this.ComboBoxPlatform);
            this.Controls.Add(this.LabelPlatformType);
            this.Controls.Add(this.ButtonChangeLoginDetails);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxProfileName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.CheckBoxDefaultLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProfileDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile Details";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.NewProfileDialog_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewProfileDialog_FormClosing);
            this.Load += new System.EventHandler(this.NewProfileDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPlatform.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxProfileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxDefaultLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxDefaultProfile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxGoldHEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxPassiveMode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelName;
        private LabelControl LabelAddress;
        private TextEdit TextBoxProfileName;
        private TextEdit TextBoxAddress;
        private SimpleButton ButtonSave;
        private SimpleButton ButtonCancel;
        private SimpleButton ButtonChangeLoginDetails;
        private LabelControl LabelPlatformType;
        private ComboBoxEdit ComboBoxPlatform;
        private CheckEdit CheckBoxDefaultLogin;
        private CheckEdit CheckBoxDefaultProfile;
        private CheckEdit CheckBoxGoldHEN;
        private LabelControl LabelLoginDetails;
        private CheckEdit CheckBoxPassiveMode;
        private LabelControl LabelOptions;
        private LabelControl labelControl2;
    }
}