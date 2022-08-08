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

            ButtonRefreshModules.Text = Language.GetString("LABEL_LOAD_MODULE");
            ButtonCancel.Text = Language.GetString("LABEL_UNLOAD_MODULE");
        }

        private string ScreenshotFile;

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (ScreenshotFile.IsNullOrWhiteSpace())
            {
                File.Delete(ScreenshotFile);
                TextBoxFileName.Text = "";
                ImageScreenshot.Image = null;
                Program.Log.Info($"Deleted screenshot file: {ScreenshotFile}");
            }

            Close();
        }

        private void ButtonTakeScreenshot_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Settings.PathBaseDirectory, "Xbox Screenshots") + @"\";
                string fileName = TextBoxFileName.Text;

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

                XboxConsole.ScreenShot(fileLocation);
                ImageScreenshot.Image = new Bitmap(fileLocation);
                ScreenshotFile = fileLocation;
                Program.Log.Info($"Screenshot file saved to path: {filePath}");

                XtraMessageBox.Show(string.Format("Screenshot file saved to path:\n{0}", filePath), Language.GetString("SUCCESS"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (CheckBoxUploadToImgur.Checked)
                {
                    UploadImage(ImageExtensions.ConvertBitmap(new Bitmap(fileLocation)), ImgurClient);
                }
            }
            catch (Exception ex)
            {
                Program.Log.Error(string.Format("Unable to take screenshot. Error: {0}", ex.Message));
                MessageBox.Show(string.Format("Unable to take screenshot. Error: {0}", ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Unable to upload screenshot file.", Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Process.Start(link);
            }
            catch (Exception ex)
            {
                Program.Log.Error(string.Format("Unable to upload screenshot file. Error: {0}", ex.Message));
                MessageBox.Show(string.Format("Unable to upload screenshot file. Error: {0}", ex.Message), Language.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}