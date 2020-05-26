using DarkUI.Controls;
using DarkUI.Forms;
using ModioX.Extensions;
using ModioX.Models.Resources;
using System;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Forms
{
    public partial class RequestMods : DarkForm
    {
        public RequestMods()
        {
            InitializeComponent();
        }

        private void RequestMods_Load(object sender, EventArgs e)
        {
            foreach (var category in MainForm.Categories.Categories)
            {
                ComboBoxCategoryTitle.Items.Add(category.Title);
            }
        }

        private void ComboBoxCategoryTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCategoryTitle.SelectedIndex != -1)
            {
                string categoryTitle = ComboBoxCategoryTitle.GetItemText(ComboBoxCategoryTitle.SelectedItem);

                TextBoxGameRegions.Enabled = MainForm.Categories.GetCategoryByTitle(categoryTitle).CategoryType == Models.Database.CategoryType.Game;
            }
        }

        private void ButtonRequestMods_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                DarkMessageBox.Show(this, "You haven't included a useful mod name.", "No Name", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxType.Text))
            {
                DarkMessageBox.Show(this, "You haven't included a mod type.", "No Type", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxAuthor.Text))
            {
                DarkMessageBox.Show(this, "You haven't included the mod's author/creator.", "No Author", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                DarkMessageBox.Show(this, "You haven't included a description. Please enter any information you know about the mods.", "No Description", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(TextBoxLinks.Text))
            {
                DarkMessageBox.Show(this, "You haven't included any links, this will help to find the mods so they can be added.", "No Links", MessageBoxIcon.Exclamation);
                return;
            }

            _ = DarkMessageBox.Show(this, "You will be directed to the GitHub Issue Tracking page for ModioX. All the information you have provided will be auto-filled in a new issue. Create or login with your GitHub account and use the 'Submit' button to open a new mod request. It will be added as soon as we're able to find it.", "Directing to GitHub", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Utilities.OpenRequestTemplate(TextBoxName.Text, TextBoxType.Text, ComboBoxCategoryTitle.GetItemText(ComboBoxCategoryTitle.SelectedItem), TextBoxAuthor.Text, TextBoxVersion.Text, TextBoxDescription.Text, TextBoxLinks.Text);
            Close();
        }
    }
}