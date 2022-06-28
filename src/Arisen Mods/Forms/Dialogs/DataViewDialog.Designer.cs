using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ArisenMods.Forms.Dialogs
{
    partial class DataViewDialog : XtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewDialog));
            this.PanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitle = new DevExpress.XtraEditors.LabelControl();
            this.LabelBody = new DevExpress.XtraEditors.LabelControl();
            this.PanelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetails
            // 
            this.PanelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDetails.AutoSize = true;
            this.PanelDetails.BackColor = System.Drawing.Color.Transparent;
            this.PanelDetails.Controls.Add(this.LabelTitle);
            this.PanelDetails.Controls.Add(this.LabelBody);
            this.PanelDetails.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PanelDetails.Location = new System.Drawing.Point(12, 12);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(460, 57);
            this.PanelDetails.TabIndex = 1;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.Appearance.Options.UseFont = true;
            this.LabelTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelTitle.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.LabelTitle.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.LabelTitle.Location = new System.Drawing.Point(3, 0);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(452, 18);
            this.LabelTitle.TabIndex = 1168;
            this.LabelTitle.Text = "Title";
            // 
            // LabelBody
            // 
            this.LabelBody.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelBody.Appearance.Options.UseFont = true;
            this.LabelBody.Location = new System.Drawing.Point(3, 25);
            this.LabelBody.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LabelBody.Name = "LabelBody";
            this.LabelBody.Size = new System.Drawing.Size(27, 15);
            this.LabelBody.TabIndex = 1169;
            this.LabelBody.Text = "Body";
            // 
            // DataViewDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(0, 12);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 81);
            this.Controls.Add(this.PanelDetails);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DataViewDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenMods.Properties.Resources.arisenmods;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 744);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(486, 43);
            this.Name = "DataViewDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Title";
            this.Load += new System.EventHandler(this.DataViewDialog_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataViewDialog_Scroll);
            this.PanelDetails.ResumeLayout(false);
            this.PanelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public FlowLayoutPanel PanelDetails;
        public LabelControl LabelTitle;
        public LabelControl LabelBody;
    }
}