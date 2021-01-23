namespace ModioX.Forms.Tools.XBOX_Tools
{
    partial class Form1
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
            this.GameNameBox = new System.Windows.Forms.TextBox();
            this.DL_BTN = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ItemIDBox = new System.Windows.Forms.TextBox();
            this.ItemNameBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.XUIDBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BLKDTH_LOGO_BOX = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MPURLBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BLKDTH_LOGO_BOX)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameNameBox
            // 
            this.GameNameBox.Location = new System.Drawing.Point(6, 17);
            this.GameNameBox.Name = "GameNameBox";
            this.GameNameBox.Size = new System.Drawing.Size(318, 22);
            this.GameNameBox.TabIndex = 13;
            this.GameNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DL_BTN
            // 
            this.DL_BTN.Location = new System.Drawing.Point(527, 229);
            this.DL_BTN.Name = "DL_BTN";
            this.DL_BTN.Size = new System.Drawing.Size(105, 23);
            this.DL_BTN.TabIndex = 19;
            this.DL_BTN.Text = ":: Download Item ::";
            this.DL_BTN.UseVisualStyleBackColor = true;
            this.DL_BTN.Click += new System.EventHandler(this.DL_BTN_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 26);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 10);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 20;
            this.progressBar.Visible = false;
            // 
            // ItemIDBox
            // 
            this.ItemIDBox.Enabled = false;
            this.ItemIDBox.Location = new System.Drawing.Point(6, 16);
            this.ItemIDBox.Name = "ItemIDBox";
            this.ItemIDBox.Size = new System.Drawing.Size(318, 22);
            this.ItemIDBox.TabIndex = 4;
            this.ItemIDBox.Text = "0000100095CEE253CEA4B7824D5308AB";
            this.ItemIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemNameBox
            // 
            this.ItemNameBox.Enabled = false;
            this.ItemNameBox.Location = new System.Drawing.Point(6, 16);
            this.ItemNameBox.Name = "ItemNameBox";
            this.ItemNameBox.Size = new System.Drawing.Size(318, 22);
            this.ItemNameBox.TabIndex = 3;
            this.ItemNameBox.Text = "Lancer";
            this.ItemNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.XUIDBox);
            this.groupBox4.Location = new System.Drawing.Point(306, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 44);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "XUID";
            // 
            // XUIDBox
            // 
            this.XUIDBox.Location = new System.Drawing.Point(6, 17);
            this.XUIDBox.MaxLength = 16;
            this.XUIDBox.Name = "XUIDBox";
            this.XUIDBox.Size = new System.Drawing.Size(315, 22);
            this.XUIDBox.TabIndex = 16;
            this.XUIDBox.Text = "0009000000000000";
            this.XUIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GameNameBox);
            this.groupBox1.Location = new System.Drawing.Point(306, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 44);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Name";
            // 
            // BLKDTH_LOGO_BOX
            // 
            this.BLKDTH_LOGO_BOX.ErrorImage = null;
            this.BLKDTH_LOGO_BOX.InitialImage = null;
            this.BLKDTH_LOGO_BOX.Location = new System.Drawing.Point(304, 251);
            this.BLKDTH_LOGO_BOX.Name = "BLKDTH_LOGO_BOX";
            this.BLKDTH_LOGO_BOX.Size = new System.Drawing.Size(335, 87);
            this.BLKDTH_LOGO_BOX.TabIndex = 24;
            this.BLKDTH_LOGO_BOX.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ItemIDBox);
            this.groupBox3.Location = new System.Drawing.Point(306, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 44);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ItemNameBox);
            this.groupBox2.Location = new System.Drawing.Point(305, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 44);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Name";
            // 
            // MPURLBox
            // 
            this.MPURLBox.Location = new System.Drawing.Point(3, 3);
            this.MPURLBox.Name = "MPURLBox";
            this.MPURLBox.Size = new System.Drawing.Size(626, 22);
            this.MPURLBox.TabIndex = 17;
            this.MPURLBox.Text = "http://marketplace.xbox.com/en-US/Product/Lancer/00001000-95ce-e253-cea4-b7824d53" +
    "08ab";
            this.MPURLBox.TextChanged += new System.EventHandler(this.MPURLBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = ":: Check URL ::";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 341);
            this.Controls.Add(this.DL_BTN);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BLKDTH_LOGO_BOX);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MPURLBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avatar Item Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BLKDTH_LOGO_BOX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GameNameBox;
        private System.Windows.Forms.Button DL_BTN;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox ItemIDBox;
        private System.Windows.Forms.TextBox ItemNameBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox XUIDBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox BLKDTH_LOGO_BOX;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox MPURLBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

