using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using Humanizer;
using ArisenStudio.Database;
using ArisenStudio.Forms.Dialogs;
using ArisenStudio.Forms.Dialogs.Details;
using ArisenStudio.Forms.Tools.PS3;
using ArisenStudio.Forms.Tools.XBOX;
using ArisenStudio.Models.Database;
using ArisenStudio.Models.Resources;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using ArisenStudio.Forms.Windows;

namespace ArisenStudio.Extensions
{
    internal static class DialogExtensions
    {
        public static ResourceManager Language = MainWindow.ResourceLanguage;

        #region Details

        public static void ShowCustomItemDetailsDialog(Form owner, CustomItemData customItem)
        {
            XtraForm overlayForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = .50d,
                BackColor = Color.Black,
                Size = owner.Size,
                Location = owner.Location,
                ShowInTaskbar = false
            };

            overlayForm.Show(owner);

            XtraForm detailsDialog = new CustomModDialog
            {
                CustomItem = customItem,
                Owner = owner
            };

            _ = detailsDialog.ShowDialog();

            // Get rid of the overlay form  
            overlayForm.Dispose();
        }

        public static void ShowItemDetailsDialog(Form owner, CategoriesData categories, ModItemData modItem, AppItemData appItem = null)
        {
            XtraForm detailsDialog = new()
            {
                Owner = owner
            };

            switch (modItem.GetPlatform())
            {
                case Platform.PS3:
                    if (modItem.GetCategoryType(categories) == CategoryType.Game)
                    {
                        detailsDialog = new GameModDialog
                        {
                            CategoryType = CategoryType.Game,
                            ModItem = modItem
                        };
                    }
                    else if (modItem.GetCategoryType(categories) == CategoryType.Homebrew)
                    {
                        detailsDialog = new HomebrewDialog
                        {
                            CategoryType = CategoryType.Homebrew,
                            ModItem = modItem
                        };
                    }
                    else if (modItem.GetCategoryType(categories) == CategoryType.Resource)
                    {
                        detailsDialog = new ResourceDialog
                        {
                            CategoryType = CategoryType.Resource,
                            ModItem = modItem
                        };
                    }
                    break;

                case Platform.XBOX360:
                    detailsDialog = new HomebrewXboxDialog
                    {
                        //CategoryType = CategoryType.Homebrew,
                        CategoryType = modItem.GetCategoryType(categories),
                        ModItem = modItem

                    };
                    break;

                default:
                    break;

            }

            XtraForm overlayForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = .50d,
                BackColor = Color.Black,
                Size = owner.Size,
                Location = owner.Location,
                ShowInTaskbar = false
            };

            overlayForm.Show(owner);

            _ = detailsDialog.ShowDialog();

            overlayForm.Dispose();
        }

        public static void ShowItemDetailsDialog(Form owner, CategoriesData categories, AppItemData appItem)
        {
            XtraForm detailsDialog = new()
            {
                Owner = owner
            };

            switch (appItem.GetPlatform())
            {
                case Platform.PS4:
                    detailsDialog = new ApplicationDialog
                    {
                        CategoryType = CategoryType.Homebrew,
                        AppItem = appItem
                    };
                    break;

                default:
                    break;

            }

            XtraForm overlayForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = .50d,
                BackColor = Color.Black,
                Size = owner.Size,
                Location = owner.Location,
                ShowInTaskbar = false
            };

            overlayForm.Show(owner);

            _ = detailsDialog.ShowDialog();

            overlayForm.Dispose();
        }

        public static void ShowItemPackageDetailsDialog(Form owner, PackageItemData packageItem)
        {
            PackageDialog detailsDialog = new()
            {
                Owner = owner,
                PackageItem = packageItem
            };

            XtraForm overlayForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = .50d,
                BackColor = Color.Black,
                Size = owner.Size,
                Location = owner.Location,
                ShowInTaskbar = false
            };

            overlayForm.Show(owner);

            _ = detailsDialog.ShowDialog();

            overlayForm.Dispose();
        }

        public static void ShowItemGameSaveDetailsDialog(Form owner, GameSaveItemData gameSaveItem)
        {
            using GameSaveDialog detailsDialog = new();
            detailsDialog.GameSaveItem = gameSaveItem;

            XtraForm overlayForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = .50d,
                BackColor = Color.Black,
                Size = owner.Size,
                Location = owner.Location,
                ShowInTaskbar = false
            };

            overlayForm.Show(owner);

            detailsDialog.Owner = owner;
            _ = detailsDialog.ShowDialog();

            overlayForm.Dispose();
        }

        public static void ShowItemGameCheatsDialog(Form owner, GameCheatItemData gameCheatItem)
        {
            using GameCheatsDialog cheatsDialog = new();
            cheatsDialog.GameCheatItem = gameCheatItem;

            XtraForm overlayForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = .50d,
                BackColor = Color.Black,
                Size = owner.Size,
                Location = owner.Location,
                ShowInTaskbar = false
            };

            overlayForm.Show(owner);

            cheatsDialog.Owner = owner;
            _ = cheatsDialog.ShowDialog();

            overlayForm.Dispose();
        }

        public static void ShowItemGamePatchesDialog(Form owner, GamePatchItemData gamePatchItem)
        {
            using GamePatchesDialog patchesDialog = new();
            patchesDialog.GamePatchItem = gamePatchItem;

            XtraForm overlayForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = .50d,
                BackColor = Color.Black,
                Size = owner.Size,
                Location = owner.Location,
                ShowInTaskbar = false
            };

            overlayForm.Show(owner);

            patchesDialog.Owner = owner;
            _ = patchesDialog.ShowDialog();
            
            overlayForm.Dispose();
        }

        public static void ShowGameTrainers(Form owner, TrainerGameData trainerItem)
        {
            using GameTrainersDialog gameTrainersDialog = new();
            gameTrainersDialog.TrainerGameData = trainerItem;

            XtraForm overlayForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = .50d,
                BackColor = Color.Black,
                Size = owner.Size,
                Location = owner.Location,
                ShowInTaskbar = false
            };

            overlayForm.Show(owner);

            gameTrainersDialog.Owner = owner;
            _ = gameTrainersDialog.ShowDialog();

            overlayForm.Dispose();
        }

        #endregion

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
            dataViewDialog.Owner = owner;
            _ = dataViewDialog.ShowDialog(owner);
        }

        public static ListItem ShowListViewDialog(Form owner, string title, List<ListItem> items)
        {
            using ListViewDialog listViewDialog = new()
            {
                Owner = owner,
                Text = title,
                Items = items
            };

            MethodInvoker dialog = new(() =>
            {
                _ = listViewDialog.ShowDialog();
            });

            if (owner.InvokeRequired)
            {
                _ = owner.Invoke(dialog);
            }
            else
            {
                dialog.Invoke();
            }

            return listViewDialog.SelectedItem ?? null;
        }

        public static string ShowListItemDialog(Form owner, string title, string labelText, string[] items, bool allowCancel = true)
        {
            using ComboBoxEdit comboBoxEdit = new();
            comboBoxEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            comboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            comboBoxEdit.Properties.ShowNullValuePrompt = ShowNullValuePromptOptions.Default;
            comboBoxEdit.Properties.NullValuePrompt = "Select...";
            comboBoxEdit.Properties.Items.AddRange(items);
            comboBoxEdit.SelectedIndex = 0;

            XtraInputBoxArgs args = new()
            {
                Owner = owner,
                Caption = title,
                Prompt = labelText,
                DefaultResponse = null,
                Editor = comboBoxEdit,
                DefaultButtonIndex = 0
            };

            if (!allowCancel)
            {
                (args as XtraBaseArgs).Buttons = [DialogResult.OK];
            }

            return (string)XtraInputBox.Show(args);
        }

        public static string ShowTextInputDialog(Form owner, string title, string labelText, string inputText = "", int maxLength = 0)
        {
            using TextEdit textEdit = new();
            textEdit.Text = inputText;
            textEdit.EditValue = inputText;
            textEdit.Properties.MaxLength = maxLength == 0 ? int.MaxValue : maxLength;
            textEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;

            XtraInputBoxArgs args = new()
            {
                Owner = owner,
                Caption = title,
                Prompt = labelText,
                DefaultResponse = inputText,
                Editor = textEdit
            };

            return (string)XtraInputBox.Show(args);
        }

        public static string[] ShowMultiTextInputDialog(Form owner, string title, string labelText, string[] inputText = null, int maxLength = 0)
        {
            MemoEdit textEdit = new();
            textEdit.Properties.MaxLength = maxLength == 0 ? int.MaxValue : maxLength;
            textEdit.Lines = inputText;

            XtraInputBoxArgs args = new()
            {
                Owner = owner,
                Caption = title,
                Prompt = labelText,
                DefaultResponse = null,
                Editor = textEdit
            };

            return (string[])XtraInputBox.Show(args);
        }

        public static int ShowNumberInputDialog(Form owner, string title, string labelText, int inputValue = 0, int maxValue = 0)
        {
            using TextEdit textEdit = new();
            textEdit.EditValue = inputValue;
            textEdit.Properties.Mask.MaskType = MaskType.Numeric;
            textEdit.Properties.MaxLength = maxValue == 0 ? int.MaxValue : maxValue;
            textEdit.Properties.MaskSettings.DataType = typeof(int);

            XtraInputBoxArgs args = new()
            {
                Owner = owner,
                Caption = title,
                Prompt = labelText,
                DefaultResponse = null,
                Editor = textEdit
            };

            return (int)XtraInputBox.Show(args);
        }

        public static Color ShowColorInputDialog(Form owner, string title, string labelText)
        {
            using ColorPickEdit colorPickEdit = new();

            XtraInputBoxArgs args = new()
            {
                Owner = owner,
                Caption = title,
                Prompt = labelText,
                DefaultResponse = null,
                Editor = colorPickEdit
            };

            return (Color)XtraInputBox.Show(args);
        }

        /// <summary>
        /// Transfer files for custom mods.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="transferType"></param>
        /// <param name="customItem"></param>
        public static void ShowTransferFilesDialog(Form owner, TransferType transferType, CustomItemData customItem)
        {
            using TransferDialog transferDialog = new()
            {
                TransferType = transferType,
                //Category = category,
                CustomMod = customItem
            };

            transferDialog.Owner = owner;
            _ = transferDialog.ShowDialog();
        }

        /// <summary>
        /// Transfer files for normal type of mods.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="transferType"></param>
        /// <param name="category"></param>
        /// <param name="modItem"></param>
        /// <param name="downloadFiles"></param>
        /// <param name="region"></param>
        public static void ShowTransferFilesDialog(Form owner, TransferType transferType, Category category, ModItemData modItem, DownloadFiles downloadFiles, string region = "")
        {
            using TransferDialog transferDialog = new()
            {
                TransferType = transferType,
                Category = category,
                ModItem = modItem,
                DownloadFiles = downloadFiles,
                GameRegion = region
            };

            transferDialog.Owner = owner;
            _ = transferDialog.ShowDialog();
        }

        /// <summary>
        /// Transfer homebrew applications for PS4.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="transferType"></param>
        /// <param name="category"></param>
        /// <param name="appData"></param>
        /// <param name="appFile"></param>
        public static void ShowTransferFilesDialog(Form owner, TransferType transferType, Category category, AppItemData appData, AppItemFile appFile)
        {
            using TransferDialog transferDialog = new()
            {
                TransferType = transferType,
                Category = category,
                AppItem = appData,
                AppItemFile = appFile,
            };

            transferDialog.Owner = owner;
            _ = transferDialog.ShowDialog();
        }

        /// <summary>
        /// Transfer package files from the store for PS3.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="transferType"></param>
        /// <param name="packageItem"></param>
        public static void ShowTransferPackagesDialog(Form owner, TransferType transferType, PackageItemData packageItem)
        {
            using TransferDialog transferDialog = new()
            {
                TransferType = transferType,
                PackageItem = packageItem
            };

            transferDialog.Owner = owner;
            _ = transferDialog.ShowDialog();
        }

        /// <summary>
        /// Transfer trainer files for Xbox 360
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="transferType"></param>
        /// <param name="trainersGame"></param>
        /// <param name="trainerItem"></param>
        public static void ShowTransferFilesDialog(Form owner, TransferType transferType, TrainerGameData trainersGame, TrainerItem trainerItem)
        {
            using TransferDialog transferDialog = new()
            {
                TransferType = transferType,
                //Category = category,
                TrainerGame = trainersGame,
                TrainerItem = trainerItem
            };

            transferDialog.Owner = owner;
            _ = transferDialog.ShowDialog();
        }

        public static void ShowTransferGameSavesDialog(Form owner, TransferType transferType, Category category, GameSaveItemData gameSaveItem, DownloadFiles downloadFiles = null)
        {
            using TransferDialog transferDialog = new()
            {
                TransferType = transferType,
                Category = category,
                GameSaveItem = gameSaveItem,
                DownloadFiles = downloadFiles,
            };

            transferDialog.Owner = owner;
            _ = transferDialog.ShowDialog();
        }

        public static DialogResult ShowCustomMessageBox(Form owner, string caption, string text, DialogResult[] results, Icon icon, string cancelButton = "Cancel", string abortButton = "Abort", string okButton = "OK", string yesButton = "Yes", string noButton = "No", string retryButton = "Retry")
        {
            XtraMessageBoxArgs args = new()
            {
                Icon = icon,
                Caption = caption,
                Text = text,
                Buttons = results,
                DefaultButtonIndex = 0
            };

            args.Showing += (o, e) =>
            {
                e.Form.Owner = owner;

                foreach (object control in e.Form.Controls)
                {
                    if (control is SimpleButton button)
                    {
                        switch (button.DialogResult.ToString())
                        {
                            case "OK":
                                button.Text = okButton;
                                break;
                            case "Cancel":
                                button.Text = cancelButton;

                                if (button.Text is not "Cancel")
                                {
                                    button.SetControlTextWidth();
                                }

                                break;
                            case "Retry":
                                button.Text = retryButton;
                                break;
                            case "Yes":
                                button.Text = yesButton;
                                break;
                            case "No":
                                button.Text = noButton;
                                break;
                            case "Abort":
                                button.Text = abortButton;
                                break;
                        }

                    }
                }
            };

            return XtraMessageBox.Show(args);
        }

        public static void ShowErrorMessage(Form owner, string message) => XtraMessageBox.Show(owner, message, Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static ConsoleProfile ShowConnectionsDialog(Form owner, Platform platform)
        {
            using ConnectionsDialog connectConsole = new() { Platform = platform };
            return connectConsole.ShowDialog(owner) == DialogResult.OK ? connectConsole.ConsoleProfile : null;
        }

        public static ConsoleProfile ShowConnectionsDialog(Form owner)
        {
            using ConnectionsDialog connectConsole = new();
            return connectConsole.ShowDialog(owner) == DialogResult.OK ? connectConsole.ConsoleProfile : null;
        }

        public static void ShowEditConnectionsDialog(Form owner, bool isEditing)
        {
            using ConnectionsDialog connectConsole = new() { IsEditing = isEditing };
            _ = connectConsole.ShowDialog(owner);
        }

        public static ConsoleProfile ShowNewConnectionWindow(Form owner, ConsoleProfile consoleProfile, bool isEditing, bool createDefaultIfNull = false)
        {
            using NewProfileDialog newProfileDialog = new() { ConsoleProfile = consoleProfile, IsEditingProfile = isEditing };

            if (newProfileDialog.ShowDialog(owner) == DialogResult.OK)
            {
                return newProfileDialog.ConsoleProfile;
            }

            if (isEditing)
            {
                return consoleProfile;
            }
            else
            {
                if (createDefaultIfNull)
                {
                    Platform platform = ShowPlatformList(owner, true);
                    return MainWindow.Settings.CreateDefaultProfile(platform);
                }
            }

            return isEditing ? consoleProfile : null;
        }

        public static Platform ShowPlatformList(Form owner, bool isRequired = true)
        {
            string selectedItem = ShowListItemDialog(owner, "Choose Platform", "Platform:", ["PlayStation 3", "PlayStation 4", "Xbox 360"], false);

            if (isRequired && selectedItem.IsNullOrWhiteSpace())
            {
                return ShowPlatformList(owner, isRequired);
            }
            else
            {
                Platform platform = selectedItem.DehumanizeTo<Platform>();
                return platform;
            }
        }

        public static void ShowNewCustomModsDialog(Form owner, CustomItemData customItem = null, bool isEditing = false)
        {
            using NewCustomDialog customDialog = new() { IsEditing = isEditing, CustomMod = customItem };
            _ = customDialog.ShowDialog(owner);
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

        public static SortOptionsDialog ShowSortOptions(Form owner, string sortOption, List<string> sortOptions, ColumnSortOrder sortOrder)
        {
            using SortOptionsDialog sortOptionsDialog = new() { SortOption = sortOption, SortOptions = sortOptions, SortOrder = sortOrder };
            return sortOptionsDialog.ShowDialog(owner) == DialogResult.OK ? sortOptionsDialog : null;
        }

        #region Help

        public static void ShowPackagesFaqDialog(Form owner)
        {
            using PackagesFaqDialog packagesFaqDialog = new();
            _ = packagesFaqDialog.ShowDialog(owner);
        }

        public static void ShowWhatsNewDialog(Form owner, Models.Release_Data.GitHubReleaseData gitHubData)
        {
            try
            {
                string body = gitHubData.Body;

                ShowDataViewDialog(owner, $"Change Log - What's New", $"{gitHubData.Name} ({gitHubData.PublishedAt.DateTime.ToOrdinalWords()})", body.Replace("- ", "• "));
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to get latest release data from GitHub.");
            }
        }

        #endregion

        public static void ShowRequestModsDialog(Form owner)
        {
            using RequestModsDialog requestModsDialog = new();
            _ = requestModsDialog.ShowDialog(owner);
        }

        public static void ShowSetupWizardDialog(Form owner)
        {
            using SetupWizardDialog setupWizardDialog = new();
            _ = setupWizardDialog.ShowDialog(owner);
        }

        #region PS3 Tools

        public static void ShowGameBackupFileManager(Form owner)
        {
            Program.Log.Info("Opening Backup Files (PS3) dialog...");
            using BackupFilesManager backupFiles = new();
            _ = backupFiles.ShowDialog(owner);
        }

        public static BackupFile ShowBackupFileDetails(Form owner, BackupFile backupFile)
        {
            using BackupFileDialog backupFileDialog = new() { BackupFile = backupFile };
            return backupFileDialog.ShowDialog(owner) == DialogResult.OK ? backupFileDialog.BackupFile : null;
        }

        public static void ShowPs3ConsoleManager(Form owner)
        {
            Program.Log.Info("Opening Console Manager (PS3) dialog...");
            using Forms.Tools.PS3.ConsoleManager consoleManager = new();
            _ = consoleManager.ShowDialog(owner);
        }

        public static void ShowGameUpdatesFinder(Form owner)
        {
            Program.Log.Info("Opening Game Updates Finder (PS3) dialog...");
            using GameUpdatesFinder gameUpdatesFinder = new();
            _ = gameUpdatesFinder.ShowDialog(owner);
        }

        public static void ShowPackageManager(Form owner)
        {
            Program.Log.Info("Opening Package Manager (PS3) dialog...");
            using PackageFilesManager packageManager = new();
            _ = packageManager.ShowDialog(owner);
        }

        public static void ShowBootPluginsEditor(Form owner)
        {
            Program.Log.Info("Opening Boot Plugins Editor (PS3) dialog...");
            using BootPluginsEditor bootPluginsEditor = new();
            _ = bootPluginsEditor.ShowDialog(owner);
        }

        public static void ShowPs3TakeScreenshot(Form owner)
        {
            Program.Log.Info("Opening Screenshot Tool (PS3) dialog...");
            using Forms.Tools.PS3.TakeScreenshot takeScreenshot = new();
            _ = takeScreenshot.ShowDialog(owner);
        }

        public static void ShowGameCheats(Form owner)
        {
            Program.Log.Info("Opening Game Cheats (PS3) dialog...");
            using GameCheatsDialog gameCheatsDialog = new();
            _ = gameCheatsDialog.ShowDialog(owner);
        }

        #endregion

        #region Xbox 360 Tools

        public static void ShowXboxGameSaveResigner(Form owner)
        {
            Program.Log.Info("Opening Game Save Resigner (XBOX) dialog...");
            using GameSaveResigner gameSaveResigner = new();
            _ = gameSaveResigner.ShowDialog(owner);
        }

        public static void ShowXboxGameLauncher(Form owner)
        {
            Program.Log.Info("Opening Game Launcher (XBOX) dialog...");
            using Forms.Tools.XBOX.GameLauncher gameLauncher = new();
            _ = gameLauncher.ShowDialog(owner);
        }

        public static void ShowXboxModuleLoader(Form owner)
        {
            Program.Log.Info("Opening Module Loader (XBOX) dialog...");
            using ModuleLoader moduleLoader = new();
            _ = moduleLoader.ShowDialog(owner);
        }

        public static void ShowXboxXuidGameSpoofer(Form owner)
        {
            Program.Log.Info("Opening XUID Game Spoofer (XBOX) dialog...");
            using XuidGameSpoofer xuidGameSpoofer = new();
            _ = xuidGameSpoofer.ShowDialog(owner);
        }

        public static void ShowXboxTakeScreenshot(Form owner)
        {
            Program.Log.Info("Opening Screenshot Tool (XBOX) dialog...");
            using Forms.Tools.XBOX.TakeScreenshot takeScreenshot = new();
            _ = takeScreenshot.ShowDialog(owner);
        }

        public static void ShowXboxConsoleManager(Form owner)
        {
            Program.Log.Info("Opening Console Manager (XBOX) dialog...");
            using ConsoleInfo consoleManager = new();
            _ = consoleManager.ShowDialog(owner);
        }

        public static void ShowXboxDashlaunchEditor(Form owner)
        {
            Program.Log.Info("Opening Dashlaunch Editor (XBOX) dialog...");
            using DashlaunchEditor pluginsEditor = new();
            _ = pluginsEditor.ShowDialog(owner);
        }

        public static void ShowXboxHDKey(Form owner)
        {
            Program.Log.Info("Opening Xbox HD Key (XBOX) dialog...");
            using XboxHDKey xboxHDKey = new();
            _ = xboxHDKey.ShowDialog(owner);
        }

        #endregion

        #region Options

        public static void ShowGameRegionsDialog(Form owner)
        {
            using GameRegions gameRegionsDialog = new();
            _ = gameRegionsDialog.ShowDialog(owner);
        }

        #endregion

        public static void ShowEasterEgg(Form owner)
        {
            Program.Log.Info("User found the easter egg!!!");
            using EasterEgg easterEgg = new();
            _ = easterEgg.ShowDialog(owner);
        }
    }
}