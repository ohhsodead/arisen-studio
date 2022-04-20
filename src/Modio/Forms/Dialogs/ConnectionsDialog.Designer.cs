using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VScrollBar = DevExpress.XtraEditors.VScrollBar;

namespace Modio.Forms.Dialogs
{
    partial class ConnectionsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionsDialog));
            this.ButtonEditProfile = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteProfile = new DevExpress.XtraEditors.SimpleButton();
            this.GroupConsoleProfiles = new DevExpress.XtraEditors.GroupControl();
            this.NoConsoleProfiles = new Modio.Controls.NoProfilesItem();
            this.ScrollBarConsoleProfiles = new DevExpress.XtraEditors.VScrollBar();
            this.PanelConsoleProfiles = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddNewProfile = new DevExpress.XtraEditors.SimpleButton();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.toolbarFormManager2 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GroupConsoleProfiles)).BeginInit();
            this.GroupConsoleProfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.SuspendLayout();
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
            this.ButtonEditProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonEditConsole.ImageOptions.SvgImage")));
            this.ButtonEditProfile.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonEditProfile.Location = new System.Drawing.Point(42, 0);
            this.ButtonEditProfile.Name = "ButtonEditProfile";
            this.ButtonEditProfile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonEditProfile.Size = new System.Drawing.Size(108, 26);
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
            this.ButtonDeleteProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonDeleteConsole.ImageOptions.SvgImage")));
            this.ButtonDeleteProfile.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonDeleteProfile.Location = new System.Drawing.Point(156, 0);
            this.ButtonDeleteProfile.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ButtonDeleteProfile.Name = "ButtonDeleteProfile";
            this.ButtonDeleteProfile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteProfile.Size = new System.Drawing.Size(120, 26);
            this.ButtonDeleteProfile.TabIndex = 2;
            this.ButtonDeleteProfile.Text = "Delete Console";
            this.ButtonDeleteProfile.Click += new System.EventHandler(this.ButtonDeleteConsole_Click);
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
            this.PanelConsoleProfiles.Location = new System.Drawing.Point(2, 23);
            this.PanelConsoleProfiles.Name = "PanelConsoleProfiles";
            this.PanelConsoleProfiles.Padding = new System.Windows.Forms.Padding(4);
            this.PanelConsoleProfiles.Size = new System.Drawing.Size(476, 343);
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
            this.ButtonAddNewProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonAddNewConsole.ImageOptions.SvgImage")));
            this.ButtonAddNewProfile.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonAddNewProfile.Location = new System.Drawing.Point(12, 386);
            this.ButtonAddNewProfile.Name = "ButtonAddNewProfile";
            this.ButtonAddNewProfile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonAddNewProfile.Size = new System.Drawing.Size(132, 26);
            this.ButtonAddNewProfile.TabIndex = 8;
            this.ButtonAddNewProfile.Text = "Add New Console";
            this.ButtonAddNewProfile.Click += new System.EventHandler(this.ButtonAddNewConsole_Click);
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            this.toolbarFormManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(504, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 424);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(504, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 424);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(504, 0);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 424);
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.PanelButtons);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(504, 424);
            this.fluentDesignFormContainer1.TabIndex = 14;
            // 
            // toolbarFormManager2
            // 
            this.toolbarFormManager2.DockControls.Add(this.barDockControl1);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl2);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl3);
            this.toolbarFormManager2.DockControls.Add(this.barDockControl4);
            this.toolbarFormManager2.Form = this;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.toolbarFormManager2;
            this.barDockControl1.Size = new System.Drawing.Size(504, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 424);
            this.barDockControl2.Manager = this.toolbarFormManager2;
            this.barDockControl2.Size = new System.Drawing.Size(504, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.toolbarFormManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 424);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(504, 0);
            this.barDockControl4.Manager = this.toolbarFormManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 424);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonDeleteProfile);
            this.PanelButtons.Controls.Add(this.ButtonEditProfile);
            this.PanelButtons.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.RightToLeft;
            this.PanelButtons.Location = new System.Drawing.Point(216, 386);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(276, 26);
            this.PanelButtons.TabIndex = 0;
            // 
            // ConnectionsDialog
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(504, 424);
            this.Controls.Add(this.ButtonAddNewProfile);
            this.Controls.Add(this.GroupConsoleProfiles);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ConnectionsDialog.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionsDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connections";
            this.Load += new System.EventHandler(this.ConnectionsDialog_Load);
            this.SizeChanged += new System.EventHandler(this.ConnectionDialog_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GroupConsoleProfiles)).EndInit();
            this.GroupConsoleProfiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SimpleButton ButtonEditProfile;
        private SimpleButton ButtonDeleteProfile;
        private GroupControl GroupConsoleProfiles;
        private VScrollBar ScrollBarConsoleProfiles;
        private FlowLayoutPanel PanelConsoleProfiles;
        private SimpleButton ButtonAddNewProfile;
        private Controls.NoProfilesItem NoConsoleProfiles;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.Utils.Layout.StackPanel PanelButtons;
    }
}