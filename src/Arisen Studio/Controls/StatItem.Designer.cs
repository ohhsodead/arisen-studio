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
            this.LabelTitle.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.LabelTitle.Appearance.Options.UseBackColor = true;
            this.LabelTitle.Appearance.Options.UseFont = true;
            this.LabelTitle.Appearance.Options.UseForeColor = true;
            this.LabelTitle.Appearance.Options.UseTextOptions = true;
            this.LabelTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LabelTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelTitle.AutoEllipsis = true;
            this.LabelTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(25, 13);
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
            this.LabelValue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LabelValue.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelValue.AutoEllipsis = true;
            this.LabelValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.LabelValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelValue.Location = new System.Drawing.Point(0, 13);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.LabelValue.Size = new System.Drawing.Size(29, 19);
            this.LabelValue.TabIndex = 2;
            this.LabelValue.Text = "Value";
            // 
            // StatItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelValue);
            this.Controls.Add(this.LabelTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "StatItem";
            this.Size = new System.Drawing.Size(130, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public LabelControl LabelTitle;
        public LabelControl LabelValue;
    }
}
