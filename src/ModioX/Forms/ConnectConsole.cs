using DarkUI.Controls;
using DarkUI.Forms;
using System;

namespace ModioX.Forms
{
    public partial class ConnectConsole : DarkForm
    {
        public ConnectConsole()
        {
            InitializeComponent();
        }

        private void ConnectConsole_Load(object sender, EventArgs e)
        {
            foreach (Models.Resources.ConsoleProfile console in MainForm.SettingsData.ConsoleProfiles)
            {
                ListViewConsoleProfiles.Items.Add(new DarkListItem(console.ToString()));
            }
        }

        private void ListViewConsoleProfiles_SelectedIndicesChanged(object sender, EventArgs e)
        {
            ButtonConnect.Enabled = ListViewConsoleProfiles.SelectedIndices.Count > 0;

            if (ListViewConsoleProfiles.SelectedIndices.Count > 0)
            {
                _ = ButtonConnect.Focus();
            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            DarkListItem selectedItem = ListViewConsoleProfiles.Items[ListViewConsoleProfiles.SelectedIndices[0]];
            MainForm.ConsoleProfile = MainForm.SettingsData.ConsoleProfiles[ListViewConsoleProfiles.Items.IndexOf(selectedItem)];
            MainForm.mainForm.ConnectConsole();
            Close();
        }

    }
}