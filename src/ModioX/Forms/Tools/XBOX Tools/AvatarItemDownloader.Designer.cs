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
            this.TextBoxGameTitle = new DevExpress.XtraEditors.TextEdit();
            this.ButtonDownloadItem = new DevExpress.XtraEditors.SimpleButton();
            this.ProgressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.TextBoxItemID = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxItemName = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxXUID = new DevExpress.XtraEditors.TextEdit();
            this.TextBoxMarketplaceURL = new DevExpress.XtraEditors.TextEdit();
            this.ButtonCheckURL = new DevExpress.XtraEditors.SimpleButton();
            this.LabelSearch = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ImageAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxXUID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMarketplaceURL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxGameTitle
            // 
            this.TextBoxGameTitle.Location = new System.Drawing.Point(8, 148);
            this.TextBoxGameTitle.Name = "TextBoxGameTitle";
            this.TextBoxGameTitle.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxGameTitle.Properties.Appearance.Options.UseFont = true;
            this.TextBoxGameTitle.Size = new System.Drawing.Size(346, 22);
            this.TextBoxGameTitle.TabIndex = 2;
            // 
            // ButtonDownloadItem
            // 
            this.ButtonDownloadItem.Location = new System.Drawing.Point(186, 229);
            this.ButtonDownloadItem.Name = "ButtonDownloadItem";
            this.ButtonDownloadItem.Size = new System.Drawing.Size(168, 27);
            this.ButtonDownloadItem.TabIndex = 5;
            this.ButtonDownloadItem.Text = "Download Item";
            this.ButtonDownloadItem.Click += new System.EventHandler(this.ButtonDownloadItem_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 22);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ProgressBar.Size = new System.Drawing.Size(636, 12);
            this.ProgressBar.TabIndex = 20;
            this.ProgressBar.Visible = false;
            // 
            // TextBoxItemID
            // 
            this.TextBoxItemID.EditValue = "0000100095CEE253CEA4B7824D5308AB";
            this.TextBoxItemID.Enabled = false;
            this.TextBoxItemID.Location = new System.Drawing.Point(8, 99);
            this.TextBoxItemID.Name = "TextBoxItemID";
            this.TextBoxItemID.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxItemID.Properties.Appearance.Options.UseFont = true;
            this.TextBoxItemID.Size = new System.Drawing.Size(346, 22);
            this.TextBoxItemID.TabIndex = 1;
            // 
            // TextBoxItemName
            // 
            this.TextBoxItemName.EditValue = "Lancer";
            this.TextBoxItemName.Enabled = false;
            this.TextBoxItemName.Location = new System.Drawing.Point(8, 50);
            this.TextBoxItemName.Name = "TextBoxItemName";
            this.TextBoxItemName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxItemName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxItemName.Size = new System.Drawing.Size(346, 22);
            this.TextBoxItemName.TabIndex = 1;
            // 
            // TextBoxXUID
            // 
            this.TextBoxXUID.EditValue = "0009000000000000";
            this.TextBoxXUID.Location = new System.Drawing.Point(8, 197);
            this.TextBoxXUID.Name = "TextBoxXUID";
            this.TextBoxXUID.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxXUID.Properties.Appearance.Options.UseFont = true;
            this.TextBoxXUID.Properties.MaxLength = 16;
            this.TextBoxXUID.Size = new System.Drawing.Size(346, 22);
            this.TextBoxXUID.TabIndex = 3;
            // 
            // TextBoxMarketplaceURL
            // 
            this.TextBoxMarketplaceURL.EditValue = "http://marketplace.xbox.com/en-US/Product/Lancer/00001000-95ce-e253-cea4-b7824d53" +
    "08ab";
            this.TextBoxMarketplaceURL.Location = new System.Drawing.Point(12, 3);
            this.TextBoxMarketplaceURL.Name = "TextBoxMarketplaceURL";
            this.TextBoxMarketplaceURL.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TextBoxMarketplaceURL.Properties.Appearance.Options.UseForeColor = true;
            this.TextBoxMarketplaceURL.Size = new System.Drawing.Size(636, 20);
            this.TextBoxMarketplaceURL.TabIndex = 0;
            this.TextBoxMarketplaceURL.EditValueChanged += new System.EventHandler(this.TextBoxMarketplaceURL_EditValueChanged);
            // 
            // ButtonCheckURL
            // 
            this.ButtonCheckURL.Location = new System.Drawing.Point(8, 229);
            this.ButtonCheckURL.Name = "ButtonCheckURL";
            this.ButtonCheckURL.Size = new System.Drawing.Size(172, 27);
            this.ButtonCheckURL.TabIndex = 4;
            this.ButtonCheckURL.Text = "Check URL";
            this.ButtonCheckURL.Click += new System.EventHandler(this.ButtonCheckURL_Click);
            // 
            // LabelSearch
            // 
            this.LabelSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.Appearance.Options.UseFont = true;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSearch.Location = new System.Drawing.Point(8, 30);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelSearch.Size = new System.Drawing.Size(68, 15);
            this.LabelSearch.TabIndex = 1175;
            this.LabelSearch.Text = "Item Name:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl1.Location = new System.Drawing.Point(8, 79);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl1.Size = new System.Drawing.Size(47, 15);
            this.labelControl1.TabIndex = 1176;
            this.labelControl1.Text = "Item ID:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl2.Location = new System.Drawing.Point(8, 128);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl2.Size = new System.Drawing.Size(65, 15);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Game Title:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl3.Location = new System.Drawing.Point(8, 177);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.labelControl3.Size = new System.Drawing.Size(35, 15);
            this.labelControl3.TabIndex = 1178;
            this.labelControl3.Text = "XUID:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LabelSearch);
            this.groupControl1.Controls.Add(this.ButtonCheckURL);
            this.groupControl1.Controls.Add(this.TextBoxXUID);
            this.groupControl1.Controls.Add(this.ButtonDownloadItem);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TextBoxItemName);
            this.groupControl1.Controls.Add(this.TextBoxGameTitle);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TextBoxItemID);
            this.groupControl1.Location = new System.Drawing.Point(285, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(363, 266);
            this.groupControl1.TabIndex = 1180;
            this.groupControl1.Text = "Avatar Details";
            // 
            // ImageAvatar
            // 
            this.ImageAvatar.Location = new System.Drawing.Point(12, 40);
            this.ImageAvatar.Name = "ImageAvatar";
            this.ImageAvatar.Size = new System.Drawing.Size(267, 267);
            this.ImageAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageAvatar.TabIndex = 1181;
            this.ImageAvatar.TabStop = false;
            // 
            // AvatarItemDownloader
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 319);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ImageAvatar);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.TextBoxMarketplaceURL);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AvatarItemDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Avatar Item Downloader";
            this.Load += new System.EventHandler(this.AvatarItemDownloader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGameTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxXUID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxMarketplaceURL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TextBoxGameTitle;
        private DevExpress.XtraEditors.SimpleButton ButtonDownloadItem;
        private DevExpress.XtraEditors.ProgressBarControl ProgressBar;
        private DevExpress.XtraEditors.TextEdit TextBoxItemID;
        private DevExpress.XtraEditors.TextEdit TextBoxItemName;
        private DevExpress.XtraEditors.TextEdit TextBoxXUID;
        private DevExpress.XtraEditors.TextEdit TextBoxMarketplaceURL;
        private DevExpress.XtraEditors.SimpleButton ButtonCheckURL;
        private DevExpress.XtraEditors.LabelControl LabelSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.PictureBox ImageAvatar;
        //imageListBoxControl1
    }
}

