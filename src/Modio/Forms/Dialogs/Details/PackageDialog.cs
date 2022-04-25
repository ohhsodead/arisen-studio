using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Humanizer;
using Modio.Database;
using Modio.Extensions;
using Modio.Forms.Windows;
using Modio.Models.Database;
using Modio.Models.Resources;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace Modio.Forms.Dialogs.Details
{
    public partial class PackageDialog : XtraForm
    {
        public PackageDialog()
        {
            InitializeComponent();
        }

        public SettingsData Settings = MainWindow.Settings;
        public ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public ResourceManager Language = MainWindow.ResourceLanguage;
        public CategoriesData Categories = MainWindow.Database.CategoriesData;

        public PackageItemData PackageItem;

        private void PackageDialog_Load(object sender, EventArgs e)
        {
            // Display details in UI
            LabelCategory.Text = PackageItem.Category;
            LabelRegion.Text = $"({PackageItem.Region})";
            LabelName.Text = PackageItem.Name.Replace("&", "&&");
            LabelModifiedDate.Text = PackageItem.IsDateMissing ? Language.GetString("DATA_MISSING") : Settings.UseRelativeTimes ? DateTime.Parse(PackageItem.ModifiedDate).Humanize() : DateTime.Parse(PackageItem.ModifiedDate).ToLongDateString();
            LabelFileSize.Text = PackageItem.IsSizeMissing ? Language.GetString("DATA_MISSING") : Settings.UseFormattedFileSizes ? long.Parse(PackageItem.Size).Bytes().Humanize("#.##") : PackageItem.Size + " " + Language.GetString("LABEL_BYTES");
            LabelTitleID.Text = PackageItem.TitleId;
            LabelContentId.Text = PackageItem.ContentId;
            LabelSha256.Text = PackageItem.IsSha256Missing ? Language.GetString("DATA_MISSING") : PackageItem.Sha256;

            LabelHeaderModifiedDate.Text = Language.GetString("LABEL_MODIFIED_DATE");
            LabelHeaderFileSize.Text = Language.GetString("LABEL_FILE_SIZE");
            LabelHeaderTitleId.Text = Language.GetString("LABEL_TITLE_ID");
            LabelHeaderContentId.Text = Language.GetString("LABEL_CONTENT_ID");

            ButtonInstall.SetControlText(Language.GetString("LABEL_INSTALL_FILE"), 26);
            ButtonDownload.SetControlText(Language.GetString("LABEL_DOWNLOAD_FILE"), 26);
        }

        private void ImageCloseDetails_Click(object sender, EventArgs e)
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