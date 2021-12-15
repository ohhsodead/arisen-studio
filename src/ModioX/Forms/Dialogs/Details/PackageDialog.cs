using System;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Humanizer;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Database;
using ModioX.Models.Resources;

namespace ModioX.Forms.Dialogs.Details
{
    public partial class PackageDialog : XtraForm
    {
        public PackageDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;
        public SettingsData Settings = MainWindow.Settings;
        public CategoriesData Categories = MainWindow.Database.CategoriesData;

        public PackageItemData PackageItem;

        private void PackageDialog_Load(object sender, EventArgs e)
        {
            // Display details in UI
            LabelCategory.Text = PackageItem.Category;
            LabelName.Text = PackageItem.Name.Replace("&", "&&");
            LabelTitleIdRegion.Text = $"{PackageItem.TitleId} ({PackageItem.Region})";
            LabelContentId.Text = PackageItem.ContentId;
            LabelModifiedDate.Text = PackageItem.IsDateMissing ? "DATA MISSING" : Settings.UseRelativeTimes ? DateTime.Parse(PackageItem.ModifiedDate).Humanize() : DateTime.Parse(PackageItem.ModifiedDate).ToString("MM/dd/yyyy", CultureInfo.CurrentCulture);
            LabelFileSize.Text = PackageItem.IsSizeMissing ? "DATA MISSING" : Settings.UseFormattedFileSizes ? long.Parse(PackageItem.Size).Bytes().Humanize("#.##") : PackageItem.Size + " Bytes";
            LabelSha256.Text = PackageItem.IsSha256Missing ? "DATA MISSING" : PackageItem.Sha256;
        }

        private void ImageCloseDetails_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuActions_BeforePopup(object sender, CancelEventArgs e)
        {
            if (PackageItem != null)
            {
                MenuItemInstallFiles.Enabled = Settings.InstallPackagesToUsbDevice | MainWindow.IsConsoleConnected;
            }
        }

        private void MenuItemInstallFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PackageItem != null)
            {
                DialogExtensions.ShowTransferPackagesDialog(this, TransferType.InstallPackage, PackageItem);
            }
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferPackagesDialog(this, TransferType.DownloadPackage, PackageItem);
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