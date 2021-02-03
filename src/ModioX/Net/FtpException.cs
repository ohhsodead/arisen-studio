using System;

namespace ModioX.Net
{
    public class FtpException : Exception
    {
        public FtpException(int error, string message)
            : base(message)
        {
            ErrorCode = error;
        }

        public int ErrorCode { get; }
    }
}