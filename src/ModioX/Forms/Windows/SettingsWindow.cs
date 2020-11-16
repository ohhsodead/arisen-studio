using System;
using System.Windows.Forms;
using DarkUI.Forms;

namespace ModioX.Forms.Windows
{
    public partial class SettingsWindow : DarkForm
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private readonly Models.Resources.SettingsData Settings = MainWindow.Settings;

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            // Content Recognition
            CheckBoxAutoDetectGameRegions.Checked = Settings.AutoDetectGameRegions;
            CheckBoxAutoDetectGameTitles.Checked = Settings.AutoDetectGameTitles;
            CheckBoxRememberGameRegions.Checked = Settings.RememberGameRegions;

            // File Manager
            CheckBoxSaveLocalPath.Checked = Settings.SaveLocalPath;
            CheckBoxSaveConsolePath.Checked = Settings.SaveConsolePath;
        }

        private void Dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Removes dotted borders from the cells on focus
            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Focus);
            e.Handled = true;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            // Content Recognized
            Settings.AutoDetectGameRegions = CheckBoxAutoDetectGameRegions.Checked;
            Settings.AutoDetectGameTitles = CheckBoxAutoDetectGameTitles.Checked;
            Settings.RememberGameRegions = CheckBoxRememberGameRegions.Checked;

            // File Manager
            Settings.SaveLocalPath = CheckBoxSaveLocalPath.Checked;
            Settings.SaveConsolePath = CheckBoxSaveConsolePath.Checked;
        }
    }
}