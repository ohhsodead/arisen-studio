using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ModioX.Forms;
using ModioX.Forms.Dialogs;
using ModioX.Forms.Settings;
using ModioX.Forms.Windows;
using ModioX.Models.Release_Data;
using ModioX.Models.Resources;
using ModioX.Windows;

namespace ModioX.Extensions
{
    internal static class DialogExtensions
    {
        public static void ShowWhatsNewWindow(Form owner, GitHubData gitHubData)
        {
            try
            {
                var releaseBody = gitHubData.Body;
                var releaseBodyWithoutLastLine = releaseBody.Substring(0, releaseBody.Trim().LastIndexOf(Environment.NewLine));

                ShowDataViewDialog(owner, gitHubData.Name + " - What's New", "Change Log", releaseBodyWithoutLastLine.Replace("-", "•"));
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to load github release data.", ex);
            }
        }

        public static void ShowDataViewDialog(Form owner, string title, string subtitle, string body)
        {
            using (var dataViewDialog = new DataViewDialog {Text = title})
            {
                dataViewDialog.LabelTitle.Text = subtitle;
                dataViewDialog.LabelData.Text = body;

                dataViewDialog.MaximumSize = new Size(dataViewDialog.MaximumSize.Width, owner.Height + 100);
                dataViewDialog.Size = new Size(dataViewDialog.Width, dataViewDialog.Height + 15);
                dataViewDialog.ShowDialog(owner);
            }
        }

        public static string ShowListInputDialog(Form owner, string title, List<string> items)
        {
            using (var listViewDialog = new ListViewDialog { Text = title, Items = items })
            {
                listViewDialog.MinimumSize = new Size(items.Max(x => x.Length) + 225, listViewDialog.Height);
                listViewDialog.Size = new Size(items.Max(x => x.Length) + 225, listViewDialog.Height);
                listViewDialog.ShowDialog(owner);

                return listViewDialog.SelectedItem ?? "";
            }
        }

        public static string ShowTextInputDialog(Form owner, string title, string labelText, string inputText)
        {
            using (var inputDialog = new InputDialog {Text = title})
            {
                inputDialog.LabelName.Text = labelText;
                inputDialog.TextBoxName.Text = inputText;

                return inputDialog.ShowDialog(owner) == DialogResult.OK ? inputDialog.TextBoxName.Text.Trim() : null;
            }
        }

        public static ConsoleProfile ShowConnectionDialog(Form owner)
        {
            using (var connectConsole = new ConnectionDialog())
            {
                return connectConsole.ShowDialog(owner) == DialogResult.OK ? connectConsole.ConsoleProfile : null;
            }
        }

        public static ConsoleProfile ShowNewConnectionWindow(Form owner, ConsoleProfile consoleProfile, bool isEditingProfile)
        {
            using (var newConnectionDialog = new NewConnectionDialog { ConsoleProfile = consoleProfile, IsEditingProfile = isEditingProfile })
            {
                return newConnectionDialog.ShowDialog(owner) == DialogResult.OK ? newConnectionDialog.ConsoleProfile : null;
            }
        }

        public static void ShowGameBackupFiles(Form owner)
        {
            using (var gameBackupFilesWindow = new GameBackupFilesWindow())
            {
                _ = gameBackupFilesWindow.ShowDialog(owner);
            }
        }

        public static BackupFile ShowBackupFileDetails(Form owner, BackupFile backupFile)
        {
            using (var backupFileDialog = new BackupFileDialog {BackupFile = backupFile})
            {
                return backupFileDialog.ShowDialog(owner) == DialogResult.OK ? backupFileDialog.BackupFile : null;
            }
        }
        public static void ShowGameUpdatesFinderDialog(Form owner)
        {
            using (var gameUpdatesDialog = new GameUpdatesDialog())
            {
                _ = gameUpdatesDialog.ShowDialog(owner);
            }
        }

        public static void ShowFileManager(Form owner)
        {
            using (var fileManagerWindow = new FileManagerWindow())
            {
                _ = fileManagerWindow.ShowDialog(owner);
            }
        }

        public static void ShowSettingsWindow(Form owner)
        {
            using (var settingsWindow = new SettingsWindow())
            {
                _ = settingsWindow.ShowDialog(owner);
            }
        }

        public static void ShowAboutWindow(Form owner)
        {
            using (var aboutDialog = new AboutDialog())
            {
                _ = aboutDialog.ShowDialog(owner);
            }
        }

        public static string ShowFolderBrowseDialog(Form owner, string description)
        {
            using (var folderBrowser = new FolderBrowserDialog {Description = description, ShowNewFolderButton = true})
            {
                return folderBrowser.ShowDialog(owner) == DialogResult.OK ? folderBrowser.SelectedPath : null;
            }
        }

        public static void ShowGameRegionsDialog(Form owner)
        {
            using (var gameRegions = new GameRegionsDialog())
            {
                _ = gameRegions.ShowDialog(owner);
            }
        }

        public static void ShowExternalApplicationsDialog(Form owner)
        {
            using (var externalApplications = new ExternalApplicationsDialog())
            {
                _ = externalApplications.ShowDialog(owner);
            }
        }
    }
}