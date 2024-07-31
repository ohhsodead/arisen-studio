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
using System.Security;
using System.IO;
using System.Diagnostics;

namespace ArisenStudio.Controls
{
    public partial class CustomFileItem : XtraUserControl
    {
        public SettingsData Settings = MainWindow.Settings;
        public ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public ResourceManager Language = MainWindow.ResourceLanguage;
        public CategoriesData Categories = MainWindow.Database.CategoriesData;

        public CustomItemData CustomModItem { get; set; }

        public ListItem InstallFile { get; set; }

        public FileInfo LocalFileInfo { get; set; }

        public bool ShowSeparator { get; set; } = false;

        public CustomFileItem()
        {
            InitializeComponent();
        }

        private void CustomFileItem_Load(object sender, EventArgs e)
        {
            BackColor = Parent.BackColor;

            LabelHeaderLocalFile.Text = Language.GetString("LABEL_LOCAL_FILE") + ":";
            LabelLocalFile.Text = InstallFile.Name;

            LabelHeaderInstallPath.Text = Language.GetString("LABEL_INSTALL_PATH") + ":";
            LabelInstallPath.Text = InstallFile.Value;

            LabelHeaderLastModified.Text = Language.GetString("LABEL_LAST_MODIFIED");
            LabelHeaderSize.Text = Language.GetString("LABEL_SIZE");

            try
            {
                LocalFileInfo = new(InstallFile.Name);
                LabelLastModified.Text = Settings.UseRelativeTimes ? LocalFileInfo.LastWriteTime.Humanize() : LocalFileInfo.LastWriteTime.ToString("dd MMM yyyy", CultureInfo.CurrentCulture);
                LabelSize.Text = Settings.UseFormattedFileSizes ? LocalFileInfo.Length.Bytes().Humanize("#.##") : LocalFileInfo.Length + " " + Language.GetString("LABEL_BYTES");
            }
            //catch (Exception ex)
            //{
            //    if (ex is SecurityException || ex is UnauthorizedAccessException || ex is PathTooLongException || ex is NotSupportedException)
            //    {
            //        MainWindow.Window.SetStatus("Unable to fetch file size for file: " + InstallFile.Name, ex);
            //        LabelSize.Text = Language.GetString("ERROR");
            //    }
            //    else
            //        throw;
            //}
            catch (Exception ex) when (ex is SecurityException ||
                                       ex is UnauthorizedAccessException ||
                                       ex is PathTooLongException ||
                                       ex is NotSupportedException)
            {
                MainWindow.Window.SetStatus("Unable to fetch file information for file: " + InstallFile.Name, ex);
                LabelLastModified.Text = Language.GetString("FILE_MISSING");
                LabelSize.Text = Language.GetString("FILE_MISSING");
            }

            Separator.Visible = ShowSeparator;

            //if (!MainWindow.IsConsoleConnected)
            //{
            //    if (CategoryType is CategoryType.Application)
            //    {
            //        if (!MainWindow.Settings.InstallApplicationsToUsbDevice)
            //        {
            //            ImageInstall.Visible = false;
            //        }
            //    }
            //    else
            //    {
            //        ImageInstall.Visible = false;
            //    }
            //}
        }

        private void ImageInstall_Click(object sender, EventArgs e)
        {
            //InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? MainWindow.Settings.GetInstalledMods(ConsoleProfile, AppItemData.CategoryId, AppItemData.Id) : null;
            //bool isInstalled = installedModInfo != null;

            //if (isInstalled)
            //{
            //    DialogExtensions.ShowTransferFilesDialog(ParentForm, TransferType.UninstallApplication, AppItemData.GetCategory(Categories), AppItemData, CustomModItem);
            //}
            //else
            //{
            //    DialogExtensions.ShowTransferFilesDialog(ParentForm, TransferType.InstallApplication, AppItemData.GetCategory(Categories), AppItemData, CustomModItem);
            //}
        }

        private void ImageDownload_Click(object sender, EventArgs e)
        {
            //DialogExtensions.ShowTransferFilesDialog(ParentForm, TransferType.DownloadApplication, AppItemData.GetCategory(Categories), AppItemData, CustomModItem);
        }

        private void ImageCopyLink_Click(object sender, EventArgs e)
        {
            if (LocalFileInfo != null && LocalFileInfo.Exists)
            {
                Process.Start(LocalFileInfo.DirectoryName);
            }
            else
            {
                XtraMessageBox.Show(this, Language.GetString("FILE_UPLOAD_NOT_FOUND"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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