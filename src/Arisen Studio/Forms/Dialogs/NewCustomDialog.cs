using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Humanizer;
using Newtonsoft.Json.Linq;
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

        public CustomItemData CustomMod { get; set; } = new();

        public bool IsEditing { get; set; } = false;

        private void NewCustomDialog_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("LABEL_MOD_DETAILS");

            LabelPlatform.Text = Language.GetString("LABEL_PLATFORM");
            LabelName.Text = Language.GetString("LABEL_NAME");
            LabelCategoryType.Text = Language.GetString("LABEL_CATEGORY_TYPE");
            LabelCategory.Text = Language.GetString("LABEL_CATEGORY");
            LabelModType.Text = Language.GetString("LABEL_MOD_TYPE");
            LabelVersion.Text = Language.GetString("LABEL_VERSION");
            LabelDescription.Text = Language.GetString("LABEL_VERSION");
            GroupInstallationFiles.Text = Language.GetString("LABEL_INSTALLATION_FILES");

            ButtonChooseFile.Text = Language.GetString("LABEL_CHOOSE_FILE");
            ButtonDeleteFile.Text = Language.GetString("LABEL_DELETE");
            ButtonDeleteAll.Text = Language.GetString("LABEL_DELETE_ALL");
            ButtonHelp.Text = Language.GetString("HELP");

            ButtonSave.Text = Language.GetString("LABEL_SAVE");
            ButtonCancel.Text = Language.GetString("LABEL_CANCEL");

            ComboBoxPlatform.SelectedIndex = ComboBoxPlatform.Properties.Items.IndexOf(CustomMod.Platform.Humanize());
            ComboBoxCategoryType.SelectedIndex = ComboBoxCategoryType.Properties.Items.IndexOf(CustomMod.CategoryType.Humanize());
            ComboBoxCategory.SelectedIndex = ComboBoxCategory.Properties.Items.IndexOf(CustomMod.Category);
            TextBoxName.Text = CustomMod.Name;
            ComboBoxModType.SelectedIndex = ComboBoxModType.Properties.Items.IndexOf(CustomMod.ModType);
            TextBoxVersion.Text = CustomMod.Version;
            //TextBoxAddress.Text = CustomItem.Address;

            TextBoxName.SelectionStart = TextBoxName.Text.Length;

            foreach (var category in MainWindow.Database.CategoriesData.Categories)
            {
                ComboBoxModType.Properties.Items.Add(category.Title);
            }

            foreach (var modTypes in MainWindow.Database.GameModsPS3.Library.Select(x => x.ModTypes))
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

        private DataTable DataTableFiles { get; set; } = DataExtensions.CreateDataTable(
            [
                new(Language.GetString("LABEL_LOCAL_FILE"), typeof(string)),
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
            CustomMod.CategoryType = ComboBoxCategoryType.SelectedItem.ToString().DehumanizeTo<CategoryType>();

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
            //else if (ComboBoxCategoryType.SelectedIndex == 4)
            //{
            //    foreach (var category in MainWindow.Database.CategoriesData.GetCategoriesByType(CategoryType.Application))
            //    {
            //        ComboBoxCategory.Properties.Items.Add(category.Title);
            //    }
            //}
            //else if (ComboBoxCategoryType.SelectedIndex == 5)
            //{
            //    foreach (var category in MainWindow.Database.CategoriesData.GetCategoriesByType(CategoryType.Plugin))
            //    {
            //        ComboBoxCategory.Properties.Items.Add(category.Title);
            //    }
            //}
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(this, "Each row contains the files that are installed on your console for the mods to work. First, browse or enter the path to the file on your computer in the first column. Next, enter the path of where you want the file to be on your console, including the file name.", Language.GetString("INSTALLATION_FILES"), MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!IsEditing)
            {
                List<int> modIds = [];

                modIds.AddRange(MainWindow.Database.GameModsPS3.Library.Select(x => x.Id));
                modIds.AddRange(MainWindow.Database.HomebrewPS3.Library.Select(x => x.Id));
                modIds.AddRange(MainWindow.Database.ResourcesPS3.Library.Select(x => x.Id));
                modIds.AddRange(MainWindow.Database.HomebrewXbox.Library.Select(x => x.Id));
                modIds.AddRange(MainWindow.Database.HomebrewPS4.Library.Select(x => x.Id));

                CustomMod.Id = Extensions.StringExtensions.GetRandomExcept(1, 10000000, modIds);
            }

            if (ComboBoxCategory.SelectedItem.ToString().Length == 0)
            {
                XtraMessageBox.Show(this, "You must choose a category.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (TextBoxName.Text.Length == 0)
            {
                XtraMessageBox.Show(this, "You must enter a name.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (ComboBoxModType.SelectedItem.ToString().Length == 0)
            {
                XtraMessageBox.Show(this, "You must choose a mod type.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (TextBoxVersion.Text.Length == 0)
            {
                XtraMessageBox.Show(this, "You must enter a version. Enter '1.0' if it doesn't have one.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (TextBoxDescription.Text.Length == 0)
            {
                CustomMod.Description = Language.GetString("NO_INPUT");
            }

            if (GridViewFiles.RowCount == 0)
            {
                XtraMessageBox.Show(this, "You must have at least one file.", "No Files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            for (int i = 0; i < GridViewFiles.RowCount; i++)
            {
                string localFilePath = (string)GridViewFiles.GetRowCellValue(i, Language.GetString("LABEL_LOCAL_FILE"));
                string installFilePath = (string)GridViewFiles.GetRowCellValue(i, Language.GetString("LABEL_INSTALL_PATH"));

                CustomMod.Files.Clear();

                CustomMod.Files.Add(new()
                {
                    Name = localFilePath,
                    Value = installFilePath
                });
            }

            DialogResult = DialogResult.OK;
        }
    }
}