namespace ModioX.Windows
{
    partial class RegionsWindow
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
            this.ListboxRegions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListboxRegions
            // 
            this.ListboxRegions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ListboxRegions.FormattingEnabled = true;
            this.ListboxRegions.ItemHeight = 17;
            this.ListboxRegions.Location = new System.Drawing.Point(12, 12);
            this.ListboxRegions.Name = "ListboxRegions";
            this.ListboxRegions.Size = new System.Drawing.Size(156, 191);
            this.ListboxRegions.TabIndex = 0;
            this.ListboxRegions.SelectedIndexChanged += new System.EventHandler(this.ListboxRegions_SelectedIndexChanged);
            // 
            // RegionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 214);
            this.Controls.Add(this.ListboxRegions);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegionsWindow";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Region...";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox ListboxRegions;
    }
}