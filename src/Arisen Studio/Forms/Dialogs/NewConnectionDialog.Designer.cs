﻿using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Dialogs
{
    partial class NewConnectionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConnectionDialog));
            this.LabelUserPass = new DevExpress.XtraEditors.LabelControl();
            this.LabelLogin = new DevExpress.XtraEditors.LabelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.LabelAddress = new DevExpress.XtraEditors.LabelControl();
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonChangeLoginDetails = new DevExpress.XtraEditors.SimpleButton();
            this.LabelPlatformType = new DevExpress.XtraEditors.LabelControl();
            this.ImageConsole = new DevExpress.XtraEditors.PictureEdit();
            this.ComboBoxPlatform = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TextBoxAddress = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxConnectionName = new DevExpress.XtraEditors.TextEdit();
            this.CheckBoxUseDefaultConsole = new DevExpress.XtraEditors.CheckEdit();
            this.LabelDefault = new DevExpress.XtraEditors.LabelControl();
            this.CheckBoxDefault = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageConsole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPlatform.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConnectionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxUseDefaultConsole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxDefault.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUserPass
            // 
            this.LabelUserPass.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelUserPass.Appearance.Options.UseFont = true;
            this.LabelUserPass.AutoEllipsis = true;
            this.LabelUserPass.Location = new System.Drawing.Point(264, 124);
            this.LabelUserPass.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelUserPass.Name = "LabelUserPass";
            this.LabelUserPass.Size = new System.Drawing.Size(38, 15);
            this.LabelUserPass.TabIndex = 3;
            this.LabelUserPass.Text = "Default";
            // 
            // LabelLogin
            // 
            this.LabelLogin.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLogin.Appearance.Options.UseFont = true;
            this.LabelLogin.Location = new System.Drawing.Point(150, 124);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(33, 15);
            this.LabelLogin.TabIndex = 1141;
            this.LabelLogin.Text = "Login:";
            // 
            // LabelName
            // 
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.Location = new System.Drawing.Point(150, 19);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(100, 15);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Connection Name:";
            // 
            // LabelAddress
            // 
            this.LabelAddress.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelAddress.Appearance.Options.UseFont = true;
            this.LabelAddress.Location = new System.Drawing.Point(150, 91);
            this.LabelAddress.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(58, 15);
            this.LabelAddress.TabIndex = 14;
            this.LabelAddress.Text = "IP Address:";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Location = new System.Drawing.Point(354, 212);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOK.Size = new System.Drawing.Size(80, 24);
            this.ButtonOK.TabIndex = 6;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(444, 212);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(80, 24);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "Cancel";
            // 
            // ButtonChangeLoginDetails
            // 
            this.ButtonChangeLoginDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonChangeLoginDetails.Location = new System.Drawing.Point(444, 120);
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
            this.LabelPlatformType.Location = new System.Drawing.Point(150, 55);
            this.LabelPlatformType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelPlatformType.Name = "LabelPlatformType";
            this.LabelPlatformType.Size = new System.Drawing.Size(77, 15);
            this.LabelPlatformType.TabIndex = 1146;
            this.LabelPlatformType.Text = "Platform Type:";
            // 
            // ImageConsole
            // 
            this.ImageConsole.EditValue = ((object)(resources.GetObject("ImageConsole.EditValue")));
            this.ImageConsole.Location = new System.Drawing.Point(12, 12);
            this.ImageConsole.Name = "ImageConsole";
            this.ImageConsole.Properties.AllowFocused = false;
            this.ImageConsole.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.False;
            this.ImageConsole.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ImageConsole.Properties.Appearance.Options.UseBackColor = true;
            this.ImageConsole.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageConsole.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageConsole.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this.ImageConsole.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageConsole.Size = new System.Drawing.Size(132, 132);
            this.ImageConsole.TabIndex = 0;
            // 
            // ComboBoxPlatform
            // 
            this.ComboBoxPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxPlatform.EditValue = "";
            this.ComboBoxPlatform.Location = new System.Drawing.Point(264, 48);
            this.ComboBoxPlatform.Name = "ComboBoxPlatform";
            this.ComboBoxPlatform.Properties.AllowFocused = false;
            this.ComboBoxPlatform.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxPlatform.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxPlatform.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxPlatform.Properties.Items.AddRange(new object[] {
            "PlayStation 3 (Fat)",
            "PlayStation 3 (Slim)",
            "PlayStation 3 (Super Slim)",
            "Xbox 360 (Fat/White)",
            "Xbox 360 Elite (Fat/Black)",
            "Xbox 360 S (Slim)",
            "Xbox 360 E (Slim E)",
            "PlayStation 4 (Test)"});
            this.ComboBoxPlatform.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxPlatform.Size = new System.Drawing.Size(260, 24);
            this.ComboBoxPlatform.TabIndex = 1;
            this.ComboBoxPlatform.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPlatformType_SelectedIndexChanged);
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAddress.Location = new System.Drawing.Point(264, 84);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxAddress.Properties.Appearance.Options.UseFont = true;
            this.TextBoxAddress.Size = new System.Drawing.Size(260, 24);
            this.TextBoxAddress.TabIndex = 2;
            // 
            // TextBoxConnectionName
            // 
            this.TextBoxConnectionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxConnectionName.Location = new System.Drawing.Point(264, 12);
            this.TextBoxConnectionName.Name = "TextBoxConnectionName";
            this.TextBoxConnectionName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConnectionName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxConnectionName.Size = new System.Drawing.Size(260, 24);
            this.TextBoxConnectionName.TabIndex = 0;
            // 
            // CheckBoxUseDefaultConsole
            // 
            this.CheckBoxUseDefaultConsole.Location = new System.Drawing.Point(264, 122);
            this.CheckBoxUseDefaultConsole.Name = "CheckBoxUseDefaultConsole";
            this.CheckBoxUseDefaultConsole.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxUseDefaultConsole.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxUseDefaultConsole.Properties.AutoWidth = true;
            this.CheckBoxUseDefaultConsole.Properties.Caption = "";
            this.CheckBoxUseDefaultConsole.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.CheckBoxUseDefaultConsole_Properties_EditValueChanging);
            this.CheckBoxUseDefaultConsole.Size = new System.Drawing.Size(20, 20);
            this.CheckBoxUseDefaultConsole.TabIndex = 3;
            this.CheckBoxUseDefaultConsole.Visible = false;
            this.CheckBoxUseDefaultConsole.CheckStateChanged += new System.EventHandler(this.CheckBoxUseDefaultConsole_CheckStateChanged);
            // 
            // LabelDefault
            // 
            this.LabelDefault.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDefault.Appearance.Options.UseFont = true;
            this.LabelDefault.Location = new System.Drawing.Point(150, 154);
            this.LabelDefault.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelDefault.Name = "LabelDefault";
            this.LabelDefault.Size = new System.Drawing.Size(41, 15);
            this.LabelDefault.TabIndex = 1149;
            this.LabelDefault.Text = "Default:";
            // 
            // CheckBoxDefault
            // 
            this.CheckBoxDefault.Location = new System.Drawing.Point(264, 152);
            this.CheckBoxDefault.Name = "CheckBoxDefault";
            this.CheckBoxDefault.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckBoxDefault.Properties.Appearance.Options.UseFont = true;
            this.CheckBoxDefault.Properties.AutoWidth = true;
            this.CheckBoxDefault.Properties.Caption = "";
            this.CheckBoxDefault.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.CheckBoxUseDefaultConsole_Properties_EditValueChanging);
            this.CheckBoxDefault.Size = new System.Drawing.Size(20, 20);
            this.CheckBoxDefault.TabIndex = 1147;
            this.CheckBoxDefault.CheckStateChanged += new System.EventHandler(this.CheckBoxDefault_CheckStateChanged);
            this.CheckBoxDefault.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.CheckBoxDefault_EditValueChanging);
            // 
            // NewConnectionDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(536, 248);
            this.Controls.Add(this.LabelDefault);
            this.Controls.Add(this.CheckBoxDefault);
            this.Controls.Add(this.ImageConsole);
            this.Controls.Add(this.ComboBoxPlatform);
            this.Controls.Add(this.LabelPlatformType);
            this.Controls.Add(this.ButtonChangeLoginDetails);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxConnectionName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.CheckBoxUseDefaultConsole);
            this.Controls.Add(this.LabelUserPass);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("NewConnectionDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewConnectionDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewConnectionDialog_FormClosing);
            this.Load += new System.EventHandler(this.ConsolesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageConsole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPlatform.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConnectionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxUseDefaultConsole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxDefault.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelName;
        private LabelControl LabelAddress;
        private LabelControl LabelUserPass;
        private LabelControl LabelLogin;
        private TextEdit TextBoxConnectionName;
        private TextEdit TextBoxAddress;
        private SimpleButton ButtonOK;
        private SimpleButton ButtonCancel;
        private SimpleButton ButtonChangeLoginDetails;
        private LabelControl LabelPlatformType;
        private ComboBoxEdit ComboBoxPlatform;
        private PictureEdit ImageConsole;
        private CheckEdit CheckBoxUseDefaultConsole;
        private LabelControl LabelDefault;
        private CheckEdit CheckBoxDefault;
    }
}