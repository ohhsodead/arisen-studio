
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheatEngine));
            this.GridControlModifyValues = new DevExpress.XtraGrid.GridControl();
            this.GridViewModifyValues = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridControlScannedAddresses = new DevExpress.XtraGrid.GridControl();
            this.GridViewScannedAddresses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.BarMenu = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.MainMenu = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.Quit = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.CheatEngineSettings = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageListBoxControl1 = new DevExpress.XtraEditors.ImageListBoxControl();
            this.imageListBoxControl2 = new DevExpress.XtraEditors.ImageListBoxControl();
            this.imageListBoxControl3 = new DevExpress.XtraEditors.ImageListBoxControl();
            this.imageListBoxControl4 = new DevExpress.XtraEditors.ImageListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlModifyValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModifyValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlScannedAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewScannedAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl4)).BeginInit();
            this.SuspendLayout();
            // 
            // GridControlModifyValues
            // 
            this.GridControlModifyValues.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridControlModifyValues.Location = new System.Drawing.Point(0, 501);
            this.GridControlModifyValues.MainView = this.GridViewModifyValues;
            this.GridControlModifyValues.Name = "GridControlModifyValues";
            this.GridControlModifyValues.Size = new System.Drawing.Size(579, 157);
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
            this.progressBarControl1.Location = new System.Drawing.Point(260, 39);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(321, 18);
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
            this.MainMenu});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.CheatEngineSettings,
            this.Quit,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MainMenu = this.MainMenu;
            this.barManager1.MaxItemId = 12;
            // 
            // MainMenu
            // 
            this.MainMenu.BarName = "Main menu";
            this.MainMenu.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.MainMenu.DockCol = 0;
            this.MainMenu.DockRow = 0;
            this.MainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4)});
            this.MainMenu.OptionsBar.DrawBorder = false;
            this.MainMenu.OptionsBar.DrawDragBorder = false;
            this.MainMenu.OptionsBar.MultiLine = true;
            this.MainMenu.OptionsBar.UseWholeRow = true;
            this.MainMenu.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "File";
            this.barSubItem1.Id = 2;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Quit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Load File";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Save FIle";
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // Quit
            // 
            this.Quit.Caption = "Quit";
            this.Quit.Id = 7;
            this.Quit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Quit.ImageOptions.Image")));
            this.Quit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Quit.ImageOptions.LargeImage")));
            this.Quit.ImageToTextAlignment = DevExpress.XtraBars.BarItemImageToTextAlignment.AfterText;
            this.Quit.Name = "Quit";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Edit";
            this.barSubItem2.Id = 3;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.CheatEngineSettings, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // CheatEngineSettings
            // 
            this.CheatEngineSettings.Caption = "Settings";
            this.CheatEngineSettings.Id = 6;
            this.CheatEngineSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CheatEngineSettings.ImageOptions.Image")));
            this.CheatEngineSettings.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("CheatEngineSettings.ImageOptions.LargeImage")));
            this.CheatEngineSettings.ImageToTextAlignment = DevExpress.XtraBars.BarItemImageToTextAlignment.AfterText;
            this.CheatEngineSettings.Name = "CheatEngineSettings";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Table";
            this.barSubItem3.Id = 4;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Make A Cheat Table";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Help";
            this.barSubItem4.Id = 5;
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(579, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 658);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(579, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 636);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(579, 22);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 636);
            // 
            // imageListBoxControl1
            // 
            this.imageListBoxControl1.Location = new System.Drawing.Point(12, 25);
            this.imageListBoxControl1.Name = "imageListBoxControl1";
            this.imageListBoxControl1.Size = new System.Drawing.Size(32, 32);
            this.imageListBoxControl1.TabIndex = 8;
            // 
            // imageListBoxControl2
            // 
            this.imageListBoxControl2.Location = new System.Drawing.Point(317, 76);
            this.imageListBoxControl2.Name = "imageListBoxControl2";
            this.imageListBoxControl2.Size = new System.Drawing.Size(42, 40);
            this.imageListBoxControl2.TabIndex = 9;
            // 
            // imageListBoxControl3
            // 
            this.imageListBoxControl3.Location = new System.Drawing.Point(413, 76);
            this.imageListBoxControl3.Name = "imageListBoxControl3";
            this.imageListBoxControl3.Size = new System.Drawing.Size(42, 40);
            this.imageListBoxControl3.TabIndex = 11;
            // 
            // imageListBoxControl4
            // 
            this.imageListBoxControl4.Location = new System.Drawing.Point(365, 76);
            this.imageListBoxControl4.Name = "imageListBoxControl4";
            this.imageListBoxControl4.Size = new System.Drawing.Size(42, 40);
            this.imageListBoxControl4.TabIndex = 10;
            // 
            // CheatEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 658);
            this.Controls.Add(this.imageListBoxControl3);
            this.Controls.Add(this.imageListBoxControl4);
            this.Controls.Add(this.imageListBoxControl2);
            this.Controls.Add(this.imageListBoxControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl4)).EndInit();
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
        private DevExpress.XtraBars.Bar MainMenu;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem Quit;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem CheatEngineSettings;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.ImageListBoxControl imageListBoxControl3;
        private DevExpress.XtraEditors.ImageListBoxControl imageListBoxControl4;
        private DevExpress.XtraEditors.ImageListBoxControl imageListBoxControl2;
        private DevExpress.XtraEditors.ImageListBoxControl imageListBoxControl1;
    }
}