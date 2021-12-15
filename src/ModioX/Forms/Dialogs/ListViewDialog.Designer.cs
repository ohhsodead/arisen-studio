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
            this.GroupListItems = new DevExpress.XtraEditors.GroupControl();
            this.GridControlListItems = new DevExpress.XtraGrid.GridControl();
            this.GridViewListItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GroupListItems)).BeginInit();
            this.GroupListItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListItems)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupListItems
            // 
            this.GroupListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupListItems.AppearanceCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.GroupListItems.AppearanceCaption.Options.UseForeColor = true;
            this.GroupListItems.Controls.Add(this.GridControlListItems);
            this.GroupListItems.Location = new System.Drawing.Point(12, 12);
            this.GroupListItems.Name = "GroupListItems";
            this.GroupListItems.Size = new System.Drawing.Size(174, 214);
            this.GroupListItems.TabIndex = 3;
            this.GroupListItems.Text = "Choose Item...";
            // 
            // GridControlListItems
            // 
            this.GridControlListItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlListItems.Location = new System.Drawing.Point(2, 23);
            this.GridControlListItems.MainView = this.GridViewListItems;
            this.GridControlListItems.Margin = new System.Windows.Forms.Padding(0);
            this.GridControlListItems.Name = "GridControlListItems";
            this.GridControlListItems.Size = new System.Drawing.Size(170, 189);
            this.GridControlListItems.TabIndex = 1;
            this.GridControlListItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewListItems});
            // 
            // GridViewListItems
            // 
            this.GridViewListItems.ActiveFilterEnabled = false;
            this.GridViewListItems.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewListItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewListItems.GridControl = this.GridControlListItems;
            this.GridViewListItems.Name = "GridViewListItems";
            this.GridViewListItems.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewListItems.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewListItems.OptionsBehavior.Editable = false;
            this.GridViewListItems.OptionsBehavior.ReadOnly = true;
            this.GridViewListItems.OptionsCustomization.AllowFilter = false;
            this.GridViewListItems.OptionsFilter.AllowFilterEditor = false;
            this.GridViewListItems.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewListItems.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewListItems.OptionsView.ShowColumnHeaders = false;
            this.GridViewListItems.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.GridViewListItems.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.GridViewListItems.OptionsView.ShowGroupPanel = false;
            this.GridViewListItems.OptionsView.ShowIndicator = false;
            this.GridViewListItems.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            this.GridViewListItems.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewListItems_RowClick);
            // 
            // ListViewDialog
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 238);
            this.Controls.Add(this.GroupListItems);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ListViewDialog.IconOptions.Icon")));
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 268);
            this.Name = "ListViewDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListViewDialog";
            this.Load += new System.EventHandler(this.ListViewDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupListItems)).EndInit();
            this.GroupListItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupControl GroupListItems;
        private DevExpress.XtraGrid.GridControl GridControlListItems;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewListItems;
    }
}