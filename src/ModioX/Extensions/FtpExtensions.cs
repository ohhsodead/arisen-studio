using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using DarkUI.Forms;
using FluentFTP;
using ModioX.Forms.Windows;
using ModioX.Net;

namespace ModioX.Extensions
{
    internal static class FtpExtensions
    {
        /// <summary>
        ///     Upload a local file to the specified location on the console
        /// </summary>
        /// <param name="ftpConnection">PS3 IP address</param>
        /// <param name="localFile">Path of the local file</param>
        /// <param name="consoleFile">Path of the uploading file directory</param>
        internal static void UploadFile(FtpConnection ftpConnection, string localFile, string consoleFile)
        {
            string dirPath = consoleFile.Contains("/")
                    ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
                    : "dev_hdd0/";

            string fileName = consoleFile.Contains("/")
                    ? consoleFile.Substring(consoleFile.LastIndexOf('/')).Replace("/", "").Replace("//", "")
                    : consoleFile;

            if (!ftpConnection.DirectoryExists(dirPath))
            {
                CreateDirectory(dirPath);
            }

            ftpConnection.SetCurrentDirectory(dirPath);
            ftpConnection.PutFile(localFile, fileName);
        }

        /// <summary>
        ///     Uninstall a specified file from the console
        /// </summary>
        /// <param name="ftpConnection">Mod to uninstall</param>
        /// <param name="consoleFile">Mod to uninstall</param>
        internal static void DeleteFile(FtpClient ftpClient, string consoleFile)
        {
            if (ftpClient.FileExists(consoleFile))
            {
                ftpClient.DeleteFile(consoleFile);
            }
        }

        /// <summary>
        ///     Uninstall a specified file from the console
        /// </summary>
        /// <param name="ftpConnection">Mod to uninstall</param>
        /// <param name="consolePath">Mod to uninstall</param>
        internal static void DeleteDirectory(FtpClient ftpClient, string consolePath)
        {
            var dirPath = consolePath.Contains("/")
                ? consolePath.Substring(0, consolePath.LastIndexOf('/')) + '/'
                : "dev_hdd0/";

            ftpClient.SetWorkingDirectory(dirPath);

            if (ftpClient.DirectoryExists(consolePath))
            {
                ftpClient.DeleteDirectory(consolePath);
            }
        }

        /// <summary>
        ///     Downloads the specified console file to the computer
        /// </summary>
        /// <param name="localFile">Path of the local file</param>
        /// <param name="consoleFile">Path of the uploading file directory</param>
        internal static void DownloadFile(string localFile, string consoleFile)
        {
            var ftpConnection = MainWindow.FtpConnection;

            var dirPath = consoleFile.Contains("/")
                ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
                : "dev_hdd0/";

            ftpConnection.SetLocalDirectory(Path.GetDirectoryName(localFile));
            ftpConnection.SetCurrentDirectory(dirPath);
            ftpConnection.GetFile(consoleFile, localFile, false);
        }

        internal static bool IsDirectoryEmpty(FtpClient ftpClient, string consolePath)
        {
            int itemCount = 0;

            foreach (FtpListItem listItem in ftpClient.GetListing(consolePath))
            {
                switch (listItem.Type)
                {
                    case FtpFileSystemObjectType.Directory:
                        itemCount++;
                        break;

                    case FtpFileSystemObjectType.File:
                        itemCount++;
                        break;

                    case FtpFileSystemObjectType.Link:
                        break;
                }
            }

            return itemCount == 0;
        }

        /// <summary>
        ///     Downloads the specified console file to the computer
        /// </summary>
        /// <param name="filePath">Path of the uploading file directory</param>
        internal static bool FileExists(string filePath)
        {
            var ftpConnection = MainWindow.FtpConnection;

            var dirPath = filePath.Contains("/")
                ? filePath.Substring(0, filePath.LastIndexOf('/')) + '/'
                : "dev_hdd0/";

            ftpConnection.SetCurrentDirectory(dirPath);

            return ftpConnection.FileExists(filePath);
        }

        /// <summary>
        ///     Renames the specified file to a new name
        /// </summary>
        /// <param name="ftpConnection"></param>
        /// <param name="filePath"></param>
        /// <param name="newName"></param>
        internal static void RenameFileOrFolder(FtpConnection ftpConnection, string filePath, string newName)
        {
            // Use the WebRequest method because FtpConnection throws an error and this doesn't, strange
            var request = (FtpWebRequest) WebRequest.Create("ftp://" + ftpConnection.Host + filePath);
            request.Method = WebRequestMethods.Ftp.Rename;
            request.Credentials = new NetworkCredential(MainWindow.ConsoleProfile.Username, MainWindow.ConsoleProfile.Password);
            request.RenameTo = newName;
            _ = request.GetResponse();
        }

        /// <summary>
        ///     Downloads the specified console file to the computer
        /// </summary>
        /// <param name="consolePath"></param>
        /// <returns>Whether the directory was created or not.</returns>
        internal static bool CreateDirectory(string consolePath)
        {
            // Use the WebRequest method because FtpConnection throws an error and this doesn't, strange
            var request = WebRequest.Create("ftp://" + MainWindow.ConsoleProfile.Address + consolePath);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            request.Credentials =
                new NetworkCredential(MainWindow.ConsoleProfile.Username, MainWindow.ConsoleProfile.Password);

            using (var resp = (FtpWebResponse) request.GetResponse())
            {
                if (resp.StatusCode == FtpStatusCode.PathnameCreated)
                {
                    return true;
                }

                return false;
            }
        }

        internal static void DownloadDirectory(string consolePath, string localPath)
        {
            var url = "ftp://" + MainWindow.ConsoleProfile.Address + consolePath;
            var credentials =
                new NetworkCredential(MainWindow.ConsoleProfile.Username, MainWindow.ConsoleProfile.Password);

            var request = (FtpWebRequest) WebRequest.Create(url);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = credentials;
            request.Timeout = -1;

            var lines = new List<string>();

            using (var listResponse = (FtpWebResponse) request.GetResponse())
            using (var listStream = listResponse.GetResponseStream())
            using (var listReader = new StreamReader(listStream))
            {
                while (!listReader.EndOfStream)
                {
                    lines.Add(listReader.ReadLine());
                }
            }

            foreach (var line in lines)
            {
                var tokens =
                    line.Split(new[] {' '}, 9, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[8];
                var permissions = tokens[0];

                var localFilePath = Path.Combine(localPath, name);
                var fileUrl = url + name;

                if (permissions[0] == 'd')
                {
                    if (!Directory.Exists(localFilePath))
                    {
                        _ = Directory.CreateDirectory(localFilePath);
                    }

                    DownloadDirectory(fileUrl, localFilePath);
                }
                else
                {
                    var downloadRequest = (FtpWebRequest) WebRequest.Create(fileUrl);
                    downloadRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                    downloadRequest.Credentials = credentials;
                    downloadRequest.Timeout = -1;

                    using (var downloadResponse = (FtpWebResponse) downloadRequest.GetResponse())
                    using (var sourceStream = downloadResponse.GetResponseStream())
                    using (Stream targetStream = File.Create(localFilePath))
                    {
                        var buffer = new byte[10240];
                        int read;
                        while (sourceStream != null && (read = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            targetStream.Write(buffer, 0, read);
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Gets the folder names inside the specified console path
        /// </summary>
        /// <param name="consolePath">Path of the uploading file directory</param>
        internal static List<string> GetFolderNames(string consolePath)
        {
            var ftpConnection = MainWindow.FtpConnection;

            var folderNames = new List<string>();

            var dirPath = consolePath.Contains("/")
                ? consolePath.Substring(0, consolePath.LastIndexOf('/')) + '/'
                : "/dev_hdd0/";

            ftpConnection.SetCurrentDirectory(dirPath);

            foreach (var directoryInfo in ftpConnection.GetDirectories(dirPath).Skip(2))
            {
                folderNames.Add(directoryInfo.Name);
            }

            return folderNames;
        }

        /// <summary>
        ///     Prompts the user to choose their user id
        /// </summary>
        /// <param name="owner">Console IP Address</param>
        /// <returns></returns>
        public static string GetUserId(Form owner)
        {
            var userIds = GetFolderNames("/dev_hdd0/home/");

            if (userIds.Count >= 1)
            {
                return DialogExtensions.ShowListInputDialog(owner, "User Profile IDs", userIds);
            }
            _ = DarkMessageBox.Show(owner,
                "Could not find any users on your console. Make sure you have at least one user profile and then try again.",
                "No Users Found", MessageBoxIcon.Error);
            return null;
        }

        /// <summary>
        ///     Returns the USB path if one is connected to the console port
        /// </summary>
        /// <returns></returns>
        public static string GetUsbPath()
        {
            string[] usbPaths =
            {
                "dev_usb000",
                "dev_usb001",
                "dev_usb002",
                "dev_usb003"
            };

            var folderNames = GetFolderNames("/");

            foreach (var usbPath in usbPaths)
            {
                if (folderNames.Contains(usbPath))
                {
                    return usbPath;
                }
            }

            _ = DarkMessageBox.Show(MainWindow.Window, "You do not have a USB device connected to your console.", "Error", MessageBoxIcon.Error);
            return null;
        }
    }
}