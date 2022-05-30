
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace NeoModsX.Forms.Tools.XBOX
{
    partial class GameLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLauncher));
            this.ListBoxGames = new DevExpress.XtraEditors.ListBoxControl();
            this.GroupGames = new DevExpress.XtraEditors.GroupControl();
            this.LabelNoGames = new DevExpress.XtraEditors.LabelControl();
            this.ButtonLaunchGame = new DevExpress.XtraEditors.SimpleButton();
            this.MenuStatus = new DevExpress.XtraBars.Bar();
            this.ButtonEditName = new DevExpress.XtraEditors.SimpleButton();
            this.PanelButtonsLeft = new DevExpress.Utils.Layout.StackPanel();
            this.PanelButtonsRight = new DevExpress.Utils.Layout.StackPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGames)).BeginInit();
            this.GroupGames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsLeft)).BeginInit();
            this.PanelButtonsLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsRight)).BeginInit();
            this.PanelButtonsRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxGames
            // 
            this.ListBoxGames.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ListBoxGames.Appearance.Options.UseFont = true;
            this.ListBoxGames.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ListBoxGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxGames.Location = new System.Drawing.Point(0, 25);
            this.ListBoxGames.Name = "ListBoxGames";
            this.ListBoxGames.Size = new System.Drawing.Size(284, 288);
            this.ListBoxGames.TabIndex = 0;
            this.ListBoxGames.SelectedIndexChanged += new System.EventHandler(this.ListBoxGames_SelectedIndexChanged);
            // 
            // GroupGames
            // 
            this.GroupGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupGames.AppearanceCaption.FontSizeDelta = 1;
            this.GroupGames.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.GroupGames.AppearanceCaption.Options.UseFont = true;
            this.GroupGames.Controls.Add(this.LabelNoGames);
            this.GroupGames.Controls.Add(this.ListBoxGames);
            this.GroupGames.Location = new System.Drawing.Point(12, 12);
            this.GroupGames.Name = "GroupGames";
            this.GroupGames.Size = new System.Drawing.Size(284, 313);
            this.GroupGames.TabIndex = 11;
            this.GroupGames.Text = "Games";
            // 
            // LabelNoGames
            // 
            this.LabelNoGames.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.LabelNoGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNoGames.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.LabelNoGames.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelNoGames.Appearance.Options.UseBackColor = true;
            this.LabelNoGames.Appearance.Options.UseFont = true;
            this.LabelNoGames.Appearance.Options.UseTextOptions = true;
            this.LabelNoGames.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LabelNoGames.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelNoGames.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelNoGames.Location = new System.Drawing.Point(31, 70);
            this.LabelNoGames.Name = "LabelNoGames";
            this.LabelNoGames.Size = new System.Drawing.Size(222, 60);
            this.LabelNoGames.TabIndex = 12;
            this.LabelNoGames.Text = "No games added yet.\r\n\r\nYou can add your game files using the File Manager.";
            // 
            // ButtonLaunchGame
            // 
            this.ButtonLaunchGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLaunchGame.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonLaunchGame.Appearance.Options.UseFont = true;
            this.ButtonLaunchGame.AutoSize = true;
            this.ButtonLaunchGame.Enabled = false;
            this.ButtonLaunchGame.Location = new System.Drawing.Point(42, 0);
            this.ButtonLaunchGame.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonLaunchGame.Name = "ButtonLaunchGame";
            this.ButtonLaunchGame.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonLaunchGame.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonLaunchGame.Size = new System.Drawing.Size(104, 24);
            this.ButtonLaunchGame.TabIndex = 1;
            this.ButtonLaunchGame.Text = "Launch Game";
            this.ButtonLaunchGame.Click += new System.EventHandler(this.ButtonLaunchGame_Click);
            // 
            // MenuStatus
            // 
            this.MenuStatus.BarItemVertIndent = 4;
            this.MenuStatus.BarName = "Status bar";
            this.MenuStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.MenuStatus.DockCol = 0;
            this.MenuStatus.DockRow = 0;
            this.MenuStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.MenuStatus.OptionsBar.AllowQuickCustomization = false;
            this.MenuStatus.OptionsBar.DrawDragBorder = false;
            this.MenuStatus.OptionsBar.UseWholeRow = true;
            this.MenuStatus.Text = "Status bar";
            // 
            // ButtonEditName
            // 
            this.ButtonEditName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonEditName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonEditName.Appearance.Options.UseFont = true;
            this.ButtonEditName.AutoSize = true;
            this.ButtonEditName.Enabled = false;
            this.ButtonEditName.Location = new System.Drawing.Point(0, 0);
            this.ButtonEditName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonEditName.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonEditName.Name = "ButtonEditName";
            this.ButtonEditName.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonEditName.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonEditName.Size = new System.Drawing.Size(86, 24);
            this.ButtonEditName.TabIndex = 16;
            this.ButtonEditName.Text = "Edit Name";
            this.ButtonEditName.Click += new System.EventHandler(this.ButtonEditName_Click);
            // 
            // PanelButtonsLeft
            // 
            this.PanelButtonsLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelButtonsLeft.Controls.Add(this.ButtonEditName);
            this.PanelButtonsLeft.Location = new System.Drawing.Point(12, 331);
            this.PanelButtonsLeft.Name = "PanelButtonsLeft";
            this.PanelButtonsLeft.Size = new System.Drawing.Size(129, 24);
            this.PanelButtonsLeft.TabIndex = 1185;
            // 
            // PanelButtonsRight
            // 
            this.PanelButtonsRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtonsRight.Controls.Add(this.ButtonLaunchGame);
            this.PanelButtonsRight.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.PanelButtonsRight.Location = new System.Drawing.Point(147, 331);
            this.PanelButtonsRight.Name = "PanelButtonsRight";
            this.PanelButtonsRight.Size = new System.Drawing.Size(149, 24);
            this.PanelButtonsRight.TabIndex = 1186;
            // 
            // GameLauncher
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 367);
            this.Controls.Add(this.PanelButtonsLeft);
            this.Controls.Add(this.PanelButtonsRight);
            this.Controls.Add(this.GroupGames);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameLauncher.IconOptions.Icon")));
            this.IconOptions.Image = global::NeoModsX.Properties.Resources.neomodsx;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 400);
            this.Name = "GameLauncher";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Launcher";
            this.Load += new System.EventHandler(this.GameLauncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGames)).EndInit();
            this.GroupGames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsLeft)).EndInit();
            this.PanelButtonsLeft.ResumeLayout(false);
            this.PanelButtonsLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsRight)).EndInit();
            this.PanelButtonsRight.ResumeLayout(false);
            this.PanelButtonsRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ListBoxControl ListBoxGames;
        private GroupControl GroupGames;
        private SimpleButton ButtonLaunchGame;
        private DevExpress.XtraBars.Bar MenuStatus;
        private LabelControl LabelNoGames;
        private SimpleButton ButtonEditName;
        private DevExpress.Utils.Layout.StackPanel PanelButtonsLeft;
        private DevExpress.Utils.Layout.StackPanel PanelButtonsRight;
    }
}