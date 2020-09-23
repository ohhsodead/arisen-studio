using DarkUI.Forms;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using System;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class EditCustomModDetails : DarkForm
    {
        public CustomMod CustomMod { get; set; } = new CustomMod();

        public int? CustomModIndex { get; set; }

        public EditCustomModDetails()
        {
            InitializeComponent();
        }

        private void EditCustomMod_Load(object sender, EventArgs e)
        {
            foreach (CategoriesData.Category game in MainForm.Categories.GetGames())
            {
                _ = ComboBoxCategoryTitle.Items.Add(game.Title);
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            DgvInstallFilePaths.Rows.Clear();

            TextBoxName.Text = CustomMod.Name;
            TextBoxDescription.Text = CustomMod.Description;
            ComboBoxCategoryTitle.Text = CustomMod.CategoryTitle;

            foreach (InstallFile installFile in CustomMod.InstallFiles)
            {
                DgvInstallFilePaths.Rows.Add(installFile.LocalPath, installFile.ConsolePath);
            }
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            CustomMod.Name = TextBoxName.Text;
        }
        private void ComboBoxCategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCategoryTitle.SelectedIndex != -1)
            {
                string categoryTitle = ComboBoxCategoryTitle.GetItemText(ComboBoxCategoryTitle.SelectedItem);

                CustomMod.CategoryId = MainForm.Categories.GetCategoryByTitle(categoryTitle).Id;
                CustomMod.CategoryTitle = categoryTitle;
            }
        }

        private void TextBoxDescription_TextChanged(object sender, EventArgs e)
        {
            CustomMod.Description = TextBoxDescription.Text;
        }

        private void ButtonLocalPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { CheckFileExists = true, Multiselect = false })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBoxLocalPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void ButtonAddInstall_Click(object sender, EventArgs e)
        {
            CustomMod.InstallFiles.Add(new InstallFile(TextBoxLocalPath.Text, TextBoxConsolePath.Text));
            UpdateUI();
        }

        private void ButtonRemoveInstallFile_Click(object sender, EventArgs e)
        {
            int selectedItem = DgvInstallFilePaths.Rows[DgvInstallFilePaths.SelectedRows[0].Index].Index;
            CustomMod.InstallFiles.RemoveAt(selectedItem);
            UpdateUI();
        }

        private void DgvInstallFilePaths_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvInstallFilePaths.SelectedRows.Count > 0)
            {
                int selectedItem = DgvInstallFilePaths.Rows[DgvInstallFilePaths.SelectedRows[0].Index].Index;
                InstallFile installFile = CustomMod.InstallFiles[selectedItem];

                TextBoxLocalPath.Text = installFile.LocalPath;
                TextBoxConsolePath.Text = installFile.ConsolePath;
            }

            ButtonRemoveInstallFile.Enabled = DgvInstallFilePaths.SelectedRows.Count > 0;
        }

        private void ButtonSaveMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomMod.Name))
            {
                _ = DarkMessageBox.Show(this, "You must include a useful name for this mod.", "No Name", MessageBoxIcon.Exclamation);
                return;
            }

            if (ComboBoxCategoryTitle.SelectedIndex == -1)
            {
                _ = DarkMessageBox.Show(this, "You must include a category to this mod.", "No Name", MessageBoxIcon.Exclamation);
                return;
            }

            if (CustomMod.InstallFiles.Count < 1)
            {
                _ = DarkMessageBox.Show(this, "You must include at least one file to be installed for this mod.", "No Local Path", MessageBoxIcon.Exclamation);
                return;
            }

            if (CustomModIndex.HasValue)
            {
                MainForm.SettingsData.UpdateCustomMod(CustomModIndex.Value, CustomMod);
            }
            else
            {
                MainForm.SettingsData.AddCustomMod(CustomMod);
            }

            Close();
        }
    }
}