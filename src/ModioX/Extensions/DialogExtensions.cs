using ModioX.Forms;
using ModioX.Forms.Dialogs;
using ModioX.Forms.Windows;
using ModioX.Models.Release_Data;
using ModioX.Models.Resources;
using ModioX.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    internal static class DialogExtensions
    {
        public static void ShowWhatsNewWindow(Form owner, GitHubData gitHubData)
        {
            try
            {
                string releaseBody = gitHubData.Body;
                string releaseBodyWithoutLastLine = releaseBody.Substring(0, releaseBody.Trim().LastIndexOf(Environment.NewLine));

                ShowDataViewDialog(owner, gitHubData.Name + " - What's New", "Change Log", releaseBodyWithoutLastLine.Replace("-", "•"));
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to load github release data.", ex);
            }
        }

        public static void ShowDataViewDialog(Form owner, string title, string subtitle, string body)
        {
            using (DataViewDialog dataViewDialog = new DataViewDialog { Text = title })
            {
                dataViewDialog.LabelTitle.Text = subtitle;
                dataViewDialog.LabelData.Text = body;

                dataViewDialog.MaximumSize = new Size(dataViewDialog.MaximumSize.Width, owner.Height + 100);
                dataViewDialog.Size = new Size(dataViewDialog.Width, dataViewDialog.Height + 15);
                _ = dataViewDialog.ShowDialog(owner);
            }
        }

        public static string ShowListInputDialog(Form owner, string title, List<string> items)
        {
            using (ListItemDialog listViewDialog = new ListItemDialog() { Text = title, Items = items })
            {
                return listViewDialog.ShowDialog(owner) == DialogResult.OK ? listViewDialog.SelectedItem : null;
            }
        }

        public static string ShowTextInputDialog(Form owner, string title, string labelText, string inputText)
        {
            using (InputDialog inputDialog = new InputDialog() { Text = title })
            {
                inputDialog.LabelName.Text = labelText;
                inputDialog.TextBoxName.Text = inputText;

                return inputDialog.ShowDialog(owner) == DialogResult.OK ? inputDialog.TextBoxName.Text : null;
            }
        }

        public static ConsoleProfile ShowConnectionDialog(Form owner)
        {
            using (ConnectionDialog connectConsole = new ConnectionDialog())
            {
                return connectConsole.ShowDialog(owner) == DialogResult.OK ? connectConsole.ConsoleProfile : null;
            }
        }

        public static ConsoleProfile ShowNewConnectionWindow(Form owner, ConsoleProfile consoleProfile, bool isEditingProfile)
        {
            using (NewConnectionDialog newConnectionDialog = new NewConnectionDialog() { ConsoleProfile = consoleProfile, IsEditingProfile = isEditingProfile })
            {
                return newConnectionDialog.ShowDialog(owner) == DialogResult.OK ? newConnectionDialog.ConsoleProfile : null;
            }
        }

        public static void ShowGameBackupFiles(Form owner)
        {
            using (GameBackupFilesWindow gameBackupFilesWindow = new GameBackupFilesWindow())
            {
                _ = gameBackupFilesWindow.ShowDialog(owner);
            }
        }

        public static BackupFile ShowBackupFileDetails(Form owner, BackupFile backupFile)
        {
            using (BackupFileDialog backupFileDialog = new BackupFileDialog() { BackupFile = backupFile })
            {
                return backupFileDialog.ShowDialog(owner) == DialogResult.OK ? backupFileDialog.BackupFile : null;
            }
        }

        public static void ShowFileManager(Form owner)
        {
            using (FileManagerWindow fileManager = new FileManagerWindow())
            {
                _ = fileManager.ShowDialog(owner);
            }
        }

        public static void ShowAboutWindow(Form owner)
        {
            using (AboutDialog aboutDialog = new AboutDialog())
            {
                _ = aboutDialog.ShowDialog(owner);
            }
        }

        public static string ShowFolderBrowseDialog(Form owner, string description)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog() { Description = description, ShowNewFolderButton = true })
            {
                return folderBrowser.ShowDialog(owner) == DialogResult.OK ? folderBrowser.SelectedPath : null;
            }
        }

        public static void ShowGameRegionsDialog(Form owner)
        {
            using (GameRegionsDialog gameRegions = new GameRegionsDialog())
            {
                _ = gameRegions.ShowDialog(owner);
            }
        }

        public static void ShowExternalApplicationsDialog(Form owner)
        {
            using (ExternalApplicationsDialog externalApplications = new ExternalApplicationsDialog())
            {
                _ = externalApplications.ShowDialog(owner);
            }
        }

        public static void ShowRequestModsWindow(Form owner)
        {
            using (RequestModsWindow requestMods = new RequestModsWindow())
            {
                _ = requestMods.ShowDialog(owner);
            }
        }
    }
}