using DarkUI.Forms;
using DevExpress.XtraEditors;

namespace ModioX.Forms
{
    partial class DataViewDialog : XtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewDialog));
            this.PanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitle = new DarkUI.Controls.DarkTitle();
            this.LabelData = new DarkUI.Controls.DarkLabel();
            this.PanelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetails
            // 
            this.PanelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDetails.AutoSize = true;
            this.PanelDetails.Controls.Add(this.LabelTitle);
            this.PanelDetails.Controls.Add(this.LabelData);
            this.PanelDetails.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PanelDetails.Location = new System.Drawing.Point(12, 11);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(460, 76);
            this.PanelDetails.TabIndex = 1;
            // 
            // LabelTitle
            // 
            this.PanelDetails.SetFlowBreak(this.LabelTitle, true);
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.LabelTitle.Location = new System.Drawing.Point(3, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(452, 22);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Title";
            // 
            // LabelData
            // 
            this.LabelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelData.AutoSize = true;
            this.LabelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelData.Location = new System.Drawing.Point(1, 22);
            this.LabelData.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(37, 17);
            this.LabelData.TabIndex = 1;
            this.LabelData.Text = "Body";
            // 
            // DataViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 12);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 99);
            this.Controls.Add(this.PanelDetails);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 744);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 43);
            this.Name = "DataViewDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.Load += new System.EventHandler(this.DataViewDialog_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataViewDialog_Scroll);
            this.PanelDetails.ResumeLayout(false);
            this.PanelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DarkUI.Controls.DarkLabel LabelData;
        public DarkUI.Controls.DarkTitle LabelTitle;
        public System.Windows.Forms.FlowLayoutPanel PanelDetails;
    }
}