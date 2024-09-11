using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using System;
using System.Resources;
using XDevkit;
using ArisenStudio.Extensions;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Imgur.API.Authentication;
using System.Windows.Media.Imaging;
using System.Diagnostics;
using PS3Lib;
using FluentFTP;

namespace ArisenStudio.Forms.Tools.PS3
{
    public partial class TakeScreenshot : XtraForm
    {
        public TakeScreenshot()
        {
            InitializeComponent();
        }

        public static ResourceManager Language = MainWindow.ResourceLanguage;

        public static SettingsData Settings = MainWindow.Settings;

        public ConsoleProfile Profile = MainWindow.ConsoleProfile;

        public FtpClient FtpClient = MainWindow.FtpClient;

        //private PS3API Ps3 = new(SelectAPI.PS3Manager);

        private ApiClient ImgurClient = new("f123f19ee8fa247");

        private void TakeScreenshot_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("TAKE_SCREENSHOT");

            ButtonCaptureImage.Text = Language.GetString("CAPTURE_IMAGE");
            ButtonDeleteImage.Text = Language.GetString("DELETE_IMAGE");
            ButtonNewImage.Text = Language.GetString("NEW_IMAGE");
            ButtonOpenFolder.Text = Language.GetString("OPEN_FOLDER");
        }

        private string LocalFilePath = null;
        private string ConsoleFilePath = null;

        private void ButtonTakeScreenshot_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Settings.PathAppData, "Screenshots", "PS3") + @"\";
                string fileName = TextBoxFileName.Text.Trim(' ', '.');

                if (TextBoxFileName.Text.IsNullOrWhiteSpace())
                {
                    fileName = $"Screenshot-{DateTime.Now:MM/dd/yyyy HH:mm:ss}";
                }

                if (Path.HasExtension(fileName))
                {
                    fileName = Path.GetFileNameWithoutExtension(fileName);
                }

                fileName = fileName.RemoveInvalidChars();

                string fileLocation = filePath + fileName + ".bmp";

                string consolePath = $"/dev_hdd0/dev_hdd0/tmp/screenshots/";
                string consolePathUrl = $"http://{Profile.Address}{consolePath}{fileName}.bmp";

                WebManExtensions.Screenshot(Profile.Address, consolePath + fileName + ".bmp");

                //HttpExtensions.DownloadFile($"http://{ip}{consoleFilePath}", localFilePath);

                if (FtpExtensions.FileExists($"http://{Profile.Address}{consolePath}{fileName}.bmp"))
                {
                    _ = FtpClient.DownloadFile(fileLocation, consolePathUrl, FtpLocalExists.Overwrite);
                }

                try
                {
                    ImageScreenshot.Image = HttpExtensions.GetImageFromUrl(consolePathUrl);
                }
                catch
                {
                    ImageScreenshot.Image = new Bitmap(fileLocation);
                }

                LocalFilePath = fileLocation;
                ConsoleFilePath = consolePathUrl;

                Program.Log.Info($"Screenshot file saved to path: {filePath}");

                _ = XtraMessageBox.Show(string.Format("Screenshot file saved to path:\n{0}", filePath), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (CheckBoxUploadToImgur.Checked)
                {
                    UploadImage(ImageExtensions.ConvertBitmap(new Bitmap(fileLocation)), ImgurClient);
                }
            }
            catch (Exception ex)
            {
                Program.Log.Error(string.Format("Unable to take screenshot. Error: {0}", ex.Message));
                _ = MessageBox.Show(string.Format("Unable to take screenshot. Error: {0}", ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDeleteScreenshot_Click(object sender, EventArgs e)
        {
            if (!LocalFilePath.IsNullOrWhiteSpace())
            {
                LocalFilePath = "";
                File.Delete(LocalFilePath);
                TextBoxFileName.Text = "";
                ImageScreenshot.Image = null;
                ButtonDeleteImage.Enabled = false;
                ButtonNewImage.Enabled = false;
                ButtonOpenFolder.Enabled = false;
                Program.Log.Info($"Deleted screenshot file: {LocalFilePath}");
            }
        }

        private void ButtonNewScreenshot_Click(object sender, EventArgs e)
        {
            if (!LocalFilePath.IsNullOrWhiteSpace())
            {
                LocalFilePath = "";
                TextBoxFileName.Text = "";
                ImageScreenshot.Image = null;
                ButtonDeleteImage.Enabled = false;
                ButtonNewImage.Enabled = false;
                ButtonOpenFolder.Enabled = false;
                Program.Log.Info($"Cleared current screenshot.");
            }
        }

        private void ButtonOpenFilePath_Click(object sender, EventArgs e)
        {
            if (File.Exists(LocalFilePath))
            {
                _ = Process.Start("explorer.exe", "/select, " + LocalFilePath);
            }
        }

        public void DownloadScreenshot(string ip, string filePath, string localPath)
        {
            HttpExtensions.DownloadFile($"http://{Profile.Address}/{filePath}", localPath);
        }

        private async void UploadImage(BitmapSource bitmap, ApiClient apiClient)
        {
            Program.Log.Info(string.Format("Uploading screenshot file..."));

            try
            {
                string link = await ImgurUploader.Upload(bitmap, Path.GetFileNameWithoutExtension(LocalFilePath), apiClient);

                if (link == "Error")
                {
                    Program.Log.Error(string.Format("Unable to upload screenshot file."));
                    _ = MessageBox.Show("Unable to upload screenshot file.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _ = Process.Start(link);
            }
            catch (Exception ex)
            {
                Program.Log.Error(string.Format("Unable to upload screenshot file. Error: {0}", ex.Message));
                _ = MessageBox.Show(string.Format("Unable to upload screenshot file. Error: {0}", ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}