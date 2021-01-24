
namespace ModioX.Forms.Tools.XBOX_Tools
{
    partial class CheatEngine
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
            this.components = new System.ComponentModel.Container();
            this.GridControlModifyValues = new DevExpress.XtraGrid.GridControl();
            this.GridViewModifyValues = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridControlScannedAddresses = new DevExpress.XtraGrid.GridControl();
            this.GridViewScannedAddresses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.BarMenu = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlModifyValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModifyValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlScannedAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewScannedAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridControlModifyValues
            // 
            this.GridControlModifyValues.Location = new System.Drawing.Point(12, 461);
            this.GridControlModifyValues.MainView = this.GridViewModifyValues;
            this.GridControlModifyValues.Name = "GridControlModifyValues";
            this.GridControlModifyValues.Size = new System.Drawing.Size(583, 217);
            this.GridControlModifyValues.TabIndex = 1;
            this.GridControlModifyValues.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewModifyValues});
            // 
            // GridViewModifyValues
            // 
            this.GridViewModifyValues.GridControl = this.GridControlModifyValues;
            this.GridViewModifyValues.Name = "GridViewModifyValues";
            this.GridViewModifyValues.OptionsView.ShowGroupPanel = false;
            this.GridViewModifyValues.OptionsView.ShowIndicator = false;
            // 
            // GridControlScannedAddresses
            // 
            this.GridControlScannedAddresses.Location = new System.Drawing.Point(12, 63);
            this.GridControlScannedAddresses.MainView = this.GridViewScannedAddresses;
            this.GridControlScannedAddresses.Name = "GridControlScannedAddresses";
            this.GridControlScannedAddresses.Size = new System.Drawing.Size(251, 392);
            this.GridControlScannedAddresses.TabIndex = 2;
            this.GridControlScannedAddresses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewScannedAddresses});
            // 
            // GridViewScannedAddresses
            // 
            this.GridViewScannedAddresses.GridControl = this.GridControlScannedAddresses;
            this.GridViewScannedAddresses.Name = "GridViewScannedAddresses";
            this.GridViewScannedAddresses.OptionsView.ShowGroupPanel = false;
            this.GridViewScannedAddresses.OptionsView.ShowIndicator = false;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(329, 118);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(100, 18);
            this.progressBarControl1.TabIndex = 3;
            // 
            // BarMenu
            // 
            this.BarMenu.AutoUpdateMergedBars = DevExpress.Utils.DefaultBoolean.True;
            this.BarMenu.BarItemVertIndent = 5;
            this.BarMenu.BarName = "Main menu";
            this.BarMenu.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.BarMenu.DockCol = 0;
            this.BarMenu.DockRow = 0;
            this.BarMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.BarMenu.OptionsBar.DrawBorder = false;
            this.BarMenu.OptionsBar.MultiLine = true;
            this.BarMenu.OptionsBar.UseWholeRow = true;
            this.BarMenu.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.AutoUpdateMergedBars = DevExpress.Utils.DefaultBoolean.True;
            this.bar1.BarItemVertIndent = 5;
            this.bar1.BarName = "Main menu";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(607, 46);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 690);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(607, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 46);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 644);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(607, 46);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 644);
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "File";
            this.barSubItem1.Id = 0;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // CheatEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 690);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.GridControlScannedAddresses);
            this.Controls.Add(this.GridControlModifyValues);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.Name = "CheatEngine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cheat Engine";
            this.Load += new System.EventHandler(this.CheatEngine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlModifyValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModifyValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlScannedAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewScannedAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridControlModifyValues;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewModifyValues;
        private DevExpress.XtraGrid.GridControl GridControlScannedAddresses;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewScannedAddresses;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraBars.Bar BarMenu;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
    }
}