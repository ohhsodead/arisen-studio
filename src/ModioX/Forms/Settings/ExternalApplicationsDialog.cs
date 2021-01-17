using DarkUI.Forms;
using DevExpress.XtraEditors;
using ModioX.Forms.Windows;
using System;
using System.ComponentModel;
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

        private void EditExternalApplications_Load(object sender, EventArgs e)
        {
            LoadExternalApplications();
        }

        private void LoadExternalApplications()
        {
            /*
            DgvApplications.Rows.Clear();

            TextBoxFileName.Clear();
            TextBoxFileLocation.Clear();

            foreach (var application in MainWindow.Settings.ExternalApplications)
            {
                _ = DgvApplications.Rows.Add(application.Name, application.FileLocation);
            }

            LabelTotalApplications.Text = $@"{DgvApplications.Rows.Count} Applications";

            ToolStripDeleteAll.Enabled = DgvApplications.Rows.Count > 0;

            DgvApplications.Sort(DgvApplications.Columns[0], ListSortDirection.Ascending);

            if (DgvApplications.Rows.Count > 0) DgvApplications.CurrentCell = DgvApplications[0, 0];
            */
        }

        private void DgvApplications_SelectionChanged(object sender, EventArgs e)
        {
            /*
            if (DgvApplications.SelectedRows.Count > 0)
            {
                var name = DgvApplications.SelectedRows[0].Cells[0].Value.ToString();
                var fileLocation = DgvApplications.SelectedRows[0].Cells[1].Value.ToString();

                TextBoxFileName.Text = name;
                TextBoxFileLocation.Text = fileLocation;
            }

            ToolStripDelete.Enabled = DgvApplications.SelectedRows.Count > 0;
            */
        }

        private void ToolStripDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want delete the selected item?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //MainWindow.Settings.ExternalApplications.RemoveAt(DgvApplications.SelectedRows[0].Index);
                LoadExternalApplications();
            }
        }

        private void ToolStripDeleteAll_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure that you would like to delete of all your specified applications?", "Delete All Game Regions", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainWindow.Settings.ExternalApplications.Clear();
                XtraMessageBox.Show("All specified regions for games have now been deleted.", "Deleted All Game Regions");
                Close();
            }
        }

        private void ButtonLocalFilePath_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Multiselect = false,
                Filter = @"Executable Files (*.exe)|*.exe|All files (*.*)|*."
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) TextBoxFileLocation.Text = openFileDialog.FileName;
        }

        private void ButtonNewApplication_Click(object sender, EventArgs e)
        {
            TextBoxFileName.Text = "";
            TextBoxFileLocation.Text = "";
            _ = TextBoxFileName.Focus();
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

            MainWindow.Settings.UpdateApplication(appName, fileLocation);
            LoadExternalApplications();
        }

        private void ButtonSaveAll_Click(object sender, EventArgs e)
        {
            /*
            foreach (DataGridViewRow row in DgvApplications.Rows)
            {
                var appName = row.Cells[0].Value.ToString();
                var fileLocation = row.Cells[1].Value.ToString();

                MainWindow.Settings.UpdateApplication(appName, fileLocation);
            }
            */

            XtraMessageBox.Show("All external applications have now been saved.", "Saved");
            Close();
        }
    }
}