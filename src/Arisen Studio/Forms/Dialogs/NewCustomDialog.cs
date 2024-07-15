using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Resources;
using System.Windows.Forms;

namespace ArisenStudio.Forms.Dialogs
{
    public partial class NewCustomDialog : XtraForm
    {
        public NewCustomDialog()
        {
            InitializeComponent();
        }

        public static ResourceManager Language = MainWindow.ResourceLanguage;

        public CustomMod CustomMod { get; set; } = new();

        public bool IsEditing { get; set; } = false;

        private void NewCustomDialog_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("LABEL_CONNECTION_DETAILS");

            //LabelName.Text = Language.GetString("LABEL_CONNECTION_NAME") + ":";
            //LabelPlatform.Text = Language.GetString("LABEL_PLATFORM_TYPE") + ":";
            //LabelCategoryType.Text = Language.GetString("LABEL_IP_ADDRESS") + ":";
            //LabelLogin.Text = Language.GetString("LABEL_LOGIN") + ":";

            //ButtonChangeLoginDetails.Text = Language.GetString("LABEL_CHANGE");
            //ButtonOK.Text = Language.GetString("LABEL_OK");
            //ButtonCancel.Text = Language.GetString("LABEL_CANCEL");

            ComboBoxPlatform.SelectedIndex = ComboBoxPlatform.Properties.Items.IndexOf(CustomMod.Platform.Humanize());

            TextBoxName.Text = CustomMod.Name;
            //TextBoxAddress.Text = CustomItem.Address;

            TextBoxName.SelectionStart = TextBoxName.Text.Length;

            foreach (var category in MainWindow.Database.CategoriesData.Categories)
            {
                ComboBoxModType.Properties.Items.Add(category.Title);
            }

            foreach (var modTypes in MainWindow.Database.GameModsPs3.Mods.Select(x => x.ModTypes))
            {
                ComboBoxModType.Properties.Items.AddRange(modTypes.ToList());
            }

            //LabelUserPass.Visible = CustomItem.Platform == Platform.PS3 | CustomItem.Platform == Platform.PS4;
            //ButtonChangeLoginDetails.Visible = CustomItem.Platform == Platform.PS3 | CustomItem.Platform == Platform.PS4;

            //CheckBoxUseDefaultConsole.Visible = CustomItem.Platform == Platform.XBOX360;
            //CheckBoxUseDefaultConsole.CheckState = CustomItem.UseDefaultConsole ? CheckState.Checked : CheckState.Unchecked;
            //CheckBoxUseDefaultConsole.Checked = CustomItem.UseDefaultConsole;

            LoadFiles();
        }

        private DataTable DataTableFiles { get; } = DataExtensions.CreateDataTable(
            [
                new(Language.GetString("LABEL_LOCAL_PATH"), typeof(string)),
                new(Language.GetString("LABEL_INSTALL_PATH"), typeof(string)),
            ]);

        private void LoadFiles()
        {
            DataTableFiles.Rows.Clear();

            foreach (ListItem file in CustomMod.Files)
            {
                DataTableFiles.Rows.Add(
                    file.Name,
                    file.Value);
            }

            GridControlFiles.DataSource = DataTableFiles;
        }

        private void ComboBoxCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxCategory.Properties.Items.Clear();

            if (ComboBoxCategoryType.SelectedIndex == 0)
            {
                foreach (var category in MainWindow.Database.CategoriesData.GetCategoriesByType(CategoryType.Game))
                {
                    ComboBoxCategory.Properties.Items.Add(category.Title);
                }
            }
            else if (ComboBoxCategoryType.SelectedIndex == 1)
            {
                foreach (var category in MainWindow.Database.CategoriesData.GetCategoriesByType(CategoryType.Homebrew))
                {
                    ComboBoxCategory.Properties.Items.Add(category.Title);
                }
            }
            else if (ComboBoxCategoryType.SelectedIndex == 2)
            {
                foreach (var category in MainWindow.Database.CategoriesData.GetCategoriesByType(CategoryType.Package))
                {
                    ComboBoxCategory.Properties.Items.Add(category.Title);
                }
            }
            else if (ComboBoxCategoryType.SelectedIndex == 3)
            {
                foreach (var category in MainWindow.Database.CategoriesData.GetCategoriesByType(CategoryType.Resource))
                {
                    ComboBoxCategory.Properties.Items.Add(category.Title);
                }
            }
            else if (ComboBoxCategoryType.SelectedIndex == 4)
            {
                foreach (var category in MainWindow.Database.CategoriesData.GetCategoriesByType(CategoryType.Application))
                {
                    ComboBoxCategory.Properties.Items.Add(category.Title);
                }
            }
            else if (ComboBoxCategoryType.SelectedIndex == 5)
            {
                foreach (var category in MainWindow.Database.CategoriesData.GetCategoriesByType(CategoryType.Plugin))
                {
                    ComboBoxCategory.Properties.Items.Add(category.Title);
                }
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (!IsEditing)
            {
                List<int> modIds = [];

                modIds.AddRange(MainWindow.Database.GameModsPs3.Mods.Select(x => x.Id));
                modIds.AddRange(MainWindow.Database.HomebrewPs3.Mods.Select(x => x.Id));
                modIds.AddRange(MainWindow.Database.ResourcesPs3.Mods.Select(x => x.Id));
                modIds.AddRange(MainWindow.Database.PluginsXbox.Mods.Select(x => x.Id));
                modIds.AddRange(MainWindow.Database.AppsPs4.Mods.Select(x => x.Id));

                CustomMod.ModId = Extensions.StringExtensions.GetRandomExcept(1, 10000000, modIds);
            }
            
            DialogResult = DialogResult.OK;
        }
    }
}