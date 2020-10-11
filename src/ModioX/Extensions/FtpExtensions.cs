using DarkUI.Forms;
using ModioX.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    internal static class FtpExtensions
    {
        /// <summary>
        ///     Upload a local file to the specified location on the console
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="localFile">Path of the local file</param>
        /// <param name="consoleFile">Path of the uploading file directory</param>
        internal static void UploadFile(string localFile, string consoleFile)
        {
            FtpConnection ftpConnection = MainWindow.GetFtpConnection();

            string dirPath = consoleFile.Contains("/")
                    ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
                    : "dev_hdd0/";

                string fileName = consoleFile.Contains("/")
                        ? consoleFile.Substring(consoleFile.LastIndexOf('/')).Replace("/", "").Replace("//", "")
                        : consoleFile;

                if (!ftpConnection.DirectoryExists(dirPath))
                {
                    FtpExtensions.CreateDirectory(dirPath);
                }

                ftpConnection.SetCurrentDirectory(dirPath);
                ftpConnection.PutFile(localFile, fileName);
            }


        /// <summary>
        ///     Uninstall a specified file from the console
        /// </summary>
        /// <param name="hostAddress">Console address to connect to</param>
        /// <param name="consoleFile">Mod to uninstall</param>
        internal static void DeleteFile(string consoleFile)
        {
            FtpConnection ftpConnection = MainWindow.GetFtpConnection();

            string dirPath = consoleFile.Contains("/")
                ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
                : "/dev_hdd0/";

            string fileName = consoleFile.Contains("/")
                ? consoleFile.Substring(consoleFile.LastIndexOf('/')).Replace("/", "").Replace("//", "")
                : consoleFile;

            ftpConnection.SetCurrentDirectory(dirPath);

            if (ftpConnection.FileExists(consoleFile))
            {
                ftpConnection.RemoveFile(consoleFile);
            }
        }

        /// <summary>
        ///     Downloads the specified console file to the computer
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="localFile">Path of the local file</param>
        /// <param name="consoleFile">Path of the uploading file directory</param>
        internal static void DownloadFile(string localFile, string consoleFile)
        {
            FtpConnection ftpConnection = MainWindow.GetFtpConnection();

            string dirPath = consoleFile.Contains("/")
            ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
            : "/dev_hdd0/";

            string fileName = consoleFile.Contains("/")
                    ? consoleFile.Substring(consoleFile.LastIndexOf('/')).Replace("/", "").Replace("//", "")
                    : consoleFile;

            ftpConnection.SetLocalDirectory(Path.GetDirectoryName(localFile));
            ftpConnection.SetCurrentDirectory(dirPath);
            ftpConnection.GetFile(consoleFile, localFile, false);

        }

        /// <summary>
        ///     Downloads the specified console file to the computer
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="consoleFile">Path of the uploading file directory</param>
        internal static bool FileExists(string consoleFile)
        {
            FtpConnection ftpConnection = MainWindow.GetFtpConnection();

            string dirPath = consoleFile.Contains("/")
            ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
            : "/dev_hdd0/";

            ftpConnection.SetCurrentDirectory(dirPath);

            return ftpConnection.FileExists(consoleFile);
        }

        /// <summary>
        ///     Downloads the specified console file to the computer
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="consolePath"></param>
        /// <param name="folderName"></param>
        /// <returns>Whether the directory was created or not.</returns>
        internal static bool CreateDirectory(string consolePath)
        {
            // Use the WebRequest method because FtpConnection throws an error and this doesn't, strange
            WebRequest request = WebRequest.Create("ftp://" + MainWindow.ConsoleProfile.Address + consolePath);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            request.Credentials = new NetworkCredential(MainWindow.ConsoleProfile.Username, MainWindow.ConsoleProfile.Password);

            using (var resp = (FtpWebResponse)request.GetResponse())
            {
                if (resp.StatusCode == FtpStatusCode.PathnameCreated)
                    return true;
                else
                    return false;
            }
        }

        public static void DeleteDirectory(string consolePath)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + MainWindow.ConsoleProfile.Address + consolePath);
            request.EnableSsl = false;
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = new NetworkCredential(MainWindow.ConsoleProfile.Username, MainWindow.ConsoleProfile.Password);

            List<string> lines = new List<string>();

            using (FtpWebResponse listResponse = (FtpWebResponse)request.GetResponse())
            using (Stream listStream = listResponse.GetResponseStream())
            using (StreamReader listReader = new StreamReader(listStream))
            {
                while (!listReader.EndOfStream)
                {
                    lines.Add(listReader.ReadLine());
                }
            }

            foreach (string line in lines)
            {
                string[] tokens =
                    line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[8];
                string permissions = tokens[0];

                string fileUrl = "ftp://" + MainWindow.ConsoleProfile.Address + consolePath + name;

                if (permissions[0] == 'd')
                {
                    DeleteDirectory(fileUrl + "/");
                }
                else
                {
                    FtpWebRequest deleteRequest = (FtpWebRequest)WebRequest.Create(fileUrl);
                    deleteRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                    deleteRequest.Credentials = request.Credentials;

                    deleteRequest.GetResponse();
                }
            }

            FtpWebRequest removeRequest = (FtpWebRequest)WebRequest.Create("ftp://" + MainWindow.ConsoleProfile.Address + consolePath);
            removeRequest.Method = WebRequestMethods.Ftp.RemoveDirectory;
            removeRequest.Credentials = request.Credentials;

            removeRequest.GetResponse();
        }

        /// <summary>
        ///     Downloads the specified console file to the computer
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="consolePath">Path of the uploading file directory</param>
        internal static bool DirectoryExists(string consolePath)
        {
            FtpConnection ftpConnection = MainWindow.GetFtpConnection();

            return ftpConnection.DirectoryExists(consolePath);
        }

        /// <summary>
        ///     Gets the folder names inside the specified console path
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="consolePath">Path of the uploading file directory</param>
        internal static List<string> GetFolderNames(string consolePath)
        {
            FtpConnection ftpConnection = MainWindow.GetFtpConnection();

            List<string> folderNames = new List<string>();

            string dirPath = consolePath.Contains("/")
            ? consolePath.Substring(0, consolePath.LastIndexOf('/')) + '/'
            : "/dev_hdd0/";

            ftpConnection.SetCurrentDirectory(dirPath);

            foreach (FtpDirectoryInfo path in ftpConnection.GetDirectories(dirPath))
            {
                folderNames.Add(path.Name);
            }

            folderNames.RemoveRange(0, 2);

            return folderNames;
        }

        /// <summary>
        ///     Prompts the user to choose their user id
        /// </summary>
        /// <param name="hostAddress">Console IP Address</param>
        /// <returns></returns>
        public static string GetUserId(Form owner)
        {
            List<string> userIds = GetFolderNames("/dev_hdd0/home/");

            if (userIds.Count < 1)
            {
                _ = DarkMessageBox.Show(MainWindow.mainForm, "Could not find any users on your console. Make sure you have created at least one user profile and then try again.", "No Users Found", MessageBoxIcon.Error);
                return null;
            }
            else
            {
                return DialogExtensions.ShowListInputDialog(owner, "User Profile IDs", userIds);
            }
        }

        /// <summary>
        ///     Returns the USB path if one is connected to the console port
        /// </summary>
        /// <param name="hostAddress">Console IP Address</param>
        /// <returns></returns>
        internal static string GetUsbPath()
        {
            string[] usbPaths = new string[]
            {
                    "/dev_usb000/",
                    "/dev_usb001/"
            };

            foreach (string usbPath in usbPaths)
            {
                if (DirectoryExists(usbPath))
                {
                    return usbPath;
                }
            }

            _ = DarkMessageBox.Show(MainWindow.mainForm, "No USB devices are connected to your console. Make sure there is at least one device connected for installing mods.", "No USB Device", MessageBoxIcon.Error);
            return null;
        }
    }
}