using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace ArisenMods.Forms.Tools.PS3
{
    partial class GameRegions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRegions));
            this.ButtonSaveAll = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridGameRegions = new DevExpress.XtraGrid.GridControl();
            this.GridViewGameRegions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBoxGameTitle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelGameRegion = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxGameRegion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelGameTitle = new DevExpress.XtraEditors.LabelControl();
            this.ButtonAddGameRegion = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDetectRegions = new DevExpress.XtraEditors.SimpleButton();
            this.PanelButtonsNewRegion = new DevExpress.Utils.Layout.StackPanel();
            this.PanelButtonsGameRegions = new DevExpress.Utils.Layout.StackPanel();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.BarStatus = new DevExpress.XtraBars.Bar();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridGameRegions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameRegions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsNewRegion)).BeginInit();
            this.PanelButtonsNewRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsGameRegions)).BeginInit();
            this.PanelButtonsGameRegions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSaveAll
            // 
            this.ButtonSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveAll.AutoSize = true;
            this.ButtonSaveAll.Location = new System.Drawing.Point(356, 390);
            this.ButtonSaveAll.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonSaveAll.Name = "ButtonSaveAll";
            this.ButtonSaveAll.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonSaveAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSaveAll.Size = new System.Drawing.Size(70, 24);
            this.ButtonSaveAll.TabIndex = 6;
            this.ButtonSaveAll.Text = "Save All";
            this.ButtonSaveAll.Click += new System.EventHandler(this.ButtonSaveAll_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Game Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnRegion
            // 
            this.ColumnRegion.HeaderText = "Region";
            this.ColumnRegion.Name = "ColumnRegion";
            this.ColumnRegion.ReadOnly = true;
            this.ColumnRegion.Width = 110;
            // 
            // ColumnGameRegion
            // 
            this.ColumnGameRegion.HeaderText = "Game Region";
            this.ColumnGameRegion.Name = "ColumnGameRegion";
            this.ColumnGameRegion.Width = 120;
            // 
            // ColumnGameTitle
            // 
            this.ColumnGameTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnGameTitle.HeaderText = "Game Title";
            this.ColumnGameTitle.Name = "ColumnGameTitle";
            this.ColumnGameTitle.ReadOnly = true;
            // 
            // GridGameRegions
            // 
            this.GridGameRegions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridGameRegions.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.GridGameRegions.Location = new System.Drawing.Point(12, 12);
            this.GridGameRegions.MainView = this.GridViewGameRegions;
            this.GridGameRegions.Name = "GridGameRegions";
            this.GridGameRegions.Size = new System.Drawing.Size(414, 224);
            this.GridGameRegions.TabIndex = 0;
            this.GridGameRegions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewGameRegions});
            // 
            // GridViewGameRegions
            // 
            this.GridViewGameRegions.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewGameRegions.GridControl = this.GridGameRegions;
            this.GridViewGameRegions.Name = "GridViewGameRegions";
            this.GridViewGameRegions.OptionsBehavior.Editable = false;
            this.GridViewGameRegions.OptionsBehavior.ReadOnly = true;
            this.GridViewGameRegions.OptionsCustomization.AllowFilter = false;
            this.GridViewGameRegions.OptionsFilter.AllowFilterEditor = false;
            this.GridViewGameRegions.OptionsMenu.EnableGroupPanelMenu = false;
            this.GridViewGameRegions.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewGameRegions.OptionsView.ShowGroupPanel = false;
            this.GridViewGameRegions.OptionsView.ShowIndicator = false;
            this.GridViewGameRegions.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GridViewGameRegions_RowClick);
            this.GridViewGameRegions.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GridViewGameRegions_FocusedRowChanged);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(0, 0);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonDelete.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDelete.Size = new System.Drawing.Size(64, 24);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonDeleteAll
            // 
            this.ButtonDeleteAll.AutoSize = true;
            this.ButtonDeleteAll.Enabled = false;
            this.ButtonDeleteAll.Location = new System.Drawing.Point(70, 0);
            this.ButtonDeleteAll.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDeleteAll.Name = "ButtonDeleteAll";
            this.ButtonDeleteAll.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonDeleteAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteAll.Size = new System.Drawing.Size(80, 24);
            this.ButtonDeleteAll.TabIndex = 2;
            this.ButtonDeleteAll.Text = "Delete All";
            this.ButtonDeleteAll.Click += new System.EventHandler(this.ButtonDeleteAll_Click);
            // 
            // ComboBoxGameTitle
            // 
            this.ComboBoxGameTitle.Location = new System.Drawing.Point(14, 308);
            this.ComboBoxGameTitle.Name = "ComboBoxGameTitle";
            this.ComboBoxGameTitle.Properties.AllowFocused = false;
            this.ComboBoxGameTitle.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameTitle.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameTitle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameTitle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameTitle.Size = new System.Drawing.Size(277, 22);
            this.ComboBoxGameTitle.TabIndex = 3;
            this.ComboBoxGameTitle.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGameTitle_SelectedIndexChanged);
            // 
            // LabelGameRegion
            // 
            this.LabelGameRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGameRegion.Appearance.Options.UseFont = true;
            this.LabelGameRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameRegion.Location = new System.Drawing.Point(297, 288);
            this.LabelGameRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelGameRegion.Name = "LabelGameRegion";
            this.LabelGameRegion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameRegion.Size = new System.Drawing.Size(80, 15);
            this.LabelGameRegion.TabIndex = 1176;
            this.LabelGameRegion.Text = "Game Region:";
            // 
            // ComboBoxGameRegion
            // 
            this.ComboBoxGameRegion.Location = new System.Drawing.Point(299, 308);
            this.ComboBoxGameRegion.Name = "ComboBoxGameRegion";
            this.ComboBoxGameRegion.Properties.AllowFocused = false;
            this.ComboBoxGameRegion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameRegion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameRegion.Size = new System.Drawing.Size(129, 22);
            this.ComboBoxGameRegion.TabIndex = 4;
            // 
            // LabelGameTitle
            // 
            this.LabelGameTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGameTitle.Appearance.Options.UseFont = true;
            this.LabelGameTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameTitle.Location = new System.Drawing.Point(12, 288);
            this.LabelGameTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelGameTitle.Name = "LabelGameTitle";
            this.LabelGameTitle.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameTitle.Size = new System.Drawing.Size(65, 15);
            this.LabelGameTitle.TabIndex = 1174;
            this.LabelGameTitle.Text = "Game Title:";
            // 
            // ButtonAddGameRegion
            // 
            this.ButtonAddGameRegion.AutoSize = true;
            this.ButtonAddGameRegion.Location = new System.Drawing.Point(0, 0);
            this.ButtonAddGameRegion.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ButtonAddGameRegion.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonAddGameRegion.Name = "ButtonAddGameRegion";
            this.ButtonAddGameRegion.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonAddGameRegion.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonAddGameRegion.Size = new System.Drawing.Size(124, 24);
            this.ButtonAddGameRegion.TabIndex = 5;
            this.ButtonAddGameRegion.Text = "Add Game Region";
            this.ButtonAddGameRegion.Click += new System.EventHandler(this.ButtonAddGameRegion_Click);
            // 
            // ButtonDetectRegions
            // 
            this.ButtonDetectRegions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDetectRegions.AutoSize = true;
            this.ButtonDetectRegions.Enabled = false;
            this.ButtonDetectRegions.Location = new System.Drawing.Point(12, 390);
            this.ButtonDetectRegions.MinimumSize = new System.Drawing.Size(0, 24);
            this.ButtonDetectRegions.Name = "ButtonDetectRegions";
            this.ButtonDetectRegions.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.ButtonDetectRegions.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDetectRegions.Size = new System.Drawing.Size(109, 24);
            this.ButtonDetectRegions.TabIndex = 1182;
            this.ButtonDetectRegions.Text = "Detect Regions";
            this.ButtonDetectRegions.Click += new System.EventHandler(this.ButtonDetectRegions_Click);
            // 
            // PanelButtonsNewRegion
            // 
            this.PanelButtonsNewRegion.Controls.Add(this.ButtonAddGameRegion);
            this.PanelButtonsNewRegion.Location = new System.Drawing.Point(14, 336);
            this.PanelButtonsNewRegion.Name = "PanelButtonsNewRegion";
            this.PanelButtonsNewRegion.Size = new System.Drawing.Size(414, 24);
            this.PanelButtonsNewRegion.TabIndex = 1183;
            // 
            // PanelButtonsGameRegions
            // 
            this.PanelButtonsGameRegions.Controls.Add(this.ButtonDelete);
            this.PanelButtonsGameRegions.Controls.Add(this.ButtonDeleteAll);
            this.PanelButtonsGameRegions.Location = new System.Drawing.Point(12, 242);
            this.PanelButtonsGameRegions.Name = "PanelButtonsGameRegions";
            this.PanelButtonsGameRegions.Size = new System.Drawing.Size(414, 24);
            this.PanelButtonsGameRegions.TabIndex = 1184;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem1.Caption = "Status:";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem1.LeftIndent = 4;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem3.Caption = "Idle";
            this.barStaticItem3.Id = 3;
            this.barStaticItem3.Name = "barStaticItem3";
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(0, 0);
            this.barDockControl5.Size = new System.Drawing.Size(0, 0);
            // 
            // BarStatus
            // 
            this.BarStatus.BarItemVertIndent = 5;
            this.BarStatus.BarName = "Status bar";
            this.BarStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.BarStatus.DockCol = 0;
            this.BarStatus.DockRow = 0;
            this.BarStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.BarStatus.OptionsBar.AllowQuickCustomization = false;
            this.BarStatus.OptionsBar.DrawDragBorder = false;
            this.BarStatus.OptionsBar.UseWholeRow = true;
            this.BarStatus.Text = "Status bar";
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem4.Name = "barStaticItem4";
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // GameRegions
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(438, 426);
            this.Controls.Add(this.PanelButtonsGameRegions);
            this.Controls.Add(this.GridGameRegions);
            this.Controls.Add(this.LabelGameRegion);
            this.Controls.Add(this.ComboBoxGameRegion);
            this.Controls.Add(this.ButtonDetectRegions);
            this.Controls.Add(this.LabelGameTitle);
            this.Controls.Add(this.ComboBoxGameTitle);
            this.Controls.Add(this.ButtonSaveAll);
            this.Controls.Add(this.PanelButtonsNewRegion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameRegions.IconOptions.Icon")));
            this.IconOptions.Image = global::ArisenMods.Properties.Resources.arisenmods;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameRegions";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Regions";
            this.Load += new System.EventHandler(this.GameRegions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridGameRegions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameRegions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsNewRegion)).EndInit();
            this.PanelButtonsNewRegion.ResumeLayout(false);
            this.PanelButtonsNewRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtonsGameRegions)).EndInit();
            this.PanelButtonsGameRegions.ResumeLayout(false);
            this.PanelButtonsGameRegions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SimpleButton ButtonSaveAll;
        private DataGridViewTextBoxColumn ColumnGameRegion;
        private DataGridViewTextBoxColumn ColumnGameTitle;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ColumnRegion;
        private GridControl GridGameRegions;
        private GridView GridViewGameRegions;
        private SimpleButton ButtonDelete;
        private SimpleButton ButtonDeleteAll;
        private ComboBoxEdit ComboBoxGameTitle;
        private SimpleButton ButtonAddGameRegion;
        private LabelControl LabelGameRegion;
        private ComboBoxEdit ComboBoxGameRegion;
        private LabelControl LabelGameTitle;
        private SimpleButton ButtonDetectRegions;
        private StackPanel PanelButtonsNewRegion;
        private StackPanel PanelButtonsGameRegions;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.Bar BarStatus;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
    }
}