using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using ModioX.Templates;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Windows.Forms;

namespace ModioX.Forms.Dialogs.Details
{
    public partial class PluginDialog : XtraForm
    {
        public PluginDialog()
        {
            InitializeComponent();
        }

        public ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public ResourceManager Language = MainWindow.ResourceLanguage;
        public SettingsData Settings = MainWindow.Settings;
        public CategoriesData Categories = MainWindow.Database.CategoriesData;

        public ModItemData ModItem;

        private void PluginDialog_Load(object sender, EventArgs e)
        {
            //Display details in UI
            LabelCategory.Text = Categories.GetCategoryById(ModItem.CategoryId).Title;
            LabelName.Text = ModItem.Name.Replace("&", "&&");
            LabelVersion.Text = string.Join(" & ", ModItem.Versions).Replace("&", "&&");
            LabelGameMode.Text = string.Join(", ", ModItem.GameModes);
            LabelCreatedBy.Text = ModItem.CreatedBy.Replace("&", "&&");
            LabelSubmittedBy.Text = ModItem.SubmittedBy.Replace("&", "&&");
            LabelDescription.Text = string.IsNullOrWhiteSpace(ModItem.Description)
                ? Language.GetString("NO_MORE_DETAILS")
                : ModItem.Description.Replace("&", "&&");

            InstalledModInfo installedModInfo = MainWindow.Settings.GetInstalledMods(ConsoleProfile, ModItem.CategoryId, ModItem.Id);

            if (installedModInfo == null)
            {
                ButtonActions.SetControlText(Language.GetString("LABEL_NOT_INSTALLED"), 26);
                ButtonActions.ImageOptions.SvgImage = Images[0];
            }
            else
            {
                ButtonActions.SetControlText(Language.GetString("LABEL_INSTALLED"), 26);;
                ButtonActions.ImageOptions.SvgImage = Images[1];
            }

            if (Settings.FavoriteModsXBOX.Exists(x => x == ModItem.Id))
            {
                ButtonFavorite.SetControlText(Language.GetString("LABEL_UNFAVORITE"), 26);
            }
            else
            {
                ButtonFavorite.SetControlText(Language.GetString("LABEL_FAVORITE"), 26);;
            }

            LabelHeaderModType.Text = Language.GetString("LABEL_MOD_TYPE");
            LabelHeaderVersion.Text = Language.GetString("LABEL_VERSION");
            LabelHeaderGameMode.Text = Language.GetString("LABEL_GAME_MODE");
            LabelHeaderCreatedBy.Text = Language.GetString("LABEL_CREATED_BY");
            LabelHeaderSubmittedBy.Text = Language.GetString("LABEL_SUBMITTED_BY");
            LabelHeaderDescription.Text = Language.GetString("LABEL_DESCRIPTION");

            ButtonDownload.SetControlText(Language.GetString("LABEL_DOWNLOAD"), 26);
            ButtonReport.SetControlText(Language.GetString("LABEL_REPORT"), 26);
        }

        private void ImageCloseDetails_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuActions_BeforePopup(object sender, CancelEventArgs e)
        {
            if (ModItem != null)
            {
                InstalledModInfo installedMod = MainWindow.Settings.GetInstalledMods(ConsoleProfile, ModItem.CategoryId, ModItem.Id);

                bool isInstalled = installedMod != null && installedMod.ModId.Equals(ModItem.Id);

                MenuItemInstallFiles.Caption = isInstalled ? $"{Language.GetString("UNINSTALL_FILES")}..." : $"{Language.GetString("INSTALL_FILES")}...";
                MenuItemInstallFiles.Enabled = MainWindow.Settings.InstallModsToUsbDevice | MainWindow.IsConsoleConnected;
            }
        }

        private void MenuItemInstallFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            InstalledModInfo installedModInfo = MainWindow.Settings.GetInstalledMods(ConsoleProfile, ModItem.CategoryId, ModItem.Id);
            bool isInstalled = installedModInfo != null;

            if (isInstalled)
            {
                DialogExtensions.ShowTransferModsDialog(this, TransferType.UninstallMods, ModItem.GetCategory(Categories), ModItem);
            }
            else
            {
                DialogExtensions.ShowTransferModsDialog(this, TransferType.InstallMods, ModItem.GetCategory(Categories), ModItem);
            }
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferModsDialog(this, TransferType.DownloadMods, ModItem.GetCategory(Categories), ModItem);
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Language.GetString("REDIRECT_TO_GITHUB_ISSUES"), Language.GetString("REDIRECTING"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            GitHubTemplates.OpenReportTemplatePlugins(Categories.GetCategoryById(ModItem.CategoryId), ModItem);
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (Settings.FavoriteModsXBOX.Contains(ModItem.Id))
            {
                Settings.RemoveFavoriteForXBOX(ModItem.Id);
                ButtonFavorite.SetControlText(Language.GetString("LABEL_FAVORITE"), 26);;
            }
            else
            {
                Settings.AddFavoriteForXBOX(ModItem.Id);
                ButtonFavorite.SetControlText(Language.GetString("LABEL_UNFAVORITE"), 26);
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

        private void LabelDescription_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
        }
    }
}