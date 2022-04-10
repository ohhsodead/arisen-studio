using DevExpress.XtraEditors;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace ModioX.Forms.Dialogs.Importing
{
    public partial class ImportNewDialog : XtraForm
    {
        public ImportNewDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        public bool IsEditing { get; set; } = false;

        public ImportedMod ImportedMod { get; set; } = new();

        private void ImportModsDialog_Load(object sender, EventArgs e)
        {
            if (ImportedMod == null)
            {
                ImportedMod = new();
            }

            ComboBoxPlatform.SelectedIndex = 0;
        }

        private void ComboBoxPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPlatform.SelectedIndex == 0)
            {
                ImportedMod.Platform = Platform.PS3;
                ComboBoxSystemType.Enabled = true;
            }
            else
            {
                ImportedMod.Platform = Platform.XBOX360;
                ComboBoxSystemType.Enabled = false;
            }

            LoadCategories();
        }
        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadCategories()
        {
            if (ImportedMod.Platform == Platform.PS3)
            {
                foreach (Category category in MainWindow.Database.CategoriesData.Categories.FindAll(x => CategoryType.Game == x.CategoryType).OrderBy(x => x.Title))
                {
                    ComboBoxCategory.Properties.Items.Add(category.Title);
                    ComboBoxCategory.Enabled = true;
                }
            }
            else
            {
                ComboBoxCategory.Enabled = false;
            }
        }

        DataTable TableFiles = DataExtensions.CreateDataTable(new List<DataColumn>
            {
                new("Local File Path", typeof(string)),
                new("Install File Path", typeof(string))
            });

        private void LoadFiles()
        {
            GridFiles.DataSource = null;
            TableFiles.Rows.Clear();

            foreach (InstallItem installItem in ImportedMod.Files)
            {
                TableFiles.Rows.Add(installItem.LocalFilePath, installItem.InstallFilePath);
            }

            GridFiles.DataSource = TableFiles;

            //GridViewFiles.Columns[0].Width = 150;
            //GridViewFiles.Columns[1].Width = 150;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (TextBoxModName.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include the mod name.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (ComboBoxCategory.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include the game title or category.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TextBoxDescription.Text.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(this, "You must include some description, such as useful details, what is it or how it works.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            XtraMessageBox.Show(this,
                "Thanks for your contribution! GitHub Issues tracker page will now open and all the information will be auto-filled for you. You must create or login with your GitHub account and click the 'Submit' button to open a request.",
                "Opening GitHub Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void ButtonAddFile_Click(object sender, EventArgs e)
        {
            Platform platform = ComboBoxPlatform.SelectedIndex == 0 ? Platform.PS3 : Platform.XBOX360;
            string localFilePath = DialogExtensions.ShowOpenFileDialog(this, "Choose Install File", "All files (*.*)|*.*");
            string installFilePath = DialogExtensions.ShowTextInputDialog(this, "Install Location", "File Location:", platform == Platform.PS3 ? @"/dev_hdd0/game/{REGION}/USRDIR/file_name_here.txt" : @"Hdd:\ModioX\file_name_here.txt");

            InstallItem installItem = DialogExtensions.ShowImportNewFileDialog(this, new InstallItem());

            switch (string.IsNullOrWhiteSpace(localFilePath))
            {
                case false:
                    {
                        if (platform == Platform.PS3)
                        {
                            if (installFilePath.StartsWith(@"/dev_hdd0/"))
                            {
                                ImportedMod.Files.Add(new() { LocalFilePath = localFilePath, InstallFilePath = installFilePath });
                                LoadFiles();
                            }
                            else
                            {
                                XtraMessageBox.Show(this, "Install file location must follow this pattern: " + @"/dev_hdd0/game/{REGION}/USRDIR/file_name_here.ext", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else if (platform == Platform.XBOX360)
                        {
                            if (installFilePath.StartsWith(@"Hdd:\"))
                            {
                                ImportedMod.Files.Add(new() { LocalFilePath = localFilePath, InstallFilePath = installFilePath });
                                LoadFiles();
                            }
                            else
                            {
                                XtraMessageBox.Show(this, "Install file location must follow this pattern: " + @"Hdd:\file_name_here.txt", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show(this, "You must include some description, such as useful details, what is it or how it works.", Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        break;
                    }
            }
        }
    }
}