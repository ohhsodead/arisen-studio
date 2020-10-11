using DarkUI.Forms;
using ModioX.Models.Resources;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class EditExternalApplications : DarkForm
    {
        public EditExternalApplications()
        {
            InitializeComponent();
        }

        private void EditExternalApplications_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        public void UpdateUI()
        {
            DgvApplications.Rows.Clear();

            TextBoxFileName.Clear();
            TextBoxFileLocation.Clear();

            foreach (ExternalApplication application in MainWindow.SettingsData.ExternalApplications)
            {
                _ = DgvApplications.Rows.Add(application.Name, application.FileLocation);
            }

            LabelTotalApplications.Text = $"{DgvApplications.Rows.Count} Applications";

            ToolStripDeleteAll.Enabled = DgvApplications.Rows.Count > 0;

            DgvApplications.Sort(DgvApplications.Columns[0], ListSortDirection.Ascending);

            if (DgvApplications.Rows.Count > 0)
            {
                DgvApplications.CurrentCell = DgvApplications[0, 0];
            }
        }

        private void DgvApplications_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvApplications.SelectedRows.Count > 0)
            {
                string name = DgvApplications.SelectedRows[0].Cells[0].Value.ToString();
                string fileLocation = DgvApplications.SelectedRows[0].Cells[1].Value.ToString();

                TextBoxFileName.Text = name;
                TextBoxFileLocation.Text = fileLocation;
            }

            ToolStripDelete.Enabled = DgvApplications.SelectedRows.Count > 0;
        }

        private void ToolStripDelete_Click(object sender, EventArgs e)
        {
            int selectedItem = DgvApplications.SelectedRows[0].Index;
            MainWindow.SettingsData.ExternalApplications.RemoveAt(selectedItem);
            UpdateUI();
        }

        private void ToolStripDeleteAll_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.Show(this, $"Are you sure that you would like to delete of all your specified applications?", "Delete All Game Regions", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MainWindow.SettingsData.ExternalApplications.Clear();
                _ = DarkMessageBox.Show(this, $"All specified regions for games have now been deleted.", "Deleted All Game Regions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void ButtonLocalFilePath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { CheckFileExists = true, Multiselect = false, Filter = "Executable Files (*.exe)|*.exe|All files (*.*)|*." })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBoxFileLocation.Text = openFileDialog.FileName;
                }
            }
        }

        private void ButtonNewApplication_Click(object sender, EventArgs e)
        {
            TextBoxFileName.Text = "";
            TextBoxFileLocation.Text = "";
            TextBoxFileName.Focus();
        }

        private void ButtonAddApplication_Click(object sender, EventArgs e)
        {
            string appName = TextBoxFileName.Text;
            string fileLocation = TextBoxFileLocation.Text;

            if (string.IsNullOrWhiteSpace(appName))
            {
                _ = DarkMessageBox.Show(this, $"You must enter a name for this application.", "No Name", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(fileLocation))
            {
                _ = DarkMessageBox.Show(this, $"You must enter the file path for this application.", "No File Location", MessageBoxIcon.Exclamation);
                return;
            }

            if (!File.Exists(fileLocation))
            {
                _ = DarkMessageBox.Show(this, $"The file for this application doesn't exist on your computer. Please choose another file.", "File Doesn't Exist", MessageBoxIcon.Exclamation);
                return;
            }

            MainWindow.SettingsData.UpdateApplication(appName, fileLocation);
            UpdateUI();
        }

        private void ButtonSaveAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvApplications.Rows)
            {
                string name = row.Cells[0].Value.ToString();
                string fileLocation = row.Cells[1].Value.ToString();

                MainWindow.SettingsData.UpdateApplication(name, fileLocation);
            }

            MainWindow.SaveSettingsData();
            _ = DarkMessageBox.Show(this, $"All external applications have now been saved.", "External Applications Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}