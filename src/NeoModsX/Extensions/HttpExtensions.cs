using NeoModsX.Models.Game_Updates;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Xml.Serialization;

namespace NeoModsX.Extensions
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
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
            ServicePointManager.ServerCertificateValidationCallback = (_, _, _, _) => true;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUriString);
            request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
            request.ContentType = contentType;
            request.Timeout = Convert.ToInt32(new TimeSpan(0, 5, 0).TotalMilliseconds);
            request.AllowAutoRedirect = allowAutoRedirect;
            request.Method = httpMethod;
            return request;
        }

        /// <summary>
        /// </summary>
        /// <param name="url">  </param>
        /// <returns></returns>
        public static Stream GetStream(string url)
        {
            return ((HttpWebResponse)GetRequest(url).GetResponse()).GetResponseStream();
        }

        /// <summary>
        /// </summary>
        /// <param name="titleId">  </param>
        /// <returns> </returns>
        public static Titlepatch GetGameUpdatesFromTitleID(string titleId)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
                ServicePointManager.ServerCertificateValidationCallback = (_, _, _, _) => true;

                using WebClient webClient = new();
                XmlSerializer serializer = new(typeof(Titlepatch));
                string titlePath = webClient.DownloadString("https://a0.ww.np.dl.playstation.net/tpl/np/" + titleId + "/" +
                                                            titleId + "-ver.xml");
                using TextReader textReader = new StringReader(titlePath);
                return (Titlepatch)serializer.Deserialize(textReader);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex,
                    $"Unable to fetch game update for title ID: {titleId} or it wasn't recognized. Error Message: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="url"> </param>
        /// <param name="filePath"> </param>
        public static void DownloadFile(string url, string filePath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
            ServicePointManager.ServerCertificateValidationCallback = (_, _, _, _) => true;

            WebClient webClient = new();
            webClient.DownloadFile(url, filePath);
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
        //public static async Task<bool> CheckForInternetAsync()
        public static bool CheckForInternetConnection()
        {
            try
            {
                Program.Log.Info("Checking for Internet connection...");
                return NetworkInterface.GetIsNetworkAvailable();
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to check for Internet connection. Error: " + ex.Message);
            }

            return false;
        }
    }
}