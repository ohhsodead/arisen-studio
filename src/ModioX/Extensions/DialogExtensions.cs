using ModioX.Forms;
using ModioX.Forms.Dialogs;
using ModioX.Forms.Windows;
using ModioX.Models.Release_Data;
using ModioX.Models.Resources;
using ModioX.Windows;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    internal static class DialogExtensions
    {
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

        public static void ShowWhatsNewWindow(Form owner, GitHubData gitHubData)
        {
            try
            {
                GitHubData GitHubData = gitHubData;

                string releaseBody = GitHubData.Body;
                string releaseBodyWithoutLastLine = releaseBody.Substring(0, releaseBody.Trim().LastIndexOf(Environment.NewLine));

                ShowDataViewDialog(owner, GitHubData.Name + " - What's New", "Change Log", releaseBodyWithoutLastLine.Replace("-", "•"));
            }
            catch (Exception ex)
            {
                Program.Log.Error("Unable to load github release data.", ex);
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

        public static void ShowConnectionDialog(Form owner)
        {
            using (ConnectionDialog connectConsole = new ConnectionDialog())
            {
                connectConsole.ShowDialog(owner);
            }
        }

        public static ConsoleProfile ShowNewConnectionWindow(Form owner, ConsoleProfile consoleProfile)
        {
            using (NewConnectionDialog newConnectionDialog = new NewConnectionDialog() { ConsoleProfile = consoleProfile, IsEditingConsole = consoleProfile != null})
            {
                return newConnectionDialog.ShowDialog(owner) == DialogResult.OK ? newConnectionDialog.ConsoleProfile : null;
            }
        }

        public static void ShowBackupFiles(Form owner)
        {
            using (BackupFilesWindow backupFilesWindow = new BackupFilesWindow())
            {
                backupFilesWindow.ShowDialog(owner);
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

        public static void ShowRequestModsWindow(Form owner)
        {
            using (RequestModsWindow requestMods = new RequestModsWindow())
            {
                _ = requestMods.ShowDialog(owner);
            }
        }
    }
}