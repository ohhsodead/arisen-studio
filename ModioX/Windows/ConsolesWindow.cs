using System;
using System.Net;
using System.Windows.Forms;
using DarkUI.Collections;
using DarkUI.Config;
using DarkUI.Controls;
using DarkUI.Docking;
using DarkUI.Forms;
using DarkUI.Renderers;

namespace ModioX.Windows
{
    public partial class ConsolesWindow : DarkForm
    {
        public ConsolesWindow()
        {
            InitializeComponent();
        }

        private void ProfilesWindow_Load(object sender, EventArgs e)
        {
            LoadProfiles();
        }

        private void LoadProfiles()
        {
            ListViewConsoles.Items.Clear();
            foreach (var profile in Properties.Settings.Default.UserConsoles)
                ListViewConsoles.Items.Add(new DarkListItem() { Text = profile });
            ListViewConsoles.SelectedIndices.Add(0);
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            MainForm.EnableButton(ButtonConsoleAdd, !string.IsNullOrEmpty(TextBoxName.Text) && !string.IsNullOrEmpty(TextBoxAddress.Text));
            MainForm.EnableButton(ButtonConsoleRemove, ProfileExists(TextBoxName.Text));
        }

        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {
            MainForm.EnableButton(ButtonConsoleAdd, !string.IsNullOrEmpty(TextBoxName.Text) && !string.IsNullOrEmpty(TextBoxAddress.Text));
            MainForm.EnableButton(ButtonConsoleRemove, ProfileExists(TextBoxName.Text));
        }

        private void ButtonConsoleAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxName.Text) || !string.IsNullOrEmpty(TextBoxAddress.Text))
                if (!ProfileExists(TextBoxName.Text))
                    if (IPAddress.TryParse(TextBoxAddress.Text, out var address))
                        Properties.Settings.Default.UserConsoles.Add(TextBoxName.Text + " : " + address);
                    else
                        MessageBox.Show(@"IP address is invalid.");
                else
                    MessageBox.Show(@"This profile already exists.");
            else
                MessageBox.Show(@"Profile can't contain blank credentials.");

            LoadProfiles();
        }

        private void ButtonConsoleRemove_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserConsoles.Count > 1)
            {
                Properties.Settings.Default.UserConsoles.Remove(TextBoxName.Text + " : " + TextBoxAddress.Text);
                LoadProfiles();
            }
            else
                MessageBox.Show(@"You must have one profile.");
        }

        private void ListViewConsoles_SelectedIndicesChanged(object sender, EventArgs e)
        {
            if (ListViewConsoles.SelectedIndices.Count > 0)
            {
                var profileDetails = ListViewConsoles.Items[ListViewConsoles.SelectedIndices[0]].Text.Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                TextBoxName.Text = profileDetails[0];
                TextBoxAddress.Text = profileDetails[1];
            }
            MainForm.EnableButton(ButtonConsoleAdd, ListViewConsoles.SelectedIndices.Count > 0);
            MainForm.EnableButton(ButtonConsoleRemove, ListViewConsoles.SelectedIndices.Count > 0);
        }

        private static bool ProfileExists(string name)
        {
            foreach (var profile in Properties.Settings.Default.UserConsoles)
            {
                var profileDetails = profile.Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                if (profileDetails[0] == name)
                    return true;
            }
            return false;
        }
    }
}