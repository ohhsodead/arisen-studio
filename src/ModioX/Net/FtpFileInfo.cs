using System;
using System.IO;

namespace ModioX.Net
{
    public class FtpFileInfo : FileSystemInfo
    {
        public FtpFileInfo(FtpConnection ftp, string filePath)
        {
            OriginalPath = filePath ?? throw new ArgumentNullException("fileName");
            FullPath = filePath;
            FtpConnection = ftp;

            Name = Path.GetFileName(filePath);
        }

        private DateTime? _lastAccessTime;
        private DateTime? _creationTime;
        private DateTime? _lastWriteTime;

        public FtpConnection FtpConnection { get; }

        public new DateTime? LastAccessTime
        {
            get { return _lastAccessTime.HasValue ? _lastAccessTime.Value : null; }
            internal set { _lastAccessTime = value; }
        }

        public new DateTime? CreationTime
        {
            get { return _creationTime.HasValue ? _creationTime.Value : null; }
            internal set { _creationTime = value; }
        }

        public new DateTime? LastWriteTime
        {
            get { return _lastWriteTime.HasValue ? _lastWriteTime.Value : null; }
            internal set { _lastWriteTime = value; }
        }

        public new DateTime? LastAccessTimeUtc
        {
            get { return _lastAccessTime.HasValue ? _lastAccessTime.Value.ToUniversalTime() : null; }
        }

        public new DateTime? CreationTimeUtc
        {
            get { return _creationTime.HasValue ? _creationTime.Value.ToUniversalTime() : null; }
        }

        public new DateTime? LastWriteTimeUtc
        {
            get { return _lastWriteTime.HasValue ? _lastWriteTime.Value.ToUniversalTime() : null; }
        }

        public new FileAttributes Attributes { get; internal set; }

        public override string Name { get; }

        public override void Delete()
        {
            FtpConnection.RemoveFile(FullName);
        }

        public override bool Exists
        {
            get { return FtpConnection.FileExists(FullName); }
        }
    }
}