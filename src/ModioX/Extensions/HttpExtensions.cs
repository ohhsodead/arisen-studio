using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModioX.Models.Game_Updates;

namespace ModioX.Extensions
{
    internal static class HttpExtensions
    {
        /// <summary>
        /// Initialize new http web request
        /// </summary>
        /// <param name="requestUriString"> File URL </param>
        /// <param name="httpMethod"> Method for the request </param>
        /// <param name="allowAutoRedirect"> Whether request should follow redirection responses </param>
        /// <param name="contentType"> Sets content-type http header </param>
        /// <returns> Returns a new HTTP Web Request to Get Response from file </returns>
        public static HttpWebRequest GetRequest(string requestUriString, string httpMethod = "GET", bool allowAutoRedirect = true, string contentType = "text/plain")
        {
            var request = (HttpWebRequest)WebRequest.Create(requestUriString);
            request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
            request.ContentType = contentType;
            request.Timeout = Convert.ToInt32(new TimeSpan(0, 5, 0).TotalMilliseconds);
            request.AllowAutoRedirect = allowAutoRedirect;
            request.Method = httpMethod;
            return request;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Stream GetStream(string url)
        {
            return ((HttpWebResponse)GetRequest(url).GetResponse()).GetResponseStream();
        }

        /// <summary>
        /// </summary>
        /// <param name="titleId"> </param>
        /// <returns> </returns>
        public static string GetGameTitleFromTitleID(string titleId)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = (_, _, _, _) => true;

                using var webClient = new WebClient();
                var serializer = new XmlSerializer(typeof(Titlepatch));
                var titlePath = webClient.DownloadString("https://a0.ww.np.dl.playstation.net/tpl/np/" + titleId + "/" + titleId + "-ver.xml");
                using TextReader textReader = new StringReader(titlePath);
                var data = (Titlepatch)serializer.Deserialize(textReader);
                var removeId = Regex.Replace(data.Tag.Package.Last().Paramsfo.TITLE, @"\(.*?\)", "").Trim().Replace("Â®", "®");
                return removeId;
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to fetch game title from ID: {0}", titleId);
                return "Not Recognized";
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="url"> </param>
        /// <param name="titleId"> </param>
        /// <returns> </returns>
        public static Titlepatch GetGameUpdatesFromTitleID(string url, string titleId)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = (_, _, _, _) => true;

                using var webClient = new WebClient();
                var serializer = new XmlSerializer(typeof(Titlepatch));
                var titlePath = webClient.DownloadString(url + titleId + "/" + titleId + "-ver.xml");
                using TextReader textReader = new StringReader(titlePath);
                return (Titlepatch)serializer.Deserialize(textReader);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to fetch game update from title ID: {0}", titleId);
                return null;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="url"> </param>
        /// <param name="folderPath"> </param>
        public static void DownloadFile(string url, string folderPath)
        {
            ServicePointManager.ServerCertificateValidationCallback = (_, _, _, _) => true;
            var webClient = new WebClient();
            webClient.DownloadFile(url, folderPath);
        }

        /// <summary>
        /// </summary>
        /// <param name="url"> </param>
        /// <returns> </returns>
        public static Bitmap GetImageFromUrl(string url)
        {
            return new(GetStream(url));
        }

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static async Task<bool> CheckForInternetAsync()
        {
            var ping = new Ping();

            try
            {
                Program.Log.Info("Checking for Internet connection...");

                if ((await ping.SendPingAsync("dropbox.com", 3000, new byte[32], new PingOptions(64, true)).ConfigureAwait(false)).Status == IPStatus.Success)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to check for Internet connection.");
            }

            return false;
        }
    }
}