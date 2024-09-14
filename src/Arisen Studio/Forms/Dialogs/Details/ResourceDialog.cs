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
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using ScrollOrientation = DevExpress.XtraEditors.ScrollOrientation;
using System.Drawing;
using ArisenStudio.Constants;

namespace ArisenStudio.Forms.Dialogs.Details
{
    public partial class ResourceDialog : XtraForm
    {
        public ResourceDialog()
        {
            InitializeComponent();
        }

        public static SettingsData Settings = MainWindow.Settings;
        public static ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public static ResourceManager Language = MainWindow.ResourceLanguage;
        public static CategoriesData Categories = MainWindow.Database.CategoriesData;

        public CategoryType CategoryType;
        public ModItemData ModItem;

        public bool IsFavorite;

        private void ResourceDialog_Load(object sender, EventArgs e)
        {
            IsFavorite = Settings.FavoriteMods.Exists(x => x.CategoryType == CategoryType && x.CategoryId == ModItem.CategoryId && x.ModId == ModItem.Id && x.Platform == ModItem.GetPlatform());

            StatLastUpdated.Title = Language.GetString("LABEL_LAST_UPDATED");
            StatSystemType.Title = Language.GetString("LABEL_SYSTEM_TYPE");
            StatModType.Title = Language.GetString("LABEL_MOD_TYPE");
            StatCreatedBy.Title = Language.GetString("LABEL_CREATED_BY");
            StatSubmittedBy.Title = Language.GetString("LABEL_SUBMITTED_BY");
            StatVersion.Title = Language.GetString("LABEL_VERSION");

            // Display details in UI
            LabelCategory.Text = Categories.GetCategoryById(ModItem.CategoryId).Title;
            LabelName.Text = ModItem.Name.Replace("&", "&&");

            StatLastUpdated.Value = Settings.UseRelativeTimes ? ModItem.DownloadFiles.First().LastUpdated.Humanize() : ModItem.DownloadFiles.First().LastUpdated.ToLongDateString();
            StatSystemType.Value = ModItem.FirmwareType;
            StatModType.Value = ModItem.ModType;
            StatCreatedBy.Value = ModItem.CreatedBy.IsNullOrWhiteSpace() ? "Unknown" : ModItem.CreatedBy.Replace("&", "&&");
            StatSubmittedBy.Value = ModItem.SubmittedBy.Replace("&", "&&");
            StatVersion.Value = string.Join(" & ", ModItem.Versions).Replace("&", "&&");

            TabDescription.Text = Language.GetString("LABEL_DESCRIPTION");
            TabDownloads.Text = $"{Language.GetString("LABEL_DOWNLOADS")} ({ModItem.DownloadFiles.Count})";

            LabelDescription.Text = string.IsNullOrWhiteSpace(ModItem.Description)
                ? Language.GetString("NO_MORE_DETAILS")
                : ModItem.Description.Replace("&", "&&");

            ButtonDownload.Text = ModItem.DownloadFiles.Count > 1 ? Language.GetString("LABEL_DOWNLOAD_LATEST") : Language.GetString("LABEL_DOWNLOAD");
            ButtonInstall.Text = ModItem.DownloadFiles.Count > 1 ? Language.GetString("LABEL_INSTALL_LATEST") : Language.GetString("LABEL_INSTALL");
            ButtonInstall.Enabled = MainWindow.IsConsoleConnected || MainWindow.Settings.InstallResourcesToUsbDevice;

            ButtonFavorite.Text = IsFavorite ? Language.GetString("LABEL_REMOVE_FROM_FAVORITES") : Language.GetString("LABEL_ADD_TO_FAVORITES");

            ButtonReport.Text = Language.GetString("LABEL_REPORT_ISSUE");

            int count = 0;
            foreach (DownloadFiles downloadFile in ModItem.DownloadFiles)
            {
                count++;

                DownloadFileItem downloadItem = new()
                {
                    CategoryType = CategoryType.Resource,
                    ModItem = ModItem,
                    DownloadFiles = downloadFile
                };

                if (ModItem.DownloadFiles.Count() > 1 && count != 1)
                {
                    downloadItem.ShowSeparator = true;
                }

                downloadItem.Dock = DockStyle.Top;
                TabDownloads.Controls.Add(downloadItem);
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

        private void ButtonDownloadLatest_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferFilesDialog(this, TransferType.DownloadMods, ModItem.GetCategory(Categories), ModItem, ModItem.GetDownloadFiles(this));
        }

        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferFilesDialog(this, TransferType.InstallMods, ModItem.GetCategory(Categories), ModItem, ModItem.GetDownloadFiles(this));
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (IsFavorite)
            {
                _ = MainWindow.Settings.FavoriteMods.RemoveAll(x => x.CategoryType == CategoryType && x.CategoryId == ModItem.CategoryId && x.ModId == ModItem.Id && x.Platform == ModItem.GetPlatform());
                ButtonFavorite.Text = Language.GetString("LABEL_ADD_TO_FAVORITES");
                IsFavorite = false;
            }
            else
            {
                MainWindow.Settings.FavoriteMods.Add(new() { CategoryType = CategoryType, CategoryId = ModItem.CategoryId, ModId = ModItem.Id, Platform = ModItem.GetPlatform() });
                ButtonFavorite.Text = Language.GetString("LABEL_REMOVE_FROM_FAVORITES");
                IsFavorite = true;
            }
        }

        private void ButtonReportIssue_Click(object sender, EventArgs e)
        {
            _ = Process.Start(Urls.ReportIssue);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            _ = Process.Start(Urls.WebsiteHelp);
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