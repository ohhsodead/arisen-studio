using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Models.Resources;
using System;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class ConnectionDialog : DarkForm
    {
        public ConnectionDialog()
        {
            InitializeComponent();
        }

        public ConsoleProfile ConsoleProfile { get; set; }

        private void ConnectConsole_Load(object sender, EventArgs e)
        {
            LoadConsoles();
        }

        private void LoadConsoles()
        {
            ListViewConsoleProfiles.Items.Clear();

            foreach (ConsoleProfile console in MainWindow.SettingsData.ConsoleProfiles)
            {
                ListViewConsoleProfiles.Items.Add(new DarkListItem(console.ToString()));
            }

            _ = ListViewConsoleProfiles.Focus();
        }

        private void ListViewConsoleProfiles_SelectedIndicesChanged(object sender, EventArgs e)
        {
            ButtonEdit.Enabled = ListViewConsoleProfiles.SelectedIndices.Count > 0;
            ButtonDelete.Enabled = ListViewConsoleProfiles.SelectedIndices.Count > 0;
            ButtonConnect.Enabled = ListViewConsoleProfiles.SelectedIndices.Count > 0;

            if (ListViewConsoleProfiles.SelectedIndices.Count > 0)
            {
                _ = ButtonConnect.Focus();
            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            DarkListItem selectedItem = ListViewConsoleProfiles.Items[ListViewConsoleProfiles.SelectedIndices[0]];
            ConsoleProfile = MainWindow.SettingsData.ConsoleProfiles[ListViewConsoleProfiles.Items.IndexOf(selectedItem)];
            Close();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MainWindow.SettingsData.ConsoleProfiles.Count == 1)
            {
                _ = DarkMessageBox.Show(this, "You can't delete this because there must be at least one console.", "Can't Delete Console", MessageBoxIcon.Warning);
            }
            else
            {
                if (DarkMessageBox.Show(this, "Do you really want to delete the selected item?", "Delete Console", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    DarkListItem selectedItem = ListViewConsoleProfiles.Items[ListViewConsoleProfiles.SelectedIndices[0]];
                    MainWindow.SettingsData.ConsoleProfiles.RemoveAt(ListViewConsoleProfiles.Items.IndexOf(selectedItem));
                    LoadConsoles();
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            DarkListItem selectedItem = ListViewConsoleProfiles.Items[ListViewConsoleProfiles.SelectedIndices[0]];
            int selectedIndex = ListViewConsoleProfiles.Items.IndexOf(selectedItem);
            ConsoleProfile oldConsoleProfile = MainWindow.SettingsData.ConsoleProfiles[selectedIndex];

            ConsoleProfile newConsoleProfile = DialogExtensions.ShowNewConnectionWindow(this, oldConsoleProfile, true);

            if (newConsoleProfile != null)
            {
                oldConsoleProfile = newConsoleProfile;
            }

            LoadConsoles();
        }
    }
}