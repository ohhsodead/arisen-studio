namespace ArisenStudio.Forms.Dialogs
{
    partial class SetupWizardDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupWizardDialog));
            this.WizardControlMain = new DevExpress.XtraWizard.WizardControl();
            this.WizardPageWelcome = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.LabelAbout = new DevExpress.XtraEditors.LabelControl();
            this.TabControlChangeLog = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageChangeLog = new DevExpress.XtraTab.XtraTabPage();
            this.PanelChangeLog = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelChangeLogVersion = new DevExpress.XtraEditors.LabelControl();
            this.LabelChangeLog = new DevExpress.XtraEditors.LabelControl();
            this.WizardPageConsoleProfiles = new DevExpress.XtraWizard.WizardPage();
            this.NoConsoleProfiles = new ArisenStudio.Controls.NoProfilesItem();
            this.ScrollBarConsoleProfiles = new DevExpress.XtraEditors.VScrollBar();
            this.PanelConsoleProfiles = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonDeleteProfile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonEditProfile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonFindConsoles = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonAddNewProfile = new DevExpress.XtraEditors.SimpleButton();
            this.WizardPageComplete = new DevExpress.XtraWizard.CompletionWizardPage();
            this.Label = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.WizardControlMain)).BeginInit();
            this.WizardControlMain.SuspendLayout();
            this.WizardPageWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlChangeLog)).BeginInit();
            this.TabControlChangeLog.SuspendLayout();
            this.TabPageChangeLog.SuspendLayout();
            this.PanelChangeLog.SuspendLayout();
            this.WizardPageConsoleProfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.WizardPageComplete.SuspendLayout();
            this.SuspendLayout();
            // 
            // WizardControlMain
            // 
            this.WizardControlMain.Controls.Add(this.WizardPageWelcome);
            this.WizardControlMain.Controls.Add(this.WizardPageConsoleProfiles);
            this.WizardControlMain.Controls.Add(this.WizardPageComplete);
            this.WizardControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WizardControlMain.Name = "WizardControlMain";
            this.WizardControlMain.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.WizardPageWelcome,
            this.WizardPageConsoleProfiles,
            this.WizardPageComplete});
            this.WizardControlMain.Size = new System.Drawing.Size(692, 506);
            this.WizardControlMain.Text = "Arisen Studio";
            this.WizardControlMain.UseCancelButton = false;
            this.WizardControlMain.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.WizardControlMain.CancelClick += new System.ComponentModel.CancelEventHandler(this.WizardControlMain_CancelClick);
            this.WizardControlMain.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.WizardControlMain_NextClick);
            // 
            // WizardPageWelcome
            // 
            this.WizardPageWelcome.Controls.Add(this.LabelAbout);
            this.WizardPageWelcome.Controls.Add(this.TabControlChangeLog);
            this.WizardPageWelcome.Name = "WizardPageWelcome";
            this.WizardPageWelcome.Size = new System.Drawing.Size(632, 339);
            this.WizardPageWelcome.Text = "Welcome to Arisen Studio";
            // 
            // LabelAbout
            // 
            this.LabelAbout.AllowHtmlString = true;
            this.LabelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAbout.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelAbout.Appearance.Options.UseFont = true;
            this.LabelAbout.Appearance.Options.UseTextOptions = true;
            this.LabelAbout.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LabelAbout.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.LabelAbout.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelAbout.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelAbout.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelAbout.Location = new System.Drawing.Point(0, 0);
            this.LabelAbout.Name = "LabelAbout";
            this.LabelAbout.Size = new System.Drawing.Size(323, 192);
            this.LabelAbout.TabIndex = 1173;
            this.LabelAbout.Text = resources.GetString("LabelAbout.Text");
            // 
            // TabControlChangeLog
            // 
            this.TabControlChangeLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.TabControlChangeLog.Location = new System.Drawing.Point(329, 0);
            this.TabControlChangeLog.Name = "TabControlChangeLog";
            this.TabControlChangeLog.SelectedTabPage = this.TabPageChangeLog;
            this.TabControlChangeLog.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.False;
            this.TabControlChangeLog.Size = new System.Drawing.Size(303, 339);
            this.TabControlChangeLog.TabIndex = 1172;
            this.TabControlChangeLog.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageChangeLog});
            // 
            // TabPageChangeLog
            // 
            this.TabPageChangeLog.Controls.Add(this.PanelChangeLog);
            this.TabPageChangeLog.Name = "TabPageChangeLog";
            this.TabPageChangeLog.Size = new System.Drawing.Size(301, 315);
            this.TabPageChangeLog.Text = "Change Log";
            // 
            // PanelChangeLog
            // 
            this.PanelChangeLog.AutoScroll = true;
            this.PanelChangeLog.BackColor = System.Drawing.Color.Transparent;
            this.PanelChangeLog.Controls.Add(this.LabelChangeLogVersion);
            this.PanelChangeLog.Controls.Add(this.LabelChangeLog);
            this.PanelChangeLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChangeLog.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PanelChangeLog.Location = new System.Drawing.Point(0, 0);
            this.PanelChangeLog.Name = "PanelChangeLog";
            this.PanelChangeLog.Padding = new System.Windows.Forms.Padding(2);
            this.PanelChangeLog.Size = new System.Drawing.Size(301, 315);
            this.PanelChangeLog.TabIndex = 2;
            // 
            // LabelChangeLogVersion
            // 
            this.LabelChangeLogVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LabelChangeLogVersion.Appearance.Options.UseFont = true;
            this.LabelChangeLogVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelChangeLogVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelChangeLogVersion.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelChangeLogVersion.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelChangeLogVersion.Location = new System.Drawing.Point(5, 5);
            this.LabelChangeLogVersion.Name = "LabelChangeLogVersion";
            this.LabelChangeLogVersion.Size = new System.Drawing.Size(264, 18);
            this.LabelChangeLogVersion.TabIndex = 1168;
            this.LabelChangeLogVersion.Text = "Title";
            // 
            // LabelChangeLog
            // 
            this.LabelChangeLog.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelChangeLog.Appearance.Options.UseFont = true;
            this.LabelChangeLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelChangeLog.Location = new System.Drawing.Point(5, 29);
            this.LabelChangeLog.Name = "LabelChangeLog";
            this.LabelChangeLog.Size = new System.Drawing.Size(27, 15);
            this.LabelChangeLog.TabIndex = 1169;
            this.LabelChangeLog.Text = "Body";
            // 
            // WizardPageConsoleProfiles
            // 
            this.WizardPageConsoleProfiles.Controls.Add(this.NoConsoleProfiles);
            this.WizardPageConsoleProfiles.Controls.Add(this.ScrollBarConsoleProfiles);
            this.WizardPageConsoleProfiles.Controls.Add(this.PanelConsoleProfiles);
            this.WizardPageConsoleProfiles.Controls.Add(this.PanelButtons);
            this.WizardPageConsoleProfiles.Name = "WizardPageConsoleProfiles";
            this.WizardPageConsoleProfiles.Size = new System.Drawing.Size(632, 339);
            this.WizardPageConsoleProfiles.Text = "Console Profiles";
            // 
            // NoConsoleProfiles
            // 
            this.NoConsoleProfiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoConsoleProfiles.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.NoConsoleProfiles.Appearance.Options.UseBackColor = true;
            this.NoConsoleProfiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NoConsoleProfiles.Location = new System.Drawing.Point(102, 63);
            this.NoConsoleProfiles.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.NoConsoleProfiles.Name = "NoConsoleProfiles";
            this.NoConsoleProfiles.Size = new System.Drawing.Size(428, 184);
            this.NoConsoleProfiles.TabIndex = 16;
            this.NoConsoleProfiles.TabStop = false;
            this.NoConsoleProfiles.Visible = false;
            // 
            // ScrollBarConsoleProfiles
            // 
            this.ScrollBarConsoleProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarConsoleProfiles.Location = new System.Drawing.Point(615, 0);
            this.ScrollBarConsoleProfiles.Name = "ScrollBarConsoleProfiles";
            this.ScrollBarConsoleProfiles.Size = new System.Drawing.Size(17, 287);
            this.ScrollBarConsoleProfiles.TabIndex = 15;
            this.ScrollBarConsoleProfiles.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarConsoleProfiles_Scroll);
            // 
            // PanelConsoleProfiles
            // 
            this.PanelConsoleProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelConsoleProfiles.AutoScroll = true;
            this.PanelConsoleProfiles.Location = new System.Drawing.Point(0, 0);
            this.PanelConsoleProfiles.Name = "PanelConsoleProfiles";
            this.PanelConsoleProfiles.Size = new System.Drawing.Size(632, 287);
            this.PanelConsoleProfiles.TabIndex = 14;
            this.PanelConsoleProfiles.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PanelConsoleProfiles_Scroll);
            this.PanelConsoleProfiles.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PanelConsoleProfiles_ControlAddedOrRemoved);
            this.PanelConsoleProfiles.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PanelConsoleProfiles_ControlAddedOrRemoved);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonDeleteProfile);
            this.PanelButtons.Controls.Add(this.ButtonEditProfile);
            this.PanelButtons.Controls.Add(this.ButtonFindConsoles);
            this.PanelButtons.Controls.Add(this.ButtonAddNewProfile);
            this.PanelButtons.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.PanelButtons.Location = new System.Drawing.Point(12, 301);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(608, 26);
            this.PanelButtons.TabIndex = 13;
            // 
            // ButtonDeleteProfile
            // 
            this.ButtonDeleteProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeleteProfile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonDeleteProfile.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ButtonDeleteProfile.Appearance.Options.UseFont = true;
            this.ButtonDeleteProfile.Enabled = false;
            this.ButtonDeleteProfile.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonDeleteProfile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonDeleteProfile.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonDeleteProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonDeleteProfile.ImageOptions.SvgImage")));
            this.ButtonDeleteProfile.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonDeleteProfile.Location = new System.Drawing.Point(486, 0);
            this.ButtonDeleteProfile.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ButtonDeleteProfile.Name = "ButtonDeleteProfile";
            this.ButtonDeleteProfile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteProfile.Size = new System.Drawing.Size(122, 26);
            this.ButtonDeleteProfile.TabIndex = 2;
            this.ButtonDeleteProfile.Text = "Delete Console";
            // 
            // ButtonEditProfile
            // 
            this.ButtonEditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEditProfile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonEditProfile.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.ButtonEditProfile.Appearance.Options.UseFont = true;
            this.ButtonEditProfile.Enabled = false;
            this.ButtonEditProfile.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonEditProfile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonEditProfile.ImageOptions.ImageToTextIndent = 5;
            this.ButtonEditProfile.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonEditProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonEditProfile.ImageOptions.SvgImage")));
            this.ButtonEditProfile.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonEditProfile.Location = new System.Drawing.Point(370, 0);
            this.ButtonEditProfile.Name = "ButtonEditProfile";
            this.ButtonEditProfile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonEditProfile.Size = new System.Drawing.Size(110, 26);
            this.ButtonEditProfile.TabIndex = 1;
            this.ButtonEditProfile.Text = "Edit Console";
            // 
            // ButtonFindConsoles
            // 
            this.ButtonFindConsoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonFindConsoles.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.ButtonFindConsoles.Appearance.Options.UseFont = true;
            this.ButtonFindConsoles.Appearance.Options.UseTextOptions = true;
            this.ButtonFindConsoles.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ButtonFindConsoles.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ButtonFindConsoles.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonFindConsoles.AppearanceDisabled.Options.UseFont = true;
            this.ButtonFindConsoles.AppearanceDisabled.Options.UseTextOptions = true;
            this.ButtonFindConsoles.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ButtonFindConsoles.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ButtonFindConsoles.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonFindConsoles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonFindConsoles.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonFindConsoles.ImageOptions.SvgImage = global::ArisenStudio.Properties.Resources.icons8_advanced_search;
            this.ButtonFindConsoles.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonFindConsoles.Location = new System.Drawing.Point(250, 0);
            this.ButtonFindConsoles.Name = "ButtonFindConsoles";
            this.ButtonFindConsoles.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonFindConsoles.Size = new System.Drawing.Size(114, 26);
            this.ButtonFindConsoles.TabIndex = 13;
            this.ButtonFindConsoles.Text = "Find Consoles";
            // 
            // ButtonAddNewProfile
            // 
            this.ButtonAddNewProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddNewProfile.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonAddNewProfile.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
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
            this.ButtonAddNewProfile.Location = new System.Drawing.Point(110, 0);
            this.ButtonAddNewProfile.Name = "ButtonAddNewProfile";
            this.ButtonAddNewProfile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonAddNewProfile.Size = new System.Drawing.Size(134, 26);
            this.ButtonAddNewProfile.TabIndex = 12;
            this.ButtonAddNewProfile.Text = "Add New Console";
            this.ButtonAddNewProfile.Click += new System.EventHandler(this.ButtonAddNewProfile_Click);
            // 
            // WizardPageComplete
            // 
            this.WizardPageComplete.Controls.Add(this.Label);
            this.WizardPageComplete.Name = "WizardPageComplete";
            this.WizardPageComplete.Size = new System.Drawing.Size(632, 339);
            this.WizardPageComplete.Text = "You\'ve Finished Setup!";
            // 
            // Label
            // 
            this.Label.AllowHtmlString = true;
            this.Label.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Label.Appearance.Options.UseFont = true;
            this.Label.Appearance.Options.UseTextOptions = true;
            this.Label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Label.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.Label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.Label.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Label.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(632, 339);
            this.Label.TabIndex = 1174;
            this.Label.Text = resources.GetString("Label.Text");
            // 
            // SetupWizardDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 506);
            this.ControlBox = false;
            this.Controls.Add(this.WizardControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupWizardDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Wizard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupWizardDialog_FormClosing);
            this.Load += new System.EventHandler(this.SetupWizardDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WizardControlMain)).EndInit();
            this.WizardControlMain.ResumeLayout(false);
            this.WizardPageWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlChangeLog)).EndInit();
            this.TabControlChangeLog.ResumeLayout(false);
            this.TabPageChangeLog.ResumeLayout(false);
            this.PanelChangeLog.ResumeLayout(false);
            this.PanelChangeLog.PerformLayout();
            this.WizardPageConsoleProfiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.WizardPageComplete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl WizardControlMain;
        private DevExpress.XtraWizard.WelcomeWizardPage WizardPageWelcome;
        private DevExpress.XtraWizard.WizardPage WizardPageConsoleProfiles;
        private DevExpress.XtraWizard.CompletionWizardPage WizardPageComplete;
        private DevExpress.XtraEditors.SimpleButton ButtonAddNewProfile;
        private DevExpress.Utils.Layout.StackPanel PanelButtons;
        private DevExpress.XtraEditors.SimpleButton ButtonDeleteProfile;
        private DevExpress.XtraEditors.SimpleButton ButtonEditProfile;
        private Controls.NoProfilesItem NoConsoleProfiles;
        private DevExpress.XtraEditors.VScrollBar ScrollBarConsoleProfiles;
        private System.Windows.Forms.FlowLayoutPanel PanelConsoleProfiles;
        private DevExpress.XtraTab.XtraTabControl TabControlChangeLog;
        private DevExpress.XtraTab.XtraTabPage TabPageChangeLog;
        public System.Windows.Forms.FlowLayoutPanel PanelChangeLog;
        public DevExpress.XtraEditors.LabelControl LabelChangeLogVersion;
        public DevExpress.XtraEditors.LabelControl LabelChangeLog;
        public DevExpress.XtraEditors.LabelControl LabelAbout;
        public DevExpress.XtraEditors.LabelControl Label;
        private DevExpress.XtraEditors.SimpleButton ButtonFindConsoles;
    }
}