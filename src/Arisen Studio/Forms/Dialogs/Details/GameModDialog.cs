﻿using DevExpress.Utils;
using DevExpress.XtraEditors;
using Humanizer;
using ArisenStudio.Controls;
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
    public partial class GameModDialog : XtraForm
    {
        public GameModDialog()
        {
            InitializeComponent();
        }

        public static SettingsData Settings = MainWindow.Settings;
        public static ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public static ResourceManager Language = MainWindow.ResourceLanguage;
        public static CategoriesData Categories = MainWindow.Database.CategoriesData;

        public CategoryType CategoryType;
        public ModItemData ModItem;

        public InstalledModInfo InstalledModInfo;

        public bool IsFavorite;

        private void GameModDialog_Load(object sender, EventArgs e)
        {
            Region = new Region(GraphicExtensions.GetRoundedRectanglePath(ClientRectangle, 20));

            InstalledModInfo = MainWindow.ConsoleProfile != null ? MainWindow.Settings.GetInstalledMods(ConsoleProfile, ModItem.CategoryId, ModItem.Id, false) : null;
            IsFavorite = Settings.FavoriteMods.Exists(x => x.CategoryType == CategoryType && x.CategoryId == ModItem.CategoryId && x.ModId == ModItem.Id && x.Platform == ModItem.GetPlatform());

            StatLastUpdated.Title = Language.GetString("LABEL_LAST_UPDATED");
            StatSystemType.Title = Language.GetString("LABEL_SYSTEM_TYPE");
            StatModType.Title = Language.GetString("LABEL_MOD_TYPE");
            StatVersion.Title = Language.GetString("LABEL_VERSION");
            StatCreatedBy.Title = Language.GetString("LABEL_CREATED_BY");
            StatSubmittedBy.Title = Language.GetString("LABEL_SUBMITTED_BY");
            StatGameMode.Title = Language.GetString("LABEL_GAME_MODE");

            // Display details in UI
            LabelCategory.Text = Categories.GetCategoryById(ModItem.CategoryId).Title;
            LabelName.Text = ModItem.Name.Replace("&", "&&");
            LabelRegion.Text = $"({string.Join(", ", ModItem.Regions)})";

            StatLastUpdated.Value = Settings.UseRelativeTimes ? ModItem.DownloadFiles[0].LastUpdated.Humanize() : ModItem.DownloadFiles[0].LastUpdated.ToString("MM/dd/yyyy", CultureInfo.CurrentCulture);
            StatSystemType.Value = ModItem.FirmwareType;
            StatModType.Value = ModItem.ModType;
            StatVersion.Value = string.Join(" & ", ModItem.Versions).Replace("&", "&&");
            StatCreatedBy.Value = ModItem.CreatedBy.IsNullOrWhiteSpace() ? "Unknown" : ModItem.CreatedBy.Replace("&", "&&");
            StatSubmittedBy.Value = ModItem.SubmittedBy.Replace("&", "&&");
            StatGameMode.Value = string.Join(", ", ModItem.GameModes);

            TabDescription.Text = Language.GetString("LABEL_DESCRIPTION");
            TabDownloads.Text = $"{Language.GetString("LABEL_DOWNLOADS")} ({ModItem.DownloadFiles.Count})";

            LabelDescription.Text = string.IsNullOrWhiteSpace(ModItem.Description)
                ? Language.GetString("NO_MORE_DETAILS")
                : ModItem.Description.Replace("&", "&&");

            if (ModItem.ModType.Equals("SCRIPT"))
            {
                LabelDescription.Text += "\n\n" + Language.GetString("SCRIPT_CANT_BE_INSTALLED");
            }

            ButtonDownload.Text = ModItem.DownloadFiles.Count > 1 ? Language.GetString("LABEL_DOWNLOAD_LATEST") : Language.GetString("LABEL_DOWNLOAD");
            ButtonInstall.Text = ModItem.DownloadFiles.Count > 1 ? Language.GetString("LABEL_INSTALL_LATEST") : Language.GetString("LABEL_INSTALL");
            ButtonInstall.Enabled = MainWindow.IsConsoleConnected || MainWindow.Settings.InstallGameModsToUsbDevice;

            ButtonFavorite.Text = IsFavorite ? Language.GetString("LABEL_REMOVE_FROM_FAVORITES") : Language.GetString("LABEL_ADD_TO_FAVORITES");
            ButtonReport.Text = Language.GetString("LABEL_REPORT_ISSUE");
            ButtonHelp.Text = Language.GetString("LABEL_HELP_SUPPORT");

            int count = 0;
            foreach (DownloadFiles downloadFile in ModItem.DownloadFiles)
            {
                count++;

                DownloadFileItem downloadItem = new()
                {
                    CategoryType = CategoryType.Game,
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

        private void LabelDescription_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            _ = Process.Start(e.Link);
        }

        private void ButtonDownloadLatest_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferFilesDialog(this, TransferType.DownloadMods, ModItem.GetCategory(Categories), ModItem, ModItem.DownloadFiles.Last());
        }

        private void ButtonInstallLatest_Click(object sender, EventArgs e)
        {
            if (InstalledModInfo == null)
            {
                DialogExtensions.ShowTransferFilesDialog(this, TransferType.InstallMods, ModItem.GetCategory(Categories), ModItem, ModItem.DownloadFiles.Last());
            }
            else
            {
                DialogExtensions.ShowTransferFilesDialog(this, TransferType.UninstallMods, ModItem.GetCategory(Categories), ModItem, (DownloadFiles)InstalledModInfo.DownloadFiles);
            }
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (IsFavorite)
            {
                _ = Settings.FavoriteMods.RemoveAll(x => x.CategoryType == CategoryType && x.CategoryId == ModItem.CategoryId && x.ModId == ModItem.Id && x.Platform == ModItem.GetPlatform());
                ButtonFavorite.Text = Language.GetString("LABEL_ADD_TO_FAVORITES");
                IsFavorite = false;
            }
            else
            {
                Settings.FavoriteMods.Add(new() { CategoryType = CategoryType, CategoryId = ModItem.CategoryId, ModId = ModItem.Id, Platform = ModItem.GetPlatform() });
                ButtonFavorite.Text = Language.GetString("LABEL_REMOVE_FROM_FAVORITES");
                IsFavorite = true;
            }
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowReportIssueDialog(this);
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

        private const int WmHscroll = 0x114;
        private const int WmVscroll = 0x115;

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == WmHscroll || m.Msg == WmVscroll)
            && (((int)m.WParam & 0xFFFF) == 5))
            {
                // Change SB_THUMBTRACK to SB_THUMBPOSITION
                m.WParam = (IntPtr)(((int)m.WParam & ~0xFFFF) | 4);
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
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