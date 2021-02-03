using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using ModioX.Extensions;

namespace ModioX.Net
{
    /// <summary>
    /// The <c> FtpConnection </c> class provides the ability to connect to FTP servers.
    /// </summary>
    public class FtpConnection : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <c> FtpConnection </c> type.
        /// </summary>
        /// <param name="host">
        /// A <see cref="String" /> type representing the server name or IP to connect to.
        /// </param>
        public FtpConnection(string host)
        {
            Host = host;
        }

        /// <summary>
        /// Initializes a new instance of the <c> FtpConnection </c> type.
        /// </summary>
        /// <param name="host">
        /// A <see cref="String" /> type representing the server name or IP to connect.
        /// </param>
        /// <param name="port">
        /// An <see cref="Int32" /> type representing the port on which to connect.
        /// </param>
        public FtpConnection(string host, int port)
        {
            Host = host;
            Port = port;
        }

        /// <summary>
        /// Initializes a new instance of the <c> FtpConnection </c> type.
        /// </summary>
        /// <param name="host">
        /// A <see cref="String" /> type representing the server name or IP to connect.
        /// </param>
        /// <param name="username">
        /// A <see cref="String" /> type representing the username with which to authenticate.
        /// </param>
        /// <param name="password">
        /// A <see cref="String" /> type representing the password with which to authenticate.
        /// </param>
        public FtpConnection(string host, string username, string password)
        {
            Host = host;
            _username = username;
            _password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <c> FtpConnection </c> type.
        /// </summary>
        /// <param name="host">
        /// A <see cref="String" /> type representing the server name or IP to connect.
        /// </param>
        /// <param name="port">
        /// An <see cref="Int32" /> type representing the port on which to connect.
        /// </param>
        /// <param name="username">
        /// A <see cref="String" /> type representing the username with which to authenticate.
        /// </param>
        /// <param name="password">
        /// A <see cref="String" /> type representing the password with which to authenticate.
        /// </param>
        public FtpConnection(string host, int port, string username, string password)
        {
            Host = host;
            Port = port;
            _username = username;
            _password = password;
        }

        /// <summary>
        /// Establishes a connection to the host.
        /// </summary>
        /// <exception cref="ArgumentNullException"> If Host is null or empty. </exception>
        public void Open()
        {
            if (String.IsNullOrEmpty(Host))
            {
                throw new ArgumentNullException("Host");
            }

            _hInternet = WININET.InternetOpen(
                Environment.UserName,
                WININET.INTERNET_OPEN_TYPE_PRECONFIG,
                null,
                null,
                WININET.INTERNET_FLAG_SYNC);

            if (_hInternet == IntPtr.Zero)
            {
                Error();
            }
        }

        /// <summary>
        /// Logs into the host server using the credentials provided when the class was instantiated.
        /// </summary>
        public void Login()
        {
            Login(_username, _password);
        }

        /// <summary>
        /// Logs into the host server using the provided credentials.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="username" /> or <paramref name="password" /> are null.
        /// </exception>
        /// <param name="username">
        /// A <see cref="String" /> type representing the user name with which to authenticate.
        /// </param>
        /// <param name="password">
        /// A <see cref="String" /> type representing the password with which to authenticate.
        /// </param>
        public void Login(string username, string password)
        {
            if (username == null)
            {
                throw new ArgumentNullException("username");
            }

            if (password == null)
            {
                throw new ArgumentNullException("password");
            }

            {
            }
            _hConnect = WININET.InternetConnect(_hInternet,
                Host,
                Port,
                username,
                password,
                WININET.INTERNET_SERVICE_FTP,
                WININET.INTERNET_FLAG_PASSIVE,
                IntPtr.Zero);

            if (_hConnect == IntPtr.Zero)
            {
                Error();
            }
        }

        /// <summary>
        /// Changes the current FTP working directory to the specified path.
        /// </summary>
        /// <exception cref="FtpException"> If the directory does not exist on the FTP server. </exception>
        /// <param name="directory">
        /// A <see cref="String" /> representing the file path of the directory.
        /// </param>
        public void SetCurrentDirectory(string directory)
        {
            var ret = WININET.FtpSetCurrentDirectory(
                _hConnect,
                directory);

            if (ret == 0)
            {
                Error();
            }
        }

        /// <summary>
        /// Changes the local working directory to the specified path.
        /// </summary>
        /// <exception cref="InvalidDataException">
        /// If the directory does not exist on the local system.
        /// </exception>
        /// <param name="directory"> </param>
        public void SetLocalDirectory(string directory)
        {
            if (Directory.Exists(directory))
            {
                Environment.CurrentDirectory = directory;
            }
            else
            {
                throw new InvalidDataException(String.Format("{0} is not a directory!", directory));
            }
        }

        /// <summary>
        /// Gets the current working FTP directory
        /// </summary>
        /// <returns> A <see cref="String"> representing the current working directory. </see> </returns>
        public string GetCurrentDirectory()
        {
            var buffLength = WINAPI.MAX_PATH + 1;
            var str = new StringBuilder(buffLength);
            var ret = WININET.FtpGetCurrentDirectory(_hConnect, str, ref buffLength);

            if (ret == 0)
            {
                Error();
                return null;
            }

            return str.ToString();
        }

        /// <summary>
        /// Get the current FtpDirectory information for the current working directory
        /// </summary>
        /// <returns>
        /// A <see cref="FtpDirectoryInfo" /> with available details about the current working directory.
        /// </returns>
        public FtpDirectoryInfo GetCurrentDirectoryInfo()
        {
            var dir = GetCurrentDirectory();
            return new FtpDirectoryInfo(this, dir);
        }

        /// <summary>
        /// Gets the specified file's size
        /// </summary>
        /// <param name="file"> The file to get the size for </param>
        /// <returns> The file size in bytes </returns>
        public long GetFileSize(string file)
        {
            var hFile = new IntPtr(
                WININET.FtpOpenFile(_hConnect, file, WINAPI.GENERIC_READ, WININET.FTP_TRANSFER_TYPE_BINARY, IntPtr.Zero)
            );

            if (hFile == IntPtr.Zero)
            {
                Error();
            }
            else
            {
                try
                {
                    var sizeHigh = 0;
                    var sizeLo = WININET.FtpGetFileSize(hFile, ref sizeHigh);

#pragma warning disable CS0675 // Bitwise-or operator used on a sign-extended operand
                    var fileSize = ((long)sizeHigh << 32) | sizeLo;
#pragma warning restore CS0675 // Bitwise-or operator used on a sign-extended operand

                    return fileSize;
                }
                catch (Exception)
                {
                    Error();
                }
                finally
                {
                    WININET.InternetCloseHandle(hFile);
                }
            }

            return 0;
        }

        /// <summary>
        /// Downloads a file from the FTP server to the local system
        /// </summary>
        /// <remarks>
        /// The file will be downloaded to the local working directory with the same name it has on
        /// the FTP server.
        /// </remarks>
        /// <exception cref="FtpException"> If the file does not exist. </exception>
        /// <param name="remoteFile">
        /// A <see cref="String" /> representing the full or relative path to the file to download.
        /// </param>
        /// <param name="failIfExists">
        /// A <see cref="Boolean" /> that determines whether an existing local file should be overwritten.
        /// </param>
        public void GetFile(string remoteFile, bool failIfExists)
        {
            GetFile(remoteFile, remoteFile, failIfExists);
        }

        /// <summary>
        /// Downloads a file from the FTP server to the local system
        /// </summary>
        /// <exception cref="FtpException"> If the file does not exist. </exception>
        /// <param name="remoteFile">
        /// A <see cref="String" /> representing the full or relative path to the file to download.
        /// </param>
        /// <param name="localFile">
        /// A <see cref="String" /> representing the local file path to save the file.
        /// </param>
        /// <param name="failIfExists">
        /// A <see cref="Boolean" /> that determines whether an existing local file should be overwritten.
        /// </param>
        public void GetFile(string remoteFile, string localFile, bool failIfExists)
        {
            var ret = WININET.FtpGetFile(_hConnect,
                 remoteFile,
                 localFile,
                 failIfExists,
                 WINAPI.FILE_ATTRIBUTE_NORMAL,
                 WININET.FTP_TRANSFER_TYPE_BINARY,
                 IntPtr.Zero);

            if (ret == 0)
            {
                Error();
            }
        }

        /// <summary>
        /// Uploads a file to the FTP server
        /// </summary>
        /// <param name="fileName">
        /// A <see cref="String"> representing the local file path to upload. </see>
        /// </param>
        public void PutFile(string fileName)
        {
            PutFile(fileName, Path.GetFileName(fileName));
        }

        /// <summary>
        /// Uploads a file to the FTP server
        /// </summary>
        /// <param name="fileName">
        /// A <see cref="String" /> representing the local file path to upload.
        /// </param>
        /// <param name="localFile">
        /// A <see cref="String" /> representing the file path to save the file.
        /// </param>
        public void PutFile(string localFile, string remoteFile)
        {
            var ret = WININET.FtpPutFile(_hConnect,
                localFile,
                remoteFile,
                WININET.FTP_TRANSFER_TYPE_BINARY,
                IntPtr.Zero);

            if (ret == 0)
            {
                Error();
            }
        }

        /// <summary>
        /// Renames a file on the FTP server
        /// </summary>
        /// <param name="existingFile">
        /// A <see cref="String" /> representing the current file name
        /// </param>
        /// <param name="newFile"> A <see cref="String" /> representing the new file name </param>
        public void RenameFile(string existingFile, string newFile)
        {
            var ret = WININET.FtpRenameFile(_hConnect, existingFile, newFile);

            if (ret == 0)
            {
                Error();
            }
        }

        /// <summary>
        /// Deletes a file from the FTP server
        /// </summary>
        /// <param name="fileName">
        /// A <see cref="String" /> representing the path of the file to delete.
        /// </param>
        public void RemoveFile(string fileName)
        {
            var ret = WININET.FtpDeleteFile(_hConnect, fileName);

            if (ret == 0)
            {
                Error();
            }
        }

        /// <summary>
        /// Deletes a directory from the FTP server
        /// </summary>
        /// <param name="directory">
        /// A <see cref="String" /> representing the path of the directory to delete.
        /// </param>
        public void RemoveDirectory(string directory)
        {
            var ret = WININET.FtpRemoveDirectory(_hConnect, directory);
            if (ret == 0)
            {
                Error();
            }
        }

        /// <summary>
        /// Gets details of all files and their available FTP file information from the current
        /// working FTP directory.
        /// </summary>
        /// <returns>
        /// A <see cref="FtpFileInfo[]" /> representing the files in the current working directory.
        /// </returns>
        public FtpFileInfo[] GetFiles()
        {
            return GetFiles(GetCurrentDirectory());
        }

        /// <summary>
        /// Gets details of all files and their available FTP file information from the current
        /// working FTP directory that match the file mask.
        /// </summary>
        /// <param name="mask"> A <see cref="String" /> representing the file mask to match files. </param>
        /// <returns>
        /// A <see cref="FtpFileInfo[]" /> representing the files in the current working directory.
        /// </returns>
        public FtpFileInfo[] GetFiles(string mask)
        {
            var findData = new WINAPI.WIN32_FIND_DATA();

            var hFindFile = WININET.FtpFindFirstFile(
                _hConnect,
                mask,
                ref findData,
                WININET.INTERNET_FLAG_NO_CACHE_WRITE,
                IntPtr.Zero);
            try
            {
                var files = new List<FtpFileInfo>();
                if (hFindFile == IntPtr.Zero)
                {
                    if (Marshal.GetLastWin32Error() == WINAPI.ERROR_NO_MORE_FILES)
                    {
                        return files.ToArray();
                    }
                    else
                    {
                        Error();
                        return files.ToArray();
                    }
                }

                if ((findData.dfFileAttributes & WINAPI.FILE_ATTRIBUTE_DIRECTORY) != WINAPI.FILE_ATTRIBUTE_DIRECTORY)
                {
                    var file = new FtpFileInfo(this, new string(findData.fileName).TrimEnd('\0'))
                    {
                        LastAccessTime = findData.ftLastAccessTime.ToDateTime(),
                        LastWriteTime = findData.ftLastWriteTime.ToDateTime(),
                        CreationTime = findData.ftCreationTime.ToDateTime(),
                        Attributes = (FileAttributes)findData.dfFileAttributes
                    };
                    files.Add(file);
                }

                findData = new WINAPI.WIN32_FIND_DATA();
                while (WININET.InternetFindNextFile(hFindFile, ref findData) != 0)
                {
                    if ((findData.dfFileAttributes & WINAPI.FILE_ATTRIBUTE_DIRECTORY) != WINAPI.FILE_ATTRIBUTE_DIRECTORY)
                    {
                        var file = new FtpFileInfo(this, new string(findData.fileName).TrimEnd('\0'))
                        {
                            LastAccessTime = findData.ftLastAccessTime.ToDateTime(),
                            LastWriteTime = findData.ftLastWriteTime.ToDateTime(),
                            CreationTime = findData.ftCreationTime.ToDateTime(),
                            Attributes = (FileAttributes)findData.dfFileAttributes
                        };
                        files.Add(file);
                    }

                    findData = new WINAPI.WIN32_FIND_DATA();
                }

                if (Marshal.GetLastWin32Error() != WINAPI.ERROR_NO_MORE_FILES)
                {
                    Error();
                }

                return files.ToArray();
            }
            finally
            {
                if (hFindFile != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(hFindFile);
                }
            }
        }

        /// <summary>
        /// Gets details of all directories and their available FTP directory information from the
        /// current working FTP directory.
        /// </summary>
        /// <returns>
        /// A <see cref="FtpDirectoryInfo[]" /> representing the directories in the current working directory.
        /// </returns>
        public FtpDirectoryInfo[] GetDirectories()
        {
            return GetDirectories(GetCurrentDirectory());
        }

        /// <summary>
        /// Gets details of all directories and their available FTP directory information from the
        /// current working FTP directory that match the directory mask.
        /// </summary>
        /// <returns>
        /// A <see cref="FtpDirectoryInfo[]" /> representing the directories in the current working
        /// directory that match the mask.
        /// </returns>
        public FtpDirectoryInfo[] GetDirectories(string path)
        {
            var findData = new WINAPI.WIN32_FIND_DATA();

            var hFindFile = WININET.FtpFindFirstFile(
                _hConnect,
                path,
                ref findData,
                WININET.INTERNET_FLAG_NO_CACHE_WRITE,
                IntPtr.Zero);
            try
            {
                var directories = new List<FtpDirectoryInfo>();

                if (hFindFile == IntPtr.Zero)
                {
                    if (Marshal.GetLastWin32Error() == WINAPI.ERROR_NO_MORE_FILES)
                    {
                        return directories.ToArray();
                    }
                    else
                    {
                        Error();
                        return directories.ToArray();
                    }
                }

                if ((findData.dfFileAttributes & WINAPI.FILE_ATTRIBUTE_DIRECTORY) == WINAPI.FILE_ATTRIBUTE_DIRECTORY)
                {
                    var dir = new FtpDirectoryInfo(this, new string(findData.fileName).TrimEnd('\0'))
                    {
                        LastAccessTime = findData.ftLastAccessTime.ToDateTime(),
                        LastWriteTime = findData.ftLastWriteTime.ToDateTime(),
                        CreationTime = findData.ftCreationTime.ToDateTime(),
                        Attributes = (FileAttributes)findData.dfFileAttributes
                    };
                    directories.Add(dir);
                }

                findData = new WINAPI.WIN32_FIND_DATA();

                while (WININET.InternetFindNextFile(hFindFile, ref findData) != 0)
                {
                    if ((findData.dfFileAttributes & WINAPI.FILE_ATTRIBUTE_DIRECTORY) == WINAPI.FILE_ATTRIBUTE_DIRECTORY)
                    {
                        var dir = new FtpDirectoryInfo(this, new string(findData.fileName).TrimEnd('\0'))
                        {
                            LastAccessTime = findData.ftLastAccessTime.ToDateTime(),
                            LastWriteTime = findData.ftLastWriteTime.ToDateTime(),
                            CreationTime = findData.ftCreationTime.ToDateTime(),
                            Attributes = (FileAttributes)findData.dfFileAttributes
                        };
                        directories.Add(dir);
                    }

                    findData = new WINAPI.WIN32_FIND_DATA();
                }

                if (Marshal.GetLastWin32Error() != WINAPI.ERROR_NO_MORE_FILES)
                {
                    Error();
                }

                return directories.ToArray();
            }
            finally
            {
                if (hFindFile != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(hFindFile);
                }
            }
        }

        /// <summary>
        /// Creates a directory on the FTP server.
        /// </summary>
        /// <param name="path">
        /// A <see cref="String" /> representing the full or relative path of the directory to create.
        /// </param>
        public void CreateDirectory(string path)
        {
            if (WININET.FtpCreateDirectory(_hConnect, path) == 0)
            {
                Error();
            }
        }

        /// <summary>
        /// Checks if a directory exists.
        /// </summary>
        /// <param name="path"> A <see cref="String" /> representing the path to check. </param>
        /// <returns> A <see cref="Boolean" /> indicating whether the directory exists. </returns>
        public bool DirectoryExists(string path)
        {
            var findData = new WINAPI.WIN32_FIND_DATA();

            var hFindFile = WININET.FtpFindFirstFile(
                _hConnect,
                path,
                ref findData,
                WININET.INTERNET_FLAG_NO_CACHE_WRITE,
                IntPtr.Zero);
            try
            {
                if (hFindFile == IntPtr.Zero)
                {
                    return false;
                }

                return true;
            }
            finally
            {
                if (hFindFile != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(hFindFile);
                }
            }
        }

        /// <summary>
        /// Checks if a file exists.
        /// </summary>
        /// <param name="path"> A <see cref="String" /> representing the path to check. </param>
        /// <returns> A <see cref="Boolean" /> indicating whether the file exists. </returns>
        public bool FileExists(string path)
        {
            var findData = new WINAPI.WIN32_FIND_DATA();

            var hFindFile = WININET.FtpFindFirstFile(
                _hConnect,
                path,
                ref findData,
                WININET.INTERNET_FLAG_NO_CACHE_WRITE,
                IntPtr.Zero);
            try
            {
                if (hFindFile == IntPtr.Zero)
                {
                    return false;
                }

                return true;
            }
            finally
            {
                if (hFindFile != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(hFindFile);
                }
            }
        }

        /// <summary>
        /// Sends a command to the FTP server
        /// </summary>
        /// <param name="cmd"> A <see cref="String" /> representing the command to send. </param>
        /// <returns> A <see cref="String" /> containing the server response. </returns>
        public string SendCommand(string cmd)
        {
            var dataSocket = new IntPtr();

            var result = cmd switch
            {
                "PASV" => WININET.FtpCommand(_hConnect, false, WININET.FTP_TRANSFER_TYPE_ASCII, cmd, IntPtr.Zero, ref dataSocket),
                _ => WININET.FtpCommand(_hConnect, false, WININET.FTP_TRANSFER_TYPE_ASCII, cmd, IntPtr.Zero, ref dataSocket),
            };

            var BUFFER_SIZE = 8192;

            if (result == 0)
            {
                Error();
            }
            else if (dataSocket != IntPtr.Zero)
            {
                var buffer = new StringBuilder(BUFFER_SIZE);
                var bytesRead = 0;

                do
                {
                    result = WININET.InternetReadFile(dataSocket, buffer, BUFFER_SIZE, ref bytesRead);
                } while (result == 1 && bytesRead > 1);

                return buffer.ToString();
            }

            return "";
        }

        /// <summary>
        /// Closes the current FTP connection
        /// </summary>
        public void Close()
        {
            Dispose();
        }

        /// <summary>
        /// Retrieves error message text
        /// </summary>
        /// <param name="code"> A <see cref="Int32" /> representing the system error code. </param>
        /// <returns> A <see cref="String" /> containing the error text. </returns>
        private string InternetLastResponseInfo(ref int code)
        {
            var BUFFER_SIZE = 8192;

            var buff = new StringBuilder(BUFFER_SIZE);
            WININET.InternetGetLastResponseInfo(ref code, buff, ref BUFFER_SIZE);
            return buff.ToString();
        }

        /// <summary>
        /// Retrieves error text and throws an Exception.
        /// </summary>
        private void Error()
        {
            var code = Marshal.GetLastWin32Error();

            if (code == WININET.ERROR_INTERNET_EXTENDED_ERROR)
            {
                var errorText = InternetLastResponseInfo(ref code);
                throw new FtpException(code, errorText);
            }

            throw new Win32Exception(code);
        }

        /// <summary>
        /// The Port used to connect
        /// </summary>
        public int Port { get; } = WININET.INTERNET_DEFAULT_FTP_PORT;

        /// <summary>
        /// The host used to connect.
        /// </summary>
        public string Host { get; }

        private IntPtr _hInternet;
        private IntPtr _hConnect;
        private readonly string _username = "";
        private readonly string _password = "";
        private bool _disposed;

        #region IDisposable Members

        public void Dispose()
        {
            if (!_disposed)
            {
                if (_hConnect != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(_hConnect);
                }

                if (_hInternet != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(_hInternet);
                }

                _hInternet = IntPtr.Zero;
                _hConnect = IntPtr.Zero;

                _disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        #endregion IDisposable Members

        ~FtpConnection()
        {
            Dispose();
        }
    }
}