using DevExpress.XtraEditors;
using ModioX.Models.Resources;
using System;

namespace ModioX.Forms.Windows
{
    public partial class SettingsWindow : XtraForm
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }
        public static SettingsData Settings = MainWindow.Settings;
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            // Content Recognized
            Settings.AutoDetectGameRegions = CheckBoxAutoDetectGameRegions.Checked;
            Settings.AutoDetectGameTitles = CheckBoxAutoDetectGameTitles.Checked;
            Settings.RememberGameRegions = CheckBoxRememberGameRegions.Checked;

            // File Manager
            Settings.SaveLocalPath = CheckBoxSaveLocalPath.Checked;
            Settings.SaveConsolePath = CheckBoxSaveConsolePath.Checked;

            // File Size
            Settings.ShowFileSizeInBytes = CheckBoxShowFileSizeInBytes.Checked;
            Close();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            // Content Recognition
            CheckBoxAutoDetectGameRegions.Checked = Settings.AutoDetectGameRegions;
            CheckBoxAutoDetectGameTitles.Checked = Settings.AutoDetectGameTitles;
            CheckBoxRememberGameRegions.Checked = Settings.RememberGameRegions;

            // File Manager
            CheckBoxSaveLocalPath.Checked = Settings.SaveLocalPath;
            CheckBoxSaveConsolePath.Checked = Settings.SaveConsolePath;

            // File Size
            CheckBoxShowFileSizeInBytes.Checked = Settings.ShowFileSizeInBytes;
        }
    }
}