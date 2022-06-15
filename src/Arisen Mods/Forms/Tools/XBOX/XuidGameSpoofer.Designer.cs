
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenMods.Forms.Tools.XBOX
{
    partial class XuidGameSpoofer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XuidGameSpoofer));
            this.MenuStatus = new DevExpress.XtraBars.Bar();
            this.ButtonGetXuid = new DevExpress.XtraEditors.SimpleButton();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonSetXuid = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxGamertag = new DevExpress.XtraEditors.TextEdit();
            this.LabelGamertag = new DevExpress.XtraEditors.LabelControl();
            this.LabelXuid = new DevExpress.XtraEditors.LabelControl();
            this.TextBoxXuid = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGamertag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxXuid.Properties)).BeginInit();
            this.SuspendLayout();
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
            // ButtonGetXuid
            // 
            this.ButtonGetXuid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonGetXuid.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonGetXuid.Appearance.Options.UseFont = true;
            this.ButtonGetXuid.AutoSize = true;
            this.ButtonGetXuid.Enabled = false;
            this.ButtonGetXuid.Location = new System.Drawing.Point(0, 0);
            this.ButtonGetXuid.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonGetXuid.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonGetXuid.Name = "ButtonGetXuid";
            this.ButtonGetXuid.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonGetXuid.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonGetXuid.Size = new System.Drawing.Size(78, 24);
            this.ButtonGetXuid.TabIndex = 16;
            this.ButtonGetXuid.Text = "Get XUID";
            this.ButtonGetXuid.Click += new System.EventHandler(this.ButtonGetXuid_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelButtons.Controls.Add(this.ButtonGetXuid);
            this.PanelButtons.Controls.Add(this.ButtonSetXuid);
            this.PanelButtons.Location = new System.Drawing.Point(12, 101);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(336, 24);
            this.PanelButtons.TabIndex = 1185;
            // 
            // ButtonSetXuid
            // 
            this.ButtonSetXuid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSetXuid.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSetXuid.Appearance.Options.UseFont = true;
            this.ButtonSetXuid.AutoSize = true;
            this.ButtonSetXuid.Enabled = false;
            this.ButtonSetXuid.Location = new System.Drawing.Point(84, 0);
            this.ButtonSetXuid.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonSetXuid.Name = "ButtonSetXuid";
            this.ButtonSetXuid.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonSetXuid.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSetXuid.Size = new System.Drawing.Size(76, 24);
            this.ButtonSetXuid.TabIndex = 17;
            this.ButtonSetXuid.Text = "Set XUID";
            this.ButtonSetXuid.Click += new System.EventHandler(this.ButtonSetXuid_Click);
            // 
            // TextBoxGamertag
            // 
            this.TextBoxGamertag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGamertag.Location = new System.Drawing.Point(78, 13);
            this.TextBoxGamertag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxGamertag.Name = "TextBoxGamertag";
            this.TextBoxGamertag.Properties.AllowFocused = false;
            this.TextBoxGamertag.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextBoxGamertag.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxGamertag.Properties.Appearance.Options.UseFont = true;
            this.TextBoxGamertag.Properties.MaxLength = 15;
            this.TextBoxGamertag.Properties.NullValuePrompt = "None";
            this.TextBoxGamertag.Size = new System.Drawing.Size(270, 22);
            this.TextBoxGamertag.TabIndex = 1186;
            // 
            // LabelGamertag
            // 
            this.LabelGamertag.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelGamertag.Appearance.Options.UseFont = true;
            this.LabelGamertag.Location = new System.Drawing.Point(12, 16);
            this.LabelGamertag.Name = "LabelGamertag";
            this.LabelGamertag.Size = new System.Drawing.Size(55, 15);
            this.LabelGamertag.TabIndex = 1187;
            this.LabelGamertag.Text = "Gamertag:";
            // 
            // LabelXuid
            // 
            this.LabelXuid.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelXuid.Appearance.Options.UseFont = true;
            this.LabelXuid.Location = new System.Drawing.Point(12, 46);
            this.LabelXuid.Name = "LabelXuid";
            this.LabelXuid.Size = new System.Drawing.Size(29, 15);
            this.LabelXuid.TabIndex = 1189;
            this.LabelXuid.Text = "XUID:";
            // 
            // TextBoxXuid
            // 
            this.TextBoxXuid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxXuid.Location = new System.Drawing.Point(78, 43);
            this.TextBoxXuid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxXuid.Name = "TextBoxXuid";
            this.TextBoxXuid.Properties.AllowFocused = false;
            this.TextBoxXuid.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.TextBoxXuid.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxXuid.Properties.Appearance.Options.UseFont = true;
            this.TextBoxXuid.Properties.NullValuePrompt = "None";
            this.TextBoxXuid.Size = new System.Drawing.Size(270, 22);
            this.TextBoxXuid.TabIndex = 1188;
            // 
            // XuidGameSpoofer
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 137);
            this.Controls.Add(this.LabelXuid);
            this.Controls.Add(this.TextBoxXuid);
            this.Controls.Add(this.LabelGamertag);
            this.Controls.Add(this.TextBoxGamertag);
            this.Controls.Add(this.PanelButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("XuidGameSpoofer.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenMods.Properties.Resources.arisenmods;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XuidGameSpoofer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XUID Spoofer";
            this.Load += new System.EventHandler(this.XuidGameSpoofer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxGamertag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxXuid.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Bar MenuStatus;
        private SimpleButton ButtonGetXuid;
        private DevExpress.Utils.Layout.StackPanel PanelButtons;
        private SimpleButton ButtonSetXuid;
        private TextEdit TextBoxGamertag;
        private LabelControl LabelGamertag;
        private LabelControl LabelXuid;
        private TextEdit TextBoxXuid;
    }
}