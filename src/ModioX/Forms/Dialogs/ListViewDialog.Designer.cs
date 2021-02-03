using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Dialogs
{
    partial class ListViewDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewDialog));
            this.ListBoxItems = new DevExpress.XtraEditors.ListBoxControl();
            this.GroupListItems = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupListItems)).BeginInit();
            this.GroupListItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxItems
            // 
            this.ListBoxItems.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ListBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxItems.Location = new System.Drawing.Point(2, 23);
            this.ListBoxItems.Name = "ListBoxItems";
            this.ListBoxItems.ShowFocusRect = false;
            this.ListBoxItems.Size = new System.Drawing.Size(219, 181);
            this.ListBoxItems.TabIndex = 2;
            this.ListBoxItems.SelectedIndexChanged += new System.EventHandler(this.ListBoxItems_SelectedIndexChanged);
            // 
            // GroupListItems
            // 
            this.GroupListItems.Controls.Add(this.ListBoxItems);
            this.GroupListItems.Location = new System.Drawing.Point(12, 12);
            this.GroupListItems.Name = "GroupListItems";
            this.GroupListItems.Size = new System.Drawing.Size(223, 206);
            this.GroupListItems.TabIndex = 3;
            this.GroupListItems.Text = "Choose Item...";
            // 
            // ListViewDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 230);
            this.Controls.Add(this.GroupListItems);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ListViewDialog.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListViewDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListViewDialog";
            this.Load += new System.EventHandler(this.ListViewDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupListItems)).EndInit();
            this.GroupListItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBoxControl ListBoxItems;
        private GroupControl GroupListItems;
    }
}