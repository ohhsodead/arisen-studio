using DevExpress.XtraEditors;
using FluentFTP;
using ArisenStudio.Forms.Windows;
using Param_SFO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ArisenStudio.Extensions
{
    internal static class FtpExtensions
    {
        /// <summary>
        /// Get the USB ports for PS3.
        /// </summary>
        public static string[] UsbPorts { get; } =
        [
            "dev_usb000",
            "dev_usb001",
            "dev_usb002",
            "dev_usb003"
        ];

        /// <summary>
        /// 
        /// </summary>
        /// <param name="localFile"></param>
        /// <param name="consoleFile"></param>
        public static FtpStatus UploadFile(string localFile, string consoleFile)
        {
            FtpClient ftpClient = MainWindow.FtpClient;

            string consolePath = Path.GetDirectoryName(consoleFile).Replace(@"\", "/") + "/";

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
                    case FtpObjectType.Directory:
                        itemCount++;
                        break;

                    case FtpObjectType.File:
                        itemCount++;
                        break;

                    case FtpObjectType.Link:
                        break;
                }
            }

            return itemCount == 0;
        }

        /// <summary>
        /// Downloads the specified console file to the computer.
        /// </summary>
        /// <param name="filePath"> Path of the uploading file directory </param>
        public static bool FileExists(string filePath)
        {
            FtpClient ftpClient = MainWindow.FtpClient;
            return ftpClient.FileExists(filePath);
        }

        /// <summary>
        /// Renames the specified file or folder.
        /// </summary>
        /// <param name="filePath"> </param>
        /// <param name="newFilePath"> </param>
        public static void RenameFileOrFolder(string filePath, string newFilePath)
        {
            FtpClient ftpClient = MainWindow.FtpClient;
            ftpClient.Rename(filePath, newFilePath);
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="consolePath"></param>
        /// <param name="localPath"></param>
        public static void DownloadDirectory(string consolePath, string localPath)
        {
            FtpClient ftpClient = MainWindow.FtpClient;
            ftpClient.DownloadDirectory(localPath, consolePath, FtpFolderSyncMode.Update, FtpLocalExists.Overwrite);
        }

        /// <summary>
        /// Gets the game title by fetching the PARAM.SFO file
        /// </summary>
        /// <param name="paramFilePath"> Path of the directory to fetch listing from </param>
        //public static string GetParamTitle(string paramFilePath)
        //{
        //    string fileUrl = "ftp://" + MainWindow.ConsoleProfile.Address + ":" + MainWindow.ConsoleProfile.Port + paramFilePath;

        //    try
        //    {
        //        using WebClient request = new();
        //        byte[] newFileData = request.DownloadData(fileUrl);
        //        PARAM_SFO paramSfo = new(newFileData);

        //        return paramSfo != null ? paramSfo.Title : "Not Recognized";
        //    }
        //    catch (WebException ex)
        //    {
        //        Program.Log.Error(ex, "Unable to fetch game title from PARAM.SFO file: {0}", paramFilePath);
        //        return "Not Recognized";
        //    }
        //    catch (Exception ex)
        //    {
        //        Program.Log.Error(ex, "Unable to fetch game title from PARAM.SFO file: {0}", paramFilePath);
        //        return "Not Recognized";
        //    }
        //}

        /// <summary>
        /// Get the game title from the PARAM.SFO file.
        /// </summary>
        /// <param name="paramFilePath"> Path of the directory to fetch listing from </param>
        public static string GetParamTitle(string paramFilePath)
        {
            FtpClient ftpClient = MainWindow.FtpClient;

            try
            {
                if (ftpClient.DownloadBytes(out byte[] file, paramFilePath))
                {
                    PARAM_SFO paramSfo = new(file);

                    return paramSfo != null ? paramSfo.Title : "Not Recognized";
                }
                else
                {
                    throw new Exception(string.Format("File doesn't exist: {0}", paramFilePath));
                }

                //using WebClient request = new();
                //byte[] newFileData = request.DownloadData(fileUrl);
                //PARAM_SFO paramSfo = new(newFileData);

                //return paramSfo != null ? paramSfo.Title : "Not Recognized";
            }
            catch (WebException ex)
            {
                Program.Log.Error(ex, "Unable to fetch game title from PARAM.SFO file: {0}", paramFilePath);
                throw new Exception(string.Format("Unable to fetch game title from PARAM.SFO file: {0} - Error: {1}", paramFilePath, ex.Message), ex);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to fetch game title from PARAM.SFO file: {0}", paramFilePath);
                throw new Exception(string.Format("Unable to fetch game title from PARAM.SFO file: {0} - Error: {1}", paramFilePath, ex.Message), ex);
            }
        }

        public static void EditProfileComment(Form owner)
        {
            MainWindow.Window.SetStatus("Editing profile comment file...");

            FtpClient ftpClient = MainWindow.FtpClient;

            string userId = GetUserProfileId(owner);

            if (userId.IsNullOrWhiteSpace())
            {
                XtraMessageBox.Show(owner, "The comment file does not exist on your console. You can create one by editing the profile comment on your console.", "No Comment File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string commentFilePath = $"/dev_hdd0/home/{userId}/friendim/mecomment.dat";

            if (!ftpClient.FileExists(commentFilePath))
            {
                XtraMessageBox.Show(owner, "The comment file does not exist on your console. You can create one by editing the profile comment on your console.", "No Comment File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MemoryStream memoryStream = new();
            ftpClient.DownloadStream(memoryStream, commentFilePath);

            using StreamReader streamReader = new(memoryStream);

            string currentProfileComment = streamReader.ReadToEnd();

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

            string[] newProfileComment = DialogExtensions.ShowMultiTextInputDialog(owner, "Edit Profile Comment", "Profile Comment:", currentProfileComment.Trim().Split(' '));
            //string newProfileComment = DialogExtensions.ShowTextInputDialog(owner, "Set Profile Comment", "Profile Comment:", currentProfileComment, 0);

            switch (newProfileComment)
            {
                case null:
                    XtraMessageBox.Show(owner, "Profile comment file must be equal to or less than 64 bytes.", MainWindow.ResourceLanguage.GetString("NO_INPUT"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

            byte[] commentBytes = newProfileComment.SelectMany(s => Encoding.UTF8.GetBytes(s + Environment.NewLine)).ToArray();

            //File.WriteAllLines(filePath, newProfileComment);

            //if (new FileInfo(filePath).Length > 64)
            //{
            //    XtraMessageBox.Show(MainWindow.Window, "Profile comment file must be equal or less than 64 bytes.", "Maximum Bytes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    MainWindow.Window.SetStatus("Profile comment file must be equal or less than 64 bytes.");
            //    return;
            //}

            if (commentBytes.Length > 64)
            {
                XtraMessageBox.Show(owner, "Profile comment file must be equal or less than 64 bytes.", "Maximum Bytes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MainWindow.Window.SetStatus("Profile comment file must be equal or less than 64 bytes.");
                return;
            }

            //UploadFile(newProfileComment, commentFilePath);
            ftpClient.UploadBytes(commentBytes, commentFilePath);
            MainWindow.Window.SetStatus("Successfully edited profile comment.");
        }

        /// <summary>
        /// Gets the folder names inside the specified console path.
        /// </summary>
        /// <param name="consolePath"> Path of the directory to fetch listing from </param>
        public static List<ListItem> GetFolderNames(string consolePath)
        {
            FtpClient ftpClient = MainWindow.FtpClient;

            List<ListItem> folderNames = [];

            if (!ftpClient.DirectoryExists(consolePath))
            {
                return folderNames;
            }

            ftpClient.SetWorkingDirectory(consolePath);

            foreach (FtpListItem listItem in ftpClient.GetListing(consolePath))
            {
                switch (listItem.Type)
                {
                    case FtpObjectType.Directory:
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

            List<ListItem> fileNames = [];

            if (!ftpClient.DirectoryExists(consolePath))
            {
                return fileNames;
            }

            ftpClient.SetWorkingDirectory(consolePath);

            foreach (FtpListItem listItem in ftpClient.GetListing(consolePath, recursive ? FtpListOption.Recursive : FtpListOption.AllFiles))
            {
                switch (listItem.Type)
                {
                    case FtpObjectType.File:
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

            List<ListItem> userNames = [];

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
            //using MemoryStream stream = new();
            //ftpClient.Download(stream, usernameFile);
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

            XtraMessageBox.Show(MainWindow.Window, "There is no USB device connected to the console.", MainWindow.ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        /// <summary>
        /// Get all of the games from the internal drive, and external USB devices (if enabled in settings).
        /// </summary>
        /// <returns> </returns>
        public static List<ListItem> GetGamesBd()
        {
            List<ListItem> games =
            [
                // Games on Interal HDD
                .. GetFolderNames("/dev_hdd0/GAMES/"),
                .. GetFolderNames("/dev_hdd0/GAMEZ/"),
            ];

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
        /// Get all of the games from the internal drive, and external USB devices (if enabled in settings).
        /// </summary>
        /// <returns> </returns>
        public static List<ListItem> GetGamesIso()
        {
            List<ListItem> games =
            [
                // Games on Interal HDD
                .. GetFileNames("/dev_hdd0/PS3ISO/"),
            ];

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
        /// Get all of the games from the internal drive, and external devices (if enabled in settings).
        /// </summary>
        /// <returns> </returns>
        public static List<ListItem> GetGamesPsn()
        {
            List<ListItem> gamesPath =
            [
                // Games on Interal HDD
                .. GetFolderNames("/dev_hdd0/GAMEI/"),
            ];

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

        /// <summary>
        /// Get all PS2 (ISO) games from the internal drive, and external devices (if enabled in settings).
        /// </summary>
        /// <returns> </returns>
        public static List<ListItem> GetGamesPs2()
        {
            List<ListItem> gamesPath =
            [
                // Games on Interal HDD
                .. GetFileNames("/dev_hdd0/PS2ISO/")
            ];

            switch (MainWindow.Settings.ShowGamesFromExternalDevices)
            {
                // Games on all external devices
                case true:
                    {
                        foreach (string usbPort in UsbPorts)
                        {
                            gamesPath.AddRange(GetFolderNames($"/{usbPort}/PS2ISO/"));
                        }

                        break;
                    }
            }

            return gamesPath;
        }

        /// <summary>
        /// Get all PS1/PSX (ISO) games from the internal drive, and external devices (if enabled in settings).
        /// </summary>
        /// <returns> </returns>
        public static List<ListItem> GetGamesPsx()
        {
            List<ListItem> gamesPath = [.. GetFileNames("/dev_hdd0/PSXISO/")];

            foreach (var folder in GetFolderNames("/dev_hdd0/PSXGAMES/"))
            {
                foreach (var item in GetFileNames("/dev_hdd0/PSXGAMES/" + folder.Name))
                {
                    if (item.Name.EndsWith(".bin"))
                    {
                        item.Name = item.Name.Replace(".bin", "");
                        gamesPath.Add(item);
                    }
                }
            }

            // Games on all external devices
            switch (MainWindow.Settings.ShowGamesFromExternalDevices)
            {
                case true:
                    {
                        foreach (string usbPort in UsbPorts)
                        {
                            gamesPath.AddRange(GetFolderNames($"/{usbPort}/PSXISO/"));

                            foreach (var folder in GetFolderNames($"/{usbPort}/PSXGAMES/"))
                            {
                                foreach (var item in GetFileNames($"/{usbPort}/PSXGAMES/" + folder.Name))
                                {
                                    if (item.Name.EndsWith(".bin"))
                                    {
                                        item.Name = item.Name.Replace(".bin", "");
                                        gamesPath.Add(item);
                                    }
                                }
                            }
                        }

                        break;
                    }
            }

            return gamesPath;
        }
    }
}