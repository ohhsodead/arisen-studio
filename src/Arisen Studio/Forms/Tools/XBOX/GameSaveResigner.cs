using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Isolib.STFSPackage;
using ArisenStudio.Extensions;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Io;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace ArisenStudio.Forms.Tools.XBOX
{
    public partial class GameSaveResigner : XtraForm
    {
        public GameSaveResigner()
        {
            InitializeComponent();
        }

        public ResourceManager Language = MainWindow.ResourceLanguage;

        public Stfs PackageGameSave { get; set; }

        public string PackageGameSavePath { get; set; }

        public Stfs PackageProfle { get; set; }

        private void GameSaveResigner_Load(object sender, EventArgs e)
        {
            MenuButtonFile.Caption = Language.GetString("FILE");
            MenuButtonProfile.Caption = Language.GetString("PROFILE");

            MenuItemAddProfileFromConsole.Enabled = MainWindow.IsConsoleConnected;
        }

        private void GameSaveResigner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PackageGameSave != null)
            {
                PackageGameSave.Close();
            }

            if (PackageProfle != null)
            {
                PackageProfle.Close();
            }
        }

        private void PopupMenuFile_BeforePopup(object sender, CancelEventArgs e)
        {
            MenuItemSaveFile.Enabled = PackageGameSave != null;
            MenuItemSaveToDevice.Enabled = PackageGameSave != null;

            if (PackageGameSave != null)
            {
                if (UsbExtensions.GetLocalUsbDevices().Count <= 0)
                {
                    MenuItemNoDeviceFound.Enabled = true;
                }
                else
                {
                    //ListItem profile = DialogExtensions.ShowListViewDialog(this, "USB Devices", UsbExtensions.GetUsbDevices());

                    //if (profile != null)
                    //{
                    //    var menuItem = new BarButtonItem() { Caption = profile.Name, Name = profile.Name };
                    //    menuItem.ItemClick += MenuItemDevice_ItemClick;
                    //    MenuItemSaveToDevice.Links.Add(menuItem);
                    //}

                    foreach (ListItem usbDevice in UsbExtensions.GetLocalUsbDevices())
                    {
                        BarButtonItem menuItem = new() { Caption = usbDevice.Name, Name = usbDevice.Name };
                        menuItem.ItemClick += MenuItemDevice_ItemClick;
                        MenuItemSaveToDevice.Links.Add(menuItem);
                    }

                    MenuItemNoDeviceFound.Enabled = false;
                }
            }
        }

        private void MenuItemDevice_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (ListItem usbDevice in UsbExtensions.GetLocalUsbDevices())
            {
                if (usbDevice.Name == e.Item.Name)
                {
                    PackageGameSave.Finish();
                    PackageGameSave.Close();
                    string installPath = $@"{usbDevice.Value}Game Saves\{TextBoxTitleId.Text}\";
                    File.Copy(PackageGameSavePath, installPath + Path.GetFileName(PackageGameSavePath), true);
                    PackageGameSave = new Stfs(PackageGameSavePath);
                    LoadFile();
                }
            }
        }

        private void MenuItemLoadFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            using XtraOpenFileDialog openFileDialog = new();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PackageGameSave = new Stfs(openFileDialog.FileName);
                PackageGameSavePath = openFileDialog.FileName;
                LoadFile();

                UpdateStatus($"Successfully loaded game save.");
                XtraMessageBox.Show(this, "Successfully loaded game save!", Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MenuItemSaveFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFile();
        }

        private void PopupImage_BeforePopup(object sender, CancelEventArgs e)
        {
            if (ImageContent.Image == null)
            {
                e.Cancel = true;
            }
        }

        private void MenuItemExtract_ItemClick(object sender, ItemClickEventArgs e)
        {
            string fileName = DialogExtensions.ShowSaveFileDialog(this, "Extract Image", "*.png|PNG Image");

            if (!fileName.IsNullOrEmpty())
            {
                ImagePackage.Image.Save(fileName, ImageFormat.Png);
            }
        }

        private void MenuItemReplace_ItemClick(object sender, ItemClickEventArgs e)
        {
            string fileName = DialogExtensions.ShowOpenFileDialog(this, "Replace Image", "PNG Image|*.png");

            if (!fileName.IsNullOrEmpty())
            {
                FileInfo fileInfo = new(fileName);

                if (fileInfo.Length <= 12000)
                {
                    ImagePackage.LoadAsync(fileName);
                }
                else
                {
                    XtraMessageBox.Show(this, Language.GetString("LABEL_IMAGE_SIZE_TOO_BIG"), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PopupMenuProfile_BeforePopup(object sender, CancelEventArgs e)
        {
            MenuItemAddProfileDetails.Enabled = PackageGameSave != null;
            MenuItemAddExistingProfile.Enabled = PackageGameSave != null && Directory.Exists(UserFolders.XboxProfiles);
            MenuItemAddProfileFromConsole.Enabled = PackageGameSave != null && MainWindow.IsConsoleConnected;
        }

        private void MenuItemAddProfileDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string fileName = DialogExtensions.ShowOpenFileDialog(this, Language.GetString("LABEL_OPEN_FILE"), string.Empty);

                if (!fileName.IsNullOrEmpty())
                {
                    if (XtraMessageBox.Show(this, $"Do you want to save this profile data?", Language.GetString("LABEL_SAVE_PROFILE"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string localProfilePath = Path.Combine(UserFolders.XboxProfiles, Path.GetFileName(fileName) + @"\");
                        string localProfileFilePath = Path.Combine(UserFolders.XboxProfiles, Path.GetFileName(fileName) + @"\" + Path.GetFileName(fileName));

                        Directory.CreateDirectory(localProfilePath);
                        File.Copy(fileName, localProfileFilePath + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bak");
                    }

                    LoadProfile(fileName);
                }
            }
            catch (Exception ex)
            {
                UpdateStatus($"Unable to load profile details.", ex);
                XtraMessageBox.Show(this, $"Unable to load profile details. Error Message: {ex.Message}", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemAddExistingProfile_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Directory.Exists(UserFolders.XboxProfiles))
            {
                List<ListItem> profiles = [];

                foreach (string profile in Directory.GetFiles(UserFolders.XboxProfiles, "*.*", SearchOption.AllDirectories))
                {
                    profiles.Add(
                        new()
                        {
                            Name = Path.GetFileName(profile),
                            Value = profile
                        });
                }

                if (profiles.Count > 0)
                {
                    ListItem profile = DialogExtensions.ShowListViewDialog(this, Language.GetString("LABEL_OPEN_FILE"), profiles);

                    if (profile == null)
                    {
                        XtraMessageBox.Show(this, $"You don't have any profiles saved or none was selected.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LoadProfile(profile.Value);
                    }
                }
                else
                {
                    XtraMessageBox.Show(this, $"You haven't saved any profiled.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MenuItemAddProfileFromConsole_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ListItem selectedProfile = XboxExtensions.GetXboxProfileFile(MainWindow.XboxConsole, this);

                if (selectedProfile != null)
                {
                    string localProfilePath = Path.Combine(UserFolders.XboxProfiles, selectedProfile.Name + @"\");
                    string localProfileFilePath = Path.Combine(UserFolders.XboxProfiles, selectedProfile.Name + @"\" + selectedProfile.Name);

                    Directory.CreateDirectory(localProfilePath);

                    MainWindow.XboxConsole.ReceiveFile(localProfileFilePath, selectedProfile.Value);

                    LoadProfile(localProfileFilePath);
                }
                else
                {
                    UpdateStatus("No profiles were found or you didn't select one.");
                    XtraMessageBox.Show(this, "No profiles were found or you didn't select one.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                UpdateStatus($"Unable to find profile files on console.", ex);
                XtraMessageBox.Show(this, $"Unable to find profile files on console. Error Message: {ex.Message}", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFile()
        {
            try
            {
                TextBoxDisplayName.Text = PackageGameSave.HeaderData.DisplayName;
                TextBoxTitleName.Text = PackageGameSave.HeaderData.TitleName;
                TextBoxProfileId.Text = PackageGameSave.HeaderData.ProfileID;
                TextBoxDeviceId.Text = PackageGameSave.HeaderData.DeviceID;
                TextBoxConsoleId.Text = PackageGameSave.HeaderData.ConsoleID;
                ImagePackage.Image = PackageGameSave.HeaderData.PackageImage;
                ImageContent.Image = PackageGameSave.HeaderData.ContentImage;
                TextBoxTitleId.Text = PackageGameSave.HeaderData.TitleID.TrimStart("00000000".ToCharArray());

                if (TextBoxProfileId.Text.IsNullOrEmpty() || TextBoxProfileId.Text == "0")
                {
                    TextBoxProfileId.Text = "0000000000000000";
                }

                if (TextBoxDeviceId.Text.IsNullOrEmpty() || TextBoxDeviceId.Text == "0")
                {
                    TextBoxDeviceId.Text = "0000000000000000000000000000000000000000";
                }

                if (TextBoxConsoleId.Text.IsNullOrEmpty() || TextBoxConsoleId.Text == "0")
                {
                    TextBoxConsoleId.Text = "0000000000";
                }
            }
            catch (Exception ex)
            {
                PackageGameSave = null;
                PackageGameSavePath = string.Empty;

                UpdateStatus($"Unable to parse game save file.", ex);
                XtraMessageBox.Show(this, $"Unable to parse game save file. Error Message: {ex.Message}", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProfile(string fileName)
        {
            try
            {
                PackageProfle = new Stfs(fileName);
                TextBoxProfileId.Text = PackageProfle.HeaderData.ProfileID;
                TextBoxDeviceId.Text = PackageProfle.HeaderData.DeviceID;
                TextBoxConsoleId.Text = PackageProfle.HeaderData.ConsoleID;

                UpdateStatus($"Successfully loaded profile file.");
                XtraMessageBox.Show(this, "Successfully loaded profile!", Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                UpdateStatus($"Unable to load profile.", ex);
                XtraMessageBox.Show(this, $"Unable to load profile. Error Message: {ex.Message}", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveFile()
        {
            try
            {
                if (XtraMessageBox.Show(this, "Would you like to create a backup of this file before saving?", "Backup File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PackageGameSave.Close();
                    BackupFile();
                }

                PackageGameSave = new Stfs(PackageGameSavePath);
                PackageGameSave.HeaderData.DisplayName = TextBoxDisplayName.Text;
                PackageGameSave.HeaderData.TitleName = TextBoxTitleName.Text;
                PackageGameSave.HeaderData.ProfileID = TextBoxProfileId.Text;
                PackageGameSave.HeaderData.DeviceID = TextBoxDeviceId.Text;
                PackageGameSave.HeaderData.ConsoleID = TextBoxConsoleId.Text;
                PackageGameSave.HeaderData.PackageImage = ImagePackage.Image;
                PackageGameSave.HeaderData.ContentImage = ImageContent.Image;

                PackageGameSave.Finish();

                UpdateStatus("Successfully saved and resigned game save.");
                XtraMessageBox.Show(this, "Successfully saved and resigned game save!", Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                UpdateStatus("Unable to save or resign game save.", ex);
                XtraMessageBox.Show(this, $"Unable to save or resign game save file.\n\nError Message: {ex.Message}", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackupFile()
        {
            UpdateStatus($"Creating backup of file: {Path.GetFileName(PackageGameSavePath)}");
            new FileInfo(PackageGameSavePath).CopyTo($"{PackageGameSavePath}.bak");
            UpdateStatus($"Successfully created backup file.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="ex"></param>
        public void UpdateStatus(string status, Exception ex = null)
        {
            if (InvokeRequired)
            {
                BeginInvoke((MethodInvoker)delegate
                {
                    LabelStatus.Caption = status;
                });
            }
            else
            {
                LabelStatus.Caption = status;
            }

            if (ex == null)
            {
                Program.Log.Info(status);
            }
            else
            {
                Program.Log.Error(ex, status);
            }
        }
    }
}