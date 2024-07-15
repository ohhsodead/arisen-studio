using DevExpress.Utils;
using DevExpress.XtraEditors;
using Humanizer;
using ArisenStudio.Database;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Database;
using ArisenStudio.Models.Resources;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using System.Windows;
using DevExpress.LookAndFeel;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Svg;

namespace ArisenStudio.Controls
{
    public partial class DownloadFileItem : XtraUserControl
    {

        public SettingsData Settings = MainWindow.Settings;
        public ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public ResourceManager Language = MainWindow.ResourceLanguage;
        public CategoriesData Categories = MainWindow.Database.CategoriesData;

        public ModItemData ModItem { get; set; }

        public AppItemData AppItem { get; set; }

        public GameSaveItemData GameSaveItem { get; set; }

        public DownloadFiles DownloadFiles { get; set; }

        public CategoryType CategoryType { get; set; }

        public bool ShowSeparator { get; set; } = false;

        public DownloadFileItem()
        {
            InitializeComponent();
        }

        private void DownloadItem_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(45, 45, 48);
            ListBoxInstallFiles.BackColor = Color.FromArgb(45, 45, 48);

            LabelName.Text = DownloadFiles.Name;
            LabelFilesCount.Text = $"{DownloadFiles.InstallPaths.Count()} {(DownloadFiles.InstallPaths.Count() == 1 ? Language.GetString("LABEL_FILE") : Language.GetString("LABEL_FILES"))}";
            LabelLastUpdated.Text = Settings.UseRelativeTimes ? DownloadFiles.LastUpdated.Humanize() : DownloadFiles.LastUpdated.ToString("dd MMM yyyy", CultureInfo.CurrentCulture);
            LabelRegion.Text = string.IsNullOrEmpty(DownloadFiles.Region) ? "-" : DownloadFiles.Region;
            LabelVersion.Text = string.IsNullOrEmpty(DownloadFiles.Version) ? "-" : DownloadFiles.Version;

            LabelHeaderLastUpdated.Text = Language.GetString("LABEL_LAST_UPDATED");
            LabelHeaderRegion.Text = Language.GetString("LABEL_REGION");
            LabelHeaderVersion.Text = Language.GetString("LABEL_VERSION");
            LabelInstallationFiles.Text = Language.GetString("LABEL_INSTALLATION_FILES");

            foreach (string installFile in DownloadFiles.InstallPaths)
            {
                ListBoxInstallFiles.Items.Add(installFile);
            }

            int totalHeight = DownloadFiles.InstallPaths.Count() * 24;
            ListBoxInstallFiles.Height = totalHeight;

            Separator.Visible = ShowSeparator;

            if (!MainWindow.IsConsoleConnected)
            {
                if (CategoryType is CategoryType.Game or CategoryType.Plugin)
                {
                    if (!MainWindow.Settings.InstallGameModsPluginsToUsbDevice)
                    {
                        ImageInstall.Visible = false;
                    }
                }
                else if (CategoryType is CategoryType.Homebrew)
                {
                    if (!MainWindow.Settings.InstallHomebrewToUsbDevice)
                    {
                        ImageInstall.Visible = false;
                    }
                }
                else if (CategoryType is CategoryType.Resource)
                {
                    if (!MainWindow.Settings.InstallResourcesToUsbDevice)
                    {
                        ImageInstall.Visible = false;
                    }
                }
                else if (CategoryType is CategoryType.Package)
                {
                    if (!MainWindow.Settings.InstallPackagesToUsbDevice)
                    {
                        ImageInstall.Visible = false;
                    }
                }
                else
                {
                    ImageInstall.Visible = false;
                }
            }
        }

        private void ImageInstall_Click(object sender, EventArgs e)
        {
            if (CategoryType is CategoryType.Game or CategoryType.Homebrew or CategoryType.Resource or CategoryType.Plugin)
            {
                InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? MainWindow.Settings.GetInstalledMods(ConsoleProfile, ModItem.CategoryId, ModItem.Id) : null;
                bool isInstalled = installedModInfo != null;

                if (isInstalled)
                {
                    DialogExtensions.ShowTransferFilesDialog(ParentForm, TransferType.UninstallMods, ModItem.GetCategory(Categories), ModItem, DownloadFiles);
                }
                else
                {
                    DialogExtensions.ShowTransferFilesDialog(ParentForm, TransferType.InstallMods, ModItem.GetCategory(Categories), ModItem, DownloadFiles);
                }
            }
            else if (CategoryType == CategoryType.GameSave)
            {
                DialogExtensions.ShowTransferGameSavesDialog(ParentForm, TransferType.InstallGameSave, Categories.GetCategoryById(GameSaveItem.CategoryId), GameSaveItem, DownloadFiles);
            }
        }

        private void ImageDownload_Click(object sender, EventArgs e)
        {
            if (CategoryType is CategoryType.Game or CategoryType.Homebrew or CategoryType.Resource or CategoryType.Plugin)
            {
                DialogExtensions.ShowTransferFilesDialog(ParentForm, TransferType.DownloadMods, ModItem.GetCategory(Categories), ModItem, DownloadFiles);
            }
            else if (CategoryType == CategoryType.GameSave)
            {
                DialogExtensions.ShowTransferGameSavesDialog(ParentForm, TransferType.DownloadGameSave, Categories.GetCategoryById(GameSaveItem.CategoryId), GameSaveItem, DownloadFiles);
            }
        }

        private void ImageCopyLink_Click(object sender, EventArgs e)
        {
            System.Windows.Clipboard.SetText(DownloadFiles.Url);
            XtraMessageBox.Show(this, Language.GetString("COPIED_LINK"), Language.GetString("LABEL_COPIED"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool isExpanded = false;

        private void ImageExpand_Click(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                ImageExpand.SvgImage = SvgImages[0];
                LabelInstallationFiles.Visible = false;
                ListBoxInstallFiles.Visible = false;
                isExpanded = false;
            }
            else
            {
                //ImageShowFiles.SvgImage = Properties.Resources.arrow_up;
                ImageExpand.SvgImage = SvgImages[1];
                LabelInstallationFiles.Visible = true;
                ListBoxInstallFiles.Visible = true;
                isExpanded = true;
            }
        }

        private void ListBoxInstallFiles_DrawItem(object sender, ListBoxDrawItemEventArgs e)
        {
            ListBoxControl control = (ListBoxControl)sender;
            e.Appearance.BackColor = control.BackColor;
            e.Appearance.ForeColor = control.ForeColor;
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
    }
}