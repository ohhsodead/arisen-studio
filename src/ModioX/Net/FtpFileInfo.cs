using System;
using System.IO;
// ReSharper disable All

namespace ModioX.Net
{
    public class FtpFileInfo : FileSystemInfo
    {
        private DateTime? _creationTime;

        private DateTime? _lastAccessTime;
        private DateTime? _lastWriteTime;

        public FtpFileInfo(FtpConnection ftp, string filePath)
        {
            OriginalPath = filePath ?? throw new ArgumentNullException("filePath");
            FullPath = filePath;
            FtpConnection = ftp;

            Name = Path.GetFileName(filePath);
        }

        public FtpConnection FtpConnection { get; }

        public new DateTime? LastAccessTime
        {
            get => _lastAccessTime.HasValue ? _lastAccessTime.Value : null;
            internal set => _lastAccessTime = value;
        }

        public new DateTime? CreationTime
        {
            get => _creationTime.HasValue ? _creationTime.Value : null;
            internal set => _creationTime = value;
        }

        public new DateTime? LastWriteTime
        {
            get => _lastWriteTime.HasValue ? _lastWriteTime.Value : null;
            internal set => _lastWriteTime = value;
        }

        public new DateTime? LastAccessTimeUtc => _lastAccessTime.HasValue ? _lastAccessTime.Value.ToUniversalTime() : null;

        public new DateTime? CreationTimeUtc => _creationTime.HasValue ? _creationTime.Value.ToUniversalTime() : null;

        public new DateTime? LastWriteTimeUtc => _lastWriteTime.HasValue ? _lastWriteTime.Value.ToUniversalTime() : null;

        public new FileAttributes Attributes { get; internal set; }

        public override string Name { get; }

        public override bool Exists => FtpConnection.FileExists(FullName);

        public override void Delete()
        {
            FtpConnection.RemoveFile(FullName);
        }
    }
}