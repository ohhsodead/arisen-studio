namespace ModioX.Windows
{
    partial class InformationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationWindow));
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelEmailMe = new System.Windows.Forms.LinkLabel();
            this.ImageInformation = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(68, 15);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(260, 64);
            this.LabelDescription.TabIndex = 1;
            this.LabelDescription.Text = "This application was developed by mostlyash.\r\nAll credits goes to the appropriate c" +
    "reators\r\nof the mods used in this application.\r\nIf you have any questions,";
            // 
            // LabelEmailMe
            // 
            this.LabelEmailMe.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.LabelEmailMe.AutoSize = true;
            this.LabelEmailMe.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmailMe.LinkColor = System.Drawing.SystemColors.Highlight;
            this.LabelEmailMe.Location = new System.Drawing.Point(222, 63);
            this.LabelEmailMe.Name = "LabelEmailMe";
            this.LabelEmailMe.Size = new System.Drawing.Size(65, 16);
            this.LabelEmailMe.TabIndex = 1;
            this.LabelEmailMe.TabStop = true;
            this.LabelEmailMe.Text = "email me.";
            this.LabelEmailMe.VisitedLinkColor = System.Drawing.SystemColors.Highlight;
            this.LabelEmailMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelEmailMe_LinkClicked);
            // 
            // ImageInformation
            // 
            this.ImageInformation.Image = global::ModioX.Properties.Resources.InformationIcon;
            this.ImageInformation.Location = new System.Drawing.Point(14, 15);
            this.ImageInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImageInformation.Name = "ImageInformation";
            this.ImageInformation.Size = new System.Drawing.Size(47, 49);
            this.ImageInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageInformation.TabIndex = 11;
            this.ImageInformation.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial", 9F);
            this.button1.Location = new System.Drawing.Point(253, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InformationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 131);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ImageInformation);
            this.Controls.Add(this.LabelEmailMe);
            this.Controls.Add(this.LabelDescription);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformationWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            ((System.ComponentModel.ISupportInitialize)(this.ImageInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.LinkLabel LabelEmailMe;
        private System.Windows.Forms.PictureBox ImageInformation;
        private System.Windows.Forms.Button button1;
    }
}