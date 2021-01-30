using DevExpress.XtraEditors;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Forms.Tools.PS3_Tools
{
    public partial class GameUpdatesFinder : XtraForm
    {
        public GameUpdatesFinder()
        {
            InitializeComponent();
        }

        private string RetailUpdatesURL => "https://a0.ww.np.dl.playstation.net/tpl/np/";

        private string DebugUpdatesURL => "https://a0.ww.sp-int.dl.playstation.net/tpl/sp-int/";

        private string UpdateTypeURL { get; set; }

        private void GameUpdatesFinder_Load(object sender, EventArgs e)
        {
            ComboBoxType.SelectedIndex = 0;
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxType.SelectedIndex)
            {
                case 0:
                    UpdateTypeURL = RetailUpdatesURL;
                    break;
                case 1:
                    UpdateTypeURL = DebugUpdatesURL;
                    break;
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxTitleID.Text))
            {
                XtraMessageBox.Show("You haven't specified a title ID.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string gameTitle = HttpExtensions.GetGameTitleFromTitleID(TextBoxTitleID.Text);
            Models.Game_Updates.Titlepatch gameUpdates = HttpExtensions.GetGameUpdatesFromTitleID(UpdateTypeURL, TextBoxTitleID.Text);

            if (gameUpdates == null)
            {
                XtraMessageBox.Show("Unable to find details for this title ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GridGameUpdates.DataSource = null;

                DataTable gameUpdateFiles = DataExtensions.CreateDataTable(new List<DataColumn>()
                {
                    new DataColumn("File Name", typeof(string)),
                    new DataColumn("File Size", typeof(string)),
                    new DataColumn("File Size", typeof(string)),
                    new DataColumn("File Size", typeof(string)),
                    new DataColumn(" ", typeof(string))
                });


                foreach (var update in gameUpdates.Tag.Package)
                {
                    gameUpdateFiles.Rows.Add(update.Url,
                                            update.Sha1sum,
                                            gameTitle,
                                            "v" + update.Version.RemoveFirstInstanceOfString("0"),
                                            MainWindow.Settings.ShowFileSizeInBytes ? long.Parse(update.Size).ToString("#,0") + " bytes" : update.Size.FormatSize(),
                                            "v" + update.Ps3_system_ver.RemoveFirstInstanceOfString("0").Replace("000", "00"),
                                            ImageExtensions.ResizeBitmap(Properties.Resources.install, 20, 20),
                                            ImageExtensions.ResizeBitmap(Properties.Resources.download_from_the_cloud, 20, 20));
                }

                GridGameUpdates.DataSource = gameUpdateFiles;

                GridViewGameUpdates.Columns[0].Visible = false;
                GridViewGameUpdates.Columns[1].Visible = false;
                GridViewGameUpdates.Columns[2].Width = 350;
                GridViewGameUpdates.Columns[3].Width = 350;
                GridViewGameUpdates.Columns[4].Width = 350;
                GridViewGameUpdates.Columns[5].Width = 125;
            }

            ProgressNoGameUpdatesFound.Visible = GridViewGameUpdates.RowCount < 1;
        }

        private void DgvGameUpdates_SelectionChanged(object sender, EventArgs e)
        {
            //ContextMenuDownloadToComputer.Enabled = DgvGameUpdates.CurrentRow != null;
            //ContextMenuInstallToConsole.Enabled = DgvGameUpdates.CurrentRow != null;
            //ContextMenuCopyURLToClipboard.Enabled = DgvGameUpdates.CurrentRow != null;
            //ContextMenuCopySHA1ToClipboard.Enabled = DgvGameUpdates.CurrentRow != null;
        }

        private void DgvGameUpdates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (DgvGameUpdates.CurrentRow != null)
            {
                if (DgvGameUpdates.CurrentCell.ColumnIndex.Equals(6))
                {
                    InstallToConsole();
                }
                else if (DgvGameUpdates.CurrentCell.ColumnIndex.Equals(7))
                {
                    DownloadToComputer();
                }
            }
            */
        }

        private void UpdateStatus(string text)
        {
            ToolStripLabelStatus.Text = text;
            Refresh();
        }

        private void ButtonInstallToConsole_Click(object sender, EventArgs e)
        {
            if (DgvGameUpdates.CurrentRow != null)
            {
                if (MainWindow.IsConsoleConnected)
                {
                    string updateUrl = DgvGameUpdates.CurrentRow.Cells[0].Value.ToString();
                    string fileName = Path.GetFileName(updateUrl);
                    string filePath = KnownFolders.GetPath(KnownFolder.Downloads) + "/" + fileName;

                    UpdateStatus("Downloading file: " + fileName);
                    HttpExtensions.DownloadFile(updateUrl, filePath);

                    UpdateStatus("Installing file: " + fileName);
                    FtpExtensions.UploadFile(filePath, "/dev_hdd0/packages/" + fileName);
                    UpdateStatus("Successfully installed package file to your Packages folder.");
                }
                else
                {
                    XtraMessageBox.Show("You must be connected to your console to install the update package file.", "Not Connected");
                }
            }
        }

        private void ButtonDownloadFile_Click(object sender, EventArgs e)
        {
            string updateUrl = DgvGameUpdates.CurrentRow.Cells[0].Value.ToString();
            string fileName = Path.GetFileName(updateUrl);
            string folderPath = DialogExtensions.ShowFolderBrowseDialog(this, "Select the folder where you want to download the game update package.");

            if (folderPath != null)
            {
                UpdateStatus("Downloading package: " + fileName);
                HttpExtensions.DownloadFile(updateUrl, folderPath + "/" + fileName);
                UpdateStatus("Successfully downloaded package file to the specified folder.");
            }
        }

        private void ButtonCopyURLToClipboard_Click(object sender, EventArgs e)
        {
            string updateUrl = DgvGameUpdates.CurrentRow.Cells[0].Value.ToString();
            Clipboard.SetText(updateUrl);
            XtraMessageBox.Show("Update URL has been copied to clipboard.", "Copied");
        }

        private void ButtonCopySHA1ToClipboard_Click(object sender, EventArgs e)
        {
            string updateSHA1 = DgvGameUpdates.CurrentRow.Cells[1].Value.ToString();
            Clipboard.SetText(updateSHA1);
            XtraMessageBox.Show("Update SHA1 has been copied to clipboard.", "Copied");
        }
    }
}