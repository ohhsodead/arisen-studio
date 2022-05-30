using System.ComponentModel;
using DevExpress.XtraEditors;

namespace NeoModsX.Forms.Dialogs
{
    partial class SortOptionsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortOptionsDialog));
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.LabelSortBy = new DevExpress.XtraEditors.LabelControl();
            this.RadioGroupSortOptions = new DevExpress.XtraEditors.RadioGroup();
            this.RadioGroupSortOrder = new DevExpress.XtraEditors.RadioGroup();
            this.LabelSortOrder = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupSortOptions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupSortOrder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(190, 230);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "Cancel";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Location = new System.Drawing.Point(109, 230);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 5;
            this.ButtonOK.Text = "OK";
            // 
            // LabelSortBy
            // 
            this.LabelSortBy.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelSortBy.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelSortBy.Appearance.Options.UseFont = true;
            this.LabelSortBy.Appearance.Options.UseForeColor = true;
            this.LabelSortBy.Location = new System.Drawing.Point(12, 12);
            this.LabelSortBy.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSortBy.Name = "LabelSortBy";
            this.LabelSortBy.Size = new System.Drawing.Size(40, 15);
            this.LabelSortBy.TabIndex = 14;
            this.LabelSortBy.Text = "Sort By:";
            // 
            // RadioGroupSortOptions
            // 
            this.RadioGroupSortOptions.Location = new System.Drawing.Point(11, 32);
            this.RadioGroupSortOptions.Name = "RadioGroupSortOptions";
            this.RadioGroupSortOptions.Properties.AllowFocused = false;
            this.RadioGroupSortOptions.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioGroupSortOptions.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.RadioGroupSortOptions.Properties.Appearance.Options.UseBackColor = true;
            this.RadioGroupSortOptions.Properties.Appearance.Options.UseFont = true;
            this.RadioGroupSortOptions.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioGroupSortOptions.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Category"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Name"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Creator"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Version")});
            this.RadioGroupSortOptions.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.RadioGroupSortOptions.Size = new System.Drawing.Size(254, 96);
            this.RadioGroupSortOptions.TabIndex = 1174;
            this.RadioGroupSortOptions.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSortOptions_SelectedIndexChanged);
            // 
            // RadioGroupSortOrder
            // 
            this.RadioGroupSortOrder.Location = new System.Drawing.Point(11, 154);
            this.RadioGroupSortOrder.Name = "RadioGroupSortOrder";
            this.RadioGroupSortOrder.Properties.AllowFocused = false;
            this.RadioGroupSortOrder.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RadioGroupSortOrder.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.RadioGroupSortOrder.Properties.Appearance.Options.UseBackColor = true;
            this.RadioGroupSortOrder.Properties.Appearance.Options.UseFont = true;
            this.RadioGroupSortOrder.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RadioGroupSortOrder.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Ascending"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Descending")});
            this.RadioGroupSortOrder.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.RadioGroupSortOrder.Size = new System.Drawing.Size(254, 48);
            this.RadioGroupSortOrder.TabIndex = 1176;
            this.RadioGroupSortOrder.SelectedIndexChanged += new System.EventHandler(this.RadioGroupSortOrder_SelectedIndexChanged);
            // 
            // LabelSortOrder
            // 
            this.LabelSortOrder.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelSortOrder.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelSortOrder.Appearance.Options.UseFont = true;
            this.LabelSortOrder.Appearance.Options.UseForeColor = true;
            this.LabelSortOrder.Location = new System.Drawing.Point(12, 134);
            this.LabelSortOrder.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelSortOrder.Name = "LabelSortOrder";
            this.LabelSortOrder.Size = new System.Drawing.Size(57, 15);
            this.LabelSortOrder.TabIndex = 1175;
            this.LabelSortOrder.Text = "Sort Order:";
            // 
            // SortOptionsDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(277, 265);
            this.Controls.Add(this.RadioGroupSortOrder);
            this.Controls.Add(this.LabelSortOrder);
            this.Controls.Add(this.RadioGroupSortOptions);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.LabelSortBy);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("SortOptionsDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::NeoModsX.Properties.Resources.neomodsx;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortOptionsDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sort Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SortOptionsDialog_FormClosing);
            this.Load += new System.EventHandler(this.SortOptionsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupSortOptions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadioGroupSortOrder.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SimpleButton ButtonCancel;
        private SimpleButton ButtonOK;
        private LabelControl LabelSortBy;
        private RadioGroup RadioGroupSortOptions;
        private RadioGroup RadioGroupSortOrder;
        private LabelControl LabelSortOrder;
    }
}