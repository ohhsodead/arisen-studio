using Imgur.API.Authentication;
using Imgur.API.Endpoints;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ArisenStudio.Extensions
{
    internal class ImgurUploader
    {
        static public async Task<string> Upload(BitmapSource bitmap, ApiClient apiClient)
        {
            string link = "";

            using (var fileStream = new FileStream("img.png", FileMode.Create))
            {
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmap));
                encoder.Save(fileStream);
            }

            try
            {
                using HttpClient httpClient = new();

                string filePath = @"img.png";
                using var fileStream = File.OpenRead(filePath);

                ImageEndpoint imageEndpoint = new(apiClient, httpClient);
                var imageUpload = await imageEndpoint.UploadImageAsync(fileStream);

                link = imageUpload?.Link ?? "Error";
            }
            catch
            {
                link = "Error";
            }

            return link;
        }
    }
}
