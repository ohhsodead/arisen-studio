using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using ModioX.Extensions;

namespace ModioX.Net
{
    public class FtpConnection : IDisposable
    {
        private readonly string _password;
        private readonly string _username;
        private bool _disposed;
        private IntPtr _hConnect;
        private IntPtr _hInternet;

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

        public int Port { get; }

        public string Host { get; }

        public void Dispose()
        {
            switch (_disposed)
            {
                case false:
                    {
                        if (_hConnect != IntPtr.Zero) WININET.InternetCloseHandle(_hConnect);
                        if (_hInternet != IntPtr.Zero) WININET.InternetCloseHandle(_hInternet);
                        _hInternet = IntPtr.Zero;
                        _hConnect = IntPtr.Zero;
                        _disposed = true;
                        GC.SuppressFinalize(this);
                        break;
                    }
            }
        }

        public void Close()
        {
            Dispose();
        }

        public void CreateDirectory(string path)
        {
            if (WININET.FtpCreateDirectory(_hConnect, path) == 0) Error();
        }

        public bool DirectoryExists(string path)
        {
            bool flag;
            WINAPI.WIN32_FIND_DATA findFileData = new();
            IntPtr hInternet = WININET.FtpFindFirstFile(_hConnect, path, ref findFileData, 0x400_0000, IntPtr.Zero);
            try
            {
                flag = !(hInternet == IntPtr.Zero);
            }
            finally
            {
                if (hInternet != IntPtr.Zero) WININET.InternetCloseHandle(hInternet);
            }

            return flag;
        }

        private void Error()
        {
            int error = Marshal.GetLastWin32Error();
            throw error switch
            {
                0x2ee3 => new FtpException(error, InternetLastResponseInfo(ref error)),
                _ => new Win32Exception(error)
            };
        }

        public bool FileExists(string path)
        {
            bool flag;
            WINAPI.WIN32_FIND_DATA findFileData = new();
            IntPtr hInternet = WININET.FtpFindFirstFile(_hConnect, path, ref findFileData, 0x400_0000, IntPtr.Zero);
            try
            {
                flag = !(hInternet == IntPtr.Zero);
            }
            finally
            {
                if (hInternet != IntPtr.Zero) WININET.InternetCloseHandle(hInternet);
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
            StringBuilder currentDirectory = new(capacity);
            if (WININET.FtpGetCurrentDirectory(_hConnect, currentDirectory, ref capacity) != 0)
                return currentDirectory.ToString();
            Error();
            return null;
        }

        public FtpDirectoryInfo GetCurrentDirectoryInfo()
        {
            return new(this, GetCurrentDirectory());
        }

        public FtpDirectoryInfo[] GetDirectories()
        {
            return GetDirectories(GetCurrentDirectory());
        }

        public FtpDirectoryInfo[] GetDirectories(string path)
        {
            FtpDirectoryInfo[] infoArray;
            WINAPI.WIN32_FIND_DATA findFileData = new();
            IntPtr hInternet = WININET.FtpFindFirstFile(_hConnect, path, ref findFileData, 0x400_0000, IntPtr.Zero);
            try
            {
                List<FtpDirectoryInfo> list = new();
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
                    switch (findFileData.dfFileAttributes & 0x10)
                    {
                        case 0x10:
                            {
                                FtpDirectoryInfo item = new(this, new string(findFileData.fileName).TrimEnd(new char[1]))
                                {
                                    LastAccessTime = findFileData.ftLastAccessTime.ToDateTime(),
                                    LastWriteTime = findFileData.ftLastWriteTime.ToDateTime(),
                                    CreationTime = findFileData.ftCreationTime.ToDateTime(),
                                    Attributes = (FileAttributes)findFileData.dfFileAttributes
                                };
                                list.Add(item);
                                break;
                            }
                    }

                    findFileData = new WINAPI.WIN32_FIND_DATA();
                    while (true)
                    {
                        if (WININET.InternetFindNextFile(hInternet, ref findFileData) == 0)
                        {
                            if (Marshal.GetLastWin32Error() != 0x12) Error();
                            infoArray = list.ToArray();
                            break;
                        }

                        switch (findFileData.dfFileAttributes & 0x10)
                        {
                            case 0x10:
                                {
                                    FtpDirectoryInfo item = new(this, new string(findFileData.fileName).TrimEnd(new char[1]))
                                    {
                                        LastAccessTime = findFileData.ftLastAccessTime.ToDateTime(),
                                        LastWriteTime = findFileData.ftLastWriteTime.ToDateTime(),
                                        CreationTime = findFileData.ftCreationTime.ToDateTime(),
                                        Attributes = (FileAttributes)findFileData.dfFileAttributes
                                    };
                                    list.Add(item);
                                    break;
                                }
                        }

                        findFileData = new WINAPI.WIN32_FIND_DATA();
                    }
                }
            }
            finally
            {
                if (hInternet != IntPtr.Zero) WININET.InternetCloseHandle(hInternet);
            }

            return infoArray;
        }

        public void GetFile(string remoteFile, bool failIfExists)
        {
            GetFile(remoteFile, remoteFile, failIfExists);
        }

        public void GetFile(string remoteFile, string localFile, bool failIfExists)
        {
            if (WININET.FtpGetFile(_hConnect, remoteFile, localFile, failIfExists, 0x80, 2, IntPtr.Zero) == 0) Error();
        }

        public FtpFileInfo[] GetFiles()
        {
            return GetFiles(GetCurrentDirectory());
        }

        public FtpFileInfo[] GetFiles(string mask)
        {
            FtpFileInfo[] infoArray;
            WINAPI.WIN32_FIND_DATA findFileData = new();
            IntPtr hInternet = WININET.FtpFindFirstFile(_hConnect, mask, ref findFileData, 0x400_0000, IntPtr.Zero);
            try
            {
                List<FtpFileInfo> list = new();
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
                        FtpFileInfo item = new(this, new string(findFileData.fileName).TrimEnd(new char[1]))
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
                            if (Marshal.GetLastWin32Error() != 0x12) Error();
                            infoArray = list.ToArray();
                            break;
                        }

                        if ((findFileData.dfFileAttributes & 0x10) != 0x10)
                        {
                            FtpFileInfo item = new(this, new string(findFileData.fileName).TrimEnd(new char[1]))
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
                if (hInternet != IntPtr.Zero) WININET.InternetCloseHandle(hInternet);
            }

            return infoArray;
        }

        public long GetFileSize(string file)
        {
            IntPtr hConnect = new(WININET.FtpOpenFile(_hConnect, file, 0x8000_0000, 2, IntPtr.Zero));
            switch ((hConnect == IntPtr.Zero))
            {
                case false:
                    try
                    {
                        int dwFileSizeHigh = 0;
                        int num2 = WININET.FtpGetFileSize(hConnect, ref dwFileSizeHigh);
                        return (dwFileSizeHigh << 0x20) | num2;
                    }
                    catch (Exception)
                    {
                        Error();
                    }
                    finally
                    {
                        WININET.InternetCloseHandle(hConnect);
                    }

                    break;
                default:
                    Error();
                    break;
            }

            return 0L;
        }

        private string InternetLastResponseInfo(ref int code)
        {
            int capacity = 0x2000;
            StringBuilder buffer = new(capacity);
            WININET.InternetGetLastResponseInfo(ref code, buffer, ref capacity);
            return buffer.ToString();
        }

        public void Login()
        {
            Login(_username, _password);
        }

        public void Login(string username, string password)
        {
            switch (username)
            {
                case null:
                    throw new ArgumentNullException("username");
            }
            switch (password)
            {
                case null:
                    throw new ArgumentNullException("password");
            }
            _hConnect = WININET.InternetConnect(_hInternet, Host, Port, username, password, 1, 0x800_0000, IntPtr.Zero);
            if (_hConnect == IntPtr.Zero) Error();
        }

        public void Open()
        {
            if (string.IsNullOrEmpty(Host)) throw new ArgumentNullException("Host");
            _hInternet = WININET.InternetOpen(Environment.UserName, 0, null, null, 4);
            if (_hInternet == IntPtr.Zero) Error();
        }

        public void PutFile(string fileName)
        {
            PutFile(fileName, Path.GetFileName(fileName));
        }

        public void PutFile(string localFile, string remoteFile)
        {
            if (WININET.FtpPutFile(_hConnect, localFile, remoteFile, 2, IntPtr.Zero) == 0) Error();
        }

        public void RemoveDirectory(string directory)
        {
            if (WININET.FtpRemoveDirectory(_hConnect, directory) == 0) Error();
        }

        public void RemoveFile(string fileName)
        {
            if (WININET.FtpDeleteFile(_hConnect, fileName) == 0) Error();
        }

        public void RenameFile(string existingFile, string newFile)
        {
            if (WININET.FtpRenameFile(_hConnect, existingFile, newFile) == 0) Error();
        }

        public string SendCommand(string cmd)
        {
            IntPtr ftpCommand = new();
            int num = cmd != "PASV"
                ? WININET.FtpCommand(_hConnect, false, 1, cmd, IntPtr.Zero, ref ftpCommand)
                : WININET.FtpCommand(_hConnect, false, 1, cmd, IntPtr.Zero, ref ftpCommand);
            int capacity = 0x2000;
            switch (num)
            {
                case 0:
                    Error();
                    break;
                default:
                    {
                        if (ftpCommand != IntPtr.Zero)
                        {
                            StringBuilder buffer = new(capacity);
                            int bytesRead = 0;
                            while (true)
                            {
                                num = WININET.InternetReadFile(ftpCommand, buffer, capacity, ref bytesRead);
                                if (num != 1 || bytesRead <= 1) return buffer.ToString();
                            }
                        }

                        break;
                    }
            }

            return "";
        }

        public void SetCurrentDirectory(string directory)
        {
            if (WININET.FtpSetCurrentDirectory(_hConnect, directory) == 0) Error();
        }

        public void SetLocalDirectory(string directory)
        {
            if (!Directory.Exists(directory)) throw new InvalidDataException($"{directory} is not a directory!");
            Environment.CurrentDirectory = directory;
        }
    }
}