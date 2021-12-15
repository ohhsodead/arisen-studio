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
    public partial class GameSaveDialog : XtraForm
    {
        public GameSaveDialog()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;
        public SettingsData Settings = MainWindow.Settings;
        public CategoriesData Categories = MainWindow.Database.CategoriesData;

        public GameSaveItemData GameSaveItem;

        private void GameSaveDialog_Load(object sender, EventArgs e)
        {
            // Display details in UI
            LabelName.Text = GameSaveItem.Name.Replace("&", "&&");
            LabelCategory.Text = Categories.GetCategoryById(GameSaveItem.CategoryId).Title;
            LabelVersion.Text = GameSaveItem.Version;
            LabelRegion.Text = GameSaveItem.Region;
            LabelGameMode.Text = GameSaveItem.GameMode;
            LabelCreatedBy.Text = GameSaveItem.CreatedBy.Replace("&", "&&");
            LabelSubmittedBy.Text = GameSaveItem.SubmittedBy.Replace("&", "&&");
            LabelDescription.Text = string.IsNullOrWhiteSpace(GameSaveItem.Description)
                ? "No other details can be found for this yet."
                : GameSaveItem.Description.Replace("&", "&&");

            StringBuilder extraDescription = new StringBuilder("\n---------------------------------------------\n")
                            .AppendLine("Important Information:\n")
                            .AppendLine("- You must have at least one USB device connected to the console before installing the game save files.\n")
                            .Append("- It's suggested to use 'Apollo Tool' (Homebrew > Applications) for patching and resigning game save files directly on your console.");

            LabelDescription.Text += extraDescription.ToString();

            InstalledModInfo installedModInfo = MainWindow.Settings.GetInstalledMods(GameSaveItem.GetPlatform(), GameSaveItem.CategoryId, GameSaveItem.Id);

            if (installedModInfo == null)
            {
                ButtonActions.Text = Language.GetString("Not Installed");
                ButtonActions.ImageOptions.SvgImage = Images[0];
                ButtonActions.SetControlTextWidth(34);
            }
            else
            {
                ButtonActions.Text = Language.GetString("Installed");
                ButtonActions.ImageOptions.SvgImage = Images[1];
                ButtonActions.SetControlTextWidth(32);
            }

            if (MainWindow.Settings.FavoriteIds.Exists(x => x.Platform == MainWindow.PlatformType && x.Ids.Contains(GameSaveItem.Id)))
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
            MenuItemInstallFiles.Caption = Language.GetString("Install Files");
            MenuItemInstallFiles.Enabled = MainWindow.Settings.InstallHomebrewToUsbDevice | MainWindow.IsConsoleConnected;
        }

        private void MenuItemInstallFiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogExtensions.ShowTransferGameSavesDialog(this, TransferType.InstallGameSave, Categories.GetCategoryById(GameSaveItem.CategoryId), GameSaveItem);
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            DialogExtensions.ShowTransferGameSavesDialog(this, TransferType.DownloadGameSave, Categories.GetCategoryById(GameSaveItem.CategoryId), GameSaveItem);

        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder()
                .Append("You will now be redirected to our GitHub Issues page for ModioX. All details will be automatically filled for you. Please provide information about the issue to help us fix your problem.\n")
                .AppendLine("Click the 'Submit' button to open a new issue which can help us fix any problems.");

            XtraMessageBox.Show(message.ToString(), "Opening GitHub Issues", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GitHubTemplates.OpenReportTemplateGameSave(Categories.GetCategoryById(GameSaveItem.CategoryId), GameSaveItem);
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (MainWindow.Settings.FavoriteIds.Exists(x => x.Platform == MainWindow.PlatformType && x.Ids.Contains(GameSaveItem.Id)))
            {
                MainWindow.Settings.RemoveFavorite(MainWindow.PlatformType, GameSaveItem.Id);
                ButtonFavorite.Text = Language.GetString("Favorite");
                ButtonFavorite.SetControlTextWidth(28);
            }
            else
            {
                MainWindow.Settings.AddFavorite(MainWindow.PlatformType, GameSaveItem.Id);
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