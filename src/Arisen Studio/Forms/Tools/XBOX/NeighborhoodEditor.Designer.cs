
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace ArisenStudio.Forms.Tools.XBOX
{
    partial class NeighborhoodEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeighborhoodEditor));
            this.TextBoxXboxName = new DevExpress.XtraEditors.ButtonEdit();
            this.LabelHeaderIconColor = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxXboxIcon = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelHeaderName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxXboxName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxXboxIcon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxXboxName
            // 
            this.TextBoxXboxName.Location = new System.Drawing.Point(12, 33);
            this.TextBoxXboxName.Name = "TextBoxXboxName";
            this.TextBoxXboxName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxXboxName.Properties.Appearance.Options.UseFont = true;
            this.TextBoxXboxName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.TextBoxXboxName.Size = new System.Drawing.Size(153, 24);
            this.TextBoxXboxName.TabIndex = 9;
            this.TextBoxXboxName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TextBoxXboxName_ButtonClick);
            // 
            // LabelHeaderIconColor
            // 
            this.LabelHeaderIconColor.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderIconColor.Appearance.Options.UseFont = true;
            this.LabelHeaderIconColor.Location = new System.Drawing.Point(171, 12);
            this.LabelHeaderIconColor.Name = "LabelHeaderIconColor";
            this.LabelHeaderIconColor.Size = new System.Drawing.Size(55, 15);
            this.LabelHeaderIconColor.TabIndex = 7;
            this.LabelHeaderIconColor.Text = "Icon Color";
            // 
            // ComboBoxXboxIcon
            // 
            this.ComboBoxXboxIcon.Location = new System.Drawing.Point(171, 33);
            this.ComboBoxXboxIcon.Name = "ComboBoxXboxIcon";
            this.ComboBoxXboxIcon.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ComboBoxXboxIcon.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxXboxIcon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxXboxIcon.Properties.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "BlueGray",
            "White"});
            this.ComboBoxXboxIcon.Size = new System.Drawing.Size(107, 24);
            this.ComboBoxXboxIcon.TabIndex = 10;
            this.ComboBoxXboxIcon.SelectedIndexChanged += new System.EventHandler(this.ComboBoxXboxIcon_SelectedIndexChanged);
            // 
            // LabelHeaderName
            // 
            this.LabelHeaderName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LabelHeaderName.Appearance.Options.UseFont = true;
            this.LabelHeaderName.Location = new System.Drawing.Point(12, 12);
            this.LabelHeaderName.Name = "LabelHeaderName";
            this.LabelHeaderName.Size = new System.Drawing.Size(78, 15);
            this.LabelHeaderName.TabIndex = 5;
            this.LabelHeaderName.Text = "Console Name";
            // 
            // NeighborhoodEditor
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 69);
            this.Controls.Add(this.TextBoxXboxName);
            this.Controls.Add(this.LabelHeaderIconColor);
            this.Controls.Add(this.LabelHeaderName);
            this.Controls.Add(this.ComboBoxXboxIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ConsoleInfo.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenStudio.Properties.Resources.arisenstudio;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NeighborhoodEditor";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neighborhood Editor";
            this.Load += new System.EventHandler(this.ConsoleInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxXboxName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxXboxIcon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LabelControl LabelHeaderName;
        private LabelControl LabelHeaderIconColor;
        private ComboBoxEdit ComboBoxXboxIcon;
        private ButtonEdit TextBoxXboxName;
    }
}