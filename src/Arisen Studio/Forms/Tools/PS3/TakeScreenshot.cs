using DevExpress.XtraEditors;
using ArisenStudio.Forms.Windows;
using ArisenStudio.Models.Resources;
using System;
using System.Resources;
using ArisenStudio.Extensions;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Imgur.API.Authentication;
using System.Windows.Media.Imaging;
using System.Diagnostics;
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

        public AsyncFtpClient FtpClient = MainWindow.FtpClient;

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

        private async void ButtonTakeScreenshot_Click(object sender, EventArgs e)
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

                await WebManExtensions.ScreenshotAsync(Profile.Address, consolePath + fileName + ".bmp");

                if (await FtpExtensions.FileExistsAsync($"http://{Profile.Address}{consolePath}{fileName}.bmp"))
                {
                    await FtpClient.DownloadFile(fileLocation, consolePathUrl, FtpLocalExists.Overwrite);
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

        private async void ButtonDeleteScreenshot_Click(object sender, EventArgs e)
        {
            try
            {
                if (!LocalFilePath.IsNullOrWhiteSpace())
                {
                    LocalFilePath = "";
                    TextBoxFileName.Text = "";
                    ImageScreenshot.Image = null;
                    ButtonDeleteImage.Enabled = false;
                    ButtonNewImage.Enabled = false;
                    ButtonOpenFolder.Enabled = false;

                    File.Delete(LocalFilePath);

                    if (await FtpExtensions.FileExistsAsync(ConsoleFilePath))
                    {
                        await FtpClient.DeleteFile(ConsoleFilePath);
                    }

                    Program.Log.Info($"Deleted screenshot file: {LocalFilePath}");
                }
            }
            catch (Exception ex)
            {
                Program.Log.Error(string.Format("Unable to delete screenshot. Error: {0}", ex.Message));
                _ = MessageBox.Show(string.Format("Unable to delete screenshot. Error: {0}", ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public async void DownloadScreenshot(string ip, string filePath, string localPath)
        {
            await HttpExtensions.DownloadFileAsync($"http://{Profile.Address}/{filePath}", localPath);
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