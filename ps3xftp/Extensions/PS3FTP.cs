using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace Ps3Xftp.Extensions
{
    public class Ps3Ftp : IDisposable
    {
        private bool _disposed;
        private IntPtr _hConnect;
        private IntPtr _hInternet;
        private readonly string _password;
        private readonly string _username;

        public Ps3Ftp(string host)
        {
            _username = "";
            _password = "";
            Port = 0x15;
            Host = host;
            Open();
            Login();
        }

        public Ps3Ftp(string host, int port)
        {
            _username = "";
            _password = "";
            Port = 0x15;
            Host = host;
            Port = port;
            Open();
            Login();
        }

        public Ps3Ftp(string host, string username, string password)
        {
            _username = "";
            _password = "";
            Port = 0x15;
            Host = host;
            _username = username;
            _password = password;
            Open();
            Login();
        }

        public Ps3Ftp(string host, int port, string username, string password)
        {
            _username = "";
            _password = "";
            Port = 0x15;
            Host = host;
            Port = port;
            _username = username;
            _password = password;
        }

        public void Close()
        {
            Dispose();
        }

        public bool IsConnected { get; private set; }

        public void CreateDirectory(string path)
        {
            if (Wininet.FtpCreateDirectory(_hConnect, path) == 0) Error();
        }

        public bool DirectoryExists(string path)
        {
            bool flag;
            var findFileData = new WinApi.Win32FindData();
            var hInternet = Wininet.FtpFindFirstFile(_hConnect, path, ref findFileData, 0x4000000, IntPtr.Zero);
            try
            {
                if (hInternet == IntPtr.Zero) return false;
                flag = true;
            }
            finally
            {
                if (hInternet != IntPtr.Zero) Wininet.InternetCloseHandle(hInternet);
            }

            return flag;
        }

        public void Dispose()
        {
            if (_disposed) return;
            if (_hConnect != IntPtr.Zero) Wininet.InternetCloseHandle(_hConnect);
            if (_hInternet != IntPtr.Zero) Wininet.InternetCloseHandle(_hInternet);
            _hInternet = IntPtr.Zero;
            _hConnect = IntPtr.Zero;
            _disposed = true;
            GC.SuppressFinalize(this);
        }

        private void Error()
        {
            var code = Marshal.GetLastWin32Error();
            if (code != 0x2ee3) throw new Win32Exception(code);
            var message = InternetLastResponseInfo(ref code);
            throw new FtpException(code, message);
        }

        public bool FileExists(string path)
        {
            bool flag;
            var findFileData = new WinApi.Win32FindData();
            var hInternet = Wininet.FtpFindFirstFile(_hConnect, path, ref findFileData, 0x4000000, IntPtr.Zero);
            try
            {
                if (hInternet == IntPtr.Zero) return false;
                flag = true;
            }
            finally
            {
                if (hInternet != IntPtr.Zero) Wininet.InternetCloseHandle(hInternet);
            }

            return flag;
        }

        ~Ps3Ftp()
        {
            Dispose();
        }

        public string GetCurrentDirectory()
        {
            var capacity = 0x105;
            var currentDirectory = new StringBuilder(capacity);
            if (Wininet.FtpGetCurrentDirectory(_hConnect, currentDirectory, ref capacity) != 0)
                return currentDirectory.ToString();
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
            var findFileData = new WinApi.Win32FindData();
            var hInternet = Wininet.FtpFindFirstFile(_hConnect, path, ref findFileData, 0x4000000, IntPtr.Zero);
            try
            {
                var list = new List<FtpDirectoryInfo>();
                if (hInternet == IntPtr.Zero)
                {
                    if (Marshal.GetLastWin32Error() != 0x12) Error();
                    return list.ToArray();
                }

                if ((findFileData.dfFileAttributes & 0x10) == 0x10)
                {
                    var item = new FtpDirectoryInfo(this, new string(findFileData.fileName).TrimEnd(new char[1]))
                    {
                        LastAccessTime = findFileData.ftLastAccessTime.ToDateTime(),
                        LastWriteTime = findFileData.ftLastWriteTime.ToDateTime(),
                        CreationTime = findFileData.ftCreationTime.ToDateTime(),
                        Attributes = (FileAttributes) findFileData.dfFileAttributes
                    };
                    list.Add(item);
                }

                for (findFileData = new WinApi.Win32FindData();
                    Wininet.InternetFindNextFile(hInternet, ref findFileData) != 0;
                    findFileData = new WinApi.Win32FindData())
                    if ((findFileData.dfFileAttributes & 0x10) == 0x10)
                    {
                        var info2 = new FtpDirectoryInfo(this, new string(findFileData.fileName).TrimEnd(new char[1]))
                        {
                            LastAccessTime = findFileData.ftLastAccessTime.ToDateTime(),
                            LastWriteTime = findFileData.ftLastWriteTime.ToDateTime(),
                            CreationTime = findFileData.ftCreationTime.ToDateTime(),
                            Attributes = (FileAttributes) findFileData.dfFileAttributes
                        };
                        list.Add(info2);
                    }

                if (Marshal.GetLastWin32Error() != 0x12) Error();
                infoArray = list.ToArray();
            }
            finally
            {
                if (hInternet != IntPtr.Zero) Wininet.InternetCloseHandle(hInternet);
            }

            return infoArray;
        }

        public void GetFile(string remoteFile, bool failIfExists)
        {
            GetFile(remoteFile, remoteFile, failIfExists);
        }

        private void GetFile(string remoteFile, string localFile, bool failIfExists)
        {
            if (Wininet.FtpGetFile(_hConnect, remoteFile, localFile, failIfExists, 0x80, 2, IntPtr.Zero) == 0) Error();
        }

        public FtpFileInfo[] GetFiles()
        {
            return GetFiles(GetCurrentDirectory());
        }

        public FtpFileInfo[] GetFiles(string mask)
        {
            FtpFileInfo[] infoArray;
            var findFileData = new WinApi.Win32FindData();
            var hInternet = Wininet.FtpFindFirstFile(_hConnect, mask, ref findFileData, 0x4000000, IntPtr.Zero);
            try
            {
                var list = new List<FtpFileInfo>();
                if (hInternet == IntPtr.Zero)
                {
                    if (Marshal.GetLastWin32Error() != 0x12) Error();
                    return list.ToArray();
                }

                if ((findFileData.dfFileAttributes & 0x10) != 0x10)
                {
                    var item = new FtpFileInfo(this, new string(findFileData.fileName).TrimEnd(new char[1]))
                    {
                        LastAccessTime = findFileData.ftLastAccessTime.ToDateTime(),
                        LastWriteTime = findFileData.ftLastWriteTime.ToDateTime(),
                        CreationTime = findFileData.ftCreationTime.ToDateTime(),
                        Attributes = (FileAttributes) findFileData.dfFileAttributes
                    };
                    list.Add(item);
                }

                for (findFileData = new WinApi.Win32FindData();
                    Wininet.InternetFindNextFile(hInternet, ref findFileData) != 0;
                    findFileData = new WinApi.Win32FindData())
                    if ((findFileData.dfFileAttributes & 0x10) != 0x10)
                    {
                        var info2 = new FtpFileInfo(this, new string(findFileData.fileName).TrimEnd(new char[1]))
                        {
                            LastAccessTime = findFileData.ftLastAccessTime.ToDateTime(),
                            LastWriteTime = findFileData.ftLastWriteTime.ToDateTime(),
                            CreationTime = findFileData.ftCreationTime.ToDateTime(),
                            Attributes = (FileAttributes) findFileData.dfFileAttributes
                        };
                        list.Add(info2);
                    }

                if (Marshal.GetLastWin32Error() != 0x12) Error();
                infoArray = list.ToArray();
            }
            finally
            {
                if (hInternet != IntPtr.Zero) Wininet.InternetCloseHandle(hInternet);
            }

            return infoArray;
        }

        public long GetFileSize(string file)
        {
            var hConnect = new IntPtr(Wininet.FtpOpenFile(_hConnect, file, 0x80000000, 2, IntPtr.Zero));
            if (hConnect == IntPtr.Zero)
                Error();
            else
                try
                {
                    var dwFileSizeHigh = 0;
                    var num2 = Wininet.FtpGetFileSize(hConnect, ref dwFileSizeHigh);
                    return (dwFileSizeHigh << 0x20) | num2;
                }
                catch (Exception)
                {
                    Error();
                }
                finally
                {
                    Wininet.InternetCloseHandle(hConnect);
                }

            return 0L;
        }

        private static string InternetLastResponseInfo(ref int code)
        {
            var capacity = 0x2000;
            var buffer = new StringBuilder(capacity);
            Wininet.InternetGetLastResponseInfo(ref code, buffer, ref capacity);
            return buffer.ToString();
        }

        private void Login()
        {
            Login(_username, _password);
        }

        private void Login(string username, string password)
        {
            if (username == null)
            {
                IsConnected = false;
                throw new ArgumentNullException(nameof(username));
            }

            if (password == null)
            {
                IsConnected = false;
                throw new ArgumentNullException(nameof(password));
            }

            _hConnect = Wininet.InternetConnect(_hInternet, Host, Port, username, password, 1, 0x8000000, IntPtr.Zero);
            IsConnected = true;
            if (_hConnect == IntPtr.Zero)
            {
                IsConnected = false;
                Error();
            }
        }

        private void Open()
        {
            if (string.IsNullOrEmpty(Host))
            {
                IsConnected = false;
                throw new ArgumentNullException(nameof(Host));
            }

            _hInternet = Wininet.InternetOpen(Environment.UserName, 0, null, null, 4);
            IsConnected = true;
            if (_hInternet != IntPtr.Zero) return;
            IsConnected = false;
            Error();
        }

        public void PutFile(string fileName)
        {
            PutFile(fileName, Path.GetFileName(fileName));
        }

        public void PutFile(string localFile, string remoteFile)
        {
            if (Wininet.FtpPutFile(_hConnect, localFile, remoteFile, 2, IntPtr.Zero) == 0) Error();
        }

        public void RemoveDirectory(string directory)
        {
            if (Wininet.FtpRemoveDirectory(_hConnect, directory) == 0) Error();
        }

        public void RemoveFile(string fileName)
        {
            if (Wininet.FtpDeleteFile(_hConnect, fileName) == 0) Error();
        }

        public void RenameFile(string existingFile, string newFile)
        {
            if (Wininet.FtpRenameFile(_hConnect, existingFile, newFile) == 0) Error();
        }

        public string SendCommand(string cmd)
        {
            int num;
            string str;
            var ftpCommand = new IntPtr();
            if ((str = cmd) != null && str == "PASV")
                num = Wininet.FtpCommand(_hConnect, false, 1, cmd, IntPtr.Zero, ref ftpCommand);
            else
                num = Wininet.FtpCommand(_hConnect, false, 1, cmd, IntPtr.Zero, ref ftpCommand);
            var capacity = 0x2000;
            if (num == 0)
            {
                Error();
            }
            else if (ftpCommand != IntPtr.Zero)
            {
                var buffer = new StringBuilder(capacity);
                var bytesRead = 0;
                while (Wininet.InternetReadFile(ftpCommand, buffer, capacity, ref bytesRead) == 1 && bytesRead > 1)
                {
                }

                return buffer.ToString();
            }

            return "";
        }

        public void SetCurrentDirectory(string directory)
        {
            if (Wininet.FtpSetCurrentDirectory(_hConnect, directory) == 0) Error();
        }

        public string ReadFile(string directory)
        {
            var request = new WebClient();
            var url = "ftp://" + Host + directory;
            var fileString = "";
            try
            {
                var newFileData = request.DownloadData(url);
                fileString = Encoding.UTF8.GetString(newFileData);
            }
            catch
            {
                // ignored
            }

            return fileString;
        }

        public void SetLocalDirectory(string directory)
        {
            if (!Directory.Exists(directory))
                throw new InvalidDataException(string.Format("{0} is not a directory!", directory));
            Environment.CurrentDirectory = directory;
        }

        private string Host { get; }

        private int Port { get; }
    }

    public class FtpDirectoryInfo : FileSystemInfo
    {
        public FtpDirectoryInfo(Ps3Ftp ftp, string path)
        {
            FtpConnection = ftp;
            FullPath = path;
        }

        public override void Delete()
        {
            try
            {
                FtpConnection.RemoveDirectory(Name);
            }
            catch (FtpException exception)
            {
                throw new Exception("Unable to delete directory.", exception);
            }
        }

        public FtpDirectoryInfo[] GetDirectories()
        {
            return FtpConnection.GetDirectories(FullPath);
        }

        public FtpDirectoryInfo[] GetDirectories(string path)
        {
            path = Path.Combine(FullPath, path);
            return FtpConnection.GetDirectories(path);
        }

        public FtpFileInfo[] GetFiles()
        {
            return GetFiles(FtpConnection.GetCurrentDirectory());
        }

        private FtpFileInfo[] GetFiles(string mask)
        {
            return FtpConnection.GetFiles(mask);
        }

        public new DateTime? CreationTime { private get; set; }

        public override bool Exists => FtpConnection.DirectoryExists(FullName);

        private Ps3Ftp FtpConnection { get; }

        public new DateTime? LastAccessTime { get; internal set; }

        public new DateTime? LastWriteTime { get; internal set; }

        public override string Name => Path.GetFileName(FullPath) ?? throw new InvalidOperationException();
    }

    public class FtpFileInfo : FileSystemInfo
    {
        public FtpFileInfo(Ps3Ftp ftp, string filePath)
        {
            OriginalPath = filePath ?? throw new ArgumentNullException(nameof(filePath));
            FullPath = filePath;
            FtpConnection = ftp;
            Name = Path.GetFileName(filePath);
        }

        public override void Delete()
        {
            FtpConnection.RemoveFile(FullName);
        }

        public new FileAttributes Attributes { get; internal set; }

        public new DateTime? CreationTime { get; internal set; }

        public override bool Exists => FtpConnection.FileExists(FullName);

        private Ps3Ftp FtpConnection { get; }

        public new DateTime? LastAccessTime { get; internal set; }

        public new DateTime? LastWriteTime { get; internal set; }

        public override string Name { get; }
    }

    public static class Extensions
    {
        public static DateTime? ToDateTime(this WinApi.FileTime time)
        {
            if (time.dwHighDateTime == 0 && time.dwLowDateTime == 0) return null;
            var dwLowDateTime = (uint) time.dwLowDateTime;
            var fileTime = (time.dwHighDateTime << 0x20) | dwLowDateTime;
            return DateTime.FromFileTimeUtc(fileTime);
        }
    }

    public class FtpException : Exception
    {
        public FtpException(int error, string message)
            : base(message)
        {
            ErrorCode = error;
        }

        private int ErrorCode { get; }
    }

    public static class WinApi
    {
        public const int ErrorNoMoreFiles = 0x12;
        public const int FileAttributeDirectory = 0x10;
        public const int FileAttributeNormal = 0x80;
        public static uint FormatMessageFromHModule { get; } = 0x800;
        public static uint FormatMessageFromSystem { get; } = 0x1000;
        public static uint FormatMessageIgnoreInserts { get; } = 0x200;
        public static uint GenericRead { get; } = 0x80000000;
        public static int MaxPath { get; } = 260;
        public static int NoError { get; } = 0;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern uint FormatMessage(uint dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpBuffer, uint nSize, IntPtr arguments);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int FreeLibrary(IntPtr hModule);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr LoadLibrary([In] [MarshalAs(UnmanagedType.LPTStr)] string lpLibFileName);

        public static string TranslateInternetError(uint errorCode)
        {
            string str;
            var zero = IntPtr.Zero;
            try
            {
                var lpBuffer = new StringBuilder(0xff);
                zero = LoadLibrary("wininet.dll");
                if (FormatMessage(0x1200, zero, errorCode, 0, lpBuffer, (uint) (lpBuffer.Capacity + 1), IntPtr.Zero) !=
                    0) return lpBuffer.ToString();
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
        public struct FileTime
        {
            public readonly int dwLowDateTime;
            public readonly int dwHighDateTime;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct InternetBuffers
        {
            private readonly int dwStructSize;
            private readonly IntPtr Next;
            private readonly string Header;
            private readonly int dwHeadersLength;
            private readonly int dwHeadersTotal;
            private readonly IntPtr lpvBuffer;
            private readonly int dwBufferLength;
            private readonly int dwBufferTotal;
            private readonly int dwOffsetLow;
            private readonly int dwOffsetHigh;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct Win32FindData
        {
            public readonly int dfFileAttributes;
            public FileTime ftCreationTime;
            public FileTime ftLastAccessTime;
            public FileTime ftLastWriteTime;
            private readonly int nFileSizeHigh;
            private readonly int nFileSizeLow;
            private readonly int dwReserved0;
            private readonly int dwReserved1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
            public readonly char[] fileName;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
            private readonly char[] alternateFileName;
        }
    }

    public static class Wininet
    {
        public const int ErrorInternetExtendedError = 0x2ee3;
        public const int FtpTransferTypeAscii = 1;
        public const int FtpTransferTypeBinary = 2;
        public const int FtpTransferTypeUnknown = 0;
        public const int InternetDefaultFtpPort = 0x15;
        public const int InternetErrorBase = 0x2ee0;
        public const int InternetFlagAsync = 0x10000000;
        public const int InternetFlagFromCache = 0x1000000;
        public const int InternetFlagHyperlink = 0x400;
        public const int InternetFlagNeedFile = 0x10;
        public const int InternetFlagNoCacheWrite = 0x4000000;
        public const int InternetFlagOffline = 0x1000000;
        public const int InternetFlagPassive = 0x8000000;
        public const int InternetFlagReload = 8;
        public const int InternetFlagResynchronize = 0x800;
        public const int InternetFlagSync = 4;
        public const int InternetNoCallback = 0;
        public const int InternetOpenTypeDirect = 1;
        public const int InternetOpenTypePreConfig = 0;
        public const int InternetServiceFtp = 1;

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpCommand([In] IntPtr hConnect, [In] bool fExpectResponse, [In] int dwFlags,
            [In] string command, [In] IntPtr dwContext, [In] [Out] ref IntPtr ftpCommand);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpCreateDirectory([In] IntPtr hConnect, [In] string directory);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpDeleteFile([In] IntPtr hConnect, [In] string fileName);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FtpFindFirstFile([In] IntPtr hConnect, [In] string searchFile,
            [In] [Out] ref WinApi.Win32FindData findFileData, [In] int dwFlags, [In] IntPtr dwContext);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpGetCurrentDirectory([In] IntPtr hConnect, [In] [Out] StringBuilder currentDirectory,
            [In] [Out] ref int dwCurrentDirectory);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpGetFile([In] IntPtr hConnect, [In] string remoteFile, [In] string newFile,
            [In] bool failIfExists, [In] int dwFlagsAndAttributes, [In] int dwFlags, [In] IntPtr dwContext);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpGetFileSize([In] IntPtr hConnect, [In] [Out] ref int dwFileSizeHigh);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpOpenFile([In] IntPtr hConnect, [In] string fileName, [In] uint dwAccess,
            [In] int dwFlags, [In] IntPtr dwContext);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpPutFile([In] IntPtr hConnect, [In] string localFile, [In] string newRemoteFile,
            [In] int dwFlags, [In] IntPtr dwContext);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpRemoveDirectory([In] IntPtr hConnect, [In] string directory);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpRenameFile([In] IntPtr hConnect, [In] string existingName, [In] string newName);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int FtpSetCurrentDirectory([In] IntPtr hConnect, [In] string directory);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int InternetCloseHandle([In] IntPtr hInternet);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr InternetConnect([In] IntPtr hInternet, [In] string serverName, [In] int serverPort,
            [In] string userName, [In] string password, [In] int dwService, [In] int dwFlags, [In] IntPtr dwContext);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int InternetFindNextFile([In] IntPtr hInternet,
            [In] [Out] ref WinApi.Win32FindData findData);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int InternetGetLastResponseInfo([In] [Out] ref int dwError,
            [Out] [MarshalAs(UnmanagedType.LPTStr)]
            StringBuilder buffer, [In] [Out] ref int bufferLength);

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr InternetOpen([In] string agent, [In] int dwAccessType, [In] string proxyName,
            [In] string proxyBypass, [In] int dwFlags);

        [DllImport("wininet.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int InternetReadFile([In] IntPtr hConnect, [In] [Out] [MarshalAs(UnmanagedType.LPTStr)]
            StringBuilder buffer, [In] int buffCount, [In] [Out] ref int bytesRead);

        [DllImport("wininet.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int InternetReadFileEx([In] IntPtr hFile,
            [In] [Out] ref WinApi.InternetBuffers lpBuffersOut, [In] int dwFlags, [In] [Out] int dwContext);
    }
}