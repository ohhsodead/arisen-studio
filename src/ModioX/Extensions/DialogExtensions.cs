using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ModioX.Forms.Dialogs;
using ModioX.Forms.Settings;
using ModioX.Forms.Tools.PS3_Tools;
using ModioX.Forms.Tools.XBOX_Tools;
using ModioX.Forms.Windows;
using ModioX.Models.Release_Data;
using ModioX.Models.Resources;

namespace ModioX.Extensions
{
    internal static class DialogExtensions
    {
        public static void ShowWhatsNewWindow(Form owner, GitHubData gitHubData)
        {
            try
            {
                string releaseBody = gitHubData.Body;
                string releaseBodyWithoutLastLine = releaseBody.Substring(0, releaseBody.Trim().LastIndexOf(Environment.NewLine, StringComparison.Ordinal));

                ShowDataViewDialog(owner, gitHubData.Name + " - What's New", "Change Log", releaseBodyWithoutLastLine.Replace("-", "•"));
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to fetch release data from GitHub.");
            }
        }

        public static void ShowDataViewDialog(Form owner, string title, string subtitle, string body)
        {
            using DataViewDialog dataViewDialog = new() 
            {
                Text = title
            };

            dataViewDialog.LabelTitle.Text = subtitle;
            dataViewDialog.LabelBody.Text = body;

            dataViewDialog.MaximumSize = new Size(dataViewDialog.MaximumSize.Width, owner.Height + 100);
            dataViewDialog.Size = new Size(dataViewDialog.Width, dataViewDialog.Height + 15);
            dataViewDialog.ShowDialog(owner);
        }

        public static string ShowListInputDialog(Form owner, string title, List<ListItem> items)
        {
            using ListViewDialog listViewDialog = new()
            {
                Text = title,
                Items = items
            };

            listViewDialog.ShowDialog(owner);
            return listViewDialog.SelectedItem ?? "";
        }

        public static string ShowTextInputDialog(Form owner, string title, string labelText, string inputText)
        {
            using InputTextDialog inputTextDialog = new()
            {
                Text = title,
                LabelName = { Text = labelText },
                TextBoxName = { Text = inputText }
            };

            return inputTextDialog.ShowDialog(owner) == DialogResult.OK ? inputTextDialog.TextBoxName.Text.Trim() : null;
        }

        public static ConsoleProfile ShowConnectionDialog(Form owner)
        {
            using ConnectionDialog connectConsole = new();
            return connectConsole.ShowDialog(owner) == DialogResult.OK ? connectConsole.ConsoleProfile : null;
        }

        public static ConsoleProfile ShowNewConnectionWindow(Form owner, ConsoleProfile consoleProfile, bool isEditing)
        {
            using NewConnectionDialog newConnectionDialog = new() { ConsoleProfile = consoleProfile, IsEditingProfile = isEditing };
            return newConnectionDialog.ShowDialog(owner) == DialogResult.OK ? newConnectionDialog.ConsoleProfile : null;
        }

        public static string ShowFolderBrowseDialog(Form owner, string description)
        {
            using XtraFolderBrowserDialog folderBrowser = new() { Description = description, ShowNewFolderButton = true };
            return folderBrowser.ShowDialog(owner) == DialogResult.OK ? folderBrowser.SelectedPath : null;
        }

        public static string ShowOpenFileDialog(Form owner, string title, string fileTypes)
        {
            using XtraOpenFileDialog openFileDialog = new() { Title = title, Filter = fileTypes };
            return openFileDialog.ShowDialog(owner) == DialogResult.OK ? openFileDialog.FileName : null;
        }

        public static string ShowSaveFileDialog(Form owner, string title, string fileTypes)
        {
            using XtraSaveFileDialog saveFileDialog = new() { Title = title, Filter = fileTypes };
            return saveFileDialog.ShowDialog(owner) == DialogResult.OK ? saveFileDialog.FileName : null;
        }

        public static void ShowFileManager(Form owner)
        {
            using FileManagerWindow fileManagerWindow = new();
            fileManagerWindow.ShowDialog(owner);
        }

        #region PS3 Tools

        public static void ShowGameBackupFiles(Form owner)
        {
            using GameBackupFiles backupFiles = new();
            backupFiles.ShowDialog(owner);
        }

        public static BackupFile ShowBackupFileDetails(Form owner, BackupFile backupFile)
        {
            using BackupFileDialog backupFileDialog = new() { BackupFile = backupFile };
            return backupFileDialog.ShowDialog(owner) == DialogResult.OK ? backupFileDialog.BackupFile : null;
        }

        public static void ShowGameUpdatesFinderDialog(Form owner)
        {
            using GameUpdatesFinder gameUpdatesFinder = new();
            gameUpdatesFinder.ShowDialog(owner);
        }

        public static void ShowPackageManagerWindow(Form owner)
        {
            using PackageManager packageManager = new();
            packageManager.ShowDialog(owner);
        }

        #endregion PS3 Tools

        #region Xbox 360 Tools

        public static void ShowXboxGameLauncher(Form owner)
        {
            using GameLauncher gameLauncher = new();
            gameLauncher.ShowDialog(owner);
        }

        public static void ShowXboxPluginsEditor(Form owner)
        {
            using PluginsEditor pluginsEditor = new();
            pluginsEditor.ShowDialog(owner);
        }

        #endregion Xbox 360 Tools

        #region Settings

        public static void ShowSettingsWindow(Form owner)
        {
            using SettingsWindow settingsWindow = new();
            settingsWindow.ShowDialog(owner);
        }

        public static void ShowGameRegionsDialog(Form owner)
        {
            using GameRegions gameRegions = new();
            gameRegions.ShowDialog(owner);
        }

        public static void ShowCustomListsDialog(Form owner, ConsoleTypePrefix consoleType)
        {
            using CustomLists customListsDialog = new() { ConsoleType = consoleType };
            customListsDialog.ShowDialog(owner);
        }

        #endregion Settings

        #region Help

        public static void ShowAboutWindow(Form owner)
        {
            using AboutDialog aboutDialog = new();
            aboutDialog.ShowDialog(owner);
        }

        #endregion Help

        public static void ShowRequestModsDialog(Form owner)
        {
            using RequestModsDialog requestModsDialog = new();
            requestModsDialog.ShowDialog(owner);
        }
    }
}