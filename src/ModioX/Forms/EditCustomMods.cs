using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using System;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class EditCustomMods : DarkForm
    {
        public EditCustomMods()
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
                _ = DgvCustomMods.Rows.Add(customMod.Name,
                                           string.IsNullOrEmpty(customMod.CategoryTitle) ? "n/a" : customMod.CategoryTitle,
                                           string.Format("{0} {1}", customMod.InstallFiles.Count.ToString(), customMod.InstallFiles.Count > 1 ? "Files" : "File"),
                                           string.Format("{0:g}", customMod.CreatedDate));
            }
        }

        private void DgvCustomMods_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvCustomMods.SelectedRows.Count > 0)
            {
                DgvInstallFilePaths.Rows.Clear();

                CustomMod customMod = MainForm.SettingsData.CustomMods[DgvCustomMods.CurrentRow.Index];

                LabelName.Text = customMod.Name;
                LabelCategory.Text = customMod.CategoryTitle;
                LabelDescription.Text = customMod.Description;

                foreach (InstallFile installFile in customMod.InstallFiles)
                {
                    _ = DgvInstallFilePaths.Rows.Add(installFile.LocalPath, installFile.ConsolePath);
                }
            }

            ToolItemEdit.Enabled = DgvCustomMods.SelectedRows.Count > 0;
            ToolItemDelete.Enabled = DgvCustomMods.SelectedRows.Count > 0;
            ToolItemInstall.Enabled = DgvCustomMods.SelectedRows.Count > 0 && MainForm.IsConsoleConnected;
            ToolItemUninstall.Enabled = DgvCustomMods.SelectedRows.Count > 0 && MainForm.IsConsoleConnected;
        }

        private void ToolStripItemEdit_Click(object sender, EventArgs e)
        {
            CustomMod customMod = MainForm.SettingsData.CustomMods[DgvCustomMods.CurrentRow.Index];

            using (EditCustomModDetails editCustomMod = new EditCustomModDetails()
            {
                CustomMod = customMod,
                CustomModIndex = DgvCustomMods.CurrentRow.Index
            })
            {
                _ = editCustomMod.ShowDialog(this);
                LoadCustomMods();
            }
        }

        private void ToolStripItemDelete_Click(object sender, EventArgs e)
        {
            if (DarkMessageBox.Show(this, "Are you sure that you woud like to delete this mod and all of the details? This can't be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MainForm.SettingsData.RemoveCustomMod(DgvCustomMods.CurrentRow.Index);
                LoadCustomMods();
            }
        }

        private void ToolStripCreate_Click(object sender, EventArgs e)
        {
            using (EditCustomModDetails editCustomMod = new EditCustomModDetails() { CustomMod = new CustomMod() })
            {
                _ = editCustomMod.ShowDialog();
                LoadCustomMods();
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
            CategoriesData.Category category = MainForm.Categories.GetCategoryByTitle(customMod.CategoryTitle);

            string gameRegion;
            string gameTitle;
            string userId;

            try
            {
                if (customMod.RequiresRegion())
                {
                    gameRegion = category.GetGameRegion(MainForm.ConsoleProfile.Address, customMod.CategoryId);
                    gameTitle = $"{category.Title} ({gameRegion})";

                    userId = null;

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        return;
                    }
                }
                else if (customMod.RequiresUserId())
                {
                    userId = FtpExtensions.GetUserId(MainForm.ConsoleProfile.Address);

                    gameTitle = $"{category.Title} ({userId})";
                    gameRegion = null;

                    if (string.IsNullOrEmpty(userId))
                    {
                        return;
                    }
                }
                else
                {
                    gameRegion = null;
                    gameTitle = $"{category.Title}";

                    userId = null;
                }

                foreach (InstallFile installFile in customMod.InstallFiles)
                {
                    if (File.Exists(installFile.LocalPath))
                    {
                        if (installFile.ConsolePath.Contains("dev_hdd0/game/"))
                        {
                            string installFileName = Path.GetFileName(installFile.ConsolePath);

                            string installPath = installFile.ConsolePath
                                .Replace("/{REGION}/", $"/{gameRegion}/")
                                .Replace("/{USERID}/", $"/{userId}/");

                            BackupFile backupFile = MainForm.SettingsData.GetGameFileBackup(category.Id, installFileName, installPath);

                            if (backupFile == null)
                            {
                                if (DarkMessageBox.Show(this, "A file is being replaced in the game folder and a backup file hasn't been created. Would you like to backup the original game file before installing this file? You can then revert the mods at anytime using either the Uninstall option, or the Tools > Backup File Manager window to restore the game file its original state.\n\nFile being installed : " + Path.GetFileName(installFile.LocalPath), "Backup Game File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    MainForm.CreateBackupFile(new ModsData.ModItem() { GameId = category.Id }, installFileName, installPath);

                                    FtpExtensions.UploadFile(MainForm.ConsoleProfile.Address, installFile.LocalPath, installPath);
                                }
                                else
                                {
                                    FtpExtensions.UploadFile(MainForm.ConsoleProfile.Address, installFile.LocalPath, installPath);
                                }
                            }
                            else
                            {
                                FtpExtensions.UploadFile(MainForm.ConsoleProfile.Address, installFile.LocalPath, installPath);
                            }
                        }
                        else if (installFile.ConsolePath.Contains("dev_usb000/"))
                        {
                            if (DarkMessageBox.Show(this, "A file wants to be installed to a usb device connected to the console - it maybe required for the mods to function. I suggest you read the complete description to see if anything is mentioned there. It could maybe be used for configuration or settings purposes." +
                                "\n\nIf you would still like to continue, then insert your usb into the right-most slot of the console ports at the front. So, should the file be installed? Only click 'YES' if you've connected the usb device. Otherwise click 'NO' and this file will be ignored.", "USB File", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                FtpExtensions.UploadFile(MainForm.ConsoleProfile.Address, installFile.LocalPath, installFile.ConsolePath);
                            }
                        }
                        else
                        {
                            FtpExtensions.UploadFile(MainForm.ConsoleProfile.Address, installFile.LocalPath, installFile.ConsolePath);
                        }
                    }
                    else
                    {
                        _ = DarkMessageBox.Show(this, "A file you have included for this custom mod doesn't exist on your computer.", "No Mod File", MessageBoxIcon.Information);
                    }
                }

                _ = DarkMessageBox.Show(this, string.Format("Installed {0} modded files for {1}", customMod.InstallFiles.Count.ToString(), gameTitle), "Installed Mod", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error("An error occurred when installing a custom mod. " + customMod.ToString(), ex);
                _ = DarkMessageBox.Show(this, "There was an issue installing this custom mod. Make sure there aren't any typos in the local or console file paths.", "Custom Mod Error", MessageBoxIcon.Error);
            }
        }

        public void UninstallCustomMods(CustomMod customMod)
        {
            try
            {
                CategoriesData.Category category = MainForm.Categories.GetCategoryByTitle(customMod.CategoryTitle);

                string gameTitle;
                string gameRegion;

                string userId;

                if (customMod.RequiresRegion())
                {
                    gameRegion = category.GetGameRegion(MainForm.ConsoleProfile.Address, customMod.CategoryId);
                    gameTitle = $"{category.Title} ({gameRegion})";

                    userId = null;

                    if (string.IsNullOrEmpty(gameRegion))
                    {
                        return;
                    }
                }
                else if (customMod.RequiresUserId())
                {
                    userId = FtpExtensions.GetUserId(MainForm.ConsoleProfile.Address);

                    gameTitle = $"{category.Title} ({userId})";
                    gameRegion = null;

                    if (string.IsNullOrEmpty(userId))
                    {
                        return;
                    }
                }
                else
                {
                    gameRegion = null;
                    gameTitle = $"{category.Title}";

                    userId = null;
                }

                foreach (InstallFile installFile in customMod.InstallFiles)
                {
                    if (installFile.ConsolePath.Contains("dev_hdd0/game/"))
                    {
                        string installFileName = Path.GetFileName(installFile.ConsolePath);

                        string installPath = installFile.ConsolePath
                            .Replace("/{REGION}/", $"/{gameRegion}/")
                            .Replace("/{USERID}/", $"/{userId}/");

                        BackupFile backupFile = MainForm.SettingsData.GetGameFileBackup(category.Id, installFileName, installPath);

                        if (backupFile != null)
                        {
                            if (File.Exists(backupFile.LocalPath))
                            {
                                FtpExtensions.UploadFile(MainForm.ConsoleProfile.Address, backupFile.LocalPath, installPath);
                            }
                            else
                            {
                                _ = DarkMessageBox.Show(this, "You have created a backup for this game file, but the file doesn't exist on your computer anymore. Open the Tools > Game File Backup Manager to edit your backup and set the local file. This game file will be ignored for now.", "No Existing Backup File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            _ = DarkMessageBox.Show(this, "You haven't created a backup for this game file. This game file will be ignored otherwise the game may have issues with missing files.", "No Created Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (installFile.ConsolePath.Contains("dev_usb000/"))
                    {
                        if (DarkMessageBox.Show(this, "The mod wants to uninstall a file from your USB drive." +
                            "\n\nIf you would still like to continue, then insert your usb into the right-most slot at the front of the console. Would you like to uninstall this file? Only click 'YES' if you've connected the USB device. Otherwise this file will be ignored.", "Uninstall USB File", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            FtpExtensions.DeleteFile(MainForm.ConsoleProfile.Address, installFile.ConsolePath);
                        }
                    }
                    else
                    {
                        FtpExtensions.DeleteFile(MainForm.ConsoleProfile.Address, installFile.ConsolePath);
                    }
                }

                _ = DarkMessageBox.Show(this, string.Format("Uninstalled {0} modded files for {1}", customMod.InstallFiles.Count.ToString(), gameTitle), "Uninstall Mod", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error("An error occurred when uninstalling a custom mod. " + customMod.ToString(), ex);
                _ = DarkMessageBox.Show(this, "There was an issue uninstalling this custom mod. Make sure there aren't any typos in the local or console file paths.", "Custom Mod Error", MessageBoxIcon.Error);
            }
        }

    }
}