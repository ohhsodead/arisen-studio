using System;
using System.IO;

namespace ModioX.Net
{
    public class FtpDirectoryInfo : FileSystemInfo
    {
        public FtpDirectoryInfo(FtpConnection ftp, string path)
        {
            FtpConnection = ftp;
            FullPath = path;
        }

        public FtpConnection FtpConnection { get; }

        public new DateTime? LastAccessTime { get; internal set; }

        public new DateTime? CreationTime { get; internal set; }

        public new DateTime? LastWriteTime { get; internal set; }

        public new DateTime? LastAccessTimeUtc => LastAccessTime?.ToUniversalTime();

        public new DateTime? CreationTimeUtc => CreationTime?.ToUniversalTime();

        public new DateTime? LastWriteTimeUtc => LastWriteTime?.ToUniversalTime();

        public new FileAttributes Attributes { get; internal set; }

        public override bool Exists => FtpConnection.DirectoryExists(FullName);

        public override string Name => Path.GetFileName(FullPath);

        public override void Delete()
        {
            try
            {
                FtpConnection.RemoveDirectory(Name);
            }
            catch (FtpException ex)
            {
                throw new Exception("Unable to delete directory.", ex);
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

        public FtpFileInfo[] GetFiles(string mask)
        {
            return FtpConnection.GetFiles(mask);
        }
    }
}