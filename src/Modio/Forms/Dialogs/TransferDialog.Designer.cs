using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Modio.Forms.Dialogs
{
    partial class TransferDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferDialog));
            this.LabelModName = new DevExpress.XtraEditors.LabelControl();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.LabelStatus = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.ButtonOpenPath = new DevExpress.XtraEditors.SimpleButton();
            this.Label = new DevExpress.XtraEditors.LabelControl();
            this.ProgressBarStatus = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelModName
            // 
            this.LabelModName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelModName.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModName.Appearance.Options.UseFont = true;
            this.LabelModName.Appearance.Options.UseTextOptions = true;
            this.LabelModName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LabelModName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelModName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelModName.Location = new System.Drawing.Point(12, 20);
            this.LabelModName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelModName.Name = "LabelModName";
            this.LabelModName.Size = new System.Drawing.Size(530, 50);
            this.LabelModName.TabIndex = 14;
            this.LabelModName.Text = "Mod Name\r\nCategory";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCancel.Appearance.Options.UseFont = true;
            this.ButtonCancel.Location = new System.Drawing.Point(467, 162);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonCancel.Size = new System.Drawing.Size(75, 25);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LabelStatus.Appearance.Options.UseFont = true;
            this.LabelStatus.Appearance.Options.UseTextOptions = true;
            this.LabelStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LabelStatus.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.LabelStatus.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LabelStatus.AutoEllipsis = true;
            this.LabelStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelStatus.Location = new System.Drawing.Point(12, 99);
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(530, 58);
            this.LabelStatus.TabIndex = 16;
            this.LabelStatus.Text = "Installing...";
            // 
            // ButtonOpenPath
            // 
            this.ButtonOpenPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOpenPath.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonOpenPath.Appearance.Options.UseFont = true;
            this.ButtonOpenPath.Location = new System.Drawing.Point(364, 162);
            this.ButtonOpenPath.Name = "ButtonOpenPath";
            this.ButtonOpenPath.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonOpenPath.Size = new System.Drawing.Size(97, 25);
            this.ButtonOpenPath.TabIndex = 17;
            this.ButtonOpenPath.Text = "Open Path";
            this.ButtonOpenPath.Visible = false;
            this.ButtonOpenPath.Click += new System.EventHandler(this.ButtonOpenPath_Click);
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Label.Appearance.Options.UseFont = true;
            this.Label.Appearance.Options.UseTextOptions = true;
            this.Label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.Label.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Label.AutoEllipsis = true;
            this.Label.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Label.Location = new System.Drawing.Point(12, 165);
            this.Label.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(346, 22);
            this.Label.TabIndex = 18;
            this.Label.Text = "Installing...";
            this.Label.Visible = false;
            // 
            // ProgressBarStatus
            // 
            this.ProgressBarStatus.EditValue = 0;
            this.ProgressBarStatus.Location = new System.Drawing.Point(12, 75);
            this.ProgressBarStatus.Name = "ProgressBarStatus";
            this.ProgressBarStatus.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.Cycle;
            this.ProgressBarStatus.Size = new System.Drawing.Size(530, 18);
            this.ProgressBarStatus.TabIndex = 20;
            // 
            // TransferDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 199);
            this.ControlBox = false;
            this.Controls.Add(this.ProgressBarStatus);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.ButtonOpenPath);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.LabelModName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("TransferDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::Modio.Properties.Resources.icon;
            this.LookAndFeel.SkinName = "Office 2019 Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transfer Dialog";
            this.Load += new System.EventHandler(this.TransferDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarStatus.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SimpleButton ButtonCancel;
        public LabelControl LabelStatus;
        public LabelControl LabelModName;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private SimpleButton ButtonOpenPath;
        public LabelControl Label;
        private MarqueeProgressBarControl ProgressBarStatus;
    }
}