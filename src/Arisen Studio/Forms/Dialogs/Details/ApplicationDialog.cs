﻿using DevExpress.Utils;
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
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using ScrollOrientation = DevExpress.XtraEditors.ScrollOrientation;
using System.Drawing;

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

            ButtonDownload.Text = Language.GetString("LABEL_DOWNLOAD");
            ButtonInstall.Text = Language.GetString("LABEL_INSTALL");

            InstalledModInfo = MainWindow.ConsoleProfile != null ? MainWindow.Settings.GetInstalledMods(ConsoleProfile, AppItem.CategoryId, AppItem.Id, false) : null;

            int count = 0;
            foreach (AppItemFile appItem in AppItem.DownloadFiles)
            {
                count++;

                DownloadAppFileItem fileItem = new()
                {
                    //CategoryType = CategoryType.Homebrew
                    
                    AppItemData = AppItem,
                    AppItemFile = appItem
                };

                if (AppItem.DownloadFiles.Count() > 1 && count != 1)
                {
                    fileItem.ShowSeparator = true;
                }

                fileItem.Dock = DockStyle.Top;
                TabDownloads.Controls.Add(fileItem);
            }

            if (!MainWindow.IsConsoleConnected)
            {
                if (!MainWindow.Settings.InstallPackagesToUsbDevice)
                {
                    ButtonInstall.Visible = false;
                }
            }

            IsFavorite = MainWindow.Settings.FavoriteMods.Exists(x => x.CategoryType == CategoryType && x.CategoryId == AppItem.CategoryId && x.ModId == AppItem.Id && x.Platform == AppItem.GetPlatform());

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

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Language.GetString("REDIRECT_TO_GITHUB_ISSUES"), Language.GetString("REDIRECTING"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            GitHubTemplates.OpenReportTemplateApps(Categories.GetCategoryById(AppItem.CategoryId), AppItem);
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (IsFavorite)
            {
                Settings.FavoriteMods.RemoveAll(x => x.CategoryType == CategoryType && x.CategoryId == AppItem.CategoryId && x.ModId == AppItem.Id && x.Platform == AppItem.GetPlatform());
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