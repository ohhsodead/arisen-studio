using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Dialogs
{
    partial class PackagesFaqDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackagesFaqDialog));
            this.GroupActivateDemo = new DevExpress.XtraEditors.GroupControl();
            this.LabelActivateDemo = new DevExpress.XtraEditors.LabelControl();
            this.ButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.GroupActivateRAP = new DevExpress.XtraEditors.GroupControl();
            this.LabelActivateRAP = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GroupActivateDemo)).BeginInit();
            this.GroupActivateDemo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupActivateRAP)).BeginInit();
            this.GroupActivateRAP.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupActivateDemo
            // 
            this.GroupActivateDemo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupActivateDemo.Controls.Add(this.LabelActivateDemo);
            this.GroupActivateDemo.Location = new System.Drawing.Point(14, 14);
            this.GroupActivateDemo.Margin = new System.Windows.Forms.Padding(5);
            this.GroupActivateDemo.Name = "GroupActivateDemo";
            this.GroupActivateDemo.Padding = new System.Windows.Forms.Padding(3);
            this.GroupActivateDemo.Size = new System.Drawing.Size(629, 104);
            this.GroupActivateDemo.TabIndex = 2;
            this.GroupActivateDemo.Text = "How do I activate a C00/Demo that has a free license?";
            // 
            // LabelActivateDemo
            // 
            this.LabelActivateDemo.AllowHtmlString = true;
            this.LabelActivateDemo.Appearance.Options.UseTextOptions = true;
            this.LabelActivateDemo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelActivateDemo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelActivateDemo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelActivateDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelActivateDemo.Location = new System.Drawing.Point(5, 25);
            this.LabelActivateDemo.Name = "LabelActivateDemo";
            this.LabelActivateDemo.Padding = new System.Windows.Forms.Padding(3);
            this.LabelActivateDemo.Size = new System.Drawing.Size(619, 74);
            this.LabelActivateDemo.TabIndex = 19;
            this.LabelActivateDemo.Text = resources.GetString("LabelActivateDemo.Text");
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonClose.Location = new System.Drawing.Point(292, 359);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonClose.Size = new System.Drawing.Size(74, 24);
            this.ButtonClose.TabIndex = 15;
            this.ButtonClose.Text = "OK";
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // GroupActivateRAP
            // 
            this.GroupActivateRAP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupActivateRAP.Controls.Add(this.LabelActivateRAP);
            this.GroupActivateRAP.Location = new System.Drawing.Point(14, 128);
            this.GroupActivateRAP.Margin = new System.Windows.Forms.Padding(5);
            this.GroupActivateRAP.Name = "GroupActivateRAP";
            this.GroupActivateRAP.Padding = new System.Windows.Forms.Padding(3);
            this.GroupActivateRAP.Size = new System.Drawing.Size(629, 209);
            this.GroupActivateRAP.TabIndex = 20;
            this.GroupActivateRAP.Text = "How do I activate a PSN package with a RAP file?";
            // 
            // LabelActivateRAP
            // 
            this.LabelActivateRAP.AllowHtmlString = true;
            this.LabelActivateRAP.Appearance.Options.UseTextOptions = true;
            this.LabelActivateRAP.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelActivateRAP.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelActivateRAP.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelActivateRAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelActivateRAP.Location = new System.Drawing.Point(5, 25);
            this.LabelActivateRAP.Name = "LabelActivateRAP";
            this.LabelActivateRAP.Padding = new System.Windows.Forms.Padding(3);
            this.LabelActivateRAP.Size = new System.Drawing.Size(619, 179);
            this.LabelActivateRAP.TabIndex = 19;
            this.LabelActivateRAP.Text = resources.GetString("LabelActivateRAP.Text");
            // 
            // PackagesFaqDialog
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(659, 395);
            this.Controls.Add(this.GroupActivateRAP);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.GroupActivateDemo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("PackagesFaqDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PackagesFaqDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Packages - FAQ";
            this.Load += new System.EventHandler(this.PackagesFaqDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupActivateDemo)).EndInit();
            this.GroupActivateDemo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupActivateRAP)).EndInit();
            this.GroupActivateRAP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupControl GroupActivateDemo;
        private SimpleButton ButtonClose;
        private LabelControl LabelActivateDemo;
        private GroupControl GroupActivateRAP;
        private LabelControl LabelActivateRAP;
    }
}