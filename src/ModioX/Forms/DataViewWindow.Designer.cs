using DarkUI.Forms;

namespace ModioX.Forms
{
    partial class DataViewWindow : DarkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewWindow));
            this.panelItems = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitle = new DarkUI.Controls.DarkTitle();
            this.LabelData = new DarkUI.Controls.DarkLabel();
            this.panelItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItems
            // 
            this.panelItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelItems.AutoSize = true;
            this.panelItems.Controls.Add(this.LabelTitle);
            this.panelItems.Controls.Add(this.LabelData);
            this.panelItems.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.panelItems.Location = new System.Drawing.Point(12, 12);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(440, 74);
            this.panelItems.TabIndex = 1;
            // 
            // LabelTitle
            // 
            this.panelItems.SetFlowBreak(this.LabelTitle, true);
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.LabelTitle.Location = new System.Drawing.Point(3, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(434, 22);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Changelog";
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
            this.LabelData.Size = new System.Drawing.Size(66, 17);
            this.LabelData.TabIndex = 1;
            this.LabelData.Text = "LabelData";
            // 
            // DataViewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 12);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(460, 99);
            this.Controls.Add(this.panelItems);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 744);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 43);
            this.Name = "DataViewWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataViewWindow_Scroll);
            this.panelItems.ResumeLayout(false);
            this.panelItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panelItems;
        public DarkUI.Controls.DarkLabel LabelData;
        public DarkUI.Controls.DarkTitle LabelTitle;
    }
}