using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Models.Resources;
using System;
using System.Net;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class EditConsoleProfiles : DarkForm
    {
        public EditConsoleProfiles()
        {
            InitializeComponent();
        }

        private void ConsolesWindow_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            ListViewConsoles.Items.Clear();

            foreach (ConsoleProfile profile in MainForm.SettingsData.ConsoleProfiles)
            {
                ListViewConsoles.Items.Add(new DarkListItem() { Text = string.Format("{0} - {1}", profile.Name, profile.Address) });
            }
        }

        private static bool ProfileExists(string name)
        {
            foreach (ConsoleProfile console in MainForm.SettingsData.ConsoleProfiles)
            {
                if (console.Name.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }

        private void ButtonAddProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxName.Text) || string.IsNullOrEmpty(TextBoxAddress.Text))
            {
                _ = DarkMessageBox.Show(this, @"You haven't provided a profile name or address for this profile. This can't be empty or blank.", "No Profile Name", MessageBoxIcon.Error);
                return;
            }

            if (ProfileExists(TextBoxName.Text))
            {
                _ = DarkMessageBox.Show(this, @" You already have a profile with the same name.", "Profile Name Exists", MessageBoxIcon.Error);
                return;
            }

            if (IPAddress.TryParse(TextBoxAddress.Text, out IPAddress address))
            {
                MainForm.SettingsData.ConsoleProfiles.Add(new ConsoleProfile(TextBoxName.Text, address.ToString()));
                UpdateUI();
            }
            else
            {
                _ = DarkMessageBox.Show(this, @"You haven't provided an valid IP address, it maybe not in the correct format. Make sure you've copied exactly from the console system information screen, or displayed on the bottom-right corner of the xmb screen.", "Invalid Profile Address", MessageBoxIcon.Error);
            }
        }

        private void ListViewConsoles_SelectedIndicesChanged(object sender, EventArgs e)
        {
            ButtonRemoveProfile.Enabled = ListViewConsoles.SelectedIndices.Count > 0;
        }

        private void ButtonRemoveProfile_Click(object sender, EventArgs e)
        {
            if (MainForm.SettingsData.ConsoleProfiles.Count > 1)
            {
                DarkListItem selectedItem = ListViewConsoles.Items[ListViewConsoles.SelectedIndices[0]];
                MainForm.SettingsData.ConsoleProfiles.RemoveAt(ListViewConsoles.Items.IndexOf(selectedItem));
                UpdateUI();
            }
            else
            {
                _ = DarkMessageBox.Show(this, @"You must have at least one console saved.", "Error", MessageBoxIcon.Error);
            }
        }
    }
}