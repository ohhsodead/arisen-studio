
namespace ModioX.Forms.Tools.XBOX_Tools
{
    partial class iniEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.List = new DevExpress.XtraEditors.ListBoxControl();
            this.ReadButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.WriteButton = new DevExpress.XtraEditors.SimpleButton();
            this.RebootButton = new DevExpress.XtraEditors.SimpleButton();
            this.InsertButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PathsCombo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LiveBlock = new DevExpress.XtraEditors.CheckEdit();
            this.LiveStrong = new DevExpress.XtraEditors.CheckEdit();
            this.Settings = new DevExpress.XtraEditors.TextEdit();
            this.Value = new DevExpress.XtraEditors.TextEdit();
            this.INITextbox = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PathsCombo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveBlock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveStrong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INITextbox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(12, 15);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(432, 326);
            this.List.TabIndex = 0;
            this.List.Click += new System.EventHandler(this.ListUserClick);
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(84, 380);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(96, 23);
            this.ReadButton.TabIndex = 1;
            this.ReadButton.Text = "Read";
            this.ReadButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LiveBlock);
            this.groupControl1.Controls.Add(this.LiveStrong);
            this.groupControl1.Location = new System.Drawing.Point(347, 378);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(97, 80);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Quick Toggles";
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(185, 380);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(96, 23);
            this.WriteButton.TabIndex = 6;
            this.WriteButton.Text = "Write";
            this.WriteButton.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // RebootButton
            // 
            this.RebootButton.Location = new System.Drawing.Point(287, 380);
            this.RebootButton.Name = "RebootButton";
            this.RebootButton.Size = new System.Drawing.Size(54, 23);
            this.RebootButton.TabIndex = 7;
            this.RebootButton.Text = "Reboot";
            this.RebootButton.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(287, 435);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(54, 23);
            this.InsertButton.TabIndex = 8;
            this.InsertButton.Text = "Insert";
            this.InsertButton.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(177, 438);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(9, 17);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "=";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(150, 410);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 17);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Insert New";
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.EditValue = "Hdd:\\";
            this.comboBoxEdit2.Location = new System.Drawing.Point(12, 381);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.Items.AddRange(new object[] {
            "Hdd:\\",
            "Usb0:\\",
            "Usb1:\\",
            "Usb2:\\",
            "Usb3:\\",
            "Usb4:\\"});
            this.comboBoxEdit2.Size = new System.Drawing.Size(66, 20);
            this.comboBoxEdit2.TabIndex = 12;
            // 
            // PathsCombo
            // 
            this.PathsCombo.EditValue = "Paths";
            this.PathsCombo.Location = new System.Drawing.Point(12, 438);
            this.PathsCombo.Name = "PathsCombo";
            this.PathsCombo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PathsCombo.Properties.Items.AddRange(new object[] {
            "Paths",
            "Plugins",
            "Externals",
            "Settings"});
            this.PathsCombo.Size = new System.Drawing.Size(66, 20);
            this.PathsCombo.TabIndex = 9;
            // 
            // LiveBlock
            // 
            this.LiveBlock.Location = new System.Drawing.Point(11, 53);
            this.LiveBlock.Name = "LiveBlock";
            this.LiveBlock.Properties.Caption = "LiveBlock";
            this.LiveBlock.Size = new System.Drawing.Size(75, 19);
            this.LiveBlock.TabIndex = 7;
            this.LiveBlock.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // LiveStrong
            // 
            this.LiveStrong.Location = new System.Drawing.Point(11, 29);
            this.LiveStrong.Name = "LiveStrong";
            this.LiveStrong.Properties.Caption = "LiveStrong";
            this.LiveStrong.Size = new System.Drawing.Size(75, 19);
            this.LiveStrong.TabIndex = 6;
            this.LiveStrong.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(84, 438);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(87, 20);
            this.Settings.TabIndex = 4;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(194, 438);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(87, 20);
            this.Value.TabIndex = 3;
            // 
            // INITextbox
            // 
            this.INITextbox.Location = new System.Drawing.Point(12, 347);
            this.INITextbox.Name = "INITextbox";
            this.INITextbox.Size = new System.Drawing.Size(432, 20);
            this.INITextbox.TabIndex = 2;
            this.INITextbox.TextChanged += new System.EventHandler(this.INITextbox_TextChanged);
            // 
            // iniEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 457);
            this.Controls.Add(this.comboBoxEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PathsCombo);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.RebootButton);
            this.Controls.Add(this.WriteButton);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.INITextbox);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.MaximizeBox = false;
            this.Name = "iniEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xbox File Editor";
            this.Load += new System.EventHandler(this.iniEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PathsCombo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveBlock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiveStrong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Value.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INITextbox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl List;
        private DevExpress.XtraEditors.SimpleButton ReadButton;
        private DevExpress.XtraEditors.TextEdit INITextbox;
        private DevExpress.XtraEditors.TextEdit Value;
        private DevExpress.XtraEditors.TextEdit Settings;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit LiveBlock;
        private DevExpress.XtraEditors.CheckEdit LiveStrong;
        private DevExpress.XtraEditors.SimpleButton WriteButton;
        private DevExpress.XtraEditors.SimpleButton RebootButton;
        private DevExpress.XtraEditors.SimpleButton InsertButton;
        private DevExpress.XtraEditors.ComboBoxEdit PathsCombo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
    }
}