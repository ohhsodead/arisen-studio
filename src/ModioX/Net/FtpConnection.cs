using ModioX.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ModioX.Net
{
    public class FtpConnection : IDisposable
    {
        private IntPtr _hInternet;
        private IntPtr _hConnect;
        private readonly string _username;
        private readonly string _password;
        private bool _disposed;

        public FtpConnection(string host)
        {
            Port = 0x15;
            _username = "";
            _password = "";
            Host = host;
        }

        public FtpConnection(string host, int port)
        {
            Port = 0x15;
            _username = "";
            _password = "";
            Host = host;
            Port = port;
        }

        public FtpConnection(string host, string username, string password)
        {
            Port = 0x15;
            _username = "";
            _password = "";
            Host = host;
            _username = username;
            _password = password;
        }

        public FtpConnection(string host, int port, string username, string password)
        {
            Port = 0x15;
            _username = "";
            _password = "";
            Host = host;
            Port = port;
            _username = username;
            _password = password;
        }

        public void Close()
        {
            Dispose();
        }

        public void CreateDirectory(string path)
        {
            if (WININET.FtpCreateDirectory(_hConnect, path) == 0)
            {
                Error();
            }
        }

        public bool DirectoryExists(string path)
        {
            bool flag;
            WINAPI.WIN32_FIND_DATA findFileData = new WINAPI.WIN32_FIND_DATA();
            IntPtr hInternet = WININET.FtpFindFirstFile(_hConnect, path, ref findFileData, 0x400_0000, IntPtr.Zero);
            try
            {
                flag = !(hInternet == IntPtr.Zero);
            }
            finally
            {
                if (hInternet != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(hInternet);
                }
            }
            return flag;
        }

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

        private void Error()
        {
            int error = Marshal.GetLastWin32Error();
            if (error == 0x2ee3)
            {
                throw new FtpException(error, InternetLastResponseInfo(ref error));
            }
            throw new Win32Exception(error);
        }

        public bool FileExists(string path)
        {
            bool flag;
            WINAPI.WIN32_FIND_DATA findFileData = new WINAPI.WIN32_FIND_DATA();
            IntPtr hInternet = WININET.FtpFindFirstFile(_hConnect, path, ref findFileData, 0x400_0000, IntPtr.Zero);
            try
            {
                flag = !(hInternet == IntPtr.Zero);
            }
            finally
            {
                if (hInternet != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(hInternet);
                }
            }
            return flag;
        }

        ~FtpConnection()
        {
            Dispose();
        }

        public string GetCurrentDirectory()
        {
            int capacity = 0x105;
            StringBuilder currentDirectory = new StringBuilder(capacity);
            if (WININET.FtpGetCurrentDirectory(_hConnect, currentDirectory, ref capacity) != 0)
            {
                return currentDirectory.ToString();
            }
            Error();
            return null;
        }

        public FtpDirectoryInfo GetCurrentDirectoryInfo()
        {
            return new FtpDirectoryInfo(this, GetCurrentDirectory());
        }

        public FtpDirectoryInfo[] GetDirectories()
        {
            return GetDirectories(GetCurrentDirectory());
        }

        public FtpDirectoryInfo[] GetDirectories(string path)
        {
            FtpDirectoryInfo[] infoArray;
            WINAPI.WIN32_FIND_DATA findFileData = new WINAPI.WIN32_FIND_DATA();
            IntPtr hInternet = WININET.FtpFindFirstFile(_hConnect, path, ref findFileData, 0x400_0000, IntPtr.Zero);
            try
            {
                List<FtpDirectoryInfo> list = new List<FtpDirectoryInfo>();
                if (hInternet == IntPtr.Zero)
                {
                    if (Marshal.GetLastWin32Error() == 0x12)
                    {
                        infoArray = list.ToArray();
                    }
                    else
                    {
                        Error();
                        infoArray = list.ToArray();
                    }
                }
                else
                {
                    if ((findFileData.dfFileAttributes & 0x10) == 0x10)
                    {
                        FtpDirectoryInfo item = new FtpDirectoryInfo(this, new string(findFileData.fileName).TrimEnd(new char[1]))
                        {
                            LastAccessTime = findFileData.ftLastAccessTime.ToDateTime(),
                            LastWriteTime = findFileData.ftLastWriteTime.ToDateTime(),
                            CreationTime = findFileData.ftCreationTime.ToDateTime(),
                            Attributes = (FileAttributes)findFileData.dfFileAttributes
                        };
                        list.Add(item);
                    }
                    findFileData = new WINAPI.WIN32_FIND_DATA();
                    while (true)
                    {
                        if (WININET.InternetFindNextFile(hInternet, ref findFileData) == 0)
                        {
                            if (Marshal.GetLastWin32Error() != 0x12)
                            {
                                Error();
                            }
                            infoArray = list.ToArray();
                            break;
                        }
                        if ((findFileData.dfFileAttributes & 0x10) == 0x10)
                        {
                            FtpDirectoryInfo item = new FtpDirectoryInfo(this, new string(findFileData.fileName).TrimEnd(new char[1]))
                            {
                                LastAccessTime = findFileData.ftLastAccessTime.ToDateTime(),
                                LastWriteTime = findFileData.ftLastWriteTime.ToDateTime(),
                                CreationTime = findFileData.ftCreationTime.ToDateTime(),
                                Attributes = (FileAttributes)findFileData.dfFileAttributes
                            };
                            list.Add(item);
                        }
                        findFileData = new WINAPI.WIN32_FIND_DATA();
                    }
                }
            }
            finally
            {
                if (hInternet != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(hInternet);
                }
            }
            return infoArray;
        }

        public void GetFile(string remoteFile, bool failIfExists)
        {
            GetFile(remoteFile, remoteFile, failIfExists);
        }

        public void GetFile(string remoteFile, string localFile, bool failIfExists)
        {
            if (WININET.FtpGetFile(_hConnect, remoteFile, localFile, failIfExists, 0x80, 2, IntPtr.Zero) == 0)
            {
                Error();
            }
        }

        public FtpFileInfo[] GetFiles() =>
            GetFiles(GetCurrentDirectory());

        public FtpFileInfo[] GetFiles(string mask)
        {
            FtpFileInfo[] infoArray;
            WINAPI.WIN32_FIND_DATA findFileData = new WINAPI.WIN32_FIND_DATA();
            IntPtr hInternet = WININET.FtpFindFirstFile(_hConnect, mask, ref findFileData, 0x400_0000, IntPtr.Zero);
            try
            {
                List<FtpFileInfo> list = new List<FtpFileInfo>();
                if (hInternet == IntPtr.Zero)
                {
                    if (Marshal.GetLastWin32Error() == 0x12)
                    {
                        infoArray = list.ToArray();
                    }
                    else
                    {
                        Error();
                        infoArray = list.ToArray();
                    }
                }
                else
                {
                    if ((findFileData.dfFileAttributes & 0x10) != 0x10)
                    {
                        FtpFileInfo item = new FtpFileInfo(this, new string(findFileData.fileName).TrimEnd(new char[1]))
                        {
                            LastAccessTime = findFileData.ftLastAccessTime.ToDateTime(),
                            LastWriteTime = findFileData.ftLastWriteTime.ToDateTime(),
                            CreationTime = findFileData.ftCreationTime.ToDateTime(),
                            Attributes = (FileAttributes)findFileData.dfFileAttributes
                        };
                        list.Add(item);
                    }
                    findFileData = new WINAPI.WIN32_FIND_DATA();
                    while (true)
                    {
                        if (WININET.InternetFindNextFile(hInternet, ref findFileData) == 0)
                        {
                            if (Marshal.GetLastWin32Error() != 0x12)
                            {
                                Error();
                            }
                            infoArray = list.ToArray();
                            break;
                        }
                        if ((findFileData.dfFileAttributes & 0x10) != 0x10)
                        {
                            FtpFileInfo item = new FtpFileInfo(this, new string(findFileData.fileName).TrimEnd(new char[1]))
                            {
                                LastAccessTime = findFileData.ftLastAccessTime.ToDateTime(),
                                LastWriteTime = findFileData.ftLastWriteTime.ToDateTime(),
                                CreationTime = findFileData.ftCreationTime.ToDateTime(),
                                Attributes = (FileAttributes)findFileData.dfFileAttributes
                            };
                            list.Add(item);
                        }
                        findFileData = new WINAPI.WIN32_FIND_DATA();
                    }
                }
            }
            finally
            {
                if (hInternet != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(hInternet);
                }
            }
            return infoArray;
        }

        public long GetFileSize(string file)
        {
            IntPtr hConnect = new IntPtr(WININET.FtpOpenFile(_hConnect, file, 0x8000_0000, 2, IntPtr.Zero));
            if (!(hConnect == IntPtr.Zero))
            {
                try
                {
                    int dwFileSizeHigh = 0;
                    int num2 = WININET.FtpGetFileSize(hConnect, ref dwFileSizeHigh);
                    return ((dwFileSizeHigh << 0x20) | num2);
                }
                catch (Exception)
                {
                    Error();
                }
                finally
                {
                    WININET.InternetCloseHandle(hConnect);
                }
            }
            else
            {
                Error();
            }
            return 0L;
        }

        private string InternetLastResponseInfo(ref int code)
        {
            int capacity = 0x2000;
            StringBuilder buffer = new StringBuilder(capacity);
            WININET.InternetGetLastResponseInfo(ref code, buffer, ref capacity);
            return buffer.ToString();
        }

        [Obsolete("Use GetFiles or GetDirectories instead.")]
        public List<string> List() =>
            List(null, false);

        [Obsolete("Will be removed in later releases.")]
        private List<string> List(bool onlyDirectories) =>
            List(null, onlyDirectories);

        [Obsolete("Use GetFiles or GetDirectories instead.")]
        public List<string> List(string mask) =>
            List(mask, false);

        [Obsolete("Will be removed in later releases.")]
        private List<string> List(string mask, bool onlyDirectories)
        {
            List<string> list2;
            WINAPI.WIN32_FIND_DATA findFileData = new WINAPI.WIN32_FIND_DATA();
            IntPtr hInternet = WININET.FtpFindFirstFile(_hConnect, mask, ref findFileData, 0x400_0000, IntPtr.Zero);
            try
            {
                List<string> list = new List<string>();
                if (hInternet == IntPtr.Zero)
                {
                    if (Marshal.GetLastWin32Error() == 0x12)
                    {
                        list2 = list;
                    }
                    else
                    {
                        Error();
                        list2 = list;
                    }
                }
                else
                {
                    if (onlyDirectories && ((findFileData.dfFileAttributes & 0x10) == 0x10))
                    {
                        list.Add(new string(findFileData.fileName).TrimEnd(new char[1]));
                    }
                    else if (!onlyDirectories)
                    {
                        list.Add(new string(findFileData.fileName).TrimEnd(new char[1]));
                    }
                    findFileData = new WINAPI.WIN32_FIND_DATA();
                    while (true)
                    {
                        if (WININET.InternetFindNextFile(hInternet, ref findFileData) == 0)
                        {
                            if (Marshal.GetLastWin32Error() != 0x12)
                            {
                                Error();
                            }
                            list2 = list;
                            break;
                        }
                        if (onlyDirectories && ((findFileData.dfFileAttributes & 0x10) == 0x10))
                        {
                            list.Add(new string(findFileData.fileName).TrimEnd(new char[1]));
                        }
                        else if (!onlyDirectories)
                        {
                            list.Add(new string(findFileData.fileName).TrimEnd(new char[1]));
                        }
                        findFileData = new WINAPI.WIN32_FIND_DATA();
                    }
                }
            }
            finally
            {
                if (hInternet != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(hInternet);
                }
            }
            return list2;
        }

        public void Login()
        {
            Login(_username, _password);
        }

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
            _hConnect = WININET.InternetConnect(_hInternet, Host, Port, username, password, 1, 0x800_0000, IntPtr.Zero);
            if (_hConnect == IntPtr.Zero)
            {
                Error();
            }
        }

        public void Open()
        {
            if (string.IsNullOrEmpty(Host))
            {
                throw new ArgumentNullException("Host");
            }
            _hInternet = WININET.InternetOpen(Environment.UserName, 0, null, null, 4);
            if (_hInternet == IntPtr.Zero)
            {
                Error();
            }
        }

        public void PutFile(string fileName)
        {
            PutFile(fileName, Path.GetFileName(fileName));
        }

        public void PutFile(string localFile, string remoteFile)
        {
            if (WININET.FtpPutFile(_hConnect, localFile, remoteFile, 2, IntPtr.Zero) == 0)
            {
                Error();
            }
        }

        public void RemoveDirectory(string directory)
        {
            if (WININET.FtpRemoveDirectory(_hConnect, directory) == 0)
            {
                Error();
            }
        }

        public void RemoveFile(string fileName)
        {
            if (WININET.FtpDeleteFile(_hConnect, fileName) == 0)
            {
                Error();
            }
        }

        public void RenameFile(string existingFile, string newFile)
        {
            if (WININET.FtpRenameFile(_hConnect, existingFile, newFile) == 0)
            {
                Error();
            }
        }

        public string SendCommand(string cmd)
        {
            IntPtr ftpCommand = new IntPtr();
            int num = (cmd != "PASV") ? WININET.FtpCommand(_hConnect, false, 1, cmd, IntPtr.Zero, ref ftpCommand) : WININET.FtpCommand(_hConnect, false, 1, cmd, IntPtr.Zero, ref ftpCommand);
            int capacity = 0x2000;
            if (num == 0)
            {
                Error();
            }
            else if (ftpCommand != IntPtr.Zero)
            {
                StringBuilder buffer = new StringBuilder(capacity);
                int bytesRead = 0;
                while (true)
                {
                    num = WININET.InternetReadFile(ftpCommand, buffer, capacity, ref bytesRead);
                    if ((num != 1) || (bytesRead <= 1))
                    {
                        return buffer.ToString();
                    }
                }
            }
            return "";
        }

        public void SetCurrentDirectory(string directory)
        {
            if (WININET.FtpSetCurrentDirectory(_hConnect, directory) == 0)
            {
                Error();
            }
        }

        public void SetLocalDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                throw new InvalidDataException($"{directory} is not a directory!");
            }
            Environment.CurrentDirectory = directory;
        }

        public int Port { get; }

        public string Host { get; }
    }
}