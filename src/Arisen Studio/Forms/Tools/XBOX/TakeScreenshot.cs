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

namespace ArisenStudio.Forms.Tools.XBOX
{
    public partial class TakeScreenshot : XtraForm
    {
        public TakeScreenshot()
        {
            InitializeComponent();
        }

        public static ResourceManager Language = MainWindow.ResourceLanguage;

        public static SettingsData Settings = MainWindow.Settings;

        public static IXboxConsole XboxConsole { get; } = MainWindow.XboxConsole;

        private ApiClient ImgurClient { get; } = new("f123f19ee8fa247");

        private void TakeScreenshot_Load(object sender, EventArgs e)
        {
            Text = Language.GetString("TAKE_SCREENSHOT");

            ButtonCaptureImage.Text = Language.GetString("CAPTURE_IMAGE");
            ButtonDeleteImage.Text = Language.GetString("DELETE_IMAGE");
            ButtonNewImage.Text = Language.GetString("NEW_IMAGE");
            ButtonOpenFolder.Text = Language.GetString("OPEN_FOLDER");
        }

        private string LocalFilePath;

        private void ButtonTakeScreenshot_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Settings.PathAppData, "Screenshots", "Xbox") + @"\";
                string fileName = TextBoxFileName.Text;

                if (TextBoxFileName.Text.IsNullOrWhiteSpace())
                {
                    fileName = $"Screenshot-{DateTime.Now:MM/dd/yyyy HH:mm:ss}";
                }

                if (Path.HasExtension(fileName))
                {
                    fileName = Path.GetFileNameWithoutExtension(fileName);
                }

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                fileName = fileName.RemoveInvalidChars();

                string fileLocation = filePath + fileName + ".bmp";

                Program.Log.Info("Local File Path: " +  fileLocation);

                XboxConsole.ScreenShot(fileLocation);
                ImageScreenshot.Image = new Bitmap(fileLocation);
                LocalFilePath = fileLocation;
                ButtonDeleteImage.Enabled = true;
                ButtonNewImage.Enabled = true;
                ButtonOpenFolder.Enabled = true;

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

        private async void UploadImage(BitmapSource bitmap, ApiClient apiClient)
        {
            Program.Log.Info(string.Format("Uploading screenshot file..."));

            try
            {
                string link = await ImgurUploader.Upload(bitmap, apiClient);

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