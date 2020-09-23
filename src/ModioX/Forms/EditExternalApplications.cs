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

            TextBoxName.Clear();
            TextBoxFileLocation.Clear();

            foreach (ExternalApplication application in MainForm.SettingsData.ExternalApplications)
            {
                _ = DgvApplications.Rows.Add(application.Name, application.FileLocation);
            }

            LabelTotalApplications.Text = $"{DgvApplications.Rows.Count} Applications";
            LabelTotalApplications.Visible = DgvApplications.Rows.Count > 0;

            ToolItemDeleteAll.Enabled = DgvApplications.Rows.Count > 0;

            DgvApplications.Sort(DgvApplications.Columns[0], ListSortDirection.Ascending);

            if (DgvApplications.Rows.Count > 0)
            {
                DgvApplications.CurrentCell = DgvApplications[0, 0];
            }
        }

        private void DgvGameRegions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvApplications.SelectedRows.Count > 0)
            {
                string name = DgvApplications.SelectedRows[0].Cells[0].Value.ToString();
                string fileLocation = DgvApplications.SelectedRows[0].Cells[1].Value.ToString();

                TextBoxName.Text = name;
                TextBoxFileLocation.Text = fileLocation;
            }
        }

        private void ToolItemDeleteAll_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.Show(this, $"Are you sure that you would like to delete of all your specified applications?", "Delete All Game Regions", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MainForm.SettingsData.ExternalApplications.Clear();
                _ = DarkMessageBox.Show(this, $"All specified regions for games have now been deleted.", "Deleted All Game Regions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void ButtonAddGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                _ = DarkMessageBox.Show(this, $"You haven't specified an application name.", "Application Name Empty", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxFileLocation.Text))
            {
                _ = DarkMessageBox.Show(this, $"You haven't specified a file location for this application.", "File Location Empty", MessageBoxIcon.Exclamation);
                return;
            }

            if (!File.Exists(TextBoxFileLocation.Text))
            {
                _ = DarkMessageBox.Show(this, $"The file for this application doesn't exist on your computer. Please choose another file.", "File Doesn't Exist", MessageBoxIcon.Exclamation);
                return;
            }

            string name = TextBoxName.Text;
            string fileLocation = TextBoxFileLocation.Text;

            MainForm.SettingsData.UpdateApplication(name, fileLocation);
            UpdateUI();
        }

        private void ButtonLocalPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { CheckFileExists = true, Multiselect = false, Filter = "Executable Files (*.exe)|*.exe|All files (*.*)|*." })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBoxFileLocation.Text = openFileDialog.FileName;
                }
            }
        }

        private void ButtonSaveAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvApplications.Rows)
            {
                string name = row.Cells[0].Value.ToString();
                string fileLocation = row.Cells[1].Value.ToString();

                MainForm.SettingsData.UpdateApplication(name, fileLocation);
            }

            MainForm.SaveSettingsData();
            _ = DarkMessageBox.Show(this, $"All external applications have now been saved.", "External Applications Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}