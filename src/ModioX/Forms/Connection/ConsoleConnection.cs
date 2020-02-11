using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Models.Resources;
using System;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Forms.Connection
{
    public partial class ConsoleConnection : DarkForm
    {
        public ConsoleConnection()
        {
            InitializeComponent();
        }

        private void ConnectConsole_Load(object sender, EventArgs e)
        {
            foreach (var console in MainForm.SettingsData.ConsoleProfiles)
            {
                ListViewConsoleProfiles.Items.Add(new DarkListItem(console.ToString()));
            }
        }

        private void ListViewConsoleProfiles_SelectedIndicesChanged(object sender, EventArgs e)
        {
            ButtonConnect.Enabled = ListViewConsoleProfiles.SelectedIndices.Count > 0;

            if (ListViewConsoleProfiles.SelectedIndices.Count > 0)
            {
                ButtonConnect.Focus();
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