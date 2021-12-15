using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using IniParser;
using IniParser.Model;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Io;
using ModioX.Properties;
using XDevkit;

namespace ModioX.Forms.Tools.XBOX
{
    public partial class PluginsEditor : XtraForm
    {
        public PluginsEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the xbox console connection.
        /// </summary>
        public static IXboxConsole XboxConsole { get; } = MainWindow.XboxConsole;

        /// <summary>
        /// Get the local launch.ini file backup directory.
        /// </summary>
        public static string LocalLaunchBackupFileDirectory { get; } = Path.Combine(UserFolders.BackupFiles, @"Launch\");

        /// <summary>
        /// Get the local launch.ini file directory.
        /// </summary>
        public static string LocalLaunchFileDirectory { get; } = Path.Combine(UserFolders.AppData, @"Launch\");

        /// <summary>
        /// Get the local launch.ini backup file path.
        /// </summary>
        public static string LocalLaunchBackupFilePath { get; } = Path.Combine(LocalLaunchBackupFileDirectory, "launch.ini");

        /// <summary>
        /// Get the local launch.ini file path.
        /// </summary>
        public static string LocalLaunchFilePath { get; } = Path.Combine(LocalLaunchFileDirectory, "launch.ini");

        /// <summary>
        /// Get the launch.ini file path located on the console internal hard drive.
        /// </summary>
        public static string ConsoleLaunchFilePath { get; } = MainWindow.Settings.LaunchIniFilePath;

        /// <summary>
        /// Get the current launch.ini file data on the console.
        /// </summary>
        public IniData LaunchFileData { get; set; }

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

                XboxConsole.ReceiveFile(LocalLaunchBackupFilePath, ConsoleLaunchFilePath);
                XboxConsole.ReceiveFile(LocalLaunchFilePath, ConsoleLaunchFilePath);

                LaunchFileData = new FileIniDataParser().ReadFile(LocalLaunchFilePath);

                ComboBoxSections.Properties.Items.Clear();

                foreach (SectionData section in LaunchFileData.Sections)
                {
                    ComboBoxSections.Properties.Items.Add(section.SectionName);
                }

                ComboBoxSections.SelectedItem = "Plugins";
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"Unable to load the launch.ini file. Error: {ex.Message}");
                XtraMessageBox.Show(this, $"Unable to load the launch.ini file. Edit the file path in Settings to your correct file location.\n\nError Message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private DataTable DataTableFileSections { get; } = DataExtensions.CreateDataTable(new List<DataColumn>
        {
            new("Key", typeof(string)),
            new("Value", typeof(string))
        });

        private void LoadLaunchFileSection(string sectionName)
        {
            DataTableFileSections.Rows.Clear();
            
            IniData launchFile = LaunchFileData;

            foreach (SectionData section in launchFile.Sections)
            {
                if (section.SectionName == sectionName)
                {
                    foreach (KeyData key in section.Keys)
                    {
                        DataTableFileSections.Rows.Add(key.KeyName, key.Value);
                    }
                }
            }

            GridLaunchFile.DataSource = DataTableFileSections;

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
            XtraMessageBox.Show(this, "Launch.ini file has been saved and uploaded to your console.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CheckBoxEnableLiveBlock_CheckedChanged(object sender, EventArgs e)
        {
            LaunchFileData["Settings"]["liveblock"] = CheckBoxEnableLiveBlock.Checked switch
            {
                true => "true",
                _ => "false"
            };
        }

        private void CheckBoxEnableLiveStrong_CheckedChanged(object sender, EventArgs e)
        {
            LaunchFileData["Settings"]["livestrong"] = CheckBoxEnableLiveStrong.Checked switch
            {
                true => "true",
                _ => "false"
            };
        }

        private void GridViewIniFile_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            switch (GridViewLaunchFile.SelectedRowsCount)
            {
                case > 0:
                    {
                        string key = GridViewLaunchFile.GetRowCellValue(e.FocusedRowHandle, GridViewLaunchFile.Columns[0])
                            .ToString();
                        string value = GridViewLaunchFile.GetRowCellValue(e.FocusedRowHandle, GridViewLaunchFile.Columns[1])
                            .ToString();

                        TextBoxKey.Text = key;
                        TextBoxValue.Text = value;
                        break;
                    }
            }
        }

        private void GridViewIniFile_RowClick(object sender, RowClickEventArgs e)
        {
            switch (GridViewLaunchFile.SelectedRowsCount)
            {
                case > 0:
                    {
                        string key = GridViewLaunchFile.GetRowCellValue(e.RowHandle, GridViewLaunchFile.Columns[0]).ToString();
                        string value = GridViewLaunchFile.GetRowCellValue(e.RowHandle, GridViewLaunchFile.Columns[1]).ToString();

                        TextBoxKey.Text = key;
                        TextBoxValue.Text = value;
                        break;
                    }
            }
        }

        private void ButtonRestoreDefault_Click(object sender, EventArgs e)
        {
            if (File.Exists(LocalLaunchBackupFilePath))
            {
                if (XtraMessageBox.Show(this, "Do you really want to restore to the default file? All edited values will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    File.WriteAllBytes("launch.ini", Encoding.UTF8.GetBytes(Resources.launch));
                    XboxConsole.SendFile("launch.ini", ConsoleLaunchFilePath);
                    LoadLaunchFileData();
                }
            }
            else
            {
                XtraMessageBox.Show(this, "You must first create a backup file to restore.", "No Backup Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonRestoreBackup_Click(object sender, EventArgs e)
        {
            if (File.Exists(LocalLaunchBackupFilePath))
            {
                if (XtraMessageBox.Show(this, "Do you really want to restore the backup file? All edited values will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    XboxConsole.SendFile(LocalLaunchBackupFilePath, ConsoleLaunchFilePath);
                    LoadLaunchFileData();
                }
            }
            else
            {
                XtraMessageBox.Show(this, "You must first create a backup file to restore.", "No Backup File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                new FileIniDataParser().WriteFile(LocalLaunchFilePath, LaunchFileData);
                XboxConsole.SendFile(LocalLaunchFilePath, ConsoleLaunchFilePath);
                XtraMessageBox.Show(this, "launch.ini file has been edited and uploaded to your console.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"Unable to save or upload launch.ini file. Error: {ex.Message}");
                XtraMessageBox.Show(this, $"There was a problem saving or uploading the launch.ini file.\n\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}