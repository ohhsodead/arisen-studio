using System.ComponentModel;
using DevExpress.XtraEditors;

namespace NeoModsX.Forms.Dialogs
{
    partial class RequestModsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestModsDialog));
            this.WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.ToolbarControl = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.ToolbarManager = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ButtonRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ProgressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.WebView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolbarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolbarManager)).BeginInit();
            this.SuspendLayout();
            // 
            // WebView
            // 
            this.WebView.AllowExternalDrop = false;
            this.WebView.CreationProperties = null;
            this.WebView.DefaultBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.WebView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebView.Location = new System.Drawing.Point(0, 32);
            this.WebView.Name = "WebView";
            this.WebView.Size = new System.Drawing.Size(598, 764);
            this.WebView.Source = new System.Uri("https://docs.google.com/forms/d/e/1FAIpQLScbeLBheZWjAp03d281pQHL2RvU93SLx2UXQZddx" +
        "8i2nS2JmA/viewform?embedded=true", System.UriKind.Absolute);
            this.WebView.TabIndex = 0;
            this.WebView.ZoomFactor = 1D;
            this.WebView.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.WebView_NavigationStarting);
            this.WebView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.WebView_NavigationCompleted);
            // 
            // ToolbarControl
            // 
            this.ToolbarControl.Location = new System.Drawing.Point(0, 0);
            this.ToolbarControl.Manager = this.ToolbarManager;
            this.ToolbarControl.Name = "ToolbarControl";
            this.ToolbarControl.Size = new System.Drawing.Size(598, 32);
            this.ToolbarControl.TabIndex = 1;
            this.ToolbarControl.TabStop = false;
            this.ToolbarControl.TitleItemLinks.Add(this.ButtonRefresh);
            this.ToolbarControl.ToolbarForm = this;
            // 
            // ToolbarManager
            // 
            this.ToolbarManager.DockControls.Add(this.barDockControlTop);
            this.ToolbarManager.DockControls.Add(this.barDockControlBottom);
            this.ToolbarManager.DockControls.Add(this.barDockControlLeft);
            this.ToolbarManager.DockControls.Add(this.barDockControlRight);
            this.ToolbarManager.Form = this;
            this.ToolbarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ButtonRefresh});
            this.ToolbarManager.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 32);
            this.barDockControlTop.Manager = this.ToolbarManager;
            this.barDockControlTop.Size = new System.Drawing.Size(598, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 796);
            this.barDockControlBottom.Manager = this.ToolbarManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(598, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Manager = this.ToolbarManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 764);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(598, 32);
            this.barDockControlRight.Manager = this.ToolbarManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 764);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.ButtonRefresh.Id = 0;
            this.ButtonRefresh.ImageOptions.SvgImage = global::NeoModsX.Properties.Resources.actions_reload1;
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ButtonRefresh_ItemClick);
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ProgressPanel.Appearance.Options.UseBackColor = true;
            this.ProgressPanel.AutoHeight = true;
            this.ProgressPanel.AutoWidth = true;
            this.ProgressPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ProgressPanel.Location = new System.Drawing.Point(276, 390);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.ShowCaption = false;
            this.ProgressPanel.ShowDescription = false;
            this.ProgressPanel.Size = new System.Drawing.Size(46, 44);
            this.ProgressPanel.TabIndex = 8;
            this.ProgressPanel.TabStop = false;
            this.ProgressPanel.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            // 
            // RequestModsDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(598, 796);
            this.Controls.Add(this.ProgressPanel);
            this.Controls.Add(this.WebView);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.ToolbarControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("RequestModsDialog.IconOptions.Icon")));
            this.IconOptions.Image = global::NeoModsX.Properties.Resources.neomodsx;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequestModsDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Request Mods";
            this.ToolbarFormControl = this.ToolbarControl;
            this.Load += new System.EventHandler(this.RequestModsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WebView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolbarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolbarManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WebView;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl ToolbarControl;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager ToolbarManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem ButtonRefresh;
        private DevExpress.XtraWaitForm.ProgressPanel ProgressPanel;
    }
}