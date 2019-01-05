namespace ps3xftp.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Net;
    using System.Runtime.InteropServices;
    using System.Text;

    public class PS3FTP : IDisposable
    {
        private bool _disposed;
        private IntPtr _hConnect;
        private IntPtr _hInternet;
        private string _host;
        private string _password;
        private int _port;
        private string _username;
        private bool _isconnected;

        public PS3FTP(string host)
        {
            this._username = "";
            this._password = "";
            this._port = 0x15;
            this._host = host;
            Open();
            Login();
        }

        public PS3FTP(string host, int port)
        {
            this._username = "";
            this._password = "";
            this._port = 0x15;
            this._host = host;
            this._port = port;
            Open();
            Login();
        }

        public PS3FTP(string host, string username, string password)
        {
            this._username = "";
            this._password = "";
            this._port = 0x15;
            this._host = host;
            this._username = username;
            this._password = password;
            Open();
            Login();
        }

        public PS3FTP(string host, int port, string username, string password)
        {
            this._username = "";
            this._password = "";
            this._port = 0x15;
            this._host = host;
            this._port = port;
            this._username = username;
            this._password = password;
        }

        public void Close()
        {
            this.Dispose();
        }
        public bool IsConnected
        {
            get { return _isconnected; }
        }
        public void CreateDirectory(string path)
        {
            if (WININET.FtpCreateDirectory(this._hConnect, path) == 0)
            {
                this.Error();
            }
        }

        public bool DirectoryExists(string path)
        {
            bool flag;
            WINAPI.WIN32_FIND_DATA findFileData = new WINAPI.WIN32_FIND_DATA();
            IntPtr hInternet = WININET.FtpFindFirstFile(this._hConnect, path, ref findFileData, 0x4000000, IntPtr.Zero);
            try
            {
                if (hInternet == IntPtr.Zero)
                {
                    return false;
                }
                flag = true;
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
            if (!this._disposed)
            {
                if (this._hConnect != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(this._hConnect);
                }
                if (this._hInternet != IntPtr.Zero)
                {
                    WININET.InternetCloseHandle(this._hInternet);
                }
                this._hInternet = IntPtr.Zero;
                this._hConnect = IntPtr.Zero;
                this._disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        private void Error()
        {
            int code = Marshal.GetLastWin32Error();
            if (code == 0x2ee3)
            {
                string message = this.InternetLastResponseInfo(ref code);
                throw new FtpException(code, message);
            }
            throw new Win32Exception(code);
        }

        public bool FileExists(string path)
        {
            bool flag;
            WINAPI.WIN32_FIND_DATA findFileData = new WINAPI.WIN32_FIND_DATA();
            IntPtr hInternet = WININET.FtpFindFirstFile(this._hConnect, path, ref findFileData, 0x4000000, IntPtr.Zero);
            try
            {
                if (hInternet == IntPtr.Zero)
                {
                    return false;
                }
                flag = true;
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

        ~PS3FTP()
        {
            this.Dispose();
        }

        public string GetCurrentDirectory()
        {
            int capacity = 0x105;
            StringBuilder currentDirectory = new StringBuilder(capacity);
            if (WININET.FtpGetCurrentDirectory(this._hConnect, currentDirectory, ref capacity) == 0)
            {
                this.Error();
                return null;
            }
            return currentDirectory.ToString();
        }

        public FtpDirectoryInfo GetCurrentDirectoryInfo()
        {
            return new FtpDirectoryInfo(this, this.GetCurrentDirectory());
        }

        public FtpDirectoryInfo[] GetDirectories()
        {
            return this.GetDirectories(this.GetCurrentDirectory());
        }

        public FtpDirectoryInfo[] GetDirectories(string path)
        {
            FtpDirectoryInfo[] infoArray;
            WINAPI.WIN32_FIND_DATA findFileData = new WINAPI.WIN32_FIND_DATA();
            IntPtr hInternet = WININET.FtpFindFirstFile(this._hConnect, path, ref findFileData, 0x4000000, IntPtr.Zero);
            try
            {
                List<FtpDirectoryInfo> list = new List<FtpDirectoryInfo>();
                if (hInternet == IntPtr.Zero)
                {
                    if (Marshal.GetLastWin32Error() != 0x12)
                    {
                        this.Error();
                    }
                    return list.ToArray();
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
                for (findFileData = new WINAPI.WIN32_FIND_DATA(); WININET.InternetFindNextFile(hInternet, ref findFileData) != 0; findFileData = new WINAPI.WIN32_FIND_DATA())
                {
                    if ((findFileData.dfFileAttributes & 0x10) == 0x10)
                    {
                        FtpDirectoryInfo info2 = new FtpDirectoryInfo(this, new string(findFileData.fileName).TrimEnd(new char[1]))
                        {
                            LastAccessTime = findFileData.ftLastAccessTime.ToDateTime(),
                            LastWriteTime = findFileData.ftLastWriteTime.ToDateTime(),
                            CreationTime = findFileData.ftCreationTime.ToDateTime(),
                            Attributes = (FileAttributes)findFileData.dfFileAttributes
                        };
                        list.Add(info2);
                    }
                }
                if (Marshal.GetLastWin32Error() != 0x12)
                {
                    this.Error();
                }
                infoArray = list.ToArray();
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
            this.GetFile(remoteFile, remoteFile, failIfExists);
        }

        public void GetFile(string remoteFile, string localFile, bool failIfExists)
        {
            if (WININET.FtpGetFile(this._hConnect, remoteFile, localFile, failIfExists, 0x80, 2, IntPtr.Zero) == 0)
            {
                this.Error();
            }
        }

        public FtpFileInfo[] GetFiles()
        {
            return this.GetFiles(this.GetCurrentDirectory());
        }

        public FtpFileInfo[] GetFiles(string mask)
        {
            FtpFileInfo[] infoArray;
            WINAPI.WIN32_FIND_DATA findFileData = new WINAPI.WIN32_FIND_DATA();
            IntPtr hInternet = WININET.FtpFindFirstFile(this._hConnect, mask, ref findFileData, 0x4000000, IntPtr.Zero);
            try
            {
                List<FtpFileInfo> list = new List<FtpFileInfo>();
                if (hInternet == IntPtr.Zero)
                {
                    if (Marshal.GetLastWin32Error() != 0x12)
                    {
                        this.Error();
                    }
                    return list.ToArray();
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
                for (findFileData = new WINAPI.WIN32_FIND_DATA(); WININET.InternetFindNextFile(hInternet, ref findFileData) != 0; findFileData = new WINAPI.WIN32_FIND_DATA())
                {
                    if ((findFileData.dfFileAttributes & 0x10) != 0x10)
                    {
                        FtpFileInfo info2 = new FtpFileInfo(this, new string(findFileData.fileName).TrimEnd(new char[1]))
                        {
                            LastAccessTime = findFileData.ftLastAccessTime.ToDateTime(),
                            LastWriteTime = findFileData.ftLastWriteTime.ToDateTime(),
                            CreationTime = findFileData.ftCreationTime.ToDateTime(),
                            Attributes = (FileAttributes)findFileData.dfFileAttributes
                        };
                        list.Add(info2);
                    }
                }
                if (Marshal.GetLastWin32Error() != 0x12)
                {
                    this.Error();
                }
                infoArray = list.ToArray();
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
            IntPtr hConnect = new IntPtr(WININET.FtpOpenFile(this._hConnect, file, 0x80000000, 2, IntPtr.Zero));
            if (hConnect == IntPtr.Zero)
            {
                this.Error();
            }
            else
            {
                try
                {
                    int dwFileSizeHigh = 0;
                    int num2 = WININET.FtpGetFileSize(hConnect, ref dwFileSizeHigh);
                    return ((dwFileSizeHigh << 0x20) | num2);
                }
                catch (Exception)
                {
                    this.Error();
                }
                finally
                {
                    WININET.InternetCloseHandle(hConnect);
                }
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
        public List<string> List()
        {
            return this.List(null, false);
        }

        [Obsolete("Will be removed in later releases.")]
        private List<string> List(bool onlyDirectories)
        {
            return this.List(null, onlyDirectories);
        }

        [Obsolete("Use GetFiles or GetDirectories instead.")]
        public List<string> List(string mask)
        {
            return this.List(mask, false);
        }

        [Obsolete("Will be removed in later releases.")]
        private List<string> List(string mask, bool onlyDirectories)
        {
            List<string> list2;
            WINAPI.WIN32_FIND_DATA findFileData = new WINAPI.WIN32_FIND_DATA();
            IntPtr hInternet = WININET.FtpFindFirstFile(this._hConnect, mask, ref findFileData, 0x4000000, IntPtr.Zero);
            try
            {
                List<string> list = new List<string>();
                if (hInternet == IntPtr.Zero)
                {
                    if (Marshal.GetLastWin32Error() != 0x12)
                    {
                        this.Error();
                    }
                    return list;
                }
                if (onlyDirectories && ((findFileData.dfFileAttributes & 0x10) == 0x10))
                {
                    list.Add(new string(findFileData.fileName).TrimEnd(new char[1]));
                }
                else if (!onlyDirectories)
                {
                    list.Add(new string(findFileData.fileName).TrimEnd(new char[1]));
                }
                for (findFileData = new WINAPI.WIN32_FIND_DATA(); WININET.InternetFindNextFile(hInternet, ref findFileData) != 0; findFileData = new WINAPI.WIN32_FIND_DATA())
                {
                    if (onlyDirectories && ((findFileData.dfFileAttributes & 0x10) == 0x10))
                    {
                        list.Add(new string(findFileData.fileName).TrimEnd(new char[1]));
                    }
                    else if (!onlyDirectories)
                    {
                        list.Add(new string(findFileData.fileName).TrimEnd(new char[1]));
                    }
                }
                if (Marshal.GetLastWin32Error() != 0x12)
                {
                    this.Error();
                }
                list2 = list;
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
            this.Login(this._username, this._password);
        }

        public void Login(string username, string password)
        {
            if (username == null)
            {
                _isconnected = false;
                throw new ArgumentNullException("username");
            }
            if (password == null)
            {
                _isconnected = false;
                throw new ArgumentNullException("password");
            }
            this._hConnect = WININET.InternetConnect(this._hInternet, this._host, this._port, username, password, 1, 0x8000000, IntPtr.Zero);
            _isconnected = true;
            if (this._hConnect == IntPtr.Zero)
            {
                _isconnected = false;
                this.Error();
            }
        }

        public void Open()
        {
            if (string.IsNullOrEmpty(this._host))
            {
                _isconnected = false;
                throw new ArgumentNullException("Host");
            }
            this._hInternet = WININET.InternetOpen(Environment.UserName, 0, null, null, 4);
            _isconnected = true;
            if (this._hInternet == IntPtr.Zero)
            {
                _isconnected = false;
                this.Error();
            }
        }

        public void PutFile(string fileName)
        {
            this.PutFile(fileName, Path.GetFileName(fileName));
        }

        public void PutFile(string localFile, string remoteFile)
        {
            if (WININET.FtpPutFile(this._hConnect, localFile, remoteFile, 2, IntPtr.Zero) == 0)
            {
                this.Error();
            }
        }

        public void RemoveDirectory(string directory)
        {
            if (WININET.FtpRemoveDirectory(this._hConnect, directory) == 0)
            {
                this.Error();
            }
        }

        public void RemoveFile(string fileName)
        {
            if (WININET.FtpDeleteFile(this._hConnect, fileName) == 0)
            {
                this.Error();
            }
        }

        public void RenameFile(string existingFile, string newFile)
        {
            if (WININET.FtpRenameFile(this._hConnect, existingFile, newFile) == 0)
            {
                this.Error();
            }
        }

        public string SendCommand(string cmd)
        {
            int num;
            string str;
            IntPtr ftpCommand = new IntPtr();
            if (((str = cmd) != null) && (str == "PASV"))
            {
                num = WININET.FtpCommand(this._hConnect, false, 1, cmd, IntPtr.Zero, ref ftpCommand);
            }
            else
            {
                num = WININET.FtpCommand(this._hConnect, false, 1, cmd, IntPtr.Zero, ref ftpCommand);
            }
            int capacity = 0x2000;
            if (num == 0)
            {
                this.Error();
            }
            else if (ftpCommand != IntPtr.Zero)
            {
                StringBuilder buffer = new StringBuilder(capacity);
                int bytesRead = 0;
                while ((WININET.InternetReadFile(ftpCommand, buffer, capacity, ref bytesRead) == 1) && (bytesRead > 1))
                {
                }
                return buffer.ToString();
            }
            return "";
        }

        public void SetCurrentDirectory(string directory)
        {
            if (WININET.FtpSetCurrentDirectory(this._hConnect, directory) == 0)
            {
                this.Error();
            }
        }
        public string ReadFile(string directory)
        {
            WebClient request = new WebClient();
            string url = "ftp://" + this._host + directory;
            string fileString = "";
            try
            {
                byte[] newFileData = request.DownloadData(url);
                fileString = System.Text.Encoding.UTF8.GetString(newFileData);
            }
            catch
            {
            }
            return fileString;
        }
        public void SetLocalDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                throw new InvalidDataException(string.Format("{0} is not a directory!", directory));
            }
            Environment.CurrentDirectory = directory;
        }

        public string Host
        {
            get
            {
                return this._host;
            }
        }

        public int Port
        {
            get
            {
                return this._port;
            }
        }
    }

    public class FtpDirectoryInfo : FileSystemInfo
    {
        private FileAttributes _attribues;
        private DateTime? _creationTime;
        private PS3FTP _ftp;
        private DateTime? _lastAccessTime;
        private DateTime? _lastWriteTime;

        public FtpDirectoryInfo(PS3FTP ftp, string path)
        {
            this._ftp = ftp;
            base.FullPath = path;
        }

        public override void Delete()
        {
            try
            {
                this._ftp.RemoveDirectory(this.Name);
            }
            catch (FtpException exception)
            {
                throw new Exception("Unable to delete directory.", exception);
            }
        }

        public FtpDirectoryInfo[] GetDirectories()
        {
            return this.FtpConnection.GetDirectories(base.FullPath);
        }

        public FtpDirectoryInfo[] GetDirectories(string path)
        {
            path = Path.Combine(base.FullPath, path);
            return this.FtpConnection.GetDirectories(path);
        }

        public FtpFileInfo[] GetFiles()
        {
            return this.GetFiles(this.FtpConnection.GetCurrentDirectory());
        }

        public FtpFileInfo[] GetFiles(string mask)
        {
            return this.FtpConnection.GetFiles(mask);
        }

        public FileAttributes Attributes
        {
            get
            {
                return this._attribues;
            }
            internal set
            {
                this._attribues = value;
            }
        }

        public DateTime? CreationTime
        {
            get
            {
                if (!this._creationTime.HasValue)
                {
                    return null;
                }
                return new DateTime?(this._creationTime.Value);
            }
            internal set
            {
                this._creationTime = value;
            }
        }

        public DateTime? CreationTimeUtc
        {
            get
            {
                if (!this._creationTime.HasValue)
                {
                    return null;
                }
                return new DateTime?(this._creationTime.Value.ToUniversalTime());
            }
        }

        public override bool Exists
        {
            get
            {
                return this.FtpConnection.DirectoryExists(this.FullName);
            }
        }

        public PS3FTP FtpConnection
        {
            get
            {
                return this._ftp;
            }
        }

        public DateTime? LastAccessTime
        {
            get
            {
                if (!this._lastAccessTime.HasValue)
                {
                    return null;
                }
                return new DateTime?(this._lastAccessTime.Value);
            }
            internal set
            {
                this._lastAccessTime = value;
            }
        }

        public DateTime? LastAccessTimeUtc
        {
            get
            {
                if (!this._lastAccessTime.HasValue)
                {
                    return null;
                }
                return new DateTime?(this._lastAccessTime.Value.ToUniversalTime());
            }
        }

        public DateTime? LastWriteTime
        {
            get
            {
                if (!this._lastWriteTime.HasValue)
                {
                    return null;
                }
                return new DateTime?(this._lastWriteTime.Value);
            }
            internal set
            {
                this._lastWriteTime = value;
            }
        }

        public DateTime? LastWriteTimeUtc
        {
            get
            {
                if (!this._lastWriteTime.HasValue)
                {
                    return null;
                }
                return new DateTime?(this._lastWriteTime.Value.ToUniversalTime());
            }
        }

        public override string Name
        {
            get
            {
                return Path.GetFileName(base.FullPath);
            }
        }
    }

    public class FtpFileInfo : FileSystemInfo
    {
        private FileAttributes _attribues;
        private DateTime? _creationTime;
        private string _filePath;
        private PS3FTP _ftp;
        private DateTime? _lastAccessTime;
        private DateTime? _lastWriteTime;
        private string _name;

        public FtpFileInfo(PS3FTP ftp, string filePath)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("fileName");
            }
            base.OriginalPath = filePath;
            base.FullPath = filePath;
            this._filePath = filePath;
            this._ftp = ftp;
            this._name = Path.GetFileName(filePath);
        }

        public override void Delete()
        {
            this.FtpConnection.RemoveFile(this.FullName);
        }

        public FileAttributes Attributes
        {
            get
            {
                return this._attribues;
            }
            internal set
            {
                this._attribues = value;
            }
        }

        public DateTime? CreationTime
        {
            get
            {
                if (!this._creationTime.HasValue)
                {
                    return null;
                }
                return new DateTime?(this._creationTime.Value);
            }
            internal set
            {
                this._creationTime = value;
            }
        }

        public DateTime? CreationTimeUtc
        {
            get
            {
                if (!this._creationTime.HasValue)
                {
                    return null;
                }
                return new DateTime?(this._creationTime.Value.ToUniversalTime());
            }
        }

        public override bool Exists
        {
            get
            {
                return this.FtpConnection.FileExists(this.FullName);
            }
        }

        public PS3FTP FtpConnection
        {
            get
            {
                return this._ftp;
            }
        }

        public DateTime? LastAccessTime
        {
            get
            {
                if (!this._lastAccessTime.HasValue)
                {
                    return null;
                }
                return new DateTime?(this._lastAccessTime.Value);
            }
            internal set
            {
                this._lastAccessTime = value;
            }
        }

        public DateTime? LastAccessTimeUtc
        {
            get
            {
                if (!this._lastAccessTime.HasValue)
                {
                    return null;
                }
                return new DateTime?(this._lastAccessTime.Value.ToUniversalTime());
            }
        }

        public DateTime? LastWriteTime
        {
            get
            {
                if (!this._lastWriteTime.HasValue)
                {
                    return null;
                }
                return new DateTime?(this._lastWriteTime.Value);
            }
            internal set
            {
                this._lastWriteTime = value;
            }
        }

        public DateTime? LastWriteTimeUtc
        {
            get
            {
                if (!this._lastWriteTime.HasValue)
                {
                    return null;
                }
                return new DateTime?(this._lastWriteTime.Value.ToUniversalTime());
            }
        }

        public override string Name
        {
            get
            {
                return this._name;
            }
        }
    }
    public static class Extensions
    {
        public static DateTime? ToDateTime(this WINAPI.FILETIME time)
        {
            if ((time.dwHighDateTime == 0) && (time.dwLowDateTime == 0))
            {
                return null;
            }
            uint dwLowDateTime = (uint)time.dwLowDateTime;
            long fileTime = (time.dwHighDateTime << 0x20) | dwLowDateTime;
            return new DateTime?(DateTime.FromFileTimeUtc(fileTime));
        }
    }
    public class FtpException : Exception
    {
        private int _error;

        public FtpException(int error, string message)
            : base(message)
        {
            this._error = error;
        }

        public int ErrorCode
        {
            get
            {
                return this._error;
            }
        }
    }
    public static class WINAPI
    {
        public const int ERROR_NO_MORE_FILES = 0x12;
        public const int FILE_ATTRIBUTE_DIRECTORY = 0x10;
        public const int FILE_ATTRIBUTE_NORMAL = 0x80;
        private const uint FORMAT_MESSAGE_FROM_HMODULE = 0x800;
        private const uint FORMAT_MESSAGE_FROM_SYSTEM = 0x1000;
        private const uint FORMAT_MESSAGE_IGNORE_INSERTS = 0x200;
        public const uint GENERIC_READ = 0x80000000;
        public const int MAX_PATH = 260;
        public const int NO_ERROR = 0;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern uint FormatMessage(uint dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer, uint nSize, IntPtr Arguments);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FreeLibrary(IntPtr hModule);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr LoadLibrary([In, MarshalAs(UnmanagedType.LPTStr)] string lpLibFileName);
        public static string TranslateInternetError(uint errorCode)
        {
            string str;
            IntPtr zero = IntPtr.Zero;
            try
            {
                StringBuilder lpBuffer = new StringBuilder(0xff);
                zero = LoadLibrary("wininet.dll");
                if (FormatMessage(0x1200, zero, errorCode, 0, lpBuffer, (uint)(lpBuffer.Capacity + 1), IntPtr.Zero) != 0)
                {
                    return lpBuffer.ToString();
                }
                str = string.Empty;
            }
            catch
            {
                str = "Unknown Error";
            }
            finally
            {
                FreeLibrary(zero);
            }
            return str;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct FILETIME
        {
            public int dwLowDateTime;
            public int dwHighDateTime;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct INTERNET_BUFFERS
        {
            public int dwStructSize;
            public IntPtr Next;
            public string Header;
            public int dwHeadersLength;
            public int dwHeadersTotal;
            public IntPtr lpvBuffer;
            public int dwBufferLength;
            public int dwBufferTotal;
            public int dwOffsetLow;
            public int dwOffsetHigh;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct WIN32_FIND_DATA
        {
            public int dfFileAttributes;
            public WINAPI.FILETIME ftCreationTime;
            public WINAPI.FILETIME ftLastAccessTime;
            public WINAPI.FILETIME ftLastWriteTime;
            public int nFileSizeHigh;
            public int nFileSizeLow;
            public int dwReserved0;
            public int dwReserved1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
            public char[] fileName;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
            public char[] alternateFileName;
        }
    }

    public static class WININET
    {
        public const int ERROR_INTERNET_EXTENDED_ERROR = 0x2ee3;
        public const int FTP_TRANSFER_TYPE_ASCII = 1;
        public const int FTP_TRANSFER_TYPE_BINARY = 2;
        public const int FTP_TRANSFER_TYPE_UNKNOWN = 0;
        public const int INTERNET_DEFAULT_FTP_PORT = 0x15;
        public const int INTERNET_ERROR_BASE = 0x2ee0;
        public const int INTERNET_FLAG_ASYNC = 0x10000000;
        public const int INTERNET_FLAG_FROM_CACHE = 0x1000000;
        public const int INTERNET_FLAG_HYPERLINK = 0x400;
        public const int INTERNET_FLAG_NEED_FILE = 0x10;
        public const int INTERNET_FLAG_NO_CACHE_WRITE = 0x4000000;
        public const int INTERNET_FLAG_OFFLINE = 0x1000000;
        public const int INTERNET_FLAG_PASSIVE = 0x8000000;
        public const int INTERNET_FLAG_RELOAD = 8;
        public const int INTERNET_FLAG_RESYNCHRONIZE = 0x800;
        public const int INTERNET_FLAG_SYNC = 4;
        public const int INTERNET_NO_CALLBACK = 0;
        public const int INTERNET_OPEN_TYPE_DIRECT = 1;
        public const int INTERNET_OPEN_TYPE_PRECONFIG = 0;
        public const int INTERNET_SERVICE_FTP = 1;

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpCommand([In] IntPtr hConnect, [In] bool fExpectResponse, [In] int dwFlags, [In] string command, [In] IntPtr dwContext, [In, Out] ref IntPtr ftpCommand);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpCreateDirectory([In] IntPtr hConnect, [In] string directory);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpDeleteFile([In] IntPtr hConnect, [In] string fileName);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FtpFindFirstFile([In] IntPtr hConnect, [In] string searchFile, [In, Out] ref WINAPI.WIN32_FIND_DATA findFileData, [In] int dwFlags, [In] IntPtr dwContext);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpGetCurrentDirectory([In] IntPtr hConnect, [In, Out] StringBuilder currentDirectory, [In, Out] ref int dwCurrentDirectory);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpGetFile([In] IntPtr hConnect, [In] string remoteFile, [In] string newFile, [In] bool failIfExists, [In] int dwFlagsAndAttributes, [In] int dwFlags, [In] IntPtr dwContext);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpGetFileSize([In] IntPtr hConnect, [In, Out] ref int dwFileSizeHigh);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpOpenFile([In] IntPtr hConnect, [In] string fileName, [In] uint dwAccess, [In] int dwFlags, [In] IntPtr dwContext);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpPutFile([In] IntPtr hConnect, [In] string localFile, [In] string newRemoteFile, [In] int dwFlags, [In] IntPtr dwContext);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpRemoveDirectory([In] IntPtr hConnect, [In] string directory);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpRenameFile([In] IntPtr hConnect, [In] string existingName, [In] string newName);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpSetCurrentDirectory([In] IntPtr hConnect, [In] string directory);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int InternetCloseHandle([In] IntPtr hInternet);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr InternetConnect([In] IntPtr hInternet, [In] string serverName, [In] int serverPort, [In] string userName, [In] string password, [In] int dwService, [In] int dwFlags, [In] IntPtr dwContext);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int InternetFindNextFile([In] IntPtr hInternet, [In, Out] ref WINAPI.WIN32_FIND_DATA findData);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int InternetGetLastResponseInfo([In, Out] ref int dwError, [Out, MarshalAs(UnmanagedType.LPTStr)] StringBuilder buffer, [In, Out] ref int bufferLength);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr InternetOpen([In] string agent, [In] int dwAccessType, [In] string proxyName, [In] string proxyBypass, [In] int dwFlags);
        [DllImport("wininet.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int InternetReadFile([In] IntPtr hConnect, [In, Out, MarshalAs(UnmanagedType.LPTStr)] StringBuilder buffer, [In] int buffCount, [In, Out] ref int bytesRead);
        [DllImport("wininet.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int InternetReadFileEx([In] IntPtr hFile, [In, Out] ref WINAPI.INTERNET_BUFFERS lpBuffersOut, [In] int dwFlags, [In, Out] int dwContext);
    }
}
