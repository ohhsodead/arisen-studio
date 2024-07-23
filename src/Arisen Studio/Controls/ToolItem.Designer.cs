using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Controls
{
    partial class ToolItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelName = new DevExpress.XtraEditors.LabelControl();
            this.ButtonLaunch = new DevExpress.XtraEditors.SimpleButton();
            this.LabelDescription = new DevExpress.XtraEditors.LabelControl();
            this.PanelControls = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControls)).BeginInit();
            this.PanelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelName.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LabelName.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LabelName.Appearance.Options.UseBackColor = true;
            this.LabelName.Appearance.Options.UseFont = true;
            this.LabelName.Appearance.Options.UseTextOptions = true;
            this.LabelName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LabelName.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.LabelName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelName.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelName.AppearanceDisabled.Options.UseForeColor = true;
            this.LabelName.AutoEllipsis = true;
            this.LabelName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelName.Location = new System.Drawing.Point(8, 14);
            this.LabelName.Margin = new System.Windows.Forms.Padding(6, 12, 6, 3);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(153, 42);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Name";
            // 
            // ButtonLaunch
            // 
            this.ButtonLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLaunch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonLaunch.Appearance.Options.UseFont = true;
            this.ButtonLaunch.Location = new System.Drawing.Point(14, 161);
            this.ButtonLaunch.Name = "ButtonLaunch";
            this.ButtonLaunch.Size = new System.Drawing.Size(141, 26);
            this.ButtonLaunch.TabIndex = 0;
            this.ButtonLaunch.Text = "Launch Tool";
            this.ButtonLaunch.Click += new System.EventHandler(this.ButtonLaunch_Click);
            // 
            // LabelDescription
            // 
            this.LabelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDescription.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LabelDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelDescription.Appearance.Options.UseBackColor = true;
            this.LabelDescription.Appearance.Options.UseFont = true;
            this.LabelDescription.Appearance.Options.UseTextOptions = true;
            this.LabelDescription.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LabelDescription.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.LabelDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelDescription.AppearanceDisabled.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelDescription.AppearanceDisabled.Options.UseForeColor = true;
            this.LabelDescription.AutoEllipsis = true;
            this.LabelDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelDescription.Location = new System.Drawing.Point(8, 62);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(6, 3, 6, 8);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(153, 90);
            this.LabelDescription.TabIndex = 2;
            this.LabelDescription.Text = "Description";
            // 
            // PanelControls
            // 
            this.PanelControls.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PanelControls.Appearance.Options.UseBackColor = true;
            this.PanelControls.Controls.Add(this.ButtonLaunch);
            this.PanelControls.Controls.Add(this.LabelDescription);
            this.PanelControls.Controls.Add(this.LabelName);
            this.PanelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControls.Location = new System.Drawing.Point(0, 0);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.Size = new System.Drawing.Size(169, 201);
            this.PanelControls.TabIndex = 0;
            this.PanelControls.EnabledChanged += new System.EventHandler(this.PanelControls_EnabledChanged);
            // 
            // ToolItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelControls);
            this.Name = "ToolItem";
            this.Size = new System.Drawing.Size(169, 201);
            this.EnabledChanged += new System.EventHandler(this.ToolItem_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControls)).EndInit();
            this.PanelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public LabelControl LabelName;
        private SimpleButton ButtonLaunch;
        public LabelControl LabelDescription;
        private PanelControl PanelControls;
    }
}
