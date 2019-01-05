using System;
using System.Net;
using System.Windows.Forms;

namespace ps3xftp.Windows
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
            Ps3xftp.EnableButton(ButtonAddProfile, !string.IsNullOrEmpty(TextBoxConsoleName.Text) && !string.IsNullOrEmpty(TextBoxProfileIP.Text));
            Ps3xftp.EnableButton(ButtonRemoveProfile, ProfileExists(TextBoxConsoleName.Text));
        }

        private void TextBoxProfileIP_TextChanged(object sender, EventArgs e)
        {
            Ps3xftp.EnableButton(ButtonAddProfile, !string.IsNullOrEmpty(TextBoxConsoleName.Text) && !string.IsNullOrEmpty(TextBoxProfileIP.Text));
            Ps3xftp.EnableButton(ButtonRemoveProfile, ProfileExists(TextBoxConsoleName.Text));
        }

        private void ButtonAddProfile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxConsoleName.Text) || !string.IsNullOrEmpty(TextBoxProfileIP.Text))
                if (!ProfileExists(TextBoxConsoleName.Text))
                    if (IPAddress.TryParse(TextBoxProfileIP.Text, out IPAddress address))
                        Properties.Settings.Default.UserConsoles.Add(TextBoxConsoleName.Text + " : " + address.ToString());
                    else
                        MessageBox.Show("IP address is invalid.");
                else
                    MessageBox.Show("This profile already exists.");
            else
                MessageBox.Show("Profile can't contain blank credentials.");

            LoadProfiles();
        }

        private void ButtonRemoveProfile_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserConsoles.Count > 1)
                Properties.Settings.Default.UserConsoles.Remove(TextBoxConsoleName.Text + " : " + TextBoxProfileIP.Text);
            else
                MessageBox.Show("You must have one profile.");

            LoadProfiles();
        }

        private void ListBoxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListboxConsoles.SelectedIndex != -1)
            {
                string[] profileDetails = ListboxConsoles.GetItemText(ListboxConsoles.SelectedItem).Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                TextBoxConsoleName.Text = profileDetails[0];
                TextBoxProfileIP.Text = profileDetails[1];
            }
            Ps3xftp.EnableButton(ButtonAddProfile, ListboxConsoles.SelectedIndex != -1);
            Ps3xftp.EnableButton(ButtonRemoveProfile, ListboxConsoles.SelectedIndex != -1);
        }

        private bool ProfileExists(string name)
        {
            foreach (var profile in Properties.Settings.Default.UserConsoles)
            {
                string[] profileDetails = profile.Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);
                if (profileDetails[0] == name)
                    return true;
            }
            return false;
        }
    }
}