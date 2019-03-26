using System;
using System.Net;
using System.Windows.Forms;

namespace ModioX.Windows
{
    public partial class ConsolesWindow : Form
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
            ListboxConsoles.Items.Clear();
            foreach (var profile in Properties.Settings.Default.UserConsoles)
                ListboxConsoles.Items.Add(profile);
        }

        private void TextBoxProfileName_TextChanged(object sender, EventArgs e)
        {
            MainForm.EnableButton(ButtonAddProfile, !string.IsNullOrEmpty(TextBoxConsoleName.Text) && !string.IsNullOrEmpty(TextBoxProfileIP.Text));
            MainForm.EnableButton(ButtonRemoveProfile, ProfileExists(TextBoxConsoleName.Text));
        }

        private void TextBoxProfileIP_TextChanged(object sender, EventArgs e)
        {
            MainForm.EnableButton(ButtonAddProfile, !string.IsNullOrEmpty(TextBoxConsoleName.Text) && !string.IsNullOrEmpty(TextBoxProfileIP.Text));
            MainForm.EnableButton(ButtonRemoveProfile, ProfileExists(TextBoxConsoleName.Text));
        }

        private void ButtonAddProfile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxConsoleName.Text) || !string.IsNullOrEmpty(TextBoxProfileIP.Text))
                if (!ProfileExists(TextBoxConsoleName.Text))
                    if (IPAddress.TryParse(TextBoxProfileIP.Text, out var address))
                        Properties.Settings.Default.UserConsoles.Add(TextBoxConsoleName.Text + " : " + address);
                    else
                        MessageBox.Show(@"IP address is invalid.");
                else
                    MessageBox.Show(@"This profile already exists.");
            else
                MessageBox.Show(@"Profile can't contain blank credentials.");

            LoadProfiles();
        }

        private void ButtonRemoveProfile_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserConsoles.Count > 1)
                Properties.Settings.Default.UserConsoles.Remove(TextBoxConsoleName.Text + " : " + TextBoxProfileIP.Text);
            else
                MessageBox.Show(@"You must have one profile.");

            LoadProfiles();
        }

        private void ListBoxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListboxConsoles.SelectedIndex != -1)
            {
                var profileDetails = ListboxConsoles.GetItemText(ListboxConsoles.SelectedItem).Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                TextBoxConsoleName.Text = profileDetails[0];
                TextBoxProfileIP.Text = profileDetails[1];
            }
            MainForm.EnableButton(ButtonAddProfile, ListboxConsoles.SelectedIndex != -1);
            MainForm.EnableButton(ButtonRemoveProfile, ListboxConsoles.SelectedIndex != -1);
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