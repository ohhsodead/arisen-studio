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
            this.ButtonEditLoginDetails = new DevExpress.XtraEditors.SimpleButton();
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
            this.GroupBoxProfileInfo = new DevExpress.XtraEditors.GroupControl();
            this.GroupBoxAdvancedSettings = new DevExpress.XtraEditors.GroupControl();
            this.ImageInfoDefaultCredentials = new DevExpress.XtraEditors.SvgImageBox();
            this.ImageInfoPassive = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPlatform.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxProfileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxDefaultLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxDefaultProfile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxGoldHEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxPassiveMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBoxProfileInfo)).BeginInit();
            this.GroupBoxProfileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBoxAdvancedSettings)).BeginInit();
            this.GroupBoxAdvancedSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInfoDefaultCredentials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInfoPassive)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.Location = new System.Drawing.Point(11, 35);
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
            this.LabelAddress.Location = new System.Drawing.Point(11, 107);
            this.LabelAddress.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(58, 15);
            this.LabelAddress.TabIndex = 14;
            this.LabelAddress.Text = "IP Address:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Location = new System.Drawing.Point(305, 346);
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
            this.ButtonCancel.Location = new System.Drawing.Point(219, 346);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(80, 24);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Cancel";
            // 
            // ButtonEditLoginDetails
            // 
            this.ButtonEditLoginDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEditLoginDetails.Location = new System.Drawing.Point(284, 31);
            this.ButtonEditLoginDetails.Name = "ButtonEditLoginDetails";
            this.ButtonEditLoginDetails.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonEditLoginDetails.Size = new System.Drawing.Size(80, 24);
            this.ButtonEditLoginDetails.TabIndex = 4;
            this.ButtonEditLoginDetails.Text = "Edit";
            this.ButtonEditLoginDetails.Click += new System.EventHandler(this.ButtonEditCredentials_Click);
            // 
            // LabelPlatformType
            // 
            this.LabelPlatformType.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelPlatformType.Appearance.Options.UseFont = true;
            this.LabelPlatformType.Location = new System.Drawing.Point(11, 71);
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
            this.ComboBoxPlatform.EditValue = "PlayStation 3 (Fat)";
            this.ComboBoxPlatform.Location = new System.Drawing.Point(124, 67);
            this.ComboBoxPlatform.Name = "ComboBoxPlatform";
            this.ComboBoxPlatform.Properties.AllowFocused = false;
            this.ComboBoxPlatform.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxPlatform.Properties.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.ComboBoxPlatform.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPlatform.Properties.Appearance.Options.UseForeColor = true;
            this.ComboBoxPlatform.Properties.AppearanceItemHighlight.ForeColor = System.Drawing.Color.White;
            this.ComboBoxPlatform.Properties.AppearanceItemHighlight.Options.UseForeColor = true;
            this.ComboBoxPlatform.Properties.AppearanceItemSelected.ForeColor = System.Drawing.Color.White;
            this.ComboBoxPlatform.Properties.AppearanceItemSelected.Options.UseForeColor = true;
            this.ComboBoxPlatform.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPlatform.Properties.DropDownRows = 9;
            this.ComboBoxPlatform.Properties.ItemAutoHeight = true;
            this.ComboBoxPlatform.Properties.Items.AddRange(new object[] {
            "PlayStation 3 (Fat)",
            "PlayStation 3 (Slim)",
            "PlayStation 3 (Super Slim)",
            "PlayStation 4 (All Models)",
            "Xbox 360 (Fat/White)",
            "Xbox 360 Elite (Fat/Black)",
            "Xbox 360 S (Slim)",
            "Xbox 360 E (Slim E)"});
            this.ComboBoxPlatform.Properties.NullValuePrompt = "Select Platform";
            this.ComboBoxPlatform.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxPlatform.Size = new System.Drawing.Size(240, 24);
            this.ComboBoxPlatform.TabIndex = 1;
            this.ComboBoxPlatform.ToolTip = "Choose the type of Platform that you have.";
            this.ComboBoxPlatform.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.ComboBoxPlatform.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPlatformType_SelectedIndexChanged);
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAddress.Location = new System.Drawing.Point(124, 103);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextBoxAddress.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAddress.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TextBoxAddress.Properties.Appearance.Options.UseFont = true;
            this.TextBoxAddress.Properties.Appearance.Options.UseForeColor = true;
            this.TextBoxAddress.Properties.NullValuePrompt = "192.68.0.12";
            this.TextBoxAddress.Size = new System.Drawing.Size(240, 24);
            this.TextBoxAddress.TabIndex = 2;
            this.TextBoxAddress.ToolTip = "Enter IP Address in format: xxx.xxx.xxx.xxx";
            this.TextBoxAddress.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            // 
            // TextBoxProfileName
            // 
            this.TextBoxProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxProfileName.Location = new System.Drawing.Point(124, 31);
            this.TextBoxProfileName.Name = "TextBoxProfileName";
            this.TextBoxProfileName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxProfileName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxProfileName.Size = new System.Drawing.Size(240, 24);
            this.TextBoxProfileName.TabIndex = 0;
            // 
            // CheckBoxDefaultLogin
            // 
            this.CheckBoxDefaultLogin.Location = new System.Drawing.Point(124, 33);
            this.CheckBoxDefaultLogin.Name = "CheckBoxDefaultLogin";
            this.CheckBoxDefaultLogin.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxDefaultLogin.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxDefaultLogin.Properties.AutoWidth = true;
            this.CheckBoxDefaultLogin.Properties.Caption = "Default Credentials";
            this.CheckBoxDefaultLogin.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.CheckBoxDefaultLogin_Properties_EditValueChanging);
            this.CheckBoxDefaultLogin.Size = new System.Drawing.Size(124, 20);
            this.CheckBoxDefaultLogin.TabIndex = 3;
            this.CheckBoxDefaultLogin.CheckStateChanged += new System.EventHandler(this.CheckBoxDefaultLogin_CheckStateChanged);
            // 
            // CheckBoxDefaultProfile
            // 
            this.CheckBoxDefaultProfile.Location = new System.Drawing.Point(124, 69);
            this.CheckBoxDefaultProfile.Name = "CheckBoxDefaultProfile";
            this.CheckBoxDefaultProfile.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxDefaultProfile.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxDefaultProfile.Properties.AutoWidth = true;
            this.CheckBoxDefaultProfile.Properties.Caption = "Default Profile";
            this.CheckBoxDefaultProfile.Size = new System.Drawing.Size(99, 20);
            this.CheckBoxDefaultProfile.TabIndex = 5;
            this.CheckBoxDefaultProfile.CheckStateChanged += new System.EventHandler(this.CheckBoxDefaultProfile_CheckStateChanged);
            this.CheckBoxDefaultProfile.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.CheckBoxDefaultProfile_EditValueChanging);
            // 
            // CheckBoxGoldHEN
            // 
            this.CheckBoxGoldHEN.Location = new System.Drawing.Point(124, 139);
            this.CheckBoxGoldHEN.Name = "CheckBoxGoldHEN";
            this.CheckBoxGoldHEN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxGoldHEN.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxGoldHEN.Properties.AutoWidth = true;
            this.CheckBoxGoldHEN.Properties.Caption = "GoldHEN";
            this.CheckBoxGoldHEN.Size = new System.Drawing.Size(73, 20);
            this.CheckBoxGoldHEN.TabIndex = 7;
            this.CheckBoxGoldHEN.CheckStateChanged += new System.EventHandler(this.CheckBoxGoldHEN_CheckStateChanged);
            // 
            // LabelLoginDetails
            // 
            this.LabelLoginDetails.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLoginDetails.Appearance.Options.UseFont = true;
            this.LabelLoginDetails.Location = new System.Drawing.Point(11, 35);
            this.LabelLoginDetails.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelLoginDetails.Name = "LabelLoginDetails";
            this.LabelLoginDetails.Size = new System.Drawing.Size(71, 15);
            this.LabelLoginDetails.TabIndex = 1147;
            this.LabelLoginDetails.Text = "Login Details:";
            // 
            // CheckBoxPassiveMode
            // 
            this.CheckBoxPassiveMode.Location = new System.Drawing.Point(124, 105);
            this.CheckBoxPassiveMode.Name = "CheckBoxPassiveMode";
            this.CheckBoxPassiveMode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxPassiveMode.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxPassiveMode.Properties.AutoWidth = true;
            this.CheckBoxPassiveMode.Properties.Caption = "Passive Mode";
            this.CheckBoxPassiveMode.Size = new System.Drawing.Size(96, 20);
            this.CheckBoxPassiveMode.TabIndex = 6;
            this.CheckBoxPassiveMode.CheckStateChanged += new System.EventHandler(this.CheckBoxPassiveMode_CheckStateChanged);
            // 
            // LabelOptions
            // 
            this.LabelOptions.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelOptions.Appearance.Options.UseFont = true;
            this.LabelOptions.Location = new System.Drawing.Point(11, 71);
            this.LabelOptions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelOptions.Name = "LabelOptions";
            this.LabelOptions.Size = new System.Drawing.Size(45, 15);
            this.LabelOptions.TabIndex = 1153;
            this.LabelOptions.Text = "Options:";
            // 
            // GroupBoxProfileInfo
            // 
            this.GroupBoxProfileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxProfileInfo.Controls.Add(this.LabelName);
            this.GroupBoxProfileInfo.Controls.Add(this.LabelAddress);
            this.GroupBoxProfileInfo.Controls.Add(this.TextBoxProfileName);
            this.GroupBoxProfileInfo.Controls.Add(this.TextBoxAddress);
            this.GroupBoxProfileInfo.Controls.Add(this.LabelPlatformType);
            this.GroupBoxProfileInfo.Controls.Add(this.ComboBoxPlatform);
            this.GroupBoxProfileInfo.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxProfileInfo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.GroupBoxProfileInfo.Name = "GroupBoxProfileInfo";
            this.GroupBoxProfileInfo.Size = new System.Drawing.Size(373, 138);
            this.GroupBoxProfileInfo.TabIndex = 1155;
            this.GroupBoxProfileInfo.Text = "Profile Information";
            // 
            // GroupBoxAdvancedSettings
            // 
            this.GroupBoxAdvancedSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxAdvancedSettings.Controls.Add(this.ImageInfoDefaultCredentials);
            this.GroupBoxAdvancedSettings.Controls.Add(this.ImageInfoPassive);
            this.GroupBoxAdvancedSettings.Controls.Add(this.LabelLoginDetails);
            this.GroupBoxAdvancedSettings.Controls.Add(this.LabelOptions);
            this.GroupBoxAdvancedSettings.Controls.Add(this.CheckBoxDefaultLogin);
            this.GroupBoxAdvancedSettings.Controls.Add(this.CheckBoxPassiveMode);
            this.GroupBoxAdvancedSettings.Controls.Add(this.ButtonEditLoginDetails);
            this.GroupBoxAdvancedSettings.Controls.Add(this.CheckBoxDefaultProfile);
            this.GroupBoxAdvancedSettings.Controls.Add(this.CheckBoxGoldHEN);
            this.GroupBoxAdvancedSettings.Location = new System.Drawing.Point(12, 161);
            this.GroupBoxAdvancedSettings.Margin = new System.Windows.Forms.Padding(3, 5, 3, 6);
            this.GroupBoxAdvancedSettings.Name = "GroupBoxAdvancedSettings";
            this.GroupBoxAdvancedSettings.Size = new System.Drawing.Size(373, 172);
            this.GroupBoxAdvancedSettings.TabIndex = 1156;
            this.GroupBoxAdvancedSettings.Text = "Advanced Settings";
            // 
            // ImageInfoDefaultCredentials
            // 
            this.ImageInfoDefaultCredentials.ContextButtonOptions.AllowGlyphSkinning = true;
            this.ImageInfoDefaultCredentials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageInfoDefaultCredentials.ItemAppearance.Disabled.FillColor = System.Drawing.Color.DimGray;
            this.ImageInfoDefaultCredentials.ItemAppearance.Normal.FillColor = System.Drawing.Color.White;
            this.ImageInfoDefaultCredentials.Location = new System.Drawing.Point(248, 34);
            this.ImageInfoDefaultCredentials.Name = "ImageInfoDefaultCredentials";
            this.ImageInfoDefaultCredentials.Size = new System.Drawing.Size(18, 18);
            this.ImageInfoDefaultCredentials.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageInfoDefaultCredentials.SvgImage = global::ArisenStudio.Properties.Resources.icons8_info;
            this.ImageInfoDefaultCredentials.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.ImageInfoDefaultCredentials.TabIndex = 1156;
            this.ImageInfoDefaultCredentials.ToolTip = "Connects without actively controlling the console. Ideal for monitoring purposes." +
    "";
            this.ImageInfoDefaultCredentials.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.ImageInfoDefaultCredentials.ToolTipTitle = "Passive Mode";
            // 
            // ImageInfoPassive
            // 
            this.ImageInfoPassive.ContextButtonOptions.AllowGlyphSkinning = true;
            this.ImageInfoPassive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageInfoPassive.ItemAppearance.Disabled.FillColor = System.Drawing.Color.DimGray;
            this.ImageInfoPassive.ItemAppearance.Normal.FillColor = System.Drawing.Color.White;
            this.ImageInfoPassive.Location = new System.Drawing.Point(221, 106);
            this.ImageInfoPassive.Name = "ImageInfoPassive";
            this.ImageInfoPassive.Size = new System.Drawing.Size(18, 18);
            this.ImageInfoPassive.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.ImageInfoPassive.SvgImage = global::ArisenStudio.Properties.Resources.icons8_info;
            this.ImageInfoPassive.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.ImageInfoPassive.TabIndex = 1155;
            this.ImageInfoPassive.ToolTip = "Connects without actively controlling the console. Ideal for monitoring purposes." +
    "";
            this.ImageInfoPassive.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.ImageInfoPassive.ToolTipTitle = "Passive Mode";
            // 
            // NewProfileDialog
            // 
            this.AcceptButton = this.ButtonSave;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(397, 382);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.GroupBoxProfileInfo);
            this.Controls.Add(this.GroupBoxAdvancedSettings);
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
            ((System.ComponentModel.ISupportInitialize)(this.GroupBoxProfileInfo)).EndInit();
            this.GroupBoxProfileInfo.ResumeLayout(false);
            this.GroupBoxProfileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBoxAdvancedSettings)).EndInit();
            this.GroupBoxAdvancedSettings.ResumeLayout(false);
            this.GroupBoxAdvancedSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInfoDefaultCredentials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInfoPassive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LabelControl LabelName;
        private LabelControl LabelAddress;
        private TextEdit TextBoxProfileName;
        private TextEdit TextBoxAddress;
        private SimpleButton ButtonSave;
        private SimpleButton ButtonCancel;
        private SimpleButton ButtonEditLoginDetails;
        private LabelControl LabelPlatformType;
        private ComboBoxEdit ComboBoxPlatform;
        private CheckEdit CheckBoxDefaultLogin;
        private CheckEdit CheckBoxDefaultProfile;
        private CheckEdit CheckBoxGoldHEN;
        private LabelControl LabelLoginDetails;
        private CheckEdit CheckBoxPassiveMode;
        private LabelControl LabelOptions;
        private GroupControl GroupBoxProfileInfo;
        private GroupControl GroupBoxAdvancedSettings;
        private SvgImageBox ImageInfoPassive;
        private SvgImageBox ImageInfoDefaultCredentials;
    }
}