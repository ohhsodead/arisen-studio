using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Models.Resources;
using System;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class EditCustomMod : DarkForm
    {
        public CustomMod CustomMod { get; set; } = new CustomMod();

        public int? CustomModIndex { get; set; } 

        public EditCustomMod()
        {
            InitializeComponent();
        }

        private void EditCustomMod_Load(object sender, EventArgs e)
        {
            foreach (var category in MainForm.Categories.Categories)
            {
                ComboBoxCategoryTitle.Items.Add(category.Title);
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            ListViewInstallFiles.Items.Clear();

            TextBoxName.Text = CustomMod.Name;
            TextBoxDescription.Text = CustomMod.Description;
            ComboBoxCategoryTitle.Text = CustomMod.CategoryTitle;

            foreach (var installFile in CustomMod.InstallFiles)
            {
                ListViewInstallFiles.Items.Add(new DarkListItem() { Text = installFile.LocalPath + " > " +  installFile.ConsolePath });
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
            CustomMod.InstallFiles.Add(new InstallFile() { LocalPath = TextBoxLocalPath.Text, ConsolePath = TextBoxConsolePath.Text });
            UpdateUI();
        }

        private void ButtonRemoveInstallFile_Click(object sender, EventArgs e)
        {
            DarkListItem selectedItem = ListViewInstallFiles.Items[ListViewInstallFiles.SelectedIndices[0]];
            CustomMod.InstallFiles.RemoveAt(ListViewInstallFiles.Items.IndexOf(selectedItem));
            UpdateUI();
        }

        private void ListViewInstallFiles_SelectedIndicesChanged(object sender, EventArgs e)
        {
            if (ListViewInstallFiles.SelectedIndices.Count > 0)
            {
                DarkListItem selectedItem = ListViewInstallFiles.Items[ListViewInstallFiles.SelectedIndices[0]];
                InstallFile installFile = CustomMod.InstallFiles[ListViewInstallFiles.Items.IndexOf(selectedItem)];

                TextBoxLocalPath.Text = installFile.LocalPath;
                TextBoxConsolePath.Text = installFile.ConsolePath;
            }

            ButtonRemoveInstallFile.Enabled = ListViewInstallFiles.SelectedIndices.Count > 0;
        }

        private void ButtonSaveMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomMod.Name))
            {
                DarkMessageBox.Show(this, "You must include a useful name for this mod.", "No Name", MessageBoxIcon.Exclamation);
                return;
            }

            if (ComboBoxCategoryTitle.SelectedIndex == -1)
            {
                DarkMessageBox.Show(this, "You must include a category to this mod.", "No Name", MessageBoxIcon.Exclamation);
                return;
            }

            if (CustomMod.InstallFiles.Count < 1)
            {
                DarkMessageBox.Show(this, "You must include at least one file to be installed for this mod.", "No Local Path", MessageBoxIcon.Exclamation);
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