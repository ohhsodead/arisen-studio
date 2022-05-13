using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraWaitForm;

namespace Modio.Forms.Tools.PS3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRegions));
            this.ButtonSaveAll = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupSavedGameRegions = new DevExpress.XtraEditors.GroupControl();
            this.GridGameRegions = new DevExpress.XtraGrid.GridControl();
            this.GridViewGameRegions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelButtons = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.ComboBoxGameTitle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.GroupAddGameRegion = new DevExpress.XtraEditors.GroupControl();
            this.LabelGameRegion = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxGameRegion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelSearch = new DevExpress.XtraEditors.LabelControl();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.ButtonAddGameRegion = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDetectRegions = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GroupSavedGameRegions)).BeginInit();
            this.GroupSavedGameRegions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridGameRegions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameRegions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupAddGameRegion)).BeginInit();
            this.GroupAddGameRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSaveAll
            // 
            this.ButtonSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveAll.Location = new System.Drawing.Point(345, 388);
            this.ButtonSaveAll.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonSaveAll.Name = "ButtonSaveAll";
            this.ButtonSaveAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSaveAll.Size = new System.Drawing.Size(79, 24);
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
            // GroupSavedGameRegions
            // 
            this.GroupSavedGameRegions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupSavedGameRegions.Controls.Add(this.GridGameRegions);
            this.GroupSavedGameRegions.Controls.Add(this.PanelButtons);
            this.GroupSavedGameRegions.Location = new System.Drawing.Point(12, 12);
            this.GroupSavedGameRegions.Name = "GroupSavedGameRegions";
            this.GroupSavedGameRegions.Size = new System.Drawing.Size(414, 236);
            this.GroupSavedGameRegions.TabIndex = 0;
            this.GroupSavedGameRegions.Text = "SAVED GAME REGIONS";
            // 
            // GridGameRegions
            // 
            this.GridGameRegions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridGameRegions.Location = new System.Drawing.Point(0, 25);
            this.GridGameRegions.MainView = this.GridViewGameRegions;
            this.GridGameRegions.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.GridGameRegions.Name = "GridGameRegions";
            this.GridGameRegions.Size = new System.Drawing.Size(414, 172);
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
            // PanelButtons
            // 
            this.PanelButtons.Controls.Add(this.ButtonDelete);
            this.PanelButtons.Controls.Add(this.ButtonDeleteAll);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(0, 197);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(414, 39);
            this.PanelButtons.TabIndex = 1173;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(8, 8);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDelete.Size = new System.Drawing.Size(69, 23);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonDeleteAll
            // 
            this.ButtonDeleteAll.Enabled = false;
            this.ButtonDeleteAll.Location = new System.Drawing.Point(83, 8);
            this.ButtonDeleteAll.Name = "ButtonDeleteAll";
            this.ButtonDeleteAll.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDeleteAll.Size = new System.Drawing.Size(84, 23);
            this.ButtonDeleteAll.TabIndex = 2;
            this.ButtonDeleteAll.Text = "Delete All";
            this.ButtonDeleteAll.Click += new System.EventHandler(this.ButtonDeleteAll_Click);
            // 
            // ComboBoxGameTitle
            // 
            this.ComboBoxGameTitle.Location = new System.Drawing.Point(10, 50);
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
            // GroupAddGameRegion
            // 
            this.GroupAddGameRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupAddGameRegion.Controls.Add(this.LabelGameRegion);
            this.GroupAddGameRegion.Controls.Add(this.ComboBoxGameRegion);
            this.GroupAddGameRegion.Controls.Add(this.LabelSearch);
            this.GroupAddGameRegion.Controls.Add(this.stackPanel1);
            this.GroupAddGameRegion.Controls.Add(this.ComboBoxGameTitle);
            this.GroupAddGameRegion.Location = new System.Drawing.Point(12, 254);
            this.GroupAddGameRegion.Name = "GroupAddGameRegion";
            this.GroupAddGameRegion.Size = new System.Drawing.Size(414, 114);
            this.GroupAddGameRegion.TabIndex = 1181;
            this.GroupAddGameRegion.Text = "ADD GAME REGION";
            // 
            // LabelGameRegion
            // 
            this.LabelGameRegion.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelGameRegion.Appearance.Options.UseFont = true;
            this.LabelGameRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelGameRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelGameRegion.Location = new System.Drawing.Point(293, 30);
            this.LabelGameRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelGameRegion.Name = "LabelGameRegion";
            this.LabelGameRegion.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelGameRegion.Size = new System.Drawing.Size(80, 15);
            this.LabelGameRegion.TabIndex = 1176;
            this.LabelGameRegion.Text = "Game Region:";
            // 
            // ComboBoxGameRegion
            // 
            this.ComboBoxGameRegion.Location = new System.Drawing.Point(293, 50);
            this.ComboBoxGameRegion.Name = "ComboBoxGameRegion";
            this.ComboBoxGameRegion.Properties.AllowFocused = false;
            this.ComboBoxGameRegion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxGameRegion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxGameRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxGameRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxGameRegion.Size = new System.Drawing.Size(112, 22);
            this.ComboBoxGameRegion.TabIndex = 4;
            // 
            // LabelSearch
            // 
            this.LabelSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.Appearance.Options.UseFont = true;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSearch.Location = new System.Drawing.Point(8, 30);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.LabelSearch.Size = new System.Drawing.Size(65, 15);
            this.LabelSearch.TabIndex = 1174;
            this.LabelSearch.Text = "Game Title:";
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.ButtonAddGameRegion);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stackPanel1.Location = new System.Drawing.Point(0, 75);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(414, 39);
            this.stackPanel1.TabIndex = 1173;
            // 
            // ButtonAddGameRegion
            // 
            this.ButtonAddGameRegion.Location = new System.Drawing.Point(8, 8);
            this.ButtonAddGameRegion.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonAddGameRegion.Name = "ButtonAddGameRegion";
            this.ButtonAddGameRegion.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonAddGameRegion.Size = new System.Drawing.Size(130, 23);
            this.ButtonAddGameRegion.TabIndex = 5;
            this.ButtonAddGameRegion.Text = "Add Game Region";
            this.ButtonAddGameRegion.Click += new System.EventHandler(this.ButtonAddGameRegion_Click);
            // 
            // ButtonDetectRegions
            // 
            this.ButtonDetectRegions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDetectRegions.Enabled = false;
            this.ButtonDetectRegions.Location = new System.Drawing.Point(14, 388);
            this.ButtonDetectRegions.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonDetectRegions.Name = "ButtonDetectRegions";
            this.ButtonDetectRegions.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDetectRegions.Size = new System.Drawing.Size(119, 24);
            this.ButtonDetectRegions.TabIndex = 1182;
            this.ButtonDetectRegions.Text = "Detect Regions";
            this.ButtonDetectRegions.Click += new System.EventHandler(this.ButtonDetectRegions_Click);
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
            this.Controls.Add(this.ButtonDetectRegions);
            this.Controls.Add(this.GroupAddGameRegion);
            this.Controls.Add(this.GroupSavedGameRegions);
            this.Controls.Add(this.ButtonSaveAll);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("GameRegions.IconOptions.Icon")));
            this.IconOptions.Image = global::Modio.Properties.Resources.icon;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameRegions";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Regions";
            this.Load += new System.EventHandler(this.GameRegions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupSavedGameRegions)).EndInit();
            this.GroupSavedGameRegions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridGameRegions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameRegions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelButtons)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupAddGameRegion)).EndInit();
            this.GroupAddGameRegion.ResumeLayout(false);
            this.GroupAddGameRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxGameRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SimpleButton ButtonSaveAll;
        private DataGridViewTextBoxColumn ColumnGameRegion;
        private DataGridViewTextBoxColumn ColumnGameTitle;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ColumnRegion;
        private GroupControl GroupSavedGameRegions;
        private GridControl GridGameRegions;
        private GridView GridViewGameRegions;
        private StackPanel PanelButtons;
        private SimpleButton ButtonDelete;
        private SimpleButton ButtonDeleteAll;
        private ComboBoxEdit ComboBoxGameTitle;
        private GroupControl GroupAddGameRegion;
        private StackPanel stackPanel1;
        private SimpleButton ButtonAddGameRegion;
        private LabelControl LabelGameRegion;
        private ComboBoxEdit ComboBoxGameRegion;
        private LabelControl LabelSearch;
        private SimpleButton ButtonDetectRegions;
    }
}