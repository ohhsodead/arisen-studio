using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Humanizer;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ArisenStudio.Forms.Tools.PS3
{
    public partial class GameUpdatesFinder : XtraForm
    {
        public GameUpdatesFinder()
        {
            InitializeComponent();
        }

        public static ResourceManager Language = MainWindow.ResourceLanguage;

        public static SettingsData Settings = MainWindow.Settings;

        private void GameUpdatesFinder_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("GAME_UPDATES_FINDER");

            ButtonSearch.Text = Language.GetString("LABEL_SEARCH");
            LabelHeaderTitleID.Text = Language.GetString("LABEL_TITLE_ID");
            LabelHeaderTitle.Text = Language.GetString("LABEL_TITLE") + ":";
            ButtonInstallFile.Text = Language.GetString("LABEL_INSTALL_FILE");
            ButtonDownloadFile.Text = Language.GetString("LABEL_DOWNLOAD_FILE");
            ButtonCopySHA1ToClipboard.Text = Language.GetString("LABEL_COPY_SHA1");
            ButtonCopyURLToClipboard.Text = Language.GetString("LABEL_COPY_URL");
            LabelStatus.Caption = Language.GetString("IDLE");
        }

        private DataTable GameUpdateFiles { get; } = DataExtensions.CreateDataTable(
        [
            new("URL", typeof(string)),
            new("SHA1", typeof(string)),
            new(Language.GetString("LABEL_FILE_NAME"), typeof(string)),
            new(Language.GetString("LABEL_VERSION"), typeof(string)),
            new(Language.GetString("LABEL_SIZE"), typeof(string)),
            new(Language.GetString("LABEL_MIN_FW"), typeof(string))
        ]);

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TextBoxTitleID.Text))
                {
                    XtraMessageBox.Show(Language.GetString("YOU_MUST_ENTER_TITLE_ID"), Language.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                SetStatus(Language.GetString("LABEL_SEARCHING"));

                Models.Game_Updates.Titlepatch gameUpdates = HttpExtensions.GetGameUpdatesFromTitleId(TextBoxTitleID.Text);

                if (gameUpdates == null)
                {
                    XtraMessageBox.Show(Language.GetString("INVALID_TITLE_ID"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GridGameUpdates.DataSource = null;

                    LabelTitle.Text = Regex.Replace(gameUpdates.Tag.Package.Last().Paramsfo.Title, @"\(.*?\)", string.Empty).Trim().Replace("Â®", "®"); // gameUpdates.Tag.Package.Last().Paramsfo.TITLE.Replace("Â®", "®"); 
                    gameUpdates.Tag.Package.Reverse();

                    foreach (Models.Game_Updates.Package update in gameUpdates.Tag.Package)
                    {
                        GameUpdateFiles.Rows.Add(
                            update.Url,
                            update.Sha1Sum,
                            Path.GetFileName(new Uri(update.Url).LocalPath),
                            update.Version.TrimStart('0'),
                            MainWindow.Settings.UseFormattedFileSizes
                                ? long.Parse(update.Size).Bytes().Humanize("#")
                                : update.Size + " " + Language.GetString("LABEL_BYTES"),
                            update.Ps3SystemVer.TrimStart('0').Substring(0, update.Ps3SystemVer.Length - 3));
                    }

                    GridGameUpdates.DataSource = GameUpdateFiles;

                    GridViewGameUpdates.Columns[0].Visible = false;
                    GridViewGameUpdates.Columns[1].Visible = false;
                    //GridViewGameUpdates.Columns[2].Width = 325;
                    GridViewGameUpdates.Columns[3].MinWidth = 70;
                    GridViewGameUpdates.Columns[3].MaxWidth = 70;
                    GridViewGameUpdates.Columns[4].MinWidth = 100;
                    GridViewGameUpdates.Columns[4].MaxWidth = 100;
                    GridViewGameUpdates.Columns[5].MinWidth = 60;
                    GridViewGameUpdates.Columns[5].MaxWidth = 60;

                    SetStatus(Language.GetString("LABEL_SEARCH_SUCCESS"));
                }
            }
            catch (Exception ex)
            {
                SetStatus(string.Format(Language.GetString("ERROR_OCCURRED"), ex.Message));
                XtraMessageBox.Show(this, string.Format(Language.GetString("ERROR_OCCURRED"), ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error, DefaultBoolean.True);
            }
        }

        private void GridViewGameUpdates_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ButtonDownloadFile.Enabled = GridViewGameUpdates.SelectedRowsCount > 0;
            ButtonInstallFile.Enabled = GridViewGameUpdates.SelectedRowsCount > 0 && MainWindow.IsConsoleConnected;
            ButtonCopyURLToClipboard.Enabled = GridViewGameUpdates.SelectedRowsCount > 0;
            ButtonCopySHA1ToClipboard.Enabled = GridViewGameUpdates.SelectedRowsCount > 0;
        }

        private void GridViewGameUpdates_RowClick(object sender, RowClickEventArgs e)
        {
            ButtonDownloadFile.Enabled = GridViewGameUpdates.SelectedRowsCount > 0;
            ButtonInstallFile.Enabled = GridViewGameUpdates.SelectedRowsCount > 0 && MainWindow.IsConsoleConnected;
            ButtonCopyURLToClipboard.Enabled = GridViewGameUpdates.SelectedRowsCount > 0;
            ButtonCopySHA1ToClipboard.Enabled = GridViewGameUpdates.SelectedRowsCount > 0;
        }

        private void ButtonInstallFile_Click(object sender, EventArgs e)
        {
            switch (GridViewGameUpdates.SelectedRowsCount)
            {
                case <= 0:
                    return;
            }

            if (MainWindow.IsConsoleConnected)
            {
                string updateUrl = GridViewGameUpdates.GetRowCellDisplayText(GridViewGameUpdates.FocusedRowHandle, GridViewGameUpdates.Columns[0]);
                string fileName = Path.GetFileName(updateUrl);
                string filePath = Settings.PathDownloads.GetFullPath(Settings.PathAppData) + "/" + fileName;

                SetStatus(string.Format(Language.GetString("FILE_DOWNLOADING"), fileName));
                HttpExtensions.DownloadFile(updateUrl, filePath);

                SetStatus(string.Format(Language.GetString("FILE_INSTALLING"), fileName));
                FtpExtensions.UploadFile(filePath, MainWindow.Settings.PackageInstallPathPS3 + fileName);
                SetStatus(Language.GetString("FILE_INSTALL_SUCCESS"));
                XtraMessageBox.Show(Language.GetString("FILE_INSTALL_SUCCESS"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(Language.GetString("YOU_MUST_BE_CONNECTED_TO_USE_FEATURE"), Language.GetString("NOT_CONNECTED"));
            }
        }

        private void ButtonDownloadFile_Click(object sender, EventArgs e)
        {
            string updateUrl = GridViewGameUpdates.GetRowCellDisplayText(GridViewGameUpdates.FocusedRowHandle, GridViewGameUpdates.Columns[0]);
            string fileName = Path.GetFileName(updateUrl);
            string folderPath = DialogExtensions.ShowFolderBrowseDialog(this, Language.GetString("CHOOSE_FOLDER_LOCATION"));

            if (folderPath != null)
            {
                SetStatus(string.Format(Language.GetString("FILE_DOWNLOADING"), fileName));
                HttpExtensions.DownloadFile(updateUrl, folderPath + "/" + fileName);
                SetStatus(Language.GetString("FILE_DOWNLOAD_SUCCESS"));
                XtraMessageBox.Show(Language.GetString("FILE_DOWNLOAD_SUCCESS"), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonCopyURLToClipboard_Click(object sender, EventArgs e)
        {
            string updateUrl = GridViewGameUpdates.GetRowCellDisplayText(GridViewGameUpdates.FocusedRowHandle, GridViewGameUpdates.Columns[0]);
            Clipboard.SetText(updateUrl);
            XtraMessageBox.Show(Language.GetString("COPIED_URL"), Language.GetString("LABEL_COPIED"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonCopySHA1ToClipboard_Click(object sender, EventArgs e)
        {
            string updateSha1 = GridViewGameUpdates.GetRowCellDisplayText(GridViewGameUpdates.FocusedRowHandle, GridViewGameUpdates.Columns[1]);
            Clipboard.SetText(updateSha1);
            XtraMessageBox.Show(Language.GetString("COPIED_SHA1"), Language.GetString("LABEL_COPIED"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// </summary>
        /// <param name="text"> </param>
        /// <param name="ex"> </param>
        private void SetStatus(string text, Exception ex = null)
        {
            LabelStatus.Caption = text;
            LabelStatus.Refresh();

            if (ex == null)
            {
                Program.Log.Info(text);
            }
            else
            {
                Program.Log.Error(ex, text);
            }
        }
    }
}