using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VScrollBar = DevExpress.XtraEditors.VScrollBar;

namespace ModioX.Forms.Dialogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionsDialog));
            this.ButtonEditConsole = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteConsole = new DevExpress.XtraEditors.SimpleButton();
            this.GroupConsoleProfiles = new DevExpress.XtraEditors.GroupControl();
            this.ScrollBarConsoleProfiles = new DevExpress.XtraEditors.VScrollBar();
            this.PanelConsoleProfiles = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddNewConsole = new DevExpress.XtraEditors.SimpleButton();
            this.NoConsolesItem = new ModioX.Controls.NoConsolesItem();
            ((System.ComponentModel.ISupportInitialize)(this.GroupConsoleProfiles)).BeginInit();
            this.GroupConsoleProfiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonEditConsole
            // 
            this.ButtonEditConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEditConsole.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonEditConsole.Appearance.Options.UseFont = true;
            this.ButtonEditConsole.Enabled = false;
            this.ButtonEditConsole.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonEditConsole.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonEditConsole.ImageOptions.ImageToTextIndent = 5;
            this.ButtonEditConsole.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonEditConsole.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonEdit.ImageOptions.SvgImage")));
            this.ButtonEditConsole.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonEditConsole.Location = new System.Drawing.Point(258, 386);
            this.ButtonEditConsole.Name = "ButtonEditConsole";
            this.ButtonEditConsole.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonEditConsole.Size = new System.Drawing.Size(108, 26);
            this.ButtonEditConsole.TabIndex = 1;
            this.ButtonEditConsole.Text = "Edit Console";
            this.ButtonEditConsole.Click += new System.EventHandler(this.ButtonEditConsole_Click);
            // 
            // ButtonDeleteConsole
            // 
            this.ButtonDeleteConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDeleteConsole.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonDeleteConsole.Appearance.Options.UseFont = true;
            this.ButtonDeleteConsole.Enabled = false;
            this.ButtonDeleteConsole.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonDeleteConsole.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonDeleteConsole.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonDeleteConsole.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonDelete.ImageOptions.SvgImage")));
            this.ButtonDeleteConsole.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.ButtonDeleteConsole.Location = new System.Drawing.Point(372, 386);
            this.ButtonDeleteConsole.Name = "ButtonDeleteConsole";
            this.ButtonDeleteConsole.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteConsole.Size = new System.Drawing.Size(120, 26);
            this.ButtonDeleteConsole.TabIndex = 2;
            this.ButtonDeleteConsole.Text = "Delete Console";
            this.ButtonDeleteConsole.Click += new System.EventHandler(this.ButtonDeleteConsole_Click);
            // 
            // GroupConsoleProfiles
            // 
            this.GroupConsoleProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupConsoleProfiles.Controls.Add(this.NoConsolesItem);
            this.GroupConsoleProfiles.Controls.Add(this.ScrollBarConsoleProfiles);
            this.GroupConsoleProfiles.Controls.Add(this.PanelConsoleProfiles);
            this.GroupConsoleProfiles.Location = new System.Drawing.Point(12, 12);
            this.GroupConsoleProfiles.Name = "GroupConsoleProfiles";
            this.GroupConsoleProfiles.Size = new System.Drawing.Size(480, 368);
            this.GroupConsoleProfiles.TabIndex = 7;
            this.GroupConsoleProfiles.Text = "Console Profiles";
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
            // ButtonAddNewConsole
            // 
            this.ButtonAddNewConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddNewConsole.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAddNewConsole.Appearance.Options.UseFont = true;
            this.ButtonAddNewConsole.Appearance.Options.UseTextOptions = true;
            this.ButtonAddNewConsole.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ButtonAddNewConsole.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ButtonAddNewConsole.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAddNewConsole.AppearanceDisabled.Options.UseFont = true;
            this.ButtonAddNewConsole.AppearanceDisabled.Options.UseTextOptions = true;
            this.ButtonAddNewConsole.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ButtonAddNewConsole.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ButtonAddNewConsole.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ButtonAddNewConsole.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ButtonAddNewConsole.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonAddNewConsole.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButtonAddNewConsole.ImageOptions.SvgImage")));
            this.ButtonAddNewConsole.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ButtonAddNewConsole.Location = new System.Drawing.Point(12, 386);
            this.ButtonAddNewConsole.Name = "ButtonAddNewConsole";
            this.ButtonAddNewConsole.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonAddNewConsole.Size = new System.Drawing.Size(132, 26);
            this.ButtonAddNewConsole.TabIndex = 8;
            this.ButtonAddNewConsole.Text = "Add New Console";
            this.ButtonAddNewConsole.Click += new System.EventHandler(this.ButtonAddNewConsole_Click);
            // 
            // NoConsolesItem
            // 
            this.NoConsolesItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoConsolesItem.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.NoConsolesItem.Appearance.Options.UseBackColor = true;
            this.NoConsolesItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NoConsolesItem.Location = new System.Drawing.Point(26, 44);
            this.NoConsolesItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.NoConsolesItem.Name = "NoConsolesItem";
            this.NoConsolesItem.Size = new System.Drawing.Size(428, 288);
            this.NoConsolesItem.TabIndex = 2;
            this.NoConsolesItem.TabStop = false;
            this.NoConsolesItem.Visible = false;
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
            this.Controls.Add(this.ButtonAddNewConsole);
            this.Controls.Add(this.GroupConsoleProfiles);
            this.Controls.Add(this.ButtonEditConsole);
            this.Controls.Add(this.ButtonDeleteConsole);
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
            this.ResumeLayout(false);

        }

        #endregion
        private SimpleButton ButtonEditConsole;
        private SimpleButton ButtonDeleteConsole;
        private GroupControl GroupConsoleProfiles;
        private VScrollBar ScrollBarConsoleProfiles;
        private FlowLayoutPanel PanelConsoleProfiles;
        private SimpleButton ButtonAddNewConsole;
        private Controls.NoConsolesItem NoConsolesItem;
    }
}