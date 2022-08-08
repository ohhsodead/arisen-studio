using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VScrollBar = DevExpress.XtraEditors.VScrollBar;

namespace ArisenStudio.Forms.Tools.XBOX
{
    partial class ConsoleManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleManager));
            this.GroupConsoleProfiles = new DevExpress.XtraEditors.GroupControl();
            this.NoConsoleProfiles = new ArisenStudio.Controls.NoProfilesItem();
            this.ScrollBarConsoleProfiles = new DevExpress.XtraEditors.VScrollBar();
            this.PanelConsoleProfiles = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddNewProfile = new DevExpress.XtraEditors.SimpleButton();
            this.PopupMenuActions = new DevExpress.XtraBars.PopupMenu(this.components);
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonEditProfile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteProfile = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupConsoleProfiles)).BeginInit();
            this.GroupConsoleProfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupConsoleProfiles
            // 
            this.GroupConsoleProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupConsoleProfiles.Controls.Add(this.NoConsoleProfiles);
            this.GroupConsoleProfiles.Controls.Add(this.ScrollBarConsoleProfiles);
            this.GroupConsoleProfiles.Controls.Add(this.PanelConsoleProfiles);
            this.GroupConsoleProfiles.Location = new System.Drawing.Point(12, 12);
            this.GroupConsoleProfiles.Name = "GroupConsoleProfiles";
            this.GroupConsoleProfiles.Size = new System.Drawing.Size(480, 368);
            this.GroupConsoleProfiles.TabIndex = 7;
            this.GroupConsoleProfiles.Text = "Console Profiles";
            // 
            // NoConsoleProfiles
            // 
            this.NoConsoleProfiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoConsoleProfiles.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.NoConsoleProfiles.Appearance.Options.UseBackColor = true;
            this.NoConsoleProfiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NoConsoleProfiles.Location = new System.Drawing.Point(26, 44);
            this.NoConsoleProfiles.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.NoConsoleProfiles.Name = "NoConsoleProfiles";
            this.NoConsoleProfiles.Size = new System.Drawing.Size(428, 288);
            this.NoConsoleProfiles.TabIndex = 2;
            this.NoConsoleProfiles.TabStop = false;
            this.NoConsoleProfiles.Visible = false;
            // 
            // ScrollBarConsoleProfiles
            // 
            this.ScrollBarConsoleProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarConsoleProfiles.Location = new System.Drawing.Point(461, 22);
            this.ScrollBarConsoleProfiles.Name = "ScrollBarConsoleProfiles";
            this.ScrollBarConsoleProfiles.Size = new System.Drawing.Size(17, 344);
            this.ScrollBarConsoleProfiles.TabIndex = 1;
            this.ScrollBarConsoleProfiles.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarConsoleProfiles_Scroll);
            // 
            // PanelConsoleProfiles
            // 
            this.PanelConsoleProfiles.AutoScroll = true;
            this.PanelConsoleProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelConsoleProfiles.Location = new System.Drawing.Point(2, 21);
            this.PanelConsoleProfiles.Name = "PanelConsoleProfiles";
            this.PanelConsoleProfiles.Padding = new System.Windows.Forms.Padding(4);
            this.PanelConsoleProfiles.Size = new System.Drawing.Size(476, 345);
            this.PanelConsoleProfiles.TabIndex = 0;
            this.PanelConsoleProfiles.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PanelConsoleProfiles_Scroll);
            this.PanelConsoleProfiles.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PanelConsoleProfiles_ControlAddedOrRemoved);
            this.PanelConsoleProfiles.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PanelConsoleProfiles_ControlAddedOrRemoved);
            // 
            // ButtonAddNewProfile
            // 
            this.ButtonAddNewProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddNewProfile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAddNewProfile.Appearance.Options.UseFont = true;
            this.ButtonAddNewProfile.Appearance.Options.UseTextOptions = true;
            this.ButtonAddNewProfile.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ButtonAddNewProfile.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ButtonAddNewProfile.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAddNewProfile.AppearanceDisabled.Options.UseFont = true;
            this.ButtonAddNewProfile.AppearanceDisabled.Options.UseTextOptions = true;
            this.ButtonAddNewProfile.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ButtonAddNewProfile.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ButtonAddNewProfile.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonAddNewProfile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonAddNewProfile.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonAddNewProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonAddNewProfile.ImageOptions.SvgImage")));
            this.ButtonAddNewProfile.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonAddNewProfile.Location = new System.Drawing.Point(12, 386);
            this.ButtonAddNewProfile.Name = "ButtonAddNewProfile";
            this.ButtonAddNewProfile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonAddNewProfile.Size = new System.Drawing.Size(132, 26);
            this.ButtonAddNewProfile.TabIndex = 8;
            this.ButtonAddNewProfile.Text = "Add Xbox 360";
            this.ButtonAddNewProfile.Click += new System.EventHandler(this.ButtonAddNewConsole_Click);
            // 
            // PopupMenuActions
            // 
            this.PopupMenuActions.Name = "PopupMenuActions";
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonDeleteProfile);
            this.PanelButtons.Controls.Add(this.ButtonEditProfile);
            this.PanelButtons.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.PanelButtons.Location = new System.Drawing.Point(214, 386);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(276, 26);
            this.PanelButtons.TabIndex = 0;
            // 
            // ButtonEditProfile
            // 
            this.ButtonEditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEditProfile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonEditProfile.Appearance.Options.UseFont = true;
            this.ButtonEditProfile.Enabled = false;
            this.ButtonEditProfile.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonEditProfile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonEditProfile.ImageOptions.ImageToTextIndent = 5;
            this.ButtonEditProfile.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonEditProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonEditProfile.ImageOptions.SvgImage")));
            this.ButtonEditProfile.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonEditProfile.Location = new System.Drawing.Point(69, 0);
            this.ButtonEditProfile.Name = "ButtonEditProfile";
            this.ButtonEditProfile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonEditProfile.Size = new System.Drawing.Size(94, 26);
            this.ButtonEditProfile.TabIndex = 1;
            this.ButtonEditProfile.Text = "Edit Console";
            this.ButtonEditProfile.Click += new System.EventHandler(this.ButtonEditConsole_Click);
            // 
            // ButtonDeleteProfile
            // 
            this.ButtonDeleteProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeleteProfile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDeleteProfile.Appearance.Options.UseFont = true;
            this.ButtonDeleteProfile.Enabled = false;
            this.ButtonDeleteProfile.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonDeleteProfile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonDeleteProfile.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonDeleteProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonDeleteProfile.ImageOptions.SvgImage")));
            this.ButtonDeleteProfile.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonDeleteProfile.Location = new System.Drawing.Point(169, 0);
            this.ButtonDeleteProfile.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ButtonDeleteProfile.Name = "ButtonDeleteProfile";
            this.ButtonDeleteProfile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteProfile.Size = new System.Drawing.Size(107, 26);
            this.ButtonDeleteProfile.TabIndex = 2;
            this.ButtonDeleteProfile.Text = "Delete Console";
            this.ButtonDeleteProfile.Click += new System.EventHandler(this.ButtonDeleteConsole_Click);
            // 
            // ConsoleManager
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(504, 424);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.ButtonAddNewProfile);
            this.Controls.Add(this.GroupConsoleProfiles);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsoleManager";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Console Manager";
            this.Load += new System.EventHandler(this.ConsoleManager_Load);
            this.SizeChanged += new System.EventHandler(this.ConnectionDialog_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GroupConsoleProfiles)).EndInit();
            this.GroupConsoleProfiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopupMenuActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupControl GroupConsoleProfiles;
        private VScrollBar ScrollBarConsoleProfiles;
        private FlowLayoutPanel PanelConsoleProfiles;
        private SimpleButton ButtonAddNewProfile;
        private Controls.NoProfilesItem NoConsoleProfiles;
        private DevExpress.XtraBars.PopupMenu PopupMenuActions;
        private DevExpress.Utils.Layout.StackPanel PanelButtons;
        private SimpleButton ButtonDeleteProfile;
        private SimpleButton ButtonEditProfile;
    }
}