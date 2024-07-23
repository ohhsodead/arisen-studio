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

namespace ArisenStudio.Controls
{
    public partial class DownloadAppFileItem : XtraUserControl
    {
        public SettingsData Settings = MainWindow.Settings;
        public ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public ResourceManager Language = MainWindow.ResourceLanguage;
        public CategoriesData Categories = MainWindow.Database.CategoriesData;

        public AppItemData AppItemData { get; set; }

        public AppItemFile AppItemFile { get; set; }

        public CategoryType CategoryType { get; set; }

        public bool ShowSeparator { get; set; } = false;

        public DownloadAppFileItem()
        {
            InitializeComponent();
        }

        private void DownloadItem_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(45, 45, 48);

            LabelHeaderLastUpdated.Text = Language.GetString("LABEL_LAST_UPDATED");
            LabelHeaderVersion.Text = Language.GetString("LABEL_VERSION");

            LabelName.Text = AppItemFile.Name;
            LabelPlayableVersions.Text = Language.GetString("LABEL_PLAYABLE_VERSION") + ": " + AppItemFile.PlayableVersion;

            LabelLastUpdated.Text = Settings.UseRelativeTimes ? AppItemFile.LastUpdated.Humanize() : AppItemFile.LastUpdated.ToString("dd MMM yyyy", CultureInfo.CurrentCulture);
            LabelVersion.Text = string.IsNullOrEmpty(AppItemFile.Version) ? "-" : AppItemFile.Version;

            Separator.Visible = ShowSeparator;

            if (!MainWindow.IsConsoleConnected)
            {
                if (CategoryType is CategoryType.Application)
                {
                    if (!MainWindow.Settings.InstallApplicationsToUsbDevice)
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
            InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? MainWindow.Settings.GetInstalledMods(ConsoleProfile, AppItemData.CategoryId, AppItemData.Id, false) : null;
            bool isInstalled = installedModInfo != null;

            if (isInstalled)
            {
                DialogExtensions.ShowTransferFilesDialog(ParentForm, TransferType.UninstallApplication, AppItemData.GetCategory(Categories), AppItemData, AppItemFile);
            }
            else
            {
                DialogExtensions.ShowTransferFilesDialog(ParentForm, TransferType.InstallApplication, AppItemData.GetCategory(Categories), AppItemData, AppItemFile);
            }
        }

        private void ImageDownload_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferFilesDialog(ParentForm, TransferType.DownloadApplication, AppItemData.GetCategory(Categories), AppItemData, AppItemFile);
        }

        private void ImageCopyLink_Click(object sender, EventArgs e)
        {
            System.Windows.Clipboard.SetText(AppItemFile.GetFileUrl(AppItemData.TitleId));
            XtraMessageBox.Show(this, Language.GetString("COPIED_LINK"), Language.GetString("LABEL_COPIED"), MessageBoxButtons.OK, MessageBoxIcon.Information);
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