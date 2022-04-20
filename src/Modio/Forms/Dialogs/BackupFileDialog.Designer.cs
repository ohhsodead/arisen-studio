using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Modio.Forms.Dialogs
{
    partial class BackupFileDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupFileDialog));
            this.LabelLocalFilePath = new DevExpress.XtraEditors.LabelControl();
            this.LabelInstallFilePath = new DevExpress.XtraEditors.LabelControl();
            this.LabelGameId = new DevExpress.XtraEditors.LabelControl();
            this.LabelFilename = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxFileName = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxGameId = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxInstallPathConsole = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxInstallPathLocal = new DevExpress.XtraEditors.TextEdit();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonBrowseLocalPath = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxInstallPathConsole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxInstallPathLocal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLocalFilePath
            // 
            this.LabelLocalFilePath.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelLocalFilePath.Appearance.Options.UseForeColor = true;
            this.LabelLocalFilePath.Location = new System.Drawing.Point(12, 104);
            this.LabelLocalFilePath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelLocalFilePath.Name = "LabelLocalFilePath";
            this.LabelLocalFilePath.Size = new System.Drawing.Size(76, 13);
            this.LabelLocalFilePath.TabIndex = 7;
            this.LabelLocalFilePath.Text = "Local File Path:";
            // 
            // LabelInstallFilePath
            // 
            this.LabelInstallFilePath.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelInstallFilePath.Appearance.Options.UseForeColor = true;
            this.LabelInstallFilePath.Location = new System.Drawing.Point(12, 58);
            this.LabelInstallFilePath.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelInstallFilePath.Name = "LabelInstallFilePath";
            this.LabelInstallFilePath.Size = new System.Drawing.Size(81, 13);
            this.LabelInstallFilePath.TabIndex = 9;
            this.LabelInstallFilePath.Text = "Install File Path:";
            // 
            // LabelGameId
            // 
            this.LabelGameId.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelGameId.Appearance.Options.UseForeColor = true;
            this.LabelGameId.Location = new System.Drawing.Point(203, 12);
            this.LabelGameId.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelGameId.Name = "LabelGameId";
            this.LabelGameId.Size = new System.Drawing.Size(45, 13);
            this.LabelGameId.TabIndex = 12;
            this.LabelGameId.Text = "Game Id:";
            // 
            // LabelFilename
            // 
            this.LabelFilename.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFilename.Appearance.Options.UseForeColor = true;
            this.LabelFilename.Location = new System.Drawing.Point(12, 12);
            this.LabelFilename.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelFilename.Name = "LabelFilename";
            this.LabelFilename.Size = new System.Drawing.Size(53, 13);
            this.LabelFilename.TabIndex = 14;
            this.LabelFilename.Text = "File Name:";
            // 
            // TextBoxFileName
            // 
            this.TextBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFileName.Enabled = false;
            this.TextBoxFileName.Location = new System.Drawing.Point(12, 30);
            this.TextBoxFileName.Name = "TextBoxFileName";
            this.TextBoxFileName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxFileName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxFileName.Size = new System.Drawing.Size(185, 22);
            this.TextBoxFileName.TabIndex = 0;
            // 
            // TextBoxGameId
            // 
            this.TextBoxGameId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGameId.Enabled = false;
            this.TextBoxGameId.Location = new System.Drawing.Point(203, 30);
            this.TextBoxGameId.Name = "TextBoxGameId";
            this.TextBoxGameId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxGameId.Properties.Appearance.Options.UseFont = true;
            this.TextBoxGameId.Size = new System.Drawing.Size(108, 22);
            this.TextBoxGameId.TabIndex = 1;
            // 
            // TextBoxInstallPathConsole
            // 
            this.TextBoxInstallPathConsole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxInstallPathConsole.Enabled = false;
            this.TextBoxInstallPathConsole.Location = new System.Drawing.Point(12, 76);
            this.TextBoxInstallPathConsole.Name = "TextBoxInstallPathConsole";
            this.TextBoxInstallPathConsole.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxInstallPathConsole.Properties.Appearance.Options.UseFont = true;
            this.TextBoxInstallPathConsole.Size = new System.Drawing.Size(299, 22);
            this.TextBoxInstallPathConsole.TabIndex = 2;
            // 
            // TextBoxInstallPathLocal
            // 
            this.TextBoxInstallPathLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxInstallPathLocal.Enabled = false;
            this.TextBoxInstallPathLocal.Location = new System.Drawing.Point(12, 122);
            this.TextBoxInstallPathLocal.Name = "TextBoxInstallPathLocal";
            this.TextBoxInstallPathLocal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxInstallPathLocal.Properties.Appearance.Options.UseFont = true;
            this.TextBoxInstallPathLocal.Size = new System.Drawing.Size(248, 22);
            this.TextBoxInstallPathLocal.TabIndex = 3;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(236, 165);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Location = new System.Drawing.Point(155, 165);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 5;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonBrowseLocalPath
            // 
            this.ButtonBrowseLocalPath.Location = new System.Drawing.Point(266, 122);
            this.ButtonBrowseLocalPath.Name = "ButtonBrowseLocalPath";
            this.ButtonBrowseLocalPath.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonBrowseLocalPath.Size = new System.Drawing.Size(45, 22);
            this.ButtonBrowseLocalPath.TabIndex = 4;
            this.ButtonBrowseLocalPath.Text = "...";
            this.ButtonBrowseLocalPath.Click += new System.EventHandler(this.ButtonBrowseLocalPath_Click);
            // 
            // BackupFileDialog
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(323, 200);
            this.Controls.Add(this.ButtonBrowseLocalPath);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.TextBoxInstallPathLocal);
            this.Controls.Add(this.TextBoxInstallPathConsole);
            this.Controls.Add(this.TextBoxGameId);
            this.Controls.Add(this.TextBoxFileName);
            this.Controls.Add(this.LabelInstallFilePath);
            this.Controls.Add(this.LabelLocalFilePath);
            this.Controls.Add(this.LabelGameId);
            this.Controls.Add(this.LabelFilename);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("BackupFileDialog.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupFileDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup File Details";
            this.Load += new System.EventHandler(this.EditBackupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxInstallPathConsole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxInstallPathLocal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelLocalFilePath;
        private LabelControl LabelInstallFilePath;
        private LabelControl LabelGameId;
        private LabelControl LabelFilename;
        private TextEdit TextBoxFileName;
        private TextEdit TextBoxGameId;
        private TextEdit TextBoxInstallPathConsole;
        private TextEdit TextBoxInstallPathLocal;
        private SimpleButton ButtonCancel;
        private SimpleButton ButtonOK;
        private SimpleButton ButtonBrowseLocalPath;
    }
}