using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FluentFTP;
using ModioX.Forms.Windows;
using ModioX.Io;
using Param_SFO;

namespace ModioX.Extensions
{
    internal static class FtpExtensions
    {
        /// <summary>
        /// Get the USB ports for PS3.
        /// </summary>
        public static string[] UsbPorts { get; } =
        {
            "dev_usb000",
            "dev_usb001",
            "dev_usb002",
            "dev_usb003"
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="localFile"></param>
        /// <param name="consoleFile"></param>
        public static FtpStatus UploadFile(string localFile, string consoleFile)
        {
            FtpClient ftpClient = MainWindow.FtpClient;

            string consolePath = Path.GetDirectoryName(consoleFile).Replace(@"\", "/") + "/";

            Console.WriteLine("Upload Local File: " + localFile);
            Console.WriteLine("Upload Console Path: " + consolePath);
            Console.WriteLine("Upload Console File: " + consoleFile);

            if (!DirectoryExists(consolePath))
            {
                CreateDirectory(consolePath);
            }

            //if (!ftpConnection.DirectoryExists(path))
            //{
            //    CreateDirectory(path);
            //}

            ftpClient.SetWorkingDirectory(consolePath);
            return ftpClient.UploadFile(localFile, consoleFile, FtpRemoteExists.Overwrite, true);
        }

        /// <summary>
        /// Delete a file from the console.
        /// </summary>
        /// <param name="consoleFile"> File to delete. </param>
        public static void DeleteFile(string consoleFile)
        {
            FtpClient ftpClient = MainWindow.FtpClient;

            if (ftpClient.FileExists(consoleFile))
            {
                ftpClient.DeleteFile(consoleFile);
            }
        }

        /// <summary>
        /// Delete a directory from the console.
        /// </summary>
        /// <param name="consolePath"> Directory to delete. </param>
        public static void DeleteDirectory(string consolePath)
        {
            FtpClient ftpClient = MainWindow.FtpClient;

            if (ftpClient.DirectoryExists(consolePath))
            {
                ftpClient.DeleteDirectory(consolePath);
            }
        }

        /// <summary>
        /// Check whether directory exists on the console.
        /// </summary>
        /// <param name="consolePath"> File to delete from console. </param>
        public static bool DirectoryExists(string consolePath)
        {
            FtpClient ftpClient = MainWindow.FtpClient;

            return ftpClient.DirectoryExists(consolePath);
        }

        /// <summary>
        /// Check whether a directory is empty on the console.
        /// </summary>
        /// <param name="consolePath"></param>
        /// <returns></returns>
        public static bool IsDirectoryEmpty(string consolePath)
        {
            FtpClient ftpClient = MainWindow.FtpClient;

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
        public static bool FileExists(string filePath)
        {
            FtpClient ftpClient = MainWindow.FtpClient;
            return ftpClient.FileExists(filePath);
        }

        /// <summary>
        /// Renames the specified file to a new name
        /// </summary>
        /// <param name="ftpConnection"> </param>
        /// <param name="filePath"> </param>
        /// <param name="newName"> </param>
        public static void RenameFileOrFolder(string filePath, string newFilePath)
        {
            FtpClient ftpClient = MainWindow.FtpClient;
            ftpClient.Rename(filePath, newFilePath);

            // Use the WebRequest method because FtpConnection throws an error and this doesn't, strange
            //FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + ftpConnection.Host + ":" + ftpConnection.Port + filePath);
            //request.Method = WebRequestMethods.Ftp.Rename;
            //request.Credentials = new NetworkCredential(MainWindow.ConsoleProfile.Username, MainWindow.ConsoleProfile.Password);
            //request.RenameTo = newName;
            //request.GetResponse();
        }

        /// <summary>
        /// Creates the specified directory path on the console.
        /// </summary>
        /// <param name="consolePath"> </param>
        /// <returns> Whether the directory was created or not. </returns>
        public static bool CreateDirectory(string consolePath)
        {
            FtpClient ftpClient = MainWindow.FtpClient;

            return ftpClient.CreateDirectory(consolePath, true);
        }

        public static void DownloadDirectory(string consolePath, string localPath)
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
                while (!listReader.EndOfStream)
                {
                    lines.Add(listReader.ReadLine());
                }
            }

            foreach (string line in lines)
            {
                string[] tokens = line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[8];
                string permissions = tokens[0];

                string localFilePath = Path.Combine(localPath, name);
                string fileUrl = url + name;

                switch (permissions[0])
                {
                    case 'd':
                        {
                            if (!Directory.Exists(localFilePath))
                            {
                                Directory.CreateDirectory(localFilePath);
                            }

                            DownloadDirectory(fileUrl, localFilePath);
                            break;
                        }
                    default:
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

                            break;
                        }
                }
            }
        }

        /// <summary>
        /// Gets the folder names inside the specified console path.
        /// </summary>
        /// <param name="consolePath"> Path of the directory to fetch listing from </param>
        public static string GetParamTitle(string paramFilePath)
        {
            string fileUrl = "ftp://" + MainWindow.ConsoleProfile.Address + ":" + MainWindow.ConsoleProfile.Port + paramFilePath;

            try
            {
                using WebClient request = new();
                byte[] newFileData = request.DownloadData(fileUrl);
                PARAM_SFO PARAM_SFO = new(newFileData);

                return PARAM_SFO != null ? PARAM_SFO.Title : "Not Recongized";
            }
            catch (WebException ex)
            {
                Program.Log.Error(ex, "Unable to fetch game title from PARAM.SFO file: {0}", paramFilePath);
                return "Not Recongized";
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to fetch game title from PARAM.SFO file: {0}", paramFilePath);
                return "Not Recongized";
            }
        }

        public static void EditProfileComment(Form owner)
        {
            MainWindow.Window.SetStatus("Editing profile comment file...");

            //FtpClient ftpClient = MainWindow.FtpClient;
            //FtpConnection ftpConnection = MainWindow.FtpConnection;

            //string userId = GetUserProfileId(owner);
            string userId = "00000001";
            string commentFilePath = $"/dev_hdd0/home/{userId}/friendim/mecomment.dat";
            string filePath = $"{UserFolders.Tmp}mecomment.dat";
            //string currentProfileComment = new string[] { string.Empty };
            string[] currentProfileComment = { string.Empty };

            if (File.Exists(filePath))
            {
                currentProfileComment = File.ReadAllLines(filePath);
            }

            //if (ftpConnection.FileExists(commentFilePath))
            //if (ftpClient.FileExists(commentFilePath))
            //{
            //    MessageBox.Show("File exists.");
            //    //ftpConnection.GetFile(commentFilePath, filePath, false);
            //    //DownloadFile(filePath, commentFilePath);
            //    ftpClient.DownloadFile(filePath, commentFilePath);
            //    MessageBox.Show("File downloaded to : " + filePath);
            //    currentProfileComment = File.ReadAllLines(filePath);
            //    MessageBox.Show(string.Join(",", currentProfileComment));
            //}
            //else
            //{
            //    MessageBox.Show("File doesn't exist.");
            //    return;
            //    //File.WriteAllText(filePath, string.Empty);
            //}

            //if (ftpClient.FileExists(commentFilePath))
            //{
            //    ftpClient.DownloadFile(filePath, commentFilePath);
            //}
            //else
            //{
            //    File.WriteAllText(filePath, string.Empty);
            //}

            string[] newProfileComment = DialogExtensions.ShowMultiTextInputDialog(owner, "Set Profile Comment", "Profile Comment:", currentProfileComment);
            //string newProfileComment = DialogExtensions.ShowTextInputDialog(owner, "Set Profile Comment", "Profile Comment:", currentProfileComment, 0);

            switch (newProfileComment)
            {
                case null:
                    MessageBox.Show("Comment can't be empty.");
                    return;
            }

            File.WriteAllLines(filePath, newProfileComment);

            if (new FileInfo(filePath).Length > 64)
            {
                XtraMessageBox.Show(MainWindow.Window, "Profile comment file must be equal or less than 64 bytes.", "Maximum Bytes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MainWindow.Window.SetStatus("Profile comment file must be equal or less than 64 bytes.");
                return;
            }

            UploadFile(filePath, commentFilePath);
            MainWindow.Window.SetStatus("Successfully edited profile comment.");
        }

        /// <summary>
        /// Gets the folder names inside the specified console path.
        /// </summary>
        /// <param name="consolePath"> Path of the directory to fetch listing from </param>
        public static List<ListItem> GetFolderNames(string consolePath)
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
                        folderNames.Add(new ListItem
                        {
                            Value = listItem.FullName,
                            Name = listItem.Name
                        });
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
        public static List<ListItem> GetFileNames(string consolePath, bool recursive = false)
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
                        fileNames.Add(new ListItem { Value = listItem.FullName, Name = listItem.Name });
                        break;
                }
            }

            return fileNames;
        }

        /// <summary>
        /// Prompts the user to choose a profile user id.
        /// </summary>
        /// <param name="owner"> Parent Form </param>
        /// <returns> </returns>
        public static string GetUserProfileId(Form owner)
        {
            List<ListItem> userIds = GetFolderNames("/dev_hdd0/home/");

            List<ListItem> userNames = new();

            foreach (ListItem userId in userIds)
            {
                userNames.Add(new ListItem
                {
                    Value = userId.Name,
                    Name = $"{userId.Name} ({GetUserNameFromUserId(userId.Name)})"
                });
            }

            switch (userIds.Count)
            {
                case > 0:
                    {
                        ListItem userId = DialogExtensions.ShowListViewDialog(owner, "User Profile IDs", userNames);

                        if (userId != null)
                        {
                            return userId.Name.Split()[0];
                        }

                        break;
                    }
            }

            XtraMessageBox.Show(owner,
                "Could not find any users. Make sure there is at least one user profile on the console.",
                "No Users Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (!ftpClient.FileExists(usernameFile))
            {
                return "No Username";
            }

            using Stream stream = ftpClient.OpenRead(usernameFile);
            using StreamReader streamReader = new(stream);
            return streamReader.ReadToEnd();
        }

        /// <summary>
        /// Returns the first USB path if one is connected to the console.
        /// </summary>
        /// <returns> </returns>
        public static string GetUsbPath()
        {
            List<ListItem> folderNames = GetFolderNames("/");

            foreach (string usbPort in UsbPorts)
            {
                if (folderNames.Any(x => x.Name.Contains(usbPort)))
                {
                    return usbPort;
                }
            }

            XtraMessageBox.Show(MainWindow.Window, "There is no USB device connected to the console.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        /// <summary>
        /// Get all of the games from the public drive, and on connected USB devices (if enabled in settings).
        /// </summary>
        /// <returns> </returns>
        public static List<ListItem> GetGamesBD()
        {
            List<ListItem> games = new();

            // Games on Interal HDD
            games.AddRange(GetFolderNames("/dev_hdd0/GAMES/"));
            games.AddRange(GetFolderNames("/dev_hdd0/GAMEZ/"));

            switch (MainWindow.Settings.ShowGamesFromExternalDevices)
            {
                // Games on all external devices
                case true:
                    {
                        foreach (string usbPort in UsbPorts)
                        {
                            games.AddRange(GetFolderNames($"/{usbPort}/GAMES/"));
                            games.AddRange(GetFolderNames($"/{usbPort}/GAMEZ/"));
                        }

                        break;
                    }
            }

            return games;
        }

        /// <summary>
        /// Get all of the games from the public drive, and on connected USB devices (if enabled in settings).
        /// </summary>
        /// <returns> </returns>
        public static List<ListItem> GetGamesISO()
        {
            List<ListItem> games = new();

            // Games on Interal HDD
            games.AddRange(GetFileNames("/dev_hdd0/PS3ISO/"));

            switch (MainWindow.Settings.ShowGamesFromExternalDevices)
            {
                // Games on all external devices
                case true:
                    {
                        foreach (string usbPort in UsbPorts)
                        {
                            games.AddRange(GetFileNames($"/{usbPort}/PS3ISO/"));
                        }

                        break;
                    }
            }

            return games;
        }

        /// <summary>
        /// Get all of the games from the public drive, and on connected USB devices (if enabled in settings).
        /// </summary>
        /// <returns> </returns>
        public static List<ListItem> GetGamesPSN()
        {
            List<ListItem> gamesPath = new();

            // Games on Interal HDD
            gamesPath.AddRange(GetFolderNames("/dev_hdd0/GAMEI/"));

            switch (MainWindow.Settings.ShowGamesFromExternalDevices)
            {
                // Games on all external devices
                case true:
                    {
                        foreach (string usbPort in UsbPorts)
                        {
                            gamesPath.AddRange(GetFolderNames($"/{usbPort}/GAMEI/"));
                        }

                        break;
                    }
            }

            return gamesPath;
        }
    }
}