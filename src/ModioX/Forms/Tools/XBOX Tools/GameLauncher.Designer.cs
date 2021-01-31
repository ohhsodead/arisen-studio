
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
            this.ListBoxGames = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxGames)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxGames
            // 
            this.ListBoxGames.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListBoxGames.Location = new System.Drawing.Point(0, 3);
            this.ListBoxGames.Name = "ListBoxGames";
            this.ListBoxGames.Size = new System.Drawing.Size(366, 454);
            this.ListBoxGames.TabIndex = 10;
            // 
            // GameLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 457);
            this.Controls.Add(this.ListBoxGames);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Launcher";
            this.Load += new System.EventHandler(this.GameLauncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ListBoxControl ListBoxGames;
    }
}