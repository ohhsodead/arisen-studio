using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Modio.Extensions;
using Modio.Forms.Windows;
using Modio.Models.Database;
using Modio.Models.Resources;
using Modio.Templates;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Modio.Forms.Dialogs.Details
{
    public partial class GameSaveDialog : XtraForm
    {
        public GameSaveDialog()
        {
            InitializeComponent();
        }

        public SettingsData Settings = MainWindow.Settings;
        public ConsoleProfile ConsoleProfile = MainWindow.ConsoleProfile;
        public ResourceManager Language = MainWindow.ResourceLanguage;
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
                ? Language.GetString("NO_MORE_DETAILS")
                : GameSaveItem.Description.Replace("&", "&&");

            StringBuilder extraDescription = new StringBuilder("\n---------------------------------------------\n")
                            .AppendLine("Important Information:\n")
                            .AppendLine("- You must have at least one USB device connected to the console before installing the game save files.\n")
                            .Append("- It's suggested to use 'Apollo Tool' (Homebrew Applications) for patching and resigning game save files directly on your console.");

            LabelDescription.Text += extraDescription.ToString();

            ButtonInstall.SetControlText(Language.GetString("LABEL_INSTALL"), 26);

            if (Settings.FavoriteGameSaves.Contains(GameSaveItem.Id))
            {
                ButtonFavorite.SetControlText(Language.GetString("LABEL_UNFAVORITE"), 26);
            }
            else
            {
                ButtonFavorite.SetControlText(Language.GetString("LABEL_FAVORITE"), 26); ;
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
            MenuItemInstallFiles.Caption = Language.GetString("INSTALL_FILES");
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
            XtraMessageBox.Show(Language.GetString("REDIRECT_TO_GITHUB_ISSUES"), Language.GetString("REDIRECTING"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            GitHubTemplates.OpenReportTemplateGameSave(Categories.GetCategoryById(GameSaveItem.CategoryId), GameSaveItem);
        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            if (Settings.FavoriteGameSaves.Contains(GameSaveItem.Id))
            {
                Settings.FavoriteGameSaves.RemoveAll(x => x == GameSaveItem.Id);
                ButtonFavorite.SetControlText(Language.GetString("LABEL_FAVORITE"), 26);;
            }
            else
            {
                Settings.FavoriteGameSaves.Add(GameSaveItem.Id);
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