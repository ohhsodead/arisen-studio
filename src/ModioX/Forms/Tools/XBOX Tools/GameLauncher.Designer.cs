
namespace ModioX.Forms.Tools.XBOX_Tools
{
    partial class GameLauncher
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
            this.ButtonFetchGames = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxGamesPath = new DevExpress.XtraEditors.TextEdit();
            this.CheckBoxCloseOnLaunch = new DevExpress.XtraEditors.CheckEdit();
            this.ListBoxGames = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGamesPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxCloseOnLaunch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxGames)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFetchGames
            // 
            this.ButtonFetchGames.Location = new System.Drawing.Point(12, 434);
            this.ButtonFetchGames.Name = "ButtonFetchGames";
            this.ButtonFetchGames.Size = new System.Drawing.Size(96, 23);
            this.ButtonFetchGames.TabIndex = 7;
            this.ButtonFetchGames.Text = "Fetch Games";
            this.ButtonFetchGames.Click += new System.EventHandler(this.ButtonFetchGames_Click);
            // 
            // TextBoxGamesPath
            // 
            this.TextBoxGamesPath.EditValue = "Hdd:\\\\";
            this.TextBoxGamesPath.Location = new System.Drawing.Point(114, 435);
            this.TextBoxGamesPath.Name = "TextBoxGamesPath";
            this.TextBoxGamesPath.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxGamesPath.Properties.Appearance.Options.UseFont = true;
            this.TextBoxGamesPath.Size = new System.Drawing.Size(240, 22);
            this.TextBoxGamesPath.TabIndex = 9;
            // 
            // CheckBoxCloseOnLaunch
            // 
            this.CheckBoxCloseOnLaunch.Location = new System.Drawing.Point(12, 5);
            this.CheckBoxCloseOnLaunch.Name = "CheckBoxCloseOnLaunch";
            this.CheckBoxCloseOnLaunch.Properties.Caption = "Close On Launch";
            this.CheckBoxCloseOnLaunch.Size = new System.Drawing.Size(342, 18);
            this.CheckBoxCloseOnLaunch.TabIndex = 8;
            // 
            // ListBoxGames
            // 
            this.ListBoxGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxGames.Location = new System.Drawing.Point(12, 29);
            this.ListBoxGames.Name = "ListBoxGames";
            this.ListBoxGames.Size = new System.Drawing.Size(342, 400);
            this.ListBoxGames.TabIndex = 10;
            // 
            // GameLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 466);
            this.Controls.Add(this.ListBoxGames);
            this.Controls.Add(this.TextBoxGamesPath);
            this.Controls.Add(this.CheckBoxCloseOnLaunch);
            this.Controls.Add(this.ButtonFetchGames);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Launcher";
            this.Load += new System.EventHandler(this.GameLauncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGamesPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxCloseOnLaunch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton ButtonFetchGames;
        private DevExpress.XtraEditors.CheckEdit CheckBoxCloseOnLaunch;
        private DevExpress.XtraEditors.TextEdit TextBoxGamesPath;
        private DevExpress.XtraEditors.ListBoxControl ListBoxGames;
    }
}