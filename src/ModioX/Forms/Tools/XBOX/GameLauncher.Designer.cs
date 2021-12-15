
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Tools.XBOX
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLauncher));
            this.ListBoxGames = new DevExpress.XtraEditors.ListBoxControl();
            this.GroupGamesList = new DevExpress.XtraEditors.GroupControl();
            this.LabelNoGames = new DevExpress.XtraEditors.LabelControl();
            this.ButtonLaunchGame = new DevExpress.XtraEditors.SimpleButton();
            this.MenuStatus = new DevExpress.XtraBars.Bar();
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.LabelHeaderStatus = new DevExpress.XtraBars.BarStaticItem();
            this.LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGamesList)).BeginInit();
            this.GroupGamesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxGames
            // 
            this.ListBoxGames.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ListBoxGames.Appearance.Options.UseFont = true;
            this.ListBoxGames.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ListBoxGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxGames.Location = new System.Drawing.Point(2, 23);
            this.ListBoxGames.Name = "ListBoxGames";
            this.ListBoxGames.Size = new System.Drawing.Size(276, 255);
            this.ListBoxGames.TabIndex = 0;
            this.ListBoxGames.SelectedIndexChanged += new System.EventHandler(this.ListBoxGames_SelectedIndexChanged);
            // 
            // GroupGamesList
            // 
            this.GroupGamesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupGamesList.AppearanceCaption.FontSizeDelta = 1;
            this.GroupGamesList.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.GroupGamesList.AppearanceCaption.Options.UseFont = true;
            this.GroupGamesList.Controls.Add(this.LabelNoGames);
            this.GroupGamesList.Controls.Add(this.ListBoxGames);
            this.GroupGamesList.Location = new System.Drawing.Point(14, 14);
            this.GroupGamesList.Name = "GroupGamesList";
            this.GroupGamesList.Size = new System.Drawing.Size(280, 280);
            this.GroupGamesList.TabIndex = 11;
            this.GroupGamesList.Text = "Games List";
            // 
            // LabelNoGames
            // 
            this.LabelNoGames.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.LabelNoGames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNoGames.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LabelNoGames.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelNoGames.Appearance.Options.UseBackColor = true;
            this.LabelNoGames.Appearance.Options.UseFont = true;
            this.LabelNoGames.Appearance.Options.UseTextOptions = true;
            this.LabelNoGames.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LabelNoGames.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelNoGames.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelNoGames.Location = new System.Drawing.Point(21, 53);
            this.LabelNoGames.Name = "LabelNoGames";
            this.LabelNoGames.Size = new System.Drawing.Size(238, 60);
            this.LabelNoGames.TabIndex = 12;
            this.LabelNoGames.Text = "No games added yet.\r\n\r\nYou can add your game files using the\r\nFile Manager.";
            // 
            // ButtonLaunchGame
            // 
            this.ButtonLaunchGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLaunchGame.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonLaunchGame.Appearance.Options.UseFont = true;
            this.ButtonLaunchGame.Enabled = false;
            this.ButtonLaunchGame.Location = new System.Drawing.Point(189, 304);
            this.ButtonLaunchGame.Name = "ButtonLaunchGame";
            this.ButtonLaunchGame.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonLaunchGame.Size = new System.Drawing.Size(105, 25);
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
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.DockControls.Add(this.barDockControlTop);
            this.BarManager.DockControls.Add(this.barDockControlBottom);
            this.BarManager.DockControls.Add(this.barDockControlLeft);
            this.BarManager.DockControls.Add(this.barDockControlRight);
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.LabelHeaderStatus,
            this.LabelStatus});
            this.BarManager.MaxItemId = 20;
            this.BarManager.StatusBar = this.bar1;
            // 
            // bar1
            // 
            this.bar1.BarItemVertIndent = 4;
            this.bar1.BarName = "Status bar";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelHeaderStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelStatus)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Status bar";
            // 
            // LabelHeaderStatus
            // 
            this.LabelHeaderStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelHeaderStatus.Caption = "Status:";
            this.LabelHeaderStatus.Id = 6;
            this.LabelHeaderStatus.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderStatus.ItemAppearance.Normal.Options.UseFont = true;
            this.LabelHeaderStatus.LeftIndent = 2;
            this.LabelHeaderStatus.Name = "LabelHeaderStatus";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.LabelStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LabelStatus.Caption = "Idle";
            this.LabelStatus.Id = 7;
            this.LabelStatus.Name = "LabelStatus";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(308, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 344);
            this.barDockControlBottom.Manager = this.BarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(308, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 344);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(308, 0);
            this.barDockControlRight.Manager = this.BarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 344);
            // 
            // GameLauncher
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 367);
            this.Controls.Add(this.ButtonLaunchGame);
            this.Controls.Add(this.GroupGamesList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameLauncher.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameLauncher";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Launcher";
            this.Load += new System.EventHandler(this.GameLauncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGamesList)).EndInit();
            this.GroupGamesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBoxControl ListBoxGames;
        private GroupControl GroupGamesList;
        private SimpleButton ButtonLaunchGame;
        private DevExpress.XtraBars.Bar MenuStatus;
        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarStaticItem LabelHeaderStatus;
        private DevExpress.XtraBars.BarStaticItem LabelStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private LabelControl LabelNoGames;
    }
}