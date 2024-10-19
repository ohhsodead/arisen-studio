using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using FluentFTP;
using System.Linq;
using ArisenStudio.Models.Database;
using System.IO.Compression;
using ArisenStudio.Constants;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Humanizer;
using System.Threading;
using ArisenStudio.Models.GameData.PS3;

namespace ArisenStudio.Extensions
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
        /// <param name="url"> URL to get stream </param>
        /// <returns></returns>
        public static Stream GetStream(string url)
        {
            return ((HttpWebResponse)GetRequest(url).GetResponse()).GetResponseStream();
        }

        /// <summary>
        /// </summary>
        /// <param name="titleId">  </param>
        /// <returns> </returns>
        public static Titlepatch GetGameUpdatesFromTitleId(string titleId)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
                ServicePointManager.ServerCertificateValidationCallback = (_, _, _, _) => true;

                using WebClient webClient = new();
                XmlSerializer serializer = new(typeof(Titlepatch));
                string titlePath = webClient.DownloadString("https://a0.ww.np.dl.playstation.net/tpl/np/" + titleId + "/" + titleId + "-ver.xml");
                using TextReader textReader = new StringReader(titlePath);
                return (Titlepatch)serializer.Deserialize(textReader);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, $"Unable to fetch game update for title ID: {titleId} or it wasn't recognized. Error Message: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="url"> </param>
        /// <param name="filePath"> </param>
        public static async Task<bool> DownloadFileAsync(string url, string filePath, IProgress<int> progress = null, LabelControl statusLabel = null, CancellationToken cancellationToken = default)
        {
            _ = Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
            ServicePointManager.ServerCertificateValidationCallback = (_, _, _, _) => true;

            using WebClient webClient = new();
            var tcs = new TaskCompletionSource<bool>();

            // Register the cancellation token to cancel the download
            cancellationToken.Register(() => webClient.CancelAsync());

            // Set label visible only when some download progress has been made
            bool hasProgressStarted = false;

            webClient.DownloadProgressChanged += (sender, e) =>
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    tcs.SetCanceled();
                    return;
                }

                long bytesDownloaded = e.BytesReceived;
                long totalBytes = e.TotalBytesToReceive;
                string progressMessage = $"{ByteSizeExtensions.Bytes(bytesDownloaded).Humanize()} / {ByteSizeExtensions.Bytes(totalBytes).Humanize()}"; // ({e.ProgressPercentage}%)

                // Report progress to the progress bar
                progress?.Report(e.ProgressPercentage);

                // Safely update the label if provided and if it's not disposed
                if (statusLabel != null && !statusLabel.IsDisposed && statusLabel.IsHandleCreated)
                {
                    if (!hasProgressStarted && e.ProgressPercentage > 0)
                    {
                        // Only make the label visible when download progress starts
                        hasProgressStarted = true;
                        if (statusLabel.InvokeRequired)
                        {
                            statusLabel.Invoke((MethodInvoker)(() => statusLabel.Visible = true));
                        }
                        else
                        {
                            statusLabel.Visible = true;
                        }
                    }

                    if (statusLabel.InvokeRequired)
                    {
                        statusLabel.Invoke((MethodInvoker)(() => statusLabel.Text = progressMessage));
                    }
                    else
                    {
                        statusLabel.Text = progressMessage;
                    }
                }
            };

            webClient.DownloadFileCompleted += (sender, e) =>
            {
                if (e.Error == null && !e.Cancelled)
                {
                    // Download succeeded
                    tcs.SetResult(true);
                }
                else if (e.Cancelled)
                {
                    // Download was cancelled
                    tcs.SetCanceled();
                }
                else
                {
                    // Download failed due to an error
                    tcs.SetException(e.Error);
                }

                // Safely hide or reset the label on completion if it's not disposed
                if (statusLabel != null && !statusLabel.IsDisposed && statusLabel.IsHandleCreated)
                {
                    if (statusLabel.InvokeRequired)
                    {
                        statusLabel.Invoke((MethodInvoker)(() => statusLabel.Visible = false));
                    }
                    else
                    {
                        statusLabel.Visible = false;
                    }
                }
            };

            try
            {
                webClient.DownloadFileAsync(new Uri(url), filePath);
                return await tcs.Task;
            }
            catch (OperationCanceledException)
            {
                // Handle cancellation case
                return false; // Return false if the download was canceled
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                throw new Exception("There was an issue trying to downloading the file. Error: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="url"> </param>
        /// <returns> </returns>
        public static Bitmap GetImageFromUrl(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            return new(responseStream);
        }

        public static bool CheckInternetConnection()
        {
            return NetworkInterface.GetAllNetworkInterfaces().Any(static x => x.OperationalStatus == OperationalStatus.Up);
        }
    }
}