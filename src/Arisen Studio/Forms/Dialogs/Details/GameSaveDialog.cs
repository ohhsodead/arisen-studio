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
using System.Text;
using System.Windows.Forms;
using ScrollOrientation = DevExpress.XtraEditors.ScrollOrientation;
using System.Drawing;

namespace ArisenStudio.Forms.Dialogs.Details
{
    public partial class GameSaveDialog : XtraForm
    {
        public GameSaveDialog()
        {
            InitializeComponent();
        }

        public static SettingsData Settings = MainWindow.Settings;
        public static ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public static ResourceManager Language = MainWindow.ResourceLanguage;
        public static CategoriesData Categories = MainWindow.Database.CategoriesData;

        public CategoryType CategoryType;
        public GameSaveItemData GameSaveItem;

        public bool IsFavorite;

        private void GameSaveDialog_Load(object sender, EventArgs e)
        {
            IsFavorite = Settings.FavoriteGameSaves.Exists(x => x.CategoryType == CategoryType && x.CategoryId == GameSaveItem.CategoryId && x.ModId == GameSaveItem.Id && x.Platform == GameSaveItem.GetPlatform());

            StatLastUpdated.Title = Language.GetString("LABEL_LAST_UPDATED");
            StatVersion.Title = Language.GetString("LABEL_VERSION");
            StatCreatedBy.Title = Language.GetString("LABEL_CREATED_BY");
            StatSubmittedBy.Title = Language.GetString("LABEL_SUBMITTED_BY");
            StatGameMode.Title = Language.GetString("LABEL_GAME_MODE");

            // Display details in UI
            LabelCategory.Text = Categories.GetCategoryById(GameSaveItem.CategoryId).Title;
            LabelName.Text = GameSaveItem.Name.Replace("&", "&&");
            LabelRegion.Text = GameSaveItem.Region;

            StatLastUpdated.Value = Settings.UseRelativeTimes ? GameSaveItem.LastUpdated.Humanize() : GameSaveItem.LastUpdated.ToString("MM/dd/yyyy", CultureInfo.CurrentCulture);
            StatVersion.Value = GameSaveItem.Version;
            StatGameMode.Value = GameSaveItem.GameMode;
            StatCreatedBy.Value = GameSaveItem.CreatedBy.IsNullOrWhiteSpace() ? "Unknown" : GameSaveItem.CreatedBy.Replace("&", "&&");
            StatSubmittedBy.Value = GameSaveItem.SubmittedBy.Replace("&", "&&");

            TabDescription.Text = Language.GetString("LABEL_DESCRIPTION");
            TabDownloads.Text = $"{Language.GetString("LABEL_DOWNLOADS")} ({GameSaveItem.DownloadFiles.Count})";

            LabelDescription.Text = string.IsNullOrWhiteSpace(GameSaveItem.Description)
                ? Language.GetString("NO_MORE_DETAILS")
                : GameSaveItem.Description.Replace("&", "&&");

            StringBuilder extraDescription = new StringBuilder("\n---------------------------------------------\n")
                            .AppendLine("Important Information:\n")
                            .AppendLine("- You must have at least one USB device connected to the console before installing the game save files.\n")
                            .Append("- It's suggested to use 'Apollo Tool' (Homebrew Applications) for patching and resigning game save files directly on your console.");

            LabelDescription.Text += extraDescription.ToString();

            ButtonDownload.Text = GameSaveItem.DownloadFiles.Count > 1 ? Language.GetString("LABEL_DOWNLOAD_LATEST") : Language.GetString("LABEL_DOWNLOAD");
            ButtonInstall.Text = GameSaveItem.DownloadFiles.Count > 1 ? Language.GetString("LABEL_INSTALL_LATEST") : Language.GetString("LABEL_INSTALL");
            ButtonInstall.Enabled = MainWindow.IsConsoleConnected || MainWindow.Settings.InstallGameSavesToUsbDevice;

            ButtonFavorite.Text = IsFavorite ? Language.GetString("LABEL_REMOVE_FROM_FAVORITES") : Language.GetString("LABEL_ADD_TO_FAVORITES");
            ButtonReport.Text = Language.GetString("LABEL_REPORT_ISSUE");
            ButtonHelp.Text = Language.GetString("LABEL_HELP_SUPPORT");

            int count = 0;
            foreach (DownloadFiles downloadFile in GameSaveItem.DownloadFiles)
            {
                count++;

                DownloadFileItem downloadItem = new()
                {
                    CategoryType = CategoryType.GameSave,
                    GameSaveItem = GameSaveItem,
                    DownloadFiles = downloadFile
                };

                if (GameSaveItem.DownloadFiles.Count() > 1 && count != 1)
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

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferGameSavesDialog(this, TransferType.DownloadGameSave, Categories.GetCategoryById(GameSaveItem.CategoryId), GameSaveItem, GameSaveItem.DownloadFiles.Last());
        }

        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferGameSavesDialog(this, TransferType.InstallGameSave, Categories.GetCategoryById(GameSaveItem.CategoryId), GameSaveItem, GameSaveItem.DownloadFiles.Last());
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (IsFavorite)
            {
                _ = MainWindow.Settings.FavoriteGameSaves.RemoveAll(x => x.CategoryType == CategoryType && x.CategoryId == GameSaveItem.CategoryId && x.ModId == GameSaveItem.Id && x.Platform == GameSaveItem.GetPlatform());
                ButtonFavorite.Text = Language.GetString("LABEL_ADD_TO_FAVORITES");
                IsFavorite = false;
            }
            else
            {
                MainWindow.Settings.FavoriteGameSaves.Add(new() { CategoryType = CategoryType, CategoryId = GameSaveItem.CategoryId, ModId = GameSaveItem.Id, Platform = GameSaveItem.GetPlatform() });
                ButtonFavorite.Text = Language.GetString("LABEL_REMOVE_FROM_FAVORITES");
                IsFavorite = true;
            }
        }

        private void ButtonReportIssue_Click(object sender, EventArgs e)
        {
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