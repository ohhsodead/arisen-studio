using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Forms.Settings
{
    public partial class ExternalApplicationsDialog : XtraForm
    {
        public ExternalApplicationsDialog()
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

            DataTable applications = DataExtensions.CreateDataTable(new List<DataColumn> { new DataColumn("Name", typeof(string)), new DataColumn("FileLocation", typeof(string)) });

            TextBoxFileName.ResetText();
            TextBoxFileLocation.ResetText();

            foreach (var application in Settings.ExternalApplications)
            {
                applications.Rows.Add(application.Name, application.FileLocation);
            }

            GridApplications.DataSource = applications;

            GridViewApplications.Columns[0].Width = 200;
            GridViewApplications.Columns[1].Width = 300;

            ButtonDeleteAll.Enabled = GridViewApplications.RowCount > 0;

            GridViewApplications.BeginSort();

            if (GridViewApplications.RowCount > 0) GridViewApplications.SelectRow(0);
        }

        private void GridViewApplications_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (GridViewApplications.SelectedRowsCount > 0)
            {
                string name = GridViewApplications.GetRowCellValue(GridViewApplications.FocusedRowHandle, "Name").ToString();
                string location = GridViewApplications.GetRowCellValue(GridViewApplications.FocusedRowHandle, "FileLocation").ToString();

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
                XtraMessageBox.Show("All applications have now been removed from the list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void ButtonDeleteApplication_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want delete the selected item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Settings.ExternalApplications.RemoveAt(GridViewApplications.FocusedRowHandle);
                XtraMessageBox.Show("Application has now been removed from the list.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadExternalApplications();
            }
        }

        private void ButtonBrowseLocalFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
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
            TextBoxFileName.Reset();
            TextBoxFileLocation.Reset();
            TextBoxFileName.Focus();
        }

        private void ButtonAddApplication_Click(object sender, EventArgs e)
        {
            string appName = TextBoxFileName.Text;
            string fileLocation = TextBoxFileLocation.Text;

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
            for (int i = 0; i < GridViewApplications.RowCount; i++)
            {
                string appName = GridViewApplications.GetRowCellValue(GridViewApplications.FocusedRowHandle, "Name").ToString();
                string fileLocation = GridViewApplications.GetRowCellValue(GridViewApplications.FocusedRowHandle, "FileLocation").ToString();

                Settings.UpdateApplication(appName, fileLocation);
            }

            XtraMessageBox.Show("All external applications have been saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}