using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Humanizer;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ModioX.Forms.Dialogs.Importing
{
    public partial class ImportedModsDialog : XtraForm
    {
        public ImportedModsDialog()
        {
            InitializeComponent();
        }

        private SettingsData Settings { get; } = MainWindow.Settings;

        private void ImportedModsDialog_Load(object sender, EventArgs e)
        {

        }

        private void TimerWait_Tick(object sender, EventArgs e)
        {
            LoadMods();
            TimerWait.Enabled = false;
        }

        DataTable TableMods = DataExtensions.CreateDataTable(new List<DataColumn>
            {
                new("Platform", typeof(string)),
                new("Category", typeof(string)),
                new("Name", typeof(string)),
                new("Total Files", typeof(string))
            });

        private void LoadMods()
        {
            GridMods.DataSource = null;
            TableMods.Rows.Clear();

            foreach (ImportedMod importedMod in Settings.ImportedMods)
            {
                TableMods.Rows.Add(importedMod.Platform.Humanize(),
                                   importedMod.CategoryId,
                                   importedMod.Name,
                                   importedMod.Files);
            }

            GridMods.DataSource = TableMods;

            //GridViewPackageFiles.Columns[0].Width = 350;
            GridViewMods.Columns[0].MinWidth = 104;
            GridViewMods.Columns[0].MaxWidth = 104;

            GridViewMods.Columns[1].MinWidth = 226;
            GridViewMods.Columns[2].MaxWidth = 226;

            GridViewMods.Columns[4].MinWidth = 226;
            GridViewMods.Columns[4].MaxWidth = 226;

            GridViewMods.Columns[5].MinWidth = 76;
            GridViewMods.Columns[5].MaxWidth = 76;

            //GridViewMods.Columns[0].Width = 150;
            //GridViewMods.Columns[1].Width = 150;
            //GridViewMods.Columns[1].Width = 150;
            //GridViewMods.Columns[1].Width = 150;

            ButtonDeleteAll.Enabled = TableMods.Rows.Count > 0;
        }

        private void GridViewMods_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ButtonDelete.Enabled = GridViewMods.SelectedRowsCount > 0;
        }

        private void GridViewMods_RowClick(object sender, RowClickEventArgs e)
        {
            ButtonDelete.Enabled = GridViewMods.SelectedRowsCount > 0;
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            ImportedMod importedMod = DialogExtensions.ShowImportNewDialog(this);

            if (importedMod != null)
            {
                Settings.ImportedMods.Add(importedMod);
            }

            //switch (string.IsNullOrWhiteSpace(localFilePath))
            //{
            //    case false:
            //        {
            //            string fileName = Path.GetFileName(localFilePath);
            //            string installFilePath = PackageFilesPath + "/" + fileName;

            //            XtraMessageBox.Show("Package file with this name already exists on your console.", "Package File Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            return;

            //            //UpdateStatus("Installing package file: " + fileName);
            //            FtpExtensions.UploadFile(localFilePath, installFilePath);
            //            //UpdateStatus("Successfully installed package file.");
            //            LoadMods();
            //            break;
            //        }
            //}
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Settings.ImportedMods.RemoveAt(GridViewMods.GetSelectedRows()[0]);
                LoadMods();
            }
        }

        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            string platform = GridViewMods.GetFocusedRowCellDisplayText("Platform");
            string name = GridViewMods.GetFocusedRowCellDisplayText("Name");
            string category = GridViewMods.GetFocusedRowCellDisplayText("Category");

            if (XtraMessageBox.Show("Do you really want to delete all items?", "Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Settings.ImportedMods.Clear();
                LoadMods();
            }
        }
    }
}