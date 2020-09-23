using DarkUI.Forms;
using ModioX.Forms;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ModioX.Extensions
{
    internal abstract class FtpExtensions
    {
        /// <summary>
        ///     Upload a local file to the specified location on the console
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="localFile">Path of the local file</param>
        /// <param name="consoleFile">Path of the uploading file directory</param>
        internal static void UploadFile(string hostAddress, string localFile, string consoleFile)
        {
            using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
            {
                ftpConnection.Open();

                string dirPath = consoleFile.Contains("/")
                    ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
                    : "dev_hdd0/";

                string fileName = consoleFile.Contains("/")
                        ? consoleFile.Substring(consoleFile.LastIndexOf('/')).Replace("/", "").Replace("//", "")
                        : consoleFile;

                if (!ftpConnection.DirectoryExists(dirPath))
                {
                    ftpConnection.CreateDirectory(dirPath);
                }

                ftpConnection.SetCurrentDirectory(dirPath);
                ftpConnection.PutFile(localFile, fileName);
            }
        }


        /// <summary>
        ///     Uninstall a specified file from the console
        /// </summary>
        /// <param name="hostAddress">Console address to connect to</param>
        /// <param name="consoleFile">Mod to uninstall</param>
        internal static void DeleteFile(string hostAddress, string consoleFile)
        {
            using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
            {
                ftpConnection.Open();

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
        }

        /// <summary>
        ///     Downloads the specified console file to the computer
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="localFile">Path of the local file</param>
        /// <param name="consoleFile">Path of the uploading file directory</param>
        internal static void DownloadFile(string hostAddress, string localFile, string consoleFile)
        {
            using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
            {
                ftpConnection.Open();

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
        }

        /// <summary>
        ///     Downloads the specified console file to the computer
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="consoleFile">Path of the uploading file directory</param>
        internal static bool FileExists(string hostAddress, string consoleFile)
        {
            using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
            {
                ftpConnection.Open();

                string dirPath = consoleFile.Contains("/")
                ? consoleFile.Substring(0, consoleFile.LastIndexOf('/')) + '/'
                : "/dev_hdd0/";

                ftpConnection.SetCurrentDirectory(dirPath);

                return ftpConnection.FileExists(consoleFile);
            }
        }

        /// <summary>
        ///     Downloads the specified console file to the computer
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="consolePath">Path of the uploading file directory</param>
        internal static bool DirectoryExists(string hostAddress, string consolePath)
        {
            using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
            {
                ftpConnection.Open();

                return ftpConnection.DirectoryExists(consolePath);
            }
        }

        /// <summary>
        ///     Downloads the specified console file to the computer
        /// </summary>
        /// <param name="hostAddress">PS3 IP address</param>
        /// <param name="consolePath">Path of the uploading file directory</param>
        internal static List<string> GetFolderNames(string hostAddress, string consolePath)
        {
            using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
            {
                List<string> folderNames = new List<string>();

                ftpConnection.Open();

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
        }

        /// <summary>
        ///     Prompts the user to choose their user id
        /// </summary>
        /// <param name="hostAddress">Console IP Address</param>
        /// <returns></returns>
        public static string GetUserId(string hostAddress)
        {
            List<string> userIds = GetFolderNames(hostAddress, "/dev_hdd0/home/");

            if (userIds.Count < 1)
            {
                _ = DarkMessageBox.Show(MainForm.mainForm, "Could not find any users on your console. Make sure you have created at least one user profile and then try again.", "No Users Found", MessageBoxIcon.Error);
                return null;
            }
            else
            {
                return Utilities.GetItemFromList("User Profile IDs", userIds);
            }
        }

        /// <summary>
        ///     Returns the USB path if one is connected to the console port
        /// </summary>
        /// <param name="hostAddress">Console IP Address</param>
        /// <returns></returns>
        internal static string GetPathForUSB(string hostAddress)
        {
            string[] usbPaths = new string[]
            {
                    "/dev_usb000/",
                    "/dev_usb001/"
            };

            foreach (string usbPath in usbPaths)
            {
                if (DirectoryExists(hostAddress, usbPath))
                {
                    return usbPath;
                }
            }

            _ = DarkMessageBox.Show(MainForm.mainForm, "No USB devices are connected to your console. Make sure there is at least one device connected for installing mods.", "No USB Device", MessageBoxIcon.Error);
            return null;
        }
    }
}