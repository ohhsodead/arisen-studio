using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using FluentFTP;
using NeoModsX.Extensions;
using NeoModsX.Forms.Windows;
using NeoModsX.Io;
using NeoModsX.Models.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace NeoModsX.Forms.Tools.PS3
{
    public partial class BootPluginsEditor : XtraForm
    {
        public BootPluginsEditor()
        {
            InitializeComponent();
        }

        public static ResourceManager Language = MainWindow.ResourceLanguage;

        public static SettingsData Settings = MainWindow.Settings;

        /// <summary>
        /// Get the PS3 console connection.
        /// </summary>
        private static FtpClient FtpClient { get; } = MainWindow.FtpClient;

        /// <summary>
        /// Get the local boot_plugins.txt file backup directory.
        /// </summary>
        public static string LocalBootPluginsFileBackupDirectory { get; } = Path.Combine(UserFolders.BackupFiles, @"Boot Plugins\");

        /// <summary>
        /// Get the local boot_plugins.txt file directory.
        /// </summary>
        public static string LocalBootPluginsFileDirectory { get; } = Path.Combine(UserFolders.AppData, @"Boot Plugins\");

        /// <summary>
        /// Get the local boot_plugins.txt backup file path.
        /// </summary>
        public static string LocalBootPluginsBackupFilePath { get; } = Path.Combine(LocalBootPluginsFileBackupDirectory, "boot_plugins.txt");

        /// <summary>
        /// Get the local boot_plugins.txt file path.
        /// </summary>
        public static string LocalBootPluginsFilePath { get; } = Path.Combine(LocalBootPluginsFileDirectory, "boot_plugins.txt");

        /// <summary>
        /// Get the boot_plugins.txt file path located on the console internal hard drive.
        /// </summary>
        public static string ConsoleBootPluginsFilePath { get; } = Settings.BootPluginsFilePath;

        private void BootPluginsEditor_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("BOOT_PLUGINS_EDITOR");

            ButtonRestoreDefault.Text = Language.GetString("LABEL_RESTORE_DEFAULT");
            ButtonRestoreBackup.Text = Language.GetString("LABEL_RESTORE_BACKUP");
            ButtonSaveUpdate.Text = Language.GetString("LABEL_SAVE_AND_UPDATE");

            LoadBootPluginsData();
        }

        private DataTable BootPlugins { get; } = DataExtensions.CreateDataTable(new List<DataColumn>
        {
            new(Language.GetString("LABEL_FILE_PATH"), typeof(string))
        });

        private void LoadBootPluginsData()
        {
            try
            {
                Directory.CreateDirectory(LocalBootPluginsFileBackupDirectory);
                Directory.CreateDirectory(LocalBootPluginsFileDirectory);

                FtpClient.DownloadFile(LocalBootPluginsFileBackupDirectory, ConsoleBootPluginsFilePath);
                FtpClient.DownloadFile(LocalBootPluginsFileDirectory, ConsoleBootPluginsFilePath);

                GridBootPlugins.DataSource = null;

                foreach (string line in File.ReadLines(LocalBootPluginsFilePath))
                {
                    BootPlugins.Rows.Add(line);
                }
                
                GridBootPlugins.DataSource = BootPlugins;

                //GridViewBootPlugins.AutoFillColumn = GridViewBootPlugins.Columns[0];
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"Unable to load the boot_plugins.txt file. Error: {ex.Message}");
                XtraMessageBox.Show(this, $"Unable to load the boot_plugins.txt file. Edit the file path in Settings to your correct file location.\n\nError Message: {ex.Message}", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void GridViewIniFile_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            
        }

        private void GridViewIniFile_RowClick(object sender, RowClickEventArgs e)
        {
            
        }

        private void ButtonRestoreDefault_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, Language.GetString("RESTORE_DEFAULT_FILE"), Language.GetString("CONFIRM"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                File.WriteAllText("boot_plugins.txt", string.Empty);
                FtpExtensions.UploadFile("boot_plugins.txt", ConsoleBootPluginsFilePath);
                LoadBootPluginsData();
            }
        }

        private void ButtonRestoreBackup_Click(object sender, EventArgs e)
        {
            if (File.Exists(LocalBootPluginsBackupFilePath))
            {
                if (XtraMessageBox.Show(this, Language.GetString("RESTORE_BACKUP_FILE"), Language.GetString("CONFIRM"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    FtpExtensions.UploadFile(LocalBootPluginsBackupFilePath, ConsoleBootPluginsFilePath);
                    LoadBootPluginsData();
                }
            }
            else
            {
                XtraMessageBox.Show(this, Language.GetString("CREATE_BACKUP_FILE"), Language.GetString("NO_BACKUP_FILE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonSaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (TextWriter textWriter = new StreamWriter(LocalBootPluginsFilePath))
                {
                    for (int i = 0; i < GridViewBootPlugins.DataRowCount; i++)
                    {
                        textWriter.WriteLine(GridViewBootPlugins.GetRowCellValue(i, GridViewBootPlugins.Columns[0]));
                    }
                }

                FtpExtensions.UploadFile(LocalBootPluginsFilePath, ConsoleBootPluginsFilePath);
                XtraMessageBox.Show(this, Language.GetString("BOOT_PLUGINS_FILE_SAVED"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"Unable to save or upload the boot_plugins.txt file. Error: {ex.Message}");
                XtraMessageBox.Show(this, string.Format(Language.GetString("FILE_SAVE_ERROR"), ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}