using ModioX.Forms;
using ModioX.Forms.Dialogs;
using ModioX.Forms.Settings;
using ModioX.Forms.Tools.PS3_Tools;
using ModioX.Forms.Tools.XBOX_Tools;
using ModioX.Forms.Windows;
using ModioX.Models.Release_Data;
using ModioX.Models.Resources;
using ModioX.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using XDevkit;

namespace ModioX.Extensions
{
    internal static class DialogExtensions
    {
        public static void ShowWhatsNewWindow(Form owner, GitHubData gitHubData)
        {
            try
            {
                var releaseBody = gitHubData.Body;
                var releaseBodyWithoutLastLine = releaseBody.Substring(0, releaseBody.Trim().LastIndexOf(Environment.NewLine, StringComparison.Ordinal));

                ShowDataViewDialog(owner, gitHubData.Name + " - What's New", "Change Log", releaseBodyWithoutLastLine.Replace("-", "•"));
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to fetch release data from GitHub.");
            }
        }

        public static void ShowDataViewDialog(Form owner, string title, string subtitle, string body)
        {
            using var dataViewDialog = new DataViewDialog { Text = title };
            dataViewDialog.LabelTitle.Text = subtitle;
            dataViewDialog.LabelBody.Text = body;

            dataViewDialog.MaximumSize = new Size(dataViewDialog.MaximumSize.Width, owner.Height + 100);
            dataViewDialog.Size = new Size(dataViewDialog.Width, dataViewDialog.Height + 15);
            dataViewDialog.ShowDialog(owner);
        }

        public static string ShowListInputDialog(string title, List<string> items)
        {
            using var listViewDialog = new ListViewDialog
            {
                Text = title,
                Items = items
            };

            listViewDialog.ShowDialog();
            return listViewDialog.SelectedItem ?? "";
        }

        public static string ShowTextInputDialog(Form owner, string title, string labelText, string inputText)
        {
            using var inputTextDialog = new InputTextDialog
            {
                Text = title,
                LabelName = { Text = labelText },
                TextBoxName = { Text = inputText }
            };

            return inputTextDialog.ShowDialog(owner) == DialogResult.OK ? inputTextDialog.TextBoxName.Text.Trim() : null;
        }

        public static ConsoleProfile ShowConnectionDialog(Form owner)
        {
            using var connectConsole = new ConnectionDialog();
            return connectConsole.ShowDialog(owner) == DialogResult.OK ? connectConsole.ConsoleProfile : null;
        }

        public static ConsoleProfile ShowNewConnectionWindow(Form owner, ConsoleProfile consoleProfile, bool isEditing)
        {
            using var newConnectionDialog = new NewConnectionDialog { ConsoleProfile = consoleProfile, IsEditingProfile = isEditing };
            return newConnectionDialog.ShowDialog(owner) == DialogResult.OK ? newConnectionDialog.ConsoleProfile : null;
        }

        public static void ShowGameBackupFiles(Form owner)
        {
            using var gameBackupFilesWindow = new GameBackupFilesWindow();
            gameBackupFilesWindow.ShowDialog(owner);
        }

        public static BackupFile ShowBackupFileDetails(Form owner, BackupFile backupFile)
        {
            using var backupFileDialog = new BackupFileDialog { BackupFile = backupFile };
            return backupFileDialog.ShowDialog(owner) == DialogResult.OK ? backupFileDialog.BackupFile : null;
        }
        public static void ShowGameUpdatesFinderDialog(Form owner)
        {
            using var gameUpdatesDialog = new GameUpdatesWindow();
            gameUpdatesDialog.ShowDialog(owner);
        }

        public static void ShowPackageManagerWindow(Form owner)
        {
            using var packageManagerWindow = new PackageManagerWindow();
            packageManagerWindow.ShowDialog(owner);
        }

        public static void ShowFileManagerPS3(Form owner)
        {
            using var fileManagerWindow = new Forms.Tools.PS3_Tools.FileManagerWindow();
            fileManagerWindow.ShowDialog(owner);
        }

        #region Xbox Tools

        public static void ShowFileManagerXbox(Form owner)
        {
            using var fileManagerWindow = new Forms.Tools.XBOX_Tools.FileManagerWindow();
            fileManagerWindow.ShowDialog(owner);
        }
        public static void ShowIniEditorXbox(Form owner)
        {
            using var iniEditorWindow = new iniEditor();
            iniEditorWindow.ShowDialog(owner);
        }
        #endregion

        public static void ShowSettingsWindow(Form owner)
        {
            using var settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog(owner);
        }

        public static void ShowAboutWindow(Form owner)
        {
            using var aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog(owner);
        }

        public static string ShowFolderBrowseDialog(Form owner, string description)
        {
            using var folderBrowser = new FolderBrowserDialog { Description = description, ShowNewFolderButton = true };
            return folderBrowser.ShowDialog(owner) == DialogResult.OK ? folderBrowser.SelectedPath : null;
        }

        public static string ShowOpenFileDialog(Form owner, string title, string fileTypes)
        {
            using var openFileDialog = new OpenFileDialog { Title = title, Filter = fileTypes };
            return openFileDialog.ShowDialog(owner) == DialogResult.OK ? openFileDialog.FileName : null;
        }

        public static void ShowGameRegionsDialog(Form owner)
        {
            using var gameRegions = new GameRegionsDialog();
            gameRegions.ShowDialog(owner);
        }

        public static void ShowExternalApplicationsDialog(Form owner)
        {
            using var externalApplications = new ExternalApplicationsDialog();
            externalApplications.ShowDialog(owner);
        }

        public static void ShowCustomListsDialog(Form owner)
        {
            using var customListsDialog = new CustomListsDialog();
            customListsDialog.ShowDialog(owner);
        }

        public static void ShowCustomXboxDialog(Form owner, string title, string body, XMessageboxUI.ButtonOptions buttons)
        {
            using var xMessageboxUI = new XMessageboxUI(title, body, buttons);
            xMessageboxUI.ShowDialog(owner);
        }
    }
}