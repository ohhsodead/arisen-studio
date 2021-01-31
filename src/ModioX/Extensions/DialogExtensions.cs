using DevExpress.XtraEditors;
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
            using DataViewDialog dataViewDialog = new DataViewDialog { Text = title };
            dataViewDialog.LabelTitle.Text = subtitle;
            dataViewDialog.LabelBody.Text = body;

            dataViewDialog.MaximumSize = new Size(dataViewDialog.MaximumSize.Width, owner.Height + 100);
            dataViewDialog.Size = new Size(dataViewDialog.Width, dataViewDialog.Height + 15);
            dataViewDialog.ShowDialog(owner);
        }

        public static string ShowListInputDialog(string title, List<string> items)
        {
            using ListViewDialog listViewDialog = new ListViewDialog
            {
                Text = title,
                Items = items
            };

            listViewDialog.ShowDialog();
            return listViewDialog.SelectedItem ?? "";
        }

        public static string ShowTextInputDialog(Form owner, string title, string labelText, string inputText)
        {
            using InputTextDialog inputTextDialog = new InputTextDialog
            {
                Text = title,
                LabelName = { Text = labelText },
                TextBoxName = { Text = inputText }
            };

            return inputTextDialog.ShowDialog(owner) == DialogResult.OK ? inputTextDialog.TextBoxName.Text.Trim() : null;
        }

        public static ConsoleProfile ShowConnectionDialog(Form owner)
        {
            using ConnectionDialog connectConsole = new ConnectionDialog();
            return connectConsole.ShowDialog(owner) == DialogResult.OK ? connectConsole.ConsoleProfile : null;
        }

        public static ConsoleProfile ShowNewConnectionWindow(Form owner, ConsoleProfile consoleProfile, bool isEditing)
        {
            using NewConnectionDialog newConnectionDialog = new NewConnectionDialog { ConsoleProfile = consoleProfile, IsEditingProfile = isEditing };
            return newConnectionDialog.ShowDialog(owner) == DialogResult.OK ? newConnectionDialog.ConsoleProfile : null;
        }

        public static string ShowFolderBrowseDialog(Form owner, string description)
        {
            using XtraFolderBrowserDialog folderBrowser = new XtraFolderBrowserDialog { Description = description, ShowNewFolderButton = true };
            return folderBrowser.ShowDialog(owner) == DialogResult.OK ? folderBrowser.SelectedPath : null;
        }

        public static string ShowOpenFileDialog(Form owner, string title, string fileTypes)
        {
            using XtraOpenFileDialog openFileDialog = new XtraOpenFileDialog { Title = title, Filter = fileTypes };
            return openFileDialog.ShowDialog(owner) == DialogResult.OK ? openFileDialog.FileName : null;
        }

        public static void ShowFileManager(Form owner)
        {
            using FileManagerWindow fileManagerWindow = new FileManagerWindow();
            fileManagerWindow.ShowDialog(owner);
        }

        #region PS3 Tools

        public static void ShowGameBackupFiles(Form owner)
        {
            using BackupFiles gameBackupFilesWindow = new BackupFiles();
            gameBackupFilesWindow.ShowDialog(owner);
        }

        public static void ShowGameUpdatesFinderDialog(Form owner)
        {
            using GameUpdatesFinder gameUpdatesDialog = new GameUpdatesFinder();
            gameUpdatesDialog.ShowDialog(owner);
        }

        public static void ShowPackageManagerWindow(Form owner)
        {
            using PackageManagerWindow packageManagerWindow = new PackageManagerWindow();
            packageManagerWindow.ShowDialog(owner);
        }

        #endregion

        #region Xbox Tools

        public static void ShowXboxPluginsEditor(Form owner)
        {
            using PluginsEditor pluginsEditor = new PluginsEditor();
            pluginsEditor.ShowDialog(owner);
        }

        public static void ShowXboxMemoryViewer(Form owner, string gameTitle)
        {
            using MemoryViewer memoryViewer = new MemoryViewer() { GameTitle = gameTitle };
            memoryViewer.ShowDialog(owner);
        }

        #endregion

        #region Settings

        public static void ShowSettingsWindow(Form owner)
        {
            using SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog(owner);
        }

        public static void ShowGameRegionsDialog(Form owner)
        {
            using SavedGameRegions gameRegions = new SavedGameRegions();
            gameRegions.ShowDialog(owner);
        }

        public static void ShowExternalApplicationsDialog(Form owner)
        {
            using ExternalApplications externalApplications = new ExternalApplications();
            externalApplications.ShowDialog(owner);
        }

        public static void ShowCustomListsDialog(Form owner)
        {
            using CustomLists customListsDialog = new CustomLists();
            customListsDialog.ShowDialog(owner);
        }

        #endregion

        public static void ShowAboutWindow(Form owner)
        {
            using AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog(owner);
        }

        public static DialogResult ShowCustomXboxDialog(Form owner, string title, string body, XMessageboxUI.ButtonOptions buttons)
        {
            using XMessageboxUI xMessageboxUI = new XMessageboxUI(title, body, buttons);
            return xMessageboxUI.ShowDialog(owner);
        }
    }
}