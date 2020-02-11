using System.Collections.Generic;
using System.IO;

namespace ModioX.Extensions
{
    internal abstract class FtpExtensions
    {
        /// <summary>
        ///     Upload a desired local file to the specified location on the console
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
        ///     Uninstall modded files specified in the InstallPath from the users console, ignore game specific files as this
        ///     could cause game to stop working (only .sprx files)
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
        /// <param name="folderPath">Path of the uploading file directory</param>
        internal static List<string> GetFolderNames(string hostAddress, string folderPath)
        {
            using (FtpConnection ftpConnection = new FtpConnection(hostAddress))
            {
                List<string> folderNames = new List<string>();

                ftpConnection.Open();

                string dirPath = folderPath.Contains("/")
                ? folderPath.Substring(0, folderPath.LastIndexOf('/')) + '/'
                : "/dev_hdd0/";

                ftpConnection.SetCurrentDirectory(dirPath);

                foreach (var path in ftpConnection.GetDirectories(dirPath))
                {
                    folderNames.Add(path.Name);
                }

                folderNames.RemoveRange(0, 2);

                return folderNames;
            }
        }
    }
}