using DevExpress.Utils;
using DevExpress.XtraEditors;
using Humanizer;
using NeoModsX.Controls;
using NeoModsX.Database;
using NeoModsX.Extensions;
using NeoModsX.Forms.Windows;
using NeoModsX.Models.Database;
using NeoModsX.Models.Resources;
using NeoModsX.Templates;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using ScrollOrientation = DevExpress.XtraEditors.ScrollOrientation;

namespace NeoModsX.Forms.Dialogs.Details
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

        public bool IsFavorite;

        private void GameModDialog_Load(object sender, EventArgs e)
        {
            InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? MainWindow.Settings.GetInstalledMods(ConsoleProfile, ModItem.CategoryId, ModItem.Id) : null;

            LabelHeaderSystemType.Text = Language.GetString("LABEL_SYSTEM_TYPE");
            LabelHeaderModType.Text = Language.GetString("LABEL_MOD_TYPE");
            LabelHeaderVersion.Text = Language.GetString("LABEL_VERSION");
            LabelHeaderGameMode.Text = Language.GetString("LABEL_GAME_MODE");
            LabelHeaderCreatedBy.Text = Language.GetString("LABEL_CREATED_BY");
            LabelHeaderSubmittedBy.Text = Language.GetString("LABEL_SUBMITTED_BY");

            // Display details in UI
            LabelCategory.Text = Categories.GetCategoryById(ModItem.CategoryId).Title;
            LabelName.Text = ModItem.Name.Replace("&", "&&");
            LabelRegion.Text = $"({string.Join(", ", ModItem.Regions)})";
            LabelLastUpdated.Text = Settings.UseRelativeTimes ? ModItem.LastUpdated.Humanize() : ModItem.LastUpdated.ToString("MM/dd/yyyy", CultureInfo.CurrentCulture);
            LabelModType.Text = ModItem.ModType;
            LabelSystemType.Text = ModItem.FirmwareType;
            LabelVersion.Text = string.Join(" & ", ModItem.Versions).Replace("&", "&&");
            LabelCreatedBy.Text = ModItem.CreatedBy.Replace("&", "&&");
            LabelSubmittedBy.Text = ModItem.SubmittedBy.Replace("&", "&&");
            LabelGameMode.Text = string.Join(", ", ModItem.GameModes);
            LabelDescription.Text = string.IsNullOrWhiteSpace(ModItem.Description)
                ? Language.GetString("NO_MORE_DETAILS")
                : ModItem.Description.Replace("&", "&&");

            if (ModItem.ModType.Equals("SCRIPT"))
            {
                LabelDescription.Text += "\n\n" + Language.GetString("SCRIPT_CANT_BE_INSTALLED");
            }

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

        private void ImageCloseDetails_Click(object sender, EventArgs e)
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

        private void ButtonReportIssue_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Language.GetString("REDIRECT_TO_GITHUB_ISSUES"), Language.GetString("REDIRECTING"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            GitHubTemplates.OpenReportTemplate(Categories.GetCategoryById(ModItem.CategoryId), ModItem);
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (IsFavorite)
            {
                Settings.FavoriteMods.RemoveAll(x => x.CategoryType == CategoryType && x.CategoryId == ModItem.CategoryId && x.ModId == ModItem.Id && x.Platform == ModItem.GetPlatform());
                ButtonFavorite.SetControlText(Language.GetString("LABEL_ADD_TO_FAVORITES"), 26);
                IsFavorite = false;
            }
            else
            {
                Settings.FavoriteMods.Add(new() { CategoryType = CategoryType, CategoryId = ModItem.CategoryId, ModId = ModItem.Id, Platform = ModItem.GetPlatform() });
                ButtonFavorite.SetControlText(Language.GetString("LABEL_REMOVE_FROM_FAVORITES"), 26);
                IsFavorite = true;
            }
        }

        private void LabelDescription_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
        }

        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL)
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
                var cp = base.CreateParams;
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