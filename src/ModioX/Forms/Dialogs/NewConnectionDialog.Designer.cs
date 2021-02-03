using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs
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
            this.darkLabel1 = new DevExpress.XtraEditors.LabelControl();
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.LabelDescription = new DevExpress.XtraEditors.LabelControl();
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonChangeCredentials = new DevExpress.XtraEditors.SimpleButton();
            this.darkLabel2 = new DevExpress.XtraEditors.LabelControl();
            this.ImageConsole = new DevExpress.XtraEditors.PictureEdit();
            this.ComboBoxConsoleType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TextBoxConsolePort = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxConsoleAddress = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxConnectionName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageConsole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxConsoleType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsolePort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsoleAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConnectionName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUserPass
            // 
            this.LabelUserPass.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelUserPass.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelUserPass.Appearance.Options.UseFont = true;
            this.LabelUserPass.Appearance.Options.UseForeColor = true;
            this.LabelUserPass.AutoEllipsis = true;
            this.LabelUserPass.Location = new System.Drawing.Point(261, 102);
            this.LabelUserPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelUserPass.Name = "LabelUserPass";
            this.LabelUserPass.Size = new System.Drawing.Size(38, 15);
            this.LabelUserPass.TabIndex = 1142;
            this.LabelUserPass.Text = "Default";
            // 
            // LabelLogin
            // 
            this.LabelLogin.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLogin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelLogin.Appearance.Options.UseFont = true;
            this.LabelLogin.Appearance.Options.UseForeColor = true;
            this.LabelLogin.Location = new System.Drawing.Point(151, 102);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(33, 15);
            this.LabelLogin.TabIndex = 1141;
            this.LabelLogin.Text = "Login:";
            // 
            // darkLabel1
            // 
            this.darkLabel1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.darkLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Appearance.Options.UseFont = true;
            this.darkLabel1.Appearance.Options.UseForeColor = true;
            this.darkLabel1.Location = new System.Drawing.Point(415, 71);
            this.darkLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(25, 15);
            this.darkLabel1.TabIndex = 1139;
            this.darkLabel1.Text = "Port:";
            // 
            // LabelName
            // 
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.Appearance.Options.UseForeColor = true;
            this.LabelName.Location = new System.Drawing.Point(151, 15);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(100, 15);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "Connection Name:";
            // 
            // LabelDescription
            // 
            this.LabelDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelDescription.Appearance.Options.UseFont = true;
            this.LabelDescription.Appearance.Options.UseForeColor = true;
            this.LabelDescription.Location = new System.Drawing.Point(151, 71);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(91, 15);
            this.LabelDescription.TabIndex = 14;
            this.LabelDescription.Text = "Console Address:";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Location = new System.Drawing.Point(332, 180);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(80, 24);
            this.ButtonOK.TabIndex = 6;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(422, 180);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(80, 24);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "Cancel";
            // 
            // ButtonChangeCredentials
            // 
            this.ButtonChangeCredentials.Location = new System.Drawing.Point(422, 98);
            this.ButtonChangeCredentials.Name = "ButtonChangeCredentials";
            this.ButtonChangeCredentials.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonChangeCredentials.Size = new System.Drawing.Size(80, 24);
            this.ButtonChangeCredentials.TabIndex = 4;
            this.ButtonChangeCredentials.Text = "Change";
            this.ButtonChangeCredentials.Click += new System.EventHandler(this.ButtonChangeCredentials_Click);
            // 
            // darkLabel2
            // 
            this.darkLabel2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.darkLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Appearance.Options.UseFont = true;
            this.darkLabel2.Appearance.Options.UseForeColor = true;
            this.darkLabel2.Location = new System.Drawing.Point(151, 43);
            this.darkLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(74, 15);
            this.darkLabel2.TabIndex = 1146;
            this.darkLabel2.Text = "Console Type:";
            // 
            // ImageConsole
            // 
            this.ImageConsole.EditValue = ((object)(resources.GetObject("ImageConsole.EditValue")));
            this.ImageConsole.Location = new System.Drawing.Point(12, 12);
            this.ImageConsole.Name = "ImageConsole";
            this.ImageConsole.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.ImageConsole.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ImageConsole.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ImageConsole.Properties.Appearance.Options.UseBackColor = true;
            this.ImageConsole.Properties.Appearance.Options.UseForeColor = true;
            this.ImageConsole.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ImageConsole.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImageConsole.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this.ImageConsole.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImageConsole.Size = new System.Drawing.Size(132, 132);
            this.ImageConsole.TabIndex = 1147;
            // 
            // ComboBoxConsoleType
            // 
            this.ComboBoxConsoleType.EditValue = "PlayStation 3 (Fat)";
            this.ComboBoxConsoleType.Location = new System.Drawing.Point(264, 40);
            this.ComboBoxConsoleType.Name = "ComboBoxConsoleType";
            this.ComboBoxConsoleType.Properties.AllowFocused = false;
            this.ComboBoxConsoleType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxConsoleType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxConsoleType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxConsoleType.Properties.Items.AddRange(new object[] {
            "PlayStation 3 (Fat)",
            "PlayStation 3 (Slim)",
            "PlayStation 3 (Super Slim)",
            "Xbox 360 (Fat/White)",
            "Xbox 360 Elite (Flat/Black)",
            "Xbox 360 S (Slim)",
            "Xbox 360 E (Slim E)"});
            this.ComboBoxConsoleType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxConsoleType.Size = new System.Drawing.Size(238, 22);
            this.ComboBoxConsoleType.TabIndex = 1;
            this.ComboBoxConsoleType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxConsoleType_SelectedIndexChanged);
            // 
            // TextBoxConsolePort
            // 
            this.TextBoxConsolePort.EditValue = "21";
            this.TextBoxConsolePort.Location = new System.Drawing.Point(453, 68);
            this.TextBoxConsolePort.Name = "TextBoxConsolePort";
            this.TextBoxConsolePort.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConsolePort.Properties.Appearance.Options.UseFont = true;
            this.TextBoxConsolePort.Size = new System.Drawing.Size(49, 22);
            this.TextBoxConsolePort.TabIndex = 3;
            // 
            // TextBoxConsoleAddress
            // 
            this.TextBoxConsoleAddress.Location = new System.Drawing.Point(264, 68);
            this.TextBoxConsoleAddress.Name = "TextBoxConsoleAddress";
            this.TextBoxConsoleAddress.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConsoleAddress.Properties.Appearance.Options.UseFont = true;
            this.TextBoxConsoleAddress.Size = new System.Drawing.Size(145, 22);
            this.TextBoxConsoleAddress.TabIndex = 2;
            // 
            // TextBoxConnectionName
            // 
            this.TextBoxConnectionName.Location = new System.Drawing.Point(264, 12);
            this.TextBoxConnectionName.Name = "TextBoxConnectionName";
            this.TextBoxConnectionName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConnectionName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxConnectionName.Size = new System.Drawing.Size(238, 22);
            this.TextBoxConnectionName.TabIndex = 0;
            // 
            // NewConnectionDialog
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(514, 216);
            this.Controls.Add(this.ImageConsole);
            this.Controls.Add(this.ComboBoxConsoleType);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.ButtonChangeCredentials);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.TextBoxConsolePort);
            this.Controls.Add(this.TextBoxConsoleAddress);
            this.Controls.Add(this.TextBoxConnectionName);
            this.Controls.Add(this.LabelUserPass);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.darkLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("NewConnectionDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewConnectionDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection Details";
            this.Load += new System.EventHandler(this.ConsolesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageConsole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxConsoleType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsolePort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConsoleAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxConnectionName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelName;
        private LabelControl LabelDescription;
        private LabelControl LabelUserPass;
        private LabelControl LabelLogin;
        private LabelControl darkLabel1;
        private TextEdit TextBoxConnectionName;
        private TextEdit TextBoxConsoleAddress;
        private TextEdit TextBoxConsolePort;
        private SimpleButton ButtonOK;
        private SimpleButton ButtonCancel;
        private SimpleButton ButtonChangeCredentials;
        private LabelControl darkLabel2;
        private ComboBoxEdit ComboBoxConsoleType;
        private PictureEdit ImageConsole;
    }
}