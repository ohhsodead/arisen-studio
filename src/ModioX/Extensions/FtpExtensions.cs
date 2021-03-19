using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FluentFTP;
using ModioX.Forms.Windows;
using ModioX.Net;

namespace ModioX.Extensions
{
    internal static class FtpExtensions
    {
        internal static void UploadFile(string localFile, string consoleFile)
        {
            FtpConnection ftpConnection = MainWindow.FtpConnection;

            string path = consoleFile.Contains("/") ? (consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + "/") : "dev_hdd0/";
            string remoteFile = consoleFile.Contains("/") ? consoleFile.Substring(consoleFile.LastIndexOf('/')).Replace("/", "").Replace("//", "") : consoleFile;

            if (!ftpConnection.DirectoryExists(path))
            {
                CreateDirectory(path);
            }

            ftpConnection.SetCurrentDirectory(path);
            ftpConnection.PutFile(localFile, remoteFile);
        }

        /// <summary>
        /// Uninstall a specified file from the console
        /// </summary>
        /// <param name="ftpClient"> Mod to uninstall </param>
        /// <param name="consoleFile"> Mod to uninstall </param>
        internal static void DeleteFile(FtpClient ftpClient, string consoleFile)
        {
            if (ftpClient.FileExists(consoleFile)) ftpClient.DeleteFile(consoleFile);
        }

        /// <summary>
        /// Uninstall a specified file from the console
        /// </summary>
        /// <param name="ftpClient"> Mod to uninstall </param>
        /// <param name="consolePath"> Mod to uninstall </param>
        internal static void DeleteDirectory(FtpClient ftpClient, string consolePath)
        {
            string parentDirectory = Path.GetDirectoryName(consolePath).Replace(@"\", "/");

            ftpClient.SetWorkingDirectory(parentDirectory);

            if (ftpClient.DirectoryExists(consolePath))
            {
                ftpClient.DeleteDirectory(consolePath);
            }
        }

        /// <summary>
        /// Downloads the specified console file to the computer
        /// </summary>
        /// <param name="localFile"> Path of the local file </param>
        /// <param name="consoleFile"> Path of the uploading file directory </param>
        internal static void DownloadFile(string localFile, string consoleFile)
        {
            FtpConnection ftpConnection = MainWindow.FtpConnection;

            Program.Log.Info("Local file: " + localFile);
            Program.Log.Info("Console file: " + consoleFile);

            string parentDirectory = Path.GetDirectoryName(consoleFile).Replace(@"\", "/");

            ftpConnection.SetLocalDirectory(Path.GetDirectoryName(localFile));
            ftpConnection.SetCurrentDirectory(parentDirectory);

            if (File.Exists(localFile))
            {
                File.Delete(localFile);
            }

            if (FileExists(consoleFile))
            {
                ftpConnection.GetFile(consoleFile, localFile, false);
            }
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
        /// Downloads the specified console file to the computer
        /// </summary>
        /// <param name="filePath"> Path of the uploading file directory </param>
        internal static bool FileExists(string filePath)
        {
            FtpConnection ftpConnection = MainWindow.FtpConnection;

            string parentDirectory = Path.GetDirectoryName(filePath).Replace(@"\", "/");

            ftpConnection.SetCurrentDirectory(parentDirectory);

            return ftpConnection.FileExists(filePath);
        }

        /// <summary>
        /// Renames the specified file to a new name
        /// </summary>
        /// <param name="ftpConnection"> </param>
        /// <param name="filePath"> </param>
        /// <param name="newName"> </param>
        internal static void RenameFileOrFolder(FtpConnection ftpConnection, string filePath, string newName)
        {
            // Use the WebRequest method because FtpConnection throws an error and this doesn't, strange
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + ftpConnection.Host + ":" + ftpConnection.Port + filePath);
            request.Method = WebRequestMethods.Ftp.Rename;
            request.Credentials = new NetworkCredential(MainWindow.ConsoleProfile.Username, MainWindow.ConsoleProfile.Password);
            request.RenameTo = newName;
            request.GetResponse();
        }

        /// <summary>
        /// Creates the specified directory path on the console.
        /// </summary>
        /// <param name="consolePath"> </param>
        /// <returns> Whether the directory was created or not. </returns>
        internal static bool CreateDirectory(string consolePath)
        {
            // Use the WebRequest method because FtpConnection throws an error and this doesn't, strange
            WebRequest request = WebRequest.Create("ftp://" + MainWindow.ConsoleProfile.Address + ":" + MainWindow.ConsoleProfile.Port + consolePath);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            request.Credentials = new NetworkCredential(MainWindow.ConsoleProfile.Username, MainWindow.ConsoleProfile.Password);

            using FtpWebResponse resp = (FtpWebResponse)request.GetResponse();
            return resp.StatusCode == FtpStatusCode.PathnameCreated;
        }

        internal static void CreateDirectories(string consolePath)
        {
            string[] folderArray = consolePath.Split('/');
            string folderName = "";

            for (int i = 0; i < folderArray.Length; i++)
            {
                if (!string.IsNullOrEmpty(folderArray[i]))
                {
                    folderName = string.IsNullOrEmpty(folderName) ? folderArray[i] : folderName + "/" + folderArray[i];
                    WebRequest request = WebRequest.Create("ftp://" + MainWindow.ConsoleProfile.Address + ":" + MainWindow.ConsoleProfile.Port + "/" + folderName);
                    request.Method = WebRequestMethods.Ftp.MakeDirectory;
                    request.Credentials = new NetworkCredential(MainWindow.ConsoleProfile.Username, MainWindow.ConsoleProfile.Password);
                    //var response = request.GetResponse();
                    //var test = response.ToString();
                }
            }
        }

        internal static void DownloadDirectory(string consolePath, string localPath)
        {
            string url = "ftp://" + MainWindow.ConsoleProfile.Address + consolePath;
            NetworkCredential credentials = new(MainWindow.ConsoleProfile.Username, MainWindow.ConsoleProfile.Password);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = credentials;
            request.Timeout = -1;

            List<string> lines = new();

            using (FtpWebResponse listResponse = (FtpWebResponse)request.GetResponse())
            using (Stream listStream = listResponse.GetResponseStream())
            using (StreamReader listReader = new(listStream))
            {
                while (!listReader.EndOfStream) lines.Add(listReader.ReadLine());
            }

            foreach (string line in lines)
            {
                string[] tokens = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[8];
                string permissions = tokens[0];

                string localFilePath = Path.Combine(localPath, name);
                string fileUrl = url + name;

                if (permissions[0] == 'd')
                {
                    if (!Directory.Exists(localFilePath)) Directory.CreateDirectory(localFilePath);

                    DownloadDirectory(fileUrl, localFilePath);
                }
                else
                {
                    FtpWebRequest downloadRequest = (FtpWebRequest)WebRequest.Create(fileUrl);
                    downloadRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                    downloadRequest.Credentials = credentials;
                    downloadRequest.Timeout = -1;

                    using FtpWebResponse downloadResponse = (FtpWebResponse)downloadRequest.GetResponse();
                    using Stream sourceStream = downloadResponse.GetResponseStream();
                    using Stream targetStream = File.Create(localFilePath);
                    byte[] buffer = new byte[10240];
                    int read;
                    while (sourceStream != null && (read = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        targetStream.Write(buffer, 0, read);
                    }
                }
            }
        }

        /// <summary>
        /// Gets the folder names inside the specified console path.
        /// </summary>
        /// <param name="consolePath"> Path of the directory to fetch listing from </param>
        internal static List<ListItem> GetFolderNames(string consolePath)
        {
            FtpClient ftpClient = MainWindow.FtpClient;

            List<ListItem> folderNames = new();

            if (!ftpClient.DirectoryExists(consolePath))
            {
                return folderNames;
            }

            ftpClient.SetWorkingDirectory(consolePath);

            foreach (FtpListItem listItem in ftpClient.GetListing(consolePath))
            {
                switch (listItem.Type)
                {
                    case FtpFileSystemObjectType.Directory:
                        folderNames.Add(new ListItem() { Value = listItem.FullName, Name = listItem.Name });
                        break;
                }
            }

            return folderNames;
        }

        /// <summary>
        /// Gets the folder names inside the specified console path.
        /// </summary>
        /// <param name="consolePath"> Path of the directory to fetch listing from </param>
        /// <param name="recursive"> Whether to fetch files from subdirectories </param>
        internal static List<ListItem> GetFileNames(string consolePath, bool recursive = false)
        {
            FtpClient ftpClient = MainWindow.FtpClient;

            List<ListItem> fileNames = new();

            if (!ftpClient.DirectoryExists(consolePath))
            {
                return fileNames;
            }

            ftpClient.SetWorkingDirectory(consolePath);

            foreach (FtpListItem listItem in ftpClient.GetListing(consolePath, recursive ? FtpListOption.Recursive : FtpListOption.AllFiles))
            {
                switch (listItem.Type)
                {
                    case FtpFileSystemObjectType.File:
                        fileNames.Add(new ListItem() { Value = listItem.FullName, Name = listItem.Name });
                        break;
                }
            }

            return fileNames;
        }

        /// <summary>
        /// Prompts the user to choose their profile user id.
        /// </summary>
        /// <param name="owner"> Console IP Address </param>
        /// <returns> </returns>
        public static string GetUserProfileId(Form owner)
        {
            List<ListItem> userIds = GetFolderNames("/dev_hdd0/home/");

            List<ListItem> userNames = new();
            
            foreach (ListItem userId in userIds)
            {
                userNames.Add(new ListItem() { Value = userId.Name, Name = $"{userId.Name} ({GetUserNameFromUserId(userId.Name)})" });
            }

            if (userIds.Count > 0)
            {
                string userId = DialogExtensions.ShowListInputDialog(owner, "User Profile IDs", userNames);

                if (userId != null)
                {
                    return userId;
                }
            }

            XtraMessageBox.Show(owner, "Could not find any users. Make sure there is at least one user profile on the console.", "No Users Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        /// <summary>
        /// Get the profile name for the userId.
        /// </summary>
        /// <param name="userId"> Console IP Address </param>
        /// <returns> </returns>
        public static string GetUserNameFromUserId(string userId)
        {
            FtpClient ftpClient = MainWindow.FtpClient;

            string usernameFile = $"/dev_hdd0/home/{userId}/localusername";

            using Stream stream = ftpClient.OpenRead(usernameFile);
            using StreamReader streamReader = new(stream);
            return streamReader.ReadToEnd();
        }

        /// <summary>
        /// Get all the ports on USB paths for PS3.
        /// </summary>
        public static string[] UsbPaths { get; } =
        {
                "dev_usb000",
                "dev_usb001",
                "dev_usb002",
                "dev_usb003"
        };

        /// <summary>
        /// Returns the first USB path if one is connected to the console.
        /// </summary>
        /// <returns> </returns>
        public static string GetUsbPath()
        {
            List<ListItem> folderNames = GetFolderNames("/");

            foreach (string usbPath in UsbPaths)
            {
                if (folderNames.Any(x => x.Name.Contains(usbPath)))
                {
                    return usbPath;
                }
            }

            XtraMessageBox.Show("There is no USB device connected to the console.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        /// <summary>
        /// Get all of the games from the internal drive, and on connected USB devices (if enabled in settings).
        /// </summary>
        /// <returns> </returns>
        public static List<ListItem> GetGamesBD()
        {
            List<ListItem> games = new();

            // Games on Interal HDD
            games.AddRange(GetFolderNames("/dev_hdd0/GAMES/"));
            games.AddRange(GetFolderNames("/dev_hdd0/GAMEZ/"));

            // Games on all external devices
            if (MainWindow.Settings.ShowGamesFromExternalDevices)
            {
                foreach (string usbPath in UsbPaths)
                {
                    games.AddRange(GetFolderNames($"/{usbPath}/GAMES/"));
                    games.AddRange(GetFolderNames($"/{usbPath}/GAMEZ/"));
                }
            }

            return games;
        }

        /// <summary>
        /// Get all of the games from the internal drive, and on connected USB devices (if enabled in settings).
        /// </summary>
        /// <returns> </returns>
        public static List<ListItem> GetGamesISO()
        {
            List<ListItem> games = new();

            // Games on Interal HDD
            games.AddRange(GetFileNames("/dev_hdd0/PS3ISO/"));

            // Games on all external devices
            if (MainWindow.Settings.ShowGamesFromExternalDevices)
            {
                foreach (string usbPath in UsbPaths)
                {
                    games.AddRange(GetFileNames($"/{usbPath}/PS3ISO/"));
                }
            }

            return games;
        }

        /// <summary>
        /// Get all of the games from the internal drive, and on connected USB devices (if enabled in settings).
        /// </summary>
        /// <returns> </returns>
        public static List<ListItem> GetGamesPSN()
        {
            List<ListItem> gamesPath = new();

            // Games on Interal HDD
            gamesPath.AddRange(GetFolderNames("/dev_hdd0/GAMEI/"));

            // Games on all external devices
            if (MainWindow.Settings.ShowGamesFromExternalDevices)
            {
                foreach (string usbPath in UsbPaths)
                {
                    gamesPath.AddRange(GetFolderNames($"/{usbPath}/GAMEI/"));
                }
            }

            return gamesPath;
        }
    }
}