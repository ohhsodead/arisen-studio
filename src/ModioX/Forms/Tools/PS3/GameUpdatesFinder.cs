using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Humanizer;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using ModioX.Io;
using ModioX.Models.Game_Updates;

namespace ModioX.Forms.Tools.PS3
{
    public partial class GameUpdatesFinder : XtraForm
    {
        public GameUpdatesFinder()
        {
            InitializeComponent();
        }

        private void GameUpdatesFinder_Load(object sender, EventArgs e)
        {
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxTitleID.Text))
            {
                XtraMessageBox.Show("You haven't specified a title ID.", "Empty Field", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            SetStatus("Searching for game updates...");

            Titlepatch gameUpdates = HttpExtensions.GetGameUpdatesFromTitleID(TextBoxTitleID.Text);

            switch (gameUpdates)
            {
                case null:
                    XtraMessageBox.Show("Unable to find details for this title ID.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
                default:
                    {
                        GridGameUpdates.DataSource = null;

                        DataTable gameUpdateFiles = DataExtensions.CreateDataTable(new List<DataColumn>
                    {
                        new("File URL", typeof(string)),
                        new("File SHA1", typeof(string)),
                        new("File Name", typeof(string)),
                        new("File Version", typeof(string)),
                        new("File Size", typeof(string)),
                        new("System Version", typeof(string))
                    });

                        string gameTitle = Regex.Replace(gameUpdates.Tag.Package.Last().Paramsfo.TITLE, @"\(.*?\)", "").Trim().Replace("Â®", "®");
                        gameUpdates.Tag.Package.Reverse();

                        foreach (Package update in gameUpdates.Tag.Package)
                        {
                            gameUpdateFiles.Rows.Add(
                                update.Url,
                                update.Sha1sum,
                                gameTitle,
                                "v" + update.Version.RemoveFirstInstanceOfString("0"),
                                MainWindow.Settings.UseFormattedFileSizes
                                    ? long.Parse(update.Size).Bytes().Humanize("#")
                                    : update.Size + " Bytes",
                                "v" + update.Ps3_system_ver.RemoveFirstInstanceOfString("0").Replace("000", "00"));
                        }

                        GridGameUpdates.DataSource = gameUpdateFiles;

                        GridViewGameUpdates.Columns[0].Visible = false;
                        GridViewGameUpdates.Columns[1].Visible = false;
                        //GridViewGameUpdates.Columns[2].Width = 325;
                        GridViewGameUpdates.Columns[3].Width = 52;
                        GridViewGameUpdates.Columns[4].Width = 85;
                        GridViewGameUpdates.Columns[5].Width = 55;
                        break;
                    }
            }
        }

        private void GridViewGameUpdates_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ButtonDownloadToComputer.Enabled = GridViewGameUpdates.SelectedRowsCount > 0;
            ButtonInstallToConsole.Enabled = GridViewGameUpdates.SelectedRowsCount > 0 && MainWindow.IsConsoleConnected;
            ButtonCopyURLToClipboard.Enabled = GridViewGameUpdates.SelectedRowsCount > 0;
            ButtonCopySHA1ToClipboard.Enabled = GridViewGameUpdates.SelectedRowsCount > 0;
        }

        private void GridViewGameUpdates_RowClick(object sender, RowClickEventArgs e)
        {
            ButtonDownloadToComputer.Enabled = GridViewGameUpdates.SelectedRowsCount > 0;
            ButtonInstallToConsole.Enabled = GridViewGameUpdates.SelectedRowsCount > 0 && MainWindow.IsConsoleConnected;
            ButtonCopyURLToClipboard.Enabled = GridViewGameUpdates.SelectedRowsCount > 0;
            ButtonCopySHA1ToClipboard.Enabled = GridViewGameUpdates.SelectedRowsCount > 0;
        }

        private void ButtonInstallToConsole_Click(object sender, EventArgs e)
        {
            switch (GridViewGameUpdates.SelectedRowsCount)
            {
                case <= 0:
                    return;
            }

            switch (MainWindow.IsConsoleConnected)
            {
                case true:
                    {
                        string updateUrl = GridViewGameUpdates.GetRowCellDisplayText(GridViewGameUpdates.FocusedRowHandle, GridViewGameUpdates.Columns[0]);
                        string fileName = Path.GetFileName(updateUrl);
                        string filePath = KnownFolders.GetPath(KnownFolder.Downloads) + "/" + fileName;

                        SetStatus("Downloading file: " + fileName);
                        HttpExtensions.DownloadFile(updateUrl, filePath);

                        SetStatus("Installing file: " + fileName);
                        FtpExtensions.UploadFile(filePath, MainWindow.Settings.PackagesInstallPath + fileName);
                        SetStatus("Successfully installed package file to your Packages folder.");
                        XtraMessageBox.Show("Successfully installed package file to your Packages folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                default:
                    XtraMessageBox.Show("You must be connected to your console to install the update package file.",
                        "Not Connected");
                    break;
            }
        }

        private void ButtonDownloadFile_Click(object sender, EventArgs e)
        {
            string updateUrl = GridViewGameUpdates.GetRowCellDisplayText(GridViewGameUpdates.FocusedRowHandle, GridViewGameUpdates.Columns[0]);
            string fileName = Path.GetFileName(updateUrl);
            string folderPath = DialogExtensions.ShowFolderBrowseDialog(this,
                "Select the folder where you want to download the game update package.");

            if (folderPath != null)
            {
                SetStatus("Downloading package: " + fileName);
                HttpExtensions.DownloadFile(updateUrl, folderPath + "/" + fileName);
                SetStatus("Successfully downloaded package file to the specified folder.");
                XtraMessageBox.Show("Successfully downloaded package file to the specified folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonCopyURLToClipboard_Click(object sender, EventArgs e)
        {
            string updateUrl = GridViewGameUpdates.GetRowCellDisplayText(GridViewGameUpdates.FocusedRowHandle, GridViewGameUpdates.Columns[0]);
            Clipboard.SetText(updateUrl);
            XtraMessageBox.Show("Update URL has been copied to clipboard.", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonCopySHA1ToClipboard_Click(object sender, EventArgs e)
        {
            string updateSHA1 = GridViewGameUpdates.GetRowCellDisplayText(GridViewGameUpdates.FocusedRowHandle, GridViewGameUpdates.Columns[1]);
            Clipboard.SetText(updateSHA1);
            XtraMessageBox.Show("Update SHA1 has been copied to clipboard.", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// </summary>
        /// <param name="text"></param>
        private void SetStatus(string text)
        {
            LabelStatus.Caption = text;
            LabelStatus.Refresh();
        }
    }
}