using DevExpress.Utils;
using DevExpress.XtraEditors;
using Humanizer;
using ArisenStudio.Controls;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Database;
using ArisenStudio.Models.Resources;
using ArisenStudio.Templates;
using System;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using ScrollOrientation = DevExpress.XtraEditors.ScrollOrientation;
using System.Drawing;

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

            LabelDescription.Text = string.IsNullOrWhiteSpace(ModItem.Description)
                ? Language.GetString("NO_MORE_DETAILS")
                : ModItem.Description.Replace("&", "&&");

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

            TabDescription.Text = Language.GetString("LABEL_DESCRIPTION");
            TabDownloads.Text = $"{Language.GetString("LABEL_DOWNLOADS")} ({ModItem.DownloadFiles.Count})";

            IsFavorite = Settings.FavoriteMods.Exists(x => x.CategoryType == CategoryType && x.CategoryId == ModItem.CategoryId && x.ModId == ModItem.Id && x.Platform == ModItem.GetPlatform());

            if (IsFavorite)
            {
                ButtonFavorite.Text = Language.GetString("LABEL_REMOVE_FROM_FAVORITES");
            }
            else
            {
                ButtonFavorite.Text = Language.GetString("LABEL_ADD_TO_FAVORITES");
            }

            ButtonReport.Text = Language.GetString("LABEL_REPORT_ISSUE");
        }

        private void ImageClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LabelDescription_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
        }

        private void TabDescription_Scroll(object sender, XtraScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                TabDownloads.VerticalScroll.Value = e.NewValue;
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
            DialogExtensions.ShowTransferFilesDialog(this, TransferType.DownloadMods, ModItem.GetCategory(Categories), ModItem, ModItem.DownloadFiles.Last());
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (IsFavorite)
            {
                MainWindow.Settings.FavoriteMods.RemoveAll(x => x.CategoryType == CategoryType && x.CategoryId == ModItem.CategoryId && x.ModId == ModItem.Id && x.Platform == ModItem.GetPlatform());
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
            XtraMessageBox.Show(Language.GetString("REDIRECT_TO_GITHUB_ISSUES"), Language.GetString("REDIRECTING"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            GitHubTemplates.OpenReportTemplate(Categories.GetCategoryById(ModItem.CategoryId), ModItem);
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