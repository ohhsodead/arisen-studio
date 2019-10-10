using DarkUI.Controls;
using DarkUI.Forms;
using System;
using System.Net;

namespace ModioX.Windows
{
    public partial class ProfilesForm : DarkForm
    {
        public ProfilesForm()
        {
            InitializeComponent();
        }

        private void ConsolesWindow_Load(object sender, EventArgs e)
        {
            LoadConsoles();
        }

        private void LoadConsoles()
        {
            ListViewConsoles.Items.Clear();

            foreach (string profile in MainForm.SettingsData.ConsoleProfiles)
            {
                ListViewConsoles.Items.Add(new DarkListItem() { Text = profile });
            }

            ListViewConsoles.SelectedIndices.Add(0);
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            ButtonConsoleAdd.Enabled = !string.IsNullOrEmpty(TextBoxName.Text) && !string.IsNullOrEmpty(TextBoxAddress.Text);
            ButtonConsoleRemove.Enabled = ConsoleExists(TextBoxName.Text);
        }

        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {
            ButtonConsoleAdd.Enabled = !string.IsNullOrEmpty(TextBoxName.Text) && !string.IsNullOrEmpty(TextBoxAddress.Text);
            ButtonConsoleRemove.Enabled = ConsoleExists(TextBoxName.Text);
        }

        private void ButtonConsoleAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxName.Text) || !string.IsNullOrEmpty(TextBoxAddress.Text))
            {
                if (!ConsoleExists(TextBoxName.Text))
                {
                    if (IPAddress.TryParse(TextBoxAddress.Text, out var address))
                    {
                        MainForm.SettingsData.ConsoleProfiles.Add(TextBoxName.Text + " : " + address);
                    }
                    else
                    {
                        DarkMessageBox.Show(this, @"IP address provided is invalid. Make sure you copied exactly from the console information.", "Error");
                    }
                }
                else
                {
                    DarkMessageBox.Show(this, @"A console with this address already exists.", "Error");
                }
            }
            else
            {
                DarkMessageBox.Show(this, @"Console name and address cannot be blank or empty.", "Error");
            }

            LoadConsoles();
        }

        private void ButtonConsoleRemove_Click(object sender, EventArgs e)
        {
            if (MainForm.SettingsData.ConsoleProfiles.Count > 1)
            {
                MainForm.SettingsData.ConsoleProfiles.Remove(TextBoxName.Text + " : " + TextBoxAddress.Text);
                LoadConsoles();
            }
            else
            {
                DarkMessageBox.Show(this, @"You must have at least one console saved.", "Error");
            }
        }

        private void ListViewConsoles_SelectedIndicesChanged(object sender, EventArgs e)
        {
            if (ListViewConsoles.SelectedIndices.Count > 0)
            {
                var profileDetails = ListViewConsoles.Items[ListViewConsoles.SelectedIndices[0]].Text.Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                TextBoxName.Text = profileDetails[0];
                TextBoxAddress.Text = profileDetails[1];
            }

            ButtonConsoleAdd.Enabled = ListViewConsoles.SelectedIndices.Count > 0;
            ButtonConsoleRemove.Enabled = ListViewConsoles.SelectedIndices.Count > 0;
        }

        private static bool ConsoleExists(string name)
        {
            foreach (var profile in MainForm.SettingsData.ConsoleProfiles)
            {
                string[] profileDetails = profile.Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries);

                if (profileDetails[0] == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}