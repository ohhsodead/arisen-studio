using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Models.Resources;
using System;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Windows.Custom_Mods
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
            foreach (var customMod in MainForm.SettingsData.CustomMods)
            {
                ComboBoxCustomMods.Items.Add(string.Format("{0} ({1}) ({2} Files)", customMod.Name, customMod.CategoryId, customMod.InstallFiles.Count.ToString()));
            }

            if (CustomModIndex.HasValue)
            {
                ComboBoxCustomMods.SelectedIndex = CustomModIndex.Value;
            }

            foreach (var category in MainForm.Categories.Categories)
            {
                ComboBoxCategoryId.Items.Add(category.Id.ToUpper());
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            ListViewInstallFiles.Items.Clear();

            TextBoxName.Text = CustomMod.Name;
            TextBoxDescription.Text = CustomMod.Description;
            ComboBoxCategoryId.Text = CustomMod.CategoryId;

            foreach (var installFile in CustomMod.InstallFiles)
            {
                ListViewInstallFiles.Items.Add(new DarkListItem() { Text = installFile.LocalPath + " > " +  installFile.ConsolePath });
            }
        }


        private void ComboBoxCustomMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCustomMods.SelectedIndex != -1)
            {
                CustomMod = MainForm.SettingsData.CustomMods[ComboBoxCustomMods.SelectedIndex];
                CustomModIndex = ComboBoxCustomMods.SelectedIndex;
            }

            UpdateUI();
        }

        private void ButtonNewMod_Click(object sender, EventArgs e)
        {
            if (ComboBoxCustomMods.SelectedIndex != -1)
            {
                if (DarkMessageBox.Show(this, "Would you like to update the current mod information before creating a new one?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(TextBoxName.Text))
                    {
                        DarkMessageBox.Show(this, "You haven't provided a job name for the details.", "Attention", MessageBoxIcon.Warning);
                        return;
                    }

                    if (ListViewInstallFiles.Items.Count < 1)
                    {
                        DarkMessageBox.Show(this, "You haven't provided any files to be installed for this mod. There must be at least one file.", "Attention", MessageBoxIcon.Warning);
                        return;
                    }

                    MainForm.SettingsData.UpdateMod(ComboBoxCustomMods.SelectedIndex, CustomMod);

                    DarkMessageBox.Show(this, string.Format("You have updated the information for job {0} (#{1}).", CustomMod.Name, CustomMod.CategoryId), "Updated Mod", MessageBoxIcon.Information);
                }
            }

            CustomMod = new CustomMod();
            ComboBoxCustomMods.SelectedIndex = -1;
            UpdateUI();
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            CustomMod.Name = TextBoxName.Text;
        }
        private void ComboBoxCategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomMod.CategoryId = ComboBoxCategoryId.GetItemText(ComboBoxCategoryId.SelectedItem).ToUpper();
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

            if (ComboBoxCategoryId.SelectedIndex == -1)
            {
                DarkMessageBox.Show(this, "You must include a category to this mod.", "No Name", MessageBoxIcon.Exclamation);
                return;
            }

            if (CustomMod.InstallFiles.Count < 1)
            {
                DarkMessageBox.Show(this, "You must include at least one file to be installed for this mod.", "No Local Path", MessageBoxIcon.Exclamation);
                return;
            }

            if (ComboBoxCustomMods.SelectedIndex == -1)
            {
                MainForm.SettingsData.AddMod(CustomMod);
            }
            else
            {
                MainForm.SettingsData.UpdateMod(ComboBoxCustomMods.SelectedIndex, CustomMod);
            }

            Close();
        }

    }
}