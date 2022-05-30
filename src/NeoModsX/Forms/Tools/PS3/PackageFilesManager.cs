using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using FluentFTP;
using Humanizer;
using NeoModsX.Extensions;
using NeoModsX.Forms.Windows;
using NeoModsX.Models.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using FtpExtensions = NeoModsX.Extensions.FtpExtensions;

namespace NeoModsX.Forms.Tools.PS3
{
    public partial class PackageFilesManager : XtraForm
    {
        public PackageFilesManager()
        {
            InitializeComponent();
        }

        public static ResourceManager Language = MainWindow.ResourceLanguage;

        public static SettingsData Settings = MainWindow.Settings;

        private static FtpClient FtpClient { get; } = MainWindow.FtpClient;

        private static string PackageFilesPath { get; } = MainWindow.Settings.PackageInstallPath;

        private List<FtpListItem> PackageFiles { get; } = new();

        private void PackageFilesManager_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("PACKAGE_FILES_MANAGER");

            ButtonInstallFile.Text = Language.GetString("LABEL_INSTALL_FILE");
            ButtonDownloadFile.Text = Language.GetString("LABEL_DOWNLOAD_FILE");
            ButtonDelete.Text = Language.GetString("LABEL_DELETE");
            ButtonDeleteAll.Text = Language.GetString("LABEL_DELETE_ALL");
        }

        private void TimerWait_Tick(object sender, EventArgs e)
        {
            LoadPackages();
            TimerWait.Enabled = false;
        }

        private void LoadPackages()
        {
            try
            {
                GridPackageFiles.DataSource = null;

                DataTable packages = DataExtensions.CreateDataTable(new List<DataColumn>
            {
                new(Language.GetString("LABEL_FILE_NAME"), typeof(string)),
                new(Language.GetString("LABEL_MODIFIED_DATE"), typeof(string)),
                new(Language.GetString("LABEL_FILE_SIZE"), typeof(string))
            });

                FtpClient.SetWorkingDirectory(PackageFilesPath);

                foreach (FtpListItem listItem in FtpClient.GetListing(PackageFilesPath))
                {
                    switch (listItem.Type)
                    {
                        case FtpFileSystemObjectType.File when listItem.Name.EndsWithIgnoreCase(".pkg"):
                            PackageFiles.Add(listItem);
                            break;

                        case FtpFileSystemObjectType.Directory:
                            break;

                        case FtpFileSystemObjectType.Link:
                            break;
                    }
                }

                foreach (FtpListItem package in PackageFiles)
                {
                    packages.Rows.Add(package.Name,
                                      MainWindow.Settings.UseRelativeTimes ? package.Modified.Humanize() : package.Modified.ToString("MM/dd/yyyy", CultureInfo.CurrentCulture),
                                      MainWindow.Settings.UseFormattedFileSizes ? package.Size.Bytes().Humanize("#") : package.Size + " " + Language.GetString("LABEL_BYTES"));
                }

                GridPackageFiles.DataSource = packages;

                //GridViewPackageFiles.Columns[0].Width = 350;
                GridViewPackageFiles.Columns[1].Width = 70;
                GridViewPackageFiles.Columns[2].Width = 70;

                ButtonDeleteAll.Enabled = packages.Rows.Count > 0;

                UpdateStatus(Language.GetString("FETCHED_LISTING"));
            }
            catch (Exception ex)
            {
                TimerWait.Enabled = false;

                ButtonInstallFile.Enabled = false;
                ButtonDownloadFile.Enabled = false;
                ButtonDelete.Enabled = false;
                ButtonDeleteAll.Enabled = false;

                UpdateStatus(string.Format(Language.GetString("FETCHING_LISTING_ERROR"), PackageFilesPath, ex.Message), ex);
                XtraMessageBox.Show(string.Format(Language.GetString("FETCHING_LISTING_ERROR"), PackageFilesPath, ex.Message));
                Close();
            }
        }

        private void GridViewPackageFiles_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ButtonDelete.Enabled = GridViewPackageFiles.SelectedRowsCount > 0;
            ButtonDownloadFile.Enabled = GridViewPackageFiles.SelectedRowsCount > 0;
        }

        private void GridViewPackageFiles_RowClick(object sender, RowClickEventArgs e)
        {
            ButtonDelete.Enabled = GridViewPackageFiles.SelectedRowsCount > 0;
            ButtonDownloadFile.Enabled = GridViewPackageFiles.SelectedRowsCount > 0;
        }

        private void ButtonInstallPackageFile_Click(object sender, EventArgs e)
        {
            string localFilePath = DialogExtensions.ShowOpenFileDialog(this, "Package File", "PKG Files (*.pkg)|*.pkg");

            switch (string.IsNullOrWhiteSpace(localFilePath))
            {
                case false:
                    {
                        string fileName = Path.GetFileName(localFilePath);
                        string installFilePath = PackageFilesPath + "/" + fileName;

                        if (FtpClient.FileExists(installFilePath))
                        {
                            XtraMessageBox.Show("Package file with this name already exists on your console.", "Package File Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        UpdateStatus(string.Format(Language.GetString("FILE_INSTALLING"), fileName));
                        FtpExtensions.UploadFile(localFilePath, installFilePath);
                        UpdateStatus("Successfully installed file.");
                        LoadPackages();
                        break;
                    }
            }
        }

        private void ButtonDeletePackageFile_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete the selected package file from your console?", Language.GetString("CONFIRM_DELETE"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string packageFileName = GridViewPackageFiles.GetRowCellValue(GridViewPackageFiles.FocusedRowHandle, GridViewPackageFiles.Columns[0]).ToString();

                UpdateStatus($"Deleting file: {packageFileName}");
                FtpExtensions.DeleteFile(PackageFilesPath + "/" + packageFileName);
                UpdateStatus("Successfully deleted file.");
                LoadPackages();
            }
        }

        private void ButtonDeleteAllPackageFiles_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete all of your package files from your console?", Language.GetString("CONFIRM_DELETE_ALL"), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                foreach (FtpListItem package in PackageFiles)
                {
                    UpdateStatus($"Deleting file: {package.Name}");
                    FtpExtensions.DeleteFile(PackageFilesPath + "/" + package.Name);
                    UpdateStatus("Successfully package file.");
                    LoadPackages();
                }
            }
        }

        private void ButtonDownloadPackageFile_Click(object sender, EventArgs e)
        {
            string packageFile = PackageFilesPath + "/" + GridViewPackageFiles.GetRowCellValue(GridViewPackageFiles.FocusedRowHandle, GridViewPackageFiles.Columns[0]);
            string fileName = Path.GetFileName(packageFile);
            string folderPath = IoExtensions.GetFullPath(Settings.PathBaseDirectory, Settings.PathDownloads);

            switch (string.IsNullOrWhiteSpace(folderPath))
            {
                case false:
                    UpdateStatus("Downloading file: " + fileName);
                    FtpClient.DownloadFile(Path.Combine(folderPath, fileName), packageFile);
                    UpdateStatus("Successfully downloaded file.");
                    break;
            }
        }

        /// <summary>
        /// Set the current status.
        /// </summary>
        /// <param name="text"> </param>
        private void UpdateStatus(string text, Exception ex = null)
        {
            LabelStatus.Caption = text;
            Refresh();

            if (ex == null)
            {
                Program.Log.Info(text);
            }
            else
            {
                Program.Log.Error(ex, text);
            }
        }
    }
}