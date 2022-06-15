using DevExpress.XtraEditors;
using Humanizer;
using ArisenMods.Database;
using ArisenMods.Extensions;
using ArisenMods.Forms.Windows;
using ArisenMods.Models.Database;
using ArisenMods.Models.Resources;
using System;
using System.Resources;
using System.Windows.Forms;

namespace ArisenMods.Forms.Dialogs.Details
{
    public partial class PackageDialog : XtraForm
    {
        public PackageDialog()
        {
            InitializeComponent();
        }

        public static SettingsData Settings = MainWindow.Settings;
        public static ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public static ResourceManager Language = MainWindow.ResourceLanguage;
        public static CategoriesData Categories = MainWindow.Database.CategoriesData;

        public PackageItemData PackageItem;

        private void PackageDialog_Load(object sender, EventArgs e)
        {
            StatModifiedDate.Title = Language.GetString("LABEL_MODIFIED_DATE");
            StatFileSize.Title = Language.GetString("LABEL_FILE_SIZE");
            StatTitleId.Title = Language.GetString("LABEL_TITLE_ID");
            StatContentId.Title = Language.GetString("LABEL_CONTENT_ID");

            // Display details in UI
            LabelCategory.Text = PackageItem.Category;
            LabelRegion.Text = $"({PackageItem.Region})";
            LabelName.Text = PackageItem.Name.Replace("&", "&&");

            StatModifiedDate.Value = PackageItem.IsDateMissing ? Language.GetString("DATA_MISSING") : Settings.UseRelativeTimes ? DateTime.Parse(PackageItem.ModifiedDate).Humanize() : DateTime.Parse(PackageItem.ModifiedDate).ToLongDateString();
            StatFileSize.Value = PackageItem.IsSizeMissing ? Language.GetString("DATA_MISSING") : Settings.UseFormattedFileSizes ? long.Parse(PackageItem.Size).Bytes().Humanize("#.##") : PackageItem.Size + " " + Language.GetString("LABEL_BYTES");
            StatTitleId.Value = PackageItem.TitleId;
            StatContentId.Text = PackageItem.ContentId;
            StatSha256.Text = PackageItem.IsSha256Missing ? Language.GetString("DATA_MISSING") : PackageItem.Sha256;

            ButtonInstall.SetControlText(Language.GetString("LABEL_INSTALL_FILE"), 26);
            ButtonDownload.SetControlText(Language.GetString("LABEL_DOWNLOAD_FILE"), 26);
        }

        private void ImageClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferPackagesDialog(this, TransferType.InstallPackage, PackageItem);
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferPackagesDialog(this, TransferType.DownloadPackage, PackageItem);
        }

        private void ButtonFaq_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowPackagesFaqDialog(this);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }
}