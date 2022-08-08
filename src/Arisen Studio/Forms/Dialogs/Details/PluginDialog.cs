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

namespace ArisenStudio.Forms.Dialogs.Details
{
    public partial class PluginDialog : XtraForm
    {
        public PluginDialog()
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

        private void PluginDialog_Load(object sender, EventArgs e)
        {
            InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? MainWindow.Settings.GetInstalledMods(ConsoleProfile, ModItem.CategoryId, ModItem.Id) : null;

            StatLastUpdated.Title = Language.GetString("LABEL_LAST_UPDATED");
            StatVersion.Title = Language.GetString("LABEL_VERSION");
            StatGameMode.Title = Language.GetString("LABEL_GAME_MODE");
            StatCreatedBy.Title = Language.GetString("LABEL_CREATED_BY");
            StatSubmittedBy.Title = Language.GetString("LABEL_SUBMITTED_BY");

            //Display details in UI
            LabelCategory.Text = Categories.GetCategoryById(ModItem.CategoryId).Title;
            LabelName.Text = ModItem.Name.Replace("&", "&&");

            StatLastUpdated.Value = Settings.UseRelativeTimes ? ModItem.DownloadFiles.First().LastUpdated.Humanize() : ModItem.DownloadFiles.First().LastUpdated.ToLongDateString();
            StatVersion.Value = string.Join(" & ", ModItem.Versions).Replace("&", "&&");
            StatGameMode.Value = string.Join(", ", ModItem.GameModes);
            StatCreatedBy.Value = ModItem.CreatedBy.IsNullOrWhiteSpace() ? "Unknown" : ModItem.CreatedBy.Replace("&", "&&");
            StatSubmittedBy.Value = ModItem.SubmittedBy.Replace("&", "&&");

            LabelDescription.Text = string.IsNullOrWhiteSpace(ModItem.Description)
                ? Language.GetString("NO_MORE_DETAILS")
                : ModItem.Description.Replace("&", "&&");

            int count = 0;
            foreach (DownloadFiles downloadFile in ModItem.DownloadFiles)
            {
                count++;

                DownloadFileItem downloadItem = new()
                {
                    CategoryType = CategoryType.Plugin,
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
                ButtonFavorite.SetControlText(Language.GetString("LABEL_REMOVE_FROM_FAVORITES"), 26);
            }
            else
            {
                ButtonFavorite.SetControlText(Language.GetString("LABEL_ADD_TO_FAVORITES"), 26);
            }

            ButtonReport.SetControlText(Language.GetString("LABEL_REPORT_ISSUE"), 26);
        }

        private void ImageClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void LabelDescription_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
        }

        private void ButtonReportIssue_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Language.GetString("REDIRECT_TO_GITHUB_ISSUES"), Language.GetString("REDIRECTING"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            GitHubTemplates.OpenReportTemplatePlugins(Categories.GetCategoryById(ModItem.CategoryId), ModItem);
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (IsFavorite)
            {
                MainWindow.Settings.FavoriteMods.RemoveAll(x => x.CategoryType == CategoryType && x.CategoryId == ModItem.CategoryId && x.ModId == ModItem.Id && x.Platform == ModItem.GetPlatform());
                ButtonFavorite.SetControlText(Language.GetString("LABEL_ADD_TO_FAVORITES"), 26);
                IsFavorite = false;
            }
            else
            {
                MainWindow.Settings.FavoriteMods.Add(new() { CategoryType = CategoryType, CategoryId = ModItem.CategoryId, ModId = ModItem.Id, Platform = ModItem.GetPlatform() });
                ButtonFavorite.SetControlText(Language.GetString("LABEL_REMOVE_FROM_FAVORITES"), 26);
                IsFavorite = true;
            }
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