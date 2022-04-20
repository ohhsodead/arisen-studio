using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Modio.Database;
using Modio.Extensions;
using Modio.Forms.Windows;
using Modio.Models.Database;
using Modio.Models.Resources;
using Modio.Templates;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Windows.Forms;

namespace Modio.Forms.Dialogs.Details
{
    public partial class GameModDialog : XtraForm
    {
        public GameModDialog()
        {
            InitializeComponent();
        }

        public SettingsData Settings = MainWindow.Settings;
        public ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public ResourceManager Language = MainWindow.ResourceLanguage;
        public CategoriesData Categories = MainWindow.Database.CategoriesData;

        public ModItemData ModItem;

        private void GameModDialog_Load(object sender, EventArgs e)
        {
            // Display details in UI
            LabelCategory.Text = Categories.GetCategoryById(ModItem.CategoryId).Title;
            LabelName.Text = ModItem.Name.Replace("&", "&&");
            LabelModType.Text = ModItem.ModType;
            LabelSystemType.Text = ModItem.FirmwareType;
            LabelVersion.Text = string.Join(" & ", ModItem.Versions).Replace("&", "&&");
            LabelRegion.Text = string.Join(", ", ModItem.Regions);
            LabelCreatedBy.Text = ModItem.CreatedBy.Replace("&", "&&");
            LabelSubmittedBy.Text = ModItem.SubmittedBy.Replace("&", "&&");
            LabelGameMode.Text = string.Join(", ", ModItem.GameModes);
            LabelDescription.Text = string.IsNullOrWhiteSpace(ModItem.Description)
                ? Language.GetString("NO_MORE_DETAILS")
                : ModItem.Description.Replace("&", "&&");

            InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? MainWindow.Settings.GetInstalledMods(ConsoleProfile, ModItem.CategoryId, ModItem.Id) : null;

            if (installedModInfo == null)
            {
                ButtonActions.SetControlText(MainWindow.ResourceLanguage.GetString("LABEL_NOT_INSTALLED"), 26);
                ButtonActions.ImageOptions.SvgImage = Images[0];
            }
            else
            {
                ButtonActions.SetControlText(MainWindow.ResourceLanguage.GetString("LABEL_INSTALLED"), 26);
                ButtonActions.ImageOptions.SvgImage = Images[1];
            }

            if (Settings.FavoriteModsPS3.Contains(ModItem.Id))
            {
                ButtonFavorite.SetControlText(Language.GetString("LABEL_UNFAVORITE"), 26);
            }
            else
            {
                ButtonFavorite.SetControlText(Language.GetString("LABEL_FAVORITE"), 26);;
            }

            if (ModItem.ModType.Equals("SCRIPT"))
            {
                ButtonActions.Enabled = false;

                LabelDescription.Text += "\n\n" + Language.GetString("SCRIPT_CANT_BE_INSTALLED");
            }

            LabelHeaderSystemType.Text = Language.GetString("LABEL_SYSTEM_TYPE");
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
                InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? MainWindow.Settings.GetInstalledMods(ConsoleProfile, ModItem.CategoryId, ModItem.Id) : null;

                bool isInstalled = installedModInfo != null && installedModInfo.ModId.Equals(ModItem.Id);

                MenuItemInstallFiles.Caption = isInstalled ? $"{Language.GetString("UNINSTALL_FILES")}..." : $"{Language.GetString("INSTALL_FILES")}...";
                MenuItemInstallFiles.Enabled = MainWindow.Settings.InstallGameModsPluginsToUsbDevice | MainWindow.IsConsoleConnected;
            }
        }

        private void MenuItemInstallFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            InstalledModInfo installedModInfo = MainWindow.ConsoleProfile != null ? MainWindow.Settings.GetInstalledMods(ConsoleProfile, ModItem.CategoryId, ModItem.Id) : null;
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
            GitHubTemplates.OpenReportTemplate(Categories.GetCategoryById(ModItem.CategoryId), ModItem);
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (Settings.FavoriteModsPS3.Contains(ModItem.Id))
            {
                Settings.RemoveFavoriteForPS3(ModItem.Id);
                ButtonFavorite.SetControlText(Language.GetString("LABEL_FAVORITE"), 26);;
            }
            else
            {
                Settings.AddFavoriteForPS3(ModItem.Id);
                ButtonFavorite.SetControlText(Language.GetString("LABEL_UNFAVORITE"), 26);
            }
        }

        private void LabelDescription_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process.Start(e.Link);
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