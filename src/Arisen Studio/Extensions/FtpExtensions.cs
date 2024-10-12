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
using System.Threading.Tasks;
using System.Diagnostics;
using System.Web.UI.WebControls;

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
        //public static FtpStatus UploadFile(string localFile, string consoleFile)
        //{
        //    AsyncFtpClient ftpClient = MainWindow.FtpClient;

        //    string consolePath = Path.GetDirectoryName(consoleFile).Replace(@"\", "/") + "/";

        //    if (!DirectoryExists(consolePath))
        //    {
        //        _ = CreateDirectory(consolePath);
        //    }

        //    //if (!ftpConnection.DirectoryExists(path))
        //    //{
        //    //    CreateDirectory(path);
        //    //}

        //    ftpClient.SetWorkingDirectory(consolePath);

        //    return ftpClient.UploadFile(localFile, consoleFile, FtpRemoteExists.Overwrite, true);
        //}

        //public static FtpStatus UploadFileAsync(string localFile, string consoleFile, IProgress<int> progress)
        //{
        //    FtpClient ftpClient = MainWindow.FtpClient;

        //    string consolePath = Path.GetDirectoryName(consoleFile).Replace(@"\", "/") + "/";

        //    if (!DirectoryExists(consolePath))
        //    {
        //        _ = CreateDirectory(consolePath);
        //    }

        //    ftpClient.SetWorkingDirectory(consolePath);

        //    // Subscribe to the progress event
        //    ftpClient.UploadProgress += (sender, args) =>
        //    {
        //        // Calculate the percentage
        //        double percentComplete = (double)args.TransferredBytes / args.TotalBytes * 100;

        //        // Report progress
        //        progress.Report(percentComplete);
        //    };

        //    // Upload the file with overwrite and progress enabled
        //    return ftpClient.UploadFile(localFile, consoleFile, FtpRemoteExists.Overwrite, true);
        //}

        public static async Task<FtpStatus> UploadFileAsync(string localFile, string consoleFile, IProgress<int> progress = null)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;

            string consolePath = Path.GetDirectoryName(consoleFile).Replace(@"\", "/") + "/";

            if (await DirectoryExistsAsync(consolePath) == false)
            {
                await CreateDirectoryAsync(consolePath);
            }

            await ftpClient.SetWorkingDirectory(consolePath);

            // Upload the file with overwrite and progress enabled
            return await ftpClient.UploadFile(localFile, consoleFile, FtpRemoteExists.Overwrite, true, FtpVerify.None, progress: new Progress<FtpProgress>(p =>
            {
                // Calculate and report progress as a percentage
                //double percentComplete = (double)p.TransferredBytes / p.TotalBytes * 100;
                //progress.Report(percentComplete);
                progress?.Report((int)p.Progress);
            }));
        }

        public static async Task<FtpStatus> DownloadFileAsync(string localFile, string consoleFile, IProgress<int> progress = null)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;

            string consolePath = Path.GetDirectoryName(consoleFile).Replace(@"\", "/") + "/";

            // Ensure the directory exists on the FTP server before downloading
            if (await DirectoryExistsAsync(consolePath) == false)
            {
                throw new Exception($"Directory does not exist on FTP server: {consolePath}");
            }

            await ftpClient.SetWorkingDirectory(consolePath);

            // Download the file with progress enabled (if progress is provided)
            return await ftpClient.DownloadFile(localFile, consoleFile, FtpLocalExists.Overwrite, FtpVerify.None, progress: new Progress<FtpProgress>(p =>
            {
                // Only report progress if a valid progress handler is provided
                progress?.Report((int)p.Progress);
            }));
        }


        /// <summary>
        /// Delete a file from the console.
        /// </summary>
        /// <param name="consoleFile"> File to delete. </param>
        public static async void DeleteFile(string consoleFile)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;

            if (await ftpClient.FileExists(consoleFile))
            {
                await ftpClient.DeleteFile(consoleFile);
            }
        }

        /// <summary>
        /// Delete a directory from the console.
        /// </summary>
        /// <param name="consolePath"> Directory to delete. </param>
        public static async void DeleteDirectory(string consolePath)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;

            if (await ftpClient.DirectoryExists(consolePath))
            {
                await ftpClient.DeleteDirectory(consolePath);
            }
        }

        /// <summary>
        /// Check whether directory exists on the console.
        /// </summary>
        /// <param name="consolePath"> File to delete from console. </param>
        public static async Task<bool> DirectoryExistsAsync(string consolePath)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;

            return await ftpClient.DirectoryExists(consolePath);
        }

        /// <summary>
        /// Check whether a directory is empty on the console.
        /// </summary>
        /// <param name="consolePath"></param>
        /// <returns></returns>
        public static async Task<bool> IsDirectoryEmpty(string consolePath)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;

            int itemCount = 0;

            foreach (FtpListItem listItem in await ftpClient.GetListing(consolePath))
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
        public static async Task<bool> FileExistsAsync(string filePath)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;
            return await ftpClient.FileExists(filePath);
        }

        /// <summary>
        /// Renames the specified file or folder.
        /// </summary>
        /// <param name="filePath"> </param>
        /// <param name="newFilePath"> </param>
        public static void RenameFileOrFolder(string filePath, string newFilePath)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;
            ftpClient.Rename(filePath, newFilePath);
        }

        /// <summary>
        /// Creates the specified directory path on the console.
        /// </summary>
        /// <param name="consolePath"> </param>
        /// <returns> Whether the directory was created or not. </returns>
        public static async Task<bool> CreateDirectoryAsync(string consolePath)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;
            return await ftpClient.CreateDirectory(consolePath, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consolePath"></param>
        /// <param name="localPath"></param>
        public static void DownloadDirectory(string consolePath, string localPath)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;
            _ = ftpClient.DownloadDirectory(localPath, consolePath, FtpFolderSyncMode.Update, FtpLocalExists.Overwrite);
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
        public static async Task<string> GetParamTitleAsync(string paramFilePath)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;

            try
            {
                // Check if the file exists first
                if (await ftpClient.FileExists(paramFilePath))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        // Download the file into the memory stream
                        var fileBytes = await ftpClient.DownloadStream(memoryStream, paramFilePath);

                        // Convert the stream to a byte array
                        byte[] paramFile = memoryStream.ToArray();

                        // Parse the PARAM.SFO file
                        PARAM_SFO paramSfo = new PARAM_SFO(paramFile);

                        // Return the title from PARAM.SFO or default to "Not Recognized"
                        return paramSfo != null ? paramSfo.Title : "Not Recognized";
                    }
                }
                else
                {
                    throw new Exception($"File doesn't exist: {paramFilePath}");
                }
            }
            catch (WebException ex)
            {
                Program.Log.Error(ex, "Unable to fetch game title from PARAM.SFO file: {0}", paramFilePath);
                throw new Exception($"Unable to fetch game title from PARAM.SFO file: {paramFilePath} - Error: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                Program.Log.Error(ex, "Unable to fetch game title from PARAM.SFO file: {0}", paramFilePath);
                throw new Exception($"Unable to fetch game title from PARAM.SFO file: {paramFilePath} - Error: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Gets the folder names inside the specified console path.
        /// </summary>
        /// <param name="consolePath"> Path of the directory to fetch listing from </param>
        public static async Task<List<ListItem>> GetFolderNamesAsync(string consolePath)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;

            List<ListItem> folderNames = [];

            if (await ftpClient.DirectoryExists(consolePath) == false)
            {
                return folderNames;
            }

            await ftpClient.SetWorkingDirectory(consolePath);

            foreach (FtpListItem listItem in await ftpClient.GetListing(consolePath))
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
        public static async Task<List<ListItem>> GetFileNamesAsync(string consolePath, bool recursive = false)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;

            List<ListItem> fileNames = [];

            if (await ftpClient.DirectoryExists(consolePath) == false)
            {
                return fileNames;
            }

            await ftpClient.SetWorkingDirectory(consolePath);

            foreach (FtpListItem listItem in await ftpClient.GetListing(consolePath, recursive ? FtpListOption.Recursive : FtpListOption.AllFiles))
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
        public static async Task<string> GetUserProfileIdAsync(Form owner)
        {
            List<ListItem> userIds = await GetFolderNamesAsync("/dev_hdd0/home/");

            List<ListItem> userNames = [];

            foreach (ListItem userId in userIds)
            {
                userNames.Add(new ListItem
                {
                    Value = userId.Name,
                    Name = $"{userId.Name} ({GetUserNameFromUserIdAsync(userId.Name)})"
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

            _ = XtraMessageBox.Show(owner,
                "Could not find any users. Make sure there is at least one user profile on the console.",
                "No Users Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        /// <summary>
        /// Get the profile name for the userId.
        /// </summary>
        /// <param name="userId"> Console IP Address </param>
        /// <returns> </returns>
        public static async Task<string> GetUserNameFromUserIdAsync(string userId)
        {
            AsyncFtpClient ftpClient = MainWindow.FtpClient;

            string usernameFile = $"/dev_hdd0/home/{userId}/localusername";

            if (await ftpClient.FileExists(usernameFile) == false)
            {
                return "No Username";
            }

            using Stream stream = await ftpClient.OpenRead(usernameFile);
            //using MemoryStream stream = new();
            //ftpClient.Download(stream, usernameFile);
            using StreamReader streamReader = new(stream);
            return streamReader.ReadToEnd();
        }

        /// <summary>
        /// Returns the first USB path if one is connected to the console.
        /// </summary>
        /// <returns> </returns>
        public static async Task<string> GetUsbPathAsync()
        {
            List<ListItem> folderNames = await GetFolderNamesAsync("/");

            foreach (string usbPort in UsbPorts)
            {
                if (folderNames.Any(x => x.Name.Contains(usbPort)))
                {
                    return usbPort;
                }
            }

            _ = XtraMessageBox.Show(MainWindow.Window, "There is no USB device connected to the console.", MainWindow.ResourceLanguage.GetString("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        /// <summary>
        /// Get all of the games from the internal drive, and external USB devices (if enabled in settings).
        /// </summary>
        /// <returns> </returns>
        public static async Task<List<ListItem>> GetGamesBdAsync()
        {
            List<ListItem> games =
            [
                .. await GetFolderNamesAsync("/dev_hdd0/GAMES/"),
                .. await GetFolderNamesAsync("/dev_hdd0/GAMEZ/"),
            ];

            switch (MainWindow.Settings.ShowGamesFromExternalDevices)
            {
                // Games on all external devices
                case true:
                    {
                        foreach (string usbPort in UsbPorts)
                        {
                            games.AddRange(await GetFolderNamesAsync($"/{usbPort}/GAMES/"));
                            games.AddRange(await GetFolderNamesAsync($"/{usbPort}/GAMEZ/"));
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
        public static async Task<List<ListItem>> GetGamesIsoAsync()
        {
            List<ListItem> games =
            [
                // Games on Interal HDD
                .. await GetFileNamesAsync("/dev_hdd0/PS3ISO/"),
            ];

            switch (MainWindow.Settings.ShowGamesFromExternalDevices)
            {
                // Games on all external devices
                case true:
                    {
                        foreach (string usbPort in UsbPorts)
                        {
                            games.AddRange(await GetFileNamesAsync($"/{usbPort}/PS3ISO/"));
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
        public static async Task<List<ListItem>> GetGamesPsnAsync()
        {
            List<ListItem> gamesPath =
            [
                // Games on Interal HDD
                .. await GetFolderNamesAsync("/dev_hdd0/GAMEI/"),
            ];

            switch (MainWindow.Settings.ShowGamesFromExternalDevices)
            {
                // Games on all external devices
                case true:
                    {
                        foreach (string usbPort in UsbPorts)
                        {
                            gamesPath.AddRange(await GetFolderNamesAsync($"/{usbPort}/GAMEI/"));
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
        public static async Task<List<ListItem>> GetGamesPs2Async()
        {
            List<ListItem> gamesPath =
            [
                // Games on Interal HDD
                .. await GetFileNamesAsync("/dev_hdd0/PS2ISO/")
            ];

            switch (MainWindow.Settings.ShowGamesFromExternalDevices)
            {
                // Games on all external devices
                case true:
                    {
                        foreach (string usbPort in UsbPorts)
                        {
                            gamesPath.AddRange(await GetFolderNamesAsync($"/{usbPort}/PS2ISO/"));
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
        public static async Task<List<ListItem>> GetGamesPsxAsync()
        {
            List<ListItem> gamesPath = [.. await GetFileNamesAsync("/dev_hdd0/PSXISO/")];

            foreach (var folder in await GetFolderNamesAsync("/dev_hdd0/PSXGAMES/"))
            {
                foreach (var item in await GetFileNamesAsync("/dev_hdd0/PSXGAMES/" + folder.Name))
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
                            gamesPath.AddRange(await GetFolderNamesAsync($"/{usbPort}/PSXISO/"));

                            foreach (var folder in await GetFolderNamesAsync($"/{usbPort}/PSXGAMES/"))
                            {
                                foreach (var item in await GetFileNamesAsync($"/{usbPort}/PSXGAMES/" + folder.Name))
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