using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;

namespace ModioX.Forms.Settings
{
    public partial class ExternalApplications : XtraForm
    {
        public ExternalApplications()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the user's settings data.
        /// </summary>
        public static SettingsData Settings { get; } = MainWindow.Settings;

        private void EditExternalApplications_Load(object sender, EventArgs e)
        {
            LoadExternalApplications();
        }

        private void LoadExternalApplications()
        {
            GridApplications.DataSource = null;

            var applications = DataExtensions.CreateDataTable(new List<DataColumn> { new("Name"), new("File Location") });

            TextBoxFileName.ResetText();
            TextBoxFileLocation.ResetText();

            foreach (var application in Settings.ExternalApplications)
            {
                applications.Rows.Add(application.Name, application.FileLocation);
            }

            GridApplications.DataSource = applications;

            GridViewApplications.Columns[0].Width = 125;
            GridViewApplications.Columns[1].Width = 300;

            ProgressLoading.Visible = GridViewApplications.RowCount < 1;
            ButtonDeleteAll.Enabled = GridViewApplications.RowCount > 0;

            if (GridViewApplications.RowCount > 0)
            {
                GridViewApplications.SelectRow(0);
            }
        }

        private void GridViewApplications_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (GridViewApplications.SelectedRowsCount > 0)
            {
                var name = GridViewApplications.GetRowCellValue(e.FocusedRowHandle, "Name").ToString();
                var location = GridViewApplications.GetRowCellValue(e.FocusedRowHandle, "File Location").ToString();

                TextBoxFileName.Text = name;
                TextBoxFileLocation.Text = location;
            }

            ButtonDeleteApplication.Enabled = GridViewApplications.SelectedRowsCount > 0;
        }

        private void GridViewApplications_RowClick(object sender, RowClickEventArgs e)
        {
            if (GridViewApplications.SelectedRowsCount > 0)
            {
                var name = GridViewApplications.GetRowCellValue(e.RowHandle, "Name").ToString();
                var location = GridViewApplications.GetRowCellValue(e.RowHandle, "File Location").ToString();

                TextBoxFileName.Text = name;
                TextBoxFileLocation.Text = location;
            }

            ButtonDeleteApplication.Enabled = GridViewApplications.SelectedRowsCount > 0;
        }

        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete all of the items?", "Confirm Delete All", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Settings.ExternalApplications.Clear();
                LoadExternalApplications();
                XtraMessageBox.Show("All applications have now been removed from the list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonDeleteApplication_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want delete the selected item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Settings.ExternalApplications.RemoveAt(GridViewApplications.FocusedRowHandle);
                LoadExternalApplications();
                XtraMessageBox.Show("Application has now been removed from the list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonBrowseLocalFile_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Multiselect = false,
                Filter = @"Executable Files (*.exe)|*.exe|All files (*.*)|*."
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxFileLocation.Text = openFileDialog.FileName;
            }
        }

        private void ButtonNewApplication_Click(object sender, EventArgs e)
        {
            TextBoxFileName.Text = string.Empty;
            TextBoxFileLocation.Text = string.Empty;
            TextBoxFileName.Reset();
            TextBoxFileName.Focus();
        }

        private void ButtonAddApplication_Click(object sender, EventArgs e)
        {
            var appName = TextBoxFileName.Text;
            var fileLocation = TextBoxFileLocation.Text;

            if (string.IsNullOrWhiteSpace(appName))
            {
                XtraMessageBox.Show("You must enter a name for this application.", "Empty Name");
                return;
            }

            if (string.IsNullOrWhiteSpace(fileLocation))
            {
                XtraMessageBox.Show("You must enter the file path for this application.", "Empty File Location");
                return;
            }

            if (!File.Exists(fileLocation))
            {
                XtraMessageBox.Show("The file for this application doesn't exist on your computer. Please choose another file.", "File Doesn't Exist");
                return;
            }

            Settings.UpdateApplication(appName, fileLocation);
            LoadExternalApplications();
        }

        private void ButtonSaveAll_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < GridViewApplications.RowCount; i++)
            {
                var appName = GridViewApplications.GetRowCellValue(i, "Name").ToString();
                var fileLocation = GridViewApplications.GetRowCellValue(i, "File Location").ToString();

                Settings.UpdateApplication(appName, fileLocation);
            }

            XtraMessageBox.Show("All external applications have been saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}