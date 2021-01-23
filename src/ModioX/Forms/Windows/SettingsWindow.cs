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

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            switch (Settings.LoadConsoleMods)
            {
                case ConsoleTypePrefix.PS3:
                    RadioConsoles.SelectedIndex = 0;
                    break;
                case ConsoleTypePrefix.XBOX:
                    RadioConsoles.SelectedIndex = 1;
                    break;
                default:
                    break;
            }

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

        private void ButtonSaveSettings_Click(object sender, EventArgs e)
        {
            // Database
            switch (RadioConsoles.SelectedIndex)
            {
                case 0:
                    Settings.LoadConsoleMods = ConsoleTypePrefix.PS3;
                    break;
                case 1:
                    Settings.LoadConsoleMods = ConsoleTypePrefix.XBOX;
                    break;
                default:
                    break;
            }

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
    }
}