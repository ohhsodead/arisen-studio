namespace ModioX.Forms.Tools.XBOX_Tools
{
    partial class AvatarItemDownloader
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
            this.GameNameBox = new DevExpress.XtraEditors.TextEdit();
            this.DL_BTN = new DevExpress.XtraEditors.SimpleButton();
            this.progressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.ItemIDBox = new DevExpress.XtraEditors.TextEdit();
            this.ItemNameBox = new DevExpress.XtraEditors.TextEdit();
            this.groupBox4 = new DevExpress.XtraEditors.GroupControl();
            this.XUIDBox = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox3 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new DevExpress.XtraEditors.GroupControl();
            this.MPURLBox = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new DevExpress.XtraEditors.ImageListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.GameNameBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemIDBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XUIDBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPURLBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameNameBox
            // 
            this.GameNameBox.Location = new System.Drawing.Point(6, 17);
            this.GameNameBox.Name = "GameNameBox";
            this.GameNameBox.Size = new System.Drawing.Size(318, 20);
            this.GameNameBox.TabIndex = 13;
            // 
            // DL_BTN
            // 
            this.DL_BTN.Location = new System.Drawing.Point(478, 229);
            this.DL_BTN.Name = "DL_BTN";
            this.DL_BTN.Size = new System.Drawing.Size(154, 23);
            this.DL_BTN.TabIndex = 19;
            this.DL_BTN.Text = ":: Download Item ::";
            this.DL_BTN.Click += new System.EventHandler(this.DL_BTN_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 26);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 10);
            this.progressBar.TabIndex = 20;
            this.progressBar.Visible = false;
            // 
            // ItemIDBox
            // 
            this.ItemIDBox.EditValue = "0000100095CEE253CEA4B7824D5308AB";
            this.ItemIDBox.Enabled = false;
            this.ItemIDBox.Location = new System.Drawing.Point(6, 16);
            this.ItemIDBox.Name = "ItemIDBox";
            this.ItemIDBox.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ItemIDBox.Properties.Appearance.Options.UseForeColor = true;
            this.ItemIDBox.Size = new System.Drawing.Size(318, 20);
            this.ItemIDBox.TabIndex = 4;
            // 
            // ItemNameBox
            // 
            this.ItemNameBox.EditValue = "Lancer";
            this.ItemNameBox.Enabled = false;
            this.ItemNameBox.Location = new System.Drawing.Point(6, 16);
            this.ItemNameBox.Name = "ItemNameBox";
            this.ItemNameBox.Size = new System.Drawing.Size(318, 20);
            this.ItemNameBox.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.XUIDBox);
            this.groupBox4.Location = new System.Drawing.Point(306, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 44);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.Text = "XUID";
            // 
            // XUIDBox
            // 
            this.XUIDBox.EditValue = "0009000000000000";
            this.XUIDBox.Location = new System.Drawing.Point(6, 17);
            this.XUIDBox.Name = "XUIDBox";
            this.XUIDBox.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.XUIDBox.Properties.Appearance.Options.UseForeColor = true;
            this.XUIDBox.Properties.MaxLength = 16;
            this.XUIDBox.Size = new System.Drawing.Size(315, 20);
            this.XUIDBox.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GameNameBox);
            this.groupBox1.Location = new System.Drawing.Point(306, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 44);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.Text = "Game Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ItemIDBox);
            this.groupBox3.Location = new System.Drawing.Point(306, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 44);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.Text = "Item ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ItemNameBox);
            this.groupBox2.Location = new System.Drawing.Point(305, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 44);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.Text = "Item Name";
            // 
            // MPURLBox
            // 
            this.MPURLBox.EditValue = "http://marketplace.xbox.com/en-US/Product/Lancer/00001000-95ce-e253-cea4-b7824d53" +
    "08ab";
            this.MPURLBox.Location = new System.Drawing.Point(3, 3);
            this.MPURLBox.Name = "MPURLBox";
            this.MPURLBox.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.MPURLBox.Properties.Appearance.Options.UseForeColor = true;
            this.MPURLBox.Size = new System.Drawing.Size(626, 20);
            this.MPURLBox.TabIndex = 17;
            this.MPURLBox.TextChanged += new System.EventHandler(this.MPURLBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = ":: Check URL ::";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // AvatarItemDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 325);
            this.Controls.Add(this.DL_BTN);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MPURLBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AvatarItemDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avatar Item Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameNameBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemIDBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemNameBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XUIDBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MPURLBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit GameNameBox;
        private DevExpress.XtraEditors.SimpleButton DL_BTN;
        private DevExpress.XtraEditors.ProgressBarControl progressBar;
        private DevExpress.XtraEditors.TextEdit ItemIDBox;
        private DevExpress.XtraEditors.TextEdit ItemNameBox;
        private DevExpress.XtraEditors.GroupControl groupBox4;
        private DevExpress.XtraEditors.TextEdit XUIDBox;
        private DevExpress.XtraEditors.GroupControl groupBox1;
        private DevExpress.XtraEditors.GroupControl groupBox3;
        private DevExpress.XtraEditors.GroupControl groupBox2;
        private DevExpress.XtraEditors.TextEdit MPURLBox;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraEditors.ImageListBoxControl pictureBox1;
        //imageListBoxControl1
    }
}

