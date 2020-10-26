using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;

namespace ModioX.Extensions
{
    internal static class HttpExtensions
    {
        /// <summary>
        ///     Initialize new http web request
        /// </summary>
        /// <param name="requestUriString">File URL</param>
        /// <param name="httpMethod">Method for the request</param>
        /// <param name="allowAutoRedirect">Whether request should follow redirection responses</param>
        /// <param name="contentType">Sets content-type http header</param>
        /// <returns>Returns a new HTTP Web Request to Get Response from file</returns>
        public static HttpWebRequest GetRequest(string requestUriString, string httpMethod = "GET",
            bool allowAutoRedirect = true, string contentType = "text/plain")
        {
            var request = (HttpWebRequest) WebRequest.Create(requestUriString);
            request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
            request.ContentType = contentType;
            request.Timeout = Convert.ToInt32(new TimeSpan(0, 5, 0).TotalMilliseconds);
            request.AllowAutoRedirect = allowAutoRedirect;
            request.Method = httpMethod;
            return request;
        }

        public static Stream GetStream(string url)
        {
            return ((HttpWebResponse) GetRequest(url).GetResponse()).GetResponseStream();
        }

        public static Bitmap GetImageFromUrl(string url)
        {
            return new Bitmap(GetStream(url));
        }

        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool IsConnectedToInternet()
        {
            return InternetGetConnectedState(out _, 0);
        }
    }
}