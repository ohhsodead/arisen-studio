using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Controls
{
    partial class StatItem
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
            this.LabelTitle = new DevExpress.XtraEditors.LabelControl();
            this.LabelValue = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelTitle.Appearance.Options.UseBackColor = true;
            this.LabelTitle.Appearance.Options.UseFont = true;
            this.LabelTitle.Appearance.Options.UseForeColor = true;
            this.LabelTitle.Appearance.Options.UseTextOptions = true;
            this.LabelTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LabelTitle.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.LabelTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelTitle.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelTitle.AutoEllipsis = true;
            this.LabelTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 6);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(152, 16);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Title";
            // 
            // LabelValue
            // 
            this.LabelValue.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LabelValue.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelValue.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelValue.Appearance.Options.UseBackColor = true;
            this.LabelValue.Appearance.Options.UseFont = true;
            this.LabelValue.Appearance.Options.UseForeColor = true;
            this.LabelValue.Appearance.Options.UseTextOptions = true;
            this.LabelValue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LabelValue.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.LabelValue.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelValue.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelValue.AutoEllipsis = true;
            this.LabelValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelValue.Location = new System.Drawing.Point(0, 16);
            this.LabelValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LabelValue.Size = new System.Drawing.Size(152, 23);
            this.LabelValue.TabIndex = 2;
            this.LabelValue.Text = "Value";
            // 
            // StatItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelValue);
            this.Controls.Add(this.LabelTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 12);
            this.Name = "StatItem";
            this.Size = new System.Drawing.Size(152, 39);
            this.ResumeLayout(false);

        }

        #endregion
        public LabelControl LabelTitle;
        public LabelControl LabelValue;
    }
}
