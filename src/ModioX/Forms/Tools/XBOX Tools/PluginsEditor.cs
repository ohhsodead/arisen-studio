using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using FluentFTP;
using IniParser;
using IniParser.Model;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Io;
using ModioX.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using XDevkit;
using FtpExtensions = ModioX.Extensions.FtpExtensions;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    public partial class PluginsEditor : XtraForm
    {
        /// <summary>
        /// Get the xbox console connection.
        /// </summary>
        public static Xbox XboxConsole { get; } = MainWindow.XboxConsole;

        /// <summary>
        /// Get the PS3/XBOX FTP connection.
        /// </summary>
        public static FtpConnection FtpConnection { get; } = MainWindow.FtpConnection;

        /// <summary>
        /// Get the PS3/XBOX FTP client.
        /// </summary>
        public static FtpClient FtpClient { get; } = MainWindow.FtpClient;

        /// <summary>
        /// Get the local launch.ini file backup directory.
        /// </summary>
        public static string LocalLaunchBackupFileDirectory { get; } = Path.Combine(UserFolders.AppBackupFilesDirectory, @"Launch\");

        /// <summary>
        /// Get the local launch.ini file directory.
        /// </summary>
        public static string LocalLaunchFileDirectory { get; } = Path.Combine(UserFolders.AppDataDirectory, @"Launch\");

        /// <summary>
        /// Get the local launch.ini backup file path.
        /// </summary>
        public static string LocalLaunchBackupFilePath { get; } = Path.Combine(LocalLaunchBackupFileDirectory, "launch.ini");

        /// <summary>
        /// Get the local launch.ini file path.
        /// </summary>
        public static string LocalLaunchFilePath { get; } = Path.Combine(LocalLaunchFileDirectory, "launch.ini");

        /// <summary>
        /// Get the launch.ini directory path located on the console internal hard drive.
        /// </summary>
        public readonly string ConsoleLaunchFileDirectory = "/Hdd1";

        /// <summary>
        /// Get the launch.ini file path located on the console internal hard drive.
        /// </summary>
        public readonly string ConsoleLaunchFilePath = MainWindow.Settings.LaunchIniFilePath;

        /// <summary>
        /// Get the current launch.ini file data on the console.
        /// </summary>
        public IniData LaunchFileData { get; set; }

        public PluginsEditor()
        {
            InitializeComponent();
        }

        private void PluginsEditor_Load(object sender, EventArgs e)
        {
            LoadLaunchFileData();
        }

        private void LoadLaunchFileData()
        {
            try
            {
                Directory.CreateDirectory(LocalLaunchBackupFileDirectory);
                Directory.CreateDirectory(LocalLaunchFileDirectory);

                FtpExtensions.DownloadFile(LocalLaunchBackupFilePath, ConsoleLaunchFilePath);
                FtpExtensions.DownloadFile(LocalLaunchFilePath, ConsoleLaunchFilePath);

                LaunchFileData = new FileIniDataParser().ReadFile(LocalLaunchFilePath);

                ComboBoxSections.Properties.Items.Clear();

                foreach (SectionData section in LaunchFileData.Sections)
                {
                    ComboBoxSections.Properties.Items.Add(section.SectionName);
                }

                ComboBoxSections.SelectedItem = "Plugins";
            }
            catch (Net.FtpException ex)
            {
                Program.Log.Error(ex, $"There was a problem loading the launch.ini file. Error: {ex.Message}");
                XtraMessageBox.Show($"There was a problem loading the launch.ini file.\n\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"There was a problem loading the launch.ini file. Error: {ex.Message}");
                XtraMessageBox.Show($"There was a problem loading the launch.ini file.\n\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void LoadLaunchFileSection(string sectionName)
        {
            GridLaunchFile.DataSource = null;

            DataTable launchFileSections = DataExtensions.CreateDataTable(new List<DataColumn>()
            {
                new DataColumn("Key", typeof(string)),
                new DataColumn("Value", typeof(string)),
            });

            IniData launchFile = LaunchFileData;

            foreach (SectionData section in launchFile.Sections)
            {
                if (section.SectionName == sectionName)
                {
                    foreach (KeyData key in section.Keys)
                    {
                        launchFileSections.Rows.Add(key.KeyName, key.Value);
                    }
                }                
            }

            GridLaunchFile.DataSource = launchFileSections;

            GridViewLaunchFile.Columns[0].Width = 150;
            GridViewLaunchFile.Columns[1].Width = 258;
        }

        private void ComboBoxSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSections.SelectedIndex != -1)
            {
                LoadLaunchFileSection(ComboBoxSections.SelectedItem.ToString());
            }
        }

        private void ButtonSetValue_Click(object sender, EventArgs e)
        {
            string section = ComboBoxSections.SelectedItem.ToString();
            string key = TextBoxKey.Text;
            string value = TextBoxValue.Text;

            LaunchFileData[section][key] = value;

            LoadLaunchFileData();
            XtraMessageBox.Show("Launch.ini file has been saved and uploaded to your console.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CheckBoxEnableLiveBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxEnableLiveBlock.Checked)
            {
                LaunchFileData["Settings"]["liveblock"] = "true";
            }
            else
            {
                LaunchFileData["Settings"]["liveblock"] = "false";
            }
        }

        private void CheckBoxEnableLiveStrong_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxEnableLiveStrong.Checked)
            {
                LaunchFileData["Settings"]["livestrong"] = "true";
            }
            else
            {
                LaunchFileData["Settings"]["livestrong"] = "false";
            }
        }

        private void GridViewIniFile_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (GridViewLaunchFile.SelectedRowsCount > 0)
            {
                string key = GridViewLaunchFile.GetRowCellValue(e.FocusedRowHandle, GridViewLaunchFile.Columns[0]).ToString();
                string value = GridViewLaunchFile.GetRowCellValue(e.FocusedRowHandle, GridViewLaunchFile.Columns[1]).ToString();

                TextBoxKey.Text = key;
                TextBoxValue.Text = value;
            }
        }

        private void GridViewIniFile_RowClick(object sender, RowClickEventArgs e)
        {
            if (GridViewLaunchFile.SelectedRowsCount > 0)
            {
                string key = GridViewLaunchFile.GetRowCellValue(e.RowHandle, GridViewLaunchFile.Columns[0]).ToString();
                string value = GridViewLaunchFile.GetRowCellValue(e.RowHandle, GridViewLaunchFile.Columns[1]).ToString();

                TextBoxKey.Text = key;
                TextBoxValue.Text = value;
            }
        }

        private void ButtonRestoreLaunchFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(LocalLaunchBackupFilePath))
            {
                if (XtraMessageBox.Show("Do you really want to restore your backup file, all edited values will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    new FileIniDataParser().WriteFile(LocalLaunchBackupFilePath, LaunchFileData);
                    FtpExtensions.UploadFile(LocalLaunchBackupFilePath, ConsoleLaunchFilePath);
                    LoadLaunchFileData();
                }
            }
            else
            {
                XtraMessageBox.Show("You must first create a backup file to restore.", "No File Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                new FileIniDataParser().WriteFile(LocalLaunchFilePath, LaunchFileData);
                FtpExtensions.UploadFile(LocalLaunchFilePath, ConsoleLaunchFilePath);
                XtraMessageBox.Show("Launch.ini file has been saved and uploaded to your console.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("There was a problem saving or uploading the launch.ini file to your console.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}