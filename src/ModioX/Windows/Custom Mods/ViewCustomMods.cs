using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Models.Resources;
using ModioX.Models.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Windows.Custom_Mods
{
    public partial class ViewCustomMods : DarkForm
    {
        public ViewCustomMods()
        {
            InitializeComponent();
        }

        private void ViewCustomMods_Load(object sender, EventArgs e)
        {
            LoadCustomMods();
        }

        private void LoadCustomMods()
        {
            DgvCustomMods.Rows.Clear();

            foreach (CustomMod customMod in MainForm.SettingsData.CustomMods)
            {
                string gameId = string.IsNullOrEmpty(customMod.CategoryId) ? "n/a" : customMod.CategoryId;
                DgvCustomMods.Rows.Add(customMod.Name, MainForm.Categories.GetCategoryById(gameId).Title, string.Format("{0} {1}", customMod.InstallFiles.Count.ToString(), customMod.InstallFiles.Count > 1 ? "Files" : "File"));
            }
        }

        private void DgvCustomMods_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvCustomMods.SelectedRows.Count > 0)
            {
                ListViewInstallFiles.Items.Clear();

                CustomMod customMod = MainForm.SettingsData.CustomMods[DgvCustomMods.CurrentRow.Index];

                LabelName.Text = customMod.Name;
                LabelGame.Text = MainForm.Categories.GetCategoryById(customMod.CategoryId).Title;
                LabelDescription.Text = customMod.Description;

                foreach (var installFile in customMod.InstallFiles)
                {
                    ListViewInstallFiles.Items.Add(new DarkListItem(string.Format("{0} > {1}", installFile.LocalPath, installFile.ConsolePath)));
                }
            }

            ToolItemEdit.Enabled = DgvCustomMods.SelectedRows.Count > 0;
            ToolItemDelete.Enabled = DgvCustomMods.SelectedRows.Count > 0;
        }

        private void ToolStripItemEdit_Click(object sender, EventArgs e)
        {
            CustomMod customMod = MainForm.SettingsData.CustomMods[DgvCustomMods.CurrentRow.Index];

            using (EditCustomMod editCustomMod = new EditCustomMod()
            {
                CustomMod = customMod,
                CustomModIndex = DgvCustomMods.CurrentRow.Index
            })
            {
                editCustomMod.ShowDialog(this);
            }

            LoadCustomMods();
        }

        private void ToolStripItemDelete_Click(object sender, EventArgs e)
        {
            CustomMod customMod = MainForm.SettingsData.CustomMods[DgvCustomMods.CurrentRow.Index];

            if (DarkMessageBox.Show(this, "Are you sure about deleting this custom mod item and all of the details? This can't be undone.", "Delete Mod Item", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                MainForm.SettingsData.RemoveMod(DgvCustomMods.CurrentRow.Index);
                LoadCustomMods();
            }
        }

        private void ToolStripCreate_Click(object sender, EventArgs e)
        {
            using (EditCustomMod editCustomMod = new EditCustomMod() { CustomMod = new CustomMod() })
            {
                editCustomMod.ShowDialog();
            }
        }

        private void ToolStripItemUninstall_Click(object sender, EventArgs e)
        {
            CustomMod customMod = MainForm.SettingsData.CustomMods[DgvCustomMods.CurrentRow.Index];
            UninstallCustomMods(customMod);
        }

        private void ToolStripItemInstall_Click(object sender, EventArgs e)
        {
            CustomMod customMod = MainForm.SettingsData.CustomMods[DgvCustomMods.CurrentRow.Index];
            InstallCustomMods(customMod);
        }

        public void InstallCustomMods(CustomMod customMod)
        {
            CategoriesData.Category category = MainForm.Categories.GetCategoryById(customMod.CategoryId);

            string gameTitle;
            string gameRegion;

            try
            {
                if (category.RequiresRegion())
                {
                    gameRegion = category.GetGameRegion(MainForm.ConsoleProfile.Address);
                    gameTitle = $"{category.Title} ({gameRegion})";

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        DarkMessageBox.Show(this, "There was no region chosen for this game title. Process can't continue.", "No Region", MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    gameRegion = null;
                    gameTitle = $"{category.Title}";
                }

                foreach (InstallFile installFile in customMod.InstallFiles)
                {
                    string installPath = installFile.LocalPath.Replace("/{REGION}/", $"/{gameRegion}/");

                    if (!File.Exists(installFile.LocalPath))
                    {
                        DarkMessageBox.Show(this, "A file you have included for this custom mod doesn't exist on your computer.", "No Mod File", MessageBoxIcon.Information);
                        return;
                    }

                    FtpExtensions.UploadFile(MainForm.ConsoleProfile.Address, installFile.LocalPath, installPath);
                }

                DarkMessageBox.Show(this, string.Format("Installed {0} modded files for {1}", customMod.InstallFiles.Count.ToString(), gameTitle), "Installed Mod", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error("An error occurred when installing a custom mod", ex);
                DarkMessageBox.Show(this, "There was an issue installing this custom mod. Make sure there aren't any typos in the local or console file paths.", "Custom Mod Error", MessageBoxIcon.Error);
            }
        }

        public void UninstallCustomMods(CustomMod customMod)
        {
            CategoriesData.Category category = MainForm.Categories.GetCategoryById(customMod.CategoryId);

            string gameTitle;
            string gameRegion;

            try
            {
                if (category.RequiresRegion())
                {
                    gameRegion = category.GetGameRegion(MainForm.ConsoleProfile.Address);
                    gameTitle = $"{category.Title} ({gameRegion})";

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        DarkMessageBox.Show(this, "There was no region chosen for this game title. Process can't continue.", "No Region", MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    gameRegion = null;
                    gameTitle = $"{category.Title}";
                }

                foreach (InstallFile installFile in customMod.InstallFiles)
                {
                    if (installFile.ConsolePath.Contains("dev_hdd0/game/"))
                    {
                        BackupFile gameBackupFile = MainForm.SettingsData.GetGameFileBackup(customMod.CategoryId, Path.GetFileName(installFile.ConsolePath), installFile.ConsolePath);

                        if (gameBackupFile != null)
                        {
                            string installPath = gameBackupFile.InstallPath.Replace("/{REGION}/", $"/{gameRegion}/");

                            if (File.Exists(gameBackupFile.LocalPath))
                            {
                                FtpExtensions.UploadFile(MainForm.ConsoleProfile.Address, gameBackupFile.LocalPath, installPath);
                            }
                            else
                            {
                                DarkMessageBox.Show(this, "You've created a backup for this game file, but the file doesn't exist anymore. Open the Tools > Game File Backup Manager to edit your backup set the local file. This game file will be ignored.", "No Backup File", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        FtpExtensions.DeleteFile(MainForm.ConsoleProfile.Address, installFile.ConsolePath);
                    }
                }

                DarkMessageBox.Show(this, string.Format("Uninstalled {0} modded files for {1}", customMod.InstallFiles.Count.ToString(), gameTitle), "Uninstall Mod", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error("An error occurred when uninstalling a custom mod.", ex);
                DarkMessageBox.Show(this, "There was an issue uninstalling this custom mod. Make sure there aren't any typos in the local or console file paths.", "Custom Mod Error", MessageBoxIcon.Error);
            }
        }

    }
}