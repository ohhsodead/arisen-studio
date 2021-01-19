using DarkUI.Forms;
using DevExpress.XtraEditors;
using FluentFTP;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using FtpExtensions = ModioX.Extensions.FtpExtensions;

namespace ModioX.Forms.Tools.PS3_Tools
{
    public partial class PackageManagerWindow : XtraForm
    {
        public PackageManagerWindow()
        {
            InitializeComponent();
        }

        private FtpClient FtpClient { get; } = MainWindow.FtpClient;

        private string PackageFilesPath { get; } = "/dev_hdd0/packages";

        private List<FtpListItem> PackageFiles { get; set; } = new List<FtpListItem>();

        private void PackageManagerWindow_Load(object sender, EventArgs e)
        {

        }

        private void TimerWait_Tick(object sender, EventArgs e)
        {
            LoadPackages();
            TimerWait.Enabled = false;
        }

        private void LoadPackages()
        {
            /*
            DgvPackages.Rows.Clear();

            FtpClient.SetWorkingDirectory(PackageFilesPath);

            foreach (FtpListItem listItem in FtpClient.GetListing(PackageFilesPath))
            {
                switch (listItem.Type)
                {
                    case FtpFileSystemObjectType.Directory:
                        break;

                    case FtpFileSystemObjectType.File:
                        PackageFiles.Add(listItem);
                        break;

                    case FtpFileSystemObjectType.Link:
                        break;
                }
            }

            foreach (FtpListItem package in PackageFiles)
            {
                DgvPackages.Rows.Add(package.Name, MainWindow.Settings.ShowFileSizeInBytes ? package.Size.ToString("#,0") + " bytes" : StringExtensions.FormatSize(package.Size.ToString()), ImageExtensions.ResizeBitmap(Properties.Resources.download_from_the_cloud, 20, 20));
            }

            LabelNoPackageFiles.Visible = DgvPackages.Rows.Count < 1;
            LabelTotalPackageFiles.Text = $"{DgvPackages.Rows.Count} Package Files";

            // Check package files for newer versions
            foreach (var packageFile in PackageFiles)
            {
                var installedPackageFile = MainWindow.Settings.GetInstalledPackageFile(packageFile.Name);

                if (installedPackageFile != null)
                {
                    if (MainWindow.Settings.IsPackageFileOldVersion(MainWindow.Database.Mods, MainWindow.Database.CategoriesData, installedPackageFile))
                    {
                        if (XtraMessageBox.Show($"There is a new homebrew version for package file: {packageFile.Name}.\n\nWould you like to update it now?", "New Homebrew Version", MessageBoxButtons.YesNo) == MessageBoxButtons.Yes)
                        {
                            //MainWindow.Window.UninstallMods(MainWindow.Database.Mods.GetModById(pkgFile.Id));
                            //MainWindow.Window.InstallMods(MainWindow.Database.Mods.GetModById(pkgFile.Id));
                        }                        
                    }
                }
            }
            */
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ButtonSearch.Enabled = !string.IsNullOrWhiteSpace(TextBoxSearch.Text);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            foreach (FtpListItem package in PackageFiles.FindAll(x => x.Name.Contains(TextBoxSearch.Text)))
            {
                //DgvPackages.Rows.Add(package.Name, MainWindow.Settings.ShowFileSizeInBytes ? package.Size.ToString("{n0}", CultureInfo.CurrentCulture) + " bytes" : StringExtensions.FormatSize(package.Size.ToString()), ImageExtensions.ResizeBitmap(Properties.Resources.download_from_the_cloud, 20, 20));
            }
        }

        private void DgvPackages_SelectionChanged(object sender, EventArgs e)
        {
            //ToolStripDeleteSelected.Enabled = DgvPackages.CurrentRow != null;
            //ContextMenuDownloadToComputer.Enabled = DgvPackages.CurrentRow != null;
        }

        private void DgvPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (DgvPackages.CurrentRow != null)
            {
                if (DgvPackages.CurrentCell.ColumnIndex.Equals(2))
                {
                    DownloadToComputer();
                }
            }
            */
        }

        private void ToolStripInstallPackageFile_Click(object sender, EventArgs e)
        {
            InstallPackage();
        }

        private void ToolStripDeleteSelected_Click(object sender, EventArgs e)
        {
            /*
            if (XtraMessageBox.Show("Do you really want to delete the selected package file from your console?", "Delete Selected", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string packageFileName = DgvPackages.Rows[DgvPackages.CurrentRow.Index].Cells[0].Value.ToString();

                UpdateStatus($"Deleting package file: {packageFileName}");
                FtpExtensions.DeleteFile(MainWindow.FtpClient, PackageFilesPath + "/" + packageFileName);
                UpdateStatus($"Successfully deleted package file.");
                LoadPackages();
            }
            */
        }

        private void ToolStripDeleteAll_Click(object sender, EventArgs e)
        {
            /*
            if (XtraMessageBox.Show("Do you really to delete all of your package files from your console?", "Delete All", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (FtpListItem package in PackageFiles)
                {
                    UpdateStatus($"Deleting package file: {package.Name}");
                    FtpExtensions.DeleteFile(MainWindow.FtpClient, PackageFilesPath + "/" + package.Name);
                    UpdateStatus($"Successfully deleted package file.");
                    LoadPackages();
                }
            }
            */
        }

        private void ContextMenuDownloadToComptuer_Click(object sender, EventArgs e)
        {
            DownloadToComputer();
        }

        /// <summary>
        /// Download the selected package file to the specified folder from the user.
        /// </summary>
        private void DownloadToComputer()
        {
            /*
            if (DgvPackages.CurrentRow != null)
            {
                string updateUrl = DgvPackages.CurrentRow.Cells[0].Value.ToString();
                string fileName = Path.GetFileName(updateUrl);
                string folderPath = DialogExtensions.ShowFolderBrowseDialog(this, "Select the folder where you want to download the package file.");

                if (!string.IsNullOrWhiteSpace(folderPath))
                {
                    UpdateStatus("Downloading file: " + fileName);
                    HttpExtensions.DownloadFile(updateUrl, folderPath + "/" + fileName);
                    UpdateStatus("Successfully downloaded file to the specified folder.");
                    LoadPackages();
                }
            }
            */
        }

        /// <summary>
        /// Upload a selected package file from the computer to console's packages folder.
        /// </summary>
        private void InstallPackage()
        {
            string localFilePath = DialogExtensions.ShowOpenFileDialog(this, "Choose Package File", "PKG Files (*.pkg)|*.pkg");

            if (!string.IsNullOrWhiteSpace(localFilePath))
            {
                string fileName = Path.GetFileName(localFilePath);
                string installFilePath = PackageFilesPath + "/" + fileName;

                if (FtpClient.FileExists(installFilePath))
                {
                    DarkMessageBox.ShowError("Package file with this name already exists on your console.", "Package File Exists");
                    return;
                }

                UpdateStatus("Installing package file: " + fileName);
                FtpExtensions.UploadFile(localFilePath, installFilePath);
                UpdateStatus("Successfully installed package file.");
                LoadPackages();
            }
        }

        /// <summary>
        /// Set the toolstrip status.
        /// </summary>
        /// <param name="text"></param>
        private void UpdateStatus(string text)
        {
            ToolStripLabelStatus.Text = text;
        }
    }
}