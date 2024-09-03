using DevExpress.Utils;
using DevExpress.XtraEditors;
using Humanizer;
using ArisenStudio.Controls;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Database;
using ArisenStudio.Models.Resources;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using ScrollOrientation = DevExpress.XtraEditors.ScrollOrientation;
using System.Drawing;
using ArisenStudio.Constants;

namespace ArisenStudio.Forms.Dialogs.Details
{
    public partial class ApplicationDialog : XtraForm
    {
        public ApplicationDialog()
        {
            InitializeComponent();
        }

        public static SettingsData Settings = MainWindow.Settings;
        public static ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public static ResourceManager Language = MainWindow.ResourceLanguage;
        public static CategoriesData Categories = MainWindow.Database.CategoriesData;

        public CategoryType CategoryType;
        public AppItemData AppItem;

        public InstalledModInfo InstalledModInfo;

        private bool IsFavorite;

        private void ApplicationDialog_Load(object sender, EventArgs e)
        {
            InstalledModInfo = MainWindow.ConsoleProfile != null ? MainWindow.Settings.GetInstalledMods(ConsoleProfile, AppItem.CategoryId, AppItem.Id, false) : null;
            IsFavorite = MainWindow.Settings.FavoriteMods.Exists(x => x.CategoryType == CategoryType && x.CategoryId == AppItem.CategoryId && x.ModId == AppItem.Id && x.Platform == AppItem.GetPlatform());

            LabelCategory.Text = Categories.GetCategoryById(AppItem.CategoryId).Title;
            LabelName.Text = AppItem.Name.Replace("&", "&&");

            //StatTitleId.Title = Language.GetString("LABEL_TITLE_ID");
            StatFwVersions.Title = Language.GetString("LABEL_SYSTEM_TYPE");
            StatVersion.Title = Language.GetString("LABEL_VERSION");
            StatVersion.Title = Language.GetString("LABEL_CREATED_BY");
            StatCreatedBy.Title = Language.GetString("LABEL_SUBMITTED_BY");
            StatLastUpdated.Title = Language.GetString("LABEL_LAST_UPDATED");

            StatTitleId.Value = AppItem.TitleId;
            StatFwVersions.Value = string.Join("/", [.. AppItem.FirmwareVersions]);
            StatCreatedBy.Value = AppItem.CreatedBy.IsNullOrWhiteSpace() ? "Unknown" : AppItem.CreatedBy.Replace("&", "&&");
            StatSubmittedBy.Value = AppItem.SubmittedBy.Replace("&", "&&");
            StatVersion.Value = string.Join(" & ", AppItem.Versions).Replace("&", "&&");
            StatLastUpdated.Value = MainWindow.Settings.UseRelativeTimes ? AppItem.DownloadFiles.First().LastUpdated.Humanize() : AppItem.DownloadFiles.First().LastUpdated.ToString("MM/dd/yyyy", CultureInfo.CurrentCulture);

            TabDescription.Text = Language.GetString("LABEL_DESCRIPTION");
            TabDownloads.Text = $"{Language.GetString("LABEL_DOWNLOADS")} ({AppItem.DownloadFiles.Count})";

            LabelDescription.Text = string.IsNullOrWhiteSpace(AppItem.Description)
                ? Language.GetString("NO_MORE_DETAILS")
                : AppItem.Description.Replace("&", "&&");

            ButtonDownload.Text = AppItem.DownloadFiles.Count > 1 ? Language.GetString("LABEL_DOWNLOAD_LATEST") : Language.GetString("LABEL_DOWNLOAD");
            ButtonInstall.Text = AppItem.DownloadFiles.Count > 1 ? Language.GetString("LABEL_INSTALL_LATEST") : Language.GetString("LABEL_INSTALL");
            ButtonInstall.Enabled = MainWindow.IsConsoleConnected || MainWindow.Settings.InstallHomebrewToUsbDevice;

            ButtonFavorite.Text = IsFavorite ? Language.GetString("LABEL_REMOVE_FROM_FAVORITES") : Language.GetString("LABEL_ADD_TO_FAVORITES");
            ButtonReport.Text = Language.GetString("LABEL_REPORT_ISSUE");


            int count = 0;
            foreach (AppItemFile appItem in AppItem.DownloadFiles)
            {
                count++;

                DownloadAppFileItem fileItem = new()
                {
                    AppItemData = AppItem,
                    AppItemFile = appItem,

                    ShowSeparator = AppItem.DownloadFiles.Count() > 1 && count != 1,

                    Dock = DockStyle.Top
                };

                TabDownloads.Controls.Add(fileItem);
            }
        }

        private void ImageClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LabelDescription_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            _ = Process.Start(e.Link);
        }

        private void TabDescription_Scroll(object sender, XtraScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                TabDescription.VerticalScroll.Value = e.NewValue;
            }
        }

        private void TabDownloads_Scroll(object sender, XtraScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                TabDownloads.VerticalScroll.Value = e.NewValue;
            }
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferFilesDialog(this, TransferType.DownloadApplication, AppItem.GetCategory(Categories), AppItem, AppItem.DownloadFiles.Last());
        }

        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferFilesDialog(this, TransferType.InstallApplication, AppItem.GetCategory(Categories), AppItem, AppItem.DownloadFiles.Last());
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (IsFavorite)
            {
                _ = Settings.FavoriteMods.RemoveAll(x => x.CategoryType == CategoryType && x.CategoryId == AppItem.CategoryId && x.ModId == AppItem.Id && x.Platform == AppItem.GetPlatform());
                ButtonFavorite.Text = Language.GetString("LABEL_ADD_TO_FAVORITES");
                IsFavorite = false;
            }
            else
            {
                Settings.FavoriteMods.Add(new() { CategoryType = CategoryType, CategoryId = AppItem.CategoryId, ModId = AppItem.Id, Platform = AppItem.GetPlatform() });
                ButtonFavorite.Text = Language.GetString("LABEL_REMOVE_FROM_FAVORITES");
                IsFavorite = true;
            }
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