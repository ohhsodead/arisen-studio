using DevExpress.XtraEditors;
using Humanizer;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Database;
using ArisenStudio.Models.Resources;
using System;
using System.Resources;
using System.Windows.Forms;
using System.Drawing;

namespace ArisenStudio.Forms.Dialogs.Details
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
            StatContentId.Value = PackageItem.ContentId;
            StatSha256.Value = PackageItem.IsSha256Missing ? Language.GetString("DATA_MISSING") : PackageItem.Sha256;

            ButtonInstall.Text = Language.GetString("LABEL_INSTALL_FILE");
            ButtonDownload.Text = Language.GetString("LABEL_DOWNLOAD_FILE");

            ButtonInstall.Enabled = MainWindow.IsConsoleConnected;

            if (!MainWindow.IsConsoleConnected)
            {
                if (!MainWindow.Settings.InstallPackagesToUsbDevice)
                {
                    ButtonInstall.Visible = false;
                }
            }
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using Pen pen = new(Color.Transparent, 0);
            e.Graphics.DrawPath(pen, GraphicExtensions.GetRoundedRectanglePath(ClientRectangle, 4));
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using Brush brush = new SolidBrush(BackColor);
            e.Graphics.FillPath(brush, GraphicExtensions.GetRoundedRectanglePath(ClientRectangle, 4));
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