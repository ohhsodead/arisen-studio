using System;
using System.ComponentModel;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using ModioX.Database;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Models.Database;
using ModioX.Models.Resources;
using ModioX.Templates;

namespace ModioX.Forms.Dialogs.Details
{
    public partial class ResourceDialog : XtraForm
    {
        public ResourceDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;
        public SettingsData Settings = MainWindow.Settings;
        public CategoriesData Categories = MainWindow.Database.CategoriesData;

        public ModItemData ModItem;

        private void ResourceDialog_Load(object sender, EventArgs e)
        {
            // Display details in UI
            LabelCategory.Text = Categories.GetCategoryById(ModItem.CategoryId).Title;
            LabelName.Text = ModItem.Name.Replace("&", "&&");
            LabelSystemType.Text = ModItem.FirmwareType;
            LabelVersion.Text = string.Join(" & ", ModItem.Versions).Replace("&", "&&");
            LabelCreatedBy.Text = ModItem.CreatedBy.Replace("&", "&&");
            LabelSubmittedBy.Text = ModItem.SubmittedBy.Replace("&", "&&");
            LabelModType.Text = ModItem.ModType;
            LabelDescription.Text = string.IsNullOrWhiteSpace(ModItem.Description)
                ? "No other details can be found for this yet."
                : ModItem.Description.Replace("&", "&&");

            if (MainWindow.Settings.FavoriteIds.Exists(x => x.Platform == PlatformPrefix.PS3 && x.Ids.Contains(ModItem.Id)))
            {
                ButtonFavorite.Text = Language.GetString("Unfavorite");
                ButtonFavorite.SetControlTextWidth(30);
            }
            else
            {
                ButtonFavorite.Text = Language.GetString("Favorite");
                ButtonFavorite.SetControlTextWidth(28);
            }
        }

        private void ImageCloseDetails_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuActions_BeforePopup(object sender, CancelEventArgs e)
        {
            if (ModItem != null)
            {
                MenuItemInstallFiles.Caption = Language.GetString("Install Files");
                MenuItemInstallFiles.Enabled = Settings.InstallResourcesToUsbDevice | MainWindow.IsConsoleConnected;
            }
        }

        private void MenuItemInstallFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowTransferModsDialog(this, TransferType.InstallMods, ModItem.GetCategory(Categories), ModItem);
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferModsDialog(this, TransferType.DownloadMods, ModItem.GetCategory(Categories), ModItem);
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder()
                .Append("You will now be redirected to our GitHub Issues page for ModioX. All details will be automatically filled for you. Please provide information about the issue to help us fix your problem.\n")
                .AppendLine("Click the 'Submit' button to open a new issue which can help us fix any problems.");

            XtraMessageBox.Show(message.ToString(), "Opening GitHub Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GitHubTemplates.OpenReportTemplate(Categories.GetCategoryById(ModItem.CategoryId), ModItem);
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (MainWindow.Settings.FavoriteIds.Exists(x => x.Platform == PlatformPrefix.PS3 && x.Ids.Contains(ModItem.Id)))
            {
                MainWindow.Settings.RemoveFavorite(PlatformPrefix.PS3, ModItem.Id);
                ButtonFavorite.Text = Language.GetString("Favorite");
                ButtonFavorite.SetControlTextWidth(28);
            }
            else
            {
                MainWindow.Settings.AddFavorite(PlatformPrefix.PS3, ModItem.Id);
                ButtonFavorite.Text = Language.GetString("Unfavorite");
                ButtonFavorite.SetControlTextWidth(30);
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